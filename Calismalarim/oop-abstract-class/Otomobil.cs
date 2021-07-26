using System;

namespace oop_abstract_class
{
    public abstract class Otomobil
    {
        public int kacTekerlektenOlusur(){
            return 4;
        }
        public virtual Renk StandartRengiNe(){
            return Renk.Beyaz;
        }
        public abstract Marka HangiMarkaninAraci();
    }
}