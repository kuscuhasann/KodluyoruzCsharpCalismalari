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
    }
    public class TohumluBitkiler:Bitkiler
    {
        public TohumluBitkiler()
        {
            base.fotosentezYapmak();
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
        }
        public void tohumsuzCogalma(){
            Console.WriteLine("Tohumsuz bitkiler sporla çoğalır");
        }
    }
}