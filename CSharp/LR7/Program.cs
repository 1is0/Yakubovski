using System;

namespace LR7
{
    class Program
    {

        static void Main(string[] args)
        {
            Fraction MyNum1 = new Fraction("-1/6");
            Console.WriteLine($"MyNum1: {MyNum1}");
            Fraction MyNum2 = new Fraction("5/4");
            Console.WriteLine($"MyNum2: {MyNum2}");
            Console.WriteLine($"MyNum1 + MyNum2: {MyNum1 + MyNum2}");
            Console.WriteLine($"MyNum1 - MyNum2: {MyNum1 - MyNum2}");
            Console.WriteLine($"MyNum1 * MyNum2: {MyNum1 * MyNum2}");
            Console.WriteLine($"MyNum1 / MyNum2: {MyNum1 / MyNum2}");
            Console.WriteLine($"MyNum1 > MyNum2: {MyNum1 > MyNum2}");
            Console.WriteLine($"MyNum1 < MyNum2: {MyNum1 < MyNum2}");
            Console.WriteLine($"MyNum1 >= MyNum2: {MyNum1 >= MyNum2}");
            Console.WriteLine($"MyNum1 <= MyNum2: {MyNum1 <= MyNum2}");
            Console.WriteLine($"MyNum1 == MyNum2: {MyNum1 == MyNum2}");
            Console.WriteLine($"MyNum1 != MyNum2: {MyNum1 != MyNum2}");
            Console.WriteLine("----------------------------");
            Fraction MyNum3 = new Fraction("5/4");
            Console.WriteLine($"MyNum3: {MyNum3}");
            Console.WriteLine($"MyNum2 == MyNum3: {MyNum2 == MyNum3}");
            Console.WriteLine($"MyNum2 != MyNum3: {MyNum2 != MyNum3}");
            Console.WriteLine("----------");
            Console.WriteLine($"17/8 as int: {(int)new Fraction("17/8")}");
            Console.WriteLine($"17/8 as float: {(float)new Fraction("17/8")}");
            Console.WriteLine($"9 as Fraction: {(Fraction)9}");
            Console.WriteLine($"5/4 as Fraction: {(Fraction)(5 / 4)}");

        }
    }
}
