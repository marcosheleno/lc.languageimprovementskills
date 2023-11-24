namespace GeneralTesting.MultipleClassesSameInterfaceInjection;

public class Class1: IClass<Class1>
{
    public void Do()
    {
        Console.WriteLine("doo be doo be doo 1");
    }
}