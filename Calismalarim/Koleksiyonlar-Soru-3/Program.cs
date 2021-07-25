using System;
using System.Collections;

namespace Koleksiyonlar_Soru_3
{
    class Program
    {
        static void Main(string[] args)
        {
                //Soru - 3:
                //Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde saklayan ve dizinin elemanlarını sıralayan programı yazınız.
              
                //Not: best case dikkate alınıp isteler dışı kısıtlama yapılmamıştır.

                //Tanımlamalar
                string cumle;
                ArrayList harfListesi=new ArrayList();
                ArrayList sesliHarflerListesi=new ArrayList();
                string[] sesliHarfler = {"a","e","ı","i","o","ö","u","ü"};
                

                Console.WriteLine("Lütfen bir cümle giriniz : ");
                cumle=Console.ReadLine();
                //cümlenin kelimelerine bölümlenmesi
                var kelimeler=cumle.Split(' ');
                //Harfleri Tespiti
                for (int i = 0; i < kelimeler.Length; i++)
                {
                   for (int j = 0; j < kelimeler[i].Length; j++)
                   {  
                    //Kelimnin harflerine ayrıştırılması 
                    harfListesi.Add(kelimeler[i][j]);
                   }
                }
                //Sesli Harfleri Tespiti
                for (int i = 0; i < harfListesi.Count; i++)
                {
                    for (int j = 0; j < sesliHarfler.Length; j++)
                    {
                        if(harfListesi[i].ToString()==sesliHarfler[j])
                        {
                            sesliHarflerListesi.Add(harfListesi[i]);
                        }
                    }
                }
                //Sıralama
                sesliHarflerListesi.Sort();
                //Ekrana Basım
                Console.WriteLine("HARFLER: ");
                foreach (var item in sesliHarflerListesi)
                {
                    Console.Write(item);
                }
        }
    }
}
