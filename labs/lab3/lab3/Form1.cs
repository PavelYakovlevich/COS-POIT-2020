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

namespace lab3
{
    public partial class Form1 : Form
    {
        private ISignal signal;
        private bool _openChartAfterSignalCreation;
        private bool _poligarmonicMode;
        private List<int> _predefinedPValues;
        private List<double> _predefinedFiValues;
        private bool _useFiInCalculation;
        public const int GARMONICS_COUNT = 30;

        public Form1()
        {
            InitializeComponent();

            InitializeBValues();
            InitializeFiValues();
        }

        private void InitializeFiValues()
        {
            _predefinedFiValues = new List<double>();
            _predefinedFiValues.Add(Math.PI / 6);
            _predefinedFiValues.Add(Math.PI / 4);
            _predefinedFiValues.Add(Math.PI / 3);
            _predefinedFiValues.Add(Math.PI / 2);
            _predefinedFiValues.Add(3 * Math.PI / 4);
            _predefinedFiValues.Add(Math.PI);
    }

        private void InitializeBValues()
        {
            _predefinedPValues = new List<int>();
            _predefinedPValues.Add(1);
            _predefinedPValues.Add(3);
            _predefinedPValues.Add(5);
            _predefinedPValues.Add(8);
            _predefinedPValues.Add(10);
            _predefinedPValues.Add(12);
            _predefinedPValues.Add(16);
        }

        private void btnCreateSignal_Click(object sender, EventArgs e)
        {
            double fi = Convert.ToDouble(txtBoxPhase.Text);
            int N = Convert.ToInt32(cmbBoxN.Text);
            int b = Convert.ToInt32(txtBoxB.Text);

            if (_poligarmonicMode)
            {
                signal = PoligarmonicSignalGenerator.GeneratePoligarmonicSignal(GARMONICS_COUNT, N, _predefinedPValues, _predefinedFiValues);
            }
            else
            {
                signal = new CosineSignal(N, fi, b);
                (signal as GarmonicSignal).Generate();
                (signal as GarmonicSignal).AFinder.CalculateAmplitude((signal as GarmonicSignal).Values, (signal as GarmonicSignal).N);
            }

            if (_openChartAfterSignalCreation) 
            {
                int fMin = Convert.ToInt32(txtBoxFMin.Text);
                int fMax = Convert.ToInt32(txtBoxFMax.Text);
                SpectrumFilter spectrumFilter = new SpectrumFilter(fMin, fMax);
                SpectrumGraphics spectrumGraphicsForm = new SpectrumGraphics();
                spectrumGraphicsForm.FillChart(signal, spectrumFilter);
                spectrumGraphicsForm.Show();
            }
        }

        private void btnRestoreSigWithSpectrum_Click(object sender, EventArgs e)
        {
            if (signal != null)
            {
                ISignal restoredSignal = null;
                if (_poligarmonicMode)
                {
                    restoredSignal = new PoligarmonicSignal(SpectrumUseUtil.RestoreSignalValues(signal, _useFiInCalculation));
                }
                else if (!_poligarmonicMode) {
                    restoredSignal = new CosineSignal(SpectrumUseUtil.RestoreSignalValues(signal));
                }

                SignalCompareForm newSignalCompareFormWindow = new SignalCompareForm();
                newSignalCompareFormWindow.FillCompareChart( new SignalChartValue("Source", signal), new SignalChartValue("Restored", restoredSignal));
                newSignalCompareFormWindow.Show();
            }
            else
            {
                MessageBox.Show("Create signal first!");
            }
            
        }

        private void chckBoxOpenGraphicsAfterSignalCreation_CheckedChanged(object sender, EventArgs e)
        {
            _openChartAfterSignalCreation = !_openChartAfterSignalCreation;
        }

        private void chckBoxPoligarmonicMode_CheckedChanged(object sender, EventArgs e)
        {
            _poligarmonicMode = !_poligarmonicMode;
        }

        private void chckBoxUseFi_CheckedChanged(object sender, EventArgs e)
        {
            _useFiInCalculation = !_useFiInCalculation;
        }
    }
}
