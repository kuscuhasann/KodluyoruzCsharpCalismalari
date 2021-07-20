using System;
using System.Collections.Generic;

namespace koleksiyonlar_iki_dersi_ornekleri_generic
{
    class Program
    {
        static void Main(string[] args)
        {
            // List<T> class
            // System.Collection.Generic Kütüphanesini Kullanılır
            //t-> object türündedir

            List<int> sayiListesi=new List<int>();
            sayiListesi.Add(23);
            sayiListesi.Add(10);
            List<string> renkListesi=new List<string>();
            renkListesi.Add("Kırmızı");
            renkListesi.Add("Mavi");

            //Count => Listenin uzunluğunun verir.
            Console.WriteLine(renkListesi.Count);
            Console.WriteLine(sayiListesi.Count);
            //Listenin ekrana bastırılması
            foreach (var item in sayiListesi)
            {
                Console.WriteLine(item);
            }

            //Listeden eleman çıkartılması
            sayiListesi.Remove(4);
            //İndex ile eleman çıkartma
            sayiListesi.RemoveAt(1);
            
            //Liste içerisinde arama yapmak 10 değeri varsa true döndürür.
            if(sayiListesi.Contains(10))
            {
                Console.WriteLine("10 liste içerisinde bulundu");
            }

            //ELeman ile index bulunması
            Console.WriteLine(renkListesi.BinarySearch("Mavi"));

            //Diziyi List e çevirme
            string[] hayvanlar={"Kedi","Köpek","Kuş"};
        
            List <string> hayvanlarListesi=new List<string>(hayvanlar);

            //Listenin temizlenmesi
            hayvanlarListesi.Clear();

            //List içerisinde nesne tutmak
            List <Kullanicilar> kullanicilarListesi=new List<Kullanicilar>();
            Kullanicilar kullanici1=new Kullanicilar();
            kullanici1.Isim="Hasan";
            kullanici1.SoyIsim="Kuşçu";
            kullanici1.Yas=23;
            Kullanicilar kullanici2=new Kullanicilar();
            kullanici2.Isim="Onur";
            kullanici2.SoyIsim="Toy";
            kullanici2.Yas=23;

            kullanicilarListesi.Add(kullanici1);
            kullanicilarListesi.Add(kullanici2);

            foreach (var item in kullanicilarListesi)
            {
                Console.WriteLine(item.Isim);
                Console.WriteLine(item.SoyIsim);
                Console.WriteLine(item.Yas);
            }          
        }
    }
    public class Kullanicilar{
        string isim;
        string soyIsim;
        int yas;

        public string Isim { get => isim; set => isim = value; }
        public string SoyIsim { get => soyIsim; set => soyIsim = value; }
        public int Yas { get => yas; set => yas = value; }
    }
}
