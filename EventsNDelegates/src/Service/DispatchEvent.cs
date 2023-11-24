using System.Reflection;
using EventsNDelegates.Contracts;
using EventsNDelegates.DelegateHandlers;
using EventsNDelegates.Delegates;

namespace EventsNDelegates.Service;

public class DispatchEvent
{
    private MyEvent _myEvent;
    private event WriteDelegate _delegate;
    private IEnumerable<IWriterDelegate> _events;

    public DispatchEvent(IEnumerable<IWriterDelegate> events)
    {
        _events = events;
    }
    
    public void Init()
    {
        Console.WriteLine("Inicializando delegates");
        AttachEvents();
        
        _myEvent = new MyEvent()
        {
            Name = "Marcos Heleno",
            Age = 31,
            Address = "Rua dos bobos #0"
        };
    }

    public void Dispatch()
    {
        Console.WriteLine("Disparando delegates");
        _delegate(_myEvent);
    }

    private void AttachEvents()
    {
        foreach (var ev in _events)
        {
            var method = ev.GetType().GetMethod("WriteDelegate");
            _delegate += (WriteDelegate) Delegate.CreateDelegate( typeof(WriteDelegate), method );
        }
    }
}