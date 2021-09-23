using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DayTripper;
using ImageMagick;
using System.IO;
using System.Security;
using DayTripperUI.Enums;
using DTPathfinder.HelperClasses;
using DTPathfinder.Enums;

namespace DayTripperUI
{
    public partial class frmMapViewer : Form
    {
        #region Search State

        private SearchableMap _map;

        private readonly Dictionary<MapType, MagickImage> _mapImages = new Dictionary<MapType, MagickImage>
        {
            { MapType.Elevation, null },
            { MapType.Passability, null },
            { MapType.Water, null },
            { MapType.Road, null }
        };

        private Size imageSize;

        private bool mapReady = false;

        private List<SearchTile> foundPath = null;
        private MagickImage pathImage;

        private Point pathStart => new Point((int)numStartX.Value, (int)numStartY.Value);
        private Point pathGoal => new Point((int)numGoalX.Value, (int)numGoalY.Value);

        #endregion

        #region UI State

        private readonly MagickImage reticleIcon;

        private float zoomFactor = 1f;
        private float invZoomFactor => 1 / zoomFactor;
        private readonly float zoomDelta = .05f;
        private InteractionMode interactionMode;
        private PathPickerTarget currentTarget;

        private bool showPath = true;
        private bool showWater = true;
        private bool showRoads = true;
        private bool showPassability = true;
        private bool showReticles = true;

        static readonly Dictionary<PathPickerTarget, Cursor> CursorFor = new Dictionary<PathPickerTarget, Cursor>()
            {
                { PathPickerTarget.None, Cursors.Default },
                { PathPickerTarget.Goal, Cursors.Cross },
                { PathPickerTarget.Start, Cursors.Cross },
            };

        bool _pendingInitialize
        {
            get => btnInitializeMap.Enabled;
            set => btnInitializeMap.Enabled = value;
        }

        readonly Dictionary<MapType, bool> _loadedAndPendingInitialize = new Dictionary<MapType, bool>
        {
            { MapType.Elevation, false },
            { MapType.Passability, false },
            { MapType.Water, false },
            { MapType.Road, false },
        };

        readonly Dictionary<MapType, Control> _mapLoadingButtons;

        #endregion

        public frmMapViewer()
        {
            InitializeComponent();

            _mapLoadingButtons = new Dictionary<MapType, Control>
            {
                { MapType.Elevation, btnLoadElevation },
                { MapType.Passability, btnLoadPassability },
                { MapType.Water, btnLoadWater },
                { MapType.Road, btnLoadRoads },
            };

            SetAllButtonCaptions();

            workerMapLoad.DoWork += WorkerMapLoad_DoWork;
            workerMapLoad.ProgressChanged += WorkerMapLoad_ProgressChanged;
            workerMapLoad.RunWorkerCompleted += WorkerMapLoad_RunWorkerCompleted;

            workerPathfind.DoWork += WorkerPathfind_DoWork;
            workerPathfind.RunWorkerCompleted += WorkerPathfind_RunWorkerCompleted;

            txtCoords.Text = "";
            pictureBoxMap.MouseMove += PictureBoxMap_MouseMove;
            pictureBoxMap.MouseLeave += PictureBoxMap_MouseLeave;
            pictureBoxMap.MouseClick += PictureBoxMap_MouseClick;

            this.KeyDown += FrmMapViewer_KeyDown;
            this.KeyUp += FrmMapViewer_KeyUp;
            pictureBoxMap.MouseWheel += PictureBoxMap_MouseWheel;

            var ss = new SearchSettings();
            numDistanceWeight.Value = (decimal)ss.CrowDistanceWeight;

            numTerrainStepCost.Value = (decimal)ss.RoughTerrainStepCost;
            numUphillPenalty.Value = (decimal)ss.UphillPenalty;
            numDownhillPenalty.Value = (decimal)ss.DownhillPenalty;

            numWaterStepCost.Value = (decimal)ss.WaterStepCost;
            numWaterEnterPenalty.Value = (decimal)ss.WaterEnterPenalty;
            numWaterExitPenalty.Value = (decimal)ss.WaterExitPenalty;

            numRoadStepCost.Value = (decimal)ss.RoadStepCost;
            numRoadExitPenalty.Value = (decimal)ss.RoadExitPenalty;

            toolTip.SetToolTip(numDistanceWeight, "How much to prefer short paths.\nHigher values take less time to compute, but often result in uglier paths.");

            toolTip.SetToolTip(numTerrainStepCost, "Cost of each step while traveling rough terrain");
            toolTip.SetToolTip(numWaterStepCost, "Cost of each step while traveling on water");
            toolTip.SetToolTip(numRoadStepCost, "Cost of each step while traveling on a road");

            toolTip.SetToolTip(numUphillPenalty, "How much to avoid going up hill\nHigher values avoid upward slopes more.\nValues less than 1 will reduce the penalty");
            toolTip.SetToolTip(numDownhillPenalty, "How much to avoid going down hill\nHigher values avoid downward slopes low ground more.\nValues less than 1 will reduce the penalty");

            toolTip.SetToolTip(numWaterEnterPenalty, "How much to avoid entering water while on land");
            toolTip.SetToolTip(numWaterExitPenalty, "How much to avoid exiting water while already on water");

            //toolTip.SetToolTip(numRoadEnterPenalty, "How much to avoid entering a road while on land");
            toolTip.SetToolTip(numRoadExitPenalty, "How much to avoid exiting a road");

            btnFindPath.Enabled = false;

            dlgOpenMap.Filter = "PNG|*.png|BMP|*.bmp|JPG|*.jpg|GIF|*.gif";
            dlgSave.Filter = "PNG|*.png";
            dlgSave.AddExtension = true;
            dlgSave.DefaultExt = "png";

            reticleIcon = new MagickImage(new MagickFactory().Image.Create(Properties.Resources.reticle));
            reticleIcon.Scale(new Percentage(50));

            #region Debugging 

            //static void DebugMap(AStarMap map, SearchTile current, SearchCandidateCollection candidateTiles, int closedCount, Point targetPoint, DebugSettings debugSettings)
            //{
            //    using var img = new MagickImage(MagickColors.Transparent, map.Width, map.Height);
            //    using (var pixels = img.GetPixels())
            //    {
            //        //foreach (var loc in visitedLocations)
            //        //{
            //        //    pixels.SetPixel(loc.X, loc.Y, DebugSettings.Orange);
            //        //}
            //        foreach (var tile in candidateTiles)
            //        {
            //            pixels.SetPixel(tile.Location.X, tile.Location.Y, DebugSettings.Yellow);
            //        }
            //        foreach (var tile in current.PathBackToStart())
            //        {
            //            pixels.SetPixel(tile.Location.X, tile.Location.Y, DebugSettings.Red);
            //        }

            //        if (debugSettings.OutputPassable)
            //        {
            //            var colors = new Dictionary<bool, byte[]>
            //            {
            //                { true, DebugSettings.PassableColor },
            //                { false, DebugSettings.ImpassableColor },
            //            };

            //            for (var x = 0; x < map.Width; x++)
            //            {
            //                for (var y = 0; y < map.Height; y++)
            //                {
            //                    pixels.SetPixel(x, y, colors[map[x, y].Passable]);
            //                }
            //            }
            //        }

            //        pixels.SetPixel(targetPoint.X, targetPoint.Y, DebugSettings.Magenta);

            //    }
            //    img.Write(Path.Join(debugSettings.DebugOutputDirectory, $"debug_{closedCount}.png"));
            //}

            //var debugSettings = new DebugSettings()
            //{
            //    report = DebugMap
            //};

            #endregion

        }

        #region PictureBox Controls

        private void PictureBoxMap_MouseWheel(object sender, MouseEventArgs e)
        {
            if (interactionMode == InteractionMode.Zoom)
            {
                zoomFactor += e.Delta > 1 ? zoomDelta : -zoomDelta;
                SetDisplayImage();
                ((HandledMouseEventArgs)e).Handled = true;
            }
            else
            {
                base.OnMouseWheel(e);
            }
        }

        private void FrmMapViewer_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                interactionMode = InteractionMode.None;
                SetCursor();
            }
            else if (e.KeyCode == Keys.Menu)
            {
                interactionMode = InteractionMode.None;
                SetCursor();
            }
        }

        private void FrmMapViewer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                interactionMode = InteractionMode.Pan;
                pictureBoxMap.Cursor = Cursors.NoMove2D;
            }
            else if (e.KeyCode == Keys.Menu)
            {
                interactionMode = InteractionMode.Zoom;
                pictureBoxMap.Cursor = Cursors.SizeAll;
            }
        }
        private void PictureBoxMap_MouseClick(object sender, MouseEventArgs e)
        {
            if (currentTarget == PathPickerTarget.None) return;

            if (currentTarget == PathPickerTarget.Start)
            {
                numStartX.Value = (int)Math.Round(e.X * (1 / zoomFactor));
                numStartY.Value = (int)Math.Round(e.Y * (1 / zoomFactor));
            }
            else
            {
                numGoalX.Value = (int)Math.Round(e.X * (1 / zoomFactor));
                numGoalY.Value = (int)Math.Round(e.Y * (1 / zoomFactor));
            }

            SetDisplayImage();
            SetCursor();
            currentTarget = PathPickerTarget.None;
        }

        private void PictureBoxMap_MouseLeave(object sender, EventArgs e)
        {
            txtCoords.Text = "";
        }

        private void PictureBoxMap_MouseMove(object sender, MouseEventArgs e)
        {
            txtCoords.Text = $"({(int)Math.Round(e.X * invZoomFactor)},{(int)Math.Round(e.Y * invZoomFactor)})";
        }
        private void SetCursor()
        {
            pictureBoxMap.Cursor = CursorFor[currentTarget];
        }

        #endregion

        #region Initialize Map

        private void InitializeMap()
        {
            if (workerMapLoad.IsBusy) return;

            mapReady = false;
            btnFindPath.Enabled = false;

            statusProgressBar.Visible = true;
            statusProgressBar.Maximum = imageSize.Width * imageSize.Height;
            txtProgressStatus.Text = "Initializing Map for Search";

            _pendingInitialize = false;
            btnInitializeMap.Text = "Initializing Map...";
            foreach (var type in _mapLoadingButtons.Keys)
            {
                _mapLoadingButtons[type].Enabled = false;
            }

            workerMapLoad.RunWorkerAsync();
        }

        private void WorkerMapLoad_DoWork(object sender, DoWorkEventArgs e)
        {
            var elevationMap = new MapMatrix(_mapImages[MapType.Elevation]);
            var passabilityMap = new MapMatrix(_mapImages[MapType.Passability], defaultValue: true);
            var waterMap = new MapMatrix(_mapImages[MapType.Water], defaultValue: false);
            var roadMap = new MapMatrix(_mapImages[MapType.Road], defaultValue: false);

            BackgroundWorker worker = sender as BackgroundWorker;
            _map = new SearchableMap(
                elevationMap,
                passabilityMap,
                waterMap,
                roadMap,
                imageSize,
                worker.ReportProgress);
        }

        private void WorkerMapLoad_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            statusProgressBar.Visible = false;
            txtProgressStatus.Text = "";
            statusProgressBar.Value = 0;

            mapReady = true;
            btnFindPath.Text = "Find Path";
            btnFindPath.Enabled = true;
            btnFindPath.BackColor = Color.GreenYellow;

            _pendingInitialize = false;
            _loadedAndPendingInitialize[MapType.Elevation] = false;
            _loadedAndPendingInitialize[MapType.Passability] = false;
            _loadedAndPendingInitialize[MapType.Water] = false;
            _loadedAndPendingInitialize[MapType.Road] = false;

            foreach (var type in _mapLoadingButtons.Keys)
            {
                _mapLoadingButtons[type].Enabled = true;
            }

            btnInitializeMap.Text = "Initialize Loaded Map";

            SetAllButtonCaptions();
        }

        private void WorkerMapLoad_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            statusProgressBar.Value = e.ProgressPercentage;
        }

        #endregion

        private void btnFindPath_Click(object sender, EventArgs e)
        {
            if (!mapReady)
            {
                MessageBox.Show("Map Not Yet Ready");
                return;
            }

            foundPath = null;
            pathImage = null;
            txtProgressStatus.Text = "Finding Path...";
            workerPathfind.RunWorkerAsync();
        }


        private void WorkerPathfind_DoWork(object sender, DoWorkEventArgs e)
        {
            void progress(int crowDistance, int candidateCount, int closedCount)
            {
                txtProgressStatus.Text = $"Distance: {crowDistance,-10:#,###} Active: {candidateCount,-10:#,###} Visited: {closedCount,-10:#,###}";
            }

            var searchSettings = new SearchSettings()
            {
                CrowDistanceWeight = (float)numDistanceWeight.Value,

                RoughTerrainStepCost = (float)numTerrainStepCost.Value,
                UphillPenalty = (float)numUphillPenalty.Value,
                DownhillPenalty = (float)numDownhillPenalty.Value,

                WaterStepCost = (float)numWaterStepCost.Value,
                WaterEnterPenalty = (float)numWaterEnterPenalty.Value,
                WaterExitPenalty = (float)numWaterExitPenalty.Value,

                RoadStepCost = (float)numRoadStepCost.Value,
                RoadExitPenalty = (float)numRoadExitPenalty.Value,
            };

            foundPath = AStar.FindPath(_map, pathStart, pathGoal, searchSettings, progress, new DebugSettings());
        }

        private void WorkerPathfind_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (foundPath != null)
            {
                txtProgressStatus.Text = "Path Found";
                GeneratatePathImage(foundPath);
                SetDisplayImage(forceRefresh: true);
            }
            else
            {
                txtProgressStatus.Text = "No Path Found";
                pathImage = null;
                SetDisplayImage(forceRefresh: true);
            }
        }


        private void WorkerPathfind_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void GeneratatePathImage(List<SearchTile> path)
        {
            var img = new MagickImage(MagickColors.Transparent, imageSize.Width, imageSize.Height);
            using (var pixels = img.GetPixels())
            {
                foreach (var tile in path)
                {
                    pixels.SetPixel(tile.Location.X, tile.Location.Y, DebugSettings.Red);
                }
            }
            pathImage = img;
        }


        void SetDisplayImage(bool forceRefresh = false)
        {
            if (forceRefresh) _cachedComposite = null;

            var display = GenerateCompositeImage();
            
            pictureBoxMap.Image = display.ToBitmap();

            pictureBoxMap.Width = (int)Math.Round(imageSize.Width * zoomFactor);
            pictureBoxMap.Height = (int)Math.Round(imageSize.Height * zoomFactor);
            txtZoom.Text = $"{zoomFactor * 100:###}%";

            numStartX.Maximum = display.Width;
            numStartY.Maximum = display.Height;
            numGoalX.Maximum = display.Width;
            numGoalY.Maximum = display.Height;
            
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dlgSave.ShowDialog() == DialogResult.OK)
            {
                if (!CheckExtension(dlgSave.FileName)) return;

                var comp = GenerateCompositeImage(showReticles: false);
                comp.Write(dlgSave.FileName);
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (pathImage != null && dlgSave.ShowDialog() == DialogResult.OK)
            {
                if (!CheckExtension(dlgSave.FileName)) return;

                pathImage.Write(dlgSave.FileName);
            }
        }

        bool CheckExtension(string fileName)
        {
            if (!fileName.EndsWith(".png"))
            {
                MessageBox.Show("Please only save as .png file", "Error Saving File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private MagickImage GenerateCompositeImage()
        {
            return GenerateCompositeImage(showReticles);
        }

        readonly Dictionary<MapType, MagickColor> _layerColors = new Dictionary<MapType, MagickColor> {
            { MapType.Passability, MagickColors.PaleVioletRed },
            { MapType.Water, MagickColors.LightBlue },
            { MapType.Road, MagickColors.GreenYellow },
            };

        Dictionary<MapType, IMagickImage> _cachedColoredLayers = new Dictionary<MapType, IMagickImage> {
            { MapType.Passability, null },
            { MapType.Water, null },
            { MapType.Road, null },
            };

        private IMagickImage GetColoredLayer(MapType mapType)
        {
            if(_cachedColoredLayers[mapType] == null)
            {
                using (var color = new MagickImage(_layerColors[mapType], imageSize.Width, imageSize.Height))
                {
                    var compositeOp = mapType == MapType.Passability ? CompositeOperator.Lighten : CompositeOperator.Darken;
                    var coloredMap = _mapImages[mapType].Clone();
                    coloredMap.Composite(color, compositeOp);
                    _cachedColoredLayers[mapType] = coloredMap;
                }
            }

            return _cachedColoredLayers[mapType];
        }

        MagickImage _cachedComposite;

        MagickImage GetLayeredImage()
        {
            if(_cachedComposite == null)
            {
                var composite = new MagickImage(_mapImages[MapType.Elevation]);

                if (_mapImages[MapType.Water] != null && showWater)
                {
                    composite.Composite(GetColoredLayer(MapType.Water), CompositeOperator.Screen);
                }

                if (_mapImages[MapType.Road] != null && showRoads)
                {
                    composite.Composite(GetColoredLayer(MapType.Road), CompositeOperator.Screen);
                }

                if (pathImage != null && showPath)
                {
                    composite.Composite(pathImage, CompositeOperator.Atop);
                }

                if (_mapImages[MapType.Passability] != null && showPassability)
                {
                    composite.Composite(GetColoredLayer(MapType.Passability), CompositeOperator.Multiply);
                }

                _cachedComposite = composite;
            }

            return _cachedComposite;
        }

        private MagickImage GenerateCompositeImage(bool showReticles = true)
        {
            var composite = new MagickImage(GetLayeredImage());

            if (showReticles)
            {
                var sizedReticle = reticleIcon.Clone();
                sizedReticle.Scale((int)Math.Round(reticleIcon.Width * invZoomFactor), (int)Math.Round(reticleIcon.Height * invZoomFactor));
                composite.Composite(sizedReticle, pathStart.X - sizedReticle.Width / 2, pathStart.Y - sizedReticle.Height / 2, CompositeOperator.Atop);
                composite.Composite(sizedReticle, pathGoal.X - sizedReticle.Width / 2, pathGoal.Y - sizedReticle.Height / 2, CompositeOperator.Atop);
            }

            return composite;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO: Check if Saved
            Environment.Exit(0);
        }

        private void btnSelectStart_Click(object sender, EventArgs e)
        {
            currentTarget = PathPickerTarget.Start;
            SetCursor();

        }

        private void btnSelectGoal_Click(object sender, EventArgs e)
        {
            currentTarget = PathPickerTarget.Goal;
            SetCursor();
        }

        private void zoomOutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            zoomFactor /= 2;
            SetDisplayImage();

        }

        private void zoomInToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            zoomFactor *= 2;
            SetDisplayImage();
        }

        private void zoomResetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            zoomFactor = 1f;
            SetDisplayImage();
        }

        private void showPathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPath = showPathToolStripMenuItem.Checked;
            SetDisplayImage(forceRefresh: true);
        }

        private void showPassabilityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPassability = showPassabilityToolStripMenuItem.Checked;
            SetDisplayImage(forceRefresh: true);

        }

        private void showWaterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showWater = showWaterToolStripMenuItem.Checked;
            SetDisplayImage(forceRefresh: true);

        }

        private void showRoadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showRoads = showRoadToolStripMenuItem.Checked;
            SetDisplayImage(forceRefresh: true);
        }

        private void showStartGoalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showReticles = showStartGoalToolStripMenuItem.Checked;
            SetDisplayImage();
        }

        private void btnLoadElevation_Click(object sender, EventArgs e)
        {
            if (!LoadMap(MapType.Elevation)) return;

            grpGoalCoords.Enabled = true;
            grpStartCoords.Enabled = true;

            foreach (var type in _mapLoadingButtons.Keys)
                _mapLoadingButtons[type].Enabled = true;
        }

        private void btnLoadPassability_Click(object sender, EventArgs e)
        {
            LoadMap(MapType.Passability);
        }

        private void btnLoadWater_Click(object sender, EventArgs e)
        {
            LoadMap(MapType.Water);
        }

        private void btnLoadRoads_Click(object sender, EventArgs e)
        {
            LoadMap(MapType.Road);
        }

        private bool LoadMap(MapType mapType)
        {
            dlgOpenMap.Title = $"Open {mapType} Map";

            if (dlgOpenMap.ShowDialog() != DialogResult.OK) return false;
                        
            MagickImage potentialMap;
            try
            {
                var mapPath = dlgOpenMap.FileName;
                potentialMap = new MagickImage(mapPath);
            }
            catch (SecurityException ex)
            {
                MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                $"Details:\n\n{ex.StackTrace}");
                return false;
            }

            if(mapType != MapType.Elevation)
            {
                if (_mapImages[MapType.Elevation] == null)
                {
                    MessageBox.Show("Load Failed: load elevation map first");
                    return false;
                }
                    
                if (!SizeMatchesElevation(potentialMap))
                {
                    MessageBox.Show("Load Failed: all maps must be the same pixel dimensions as the elevation map");
                    return false;
                }
                _cachedColoredLayers[mapType] = null;
            }

            _mapImages[mapType] = potentialMap;

            if (mapType == MapType.Elevation)
            {
                imageSize = new Size(potentialMap.Width, potentialMap.Height);
                EnsureAllMapsSameSize();
            }
                
            SetDisplayImage(forceRefresh: true);
            _pendingInitialize = true;
            _loadedAndPendingInitialize[mapType] = true;
            SetAllButtonCaptions();
            return true;
        }

        bool SizeMatchesElevation(MagickImage img)
        {
            return imageSize.Width == img.Width && imageSize.Height == img.Height;
        }

        private void EnsureAllMapsSameSize()
        {
            foreach (var type in new MapType[]{MapType.Passability, MapType.Water, MapType.Road})
            {
                if (_mapImages[type] == null) continue;
                if(!SizeMatchesElevation(_mapImages[type])) {
                    _mapImages[type] = null;
                    _pendingInitialize = true;
                    _loadedAndPendingInitialize[type] = false;
                }
            }
        }

        private void btnInitializeMap_Click(object sender, EventArgs e)
        {
            InitializeMap();
        }

        private void SetAllButtonCaptions()
        {
            foreach(var mapType in _mapLoadingButtons.Keys)
            {
                var state = _mapImages[mapType] == null
                ? "None"
                : _loadedAndPendingInitialize[mapType]
                    ? "Loaded"
                    : "Initialized";

                _mapLoadingButtons[mapType].Text = $"Load {mapType} Map ({state})";
            }
        }
    }
}
