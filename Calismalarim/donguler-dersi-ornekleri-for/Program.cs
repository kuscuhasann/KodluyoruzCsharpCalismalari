using System;

namespace donguler_dersi_ornekleri_for
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ekrana girilen sayıya kadar olan tek sayilari ekrana basimi
            Console.WriteLine("Lütfen bir sayi giriniz: ");
            int sayac=int.Parse(Console.ReadLine());
            for(int i=1;i<=sayac;i++){
                if(i%2==1){
                    Console.WriteLine(i);
                }
            }

            //1 ile 1000 arasındaki sayıların kendi içlerinde toplanıp ekrana yazdırılması
            int tekToplam=0,ciftToplam=0;
            for (int i = 0; i < 1000; i++)
            {
                if(i%2==1){
                    tekToplam+=i;
                }
                else
                    ciftToplam+=i;
            } 

            Console.WriteLine("Tek Toplam: "+ tekToplam);
            Console.WriteLine("Cift Toplam: "+ ciftToplam);

            //break,continue

            for (int i = 0; i < 10; i++)
            {
                if (i==4)
                {
                    break;
                }
                Console.WriteLine(i);
            }
            for (int i = 0; i < 10; i++)
            {
                if (i==4)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }
    }
}
