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
        private const int SOBEL_LIMIT = 128*128;
        private const int GAUSS_SIGMA = 6;
        private const int MEDIAN_FILTER_MATRIX_SIZE = 3;

        public formMain()
        {
            InitializeComponent();
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

        private void InitializeAlgorithmsNames()
        {
            _algoryths = new Dictionary<string, IAlgorythm>();
            _algoryths.Add("Собеля", new Sobel(SOBEL_LIMIT));
            _algoryths.Add("Гаусса", new Gauss(GAUSS_SIGMA));
            _algoryths.Add("Медианный", new MedianFilter(MEDIAN_FILTER_MATRIX_SIZE));
            _algoryths.Add("Скользящее окно", new SlidingWindow());
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
            if (_imageIsLoaded)
            {
                pictureBoxResult.Image = _algoryths[cmbBox.Text].Process(new Bitmap(pictureBoxResult.Image));
                return;
            }

            MessageBox.Show("Load image first!");
        }
    }
}
