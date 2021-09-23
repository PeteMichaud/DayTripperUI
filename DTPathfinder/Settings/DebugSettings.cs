using System;
using System.IO;
using ImageMagick;
using System.Drawing;

namespace DayTripper
{
    public class DebugSettings
    {
        public int ProgressMessageInterval = 5_000;

        public bool DebugMode => report != null;
        public int DebugStart = 1_000_000;
        public int ImageOutputInterval = 500_000;
        public string DebugOutputDirectory = Path.Combine(Directory.GetCurrentDirectory(), "output");
        public bool OutputPassable = false;
        public Action<SearchableMap, SearchTile, SearchCandidateCollection, int, Point, DebugSettings> report = null;

        public static readonly byte[] Red = MagickColors.Red.ToByteArray();
        public static readonly byte[] Orange = MagickColors.Orange.ToByteArray();
        public static readonly byte[] Yellow = MagickColors.Yellow.ToByteArray();
        public static readonly byte[] Magenta = MagickColors.Magenta.ToByteArray();
        public static readonly byte[] ImpassableColor = MagickColors.Blue.ToByteArray();
        public static readonly byte[] PassableColor = MagickColors.Transparent.ToByteArray();

    }
}
