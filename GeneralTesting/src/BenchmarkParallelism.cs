using BenchmarkDotNet.Attributes;

namespace GeneralTesting;

public class BenchmarkParallelism
{
    [Benchmark]
    public void Parallel()
    {
        var parallel = new Parallelism();
            parallel.IsPrimeWithTaskRunning();
    }

}