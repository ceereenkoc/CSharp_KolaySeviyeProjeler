using System;

namespace ortalamahesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen sayı dizisi için derinlik giriniz:");
            FibanocciSayıDizisiYazdırma();
            
        }
        static void FibanocciSayıDizisiYazdırma()
        {
            int derinlik = Int32.Parse(Console.ReadLine());
            double[] dizi = new double[derinlik];
            int a, b = 1;
            int sonuç = 0;
            double toplam = 0;
            
            for (int i = 0; i < dizi.Length; i++) 
            {
                a = b; // b değişkeninin değerini a değişkenine atıyoruz.
                b = sonuç; // sonuç değişkeninin değerini b değerine atıyoruz.
                sonuç = a + b; // a ile b değerini toplayıp a değişkenine atıyoruz.
                toplam += sonuç;
                Console.Write(" " + sonuç);
            }
           
            Console.WriteLine("\n Ortalama: " + toplam/dizi.Length);

            Console.WriteLine("\n Ortalama:" + toplam/derinlik);
        }
    }
}
