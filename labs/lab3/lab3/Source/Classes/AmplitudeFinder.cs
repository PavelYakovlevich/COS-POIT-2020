using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3.Source.Classes
{
    public class AmplitudeFinder
    {
        public double AmplitudeValue { get; private set; }
        public double CosAmplitudeValue { get; private set; }
        public double SinAmplitudeValue { get; private set; }
        public double StartPhase { get; private set; }
        public double CalculateAmplitude(List<double> values, int n, int j = 1)
        {
            double sinSum = 0;
            double cosSum = 0;
            int i = 1;

            foreach (var value in values)
            {
                double angle = (double)(2.0 * Math.PI * i * j / n);
                sinSum += value * Math.Sin(angle);
                cosSum += value * Math.Cos(angle);
                ++i;
            }

            sinSum *= 2.0 / values.Count;
            cosSum *= 2.0 / values.Count;

            CosAmplitudeValue = cosSum;
            SinAmplitudeValue = sinSum;

            CalculateStartPhase();

            AmplitudeValue = Math.Sqrt(sinSum * sinSum + cosSum * cosSum);
            return AmplitudeValue;
        }

        private void CalculateStartPhase()
        {
            StartPhase = Math.Atan(SinAmplitudeValue / CosAmplitudeValue);
            if (CosAmplitudeValue < 0)
            {
                StartPhase += Math.PI;
            }
        }
    }
}
