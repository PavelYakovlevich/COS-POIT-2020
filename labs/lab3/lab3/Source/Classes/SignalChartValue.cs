using lab3.Source.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3.Source.Classes
{
    public class SignalChartValue
    {
        public string Name { get; set; }
        public ISignal Signal { get; set; }
        public SignalChartValue(string name, ISignal signal)
        {
            Name = name;
            Signal = signal; 
        }
    }
}
