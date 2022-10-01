using System;

namespace Name
{
    class Program
    {
        static void Main(string[] args)
        {
            ÜçgenÇizdir();
        }

        static void ÜçgenÇizdir()
        {
            Console.WriteLine("Lütfen bir sayı giriniz:");
            int input = Int32.Parse(Console.ReadLine());
            for (int i = 0; i <= input; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" * ");
                }
                Console.WriteLine();
            }
        }
    }
}
