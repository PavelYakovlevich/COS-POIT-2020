using lab2.Src.Signal.Classes;
using lab3.Source.Interfaces;
using System;
using System.Collections.Generic;
using System.Xml.XPath;

namespace lab3
{
    public class SpectrumFilter
    {
        public int FMin { get; private set; }
        public int FMax { get; private set; }

        public SpectrumFilter(int fMin, int fMax)
        {
            FMin = fMin;
            FMax = fMax;
        }

        public List<GarmonicSignal> Filter(List<GarmonicSignal> signals)
        {
            List<GarmonicSignal> result = new List<GarmonicSignal>();
            foreach (GarmonicSignal temp in signals)
            {
                if (FMin <= temp.GarmonicIndex && temp.GarmonicIndex <= FMax)
                {
                    result.Add(temp);
                }
            }

            return result;
        }
    }
}