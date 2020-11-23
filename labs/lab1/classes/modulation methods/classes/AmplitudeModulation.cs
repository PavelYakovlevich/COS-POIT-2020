using lab1.classes.signals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1.classes.modulation_methods.classes
{
    class AmplitudeModulation : IModulationMethod
    {
        public void Modulate(GarmonicSignal sig, GarmonicSignal modulatingSig)
        {
            sig.AM = modulatingSig;
        }
    }
}
