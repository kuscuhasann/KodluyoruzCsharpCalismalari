using System;

namespace operatorler_dersi_ornekleri
{
    class Program
    {
        static void Main(string[] args)
        {
            //Atama ve işlemli atama
            int x=3,y=2;
            y=y+2;
            //Console.WriteLine(y);
            y+=2;
            //Console.WriteLine(y);
            y/=1;
            //Console.WriteLine(y);
            x*=2;
            //Console.WriteLine(x);

            //Mantiksal Operatorler
            // || && !
            bool isSuccess=true;
            bool isComplated=false;
            if(isComplated)
            {
                Console.WriteLine("İşlem tamamlandı");
            }
            if(isSuccess || isComplated)
            Console.WriteLine("Great");
            if(isSuccess && !isComplated)
            Console.WriteLine("Fine");

            //İlişkisel operatorler
            //< , > ,<= ,>=,==,!=
            
            int a=3,b=4;
            bool sonuc=a<b;
            Console.WriteLine(sonuc);
            sonuc=a>b;
            Console.WriteLine(sonuc);
            sonuc=a>=b;
            Console.WriteLine(sonuc);
            sonuc=a<=b;
            Console.WriteLine(sonuc);
            sonuc=a==b;
            Console.WriteLine(sonuc);
            sonuc=a!=b;
            Console.WriteLine(sonuc);
            
            //Aritmetik op.(/,*,+,-)

            int sayi1=10,sayi2=2;
            int sonuc1=sayi1/sayi2;
            Console.WriteLine(sonuc1);
            sonuc1=sayi1*sayi2;
            Console.WriteLine(sonuc1);
            sonuc1=sayi1+sayi2;
            Console.WriteLine(sonuc1);
            sonuc1=sayi1++;
            Console.WriteLine(sonuc1);

            //% Mod alır
            int sonuc2=20%3;
            Console.WriteLine(sonuc2);
        }
    }
}
