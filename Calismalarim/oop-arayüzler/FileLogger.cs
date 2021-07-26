using System;

namespace oop_arayüzler
{
    public class FileLogger : ILogger
    {
        public void writeLog()
        {
            //throw new NotImplementedException();
            Console.WriteLine("Dosyaya log yazar");
        }
    }
}