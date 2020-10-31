using lab2.Src.Signal.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public void FillChart(SecondLabWorker secondLabWorker)
        {
            foreach (var item in secondLabWorker.Signals)
            {
                mainChart.Series["SKZ"].Points.AddXY(item.M, item.DeltaAvgSqrValue);
                mainChart.Series["SKO"].Points.AddXY(item.M, item.DeltaAvgSqrDiviation);
                mainChart.Series["Amplitude"].Points.AddXY(item.M, item.DeltaAmplitude);
            }
        }
    }
}
