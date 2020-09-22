using lab1.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace lab1.classes
{
    class ImpulseSignal : ISignal
    {
        private List<short> _values;
        public List<short> Values => _values;

        public uint PulseTime { get; private set; }
        public uint Period { get; private set; }
        public uint ValuesCount { get; private set; }
        public uint SecondsCount { get; private set; }

        private ImpulseSignal()
        {
            _values = new List<short>();
        }

        public ImpulseSignal(uint period, uint pulseTime, uint valuesCount = 44100, uint secondCount = 60) :
            this()
        {
            Period = period;
            PulseTime = pulseTime;
            ValuesCount = valuesCount;
            SecondsCount = secondCount;
        }

        public void Generate()
        {
            for (int i = 0; i < SecondsCount; i++)
            {
                for (int j = 1; j < ValuesCount - 1; j++)
                {
                    short generatedValue = (short)
                        ( (double)( PulseTime / Period ) +
                        ( ( 2.0f / ( Math.PI * (double)j ) ) *
                        Math.Sin( ( Math.PI * (double)PulseTime * (double)j ) / (double)Period )) *
                        Math.Cos( 2.0f * Math.PI * (double)j * ( (double)j - 1 ) / (double)Period )
                        );

                    _values.Add(generatedValue);
                }
            }
        }
    }
}
