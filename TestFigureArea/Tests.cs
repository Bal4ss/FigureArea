using System;
using FigureArea.Common.Figures;
using NUnit.Framework;

namespace TestFigureArea
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void CircleArea()
        {
            var circle = new Circle();

            Assert.Equals(circle.Area(), 0d);
        }
        
        [Test]
        public void TriangleArea()
        {
            var triangle = new Triangle();

            Assert.Equals(triangle.Area(), 0d);
        }
    }
}