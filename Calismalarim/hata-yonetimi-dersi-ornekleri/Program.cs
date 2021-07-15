using System;

namespace hata_yonetimi_dersi_ornekleri
{
    class Program
    {
        static void Main(string[] args)
        {
            //hataya sebebiyet  verebilecek kod satırı burada yer almalıdır
            try
            {
                Console.WriteLine("Bir sayi giriniz");
                int sayi=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girmiş olduğunuz sayi:"+sayi);
            }
            //hata sistem tarafından yakalanıp ekrana yazdırılabilir.
            catch (Exception ex)
            {
                Console.WriteLine("Hata:" +ex.Message.ToString());                
            }
            // //tryda hata alsın veya almasın her zaman  çalışmasını istediğimiz kod parçacığı buraya gelecektir.
            // finally
            // {
            //     Console.WriteLine("İşlem tamamlandı");
            // }

            //Eğer fırlatıcak hatanın nedenini tam olarak bilebiliyorsak catch içerisinde Arguman ex.FormatEx OverFlowEx kullanarak 
            //kullanıcımıza hata mesajımızı özelleştirerek gösterebiliriz.
           
        }
    }
}
