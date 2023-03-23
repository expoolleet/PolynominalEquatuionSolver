using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PolynomialCalculation
{
    public partial class FormIntervalRoots : Form
    {
        private MainForm _mainForm;
        private double _accuracy;
        public FormIntervalRoots(MainForm mainForm)
        {
            InitializeComponent();

            _mainForm = mainForm;
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            //_mainForm.LeftLimit = Convert.ToDouble(textBoxLeft.Text);
           // _mainForm.RightLimit = Convert.ToDouble(textBoxRight.Text);
            _mainForm.NumericalMethod(_accuracy, Convert.ToDouble(textBoxLeft.Text), Convert.ToDouble(textBoxRight.Text));
        }

        private void trackBarAccuracy_Scroll(object sender, EventArgs e)
        {
            _accuracy = trackBarAccuracy.Value / Math.Pow(10, _accuracy);
          //  string symbol = $"\u00B{_accuracy}";
            textBoxAccuracy.Text = "1 x 10\u207B\u00B3";
        }
    }
}
