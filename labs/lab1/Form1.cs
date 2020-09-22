using lab1.classes;
using lab1.interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    public partial class Form1 : Form
    {
        private string _tempFileName = @"D:\University\labs\4.1\COS\labs\lab1\Generated Files\test.wav";
        private WaveFileWriter _waveFileWriter;
        private ISignal _signal;
        private SinusoidalSignal _sinusoidalSignal;
        public Form1()
        {
            InitializeComponent();
            _waveFileWriter = new WaveFileWriter();
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {

            _signal.Generate();
            _waveFileWriter.RecordSignal(_tempFileName, _signal.Values);
            MessageBox.Show("Recorded!");
        }

        private void rBtnSinusoidal_CheckedChanged(object sender, EventArgs e)
        {
            _signal = new SinusoidalSignal((uint)(Convert.ToUInt32(txtBoxStartPhase.Text)),
                                         (uint)(Convert.ToUInt32(txtFrequence.Text)),
                                         (uint)(Convert.ToUInt32(txtBoxAmplitude.Text)));
        }

        private void rBtnImpulse_CheckedChanged(object sender, EventArgs e)
        {
            var temp = (uint)(1.0f / (Convert.ToDouble(txtFrequence.Text)));
            _signal = new ImpulseSignal((uint)(1.0f / (Convert.ToDouble(txtFrequence.Text))),
                                         Convert.ToUInt32(txtBoxImpulseTime.Text));
        }
    }
}
