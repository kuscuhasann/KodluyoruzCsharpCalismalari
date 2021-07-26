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
    }
    public class Surungenler:Hayvanlar
    {
        public Surungenler(){
            base.Adaptasyon();
        }
        public void surunerekHareketEtmek(){
            Console.WriteLine("Sürüngenler sürünerek hareket ederler");
        }
    }
    public class Kuslar:Hayvanlar
    {
        public Kuslar(){
            base.Adaptasyon();
         }
        public void Ucmak(){
            Console.WriteLine("Kuşlar uçar");
        }
    }
}