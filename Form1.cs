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
    public partial class MainForm : Form
    {
        private List<TextBox> _coefficients = new List<TextBox>();
        private List<Label> _variables = new List<Label>();
        private int _degree;
        private int _maxDegree = 5;
        public MainForm()
        {
            InitializeComponent();
            _coefficients.Add(textBoxCoefficient0);
            _coefficients.Add(textBoxCoefficient1);
            _coefficients.Add(textBoxCoefficient2);
            _coefficients.Add(textBoxCoefficient3);
            _coefficients.Add(textBoxCoefficient4);
            _coefficients.Add(textBoxCoefficient5);

            _variables.Add(labelVar0);
            _variables.Add(labelVar1);
            _variables.Add(labelVar2);
            _variables.Add(labelVar3);
            _variables.Add(labelVar4);
            _variables.Add(labelVar5);
        }

        private void comboBoxDegree_SelectedIndexChanged(object sender, EventArgs e)
        {
            _degree = Convert.ToInt16(comboBoxDegree.SelectedItem);

            EquationVisibility();
        }

        private void buttonFindRoots_Click(object sender, EventArgs e)
        {
            switch (_degree)
            {
                case 1:
                    labelRoot1.Text += (-Convert.ToDouble(textBoxCoefficient0.Text) / Convert.ToDouble(textBoxCoefficient1.Text)).ToString(); break;
                case 2:
                    {
                        double discriminant = Math.Pow(Convert.ToDouble(textBoxCoefficient1.Text), 2) - 4 * Convert.ToDouble(textBoxCoefficient2.Text) * Convert.ToDouble(textBoxCoefficient0.Text);

                     //   var sqrtDis = discriminant > 0 ? Math.Sqrt(discriminant) : 
                    }
                    break;

                    //private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
                    //{
                    //    if (e.KeyChar == 45 && textBox1.SelectionStart == 0) {; }
                    //    else
                    //    {
                    //        if (e.KeyChar == '.') e.KeyChar = ',';
                    //        if (e.KeyChar != 13 && e.KeyChar != 44 && e.KeyChar != 8 && (e.KeyChar < 48 || e.KeyChar > 57))
                    //        {
                    //            e.Handled = true;
                    //            MessageBox.Show("только цифры");
                    //            // label1.Text = Convert.ToInt16(e.KeyChar);
                    //        }
                    //    }
                    //    if (e.KeyChar == 13)
                    //        if (textBox1.Text.Length > 0) button1_Click(textBox1, null);
                    //        else MessageBox.Show("Введите число");
                    //}

                    //private void button1_Click(object sender, EventArgs e)
                    //{
                    //    if (sender == textBox1) label1.Text = "" + Convert.ToDouble(textBox1.Text) * 2;
                    //    else label1.Text = "button1 was pressed";
                    //}
            }
        }


        private void EquationVisibility()
        {
            for (int i = 0; i <= _maxDegree; i++)
            {
                _coefficients[i].Visible = false;
                _variables[i].Visible = false;
            }

            for (int i = 0; i <= _degree; i++)
            {
                _coefficients[i].Visible = true;
                _variables[i].Visible = true;
            }
        }
    }
}
