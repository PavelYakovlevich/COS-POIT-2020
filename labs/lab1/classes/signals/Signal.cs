using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1.classes.signals
{
    abstract class Signal
    {
        public List<double> Values { get; protected set; }
    }
}
