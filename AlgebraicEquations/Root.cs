namespace AlgebraicEquations
{
    public class Root
    {
        private string _root;
        private double _real;
        private double _image;

        public double RealPart
        {
            get
            {
                return _real;
            }

            private set
            {
                RealPart = _real;
            }
        }

        public double ImgPart
        {
            get
            {
                return _image;
            }

            private set
            {
                ImgPart = _image;
            }
        }

        public Root(string root, double real, double image)
        {
            _root = root;
            _real = real;
            _image = image;
        }
        
        public string GetRoot()
        {
            return _root;
        }
    }
}