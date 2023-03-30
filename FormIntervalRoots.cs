using System;
using System.Windows.Forms;

namespace PolynomialCalculation
{
    public partial class FormIntervalRoots : Form
    {
        private readonly MainForm _mainForm;
        private double _accuracy = 0.01;

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
            _accuracy = 1 / Math.Pow(10, trackBarAccuracy.Value);
            //  string symbol = $"\u00B{_accuracy}";
            //  textBoxAccuracy.Text = "1 x 10\u207B\u00B3";
            textBoxAccuracy.Text = _accuracy.ToString();
        }
    }
}
