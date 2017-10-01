using Common.Logging;

namespace Noobot.Examples.Asp.Logging
{
    public interface IMemoryLog : ILog
    {
        string[] FullLog();
    }
}