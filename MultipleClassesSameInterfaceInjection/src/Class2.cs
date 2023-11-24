namespace GeneralTesting.MultipleClassesSameInterfaceInjection;

public class Class2: IClass<Class2>
{
    public void Do()
    {
        Console.WriteLine("doo be doo be doo 2");
    }
}