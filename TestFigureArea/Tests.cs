using System;
using System.Collections.Generic;
using FigureArea.Common;
using FigureArea.Common.Figures;
using NUnit.Framework;

namespace TestFigureArea
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void CircleRawArea()
        {
            var circle = new Circle();

            Assert.AreEqual(0d, circle.Area());
        }
        
        [Test]
        public void TriangleRawArea()
        {
            var triangle = new Triangle();

            Assert.AreEqual(0d, triangle.Area());
        }

        [Test]
        [TestCaseSource(nameof(CircleAreaTestValue))]
        public void CircleArea(double radius, double expectedValue)
        {
            var circle = new Circle(radius);
            
            var result = Math.Round(circle.Area(), 2);
            
            Assert.AreEqual(expectedValue, result);
        }
        
        [Test]
        [TestCaseSource(nameof(TriangleAreaTestValue))]
        public void TriangleArea(double a, double b, double c, double expectedValue)
        {
            var triangle = new Triangle(a, b, c);

            var result = Math.Round(triangle.Area(), 2);

            Assert.AreEqual(expectedValue, result);
        }
        
        [Test]
        [TestCaseSource(nameof(TriangleAreaErrorTestValue))]
        public void TriangleAreaError(double a, double b, double c)
        {
            var triangle = new Triangle(a, b, c);

            Assert.Catch<ArgumentOutOfRangeException>(() => { Math.Round(triangle.Area(), 2); });
        }

        [Test]
        [TestCaseSource(nameof(FigureAreaTestValue))]
        public void FigureArea(IFigure figure, double expectedValue)
        {
            var result = Math.Round(figure.Area(), 2);

            Assert.AreEqual(expectedValue, result);
        }

        [Test]
        [TestCaseSource(nameof(TriangleIsRightTestValue))]
        public void TriangleIsRight(double a, double b, double c, bool expectedValue)
        {
            var triangle = new Triangle(a, b, c);
            
            Assert.AreEqual(expectedValue, triangle.IsRight);
        }

        private static IEnumerable<TestCaseData> TriangleIsRightTestValue
        {
            get
            {
                yield return new TestCaseData(3, 4, 5, true);
                yield return new TestCaseData(3, 4, 3, false);
                yield return new TestCaseData(17, 15, 8, true);
            }
        }

        private static IEnumerable<TestCaseData> FigureAreaTestValue
        {
            get
            {
                yield return new TestCaseData(new Triangle(3, 4, 5), 6);
                yield return new TestCaseData(new Triangle(2, 4, 4), 3.87);
                yield return new TestCaseData(new Triangle(3, 6, 8), 7.64);
                yield return new TestCaseData(new Circle(2), 12.57);
                yield return new TestCaseData(new Circle(1), 3.14);
                yield return new TestCaseData(new Circle(5), 78.54);
            }
        }

        private static IEnumerable<TestCaseData> TriangleAreaErrorTestValue
        {
            get
            {
                yield return new TestCaseData(1, 15, 2);
                yield return new TestCaseData(1, 2, 25);
            }
        }

        private static IEnumerable<TestCaseData> TriangleAreaTestValue
        {
            get
            {
                yield return new TestCaseData(3, 4, 5, 6);
                yield return new TestCaseData(2, 4, 4, 3.87);
                yield return new TestCaseData(3, 6, 8, 7.64);
            }
        }

        private static IEnumerable<TestCaseData> CircleAreaTestValue
        {
            get
            {
                yield return new TestCaseData(2, 12.57);
                yield return new TestCaseData(1, 3.14);
                yield return new TestCaseData(5, 78.54);
                yield return new TestCaseData(0, 0);
            }
        }
    }
}