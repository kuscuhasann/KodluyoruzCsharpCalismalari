using System;

namespace string_metotlar_dersi_ornekleri
{
    class Program
    {
        static void Main(string[] args)
        {
            string degisken="Dersimiz CSharp, Hoşgeldiniz";
            string degisken2="Dersimiz CSharp";
            
            //Length
            Console.WriteLine(degisken.Length);

            //ToUpper ,ToLower
            Console.WriteLine(degisken.ToUpper());
            Console.WriteLine(degisken.ToLower());

            //Concat: İki string birleştirilirken kullanılır
            Console.WriteLine(String.Concat(degisken,"Merhaba"));

            //CompareTo : 2 string değeri karşılaştırır.
            // 1. degisken 2.degiskene eşit olursa = 0 döndürür.
            // 1. degisken 2.degiskenden daha büyük karakter sayisina sahipse 1 dönüdür.
            // 1. degisken 2.degsikenden daha küçük bir karakter sayisina sahipse bana -1 dönüdür.
            Console.WriteLine(degisken.CompareTo(degisken2));

            //Compare =CompareTo ile aynı işi yapar ve aynı geri dönüş değerlerine sahiptir.
            //Eğer true dersen büyük küçük harf duyarsızlaşır ignoreCase
            Console.WriteLine(String.Compare(degisken,degisken2,true));

            //Contains = Değişken 1 in içerisinde değişken 2 varmı bulursa true doner
            Console.WriteLine(degisken.Contains(degisken2));

            //EndsWith: Yazılan parametre ile bitiyor mu
            Console.WriteLine(degisken.EndsWith("Hoşgeldiniz")); //true
            //StartsWith: Yazılan parametre ile başlıyor mu
            Console.WriteLine(degisken.StartsWith("Merhaba")); //false

            //IndexOf: Değişken içerisinde ilgili parametreyi arıyacak ilk bulduğu yerde C nin indexini dönecek
            Console.WriteLine(degisken.IndexOf("CS")); //Bulamaz ise -1 döner

            //Insert: metinin 0.indexine (başına) ekler
            Console.WriteLine(degisken.Insert(0,"Merhaba"));

            //LastIndexOf: değişkende aratır ve sonda bulduğu i nin indexini verir
            Console.WriteLine(degisken.LastIndexOf("i"));

            //PadLeft //PadRight metin 7 uzunluğunda olsun
            //PadLeft/Right 'a 10 verirsek 3 birim boşluk bırakır 10 a tammalar yada eklenmesi istediğimiz parametreleri belirtebiliriz
            Console.WriteLine(degisken+degisken2.PadLeft(30));
            Console.WriteLine(degisken+degisken2.PadLeft(30,'*'));
            Console.WriteLine(degisken.PadRight(50)+degisken2);

            //Remove: verilen indisten sonrasını siler
            Console.WriteLine(degisken.Remove(10));
            // 5. indexten başlayarak 3 karakter siler.
            Console.WriteLine(degisken.Remove(5,3));

            //Replace= 1. parametre ile 2.yi değiştirir
            Console.WriteLine(degisken.Replace("CSharp","C#"));

            //Split: Metini dizi haline getirir.
            Console.WriteLine(degisken.Split(' '));

            //Substrin parametre indexinden başlayarak cümlenin sonuna kadar geitirir.
            Console.WriteLine(degisken.Substring(3));
            //4. indexten başlayarak 6 karakter getir.
            Console.WriteLine(degisken.Substring(4,6));
        }
    }
}
