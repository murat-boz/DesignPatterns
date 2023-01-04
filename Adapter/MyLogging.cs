using System;

namespace Adapter
{
    public class MyLogging : IMyLog
    {
        public void Log(object value)
        {
            Console.WriteLine($"My logging system has logged to {value}");
        }
    }
}
