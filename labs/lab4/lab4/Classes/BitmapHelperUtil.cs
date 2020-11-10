using System;
using System.Drawing;

namespace lab4.Classes
{
    public class BitmapHelperUtil
    {
        public static void FillRGBValues(Bitmap source, int[,] redValues, int[,] greenValues, int[,] blueValues)
        {
            for (int i = 0; i < source.Width; i++)
            {
                for (int j = 0; j < source.Height; j++)
                {
                    redValues[i, j] = source.GetPixel(i, j).R;
                    greenValues[i, j] = source.GetPixel(i, j).G;
                    blueValues[i, j] = source.GetPixel(i, j).B;
                }
            }
        }
    }
}