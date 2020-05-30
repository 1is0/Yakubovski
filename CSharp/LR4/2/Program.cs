using System;

namespace LR4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            Console.WriteLine("Rectangle 8 6");
            Console.WriteLine($"Perimeter: {Linker.Perimeter(8, 6)}");
            Console.WriteLine($"Area: {Linker.Area(8, 6)}");
            Console.WriteLine($"Diagonal: {Linker.Diagonal(8, 6)}");
        }
    }
}
