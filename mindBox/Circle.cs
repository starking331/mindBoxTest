using System;

namespace mindBox
{
    public class Circle : IFigure
    {
        public double Radius { get; }

        public Circle(double radius)
        {
            if (radius <= 0)
                throw new ArgumentException("Wrong radius",nameof(radius));
            Radius = radius;
        }

        public double Area => Math.PI * Math.Pow(Radius, 2);
    }
}