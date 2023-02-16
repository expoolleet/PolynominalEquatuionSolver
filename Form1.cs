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
        private List<string> _roots = new List<string>();
        private List<Label> _rootLabels = new List<Label>();
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

            _roots.Add(labelRoot1.Text);
            _roots.Add(labelRoot2.Text);
            _roots.Add(labelRoot3.Text);
            _roots.Add(labelRoot4.Text);
            _roots.Add(labelRoot5.Text);

            _rootLabels.Add(labelRoot1);
            _rootLabels.Add(labelRoot2);
            _rootLabels.Add(labelRoot3);
            _rootLabels.Add(labelRoot4);
            _rootLabels.Add(labelRoot5);
        }

        private void comboBoxDegree_SelectedIndexChanged(object sender, EventArgs e)
        {
            _degree = Convert.ToInt16(comboBoxDegree.SelectedItem);

            EquationVisibility();
        }

        private void buttonFindRoots_Click(object sender, EventArgs e)
        {
            try
            {
                switch (_degree)
                {
                    case 1:
                        labelRoot1.Text = _roots[0] + (-Convert.ToDouble(_coefficients[0].Text) / Convert.ToDouble(_coefficients[1].Text)).ToString(); break;
                    case 2:
                        {
                            double discriminant = Math.Pow(Convert.ToDouble(_coefficients[1].Text), 2) - 4 * Convert.ToDouble(_coefficients[2].Text) * Convert.ToDouble(_coefficients[0].Text);

                            if (discriminant >= 0)
                            {
                                var sqrtDis = Math.Sqrt(discriminant);

                                var root1 = Math.Round(-Convert.ToDouble(_coefficients[1].Text) + sqrtDis / (2 * Convert.ToDouble(_coefficients[2].Text)), 2);
                                var root2 = Math.Round(-Convert.ToDouble(_coefficients[1].Text) - sqrtDis / (2 * Convert.ToDouble(_coefficients[2].Text)), 2);

                                //labelRoot1.Text = _roots[0] + root1;
                                //labelRoot2.Text = _roots[1] + root2;

                                labelRoot1.Text = root1.ToString();
                                labelRoot2.Text = root2.ToString();


                            }
                            else
                            {
                                var sqrtDis = Math.Sqrt(Math.Abs(discriminant));

                                var root1 = Math.Round(sqrtDis * Math.Cos(Math.PI * 0), 2) + " + i" + Math.Round(sqrtDis * Math.Sin(Math.PI * 0), 2);
                                var root2 = Math.Round(sqrtDis * Math.Cos(Math.PI * 1), 2) + " + i" + Math.Round(sqrtDis * Math.Sin(Math.PI * 1), 2);

                              //  labelRoot1.Text = _roots[0] + root1;
                              //  labelRoot2.Text = _roots[1] + root2;

                               labelRoot1.Text =   root1;
                               labelRoot2.Text =   root2;
                            }
                        }
                        break;
                    case 3:
                        {

                        }
                        break;
                    case 4:
                        {

                        }
                        break;
                    case 5:
                        {

                        }
                        break;
                }



                chart.Series["Series1"].Points.Clear();

                int y;

                for (int x = -10; x <= 10; x++)
                {
                    y = Convert.ToInt32(_coefficients[2].Text) * x * x + Convert.ToInt32(_coefficients[1].Text) * x + Convert.ToInt32(_coefficients[0].Text);

                    chart.Series["Series1"].Points.AddXY(x, y);
                }


            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Возникло исключение", MessageBoxButtons.OK);
            }






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



        private void EquationVisibility()
        {
            for (int i = 0; i <= _maxDegree; i++)
            {
                _coefficients[i].Visible = false;
                _variables[i].Visible = false;

                if (i != _maxDegree)
                {
                    _rootLabels[i].Visible = false;
                }
            }

            for (int i = 0; i <= _degree; i++)
            {
                _coefficients[i].Visible = true;
                _variables[i].Visible = true;

                if (i != _degree)
                {
                    _rootLabels[i].Visible = true;
                }
            }
        }
    }
}
