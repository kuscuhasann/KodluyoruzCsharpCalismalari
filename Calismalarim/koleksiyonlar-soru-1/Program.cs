using System;
using System.Collections;

namespace koleksiyonlar_soru_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Soru 1:
            //Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. (ArrayList sınıfını kullanara yazınız.)

            // Negatif ve numeric olmayan girişleri engelleyin.
            // Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
            // Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.

            //Tanımlamalar 
            int girilenSayi=0;
            bool asalDegilMi=false;
            int asalToplam=0,asalOlmayanToplam=0;
            ArrayList asalSayilar=new ArrayList();
            ArrayList asalOlmayanSayilar=new ArrayList();

            for(int i=1;i<=20;i++)
            {   asalDegilMi=false;
                Console.Write("Lütfen pozitif bir sayi giriniz: ");
                //girilen değer kontrolü(Sayı mı?- Karakter mi?)
                bool sayiKontrol=int.TryParse(Console.ReadLine(),out girilenSayi);
                if(sayiKontrol && girilenSayi>=0)
                {
                    Console.WriteLine("{0}. Girdiğiniz sayi= "+girilenSayi,i);
                    for (int j = 2; j < girilenSayi; j++)
                    {
                        //Asal olup olmadığı kontrolü
                        if (girilenSayi % j == 0)
                        {
                        asalDegilMi=true;
                        }
                    }
                    if(asalDegilMi)
                    {
                        asalOlmayanSayilar.Add(girilenSayi);
                        asalOlmayanToplam+=girilenSayi;
                    }
                    else
                    {
                        asalSayilar.Add(girilenSayi);
                        asalToplam+=girilenSayi;
                    }
                }
                else
                {
                    //Eğer hatalı giriş olduysa 20 değerden az sayi olmasının engellenmesi
                    Console.WriteLine("Hatalı bir giriş yaptınız: Lütfen pozitif bir sayi giriniz");
                    i--;
                }
                
            }
            //Ekrana basımların olduğu kısım
            Console.WriteLine("*****SONUÇ*******");
            Console.Write("Girmiş olduğunuz asal sayılar: "); 
            diziIicerigiListele(asalSayilar);
            Console.Write("\n");
            Console.Write("Girmiş olduğunuz asal olmayan sayilar: ");
            diziIicerigiListele(asalOlmayanSayilar);


            Console.WriteLine("\n"+"Kaç tane asal sayi var: "+asalSayilar.Count+"\n"+"Asal sayilar dizisinin ortalaması= "+asalToplam/asalSayilar.Count);
            Console.WriteLine("\n"+"Kaç tane asal olmayan sayi var: "+asalOlmayanSayilar.Count+"\n"+"Asal olmayan sayilar dizisinin ortalaması= "+asalOlmayanToplam/asalSayilar.Count);
        }
        public static void diziIicerigiListele(ArrayList liste)
        {
            //Sıralama ve tersine çevirim
            liste.Sort();
            liste.Reverse();
            
            foreach (var item in liste)
            {
                Console.Write(item+" ");
            }
        }
    }
}
