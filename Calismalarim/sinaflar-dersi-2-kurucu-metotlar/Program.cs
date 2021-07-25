using System;

namespace sinaflar_dersi_2_kurucu_metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Calisan c1=new Calisan("Hasan","KUŞÇU",1,"Ar-Ge");
            c1.calisanBilgisi();
            Calisan c2=new Calisan("Selami","Işık");
            //Calisan bilgileri listelenirken 4 lü veri listelediğimiz için; int veri verilmemişse 0, string değer verilmemişse null ataması yapılır.
            c2.calisanBilgisi();
            
        }
    }
    class Calisan
    {
        public string ad;
        public string soyAd;
        public int no;
        public string departman;

        //Constructor
        public Calisan(string ad,string soyAd,int no, string departman)
        {
            this.ad=ad;
            this.soyAd=soyAd;
            this.no=no;
            this.departman=departman;
        }
        public Calisan(string ad,string Soyad)
        {
            this.ad=ad;
            this.soyAd=ad;
        }

        public void calisanBilgisi()
        {
            Console.WriteLine("Çalışan Adı: {0}",ad);
            Console.WriteLine("Çalışan Soyad: {0}",soyAd);
            Console.WriteLine("Çalışan No: {0}",no);
            Console.WriteLine("Çalışan Departmanı: {0}",departman);
        }
    }
}
