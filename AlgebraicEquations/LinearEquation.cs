using PolynomialCalculation;
using System;

namespace AlgebraicEquations
{
    internal class LinearEquation : Equation
    {
        private int _accuracy;

        public LinearEquation(MainForm mainForm)
        {
            _accuracy = mainForm.AccuracyOfDecimalPlaces;

            mainForm.ChangeAccuracyOfDecimalPlaces += ChangeAccuracy;
        }

        public Root[] SolveEquation(double coefficient1, double coefficient0)
        {
            _coefficient1 = coefficient1;
            _coefficient0 = coefficient0;

            SolveEquation();

            return _roots;
        }

        protected override void FindRoots()
        {
            _roots = new Root[1];

            var root = -_coefficient0 / _coefficient1;

            var fullroot = Math.Round(root, _accuracy).ToString();

            _roots[0] = new Root(fullroot, root, 0);
        }

        private void ChangeAccuracy(int value)
        {
            _accuracy = value;
        }
    }
}