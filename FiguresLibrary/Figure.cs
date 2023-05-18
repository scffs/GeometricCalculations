using System;

namespace FiguresLibrary
{
    public class Figure
    {
        public double Area;
        public double Perimeter;
        public virtual double GetArea()
        {
            return Area;
        }
        public virtual double GetPerimeter()
        {
            return Perimeter;
        }

        public void getInfo()
        {
            Console.WriteLine($"Area: {Math.Round(GetArea(), 2)}");
            Console.WriteLine($"Perimeter: {Math.Round(GetPerimeter(), 2)}");
        }

    }
}
