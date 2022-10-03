using System;

namespace karakterterstenyazdırma
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Lütfen bir cümle giriniz:");
            string cümle = Console.ReadLine();

            char[] karakterler = cümle.ToCharArray(); // ToCharArray ile string ifadeki değerin karakterlere ayrılmasını sağladık ve bunu karakterler dizisine atadık.
            string ters = String.Empty; //String.Empty'i tanımlanan string değerin boş bir değer tutması için kullandık.
            for (int i = karakterler.Length - 1; i > -1; i--)
            {
                ters += karakterler[i];
            }

            Console.WriteLine(ters);

        }
    }
}