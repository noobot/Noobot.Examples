using Common.Logging;

namespace Noobot.Examples.Dotnet.Logging
{
    public interface IMemoryLog : ILog
    {
        string[] FullLog();
    }
}