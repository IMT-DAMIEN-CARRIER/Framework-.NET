namespace Demo3.Services
{
    internal delegate void OutputDelegate();

    internal interface IOutput
    {
        event OutputDelegate WriteFinished;
        void Write(string message);
    }
}