using System;

namespace rekursif_extension_fonksiyonlar_dersi_ornekleri
{
    class Program
    {
        static void Main(string[] args)
        {
           //rekürsif(Kendi kendini çağıran foksiyon denir)
           //3^4
            int result=1;
           for (int i = 1; i < 5; i++)
           {
               result*=3;
           }
           Console.WriteLine(result);
            Islemler islemler=new Islemler();
            Console.WriteLine(islemler.expo(3,2));

            //Extension Metotlar
            //Extension metotlar static olmalıdır yoksa bu metotlara erişemezsiniz.
            string ifade="Selamlar Ben Hasan";
            bool sonuc=ifade.checkSpaces();
            
            //Console.WriteLine(sonuc);  result=true;
            Console.WriteLine(ifade.makeLowerCase());
            Console.WriteLine(ifade.makeUpperCase());

        }
    }
    public class Islemler{
        public int expo(int sayi,int us){
            
            if(us<2)
                return sayi;
            return expo(sayi,us-1)*sayi;
        }   
    }
    public static class Extension{
        public static bool checkSpaces(this string param){
            //Contains " " boşluğu içeriyor mu?
            return param.Contains(" ");
        }
        public static string removeWhiteSpace(this string param){
            string[] dizi=param.Split(" ");
            return string.Join("",dizi);
        }
        public static string makeUpperCase(this string param){
            return param.ToUpper();
        }
        public static string makeLowerCase(this string param){
            return param.ToLower();
        }

    }
}
