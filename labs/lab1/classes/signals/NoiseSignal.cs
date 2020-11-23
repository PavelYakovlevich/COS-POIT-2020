using System;
using System.Collections.Generic;

namespace lab1.classes.signals
{
    class NoiseSignal : GarmonicSignal
    {
        private Random random = new Random();
        public NoiseSignal(double amplitude, uint valuesCount = 44100)
        {
            if (amplitude.CompareTo(0) < 0 && amplitude.CompareTo(1) > 0)
            {
                throw new ArgumentException("Amplitude must be lower than 1 and greater than 0");
            }
            Values = new List<double>();
            Amplitude = amplitude;
            ValuesCount = valuesCount;
        }
        public override double GenerateValue()
        {
            return random.NextDouble() * 2.0 * Amplitude - Amplitude;
        }
    }
}
