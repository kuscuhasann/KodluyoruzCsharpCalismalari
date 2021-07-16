using System;

namespace metotlar_overloading_dersi_ornekleri
{
    class Program
    {
        static void Main(string[] args)
        {
            //alt parametreler
            string sayi="999";
            int outSayi;
            bool sonuc=int.TryParse(sayi,out outSayi);
            if(sonuc){
                Console.WriteLine("Başarılı");
                Console.WriteLine(outSayi);
            }
            else
            Console.WriteLine("Başarısız");

            Metotlar metotlar=new Metotlar();
            metotlar.topla(3,2,out int toplamSonucu);
            Console.WriteLine(toplamSonucu);

            //Metot Aşırı Yükleme-Overloading
            int ifade=99;
            metotlar.ekranaYazdir(ifade);
            
        }
    }
    class Metotlar{
        public void topla(int a, int b, out int toplam){
            
            toplam=a+b;
        }
        public void ekranaYazdir(string veri){
            Console.WriteLine(veri);
        }
        public void ekranaYazdir(int veri){
            Console.WriteLine(veri);
        }
    }
}
