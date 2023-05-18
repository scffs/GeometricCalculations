using System;

namespace FiguresLibrary
{
    public class Triangle : Figure
    {
        public double aSide;
        public double bSide;
        public double cSide;

        public Triangle(double aSide, double bSide, double cSide)
        {
            this.aSide = aSide;
            this.bSide = bSide;
            this.cSide = cSide;

            if (aSide * aSide + bSide * bSide == cSide * cSide)
            {
                Console.WriteLine("Triangle is right");
            }
        }
        public override double GetArea()
        {
            double p = GetPerimeter() / 2;
            Area = Math.Sqrt(p * (p-aSide) * (p - bSide) * (p - cSide));
            return Area;
        }
        public override double GetPerimeter()
        {
            Perimeter = aSide + bSide + cSide;
            return Perimeter;
        }

    }
}
