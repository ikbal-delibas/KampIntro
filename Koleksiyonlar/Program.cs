using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> isimler = new List<string>();
            isimler.Add("İkbal");
            isimler.Add("Osman");
            isimler.Add("Aynur");
            isimler.Add("Engin");
            isimler.Add("Havva");
            isimler.Add("Nur");
            foreach (var isim in isimler)
            {
                Console.WriteLine(isim);
            }

            Console.WriteLine("************");
            for (int i = 0; i < isimler.Count; i++)
            {
                Console.WriteLine(isimler[i]);
            }

        }
    }
}
