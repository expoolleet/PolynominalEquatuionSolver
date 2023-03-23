using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using AlgebraicEquations;
using System.IO;

namespace PolynomialCalculation
{
    public delegate void AccuracyOfDecimalPlaces(int value);

    public partial class MainForm : Form
    {
        public event AccuracyOfDecimalPlaces ChangeAccuracyOfDecimalPlaces;

        private List<TextBox> _coefficients = new List<TextBox>();
        private List<Label> _variables = new List<Label>();
        private List<TextBox> _roots = new List<TextBox>();
        private List<Label> _rootLabels = new List<Label>();
        private List<Label> _funcLabels = new List<Label>();
        private List<TextBox> _func = new List<TextBox>();
        private List<Panel> _panels = new List<Panel>();
        private int _degree;
        private int _maxDegree = 5;
        private int _accuracy = 2;
        private int _numberOfZoom;
        private double _coef0;
        private double _coef1;
        private double _coef2;
        private double _coef3;
        private double _coef4;
        private double _coef5;

        public int AccuracyOfDecimalPlaces
        {
            get
            {
                return _accuracy;
            }
            private set
            {
                AccuracyOfDecimalPlaces = _accuracy;
            }
        }

        public int xMin { get; set; } = -10;
        public int xMax { get; set; } = 10;
        public int yMin { get; set; } = -50;
        public int yMax { get; set; } = 50;

        //  public double LeftLimit { get; set; }
        // public double RightLimit { get; set; }



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

            _panels.Add(panel1);
            _panels.Add(panel2);
            _panels.Add(panel3);
            _panels.Add(panel4);
            _panels.Add(panel5);

            chart.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            chart.ChartAreas[0].AxisY.ScaleView.Zoomable = true;
            chart.ChartAreas[0].AxisX.LabelStyle.Format = "0.00";
            chart.ChartAreas[0].AxisY.LabelStyle.Format = "0.00";
        }

        private void comboBoxDegree_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (labelEqualZero.Visible == false && labelfx.Visible == false)
            {
                labelEqualZero.Visible = true;
                labelfx.Visible = true;
            }

            _degree = Convert.ToInt16(comboBoxDegree.SelectedItem);

            EquationVisibility();
        }


        private void trackBarAccuracy_Scroll(object sender, EventArgs e)
        {
            _accuracy = trackBarAccuracy.Value;
            textBoxAccuracy.Text = _accuracy.ToString();
            ChangeAccuracyOfDecimalPlaces?.Invoke(_accuracy);
        }

        private void SetCoefficients()
        {
            _coef0 = _coefficients[0].Text == "" ? 0 : Convert.ToDouble(_coefficients[0].Text);
            _coef1 = _coefficients[1].Text == "" ? 0 : Convert.ToDouble(_coefficients[1].Text);
            _coef2 = _coefficients[2].Text == "" ? 0 : Convert.ToDouble(_coefficients[2].Text);
            _coef3 = _coefficients[3].Text == "" ? 0 : Convert.ToDouble(_coefficients[3].Text);
            _coef4 = _coefficients[4].Text == "" ? 0 : Convert.ToDouble(_coefficients[4].Text);
            _coef5 = _coefficients[5].Text == "" ? 0 : Convert.ToDouble(_coefficients[5].Text);
        }

        public void NumericalMethod(double accuracy, double leftLimit, double rightLimit)
        {
            double middle;
            double y1;
            double y2;

            if (FindFunction(leftLimit) * FindFunction(rightLimit) > 0)
            {
                MessageBox.Show("Задан неподходящий диапазон чисел", "Ошибка", MessageBoxButtons.OK);
                return;
            }

            //while (true)
            //{
            //     y1 = FindFunction(leftLimit);
            //     y2 = FindFunction(rightLimit);

            //    if (y1 * y2 < 0)
            //    {
            //        break;
            //    }
            //    else
            //    {
            //        middle = rightLimit / 2;

            //        y1 = FindFunction(leftLimit);
            //        y2 = FindFunction(middle);

            //        if (y1 * y2 < 0)
            //        {
            //            rightLimit = middle;
            //            break;
            //        }
            //        else
            //        {
            //            leftLimit = middle;
            //        }
            //    }
            //}
            using (StreamWriter sw = new StreamWriter("text_file.txt", false))
            {
             //   MessageBox.Show($"{leftLimit}");
             //   MessageBox.Show($"{rightLimit}");
                MessageBox.Show($"{accuracy}");
  

                for (double i = leftLimit; i < rightLimit; i += accuracy)
                {
                       sw.WriteLine($"{i} - {FindFunction(i)}");
                    //if (FindFunction(i) - FindFunction(i - 1) < accuracy)
                    //{
                    //   MessageBox.Show($"{i} ; {FindFunction(i)}");
                    //    break;
                    //}
                }
                MessageBox.Show("Done");
            }
        //   y1 = FindFunction(leftLimit);
        //  y2 = FindFunction(rightLimit);

        //  MessageBox.Show($"{y1}");
        //  MessageBox.Show($"{y2}");
    }

        private void buttonFindRoots_Click(object sender, EventArgs e)
        {
            SetCoefficients();

            try
            {
                switch (_degree)
                {
                    case 1:
                        {
                            var linearEquation = new LinearEquation(this);

                            var root = linearEquation.SolveEquation(_coef1, _coef0);
                            
                            _roots[0].Text = root[0].GetRoot();

                            _func[0].Text = Math.Round(root[0].RealPart * _coef1 + _coef0, _accuracy).ToString();
                        }

                        break;
                    case 2:
                        {
                            var quadraticEquation = new QuadraticEquation(this);

                            var roots = quadraticEquation.SolveEquation(_coef2, _coef1, _coef0);

                            _roots[0].Text = roots[0].GetRoot();
                            _roots[1].Text = roots[1].GetRoot();

                            _func[0].Text = Math.Round(_coef2 * (Math.Pow(roots[0].RealPart, 2) + -Math.Pow(roots[0].ImgPart, 2)) + _coef1 * roots[0].RealPart + _coef0, _accuracy).ToString();
                            _func[1].Text = Math.Round(_coef2 * (Math.Pow(roots[1].RealPart, 2) + -Math.Pow(roots[1].ImgPart, 2)) + _coef1 * roots[1].RealPart + _coef0, _accuracy).ToString();
                        }
                        break;
                    case 3:
                        {
                            var qubicEquation = new QubicEquation(this);

                            var roots = qubicEquation.SolveEquation(_coef3, _coef2, _coef1, _coef0);

                            _roots[0].Text = roots[0].GetRoot();
                            _roots[1].Text = roots[1].GetRoot();
                            _roots[2].Text = roots[2].GetRoot();

                            _func[0].Text = (Math.Round(_coef3 * Math.Pow(roots[0].RealPart, 3) + _coef2 * Math.Pow(roots[0].RealPart, 2) + _coef1 * roots[0].RealPart + _coef0, _accuracy)).ToString();
                            _func[1].Text = (Math.Round(_coef3 * (Math.Pow(roots[1].RealPart, 3) + (3 * roots[1].RealPart * -Math.Pow(roots[1].ImgPart, 2))) + _coef2 * (Math.Pow(roots[1].RealPart, 2) + -Math.Pow(roots[1].ImgPart, 2)) + _coef1 * roots[1].RealPart + _coef0, _accuracy)).ToString();
                            _func[2].Text = (Math.Round(_coef3 * (Math.Pow(roots[2].RealPart, 3) + (3 * roots[2].RealPart * -Math.Pow(roots[2].ImgPart, 2))) + _coef2 * (Math.Pow(roots[2].RealPart, 2) + -Math.Pow(roots[2].ImgPart, 2)) + _coef1 * roots[2].RealPart + _coef0, _accuracy)).ToString();
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
                    _panels[i].Visible = false;
                    _rootLabels[i].Visible = false;
                    _roots[i].Visible = false;
                    _func[i].Visible = false;
                    _funcLabels[i].Visible = false;
                }
            }

            for (int i = 0; i <= _degree; i++)
            {
                _coefficients[i].Visible = true;

                _coefficients[i].Text = "";
                _variables[i].Visible = true;

                if (i != _degree)
                {
                    _panels[i].Visible = true;
                    _rootLabels[i].Visible = true;
                    _roots[i].Visible = true;
                    _roots[i].Text = "";
                    _func[i].Visible = true;
                    _func[i].Text = "";
                    _funcLabels[i].Visible = true;
                }
            }
        }

        #region onkeypressed

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

        #endregion

        private void chart_MouseWheel(object sender, MouseEventArgs e)
        {
            var chart = (Chart)sender;
            var xAxis = chart.ChartAreas[0].AxisX;
            var yAxis = chart.ChartAreas[0].AxisY;

            var xMin = xAxis.ScaleView.ViewMinimum;
            var xMax = xAxis.ScaleView.ViewMaximum;
            var yMin = yAxis.ScaleView.ViewMinimum;
            var yMax = yAxis.ScaleView.ViewMaximum;

            int IntervalX = 3;
            int IntervalY = 3;
            try
            {
                if (e.Delta < 0 && _numberOfZoom > 0) // Scrolled down.
                {
                    var posXStart = xAxis.PixelPositionToValue(e.Location.X) - IntervalX * 2 / Math.Pow(2, _numberOfZoom);
                    var posXFinish = xAxis.PixelPositionToValue(e.Location.X) + IntervalX * 2 / Math.Pow(2, _numberOfZoom);
                    var posYStart = yAxis.PixelPositionToValue(e.Location.Y) - IntervalY * 2 / Math.Pow(2, _numberOfZoom);
                    var posYFinish = yAxis.PixelPositionToValue(e.Location.Y) + IntervalY * 2 / Math.Pow(2, _numberOfZoom);

                    if (posXStart < 0) posXStart = 0;
                    if (posYStart < 0) posYStart = 0;
                    if (posYFinish > yAxis.Maximum) posYFinish = yAxis.Maximum;
                    if (posXFinish > xAxis.Maximum) posYFinish = xAxis.Maximum;
                    xAxis.ScaleView.Zoom(posXStart, posXFinish);
                    yAxis.ScaleView.Zoom(posYStart, posYFinish);
                    _numberOfZoom--;
                }
                else if (e.Delta < 0 && _numberOfZoom == 0) //Last scrolled dowm
                {
                    yAxis.ScaleView.ZoomReset();
                    xAxis.ScaleView.ZoomReset();
                }
                else if (e.Delta > 0) // Scrolled up.
                {

                    var posXStart = xAxis.PixelPositionToValue(e.Location.X) - IntervalX / Math.Pow(2, _numberOfZoom);
                    var posXFinish = xAxis.PixelPositionToValue(e.Location.X) + IntervalX / Math.Pow(2, _numberOfZoom);
                    var posYStart = yAxis.PixelPositionToValue(e.Location.Y) - IntervalY / Math.Pow(2, _numberOfZoom);
                    var posYFinish = yAxis.PixelPositionToValue(e.Location.Y) + IntervalY / Math.Pow(2, _numberOfZoom);

                    xAxis.ScaleView.Zoom(posXStart, posXFinish);
                    yAxis.ScaleView.Zoom(posYStart, posYFinish);
                    _numberOfZoom++;
                }

                if (_numberOfZoom < 0) _numberOfZoom = 0;
            }
            catch { }
        }

        private void buttonLimits_Click(object sender, EventArgs e)
        {
            FormLimits form = new FormLimits(this);
            form.ShowDialog();
        }

        private double FindFunction(double x)
        {
            return _coef5 * Math.Pow(x, 5) + _coef4 * Math.Pow(x, 4) + _coef3 * Math.Pow(x, 3) + _coef2 * Math.Pow(x, 2) + _coef1 * x + _coef0;
        }

        private void buttonGraphic_Click(object sender, EventArgs e)
        {
            try
            {
                chart.Series["Func"].Points.Clear();

                int y;

                SetCoefficients();

                for (int x = xMin; x <= xMax; x++)
                {
                    y = (int)FindFunction(x);

                    if (y <= yMax && y >= yMin)
                    {
                        chart.Series["Func"].Points.AddXY(x, y);
                    }

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

        private void buttonSetInterval_Click(object sender, EventArgs e)
        {
            new FormIntervalRoots(this).ShowDialog();
        }
    }
}
