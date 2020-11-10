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
        public formMain()
        {
            InitializeComponent();
        }

        private void btnSobel_Click(object sender, EventArgs e)
        {
            Sobel sobel = new Sobel();
            sobel.Process(pictureBoxSource, pictureBoxResult, 128 * 128);
        }

        private void btnGauss_Click(object sender, EventArgs e)
        {
            Gauss gauss = new Gauss();
            pictureBoxResult.Image = gauss.Blur(new Bitmap(pictureBoxSource.Image), 6);
        }

        private void btnMedian_Click(object sender, EventArgs e)
        {
            MedianFilter medianFilter = new MedianFilter();
            pictureBoxResult.Image = medianFilter.Filter(new Bitmap(pictureBoxSource.Image), 3);
        }

        private void btnSlidingWindow_Click(object sender, EventArgs e)
        {
            SlidingWindow slidingWindow = new SlidingWindow();
            pictureBoxResult.Image = slidingWindow.Process(new Bitmap(pictureBoxSource.Image));
        }
    }
}
