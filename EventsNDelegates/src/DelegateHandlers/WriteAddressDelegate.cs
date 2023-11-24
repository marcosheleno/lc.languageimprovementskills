using EventsNDelegates.Contracts;

namespace EventsNDelegates.DelegateHandlers;

public class WriteAddressDelegate : IWriterDelegate
{
    public static void WriteDelegate(MyEvent myEvent)
    {
        Console.WriteLine($"Escrevendo o endereço: {myEvent.Address}");
    }
}