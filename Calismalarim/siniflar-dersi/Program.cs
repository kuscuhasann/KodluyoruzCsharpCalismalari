using System;

namespace siniflar_dersi
{
    class Program
    {
        static void Main(string[] args)
        {
            //Public = her yerden  erişilebilir
            //Private = tanımlandığı sınıf içerisinde erişilebilir
            //Internal = Sadece kendi bulunduğu proje içerisinde
            //Protected = Sadece tanımlandığı sınıfta veya o sınıftan kalıtım alan diğer sınıflarda kullanılabilir.

            Calisan calisan1=new Calisan();
            calisan1.ad="Hasan";
            calisan1.soyAd="KUŞÇU";
            calisan1.no=1;
            calisan1.departman="Ar-Ge";
            calisan1.calisanBilgileri();

        }
    }
    class Calisan
    {
        public string ad;
        public string soyAd;
        public int no;
        public string departman;

        public void calisanBilgileri(){
            Console.WriteLine("Çalışan Adı: {0}",ad);
            Console.WriteLine("Çalışan Soyad: {0}",soyAd);
            Console.WriteLine("Çalışan No: {0}",no);
            Console.WriteLine("Çalışan Departmanı: {0}",departman);
        }
    }
}
