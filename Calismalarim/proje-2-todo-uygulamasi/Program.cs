using System;

namespace proje_2_todo_uygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tanımlamalar
            int gelenIstek=0;
            //Menü
            menuGetir();

            //Seçimler
            bool sayiMi=int.TryParse(Console.ReadLine(),out gelenIstek);
            if(sayiMi)
            {
                if(gelenIstek==1)
                {
                  Console.WriteLine("Board Listele");
                }
                else if(gelenIstek==2)
                {
                  Console.WriteLine("Board'a kart ekle");
                }
                else if(gelenIstek==3)
                {
                   Console.WriteLine("Boardtan kart sil");
                }
                else if(gelenIstek==4)
                {
                  Console.WriteLine("Kart Taşı");
                }
                
            else
                {
                Console.WriteLine("Girmiş olduğunuz istek değeri alınamadı lütfen tekrar giriniz...");
                }
            }
        }
        static void menuGetir()
        {
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :)");
            Console.WriteLine("*******************************************");
            Console.WriteLine("(1) Board Listelemek");
            Console.WriteLine("(2) Board'a Kart Eklemek");
            Console.WriteLine("(3) Board'dan Kart Silmek");
            Console.WriteLine("(4) Kart Taşımak");
        }
        
    }
}
