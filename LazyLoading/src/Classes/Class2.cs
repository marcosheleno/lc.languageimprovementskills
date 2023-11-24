using LazyLoading.Contracts;

namespace LazyLoading.Classes;

public class Class2: IClass2
{
    public Class2()
    {
        Console.WriteLine("Iniciei Class 2");
    }

    public void Do()
    {
        Thread.Sleep(2);
    }
}