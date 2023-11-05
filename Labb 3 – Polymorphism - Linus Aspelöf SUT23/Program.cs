using System;
// Linus Aspelöf SUT23
namespace Labb_3___Polymorphism___Linus_Aspelöf_SUT23
{
    class Program
    {
        static void Main(string[] args)
        {
            Geometri[] geometriskaFigurer = new Geometri[3];

            geometriskaFigurer[0] = new Rektangel(5, 4);
            geometriskaFigurer[1] = new Fyrkant(3);
            geometriskaFigurer[2] = new Cirkel(2);

            foreach (var figur in geometriskaFigurer)
            {
                Console.WriteLine($"Area: {figur.Area()}");
            }
        }
    }
}
