using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2.Src.Signal.Classes
{
    public class SecondLabWorker
    {
        public List<GarmonicSignal> Signals { get; private set; }
        public int M { get; private set; }
        public int K { get; private set; }
        public int N { get; private set; }
        public double Phase { get; private set; }
        public int NMulCoef { get; private set; }

        public SecondLabWorker(int n, int k, int mulCoef, double phase)
        {
            Signals = new List<GarmonicSignal>();
            N = n;
            K = k;
            Phase = phase;
            NMulCoef = mulCoef;
        }

        public void GenerateSignals()
        {
            int deltaM = N / 4 / 8;
            M = N * NMulCoef;

            for (int i = deltaM; i < M; i++)
            {
                GarmonicSignal newSignal = new SinusoidalSignal(i, N, Phase);
                newSignal.Generate();
                newSignal.CalculateCharacteristics();
                Signals.Add(newSignal);
            }
            
        }
    }
}
