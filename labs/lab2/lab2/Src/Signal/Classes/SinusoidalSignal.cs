using lab2.Src.Signal.Classes;
using System;
using System.CodeDom;
using System.Windows.Forms;

namespace lab2
{
    public class SinusoidalSignal : GarmonicSignal
    {
        public int N { get; private set; }

        public SinusoidalSignal(int m, int n, double phase) : 
            base(m, n, phase)
        {
            N = n;
        }

        public override double GenerateNextValue(int index)
        {
            return Math.Sin(((2.0 * Math.PI * (double)index) / (double)N) + Phase);
        }

        protected override void CalculateAmplitude()
        {
            double sinSum = 0;
            double cosSum = 0;
            int i = 0;
            
            foreach (var value in Values)
            {
                double angle = (double)(2.0 * Math.PI * (double)i / N);
                sinSum += value * Math.Sin(angle);
                cosSum += value * Math.Cos(angle);
                ++i;
            }

            sinSum *= 2 / (double)Values.Count;
            cosSum *= 2 / (double)Values.Count;

            Amplitude = Math.Sqrt(sinSum * sinSum + cosSum * cosSum);
        }

        public override void CalculateDeltaAvgSquareValue()
        {
            DeltaAvgSqrValue = 0.707 - AvgSqrValueFormula1;
        }

        public override void CalculateDeltaAmplitude()
        {
            DeltaAmplitude = 1.0 - Amplitude;
        }

        public override void CalculateDeltaAvgSqrDiviation()
        {
            DeltaAvgSqrDiviation = 0.707 - AvgSqrValueFormula2;
        }
    }
}