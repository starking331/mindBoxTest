using System;
using mindBox;
using NUnit.Framework;

namespace mindBoxTest
{
    public class CircleTest
    {
        private double epsilon = 1e-7;

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ZeroRadiusTest()
        {
            Assert.Catch<ArgumentException>(() => new Circle(0d));
        }


        [Test]
        public void NegativeRadiusTest()
        {
            Assert.Catch<ArgumentException>(() => new Circle(-1d));
        }


        [Test]
        public void GetSquareTest()
        {
            var radius = 5;
            var circle = new Circle(radius);
            var expectedValue = Math.PI * Math.Pow(radius, 2d);

            var square = circle.Area;

            Assert.Less(Math.Abs(square - expectedValue), epsilon);
        }
    }
}