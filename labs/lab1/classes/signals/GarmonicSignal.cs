using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1.classes.signals
{
    abstract class GarmonicSignal : Signal
    {
        private GarmonicSignal _amplitudeModulatingSignal;
        private GarmonicSignal _frequenceModulatingSignal;
        public GarmonicSignal AM
        {
            get 
            {
                return _amplitudeModulatingSignal;
            } 
            set
            {
                if (value == null)
                {
                    throw new ArgumentException("Modulating signal can't be null");
                }

                _amplitudeModulatingSignal = value;
            }
        }
        public GarmonicSignal FM
        {
            get
            {
                return _frequenceModulatingSignal;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentException("Modulating signal can't be null");
                }

                _frequenceModulatingSignal = value;
            }
        }
        public double StartPhase { get; protected set; }
        public double Frequence { get; protected set; }
        public double Amplitude { get; protected set; }
        public uint ValuesCount { get; protected set; }

        public GarmonicSignal()
        {
            StartPhase = default;
        }

        public abstract double GenerateValue();
        public List<double> Generate()
        {
            Values.Clear();
            for (int i = 1; i <= ValuesCount; i++)
            {
                Values.Add(GenerateValue() * (1 + (AM?.GenerateValue() ?? 0)));
            }

            return Values;
        }
    }
}
