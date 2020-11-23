using lab1.classes.signals;
using System;
using System.Collections.Generic;

namespace lab1.classes
{
    class ImpulseSignal : GarmonicSignal
    {
        public double PulseTime { get; private set; }

        public ImpulseSignal(double startPhase, double frequence, double amplitude, double pulseTime, uint valuesCount = 44100)
        {
            if(amplitude.CompareTo(0) < 0 && amplitude.CompareTo(1) > 0)
            {
                throw new ArgumentException("Amplitude must be lower than 1 and greater than 0");
            }

            if (pulseTime.CompareTo(0) < 0 && pulseTime.CompareTo(1) > 0)
            {
                throw new ArgumentException("Pulse time must be lower than 1 and greater than 0");
            }

            Values = new List<double>();
            PulseTime = pulseTime;
            StartPhase = startPhase;
            Frequence = frequence;
            Amplitude = amplitude;
            ValuesCount = valuesCount;
        }

        public override double GenerateValue()
        {
            StartPhase += 2.0 * Math.PI * Frequence * (1.0 + (FM?.GenerateValue() ?? 0.0)) / ValuesCount;
            double cycle = 2.0 * Math.PI;

            return (StartPhase % cycle) / cycle > PulseTime ? 0.0 : Amplitude;
        }

    }
}
