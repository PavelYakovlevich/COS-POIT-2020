using lab1.classes.signals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1.classes.modulation_methods
{
    interface IModulationMethod
    {
        void Modulate(GarmonicSignal sig, GarmonicSignal modulatingSig);
    }
}
