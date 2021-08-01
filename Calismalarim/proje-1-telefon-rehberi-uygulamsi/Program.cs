using System;
using System.Collections;
using System.Collections.Generic;

namespace proje_1_telefon_rehberi_uygulamsi
{
    class Program
    {
        static void Main(string[] args)
        {   
            //Tanimlamalar
            int gelenIstek=0;
            List <RehberKisileri> rehber=new List<RehberKisileri>();
            RehberKisileri kisi1=new RehberKisileri("Hasan","Kuşçu",1);
            RehberKisileri kisi2=new RehberKisileri("Kabe","Kuş",89);
            RehberKisileri kisi3=new RehberKisileri("Onur","Toy",65);
            RehberKisileri kisi4=new RehberKisileri("Selami","Işık",678);
            RehberKisileri kisi5=new RehberKisileri("Ayşe","Yükselen",3223);
            rehber.Add(kisi1);
            rehber.Add(kisi2);
            rehber.Add(kisi3);
            rehber.Add(kisi4);
            rehber.Add(kisi5);

            //Menu
            menuGetir();
            //istek kontrol alani
            menuSecimKontrol(rehber,gelenIstek);
        }
        static void menuGetir()

        {
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :");
            Console.WriteLine("*******************************************");
            Console.WriteLine("(1) Yeni Numara Kaydetmek");
            Console.WriteLine("(2) Varolan Numarayı Silmek");
            Console.WriteLine("(3) Varolan Numarayı Güncelleme");
            Console.WriteLine("(4) Rehberi Listelemek");
            Console.WriteLine("(5) Rehberde Arama Yapmak");
        }
        static void menuSecimKontrol(List <RehberKisileri> rehber,int gelenIstek){
            
            bool sayiMi=int.TryParse(Console.ReadLine(),out gelenIstek);
            if(sayiMi)
            {
                if(gelenIstek==1)
                {
                  rehbereEkle(rehber);
                }
                else if(gelenIstek==2)
                {
                  rehberdenKisiSil(rehber,gelenIstek); 
                }
                else if(gelenIstek==3)
                {
                   rehberdekiKisiyiGuncelle(rehber);

                }
                else if(gelenIstek==4)
                {
                  rehberGetir(rehber);
                }
                else if(gelenIstek==5)
                {
                 aramaYap(rehber,gelenIstek);
                }
            }
            else
            {
                Console.WriteLine("Girmiş olduğunuz istek değeri alınamadı lütfen tekrar giriniz...");
            }
        }
        static void rehberdekiKisiyiGuncelle(List<RehberKisileri> rehber)
        {
            int yeniTelefonNumarasi=0;
             Console.WriteLine("Lütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz:");
                    string searchItem=Console.ReadLine();
                        for (int nameIndex = 0; nameIndex < rehber.Count; nameIndex++)
                        {
                            if(rehber[nameIndex].RehberIsim==searchItem || rehber[nameIndex].RehberSoyIsim==searchItem)
                            {   
                                
                                Console.WriteLine(rehber[nameIndex].RehberIsim+"  kişisine ait numara: "+rehber[nameIndex].TelefonNumarasi);
                                Console.WriteLine("Güncel numarayı yazınız :");
                                
                                bool kontrol=int.TryParse(Console.ReadLine(),out yeniTelefonNumarasi);
                                if(kontrol)
                                {
                                    rehber[nameIndex].TelefonNumarasi=yeniTelefonNumarasi;
                                    Console.WriteLine("Kişi başarıyla güncellenmiştir.");
                                    Console.WriteLine(rehber[nameIndex].RehberIsim+"  kişisine ait numara: "+rehber[nameIndex].TelefonNumarasi);
                                }
                                else
                                Console.WriteLine("Hatalı bir değer girdiğiniz için işleminiz sonlandırılıyor");
                            }
                        } 
        }
        static void rehberdenKisiSil(List<RehberKisileri> rehber,int gelenIstek){
             Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");
                string searchItem=Console.ReadLine();
                        for (int nameIndex = 0; nameIndex < rehber.Count; nameIndex++)
                        {
                            if(rehber[nameIndex].RehberIsim==searchItem || rehber[nameIndex].RehberSoyIsim==searchItem)
                            {
                               Console.WriteLine(rehber[nameIndex].RehberIsim+" isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)");
                               string dogrulama=Console.ReadLine();
                               if(dogrulama=="y")
                               {
                                Console.WriteLine(rehber[nameIndex].RehberIsim+" kişisi silinmiştir.");
                                rehber.RemoveAt(nameIndex);
                                break;
                               }
                               else{
                                   Console.WriteLine("Silme işlemi sonlandırılmıştır");
                               }
                               
                            }
                            else
                            {
                                Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                                Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
                                Console.WriteLine("* Yeniden denemek için      : (2)");
                                bool kontrol=int.TryParse(Console.ReadLine(),out gelenIstek);
                                if(kontrol)
                                {
                                    if(gelenIstek==1)
                                    {
                                        Console.WriteLine("Silme işleminiz sonlandırılmıştır.");
                                    }
                                    else if(gelenIstek==2)
                                    {
                                        menuGetir();
                                        menuSecimKontrol(rehber,gelenIstek);
                                    }
                                    else
                                    Console.WriteLine("Hatalı bir değer girdiğiniz için işlemler sonlandırılıyor");
                                }
                            }
                        }
        }
        static void rehbereEkle(List<RehberKisileri> rehber){
            RehberKisileri rehberKisisi=new RehberKisileri();
            Console.WriteLine("Lütfen isim giriniz             :");
            rehberKisisi.RehberIsim=Console.ReadLine();
            Console.WriteLine("Lütfen soyisim giriniz          :");
            rehberKisisi.RehberSoyIsim=Console.ReadLine();
            Console.WriteLine("Lütfen telefon numarası giriniz :");
            rehberKisisi.TelefonNumarasi=int.Parse(Console.ReadLine());
            rehber.Add(rehberKisisi);
            Console.WriteLine(rehberKisisi.RehberIsim+" kişisi başarıyla rehbere eklenmiştir.");
        }
        static void rehberGetir(List<RehberKisileri> rehber)
        {
              Console.WriteLine("TELEFON REHBERİ");
              Console.WriteLine("**********************************************");
                    foreach (var item in rehber)
                {
                    Console.WriteLine("İsim: "+item.RehberIsim);
                    Console.WriteLine("Soyisim: "+item.RehberSoyIsim);
                    Console.WriteLine("Telefon Numarası: "+item.TelefonNumarasi);
                    Console.WriteLine("-");
                }
        }
        static void aramaYap(List<RehberKisileri> rehber,int gelenIstek){
            Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.");
            Console.WriteLine("**********************************************");
            Console.WriteLine("İsim veya soyisime göre arama yapmak için: (1)");
            Console.WriteLine("Telefon numarasına göre arama yapmak için: (2)");
            bool kontrol=int.TryParse(Console.ReadLine(),out gelenIstek);
                if(kontrol){
                    if(gelenIstek==1)
                    {
                        Console.WriteLine("Lütfen arama yapmak istediğiniz ismi veya soyismi giriniz");
                        string searchItem=Console.ReadLine();
                        for (int nameIndex = 0; nameIndex < rehber.Count; nameIndex++)
                        {
                            if(rehber[nameIndex].RehberIsim==searchItem || rehber[nameIndex].RehberSoyIsim==searchItem)
                            {
                                Console.WriteLine("Arama Sonuçlarınız");
                                Console.WriteLine("**********************************************");
                                Console.WriteLine(rehber[nameIndex].RehberIsim);
                                Console.WriteLine(rehber[nameIndex].RehberSoyIsim);
                                Console.WriteLine(rehber[nameIndex].TelefonNumarasi);
                            }
                        } 
                    }
                    else{
                        Console.WriteLine("Lütfen arama yapmak istediğiniz telefon numarasını giriniz");
                        int searchItem=int.Parse(Console.ReadLine());
                        for (int telNoIndex = 0; telNoIndex < rehber.Count; telNoIndex++)
                        {
                            Console.WriteLine("Arama Sonuçlarınız");
                            Console.WriteLine("**********************************************");
                            Console.WriteLine(rehber[telNoIndex].RehberIsim);
                            Console.WriteLine(rehber[telNoIndex].RehberSoyIsim);
                            Console.WriteLine(rehber[telNoIndex].TelefonNumarasi);
                        }
                        }
                    }
        else{
            Console.WriteLine("Hatalı bir seçim yaptınız");
            }
        }
    }
}
