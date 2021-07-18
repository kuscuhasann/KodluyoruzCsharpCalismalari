using System;

namespace date_time_ve_match_dersi_ornekleri
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now); //Günün tarihini getirir
            Console.WriteLine(DateTime.Now.Date);
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);
            //Haftanın gününü ingilizce karşılığı ile getirir.
            Console.WriteLine(DateTime.Now.DayOfWeek);
            Console.WriteLine(DateTime.Now.DayOfYear); //Yılın günü

            Console.WriteLine(DateTime.Now.ToLongDateString());
            Console.WriteLine(DateTime.Now.ToShortDateString());
            Console.WriteLine(DateTime.Now.ToLongDateString());
            Console.WriteLine(DateTime.Now.ToShortTimeString());

            Console.WriteLine(DateTime.Now.AddDays(2));
            Console.WriteLine(DateTime.Now.AddHours(3));
            Console.WriteLine(DateTime.Now.AddSeconds(30));
            Console.WriteLine(DateTime.Now.AddMonths(5));
            Console.WriteLine(DateTime.Now.AddYears(10));
            Console.WriteLine(DateTime.Now.AddMilliseconds(50));

            //Datetime Format
            Console.WriteLine(DateTime.Now.ToString("dd")); //24
            Console.WriteLine(DateTime.Now.ToString("ddd")); //Sat
            Console.WriteLine(DateTime.Now.ToString("dddd")); //Saturday

            Console.WriteLine(DateTime.Now.ToString("MM")); //04
            Console.WriteLine(DateTime.Now.ToString("MMM")); //Apr
            Console.WriteLine(DateTime.Now.ToString("MMMM")); //April
            
            Console.WriteLine(DateTime.Now.ToString("yy")); //21
            Console.WriteLine(DateTime.Now.ToString("yyyy")); // 2021

            //Math Kütüphanesi
            Console.WriteLine(Math.Abs(-25)); // 25;

            Console.WriteLine(Math.Ceiling(22.3)); //23
            Console.WriteLine(Math.Round(22.3)); //22
            Console.WriteLine(Math.Floor(22.7)); //22

            Console.WriteLine(Math.Min(2,6));
            Console.WriteLine(Math.Max(2,6));

            Console.WriteLine(Math.Pow(3,4)); //3^4=81
            Console.WriteLine(Math.Sqrt(81));// 9 karekök

        }
    }
}
