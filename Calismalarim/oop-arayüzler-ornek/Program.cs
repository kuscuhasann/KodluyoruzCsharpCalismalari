using System;

namespace oop_arayüzler_ornek
{
    class Program
    {
        static void Main(string[] args)
        {
            Focus focus=new Focus();
            //Enum veri okunurken ToString() kullanılmalıdır
            Console.WriteLine(focus.HangiMarkaAraci().ToString());
            Console.WriteLine(focus.kacTekerlektenOlusur());
            Console.WriteLine(focus.StandartRengiNe().ToString());
        }
    }
}
