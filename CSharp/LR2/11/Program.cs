using System;
using System.Text;

namespace Task11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input your string:");
            StringBuilder str = new StringBuilder(Console.ReadLine());
            int start = 0;
            for (int i = 0;i<str.Length;i++)
            {
                if(i==0 || str[i-1] == ' ')
                {
                    start = i;
                }
                if(Char.IsPunctuation(str[i]))
                {
                    str.Insert(start, str[i]);
                    i++;
                }
            }
            Console.WriteLine(str);
        }
    }
}
