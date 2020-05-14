using System;
using System.Text;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input your string:");
            string input = Console.ReadLine();
            string tmp;
            foreach (char letter in input)
            {
                tmp = string.Format("{0:X} ", Convert.ToInt32(letter));
                Console.Write(tmp.PadLeft(5, '0'));
            }
        }
    }
}
