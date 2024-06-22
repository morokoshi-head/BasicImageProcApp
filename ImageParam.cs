using System;

namespace BasicImageProcApp
{
    internal class ImageParam
    {
        public static int bitWidth = 8;
        public static int pixelValueMax = (int)Math.Pow(2, bitWidth) - 1;
    }
}
