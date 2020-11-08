using lab2.Src.Signal.Classes;
using System;
using System.CodeDom;
using System.Windows.Forms;

namespace lab2
{
    public class SinusoidalSignal : GarmonicSignal
    {
        public SinusoidalSignal(int n, double phase, int garmonicIndex = 1) : 
            base(n, phase, garmonicIndex)
        {
        }

        public override double GenerateNextValue(int index)
        {
            return Math.Sin(((2.0 * Math.PI * (double)index * (double)GarmonicIndex) / (double)N) + Phase);
        }
    }
}