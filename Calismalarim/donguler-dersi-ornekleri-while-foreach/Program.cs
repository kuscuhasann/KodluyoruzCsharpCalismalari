using System;

namespace donguler_dersi_ornekleri_while_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
           //While
           //1 den başlarak girilen sayiya kadar(dahil) ortalama hesaplayıp yazdıran program
           Console.WriteLine("Lütfen bir sayı giriniz");
           int sayi=int.Parse(Console.ReadLine());
           int sayac=1;
           int toplam=0;
           while(sayac<=sayi){
               toplam+=sayac;
               sayac++;

           }
           Console.WriteLine(toplam/sayi);

            //A dan Z ye kadar tüm harfleri yazdır..
            char character='a';
            while (character<'z')
            {
                Console.Write(character);
                character++;
            }
            //Foreach
            string[] arabalar={"BMV","Ford","Toyota","Nissan"};
            foreach(var araba in arabalar){
                Console.WriteLine(araba);
            }
        }
    }
}
