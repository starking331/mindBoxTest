using System;

namespace mindBox
{
    public class Triangle : IFigure
    {
        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }


        public Triangle(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0)
                throw new ArgumentException("Wrong side", nameof(sideA));

            if (sideB <= 0)
                throw new ArgumentException("Wrong side", nameof(sideB));

            if (sideC <= 0)
                throw new ArgumentException("Wrong side", nameof(sideC));
            var maxSide = Math.Max(sideA, Math.Max(sideB, sideC));
            var perimeter = sideA + sideB + sideC;
            if ((perimeter - maxSide) - maxSide < 0)
                throw new ArgumentException("The longest side of the triangle must be less than the sum of the other sides");

            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }
        public double Area
        {
            get
            {
                var semiPerimeter = (SideA + SideB + SideC) / 2d;
                return Math.Sqrt
                (
                    semiPerimeter * 
                    (semiPerimeter - SideA) * 
                    (semiPerimeter - SideB) * 
                    (semiPerimeter - SideC)
                );
            }
        }
    }
}