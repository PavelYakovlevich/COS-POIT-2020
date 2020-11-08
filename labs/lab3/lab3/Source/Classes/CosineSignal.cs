using lab2.Src.Signal.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3.Source.Classes
{
    public class CosineSignal : GarmonicSignal
    {
        public CosineSignal(int n, double phase, double a, int garmonicIndex = 1) : 
            base(n, phase, garmonicIndex)
        {
            A = a;
        }

        public CosineSignal(List<double> values) :
            base(values)
        {

        }

        public override double GenerateNextValue(int index)
        {
            return A * Math.Cos(((2 * Math.PI * index * GarmonicIndex) / N) - Phase);
        }
    }
}
