using Bibliotheque.Entity;

namespace Bibliotheque.Events
{
    public class BookIsAvailableEvent
    {
        public delegate void IsAvailableChangeEventHandler(Livre book);
    }
}