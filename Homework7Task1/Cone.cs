namespace Homework7
{
    public class Cone
    {
        private double radius;
        private double height;
        public double Radius 
        { 
            get { return radius; } 
            init
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Radius must be greater than zero");
                }
                radius = value;
            } 
        }
        public double Height
        {
            get { return height; }
            init
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height must be greater than zero");
                }
                height = value;
            }
        }

        public Cone(double radius, double height)
        {
            Radius = radius;
            Height = height;
        }

        public double GetBaseSurfaceArea()
        {
            return Math.PI * Math.Pow(Radius, 2); 
        }

        public double GetFullSurfaceArea()
        {
            double l = Math.Sqrt(Math.Pow(Radius, 2) + Math.Pow(Height, 2));
            return Math.PI * Radius * l + GetBaseSurfaceArea();
        }
    }
}
