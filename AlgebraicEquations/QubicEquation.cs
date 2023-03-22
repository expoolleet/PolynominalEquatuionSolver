using AlgebraicEquations;
using PolynomialCalculation;
using System;


namespace AlgebraicEquations
{
    internal class QubicEquation : Equation
    {
        private double _p;
        private double _q;
        private double _b1;
        private double _b2;
        private double _b3;
        private int _accuracy;
        
        public QubicEquation(MainForm mainForm)
        {
            _accuracy = mainForm.AccuracyOfDecimalPlaces;
            mainForm.ChangeAccuracyOfDecimalPlaces += ChangeAccuracy;
        }

        public Root[] SolveEquation(double coefficient3, double coefficient2, double coefficient1, double coefficient0)
        {
            _coefficient3 = coefficient3;
            _coefficient2 = coefficient2;
            _coefficient1 = coefficient1;
            _coefficient0 = coefficient0;

            SolveEquation();
            return _roots;
        }

        protected override void FindDiscriminant()
        {
            var a0 = _coefficient3;
            var a1 = _coefficient2;
            var a2 = _coefficient1;
            var a3 = _coefficient0;

            _b1 = a1 / a0;
            _b2 = a2 / a0;
            _b3 = a3 / a0;

            _p = -Math.Pow(_b1, 2) / 3 + _b2;
            _q = 2 * Math.Pow(_b1, 3) / 27 - _b1 * _b2 / 3 + _b3;

            _discriminant = Math.Pow(_p / 3, 3) + Math.Pow(_q / 2, 2);
        }

        protected override void FindRoots()
        {
            _roots = new Root[3];

            string x1;
            string x2;
            string x3;

            double x1_real;
            double x2_real;
            double x3_real;
            double x_img = 0;

            if (_discriminant > 0)
            {
                var alpha = double.IsNaN(Math.Pow(-(_q / 2) + Math.Sqrt(_discriminant), 1.0 / 3)) ? -Math.Pow(Math.Abs(-(_q / 2) + Math.Sqrt(_discriminant)), 1.0 / 3) : Math.Pow(-(_q / 2) + Math.Sqrt(_discriminant), 1.0 / 3);
                var beta = double.IsNaN(Math.Pow(-(_q / 2) - Math.Sqrt(_discriminant), 1.0 / 3)) ? -Math.Pow(Math.Abs(-(_q / 2) - Math.Sqrt(_discriminant)), 1.0 / 3) : Math.Pow(-(_q / 2) - Math.Sqrt(_discriminant), 1.0 / 3);
                
                var y1 = alpha + beta;

                var y2_real = -(alpha + beta) / 2;
                var y_img = (alpha - beta) / 2 * Math.Sqrt(3);

                var y3_real = y2_real;

                x_img = y_img;

                x1_real = y1 - _b1 / 3;
                x1 = Math.Round(x1_real, _accuracy).ToString();

                x2_real = y2_real - _b1 / 3;
                if (x_img > 0)
                {
                    x2 = Math.Round(x2_real, _accuracy) + " + i" + Math.Round(x_img, _accuracy);
                }
                else
                {
                    x2 = Math.Round(x2_real, _accuracy).ToString();
                }

                x3_real = y3_real - _b1 / 3;
                x3 = Math.Round(x3_real, _accuracy) + " - i" + Math.Round(x_img, _accuracy);

            }
            else if (_discriminant == 0)
            {
                var alpha = double.IsNaN(Math.Pow(-(_q / 2) + Math.Sqrt(_discriminant), 1.0 / 3)) ? -Math.Pow(Math.Abs(-(_q / 2) + Math.Sqrt(_discriminant)), 1.0 / 3) : Math.Pow(-(_q / 2) + Math.Sqrt(_discriminant), 1.0 / 3);

                var y1 = 2 * alpha;
                var y2 = -alpha;
                var y3 = y2;

                x1_real = y1 - _b1 / 3;
                x2_real = y2 - _b1 / 3;
                x3_real = y3 - _b1 / 3;

                x1 = Math.Round(x1_real, _accuracy).ToString();
                x2 = Math.Round(x2_real, _accuracy).ToString();
                x3 = Math.Round(x3_real, _accuracy).ToString();
            }
            else
            {
                var x_real = -_q / 2;
                var y_img = Math.Sqrt(Math.Abs(Math.Pow(_q, 2) / 4 + Math.Pow(_p, 3) / 27));

                var length = Math.Sqrt(Math.Pow(x_real, 2) + Math.Pow(y_img, 2));

                var z = Math.Pow(length, 1.0 / 3);

                double fi;

                if (x_real > 0)
                {
                    fi = Math.Atan(y_img / x_real);
                }
                else if (x_real < 0 && y_img >= 0)
                {
                    fi = Math.PI + Math.Atan(y_img / x_real);
                }
                else if (x_real < 0 && y_img < 0)
                {
                    fi = -Math.PI + Math.Atan(y_img / x_real);
                }
                else if (x_real == 0 && y_img > 0)
                {
                    fi = Math.PI / 2;
                }
                else
                {
                    fi = -Math.PI / 2;
                }

                var k1 = z * Math.Cos((fi + 2 * Math.PI * 0) / 3);

                var k2 = z * Math.Cos((fi + 2 * Math.PI * 1) / 3);

                var k3 = z * Math.Cos((fi + 2 * Math.PI * 2) / 3);

                var y1 = k1 + k1;
                var y2 = k2 + k2;
                var y3 = k3 + k3;

                x1_real = y1 - _b1 / 3;
                x2_real = y2 - _b1 / 3;
                x3_real = y3 - _b1 / 3;

                x1 = Math.Round(x1_real, _accuracy).ToString();
                x2 = Math.Round(x2_real, _accuracy).ToString();
                x3 = Math.Round(x3_real, _accuracy).ToString();
            }

            _roots[0] = new Root(x1, x1_real, x_img);
            _roots[1] = new Root(x2, x2_real, x_img);
            _roots[2] = new Root(x3, x3_real, x_img);
        }

        private void ChangeAccuracy(int value)
        {
            _accuracy = value;
        }
    }
}
