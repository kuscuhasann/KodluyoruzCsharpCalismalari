using System;
using System.Collections.Generic;

namespace koleksiyonlar_dort_dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //Not: Tanımlanan Keyler Benzersiz olmalıdır.

            //Dictionary=> System.collections.generic
            
            //Dictionary Tanımlanması 1.Key 2.si value.
            Dictionary<int,string> plaka=new Dictionary<int, string>();

            //Eleman ekleme
            plaka.Add(10,"Balıkesir");
            plaka.Add(16,"Bursa");
            plaka.Add(34,"İstanbul");
            plaka.Add(35,"İzmir");

            //Elemanlarına erişim
            Console.WriteLine("ELemanlara Erişim");
            Console.WriteLine(plaka[16]);
            foreach (var item in plaka)
            {
                Console.WriteLine(item);
            }

            //Count=> Dizinin uzunluğunu verir
            Console.WriteLine(plaka.Count);

            // Contains => ContainsKey ContainsValue iki farklı metot (içeriyor mu?)
            Console.WriteLine(plaka.ContainsKey(16)); // True döner
            Console.WriteLine(plaka.ContainsValue("Bursa")); //True döner

            //Eleman Çıkartmak
            Console.WriteLine("Remove");
            plaka.Remove(16);
            foreach (var item in plaka)
            {
                //Sadece değerlerine yazdırmak
                Console.WriteLine(item.Value);
            }

            //Keys
             Console.WriteLine("************Keys");
             foreach (var item in plaka.Keys)
             {
                 Console.WriteLine(item);
             }
            //Values
             Console.WriteLine("*********Values");
             foreach (var item in plaka.Values)
             {
                 Console.WriteLine(item);
             }
        }
    }
}
