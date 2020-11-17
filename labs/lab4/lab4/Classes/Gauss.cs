using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4.Classes
{
    public class Gauss : IAlgorythm
    {
        public double Sigma { get; private set; }

        public Gauss(double sigma)
        {
            Sigma = sigma;
        }

        public Bitmap Process(Bitmap source)
        {
            Bitmap result = new Bitmap(source);

            int height = source.Height;
            int width = source.Width;

            int windowSize = (int)Math.Ceiling(3 * Sigma);
            if (windowSize % 2 == 0)
            {
                windowSize++;
            } 


            double[,] window = new double[windowSize, windowSize];
            int halfOfWindowSize = (windowSize - 1)/ 2;

            InitializeWindow(window, windowSize);

            double R = 0, G = 0, B = 0;
            double sum = 0;

            for (int i = 0; i < source.Width - 1; i++)
            {
                for (int j = 0; j < source.Height - 1; j++)
                {
                    R = 0;
                    G = 0;
                    B = 0;
                    sum = 0;

                    for (int wi = -halfOfWindowSize; wi <= halfOfWindowSize; wi++)
                    {
                        for (int hw = -halfOfWindowSize; hw <= halfOfWindowSize; hw++)
                        {
                            Color retrievedPixel = source.GetPixel(CheckBound(i + hw, source.Width - 1), CheckBound(j + wi, source.Height - 1));
                            R += window[wi + halfOfWindowSize, hw + halfOfWindowSize] * retrievedPixel.R;
                            G += window[wi + halfOfWindowSize, hw + halfOfWindowSize] * retrievedPixel.G;
                            B += window[wi + halfOfWindowSize, hw + halfOfWindowSize] * retrievedPixel.B;

                            sum += window[wi + halfOfWindowSize, hw + halfOfWindowSize];
                        }
                    }

                    R = CorrectColor(R);
                    G = CorrectColor(G);
                    B = CorrectColor(B);

                    result.SetPixel(i, j, Color.FromArgb((int)R, (int)G, (int)B));
                }
            }

            for (int j = 0; j < source.Height - 1; j++)
            {
                for (int i = 0; i < source.Width - 1; i++)
                {
                    R = 0;
                    G = 0;
                    B = 0;
                    sum = 0;

                    for (int wi = -halfOfWindowSize; wi <= halfOfWindowSize; wi++)
                    {
                        for (int hw = -halfOfWindowSize; hw <= halfOfWindowSize; hw++)
                        {
                            Color retrievedPixel = source.GetPixel(CheckBound(i + hw, source.Width - 1), CheckBound(j + wi, source.Height - 1));
                            R += window[wi + halfOfWindowSize, hw + halfOfWindowSize] * retrievedPixel.R;
                            G += window[wi + halfOfWindowSize, hw + halfOfWindowSize] * retrievedPixel.G;
                            B += window[wi + halfOfWindowSize, hw + halfOfWindowSize] * retrievedPixel.B;

                            sum += window[wi + halfOfWindowSize, hw + halfOfWindowSize];
                        }
                    }

                    R = CorrectColor(R);
                    G = CorrectColor(G);
                    B = CorrectColor(B);

                    result.SetPixel(i, j, Color.FromArgb((int)R, (int)G, (int)B));
                }
            }

            return result;
        }

        private int CheckBound(int v, int v1)
        {
           if (v < 0)
           {
                return 0;
           }

            if (v > v1)
            {
                return v1;
            }

            return v;
        }

        private double CorrectColor(double color)
        {
            color = color > 255 ? 255 : color;
            color = color < 0 ? 0 : color;
            return color;
        }

        private void InitializeWindow(double[,] window, int windowSize)
        {
         
            double kernelSum = 0;
            int foff = (windowSize - 1) / 2;
            double distance = 0;
            double constant = 1d / (2 * Math.PI * Sigma * Sigma);
            for (int y = -foff; y <= foff; y++)
            {
                for (int x = -foff; x <= foff; x++)
                {
                    distance = ((y * y) + (x * x)) / (2 * Sigma * Sigma);
                    window[y + foff, x + foff] = constant * Math.Exp(-distance);
                    kernelSum += window[y + foff, x + foff];
                }
            }
            for (int y = 0; y < windowSize; y++)
            {
                for (int x = 0; x < windowSize; x++)
                {
                    window[y, x] = window[y, x] * 1d / kernelSum;
                }
            }

        }

       
    }
}
