using System;

namespace switch_case_karar_yapisi_ornekleri
{
    class Program
    {
        static void Main(string[] args)
        {
            int month=DateTime.Now.Month;

        //expression
            switch (month)
            {
                case 1:
                    Console.WriteLine("Ocak Ayındasınız");
                    break;
                case 7:
                    Console.WriteLine("Temmuz Ayındasınız");
                    break;

                default:
                Console.WriteLine("Yanlış bir değer girdiniz");
                break;
            }

            switch (month)
            {
                case 1:
                case 2:
                case 4:
                Console.WriteLine("Kış ayındasınız");
                break;
                
                default:
                break;
            }
        }
    }
}
