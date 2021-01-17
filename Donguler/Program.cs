using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım geliştirici yetiştirme kampı";
            string kurs2 = "Programlamaya başlangıç için temel kurs";
            string kurs3 = "Java";

            //array - dizi

            string[] kurslar   = new string[] { "Yazılım geliştirici yetiştirme kampı","Programlamaya başlangıç için temel kurs", "Java" };

            for (int i = 0; i <kurslar.Length; i++) 
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For bitti");

            foreach (string kurs in kurslar) // foreach dizileri teker teker geziyor.
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa sonu - footer");
        }
    }
}
