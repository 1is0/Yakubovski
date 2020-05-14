using System;
using System.Numerics;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger numA;
            BigInteger numB;
            while (true)
            {
                numA = ReadBigInteger("first num");
                numB = ReadBigInteger("second num");
                if (numA > numB)
                {
                    Console.WriteLine("The first number must be greater than the second.");
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                    break;
            }
            int counter = 0;
            BigInteger num = numA;
            if (!num.IsEven)
                num += 1;
            while (num <= numB)
            {
                BigInteger tmp = num;
                while (true)
                {
                    if (!tmp.IsEven)
                        break;
                    tmp /= 2;
                    counter++;
                }
                num += 2;
            }
            Console.WriteLine("Result: " + counter);
        }
        static BigInteger ReadBigInteger(string varName = "")
        {
            BigInteger num;
            while (true)
            {
                Console.Write("Input {0}: ", varName);
                if (BigInteger.TryParse(Console.ReadLine(), out num) && num > 0)
                {

                    break;
                }
                Console.WriteLine("Invalid Input.");
                Console.ReadLine();
                Console.Clear();
            }
            return num;
        }
    }

}
