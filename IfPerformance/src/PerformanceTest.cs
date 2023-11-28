using BenchmarkDotNet.Attributes;

namespace IfPerformance;

public class PerformanceTest
{
    [Benchmark]
    public void TestIf()
    {
        var service = new IfNull();
        service.Run();
    }

    [Benchmark]
    public void TestNull()
    {
        var service = new NullOperator();
        service.Run();
    }
}