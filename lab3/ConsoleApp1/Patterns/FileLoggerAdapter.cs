namespace Lab3.Patterns
{
    public class FileLoggerAdapter : Logger
    {
        private readonly FileWriter fileWriter;

        public FileLoggerAdapter(FileWriter fileWriter)
        {
            this.fileWriter = fileWriter;
        }

        public new void Log(string message)
        {
            fileWriter.WriteLine("LOG: " + message);
        }

        public new void Error(string message)
        {
            fileWriter.WriteLine("ERROR: " + message);
        }

        public new void Warn(string message)
        {
            fileWriter.WriteLine("WARNING: " + message);
        }
    }
}
