using System;

namespace AlgebraicEquations
{
    public class QuadraticEquation : Equation
    {

        public QuadraticEquation()
        {
            
        }

        public override SolveEquation

        protected override void FindDiscriminant()
        {
            _discriminant = Math.Pow(_a1, 2) - 4 * _a0 * _a2;
        }

        //protected override void FindRoots()
        //{
        //    if (discriminant >= 0)
        //    {
        //        var sqrtDis = Math.Sqrt(discriminant);

        //        var root1 = (-b + sqrtDis) / (2 * a);
        //        var root2 = (-b - sqrtDis) / (2 * a);

        //        _roots[0].Text = Math.Round(root1, _accuracy).ToString();
        //        _roots[1].Text = Math.Round(root2, _accuracy).ToString();

        //        _func[0].Text = Math.Round(a * Math.Pow(root1, 2) + b * root1 + c, 0).ToString();
        //        _func[1].Text = Math.Round(a * Math.Pow(root2, 2) + b * root2 + c, 0).ToString();
        //    }
        //    else
        //    {
        //        var sqrtDis = Math.Sqrt(Math.Abs(discriminant));

        //        var root_real = -b / (2 * a);
        //        var root_img = sqrtDis / (2 * a);

        //        _roots[0].Text = Math.Round(root_real, _accuracy).ToString() + " + i" + Math.Round(root_img, _accuracy).ToString();
        //        _roots[1].Text = Math.Round(root_real, _accuracy).ToString() + " - i" + Math.Round(root_img, _accuracy).ToString();

        //        _func[0].Text = Math.Round(a * (Math.Pow(root_real, 2) + -Math.Pow(root_img, 2)) + b * root_real + c, 0).ToString();
        //        _func[1].Text = Math.Round(a * (Math.Pow(root_real, 2) + -Math.Pow(root_img, 2)) + b * root_real + c, 0).ToString();
        //    }
        //}
    }
}

