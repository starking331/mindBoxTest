using System;
using System.Reflection.Metadata.Ecma335;
using mindBox;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace Tests
{
    public class TriangleTest
    {
        private double epsilon = 1e-7;

        [TestCase(-1, 1, 1)]
        [TestCase(1, -1, 1)]
        [TestCase(1, 1, -1)]
        [TestCase(0, 0, 0)]
        public void InitTriangleWithErrorTest(double a, double b, double c)
        {
            Assert.Catch<ArgumentException>(() => new Triangle(a, b, c));
        }

        [Test]
        public void InitTriangleTest()
        {
            // Data.
            double a = 3d, b = 4d, c = 5d;

            // Act.
            var triangle = new Triangle(a, b, c);

            // Assert.
            Assert.NotNull(triangle);
            Assert.Less(Math.Abs(triangle.SideA - a), epsilon);
            Assert.Less(Math.Abs(triangle.SideB - b), epsilon);
            Assert.Less(Math.Abs(triangle.SideC - c), epsilon);
        }

        [Test]
        public void GetSquareTest()
        {
            // Data.
            double a = 3d, b = 4d, c = 5d;
            double result = 6d;
            var triangle = new Triangle(a, b, c);

            // Act.
            var square = triangle?.Area;

            // Assert.
            Assert.NotNull(square);
            Assert.Less(Math.Abs(square.Value - result), epsilon);
        }

        [Test]
        public void InitNotTriangleTest()
        {
            Assert.Catch<ArgumentException>(() => new Triangle(1, 1, 4));
        }
    }
}