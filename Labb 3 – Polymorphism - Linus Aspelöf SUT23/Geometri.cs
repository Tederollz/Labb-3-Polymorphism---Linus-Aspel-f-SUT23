using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_3___Polymorphism___Linus_Aspelöf_SUT23
{
    public class Geometri
    {
        public virtual double Area()
        {
            return 0.0;
        }
    }

    public class Rektangel : Geometri
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public Rektangel(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public override double Area()
        {
            return Length * Width;
        }
    }

    public class Fyrkant : Geometri
    {
        public double SideLength { get; set; }

        public Fyrkant(double sideLength)
        {
            SideLength = sideLength;
        }

        public override double Area()
        {
            return SideLength * SideLength;
        }
    }

    public class Cirkel : Geometri
    {
        public double Radius { get; set; }

        public Cirkel(double radius)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
