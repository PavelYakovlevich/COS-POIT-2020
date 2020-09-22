using lab1.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1.interfaces
{
    interface ISignal
    {
        List<short> Values { get; }
        void Generate();
    }
}
