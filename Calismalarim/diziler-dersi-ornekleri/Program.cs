using System;

namespace diziler_dersi_ornekleri
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dizi Tanımlama
            string [] renkler=new string[5];
            string[] hayvanlar={"Kedi","Köpek","Kuş","Maymun"};
            int[] dizi;
            dizi=new int[5];
            //Dizilere Deger Atama ve Erisim
            renkler[0]="Mavi";
            dizi[3]=10;

            Console.WriteLine(hayvanlar[1]);

            //Döngüler dizi kullanımı
            //Klavyeden girilen n tane sayının ortalamasını hesaplayan program
            Console.WriteLine("Lütfen dizinin eleman sayısını giriniz");
            int diziUzunlugu=int.Parse(Console.ReadLine());
            int[] sayiDizisi=new int[diziUzunlugu];

            for (int i = 0; i < diziUzunlugu; i++)
            {
                Console.Write("Lütfen {0}. sayıyı giriniz: ",i+1);
                sayiDizisi[i]=int.Parse(Console.ReadLine());

            }
            int toplam=0;
            foreach (var sayi in sayiDizisi)
            {
                toplam+=sayi;
            }
            Console.WriteLine("Ortalama: "+toplam/diziUzunlugu);
        }
    }
}
