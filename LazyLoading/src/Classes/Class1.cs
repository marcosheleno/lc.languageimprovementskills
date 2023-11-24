using LazyLoading.Contracts;

namespace LazyLoading.Classes;

public class Class1 : IClass1
{
    private readonly Class2 _class2;

    public Class1(Class2 class2)
    {
        _class2 = class2;
        Console.WriteLine("Iniciei Class 1");
    }

    public void Do()
    {
        Thread.Sleep(1);
    }
}