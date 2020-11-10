using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4.Classes
{
    public class Gauss
    {
        public Bitmap Blur(Bitmap source, double sigma)
        {
            Bitmap result = new Bitmap(source);

            int height = source.Height;
            int width = source.Width;

            int windowSize = (int)Math.Ceiling(3 * sigma);

            double sum = 0;
            double s2 = 2 * sigma * sigma;

            double[] window = new double[windowSize];

            InitializeWindow(window, s2);

            int R = 0, G = 0, B = 0;
            for (int j = 0; j < height; j++)
            {
                for (int i = 0; i < width; i++)
                {
                    sum = 0;
                    R = 0;
                    G = 0;
                    B = 0;

                    for (int k = 0; k < windowSize; k++)
                    {
                        int l = i + k;
                        if (l < width) 
                        {
                            Color temp = source.GetPixel(l, j);
                            R += (int)(temp.R * window[k]);
                            G += (int)(temp.G * window[k]);
                            B += (int)(temp.B * window[k]);

                            sum += window[k];
                        }
                    }

                    R = (int)(R / sum);
                    G = (int)(G / sum);
                    B = (int)(B / sum);

                    result.SetPixel(i, j, Color.FromArgb(R, G, B));
                }
            }

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    sum = 0;
                    R = 0;
                    G = 0;
                    B = 0;

                    for (int k = 0; k < windowSize; k++)
                    {
                        int l = j + k;
                        if (l < height)
                        {
                            Color temp = source.GetPixel(i, l);
                            R += (int)(temp.R * window[k]);
                            G += (int)(temp.G * window[k]);
                            B += (int)(temp.B * window[k]);

                            sum += window[k];
                        }
                    }

                    R = (int)(R / sum);
                    G = (int)(G / sum);
                    B = (int)(B / sum);

                    result.SetPixel(i, j, Color.FromArgb(R, G, B));
                }
            }

            return result;
        }

        private void InitializeWindow(double[] window, double dQSigma)
        {
            window[0] = 1;
            for (int i = 1; i < window.Length; i++)
            {
                window[i] = Math.Exp(-i * i / dQSigma);
            }
        }
    }
}
