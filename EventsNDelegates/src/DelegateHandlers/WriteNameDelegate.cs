using EventsNDelegates.Contracts;

namespace EventsNDelegates.DelegateHandlers;

public class WriteNameDelegate : IWriterDelegate
{
    public static void WriteDelegate(MyEvent myEvent)
    {
        Console.WriteLine($"Escrevendo o nome: {myEvent.Name}");
    }
}