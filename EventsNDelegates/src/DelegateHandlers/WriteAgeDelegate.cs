using EventsNDelegates.Contracts;

namespace EventsNDelegates.DelegateHandlers;

public class WriteAgeDelegate : IWriterDelegate
{
    public static void WriteDelegate(MyEvent myEvent)
    {
        Console.WriteLine($"Escrevendo a idade: {myEvent.Age}");
    }
}