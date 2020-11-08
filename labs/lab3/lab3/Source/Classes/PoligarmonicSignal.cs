using lab2.Src.Signal.Classes;
using lab3.Source.Interfaces;
using System.Collections.Generic;
using System.Security.Policy;

namespace lab3
{
    public class PoligarmonicSignal : ISignal
    {
        private List<double> _values;

        public List<GarmonicSignal> Signals { get; private set; }
        public List<double> Values { get => _values; set => _values = value; }

        public PoligarmonicSignal()
        {
            Signals = new List<GarmonicSignal>();
            Values = new List<double>();
        }

        public PoligarmonicSignal(List<double> lists)
        {
            Values = lists;
        }

        public void AddSignal(GarmonicSignal garmonicSignal)
        {
            Signals.Add(garmonicSignal);
        }

        public void CalculateSignalValues()
        {
            int N = Signals[0].N;

            for (int i = 0; i < N; i++)
            {
                if(Values.Count != N)
                {
                    Values.Add(0);
                }
                for (int j = 0; j < Signals.Count; j++)
                {
                    Values[i] += Signals[j].Values[i];
                }
            }
        }
    }
}