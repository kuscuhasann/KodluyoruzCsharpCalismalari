using System;

namespace enum_ornekler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Değeri belirli olan değişkenler olduğunda kodun okunabilirliği arttırmaktadır.
            Console.WriteLine(Gunler.Pazar);
            Console.WriteLine((int)Gunler.Cumartesi);

            int sicaklik=32;
            if(sicaklik<=(int)HavaDurumu.Normal)
            {
                Console.WriteLine("Dışarıya çıkmak için havanın ısınmasını bekle");
            }
            else if(sicaklik>=(int)HavaDurumu.Sıcak)
            Console.WriteLine("Dışarıya çıkmak için sıcak bir gün");
            else if(sicaklik>=(int)HavaDurumu.Normal && sicaklik<=(int)HavaDurumu.CokSıcak)
            Console.WriteLine("Hadi dışarıya çıkalım");
        }
    }
    enum Gunler
    {
        //Pazartesi-1 den başlatılırsa diğerleri +1 şeklinde olur
        Pazartesi=1,
        Sali,
        Çarşamba,
        Perşembe,
        Cuma,
        Cumartesi,
        Pazar,
    }
    enum HavaDurumu
    {
        Soguk=5,
        Normal=25,
        Sıcak=25,
        CokSıcak=30
    }
}
