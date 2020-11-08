using lab2.Src.Signal.Classes;
using lab3.Source.Classes;
using lab3.Source.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace lab3
{
    public partial class SignalCompareForm : Form
    {
        public SignalCompareForm()
        {
            InitializeComponent();
        }

        public void FillCompareChart(SignalChartValue signal1, params SignalChartValue[] signals)
        {
            SignalChartValue[] allSignalsArr = new SignalChartValue[signals.Length + 1];
            allSignalsArr[0] = signal1;
            signals.CopyTo(allSignalsArr, 1);

            for (int i = 0; i < allSignalsArr.Length; i++)
            {
                Series newSerias = new Series(allSignalsArr[i].Name);
                newSerias.ChartType = SeriesChartType.Line;
                chartCompareSignals.Series.Add(newSerias);
                int valuesCount = allSignalsArr[i].Signal.Values.Count;
                for (int j = 0; j < valuesCount; j++)
                {
                    chartCompareSignals.Series[allSignalsArr[i].Name].Points.AddXY(j, allSignalsArr[i].Signal.Values[j]);
                }
            }
        }
    }
}
