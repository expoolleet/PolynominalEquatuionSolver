using System;
using PolynomialCalculation;

namespace AlgebraicEquations
{
    public class QuadraticEquation : Equation
    {
        private int _accuracy;

        public QuadraticEquation(MainForm mainForm)
        {
            _accuracy = mainForm.AccuracyOfDecimalPlaces;
            mainForm.ChangeAccuracyOfDecimalPlaces += ChangeAccuracy;
        }

        public Root[] SolveEquation(double coefficient2, double coefficient1, double coefficient0)
        {
            _coefficient2 = coefficient2;
            _coefficient1 = coefficient1;
            _coefficient0 = coefficient0;

            SolveEquation();

            return _roots;
        }

        protected override void FindDiscriminant()
        {
            _discriminant = Math.Pow(_coefficient1, 2) - 4 * _coefficient2 * _coefficient0;
        }

        protected override void FindRoots()
        {
            _roots = new Root[2];

            if (_discriminant >= 0)
            {
                var sqrtDis = Math.Sqrt(_discriminant);

                var root1 = (-_coefficient1 + sqrtDis) / (2 * _coefficient2);
                var root2 = (-_coefficient1 - sqrtDis) / (2 * _coefficient2);

                var fullroot1 = Math.Round(root1, _accuracy).ToString();
                var fullroot2 = Math.Round(root2, _accuracy).ToString();

                _roots[0] = new Root(fullroot1, root1, 0);
                _roots[1] = new Root(fullroot2, root2, 0);

            }
            else
            {
                var sqrtDis = Math.Sqrt(Math.Abs(_discriminant));

                var root_real = -_coefficient1 / (2 * _coefficient2);
                var root_img = sqrtDis / (2 * _coefficient2);

                var fullroot1 = Math.Round(root_real, _accuracy).ToString() + " + i" + Math.Round(root_img, _accuracy).ToString();
                var fullroot2 = Math.Round(root_real, _accuracy).ToString() + " - i" + Math.Round(root_img, _accuracy).ToString();

                _roots[0] = new Root(fullroot1, root_real, root_img);
                _roots[1] = new Root(fullroot2, root_real, root_img);
            }
        }
        private void ChangeAccuracy(int value)
        {
            _accuracy = value;
        }
    }
}