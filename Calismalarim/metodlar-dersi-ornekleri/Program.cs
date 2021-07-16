using System;

namespace metodlar_dersi_ornekleri
{
    class Program
    {
        static void Main(string[] args)
        {
            Metotlar metotlar=new Metotlar();
            int a=2,b=3;
            int sonuc=metotlar.arttirveTopla(a,b);
            Console.WriteLine(sonuc);

           metotlar.ekranaYazdir(sonuc.ToString());
        }
        static int topla(int deger1,int deger2){
            return deger1+deger2;
        }
    }
    class Metotlar{
        public void ekranaYazdir(string veri){
            Console.WriteLine(veri);
        }

        public int arttirveTopla(int deger1,int deger2)
        {
            deger1+=1;
            deger2+=1;
            return deger1+deger2;
        }
    }
}
