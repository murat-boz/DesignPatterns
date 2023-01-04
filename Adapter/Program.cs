using System;

namespace Adapter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ThirdPartyLoggingSystem thirdPartyLoggingSystem = new ThirdPartyLoggingSystem();

            LogAdapter logAdapter = new LogAdapter(thirdPartyLoggingSystem);

            logAdapter.Log(new object());

            Console.ReadLine();
        }
    }
}
