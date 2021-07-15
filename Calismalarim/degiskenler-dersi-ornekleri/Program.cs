using System;

namespace degiskenler_dersi_ornekleri
{
    class Program
    {
        static void Main(string[] args)
        {
            int deger=2;
            //Büyük harf küçük harf duyarlı
            string degisken=null;
            string Degisken=null;
            
            //Console.WriteLine(deger);

            byte b=5; //2 byte
            sbyte c=5; //1 byte

            short s=5;   //2 byte
            ushort us=5; //2 byte

            Int16 i16=2;    //2 byte
            int i=2;        //4 byte
            Int32 i32=2;    //4 byte   
            Int64 i64=2;    //8 byte
            
            uint ıi=2;  //4 byte
            long l=4;   //8 byte
            ulong ul=4; //8 byte
            
            float f=5;    //4 byte
            double d=5;   //8 byte
            decimal de=5; //16 byte
            
            //"tanımlanamaz"=> 'tanımlanabilir'
            char ch='a';  //2 byte
            string str="Hasan";     //sınırsız

            bool b1=true;
            bool b2=false;

            DateTime dateTime=DateTime.Now;
            //Çalıştırdıktan sonra terminal sekmesine tıklayıp görebilirsin...
            Console.WriteLine(dateTime); //14.07.2021 14:38:59

            object o1="x";
            object o2='y';
            object o3=4;
            object o4=0.3;

            //string ifadeler

            string str1=string.Empty;
            str1="Hasan KUŞÇU";
            string kullanciAdi="Hasan";
            string kullanciciSoyad="Kuşçu";
            string tamIsim=kullanciAdi+" "+kullanciciSoyad;
            //Console.WriteLine(tamIsim);
            
            //integer tanımlama şekilleri

            int integer1=5;
            int integer2=4;
            int toplam=integer1+integer2;
            //Console.WriteLine(toplam);

            bool bool1=10>2;

            //Degisken Dönüşümleri
            string str20="22";
            int int20=20;
            string yeniDeger=str20+int20.ToString();
            Console.WriteLine(yeniDeger);//2220

            int int21= int20+Convert.ToInt32(str20);
            Console.WriteLine(int21);// 42

            int int22=int20+int.Parse(str20);//42
            //tarih getirmek için kullandigimiz yapi
            string datetime=DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(datetime);

            string datetime2=DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine(datetime2);
            //sadece saat ve dakikayı ogrenmek istersek
            string hour=DateTime.Now.ToString("HH:mm");
            Console.WriteLine(hour);
        }
    }
}
