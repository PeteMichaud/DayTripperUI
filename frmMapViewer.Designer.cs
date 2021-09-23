namespace DayTripperUI
{
    partial class frmMapViewer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.workerMapLoad = new System.ComponentModel.BackgroundWorker();
            this.workerPathfind = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomOutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomInToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomResetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.showPathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showWaterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showRoadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPassibilityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showStartGoalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnFindPath = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.numRoadExitPenalty = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.numUphillPenalty = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numDownhillPenalty = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numWaterExitPenalty = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.numWaterEnterPenalty = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numTerrainStepCost = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numWaterStepCost = new System.Windows.Forms.NumericUpDown();
            this.numRoadStepCost = new System.Windows.Forms.NumericUpDown();
            this.numDistanceWeight = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.grpGoalCoords = new System.Windows.Forms.GroupBox();
            this.numGoalY = new System.Windows.Forms.NumericUpDown();
            this.numGoalX = new System.Windows.Forms.NumericUpDown();
            this.btnSelectGoal = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grpStartCoords = new System.Windows.Forms.GroupBox();
            this.numStartY = new System.Windows.Forms.NumericUpDown();
            this.numStartX = new System.Windows.Forms.NumericUpDown();
            this.btnSelectStart = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpMaps = new System.Windows.Forms.GroupBox();
            this.btnInitializeMap = new System.Windows.Forms.Button();
            this.btnLoadRoads = new System.Windows.Forms.Button();
            this.btnLoadWater = new System.Windows.Forms.Button();
            this.btnLoadPassibility = new System.Windows.Forms.Button();
            this.btnLoadElevation = new System.Windows.Forms.Button();
            this.pictureBoxMap = new System.Windows.Forms.PictureBox();
            this.dlgOpenMap = new System.Windows.Forms.OpenFileDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.txtProgressStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblSpacer = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtCoords = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtZoom = new System.Windows.Forms.ToolStripStatusLabel();
            this.dlgSave = new System.Windows.Forms.SaveFileDialog();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRoadExitPenalty)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUphillPenalty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDownhillPenalty)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWaterExitPenalty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWaterEnterPenalty)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTerrainStepCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWaterStepCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRoadStepCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDistanceWeight)).BeginInit();
            this.grpGoalCoords.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGoalY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGoalX)).BeginInit();
            this.grpStartCoords.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStartY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStartX)).BeginInit();
            this.grpMaps.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMap)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // workerMapLoad
            // 
            this.workerMapLoad.WorkerReportsProgress = true;
            // 
            // workerPathfind
            // 
            this.workerPathfind.WorkerReportsProgress = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1250, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.toolStripMenuItem2,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.saveToolStripMenuItem.Text = "Save Composite Image";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(245, 26);
            this.toolStripMenuItem2.Text = "Save Path Image";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(242, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoomOutToolStripMenuItem1,
            this.zoomInToolStripMenuItem1,
            this.zoomResetToolStripMenuItem,
            this.toolStripSeparator2,
            this.showPathToolStripMenuItem,
            this.showWaterToolStripMenuItem,
            this.showRoadToolStripMenuItem,
            this.showPassibilityToolStripMenuItem,
            this.showStartGoalToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // zoomOutToolStripMenuItem1
            // 
            this.zoomOutToolStripMenuItem1.Name = "zoomOutToolStripMenuItem1";
            this.zoomOutToolStripMenuItem1.Size = new System.Drawing.Size(227, 26);
            this.zoomOutToolStripMenuItem1.Text = "Zoom Out";
            this.zoomOutToolStripMenuItem1.Click += new System.EventHandler(this.zoomOutToolStripMenuItem1_Click);
            // 
            // zoomInToolStripMenuItem1
            // 
            this.zoomInToolStripMenuItem1.Name = "zoomInToolStripMenuItem1";
            this.zoomInToolStripMenuItem1.Size = new System.Drawing.Size(227, 26);
            this.zoomInToolStripMenuItem1.Text = "Zoom In";
            this.zoomInToolStripMenuItem1.Click += new System.EventHandler(this.zoomInToolStripMenuItem1_Click);
            // 
            // zoomResetToolStripMenuItem
            // 
            this.zoomResetToolStripMenuItem.Name = "zoomResetToolStripMenuItem";
            this.zoomResetToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.zoomResetToolStripMenuItem.Text = "Zoom Reset";
            this.zoomResetToolStripMenuItem.Click += new System.EventHandler(this.zoomResetToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(224, 6);
            // 
            // showPathToolStripMenuItem
            // 
            this.showPathToolStripMenuItem.Checked = true;
            this.showPathToolStripMenuItem.CheckOnClick = true;
            this.showPathToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showPathToolStripMenuItem.Name = "showPathToolStripMenuItem";
            this.showPathToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.showPathToolStripMenuItem.Text = "Show Path";
            this.showPathToolStripMenuItem.Click += new System.EventHandler(this.showPathToolStripMenuItem_Click);
            // 
            // showWaterToolStripMenuItem
            // 
            this.showWaterToolStripMenuItem.Checked = true;
            this.showWaterToolStripMenuItem.CheckOnClick = true;
            this.showWaterToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showWaterToolStripMenuItem.Name = "showWaterToolStripMenuItem";
            this.showWaterToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.showWaterToolStripMenuItem.Text = "Show Water";
            this.showWaterToolStripMenuItem.Click += new System.EventHandler(this.showWaterToolStripMenuItem_Click);
            // 
            // showRoadToolStripMenuItem
            // 
            this.showRoadToolStripMenuItem.Checked = true;
            this.showRoadToolStripMenuItem.CheckOnClick = true;
            this.showRoadToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showRoadToolStripMenuItem.Name = "showRoadToolStripMenuItem";
            this.showRoadToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.showRoadToolStripMenuItem.Text = "Show Road";
            this.showRoadToolStripMenuItem.Click += new System.EventHandler(this.showRoadToolStripMenuItem_Click);
            // 
            // showPassibilityToolStripMenuItem
            // 
            this.showPassibilityToolStripMenuItem.Checked = true;
            this.showPassibilityToolStripMenuItem.CheckOnClick = true;
            this.showPassibilityToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showPassibilityToolStripMenuItem.Name = "showPassibilityToolStripMenuItem";
            this.showPassibilityToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.showPassibilityToolStripMenuItem.Text = "Show Passibility";
            this.showPassibilityToolStripMenuItem.Click += new System.EventHandler(this.showPassibilityToolStripMenuItem_Click);
            // 
            // showStartGoalToolStripMenuItem
            // 
            this.showStartGoalToolStripMenuItem.Checked = true;
            this.showStartGoalToolStripMenuItem.CheckOnClick = true;
            this.showStartGoalToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showStartGoalToolStripMenuItem.Name = "showStartGoalToolStripMenuItem";
            this.showStartGoalToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.showStartGoalToolStripMenuItem.Text = "Show Start and Goal";
            this.showStartGoalToolStripMenuItem.Click += new System.EventHandler(this.showStartGoalToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 28);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(this.btnFindPath);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox3);
            this.splitContainer1.Panel1.Controls.Add(this.grpGoalCoords);
            this.splitContainer1.Panel1.Controls.Add(this.grpStartCoords);
            this.splitContainer1.Panel1.Controls.Add(this.grpMaps);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.splitContainer1.Panel2.Controls.Add(this.pictureBoxMap);
            this.splitContainer1.Size = new System.Drawing.Size(1250, 884);
            this.splitContainer1.SplitterDistance = 293;
            this.splitContainer1.TabIndex = 1;
            // 
            // btnFindPath
            // 
            this.btnFindPath.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFindPath.Location = new System.Drawing.Point(3, 809);
            this.btnFindPath.Margin = new System.Windows.Forms.Padding(4);
            this.btnFindPath.Name = "btnFindPath";
            this.btnFindPath.Padding = new System.Windows.Forms.Padding(0, 12, 0, 12);
            this.btnFindPath.Size = new System.Drawing.Size(287, 53);
            this.btnFindPath.TabIndex = 6;
            this.btnFindPath.Text = "Find Path (Map Not Initialized)";
            this.btnFindPath.UseVisualStyleBackColor = true;
            this.btnFindPath.Click += new System.EventHandler(this.btnFindPath_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(3, 385);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(287, 424);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Search Settings";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.numRoadExitPenalty);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox5.Location = new System.Drawing.Point(4, 355);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(279, 61);
            this.groupBox5.TabIndex = 17;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Road";
            // 
            // numRoadExitPenalty
            // 
            this.numRoadExitPenalty.DecimalPlaces = 1;
            this.numRoadExitPenalty.Location = new System.Drawing.Point(159, 22);
            this.numRoadExitPenalty.Margin = new System.Windows.Forms.Padding(4);
            this.numRoadExitPenalty.Name = "numRoadExitPenalty";
            this.numRoadExitPenalty.Size = new System.Drawing.Size(97, 22);
            this.numRoadExitPenalty.TabIndex = 13;
            this.numRoadExitPenalty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(32, 24);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(119, 17);
            this.label13.TabIndex = 12;
            this.label13.Text = "Road Exit Penalty";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.numUphillPenalty);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.numDownhillPenalty);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(4, 270);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(279, 85);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Terrain";
            // 
            // numUphillPenalty
            // 
            this.numUphillPenalty.DecimalPlaces = 1;
            this.numUphillPenalty.Location = new System.Drawing.Point(159, 22);
            this.numUphillPenalty.Margin = new System.Windows.Forms.Padding(4);
            this.numUphillPenalty.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numUphillPenalty.Name = "numUphillPenalty";
            this.numUphillPenalty.Size = new System.Drawing.Size(97, 22);
            this.numUphillPenalty.TabIndex = 4;
            this.numUphillPenalty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 24);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Uphill Penalty";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 54);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Downhill Penalty";
            // 
            // numDownhillPenalty
            // 
            this.numDownhillPenalty.DecimalPlaces = 1;
            this.numDownhillPenalty.Location = new System.Drawing.Point(159, 52);
            this.numDownhillPenalty.Margin = new System.Windows.Forms.Padding(4);
            this.numDownhillPenalty.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numDownhillPenalty.Name = "numDownhillPenalty";
            this.numDownhillPenalty.Size = new System.Drawing.Size(97, 22);
            this.numDownhillPenalty.TabIndex = 5;
            this.numDownhillPenalty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.numWaterExitPenalty);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.numWaterEnterPenalty);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(4, 164);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(279, 106);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Water";
            // 
            // numWaterExitPenalty
            // 
            this.numWaterExitPenalty.DecimalPlaces = 1;
            this.numWaterExitPenalty.Location = new System.Drawing.Point(159, 61);
            this.numWaterExitPenalty.Margin = new System.Windows.Forms.Padding(4);
            this.numWaterExitPenalty.Name = "numWaterExitPenalty";
            this.numWaterExitPenalty.Size = new System.Drawing.Size(97, 22);
            this.numWaterExitPenalty.TabIndex = 11;
            this.numWaterExitPenalty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 63);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 17);
            this.label10.TabIndex = 10;
            this.label10.Text = "Water Exit Penalty";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 33);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Water Enter Penalty";
            // 
            // numWaterEnterPenalty
            // 
            this.numWaterEnterPenalty.DecimalPlaces = 1;
            this.numWaterEnterPenalty.Location = new System.Drawing.Point(159, 31);
            this.numWaterEnterPenalty.Margin = new System.Windows.Forms.Padding(4);
            this.numWaterEnterPenalty.Name = "numWaterEnterPenalty";
            this.numWaterEnterPenalty.Size = new System.Drawing.Size(97, 22);
            this.numWaterEnterPenalty.TabIndex = 9;
            this.numWaterEnterPenalty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numTerrainStepCost);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.numWaterStepCost);
            this.groupBox2.Controls.Add(this.numRoadStepCost);
            this.groupBox2.Controls.Add(this.numDistanceWeight);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(4, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(279, 145);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "General";
            // 
            // numTerrainStepCost
            // 
            this.numTerrainStepCost.Location = new System.Drawing.Point(159, 52);
            this.numTerrainStepCost.Margin = new System.Windows.Forms.Padding(4);
            this.numTerrainStepCost.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numTerrainStepCost.Name = "numTerrainStepCost";
            this.numTerrainStepCost.Size = new System.Drawing.Size(97, 22);
            this.numTerrainStepCost.TabIndex = 16;
            this.numTerrainStepCost.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(32, 54);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(119, 17);
            this.label12.TabIndex = 15;
            this.label12.Text = "Terrain Step Cost";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 114);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "Water Step Cost";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 24);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Distance Weight";
            // 
            // numWaterStepCost
            // 
            this.numWaterStepCost.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numWaterStepCost.Location = new System.Drawing.Point(159, 112);
            this.numWaterStepCost.Margin = new System.Windows.Forms.Padding(4);
            this.numWaterStepCost.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numWaterStepCost.Name = "numWaterStepCost";
            this.numWaterStepCost.Size = new System.Drawing.Size(97, 22);
            this.numWaterStepCost.TabIndex = 7;
            this.numWaterStepCost.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numRoadStepCost
            // 
            this.numRoadStepCost.Location = new System.Drawing.Point(159, 82);
            this.numRoadStepCost.Margin = new System.Windows.Forms.Padding(4);
            this.numRoadStepCost.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numRoadStepCost.Name = "numRoadStepCost";
            this.numRoadStepCost.Size = new System.Drawing.Size(97, 22);
            this.numRoadStepCost.TabIndex = 14;
            this.numRoadStepCost.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numDistanceWeight
            // 
            this.numDistanceWeight.Location = new System.Drawing.Point(159, 22);
            this.numDistanceWeight.Margin = new System.Windows.Forms.Padding(4);
            this.numDistanceWeight.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numDistanceWeight.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.numDistanceWeight.Name = "numDistanceWeight";
            this.numDistanceWeight.Size = new System.Drawing.Size(97, 22);
            this.numDistanceWeight.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(44, 84);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 17);
            this.label11.TabIndex = 13;
            this.label11.Text = "Road Step Cost";
            // 
            // grpGoalCoords
            // 
            this.grpGoalCoords.Controls.Add(this.numGoalY);
            this.grpGoalCoords.Controls.Add(this.numGoalX);
            this.grpGoalCoords.Controls.Add(this.btnSelectGoal);
            this.grpGoalCoords.Controls.Add(this.label3);
            this.grpGoalCoords.Controls.Add(this.label4);
            this.grpGoalCoords.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpGoalCoords.Enabled = false;
            this.grpGoalCoords.Location = new System.Drawing.Point(3, 285);
            this.grpGoalCoords.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpGoalCoords.Name = "grpGoalCoords";
            this.grpGoalCoords.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpGoalCoords.Size = new System.Drawing.Size(287, 100);
            this.grpGoalCoords.TabIndex = 5;
            this.grpGoalCoords.TabStop = false;
            this.grpGoalCoords.Text = "Goal Coords";
            // 
            // numGoalY
            // 
            this.numGoalY.Location = new System.Drawing.Point(33, 54);
            this.numGoalY.Margin = new System.Windows.Forms.Padding(4);
            this.numGoalY.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numGoalY.Name = "numGoalY";
            this.numGoalY.Size = new System.Drawing.Size(100, 22);
            this.numGoalY.TabIndex = 11;
            // 
            // numGoalX
            // 
            this.numGoalX.Location = new System.Drawing.Point(33, 22);
            this.numGoalX.Margin = new System.Windows.Forms.Padding(4);
            this.numGoalX.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numGoalX.Name = "numGoalX";
            this.numGoalX.Size = new System.Drawing.Size(100, 22);
            this.numGoalX.TabIndex = 10;
            // 
            // btnSelectGoal
            // 
            this.btnSelectGoal.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSelectGoal.BackgroundImage = global::DayTripperUI.Properties.Resources.reticle;
            this.btnSelectGoal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSelectGoal.Location = new System.Drawing.Point(140, 24);
            this.btnSelectGoal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSelectGoal.Name = "btnSelectGoal";
            this.btnSelectGoal.Size = new System.Drawing.Size(50, 50);
            this.btnSelectGoal.TabIndex = 9;
            this.btnSelectGoal.UseVisualStyleBackColor = false;
            this.btnSelectGoal.Click += new System.EventHandler(this.btnSelectGoal_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Y";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "X";
            // 
            // grpStartCoords
            // 
            this.grpStartCoords.Controls.Add(this.numStartY);
            this.grpStartCoords.Controls.Add(this.numStartX);
            this.grpStartCoords.Controls.Add(this.btnSelectStart);
            this.grpStartCoords.Controls.Add(this.label2);
            this.grpStartCoords.Controls.Add(this.label1);
            this.grpStartCoords.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpStartCoords.Enabled = false;
            this.grpStartCoords.Location = new System.Drawing.Point(3, 185);
            this.grpStartCoords.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpStartCoords.Name = "grpStartCoords";
            this.grpStartCoords.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpStartCoords.Size = new System.Drawing.Size(287, 100);
            this.grpStartCoords.TabIndex = 2;
            this.grpStartCoords.TabStop = false;
            this.grpStartCoords.Text = "Start Coords";
            // 
            // numStartY
            // 
            this.numStartY.Location = new System.Drawing.Point(33, 55);
            this.numStartY.Margin = new System.Windows.Forms.Padding(4);
            this.numStartY.Name = "numStartY";
            this.numStartY.Size = new System.Drawing.Size(100, 22);
            this.numStartY.TabIndex = 6;
            // 
            // numStartX
            // 
            this.numStartX.Location = new System.Drawing.Point(33, 23);
            this.numStartX.Margin = new System.Windows.Forms.Padding(4);
            this.numStartX.Name = "numStartX";
            this.numStartX.Size = new System.Drawing.Size(100, 22);
            this.numStartX.TabIndex = 5;
            // 
            // btnSelectStart
            // 
            this.btnSelectStart.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSelectStart.BackgroundImage = global::DayTripperUI.Properties.Resources.reticle;
            this.btnSelectStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSelectStart.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSelectStart.Location = new System.Drawing.Point(140, 25);
            this.btnSelectStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSelectStart.Name = "btnSelectStart";
            this.btnSelectStart.Size = new System.Drawing.Size(50, 50);
            this.btnSelectStart.TabIndex = 4;
            this.btnSelectStart.UseVisualStyleBackColor = false;
            this.btnSelectStart.Click += new System.EventHandler(this.btnSelectStart_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Y";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "X";
            // 
            // grpMaps
            // 
            this.grpMaps.Controls.Add(this.btnInitializeMap);
            this.grpMaps.Controls.Add(this.btnLoadRoads);
            this.grpMaps.Controls.Add(this.btnLoadWater);
            this.grpMaps.Controls.Add(this.btnLoadPassibility);
            this.grpMaps.Controls.Add(this.btnLoadElevation);
            this.grpMaps.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpMaps.Location = new System.Drawing.Point(3, 3);
            this.grpMaps.Margin = new System.Windows.Forms.Padding(4);
            this.grpMaps.Name = "grpMaps";
            this.grpMaps.Padding = new System.Windows.Forms.Padding(4);
            this.grpMaps.Size = new System.Drawing.Size(287, 182);
            this.grpMaps.TabIndex = 8;
            this.grpMaps.TabStop = false;
            this.grpMaps.Text = "Maps";
            // 
            // btnInitializeMap
            // 
            this.btnInitializeMap.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInitializeMap.Enabled = false;
            this.btnInitializeMap.Location = new System.Drawing.Point(4, 131);
            this.btnInitializeMap.Margin = new System.Windows.Forms.Padding(4);
            this.btnInitializeMap.Name = "btnInitializeMap";
            this.btnInitializeMap.Size = new System.Drawing.Size(279, 37);
            this.btnInitializeMap.TabIndex = 5;
            this.btnInitializeMap.Text = "Initialize Loaded Maps";
            this.btnInitializeMap.UseVisualStyleBackColor = true;
            this.btnInitializeMap.Click += new System.EventHandler(this.btnInitializeMap_Click);
            // 
            // btnLoadRoads
            // 
            this.btnLoadRoads.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLoadRoads.Enabled = false;
            this.btnLoadRoads.Location = new System.Drawing.Point(4, 103);
            this.btnLoadRoads.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoadRoads.Name = "btnLoadRoads";
            this.btnLoadRoads.Size = new System.Drawing.Size(279, 28);
            this.btnLoadRoads.TabIndex = 4;
            this.btnLoadRoads.Text = "Load Roads";
            this.btnLoadRoads.UseVisualStyleBackColor = true;
            this.btnLoadRoads.Click += new System.EventHandler(this.btnLoadRoads_Click);
            // 
            // btnLoadWater
            // 
            this.btnLoadWater.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLoadWater.Enabled = false;
            this.btnLoadWater.Location = new System.Drawing.Point(4, 75);
            this.btnLoadWater.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoadWater.Name = "btnLoadWater";
            this.btnLoadWater.Size = new System.Drawing.Size(279, 28);
            this.btnLoadWater.TabIndex = 3;
            this.btnLoadWater.Text = "Load Water";
            this.btnLoadWater.UseVisualStyleBackColor = true;
            this.btnLoadWater.Click += new System.EventHandler(this.btnLoadWater_Click);
            // 
            // btnLoadPassibility
            // 
            this.btnLoadPassibility.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLoadPassibility.Enabled = false;
            this.btnLoadPassibility.Location = new System.Drawing.Point(4, 47);
            this.btnLoadPassibility.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoadPassibility.Name = "btnLoadPassibility";
            this.btnLoadPassibility.Size = new System.Drawing.Size(279, 28);
            this.btnLoadPassibility.TabIndex = 2;
            this.btnLoadPassibility.Text = "Load Passibility";
            this.btnLoadPassibility.UseVisualStyleBackColor = true;
            this.btnLoadPassibility.Click += new System.EventHandler(this.btnLoadPassibility_Click);
            // 
            // btnLoadElevation
            // 
            this.btnLoadElevation.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLoadElevation.Location = new System.Drawing.Point(4, 19);
            this.btnLoadElevation.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoadElevation.Name = "btnLoadElevation";
            this.btnLoadElevation.Size = new System.Drawing.Size(279, 28);
            this.btnLoadElevation.TabIndex = 1;
            this.btnLoadElevation.Text = "Load Elevation";
            this.btnLoadElevation.UseVisualStyleBackColor = true;
            this.btnLoadElevation.Click += new System.EventHandler(this.btnLoadElevation_Click);
            // 
            // pictureBoxMap
            // 
            this.pictureBoxMap.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBoxMap.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxMap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxMap.Name = "pictureBoxMap";
            this.pictureBoxMap.Size = new System.Drawing.Size(91, 75);
            this.pictureBoxMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMap.TabIndex = 0;
            this.pictureBoxMap.TabStop = false;
            // 
            // dlgOpenMap
            // 
            this.dlgOpenMap.FileName = "openFileDialog1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusProgressBar,
            this.txtProgressStatus,
            this.lblSpacer,
            this.txtCoords,
            this.txtZoom});
            this.statusStrip1.Location = new System.Drawing.Point(0, 912);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1250, 30);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusProgressBar
            // 
            this.statusProgressBar.Name = "statusProgressBar";
            this.statusProgressBar.Size = new System.Drawing.Size(133, 22);
            // 
            // txtProgressStatus
            // 
            this.txtProgressStatus.Name = "txtProgressStatus";
            this.txtProgressStatus.Size = new System.Drawing.Size(0, 24);
            // 
            // lblSpacer
            // 
            this.lblSpacer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.lblSpacer.Name = "lblSpacer";
            this.lblSpacer.Size = new System.Drawing.Size(990, 24);
            this.lblSpacer.Spring = true;
            // 
            // txtCoords
            // 
            this.txtCoords.Name = "txtCoords";
            this.txtCoords.Size = new System.Drawing.Size(56, 24);
            this.txtCoords.Text = "Coords";
            // 
            // txtZoom
            // 
            this.txtZoom.Name = "txtZoom";
            this.txtZoom.Size = new System.Drawing.Size(49, 24);
            this.txtZoom.Text = "Zoom";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // frmMapViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 942);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmMapViewer";
            this.Text = "Day Tripper Pathfinding Tool";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRoadExitPenalty)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUphillPenalty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDownhillPenalty)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWaterExitPenalty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWaterEnterPenalty)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTerrainStepCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWaterStepCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRoadStepCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDistanceWeight)).EndInit();
            this.grpGoalCoords.ResumeLayout(false);
            this.grpGoalCoords.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGoalY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGoalX)).EndInit();
            this.grpStartCoords.ResumeLayout(false);
            this.grpStartCoords.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStartY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStartX)).EndInit();
            this.grpMaps.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMap)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker workerMapLoad;
        private System.ComponentModel.BackgroundWorker workerPathfind;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox grpGoalCoords;
        private System.Windows.Forms.GroupBox grpStartCoords;
        private System.Windows.Forms.Button btnSelectStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxMap;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.NumericUpDown numGoalY;
        private System.Windows.Forms.NumericUpDown numGoalX;
        private System.Windows.Forms.Button btnSelectGoal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numStartY;
        private System.Windows.Forms.NumericUpDown numStartX;
        private System.Windows.Forms.OpenFileDialog dlgOpenMap;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar statusProgressBar;
        private System.Windows.Forms.ToolStripStatusLabel txtProgressStatus;
        private System.Windows.Forms.Button btnFindPath;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog dlgSave;
        private System.Windows.Forms.ToolStripStatusLabel lblSpacer;
        private System.Windows.Forms.ToolStripStatusLabel txtCoords;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown numDistanceWeight;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.NumericUpDown numDownhillPenalty;
        private System.Windows.Forms.NumericUpDown numUphillPenalty;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomOutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem zoomInToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem zoomResetToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem showPathToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPassibilityToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel txtZoom;
        private System.Windows.Forms.ToolStripMenuItem showStartGoalToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpMaps;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button btnLoadElevation;
        private System.Windows.Forms.Button btnLoadPassibility;
        private System.Windows.Forms.Button btnLoadRoads;
        private System.Windows.Forms.Button btnLoadWater;
        private System.Windows.Forms.Button btnInitializeMap;
        private System.Windows.Forms.ToolStripMenuItem showWaterToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown numWaterExitPenalty;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numWaterEnterPenalty;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numWaterStepCost;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numRoadStepCost;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ToolStripMenuItem showRoadToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.NumericUpDown numRoadExitPenalty;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown numTerrainStepCost;
        private System.Windows.Forms.Label label12;
    }
}

