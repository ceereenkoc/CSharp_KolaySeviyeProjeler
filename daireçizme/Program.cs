using System;

namespace Daire_Cizme
{
    class Program
    {
        static void Main(string[] args)
        {
        double thickness = 0.4;
        Console.WriteLine("Yarıçapını giriniz: ");
        double yarıcap=double.Parse(Console.ReadLine());
        double r1 = yarıcap - thickness;
        double r2 = yarıcap + thickness;

        for (double i = yarıcap; i >= -yarıcap; i--)
        {
            for (double j = -yarıcap; j < r2; j += 0.5)
            {
                double value = j * j + i * i;
                if (value >= r1 * r1 && value <= r2 * r2)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
        }
    }
}
