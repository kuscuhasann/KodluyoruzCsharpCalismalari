using System;

namespace oop_kalitim
{
    class Program
    {
        static void Main(string[] args)
        {
            //Notlar sealed bir klasa verirlirsa o class kalıtım veremez
            //Overrida sınıflarda gösterilmiştir.















            // TohumluBitkiler tohumluBitki=new TohumluBitkiler();
            //Canlılar Sınıfından beslenme metodunun katılım ile almaktadır.
            //3 metodu canli olduğu için almıştır.
            // tohumluBitki.Beslenme();
            // tohumluBitki.Solunum();
            // tohumluBitki.Bosaltim();
            //Bitkiler sınıfından katılım ile
            
            //kendisine ait metod
            // tohumluBitki.tohumlaCogalma();

            // Console.WriteLine("***********");

            // Kuslar marti=new Kuslar();

            // marti.Beslenme();
            // marti.Solunum();
            // marti.Bosaltim();
            // marti.Ucmak();

            //NOT: İLGİLİ METOTLARIN ERİŞİM BELİRTEÇLERİ PUBLİC SE YUKARIDAKİ GİBİ KULLANILABİLMEKTEDİR
            //FAKAT PROTECTED İSE: 
            //Üst sınıfın metotlarına alt sınıfta base.metotadı ile constructor da erişilmelidir.

            TohumluBitkiler tohumluBitki=new TohumluBitkiler();
            
            tohumluBitki.tohumlaCogalma();

            Console.WriteLine("***********");

            Kuslar marti=new Kuslar();
            marti.Ucmak();
            
        }
    }
}
