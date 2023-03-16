
namespace AlgebraicEquations
{
    public abstract class Equation
    {
        protected double[] _roots;
        protected double _a0;
        protected double _a1;
        protected double _a2;
        protected double _a3;
        protected double _discriminant;

        protected virtual double[] SolveEquation(double a0, double a1)
        {
            _a0 = a0;
            _a1 = a1;
            SolveEquation();

            return _roots;
        }

        protected virtual double[] SolveEquation(double a0, double a1, double a2)
        {
            _a0 = a0;
            _a1 = a1;
            _a2 = a2;
            SolveEquation();

            return _roots;
        }

        protected virtual double[] SolveEquation(double a0, double a1, double a2, double a3)
        {
            _a0 = a0;
            _a1 = a1;
            _a2 = a2;
            _a3 = a3;
            SolveEquation();

            return _roots;
        }

        protected private void SolveEquation()
        {
            FindDiscriminant();
            FindRoots();
        }

        protected abstract void FindDiscriminant();

        protected abstract void FindRoots();
    }
}