using System.IO;

namespace Demo3.Services
{
    internal class FileOutput : IOutput
    {
        public event OutputDelegate WriteFinished;

        public void Write(string message)
        {
            System.Console.WriteLine(message);
            File.AppendAllText("output.txt", message + System.Environment.NewLine);


            WriteFinished?.Invoke();
        }
    }
}