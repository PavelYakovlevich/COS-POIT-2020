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
    public partial class ParameterSettingForm : Form
    {
        public double Sigma { get; private set; }
        public int WindowSize { get; private set; }
        public int SobelLimit { get; private set; }
        public ParameterSettingForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SobelLimit = Convert.ToInt32(txtBoxLimitSobel.Text);
            WindowSize = Convert.ToInt32(txtBoxWindowSize.Text);
            Sigma = Convert.ToDouble(txtBoxSigma.Text);
            Hide();
        }
    }
}
