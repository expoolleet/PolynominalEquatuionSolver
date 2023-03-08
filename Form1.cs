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
        private List<TextBox> _roots = new List<TextBox>();
        private List<Label> _rootLabels = new List<Label>();
        private List<Label> _funcLabels = new List<Label>();
        private List<TextBox> _func = new List<TextBox>();
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

            _rootLabels.Add(labelRoot1);
            _rootLabels.Add(labelRoot2);
            _rootLabels.Add(labelRoot3);
            _rootLabels.Add(labelRoot4);
            _rootLabels.Add(labelRoot5);

            _roots.Add(textBoxRoot1);
            _roots.Add(textBoxRoot2);
            _roots.Add(textBoxRoot3);
            _roots.Add(textBoxRoot4);
            _roots.Add(textBoxRoot5);

            _func.Add(textBoxFunc1);
            _func.Add(textBoxFunc2);
            _func.Add(textBoxFunc3);
            _func.Add(textBoxFunc4);
            _func.Add(textBoxFunc5);

            _funcLabels.Add(labelFunc1);
            _funcLabels.Add(labelFunc2);
            _funcLabels.Add(labelFunc3);
            _funcLabels.Add(labelFunc4);
            _funcLabels.Add(labelFunc5);


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
                        {
                            var b = Convert.ToDouble(_coefficients[0].Text);
                            var a = Convert.ToDouble(_coefficients[1].Text);
                            var root = -b / a;
                            _roots[0].Text = root.ToString();

                            chart.Series["Func"].Points.Clear();

                            int y;

                            for (int x = -10; x <= 10; x++)
                            {
                                y = (int)(a * x + b);

                                chart.Series["Func"].Points.AddXY(x, y);
                            }

                            _func[0].Text = (root * a + b).ToString();
                        }

                        break;
                    case 2:
                        {
                            var c = Convert.ToDouble(_coefficients[0].Text);
                            var b = Convert.ToDouble(_coefficients[1].Text);
                            var a = Convert.ToDouble(_coefficients[2].Text);

                            double discriminant = Math.Pow(b, 2) - 4 * a * c;

                            if (discriminant >= 0)
                            {
                                var sqrtDis = Math.Sqrt(discriminant);

                                var root1 = (-b + sqrtDis) / (2 * a);
                                var root2 = (-b - sqrtDis) / (2 * a);

                                _roots[0].Text = root1.ToString();
                                _roots[1].Text = root2.ToString();

                                _func[0].Text = (a * Math.Pow(root1, 2) + b * root1 + c).ToString();
                                _func[1].Text = (a * Math.Pow(root2, 2) + b * root2 + c).ToString();
                            }
                            else
                            {
                                var sqrtDis = Math.Sqrt(Math.Abs(discriminant));

                                var root_real = -b / (2 * a);
                                var root_img = sqrtDis / (2 * a);

                                _roots[0].Text = root_real.ToString() + " + i" + root_img.ToString();
                                _roots[1].Text = root_real.ToString() + " - i" + root_img.ToString();

                                _func[0].Text = (Math.Round(a * (Math.Pow(root_real, 2) + -Math.Pow(root_img, 2)) + b * root_real + c, 12)).ToString();
                                _func[1].Text = (Math.Round(a * (Math.Pow(root_real, 2) + -Math.Pow(root_img, 2)) + b * root_real + c, 12)).ToString();
                            }

                            chart.Series["Func"].Points.Clear();

                            int y;

                            for (int x = -10; x <= 10; x++)
                            {
                                y = (int)(a * x * x + b * x + c);

                                chart.Series["Func"].Points.AddXY(x, y);
                            }
                        }
                        break;
                    case 3:
                        {
                            var a0 = Convert.ToDouble(_coefficients[3].Text);
                            var a1 = Convert.ToDouble(_coefficients[2].Text);
                            var a2 = Convert.ToDouble(_coefficients[1].Text);
                            var a3 = Convert.ToDouble(_coefficients[0].Text);

                            var b1 = a1 / a0;
                            var b2 = a2 / a0;
                            var b3 = a3 / a0;

                            var p = -Math.Pow(b1, 2) / 3 + b2;
                            var q = 2 * Math.Pow(b1, 3) / 27 - b1 * b2 / 3 + b3;

                            var Q = Math.Pow(p / 3, 3) + Math.Pow(q / 2, 2);
                          //  MessageBox.Show($"{Q}", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            string x1 = "";
                            string x2 = "";
                            string x3 = "";

                            double x1_real = 0;
                            double x2_real = 0;
                            double x3_real = 0;
                            double x_img = 0;

                            if (Q > 0)
                            {
                                var alpha = double.IsNaN(Math.Pow(-(q / 2) + Math.Sqrt(Q), 1.0 / 3)) ? -Math.Pow(Math.Abs(-(q / 2) + Math.Sqrt(Q)), 1.0 / 3) : Math.Pow(-(q / 2) + Math.Sqrt(Q), 1.0 / 3);
                                var beta = double.IsNaN(Math.Pow(-(q / 2) - Math.Sqrt(Q), 1.0 / 3)) ? -Math.Pow(Math.Abs(-(q / 2) - Math.Sqrt(Q)), 1.0 / 3) : Math.Pow(-(q / 2) - Math.Sqrt(Q), 1.0 / 3);

                                var y1 = alpha + beta;

             

                                var y2_real = -(alpha + beta) / 2;
                                var y_img = Math.Round((alpha - beta) / 2 * Math.Sqrt(3), 2);

                                var y3_real = y2_real;

                                x_img = y_img;

                                 x1_real = Math.Round(y1 - b1 / 3, 2);
                              //  x1_real = y1 - b1 / 3;
                                x1 = x1_real.ToString();

                                  x2_real = Math.Round(y2_real - b1 / 3, 2);
                               // x2_real = y2_real - b1 / 3;
                                x2 = x2_real + " + i" + x_img;

                                 x3_real = Math.Round(y3_real - b1 / 3, 2);
                               // x3_real = y3_real - b1 / 3;
                                x3 = x3_real + " - i" + x_img;

                            }
                            else if (Q == 0)
                            {

                            }
                            else
                            {
                                var z = Math.Pow(Math.Abs(-q / 2 + (Double.IsNaN(Math.Sqrt(Math.Pow(q, 2) / 4 + Math.Pow(p, 3) / 27)) ? 0 : Math.Sqrt(Math.Pow(q, 2) / 4 + Math.Pow(p, 3) / 27))), 1.0 / 3);
                              //  var z = double.IsNaN(Math.Pow(- q / 2 + (Math.Sqrt(Math.Pow(q, 2) / 4 + Math.Pow(p, 3) / 27)), 1.0 / 3)) ? -Math.Pow(Math.Abs(-q / 2 + (Math.Sqrt(Math.Pow(q, 2) / 4 + Math.Pow(p, 3) / 27))), 1.0 / 3) : Math.Pow(-q / 2 + (Math.Sqrt(Math.Pow(q, 2) / 4 + Math.Pow(p, 3) / 27)), 1.0 / 3);
                                //   var z2 = Math.Pow(Math.Abs(-q / 2 - (Double.IsNaN(Math.Sqrt(-Math.Pow(q, 2) / 4 + Math.Pow(p, 3) / 27)) ? 0 : Math.Sqrt(-Math.Pow(q, 2) / 4 + Math.Pow(p, 3) / 27))), 1.0 / 3);

                                //   MessageBox.Show($"{z1}  {z1}", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                // MessageBox.Show($"{Math.Sqrt(Math.Abs(Math.Pow(q, 2) / 4 + Math.Pow(p, 3) / 27) <= 0 ? 1 : Math.Sqrt(Math.Pow(q, 2) / 4 + Math.Pow(p, 3) / 27))}", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                //  var z = z1;

                                var k1 = z * Math.Cos((Math.PI + 2 * Math.PI * 0) / 3);
                                var k2 = z * Math.Cos((Math.PI + 2 * Math.PI * 1) / 3);
                                var k3 = z * Math.Cos((Math.PI + 2 * Math.PI * 2) / 3);

                              //  MessageBox.Show($"{k1}  {k2}  {k3}", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                var y1 = k1 + k3;
                                var y2 = k2 + k2;
                                var y3 = k3 + k1;

                                x1_real = y1 - b1 / 3;
                                x2_real = y2 - b1 / 3;
                                x3_real = y3 - b1 / 3;

                                x1 = x1_real.ToString();
                                x2 = x2_real.ToString();
                                x3 = x3_real.ToString();
                            }

                           

                            _roots[0].Text = x1;
                            _roots[1].Text = x2;
                            _roots[2].Text = x3;

                            // MessageBox.Show($"{y1} - {y2} - {y3}", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            chart.Series["Func"].Points.Clear();

                            int y;

                            for (int x = -20; x <= 20; x++)
                            {
                                y = (int)(a0 * Math.Pow(x, 3) + a1 * Math.Pow(x, 2) + a2 * x + a3);

                                chart.Series["Func"].Points.AddXY(x, y);
                            }

                            _func[0].Text = (Math.Round(a0 * Math.Pow(x1_real, 3) + a1 * Math.Pow(x1_real, 2) + a2 * x1_real + a3, 0)).ToString();
                            _func[1].Text = (Math.Round(a0 * (Math.Pow(x2_real, 3) + (3 * x2_real * -Math.Pow(x_img, 2))) + a1 * (Math.Pow(x2_real, 2) + -Math.Pow(x_img, 2)) + a2 * x2_real + a3, 0)).ToString();
                            _func[2].Text = (Math.Round(a0 * (Math.Pow(x3_real, 3) + (3 * x3_real * -Math.Pow(x_img, 2))) + a1 * (Math.Pow(x3_real, 2) + -Math.Pow(x_img, 2)) + a2 * x3_real + a3, 0)).ToString();
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
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Возникло исключение", MessageBoxButtons.OK);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Возникло исключение", MessageBoxButtons.OK);
            }

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
                    _roots[i].Visible = false;
                    _func[i].Visible = false;
                    _funcLabels[i].Visible = false;
                }
            }

            for (int i = 0; i <= _degree; i++)
            {
                _coefficients[i].Visible = true;
                _variables[i].Visible = true;

                if (i != _degree)
                {
                    _rootLabels[i].Visible = true;
                    _roots[i].Visible = true;
                    _func[i].Visible = true;

                    _funcLabels[i].Visible = true;
                }
            }
        }

        private void OnKeyPressed(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            var textBox = sender as TextBox;

            if (number == 45 && textBox.SelectionStart == 0)
            {

            }
            else if (!char.IsDigit(number) && number != 8)
            {
                if (!textBox.Text.Contains(','))
                {
                    if (number == 46 || number == 44)
                    {
                        if (textBox.Text.Length == 0 || (textBox.Text.Length == 1 && textBox.Text.Contains('-')))
                        {
                            textBox.Text += "0";
                        }
                        textBox.Text += ",";
                    }
                }
                textBox.Select(textBox.Text.Length, 0);

                e.Handled = true;
            }
            else if (number == 48)
            {
                if (textBox.SelectionStart == 0 && textBox.Text.Length == 0 ||
                    textBox.Text.Contains(',') && textBox.SelectionStart > 1 ||
                    textBox.Text.Contains('-') && textBox.SelectionStart > 1 ||
                    textBox.Text.Any(char.IsDigit) && textBox.SelectionStart > 0)
                { }
                else if (textBox.SelectionStart == 1 && textBox.Text.Contains('-'))
                {
                    textBox.Text += "0,";
                    textBox.Select(textBox.Text.Length, 0);
                    e.Handled = true;
                }
                else
                {
                    e.Handled = true;
                }
            }
            else if (textBox.Text.Contains('0') && textBox.SelectionStart == 1 && Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void textBoxCoefficient5_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnKeyPressed(sender, e);
        }

        private void textBoxCoefficient4_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnKeyPressed(sender, e);
        }

        private void textBoxCoefficient3_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnKeyPressed(sender, e);
        }

        private void textBoxCoefficient2_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnKeyPressed(sender, e);
        }

        private void textBoxCoefficient1_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnKeyPressed(sender, e);
        }

        private void textBoxCoefficient0_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnKeyPressed(sender, e);
        }
    }
}
