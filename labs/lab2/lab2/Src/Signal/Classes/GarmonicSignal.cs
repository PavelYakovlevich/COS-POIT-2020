using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2.Src.Signal.Classes
{
    public abstract class GarmonicSignal
    {
        private double _valuesSum;
        private double _sqrValuesSum;
        public int M { get; private set; }
        public double Phase { get; private set; }
        public double AvgSqrValueFormula1 { get; private set; }
        public double AvgSqrValueFormula2 { get; private set; }
        public double Amplitude { get; protected set; }
        public double DeltaAvgSqrValue { get; protected set; }
        public double DeltaAmplitude { get; protected set; }
        public double DeltaAvgSqrDiviation { get; protected set; }


        public List<double> Values { get; private set; }

        public GarmonicSignal(int m, int n, double phase)
        {
            M = m;
            Phase = phase;
            Values = new List<double>();
        }

        public void Generate()
        {
            for (int i = 0; i < M; i++)
            {
                double generatedValue = GenerateNextValue(i);
                _valuesSum += generatedValue;
                _sqrValuesSum += Math.Pow(generatedValue, 2);
                Values.Add(generatedValue);
            }

        }

        public void CalculateCharacteristics()
        {
            AvgSqrValueFormula1 = Math.Sqrt( (1.0
                                             / (M + 1.0)) * _sqrValuesSum);
            AvgSqrValueFormula2 = Math.Sqrt(((1.0
                                             / (M + 1.0)) * _sqrValuesSum) -
                                             Math.Pow(((1.0
                                             / (M + 1.0)) * _valuesSum),2));
            CalculateAmplitude();
            CalculateDeltas();
        }

        private void CalculateDeltas()
        {
            CalculateDeltaAvgSquareValue();
            CalculateDeltaAmplitude();
            CalculateDeltaAvgSqrDiviation();
        }

        public abstract void CalculateDeltaAvgSquareValue();
        public abstract void CalculateDeltaAmplitude();
        public abstract void CalculateDeltaAvgSqrDiviation();
        abstract protected void CalculateAmplitude();
        

        public abstract double GenerateNextValue(int index);
    }
}
