namespace Demo3.Services
{
    internal class DebugOutput : IOutput
    {
        public event OutputDelegate WriteFinished;

        public void Write(string message)
        {
            System.Console.WriteLine(message);

            WriteFinished?.Invoke();
        }
    }
}