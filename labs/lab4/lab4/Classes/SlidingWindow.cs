using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4.Classes
{
    public class SlidingWindow : IAlgorythm
    {
        private int windowSize;

        public SlidingWindow(int windowSize)
        {
            this.windowSize = windowSize;
        }

        public Bitmap Process(Bitmap source)
        {
            Bitmap result = new Bitmap(source);

            int height = source.Height;
            int width = source.Width;

            if(windowSize % 2 == 0)
            {
                windowSize++;
            }

            int[,] sourceBitsRedValues = new int[width, height];
            int[,] sourceBitsGreenValues = new int[width, height];
            int[,] sourceBitsBlueValues = new int[width, height];

            BitmapHelperUtil.FillRGBValues(source, sourceBitsRedValues, sourceBitsGreenValues, sourceBitsBlueValues);

            int halfOfWindow = (windowSize - 1) / 2;

            for (int i = halfOfWindow; i < source.Width - (halfOfWindow + 1); i++)
            {
                for (int j = halfOfWindow; j < source.Height - (halfOfWindow + 1); j++)
                {
                    int newR = 0;
                    int newG = 0;
                    int newB = 0;
                    int K = 0;

                    for (int wi = -halfOfWindow; wi <= halfOfWindow; wi++)
                    {
                        for (int hw = -halfOfWindow; hw <= halfOfWindow; hw++)
                        {
                            K++;
                            
                            if (hw == 0 && wi == 0)
                            {
                                continue;
                            }

                            newR += sourceBitsRedValues[i + hw, j + wi];

                            newG += sourceBitsGreenValues[i + hw, j + wi];

                            newB += sourceBitsBlueValues[i + hw, j + wi];

                        }
                    }

                    result.SetPixel(i, j, Color.FromArgb(newR / K, newG / K, newB / K));
                }
            }

            return result;
        }
    }
}
