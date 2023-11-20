using System;
// Linus Aspelöf SUT23
namespace Labb_3___Polymorphism___Linus_Aspelöf_SUT23
{
    class Program
    {
        static void Main(string[] args)
        {
            Geometry[] Shapes = new Geometry[3];

            Shapes[0] = new Rectangle(5, 4);
            Shapes[1] = new Square(3);
            Shapes[2] = new Circle(2);

            foreach (var obj in Shapes)
            {
                Console.WriteLine($"Area: {obj.GetArea()}");
            }
        }
    }
}
