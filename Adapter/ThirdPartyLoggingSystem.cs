using System;

namespace Adapter
{
    public class ThirdPartyLoggingSystem : IThirdPartyLog
    {
        public void LogText(object value)
        {
            Console.WriteLine($"Third party logging system has logged to {value}");
        }
    }
}
