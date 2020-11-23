using lab1.classes.signals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace lab1.classes
{
    class SinusoidalSignal : GarmonicSignal
    {
        public SinusoidalSignal(double startPhase, double frequence, double amplitude, uint valuesCount = 44100)
        {
            if (amplitude.CompareTo(0) < 0 && amplitude.CompareTo(1) > 0)
            {
                throw new ArgumentException("Amplitude must be lower than 1 and greater than 0");
            }

            Values = new List<double>();
            StartPhase = default;
            Frequence = frequence;
            Amplitude = amplitude;
            ValuesCount = valuesCount;
        }
        public override double GenerateValue()
        {
            StartPhase += 2.0 * Math.PI * Frequence * (1.0 + (FM?.GenerateValue() ?? 0.0)) / ValuesCount;
            return Amplitude * Math.Sin(StartPhase); 
        }
    }
}
