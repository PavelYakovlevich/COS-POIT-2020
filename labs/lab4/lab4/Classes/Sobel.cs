using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4.Classes
{
    public class Sobel
    {
        private int[,] _gx = new int[,] { { -1, 0, 1 }, { -2, 0, 2 }, { -1, 0, 1 } };
        private int[,] _gy = new int[,] { { 1, 2, 1 }, { 0, 0, 0 }, { -1, -2, -1 } };

        public void Process(PictureBox sourcePB, PictureBox toPB, int limit)
        {
            Bitmap source = new Bitmap(sourcePB.Image);
            Bitmap to = new Bitmap(sourcePB.Image);

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
                    int newXR = 0, newYR = 0;
                    int newXG = 0, newYG = 0;
                    int newXB = 0, newYB = 0;

                    for (int wi = -1; wi < 2; wi++)
                    {
                        for (int hw = -1; hw < 2; hw++)
                        {
                            newXR += _gx[wi + 1, hw + 1] * sourceBitsRedValues[i + hw, j + wi];
                            newYR += _gy[wi + 1, hw + 1] * sourceBitsRedValues[i + hw, j + wi];

                            newXG += _gx[wi + 1, hw + 1] * sourceBitsGreenValues[i + hw, j + wi];
                            newYG += _gy[wi + 1, hw + 1] * sourceBitsGreenValues[i + hw, j + wi];

                            newXB += _gx[wi + 1, hw + 1] * sourceBitsBlueValues[i + hw, j + wi];
                            newYB += _gy[wi + 1, hw + 1] * sourceBitsBlueValues[i + hw, j + wi];
                        }
                    }

                    if (newXR * newXR + newYR * newYR > limit ||
                        newXG * newXG + newYG * newYG > limit ||
                        newXB * newXB + newYB * newYB > limit)

                        to.SetPixel(i, j, Color.Black);
                    else
                        to.SetPixel(i, j, Color.White);
                }
            }

            toPB.Image = to;
        }
    }
}
