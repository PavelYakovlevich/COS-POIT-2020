using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1.classes.signals
{
    class PoligarmonicSignal : Signal
    {
        public int SignalsCount { get; private set; }

        public PoligarmonicSignal()
        {
            SignalsCount = 0;
        }

        public void AddSignal(Signal signal)
        {
            if (signal.Values.Count == 0 || signal.Values == null)
            {
                throw new ArgumentException("Values list should not be null or have 0 elements!");
            }

            if(Values == null)
            {
                Values = signal.Values;
                return;
            }

            int len = signal.Values.Count > Values.Count ? Values.Count : signal.Values.Count;
            
            for(int i = 0; i < len; i++)
            {
                Values[i] += signal.Values[i];
            }

            SignalsCount++;
        }
    }
}
