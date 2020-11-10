using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4.Classes
{
    public class SlidingWindow
    {
        public Bitmap Process(Bitmap source)
        {
            Bitmap result = new Bitmap(source);

            int height = source.Height;
            int width = source.Width;

            int[,] sourceBitsRedValues = new int[width, height];
            int[,] sourceBitsGreenValues = new int[width, height];
            int[,] sourceBitsBlueValues = new int[width, height];

            BitmapHelperUtil.FillRGBValues(source, sourceBitsRedValues, sourceBitsGreenValues, sourceBitsBlueValues);

            for (int i = 1; i < source.Width - 1; i++)
            {
                for (int j = 1; j < source.Height - 1; j++)
                {
                    int newR = 0;
                    int newG = 0;
                    int newB = 0;

                    for (int wi = -1; wi < 2; wi++)
                    {
                        for (int hw = -1; hw < 2; hw++)
                        {
                            newR += sourceBitsRedValues[i + hw, j + wi];

                            newG += sourceBitsGreenValues[i + hw, j + wi];

                            newB += sourceBitsBlueValues[i + hw, j + wi];
                        }
                    }

                    result.SetPixel(i, j, Color.FromArgb(newR / 10, newG / 10, newB / 10));
                }
            }

            return result;
        }
    }
}
