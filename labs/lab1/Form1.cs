using lab1.classes.modulation_methods;
using lab1.classes.modulation_methods.classes;
using lab1.classes.signals;
using System;
using System.Windows.Forms;
using NAudio.Wave;
using System.IO;
using lab1.classes;
using WaveFileWriter = NAudio.Wave.WaveFileWriter;
using System.Windows.Forms.VisualStyles;

namespace lab1
{
    public partial class frmMain : Form
    {
        private string _tempFileName = @"D:\University\labs\4.1\COS\labs\lab1\Generated Files\test.wav";
        private Signal _signal;
        private bool _poligarmonicMode;
        private bool _modulationMode;
        private int _selectedSignalIndex = 1;
        private const int SAMPLE_RATE = 44100;
        private bool _signalWasCreated = false;
        delegate void Modulation(GarmonicSignal sig, GarmonicSignal modulatingSig);
        public frmMain()
        {
            InitializeComponent();
            _poligarmonicMode = false;
            InitializeModulationButtonsTags();
        }

        private void InitializeModulationButtonsTags()
        {
            btnAM.Tag = new AmplitudeModulation();
            btnFM.Tag = new FrequenceModulation();
        }

        private void SignalRadioButtonStateChanged(object sender, EventArgs e)
        {
            _selectedSignalIndex = Convert.ToInt32((sender as Control).Tag);
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            if (_signal == null) return;

            if (File.Exists(_tempFileName))
            {
                File.Delete(_tempFileName);
            }

            using (FileStream fs = new FileStream(_tempFileName, FileMode.Create))
            {
                float[] convertedDoubles = new float[_signal.Values.Count];
                for(int i = 0; i < convertedDoubles.Length; i++)
                {
                    convertedDoubles[i] = (float)_signal.Values[i];
                }

                using (WaveFileWriter waveFileWriter = new WaveFileWriter(fs, new WaveFormat(SAMPLE_RATE, 16, 1))) 
                {
                    waveFileWriter.WriteSamples(convertedDoubles, 0, _signal.Values.Count);
                }
                fs.Close();
            }
            MessageBox.Show("Recorded!");
        }

        private void btnCreateSignal_Click(object sender, EventArgs e)
        {
            CheckSignalInputParams();

            Signal temp = CreatePropriateSignal(_selectedSignalIndex);

            if (_poligarmonicMode)
            {
                (temp as GarmonicSignal).Generate();

                (_signal as PoligarmonicSignal).AddSignal(temp);

                MessageBox.Show("Signal was added!"); 
                return;
            } else if (_modulationMode)
            {
                Modulation modulation = new Modulation(((sender as Control).Tag as IModulationMethod).Modulate);

                modulation((GarmonicSignal)_signal, (GarmonicSignal)temp);

                (_signal as GarmonicSignal).Generate();

                MessageBox.Show("Signal was modulated!");
                return;
            }

             (temp as GarmonicSignal).Generate();

            _signal = temp;

            MessageBox.Show("Created!");
            _signalWasCreated = true;
            chckBoxModulationMode.Enabled = true;
        }

        private bool CheckSignalInputParams()
        {
            return  Check.IsFloatValue(txtBoxAmplitude.Text) &&
                    Check.IsFloatValue(txtFrequence.Text) &&
                    Check.IsFloatValue(txtBoxStartPhase.Text) &&
                    Check.IsFloatValue(txtBoxImpulseTime.Text);
        }

        private Signal CreatePropriateSignal(int index)
        {
            switch (index)
            {
                case 1:
                    return new ImpulseSignal(   (float)Convert.ToDouble(txtBoxStartPhase.Text),
                                                (float)Convert.ToDouble(txtFrequence.Text),
                                                (float)Convert.ToDouble(txtBoxAmplitude.Text),
                                                (float)Convert.ToDouble(txtBoxImpulseTime.Text));
                case 2:
                    return new SinusoidalSignal((float)Convert.ToDouble(txtBoxStartPhase.Text),
                                                (float)Convert.ToDouble(txtFrequence.Text),
                                                (float)Convert.ToDouble(txtBoxAmplitude.Text));
                case 3:
                    return new TriangleSignal(  (float)Convert.ToDouble(txtBoxStartPhase.Text),
                                                (float)Convert.ToDouble(txtFrequence.Text),
                                                (float)Convert.ToDouble(txtBoxAmplitude.Text));
                case 4:
                    return new SawtoothSignal(  (float)Convert.ToDouble(txtBoxStartPhase.Text),
                                                (float)Convert.ToDouble(txtFrequence.Text),
                                                (float)Convert.ToDouble(txtBoxAmplitude.Text));
                case 5:
                    return new NoiseSignal(     (float)Convert.ToDouble(txtBoxAmplitude.Text));
                default:
                    return null;
            }

        }

        private void chckBoxPoligarmonicMode_CheckedChanged(object sender, EventArgs e)
        {
            _signal = !_poligarmonicMode ? new PoligarmonicSignal() : null;
            _poligarmonicMode = !_poligarmonicMode;
        }

        private void chckBoxModulationMode_CheckedChanged(object sender, EventArgs e)
        {
            _modulationMode = !_modulationMode;
            grpBoxModulationTypes.Enabled = !grpBoxModulationTypes.Enabled;
            _poligarmonicMode = false;
            chckBoxPoligarmonicMode.Checked = false;
            if (!_modulationMode)
            {
                _signal = null;
                _signalWasCreated = false;
                chckBoxModulationMode.Enabled = false;
            }
        }

        private void txtBoxAmplitude_ModifiedChanged(object sender, EventArgs e)
        {
            var temp = 0;
        }
    }
}

