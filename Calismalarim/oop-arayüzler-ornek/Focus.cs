using System;

namespace oop_arayüzler_ornek
{
    public class Focus : IOtomobil
    {
        public Marka HangiMarkaAraci()
        {
            return Marka.Ford;
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