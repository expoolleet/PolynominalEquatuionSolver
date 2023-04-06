namespace AlgebraicEquations
{
    public abstract class Equation
    {
        protected string _root;

        protected Root[] _roots;

        protected double _coefficient0;

        protected double _coefficient1;

        protected double _coefficient2;

        protected double _coefficient3;

        protected double _discriminant;

        protected private void SolveEquation()
        {
            FindDiscriminant();
            FindRoots();
        }

        protected virtual void FindDiscriminant() { }

        protected abstract void FindRoots();
    }
}