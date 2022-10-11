namespace Extensibility
{
    internal partial class Program
    {
        public class FileLogger : ILogger
        {
            private readonly string _path;

            public FileLogger(string path)
            {
                this._path = path;
            }
            public void LogError(string message)
            {
                using (var streamWriter = new StreamWriter(_path, true))
                {
                    Log(message, "ERROR");
                }
            }

            public void LogInfo(string message)
            {
                using (var streamWriter = new StreamWriter(_path, true))
                {
                    Log(message, "INFO");
                }
            }

            private void Log(string message, string messageType)
            {
                using (var streamWriter = new StreamWriter(_path, true))
                {
                    streamWriter.WriteLine(messageType + ": " + message);
                    streamWriter.Close();
                }
            }
        }
    }
}