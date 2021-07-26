using System;

namespace oop_kalitim
{
    public class Hayvanlar:Canlilar
    {
        public Hayvanlar(){
            base.Beslenme();
            base.Bosaltim();
            base.Solunum();
        }
        protected void Adaptasyon(){
            Console.WriteLine("Hayvanlar Adaptasyon kurabilir");
        }
        public override void uyaranlaraTepki()
        {
            base.uyaranlaraTepki();
            Console.WriteLine("Hayvanlar temasa tepki verir.");
        }
    }
    public class Surungenler:Hayvanlar
    {
        public Surungenler(){
            base.Adaptasyon();
            base.uyaranlaraTepki();
        }
        public void surunerekHareketEtmek(){
            Console.WriteLine("Sürüngenler sürünerek hareket ederler");
        }
    }
    public class Kuslar:Hayvanlar
    {
        public Kuslar(){
            base.Adaptasyon();
            base.uyaranlaraTepki();
         }
        public void Ucmak(){
            Console.WriteLine("Kuşlar uçar");
        }
    }
}