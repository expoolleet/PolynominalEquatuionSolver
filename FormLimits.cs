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
        MainForm mainForm;

        public FormLimits(Form form)
        {
            InitializeComponent();
            mainForm = (MainForm)form;
            TakeValues();
        }


        private void buttonOK_Click(object sender, EventArgs e)
        {
            mainForm.xMin = Convert.ToInt32(textBoxXmin.Text);
            mainForm.xMax = Convert.ToInt32(textBoxXmax.Text);
            mainForm.yMin = Convert.ToInt32(textBoxYmin.Text);
            mainForm.yMax = Convert.ToInt32(textBoxYmax.Text);

            Close();
        }

        private void TakeValues()
        {
            textBoxXmin.Text = mainForm.xMin.ToString();
            textBoxXmax.Text = mainForm.xMax.ToString();
            textBoxYmin.Text = mainForm.yMin.ToString();
            textBoxYmax.Text = mainForm.yMin.ToString();
        }
    }
}
