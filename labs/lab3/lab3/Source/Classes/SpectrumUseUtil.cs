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
        public static List<double> RestoreSignalValues(ISignal signal, bool includeFi = true)
        {
            List<double> result = new List<double>();
            Dictionary<int, GarmonicSignal> garmonicSignals = new Dictionary<int, GarmonicSignal>();
            double includeFiValue = Convert.ToDouble(includeFi);

            if (signal is GarmonicSignal)
            { 
                garmonicSignals.Add(1, signal as GarmonicSignal);
            }
            else
            {
                for (int i = 1; i <= (signal as PoligarmonicSignal).Signals.Count; i++)
                {
                    garmonicSignals.Add(i, (signal as PoligarmonicSignal).Signals[i-1]);
                }
            }

            for (int i = 1; i <= garmonicSignals[1].N; i++)
            {
                double accumulator = 0;

                for (int j = 1; j <= garmonicSignals.Count; j++)
                {
                    var temp = garmonicSignals[j].AFinder.AmplitudeValue * Math.Cos(((2 * Math.PI * i * j) / garmonicSignals[j].N) - garmonicSignals[j].AFinder.StartPhase);
                    var expected = (signal as PoligarmonicSignal).Signals[j - 1].Values[i - 1];
                    accumulator += temp;
                }

                result.Add(accumulator);
            }
            return result;
        }
    }
}
