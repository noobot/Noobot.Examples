using System;

namespace Noobot.Examples.ConsoleService.Logging
{
    public interface ILogger : IDisposable
    {
        void Grapple();
    }
}