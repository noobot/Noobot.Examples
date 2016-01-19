using System;
using System.IO;
using Noobot.Core.Configuration;

namespace Noobot.Examples.ConsoleService.Logging
{
    /// <summary>
    /// Used to copy everything written to console also to a file
    /// </summary>
    public class ConsoleLogger
    {
        private readonly IConfigReader _configReader;
        private TextWriterDistributor _distributor;

        public ConsoleLogger(IConfigReader configReader)
        {
            _configReader = configReader;
        }

        public void Grapple()
        {
            TextWriter fileWriter = TryGetLogWriter();
            _distributor = new TextWriterDistributor(fileWriter, Console.Out);
            Console.SetOut(_distributor);
        }

        private TextWriter TryGetLogWriter()
        {
            try
            {
                string logFileName = _configReader.GetConfigEntry<string>("logFile");
                string logFile = Path.Combine(Environment.CurrentDirectory, logFileName);

                if (File.Exists(logFile))
                {
                    File.Delete(logFile);
                }

                var logStream = new FileStream(logFile, FileMode.OpenOrCreate, FileAccess.Write);
                var fileWriter = new StreamWriter(logStream) { AutoFlush = true };
                return fileWriter;

            }
            catch (Exception)
            {
                Console.WriteLine("Unable to write to log file, THIS SESSION IS NOT LOGGING TO FILE");
                return null;
            }
        }
        
        public void Dispose()
        {
            _distributor?.Dispose();
        }
    }
}