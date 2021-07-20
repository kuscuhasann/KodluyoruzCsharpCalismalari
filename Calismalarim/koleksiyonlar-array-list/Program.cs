using System;
using System.Collections;
using System.Collections.Generic;

namespace koleksiyonlar_array_list
{
    class Program
    {
        static void Main(string[] args)
        {
            //System.Collection namespace i kullanır

            //Array List Oluşturmak
            ArrayList liste=new ArrayList();
            //Listeye eleman atmak
            // liste.Add("Ayşe");
            // liste.Add(2);
            // liste.Add(true);
            // liste.Add('A');

            //Liste içerisinde ki elemanlara erişim
            //indexleme ile çağırabiliyoruz
            //Console.WriteLine(liste[1]);
            //Foreach 
            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            //AddRange=> Birden fazla elemanı eklemeye yarar
            Console.WriteLine("AddRange:");
            string[] renkler={"yeşil","sarı","mavi","siyah","mor","beyaz"};
            //List<int> sayilar=new List<int>(){1,2,3,4,5};
            liste.AddRange(renkler);
            //liste.AddRange(sayilar);

            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            //Sort:> liste içerisinde sıralama yapar.
            Console.WriteLine("SORT");
            liste.Sort(); // İçeride birden farklı veri tipi bulunursa runtime da hata verecektir.
            //içerisinde sadece bir veri tipi olmalıdır.
            foreach (var item in liste)
            {
                Console.WriteLine(item);   
            }

            //Binary Search=>  liste içerisindeki istenilen değerin index değerini verir.
            //Binary Search kullanılmadan önce sıralanması gerekmektedir.
            Console.WriteLine(liste.BinarySearch(9));

            //Reverse=>Listeyi tersine çevirir
            liste.Reverse();
            Console.WriteLine("Tersine Çevrilmiş hali");
            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }
        }
    }
}
