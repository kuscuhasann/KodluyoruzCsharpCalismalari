using System;

namespace Koleksiyonlar_Soru_2
{
    class Program
    {
        static void Main(string[] args)
        {
        //    Soru - 2: Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan, 
        //    her iki grubun kendi içerisinde ortalamalarını alan ve bu ortalamaları ve ortalama toplamlarını console'a yazdıran programı yazınız. 
        //    (Array sınıfını kullanarak yazınız.)
              
             //Not: Girilen sayilar best case gibi kabul edilmiştir, isterler dışı kısıtlamalar yapılmamıştır.

              //Tanımlamalar
              int[] sayilar=new int[20];
              int gelenSayi=0,enKucukSayilarToplami=0,enBuyukSayilarToplami=0,kucuklerinOrtalamasi=0,buyuklerinOrtalamasi=0,ortalamaToplamlari=0;

              for (int i = 0; i <20; i++)
              {
                  Console.WriteLine("Lütfen bir sayi giriniz: Şu anda {0}. sayidasiniz ",i+1);
                  gelenSayi=Convert.ToInt32(Console.ReadLine());

                  sayilar[i]=gelenSayi;
                  
              }
              Array.Sort(sayilar);
              //for döngüsü kullanılarakta yapılabilir
              Console.WriteLine("Girilen Sayilardan en küçük üç tanesi= "+sayilar[0]+" "+sayilar[1]+" "+sayilar[2]);
              enKucukSayilarToplami=sayilar[0]+sayilar[1]+sayilar[2];
              Console.WriteLine("Girilen Sayilardan en büyük üç tanesi= "+sayilar[sayilar.Length-1]+" "+sayilar[sayilar.Length-2]+" "+sayilar[sayilar.Length-3]);
              enBuyukSayilarToplami=sayilar[sayilar.Length-1]+sayilar[sayilar.Length-2]+sayilar[sayilar.Length-3];
              kucuklerinOrtalamasi=enKucukSayilarToplami/3;
              buyuklerinOrtalamasi=enBuyukSayilarToplami/3;
              ortalamaToplamlari=kucuklerinOrtalamasi+buyuklerinOrtalamasi;

              Console.WriteLine("En küçük sayıları ortalaması : "+kucuklerinOrtalamasi);
              Console.WriteLine("En büyük sayıların ortalaması : "+buyuklerinOrtalamasi);
              Console.WriteLine("İki ortalamanın toplamı : "+ ortalamaToplamlari);
              
              
        }
    }
}
