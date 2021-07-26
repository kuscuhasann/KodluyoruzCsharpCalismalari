using System;

namespace oop_arayüzler_ornek
{
    public class Corolla : IOtomobil
    {
        public Marka HangiMarkaAraci()
        {
            return Marka.Toyota;
        }

        public int kacTekerlektenOlusur()
        {
            return 4;
        }

        public Renk StandartRengiNe()
        {
            return Renk.Gri;
        }
    }
}