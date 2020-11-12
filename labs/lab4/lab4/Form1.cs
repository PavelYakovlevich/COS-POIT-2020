using lab4.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4
{
    public partial class formMain : Form
    {
        private Bitmap _sourcePicture;
        private Dictionary<string, IAlgorythm> _algoryths;
        private bool _imageIsLoaded;
        private ParameterSettingForm _parameterSettingForm;
        public formMain()
        {
            InitializeComponent();
            _parameterSettingForm = new ParameterSettingForm();
            InitializeAlgorithmsNames();
            LoadAlgNamesComboBox();
        }

        private void LoadAlgNamesComboBox()
        {
            foreach (var pair in _algoryths)
            {
                cmbBox.Items.Add(pair.Key);
            }

            cmbBox.Text = (string)cmbBox.Items[0];
        }

        public void InitializeAlgorithmsNames()
        {
            _algoryths = new Dictionary<string, IAlgorythm>();
            _algoryths.Add("Собеля", new Sobel(_parameterSettingForm.SobelLimit));
            _algoryths.Add("Гаусса", new Gauss(_parameterSettingForm.Sigma));
            _algoryths.Add("Медианный", new MedianFilter(_parameterSettingForm.WindowSize));
            _algoryths.Add("Скользящее окно", new SlidingWindow(_parameterSettingForm.WindowSize));
        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            if (openFileDlgLoadPicture.ShowDialog() != DialogResult.Cancel)
            {
                _sourcePicture = new Bitmap(openFileDlgLoadPicture.FileName);
                pictureBoxResult.Image = _sourcePicture;
                _imageIsLoaded = true;
            }
        }

        private void btnProcessImage_Click(object sender, EventArgs e)
        {
            _algoryths["Собеля"] = new Sobel(_parameterSettingForm.SobelLimit);
            _algoryths["Гаусса"] =  new Gauss(_parameterSettingForm.Sigma);
            _algoryths["Медианный"] =  new MedianFilter(_parameterSettingForm.WindowSize);
            _algoryths["Скользящее окно"] = new SlidingWindow(_parameterSettingForm.WindowSize);
            if (_imageIsLoaded)
            {

                pictureBoxResult.Image = _algoryths[cmbBox.Text].Process(new Bitmap(pictureBoxResult.Image));
                return;
            }

            MessageBox.Show("Load image first!");
        }

        private void btnParamsSetting_Click(object sender, EventArgs e)
        {
            _parameterSettingForm.Show();
        }
    }
}
