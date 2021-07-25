using System;

namespace siniflar_dersi_kapsülleme_propertyler
{
    class Program
    {
        static void Main(string[] args)
        {
           //Bir sınıfın üyelerini korumak için yaptığımız kavram =Kapsülleme(getter,setter)

           Ogrenci ogrenci1=new Ogrenci();
           ogrenci1.OgrenciAdi="Hasan";
           ogrenci1.OgrenciSoyIsim="KUŞÇU";
           ogrenci1.OgrenciNo=32;
           ogrenci1.OgrenciSinifi=4;
           //ogrenci1.ogrenciBilgileriGetir();
           //ogrenci1.sinifAtlat();
           //ogrenci1.ogrenciBilgileriGetir();
           
           Ogrenci ogrenci2=new Ogrenci("Bedri","KUŞÇU",10,1);
           ogrenci2.sinifDusur();
           ogrenci2.sinifDusur();
           ogrenci2.ogrenciBilgileriGetir();

        }
    }
    class Ogrenci
    {
        private string ogrenciAdi;
        private string ogrenciSoyIsim;

        private int ogrenciNo;

        private int ogrenciSinifi;
        //Kapsül
        public string OgrenciAdi { get => ogrenciAdi; set => ogrenciAdi = value; }
        public string OgrenciSoyIsim { get => ogrenciSoyIsim; set => ogrenciSoyIsim = value; }
        public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }
        public int OgrenciSinifi { 
            
            get => ogrenciSinifi; 
        
        set {
            if(value<1)
            {
                Console.WriteLine("Sınıf birden küçük olamaz.");
                ogrenciSinifi=1;
            }
            else
            ogrenciSinifi = value;
        }  
        }
        //Boş Kurucu
         public Ogrenci()
        {
            
        }
        // Dolu Kurucu
        public Ogrenci(string ogrenciAdi, string ogrenciSoyIsim, int ogrenciNo, int ogrenciSinifi)
        {
            OgrenciAdi = ogrenciAdi;
            OgrenciSoyIsim = ogrenciSoyIsim;
            OgrenciNo = ogrenciNo;
            OgrenciSinifi = ogrenciSinifi;
        }
        public void ogrenciBilgileriGetir()
        {
            Console.WriteLine("Ogrenci Adı: {0}",this.ogrenciAdi);
            Console.WriteLine("Ogrenci Soyadı: {0}",this.ogrenciSoyIsim);
            Console.WriteLine("Ogrenci No: {0}",this.ogrenciNo);
            Console.WriteLine("Ogrenci Sinifi: {0}",ogrenciSinifi);
        }
        public void sinifAtlat()
        {
            this.OgrenciSinifi+=1;
        }
        public void sinifDusur()
        {
            this.OgrenciSinifi-=1;
        }

       
    }
}
