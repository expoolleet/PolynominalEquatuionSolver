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
    public partial class FormLimits : Form
    {
        private MainForm _mainForm;

        public FormLimits(MainForm form)
        {
            InitializeComponent();
            _mainForm = form;
            TakeValues();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            _mainForm.xMin = Convert.ToDouble(textBoxXmin.Text);
            _mainForm.xMax = Convert.ToDouble(textBoxXmax.Text);
            _mainForm.yMin = Convert.ToDouble(textBoxYmin.Text);
            _mainForm.yMax = Convert.ToDouble(textBoxYmax.Text);

            Close();
        }

        private void TakeValues()
        {
            textBoxXmin.Text = _mainForm.xMin.ToString();
            textBoxXmax.Text = _mainForm.xMax.ToString();
            textBoxYmin.Text = _mainForm.yMin.ToString();
            textBoxYmax.Text = _mainForm.yMax.ToString();
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            _mainForm.OnKeyPressed(sender, e);
        }
    }
}
