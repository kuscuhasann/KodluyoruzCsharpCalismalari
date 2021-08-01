using System;

namespace proje_1_telefon_rehberi_uygulamsi
{
    public class RehberKisileri
    {
        string rehberIsim;
        string rehberSoyIsim;
        long telefonNumarasi;

        public string RehberIsim { get => rehberIsim; set => rehberIsim = value; }
        public string RehberSoyIsim { get => rehberSoyIsim; set => rehberSoyIsim = value; }
        public long TelefonNumarasi { get => telefonNumarasi; set => telefonNumarasi = value; }
        public RehberKisileri(){}
        public RehberKisileri(string rehberIsim, string rehberSoyIsim, long telefonNumarasi)
        {
            RehberIsim = rehberIsim;
            RehberSoyIsim = rehberSoyIsim;
            TelefonNumarasi = telefonNumarasi;
        }
    }
}