using System;

namespace oop_arayüzler
{
    class Program
    {
        static void Main(string[] args)
        {
           FileLogger fileLogger=new FileLogger();
           fileLogger.writeLog();

           DatabaseLogger databaseLogger=new DatabaseLogger();
           databaseLogger.writeLog();

           SmsLogger smsLogger=new SmsLogger();
           smsLogger.writeLog();

           LogManager log=new LogManager(new FileLogger());
           log.writeLog();
        }
    }
}
