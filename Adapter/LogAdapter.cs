namespace Adapter
{
    public class LogAdapter : IMyLog
    {
        private readonly ThirdPartyLoggingSystem thirdPartyLoggingSystem;

        public LogAdapter(ThirdPartyLoggingSystem thirdPartyLoggingSystem)
        {
            this.thirdPartyLoggingSystem = thirdPartyLoggingSystem;
        }

        public void Log(object value)
        {
            this.thirdPartyLoggingSystem.LogText(value);
        }
    }
}
