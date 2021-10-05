using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask
{
    class Program
    {
        static void Main(string[] args)
        {
            double t;
            Console.WriteLine("2 numbers");
            Console.WriteLine(Nod.Euclide(5, 10));
            Console.WriteLine(Nod.Euclide(0, 10));
            Console.WriteLine(Nod.Euclide(5, 0));
            Console.WriteLine(Nod.Euclide(0, 0));
            Console.WriteLine("3 numbers");
            Console.WriteLine(Nod.Euclide(-5, 10, -20));
            Console.WriteLine(Nod.Euclide(5, 0, 5));
            Console.WriteLine(Nod.Euclide(0, -1, 20));
            Console.WriteLine(Nod.Euclide(0, 0, 5));
            Console.WriteLine(Nod.Euclide(0, 0, 0));
            Console.WriteLine("Stein");
            Console.WriteLine(Nod.Stein(5, 10, out t));
            Console.WriteLine(Nod.Stein(0, 10, out t));
            Console.WriteLine(Nod.Stein(5, 0, out t));
            Console.WriteLine(Nod.Stein(0, 0, out t));
            Console.WriteLine(Nod.Stein(-5, 10, out t));
            t = 0;
            Console.WriteLine("Grafics");
            Console.WriteLine(Nod.TimesForGrafics(64, 100));
            Console.ReadKey();
        }
    }
}
