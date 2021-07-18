using System;
using System.Collections.Generic;

namespace odev_bir_algoritma_sorulari
{
    class Program
    {
        static void Main(string[] args)
        {   
// //ÖDEVİN 1.KISMI
            // //Tanımlamalar
            // int girilenSayilar=0,kacAdetSayi=0;
            // List<int> ciftSayilar = new List<int>();
            

            // Console.WriteLine("Lütfen kaç adet pozitif sayi gireceğinizi belirleyiniz:  ");
            // kacAdetSayi=Convert.ToInt32(Console.ReadLine());

            // for(int i=1;i<=kacAdetSayi;i++)
            // {
            //     //Kullanicidan sayilarin istenmesi
            //     Console.WriteLine("Lütfen pozitif  sayi giriniz: Şuan {0}. sayi giriliyor",i);
            //     girilenSayilar=Convert.ToInt32(Console.ReadLine());
            //     if(girilenSayilar%2==0 && girilenSayilar>0)
            //     {
            //        //Cift Sayilarin tespiti ve sayilarin liste içerisine alinmasi
            //        ciftSayilar.Add(girilenSayilar);
                   
            //     } 
            // }
            // //Girilen Cift Sayilarin Ekrana Basimi
            // foreach (var item in ciftSayilar)
            // {
            // Console.WriteLine("Girilen cift sayilar= "+item);    
            // }
            
// //ÖDEVİN 2.KISMI
            // //Tanımlamalar
            // int girilenSayilarOdev2=0,kacAdetSayiOdev2=0,karsilastirmaSayisi=0;
            // List<int> karsilastirmaListesi = new List<int>();

            // Console.WriteLine("Lütfen kaç adet pozitif  sayi gireceğinizi belirleyiniz:  ");
            // kacAdetSayiOdev2=Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Lütfen sabit karşılaştırma sayısını giriniz :  ");
            // karsilastirmaSayisi=Convert.ToInt32(Console.ReadLine());


            // for(int i=1;i<=kacAdetSayiOdev2;i++)
            // {
            //     //Kullanicidan sayilarin istenmesi
            //     Console.WriteLine("Lütfen pozitif sayi giriniz: Şuan {0}. sayi giriliyor",i);
            //     girilenSayilarOdev2=Convert.ToInt32(Console.ReadLine());
            //     if(girilenSayilarOdev2>0 && girilenSayilarOdev2==karsilastirmaSayisi || girilenSayilarOdev2%karsilastirmaSayisi==0)
            //     {
                   
            //        karsilastirmaListesi.Add(girilenSayilarOdev2);
                   
            //     } 
            // }
            
            // foreach (var item in karsilastirmaListesi)
            // {
            // Console.WriteLine("Koşulu Sağlan İfadeler: "+item);
            // }

// //ÖDEV 3.KISIM
//             int kacAdetMetin=0;
//             string girilenMetinler;
//             List<string> metinListesi = new List<string>();

//             void kacDegerAlinacak()
//             {
//                 Console.WriteLine("Lütfen kaç adet kelime girmek istediğinizi belirleyiniz:  ");
//                 kacAdetMetin=Convert.ToInt32(Console.ReadLine());
//             }
//             try
//             {
//                 kacDegerAlinacak();
//             }
//             catch (System.Exception e)
//             {
//                 Console.WriteLine(" Yanlış bir değer girdiğiniz lütfen metin giriniz:  Hata : Detay: "+e);
//                 kacDegerAlinacak();
//             }
//             for(int i=1;i<=kacAdetMetin;i++)
//             {
//                 //Kullanicidan kelimelerin istenmesi
//                 Console.WriteLine("Lütfen kelimenizi giriniz: Şuan {0}. kelime giriliyor",i);
//                 girilenMetinler=Console.ReadLine();
//                 metinListesi.Add(girilenMetinler);  
//             }
//             metinListesi.Reverse();
//             foreach (var item in metinListesi)
//             {
//             Console.WriteLine("Tersten Metinleriniz: "+item);
//             }

            
            
//ÖDEV 4.KISIM    
             string cumleBilgisi;
             int totalWordsInSentence=0;
             int totalHarf=0;
             String[] words;

            void cumleGetir()
            {
                Console.WriteLine("Lütfen girmek istediğiniz cumleyi belirleyiniz:  ");
                cumleBilgisi=Console.ReadLine();
            }
            try
            {
                cumleGetir();
            }
            catch (System.Exception e)
            {
                Console.WriteLine(" Yanlış bir değer girdiğiniz lütfen metin giriniz:  Hata : Detay: "+e);
                cumleGetir();
            }
            words=cumleBilgisi.Split(" ");           
            totalWordsInSentence=words.Length;
            Console.WriteLine("Cümle içerisinde ki toplam kelime sayisi : "+totalWordsInSentence);

            for(int i=0;i<words.Length;i++)
            {
               totalHarf+=words[i].Length;
            }
            Console.WriteLine("Cümlede ki toplam harf sayisi: "+ totalHarf);
        }    
    }
}
