using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using AlgebraicEquations;

namespace PolynomialCalculation
{
    public delegate void AccuracyOfDecimalPlaces(int value);

    public partial class MainForm : Form
    {
        public event AccuracyOfDecimalPlaces ChangeAccuracyOfDecimalPlaces;

        private List<Root> _rootsByNumeral = new List<Root>();
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

        public double xMin { get; set; } = -20;
        public double xMax { get; set; } = 20;
        public double yMin { get; set; } = -20;
        public double yMax { get; set; } = 20;

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

        public void NumericalMethod(double accuracy, double leftLimit, double rightLimit)
        {
            _rootsByNumeral.Clear();
            SetCoefficients();

            double middle;
            double y1;
            double y2;

            for (double step = leftLimit; step < rightLimit; step += 0.1)
            {
                if (FindFunction(leftLimit) * FindFunction(step) < 0)
                {
                    while (FindFunction(leftLimit) < accuracy && FindFunction(step) > accuracy)
                    {

                        middle = (step + leftLimit) / 2;

                        y1 = FindFunction(leftLimit);
                        y2 = FindFunction(middle);

                        if (y1 * y2 < 0)
                        {
                            step = middle;
                        }
                        else
                        {
                            leftLimit = middle;
                        }
                    }

                    var root = Math.Round(step, _accuracy);

                    _rootsByNumeral.Add(new Root($"{root}", root, 0));

                    leftLimit = step;
                }
            }

            for (int i = 0; i < _rootsByNumeral.Count; i++)
            {
                _roots[i].Text = "";
                _func[i].Text = "";

                _roots[i].Text = _rootsByNumeral[i].GetRoot();
                _func[i].Text = FindFunction(_rootsByNumeral[i].RealPart).ToString();
            }
        }

        private double FindFunction(double x)
        {
            return _coef5 * Math.Pow(x, 5) + _coef4 * Math.Pow(x, 4) + _coef3 * Math.Pow(x, 3) + _coef2 * Math.Pow(x, 2) + _coef1 * x + _coef0;
            
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

        private void EquationVisibility()
        {
            if (_degree > 3)
            {
                buttonFindRoots.Visible = false;
                buttonSetInterval.Visible = true;
            }
            else
            {
                buttonFindRoots.Visible = true;
                buttonSetInterval.Visible = false;
            }

            for (int i = 0; i <= _maxDegree; i++)
            {
                _coefficients[i].Visible = false;
                _coefficients[i].Text = "";
                _variables[i].Visible = false;


                if (i != _maxDegree)
                {
                    _panels[i].Visible = false;
                    _rootLabels[i].Visible = false;
                    _roots[i].Visible = false;
                    _roots[i].Text = "";
                    _func[i].Visible = false;
                    _func[i].Text = "";
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

        public void OnKeyPressed(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            var textBox = sender as TextBox;

            if (number == 45 && textBox.SelectionStart == 0)
            { }
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
                 if (textBox.SelectionStart == 1 && textBox.Text.Contains('-'))
                {
                    textBox.Text += "0,";
                    textBox.Select(textBox.Text.Length, 0);
                    e.Handled = true;
                }
                if (textBox.Text.Contains('0') && textBox.SelectionStart == 1)
                {
                    e.Handled = true;
                }
            }
            else if (textBox.Text.Contains('0') && textBox.SelectionStart == 1 && Char.IsDigit(number))
            {
                e.Handled = true;
            }
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

        private void buttonLimits_Click(object sender, EventArgs e)
        {
            FormLimits form = new FormLimits(this);
            form.ShowDialog();
        }

        private void buttonGraphic_Click(object sender, EventArgs e)
        {
            SetCoefficients();
            chart.ChartAreas[0].AxisX.Minimum = xMin;
            chart.ChartAreas[0].AxisX.Maximum = xMax;
            chart.ChartAreas[0].AxisY.Minimum = yMin;
            chart.ChartAreas[0].AxisY.Maximum = yMax;

            try
            {
                chart.Series["Func"].Points.Clear();

                double y;   

                for (double x = xMin; x <= xMax; x += 0.01)
                {
                        
                    y = FindFunction(x);         
                    chart.Series["Func"].Points.AddXY(x, y);
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

        private void chart_MouseEnter(object sender, EventArgs e)
        {
            ChartArea ca = chart.ChartAreas[0]; 
            ca.AxisX.ScaleView.Zoomable = true;
            ca.AxisY.ScaleView.Zoomable = true;
            ca.CursorX.AutoScroll = true;
            ca.CursorY.AutoScroll = true;
            ca.CursorX.IsUserSelectionEnabled = true;
            ca.CursorY.IsUserSelectionEnabled = true;     
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chart.Visible = false;
            chart.ChartAreas[0].AxisY.ScaleView.ZoomReset(10);
            chart.ChartAreas[0].AxisX.ScaleView.ZoomReset(10);
            chart.Visible = true;
        }
    }
}
