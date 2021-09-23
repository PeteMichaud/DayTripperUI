using DTPathfinder.HelperClasses;
using System;
using System.Drawing;

namespace DayTripper
{
    public class SearchableMap
    {
        private readonly MapTile[,] _map;
        public Size Size;
        public int Width => Size.Width;
        public int Height => Size.Height;

        public static readonly byte BoolReadingThreshold = byte.MaxValue / 2;


        public SearchableMap(
            MapMatrix elevation, MapMatrix passibility, MapMatrix water, MapMatrix road,
            Size size, Action<int> loadProgress = null)
        {
            //This code will break if the matices are different sizes. The calling code should check.

            Size = size;

            _map = new MapTile[Size.Width, Size.Height];

            for(var x = 0; x < Size.Width; x++)
            {
                for (var y = 0; y < Size.Height; y++)
                {
                    _map[x, y] = new MapTile()
                    {
                        Elevation = elevation[x,y],
                        IsPassable = passibility[x,y] > BoolReadingThreshold,
                        Water = water[x,y],
                        IsRoad = road[x,y] > BoolReadingThreshold
                    };
                }
                loadProgress?.Invoke((x+1) * Size.Height);
            }
        }

        public MapTile this[int x, int y]
        {
            get 
            { 
                return _map[x,y]; 
            }  
        }

        public MapTile this[Point pt]
        {
            get
            {
                return _map[pt.X, pt.Y];
            }
        }

        public bool InBounds(Point pt) => pt.X > -1 && pt.Y > -1 && pt.X < Width && pt.Y < Height;

    }
}
