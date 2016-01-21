using Noobot.Core.Logging;

namespace Noobot.Examples.Web.Logging
{
    public interface IMemoryLog : ILog
    {
        string[] FullLog();
    }
}