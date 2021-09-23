using ImageMagick;
using System;
using System.Collections.Generic;

namespace DTPathfinder.HelperClasses
{
    /// <summary>
    /// The idea here is that sometimes we have a real map of pixels to read from 
    /// and sometimes we don't but we still want to read the correct values really 
    /// quickly during initialization. For example if we're not given a passability 
    /// map, we want all the tiles to be passable. If we're not given a water map, 
    /// we want all the tiles to be dry land. 
    /// 
    /// This class can do both: read a real map, or provide a given dummy value, 
    /// and the search map initializer never needs to know anything about it. 
    /// </summary>
    public class MapMatrix
    {
        private readonly byte _dummyValue;
        private readonly IPixelCollection<byte> _map;
        private readonly bool _useDummyValue;
        private readonly Dictionary<bool, Func<int,int,byte>> _getter;

        public MapMatrix()
        {
            _getter = new Dictionary<bool, Func<int, int, byte>>
            {
                { true, (x,y) => _dummyValue },
                { false, (x,y) => _map[x,y][0] }
            };
        }

        public MapMatrix(MagickImage mapImage)
            : this(mapImage, byte.MinValue) { }

        public MapMatrix(MagickImage map, bool defaultValue)
            : this(map, defaultValue ? byte.MaxValue : byte.MinValue) { }

        public MapMatrix(MagickImage map, byte defaultValue)
            : this()
        {
            if(map == null)
            {
                _useDummyValue = true;
                _dummyValue = defaultValue;
            }
            else
            {
                _useDummyValue = false;
                _map = map.GetPixels();
            }
        }

        public byte this[int x, int y] => _getter[_useDummyValue](x, y);

    }
}
