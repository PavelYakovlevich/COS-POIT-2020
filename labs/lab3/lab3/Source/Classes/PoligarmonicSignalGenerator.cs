using lab2.Src.Signal.Classes;
using System;
using System.Collections.Generic;
using System.Security.Principal;

namespace lab3.Source.Classes
{
    public static class PoligarmonicSignalGenerator
    {
        private static Random _random = new Random();
        public static PoligarmonicSignal GeneratePoligarmonicSignal(int signalsCount, int N, List<int> amplitudesList, List<double> phasesList = null)
        {
            PoligarmonicSignal result = new PoligarmonicSignal();
            if (phasesList == null)
            {
                phasesList = new List<double>();
                phasesList.Add(0);
            }

            for (int i = 1; i <= signalsCount; i++)
            {
                GarmonicSignal garmonicSignal = new CosineSignal(N, GetRandomPhase(phasesList), GetRandomAmplitude(amplitudesList), i);
                garmonicSignal.Generate();
                garmonicSignal.AFinder.CalculateAmplitude(garmonicSignal.Values, N, i);
                result.AddSignal(garmonicSignal);
            }

            result.CalculateSignalValues();
            return result;
        }

        private static double GetRandomAmplitude(List<int> amplitudesList)
        {
            int valueIndex = _random.Next(1, amplitudesList.Count);
            return amplitudesList[valueIndex];
        }

        private static double GetRandomPhase(List<double> phasesList)
        {
            int valueIndex = _random.Next(1, phasesList.Count);
            return phasesList[valueIndex];
        }
    }
}
