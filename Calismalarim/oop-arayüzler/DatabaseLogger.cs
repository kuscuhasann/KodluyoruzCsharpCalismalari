using System;

namespace oop_arayüzler
{
    public class DatabaseLogger : ILogger
    {
        public void writeLog()
        {
            //throw new NotImplementedException();
            Console.WriteLine("Database e log yazar");
        }
    }
}