using FiguresLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GeometryTests
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void TriangleAreaTestMethod()
        {
            double a = 3;
            double b = 4;
            double c = 5;
            double expected = 6;

            Triangle triangle = new(a, b, c);
            double actual = triangle.GetArea();

            Assert.AreEqual(expected, actual, "Method is incorrect");
        }

        [TestMethod]
        public void TrianglePerimeterTestMethod()
        {
            double a = 3;
            double b = 4;
            double c = 5;
            double expected = 12;

            Triangle triangle = new(a, b, c);
            double actual = triangle.GetPerimeter();

            Assert.AreEqual(expected, actual, "Method is incorrect");
        }
    }
}
