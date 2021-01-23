using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Mylist<string> isimler = new Mylist<string>();
            isimler.Add("İlknur");

            Console.WriteLine(isimler.Length);

            foreach (var isim in isimler)
            {
                Console.WriteLine(isim);
            }
            
        }
    }
}
