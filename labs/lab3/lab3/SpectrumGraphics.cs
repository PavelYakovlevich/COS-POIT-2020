using lab2.Src.Signal.Classes;
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
    public partial class SpectrumGraphics : Form
    {
        public SpectrumGraphics()
        {
            InitializeComponent();
        }


        public void FillChart(ISignal signal)
        {
            if (signal is GarmonicSignal)
            {
                chartPhaseSpectrum.Series["Phase Spectrum"].Points.AddXY(1, (signal as GarmonicSignal).AFinder.StartPhase);
                chartASpectrum.Series["Amplitude Spectrum"].Points.AddXY(1, (signal as GarmonicSignal).AFinder.AmplitudeValue);

                for (int i = 2; i < (signal as GarmonicSignal).N / 2; i++)
                {
                    chartPhaseSpectrum.Series["Phase Spectrum"].Points.AddXY(i, 0);
                    chartASpectrum.Series["Amplitude Spectrum"].Points.AddXY(i, 0);
                }
            }
            else if (signal is PoligarmonicSignal)
            {
                foreach (var innerSignal in (signal as PoligarmonicSignal).Signals)
                {
                    chartPhaseSpectrum.Series["Phase Spectrum"].Points.AddXY((innerSignal as GarmonicSignal).GarmonicIndex, (innerSignal as GarmonicSignal).AFinder.StartPhase);
                    chartASpectrum.Series["Amplitude Spectrum"].Points.AddXY((innerSignal as GarmonicSignal).GarmonicIndex, (innerSignal as GarmonicSignal).AFinder.AmplitudeValue);
                }
                
            }
        }
    }
}
