using System;

namespace siniflar_dersi_3_static_siniflar_uyeleri
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Çalışan sayisi: {0}",Calisan.CalisanSayisi);

            Calisan calisan=new Calisan("Hasan","KUŞÇU","Yazılım");
            Console.WriteLine("Çalışan sayisi: {0}",Calisan.CalisanSayisi);

            //Statik sınıf Islemler ornekleri
            //Statik sınıfın üyelerine sadece sınıf adı. diye erişilebilir
            //HATA :Islemler islemler=new Islemler();
            Console.WriteLine("Toplama işleminin sonucu: {0}",Islemler.Topla(5,3));
            Console.WriteLine("Çıkartma işleminin sonucu: {0}",Islemler.Cikar(8,2)); 

        }
    }
    class Calisan{
        //Bir sınıfı statik yaparsak bütün üyeleri statik olmak zorundadır.
        private static int calisanSayisi;

        public static int CalisanSayisi { get => calisanSayisi;}

        private string isim;

        private string soyIsim;
        private string departman;

        //Statik Kurucu=erişim belirteçleri olmaz
        static Calisan()
        {
            calisanSayisi=0;
        }

        public Calisan(string isim,string soyIsim,string departman){
            
            this.isim=isim;
            this.soyIsim=soyIsim;
            this.departman=departman;
            calisanSayisi++;

        }
    }

    static class Islemler
    {
        public static long Topla(int sayi1,int sayi2)
        {
            return sayi1+sayi2;
        }
        public static long Cikar(int sayi1,int sayi2)
        {
            return sayi1-sayi2;
        }
    }

}
