using System;

namespace karar_yapilari_dersi_ornekleri
{
    class Program
    {
        static void Main(string[] args)
        {
            int time=DateTime.Now.Hour;
            if(time<=18)
            Console.WriteLine("İyi Günler");
            else
            Console.WriteLine("İyi Günler");

            string sonuc =time<=18? "iyi günler":"iyi geceler";
            Console.WriteLine(sonuc);

        }
    }
}
