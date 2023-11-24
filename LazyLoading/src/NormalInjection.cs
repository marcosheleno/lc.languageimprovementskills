using BenchmarkDotNet.Attributes;
using LazyLoading.Classes;
using Microsoft.Extensions.Hosting;

namespace LazyLoading;

public class NormalInjection
{
    private readonly Class1 _class1;

    public NormalInjection(Class1 class1)
    {
        _class1 = class1;
    }

    public void Do()
    {
        Console.WriteLine("Normal injection");
        Thread.Sleep(5);
    }
}