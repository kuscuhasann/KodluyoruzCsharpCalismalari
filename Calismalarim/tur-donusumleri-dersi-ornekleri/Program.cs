using System;

namespace tur_donusumleri_dersi_ornekleri
{
    class Program
    {
        static void Main(string[] args)
        {
            //Implicit Conversion(Bilinçsiz Dönüşüm) (mesela= sbyte'ın= byte degerine atanması)
            byte a=5;
            sbyte b=30;
            short c=10;
            int d=a+b+c;
            Console.WriteLine("d:"+d);
            
            //Explicit Conversion(Bilinçli Dönüşüm)

            int x=4;
            byte y=(byte)x;
            Console.WriteLine("y:"+y);

            int z=100;
            byte t=(byte)z;
            Console.WriteLine("t:"+t);

            float w=10.3f;
            byte v=(byte)w;
            Console.WriteLine("v: "+v);

            // toString()

            int sayicik=6;
            string donusenSayi=sayicik.ToString();
            Console.WriteLine("Donusmus sayi"+donusenSayi);

            // System.Convert
            string s1="10",s2="20";
            int sayi1,sayi2;
            int toplam;

            sayi1=Convert.ToInt32(s1);
            sayi2=Convert.ToInt32(s2);

            toplam=sayi1+sayi2;
            Console.WriteLine("toplam deger:"+toplam);

            //parse

            parseMethod();

        }
        public static void parseMethod()
        {
            string metin1="10";
            string metin2="10.25";
            int rakam1;
            double double1;

            rakam1=Int32.Parse(metin1);
            double1=Double.Parse(metin2);
            Console.WriteLine("rakam1"+metin1);
            Console.WriteLine("rakam1"+metin2);
        }
    }
}
