using lab3.Source.Classes;
using lab3.Source.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2.Src.Signal.Classes
{
    public abstract class GarmonicSignal : ISignal
    {
        private List<double> _values;
        public double Phase { get; private set; }
        public double A { get; protected set; }
        public int N { get; protected set; }
        public AmplitudeFinder AFinder { get; private set; }
        public int GarmonicIndex { get; private set; }
        public List<double> Values
        { 
            get
            {
                return _values;
            }

            set 
            {
                _values = value;
            } 
        }

        public GarmonicSignal(int n, double phase, int garmonicIndex)
        {
            Phase = phase;
            Values = new List<double>();
            AFinder = new AmplitudeFinder();
            N = n;
            GarmonicIndex = garmonicIndex;
        }

        public GarmonicSignal(List<double> values)
        {
            if(values == null)
            {
                throw new ArgumentNullException();
            }

            Values = values;
        }

        public void Generate()
        {
            for (int i = 1; i <= N; i++)
            {
                double generatedValue = GenerateNextValue(i);
                Values.Add(generatedValue);
            }
        }
        public abstract double GenerateNextValue(int index);
    }
}
