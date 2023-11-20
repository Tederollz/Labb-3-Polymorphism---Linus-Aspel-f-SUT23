using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_3___Polymorphism___Linus_Aspelöf_SUT23
{
    public class Geometry
    {
        public virtual double GetArea()
        {
            return 0.0;
        }
    }

    public class Rectangle : Geometry
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public override double GetArea()
        {
            double area = Length * Width;
            return Math.Round(area, 2);
        }
    }

    public class Square : Geometry
    {
        public double SideLength { get; set; }

        public Square(double sideLength)
        {
            SideLength = sideLength;
        }

        public override double GetArea()
        {
            double area = SideLength * SideLength;
            return Math.Round(area, 2);
        }
    }

    public class Circle : Geometry
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double GetArea()
        {
            double area = Math.PI * Radius * Radius;
            return Math.Round(area, 2);
        }
    }
}
