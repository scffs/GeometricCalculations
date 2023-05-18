using System;

namespace FiguresLibrary
{
    public class Circumference : Figure
    {
        public double radius;
        public Circumference(double r)
        {
            radius = r;
        }
        public override double GetArea()
        {
            Area = Math.PI * Math.Pow(radius, 2);
            return Area;
        }
        public override double GetPerimeter()
        {
            Perimeter = 2 * Math.PI * radius;
            return Perimeter;
        }
    }
}
