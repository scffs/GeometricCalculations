using FiguresLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GeometryTests
{
    [TestClass]
    public class CircumferenceTest
    {
        [TestMethod]
        public void CircumferenceAreaTestMethod()
        {
            double radius = 3;
            double expected = 28.274333882308138;

            Circumference circle = new(radius);
            double actual = circle.GetArea();

            Assert.AreEqual(expected, actual, "Method is incorrect");
        }

        [TestMethod]
        public void CircumferencePerimeterTestMethod()
        {
            double radius = 3;
            double expected = 18.849555921538759430775860299677;

            Circumference circle = new(radius);
            double actual = circle.GetPerimeter();

            Assert.AreEqual(expected, actual, "Method is incorrect");
        }
    }
}
