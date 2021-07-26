using System;

namespace struct_nedir
{
    class Program
    {
        static void Main(string[] args)
        {
            //Structlar değer tipindedir.

            //Sınıf
            Dikdortgen dikdortgen=new Dikdortgen();
            dikdortgen.kisaKenar=3;
            dikdortgen.uzunKenar=6;
            Console.WriteLine("Class Alan Hesabı: {0}",dikdortgen.AlanHesapla());
            //Struct
            //Newlemeden çağrılabilir
            //parametresiz constructora izin vermez.
            //Neden Structları kullanmalıyız?
            //*16bayt kadar struct 16bayttan sonra class kullanılmalı (Uzman önerisi..)
            Dikdortgen_Struct dikdortgenS;
            dikdortgenS.kisaKenar=3;
            dikdortgenS.uzunKenar=6;
            Console.WriteLine("Struct Alan Hesabı: {0}",dikdortgenS.AlanHesapla());
        }
    }
    class Dikdortgen
    {
        public int kisaKenar;
        public int uzunKenar;

        public long AlanHesapla(){
            return kisaKenar*uzunKenar;
        }

    }
    //Yukarıda yazılımış class'ın struct hali: 
    struct Dikdortgen_Struct
    {
         public int kisaKenar;
        public int uzunKenar;

        public long AlanHesapla(){
            return kisaKenar*uzunKenar;
        }
    }
}
