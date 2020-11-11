using lab2.Src.Signal.Classes;
using lab3.Source.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3.Source.Classes
{
    public static class SpectrumUseUtil
    {
        public static List<double> RestoreSignalValues(ISignal signal, bool includeFi = true, SpectrumFilter filter = null)
        {
            List<double> result = new List<double>();
            Dictionary<int, GarmonicSignal> garmonicSignals = new Dictionary<int, GarmonicSignal>();
            double includeFiValue = Convert.ToDouble(includeFi);
            int N = 0;

            if (signal is GarmonicSignal)
            { 
                garmonicSignals.Add(1, signal as GarmonicSignal);
                N = (signal as GarmonicSignal).N;
            }
            else
            {
                List<GarmonicSignal> filteredSignals = (signal as PoligarmonicSignal).Signals;
                if (filter != null)
                {
                    filteredSignals = filter.Filter(filteredSignals);
                }
                for (int i = 1; i <= filteredSignals.Count; i++)
                {
                    garmonicSignals.Add(filteredSignals[i - 1].GarmonicIndex, filteredSignals[i-1]);
                    N = filteredSignals[i - 1].N;
                }
            }


            
            for (int i = 1; i <= N; i++)
            {
                double accumulator = 0;

                foreach (var innerSignal in garmonicSignals)
                {
                    var temp = innerSignal.Value.AFinder.AmplitudeValue * Math.Cos(((2 * Math.PI * i * innerSignal.Value.GarmonicIndex-1) / N) - innerSignal.Value.AFinder.StartPhase);
                    accumulator += temp;
                }

                result.Add(accumulator);
            }
            return result;
        }
    }
}
