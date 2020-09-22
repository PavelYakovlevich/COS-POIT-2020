using lab1.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace lab1.classes
{
    class SinusoidalSignal : ISignal
    {
        private List<short> _values;
        public uint StartPhase { get; private set; }
        public uint Frequence { get; private set; }
        public uint Amplitude { get; private set; }
        public uint HarmonicsCount { get; set; }
        public uint SecondsCount { get; set; }

        public List<short> Values => _values;

        public void Generate()
        {
            for (int j = 0; j < SecondsCount; j++)
            {
                for (int i = 1; i < HarmonicsCount - 1; i++)
                {
                    short newYValue = (short)((double)Amplitude * Math.Sin(2.0f * Math.PI * (double)Frequence * (double)i / (double)HarmonicsCount));
                    _values.Add(newYValue);
                }
            }

        }

        private SinusoidalSignal()
        {
            _values = new List<short>();
        }

        public SinusoidalSignal(uint startPhase, uint frequnce, uint amplitude, uint harmonicsCount = 44100, int secondCount = 60) :
            this()
        {
            StartPhase = startPhase;
            Frequence = frequnce;
            Amplitude = amplitude;
            HarmonicsCount = harmonicsCount;
            SecondsCount = 60;
        }
    }
}
