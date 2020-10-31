using lab2.Src.Signal.Classes;
using System;
using System.CodeDom.Compiler;
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
    public partial class Main : Form
    {
        private List<string> _formulasLocations;
        private int _currFormulaID;

        public Main()
        {
            InitializeComponent();
            InitializeFormulasLocations();
        }

        private void InitializeFormulasLocations()
        {
            _formulasLocations = new List<string>();
            _formulasLocations.Add(@".\Formulas\formula1.PNG");
            _formulasLocations.Add(@".\Formulas\formula2.PNG");
        }

        private void Main_Load(object sender, EventArgs e)
        {
            try
            {
                picBoxKFormula.Load(GetNextFormulaLocation());
            }
            catch (Exception)
            {
                MessageBox.Show("Can't find formulas pictures!");
            }
        }

        private string GetNextFormulaLocation()
        {
            string res = "";
            res = _formulasLocations[_currFormulaID];

            if (_currFormulaID >= _formulasLocations.Count - 1)
            {
                _currFormulaID = -1;
            }

            _currFormulaID++;
            return res;
        }

        private void btnNextK_Click(object sender, EventArgs e)
        {
            picBoxKFormula.Load(GetNextFormulaLocation());
        }

        private void btnGenerateValues_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(cmbBoxN.Text);
            double fi = Convert.ToDouble(txtBoxFi.Text);
            int k = (int)(3 * n / 4); // TODO: fix it later
            int nMulCoef = Convert.ToInt32(txtBoxnMulCoef.Text);
            SecondLabWorker secondLabWorker = new SecondLabWorker(n, k, nMulCoef, fi);
            secondLabWorker.GenerateSignals();

            Form2 form2 = new Form2();
            form2.FillChart(secondLabWorker);
            form2.Show();
        }
    }
}
