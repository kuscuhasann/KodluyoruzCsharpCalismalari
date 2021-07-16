using System;

namespace diziler_dersi_ornekler_iki
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sort
            int[] sayiDizisi={23,12,4,86,72,3,11,17};
            Console.WriteLine("Sırasız dizi");
            foreach (var item in sayiDizisi)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Sıralı Dizi");
            Array.Sort(sayiDizisi);
            foreach (var item in sayiDizisi)
            {
                Console.WriteLine(item);
            }

            //Clear
            Console.WriteLine("Clear");
            //sayiDizisi elamanlarını kullanarak 2.index ten itibaren 2 tane elemanı sıfırlar
            Array.Clear(sayiDizisi,2,2);

            foreach (var item in sayiDizisi)
            {
                Console.WriteLine(item);
            }
            //Reverse
            Console.WriteLine("Array Reverse");
            Array.Reverse(sayiDizisi);
            foreach (var item in sayiDizisi)
            {
                Console.WriteLine(item);
            }

            //IndexOf
            Console.WriteLine("IndexOf");
            Console.WriteLine(Array.IndexOf(sayiDizisi,23));
            //Resize
            Console.WriteLine("Resize");
            Array.Resize<int>(ref sayiDizisi,9);
            sayiDizisi[8]=99;
            foreach (var item in sayiDizisi)
            {
                Console.WriteLine(item);
            }
        }
    }
}
