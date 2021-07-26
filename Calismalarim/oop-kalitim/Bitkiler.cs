using System;

namespace oop_kalitim
{
    public class Bitkiler:Canlilar
    {
        public Bitkiler(){
            base.Beslenme();
            base.Bosaltim();
            base.Solunum();
        }
        protected void fotosentezYapmak(){
            Console.WriteLine("Bitkiler fotosentez yapar");
        }
        public override void uyaranlaraTepki()
        {
            base.uyaranlaraTepki();
            Console.WriteLine("Bitkiler güneşe tepki verir.");
        }
    }
    public class TohumluBitkiler:Bitkiler
    {
        public TohumluBitkiler()
        {
            base.fotosentezYapmak();
            base.uyaranlaraTepki();
        }
        public void tohumlaCogalma(){
            Console.WriteLine("Tohumlu bitkiler tohumla çoğalır");
        }
    }
    public class TohumsuzBitkiler:Bitkiler
    {
          public TohumsuzBitkiler()
        {
            base.fotosentezYapmak();
            base.uyaranlaraTepki();
        }
        public void tohumsuzCogalma(){
            Console.WriteLine("Tohumsuz bitkiler sporla çoğalır");
        }
    }
}