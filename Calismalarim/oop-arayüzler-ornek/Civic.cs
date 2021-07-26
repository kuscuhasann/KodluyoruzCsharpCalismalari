using System;

namespace oop_arayüzler_ornek
{
    public class Civic : IOtomobil
    {
        public Marka HangiMarkaAraci()
        {
            return Marka.Honda;
        }

        public int kacTekerlektenOlusur()
        {
            return 4;
        }

        public Renk StandartRengiNe()
        {
            return Renk.Beyaz;
        }
    }
}