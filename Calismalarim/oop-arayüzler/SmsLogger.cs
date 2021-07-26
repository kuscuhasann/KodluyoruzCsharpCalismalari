using System;

namespace oop_arayüzler
{
    public class SmsLogger : ILogger
    {
        public void writeLog()
        {
            //throw new NotImplementedException();
            Console.WriteLine("Sms'e log yazar");
        }
    }
}