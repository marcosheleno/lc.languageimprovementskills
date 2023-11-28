using BenchmarkDotNet.Running;
using IfPerformance;

//dotnet run --project ./IfPerformance -c Release
BenchmarkRunner.Run<PerformanceTest>();

/**
    Nenhum preenchido
    | Method   | Mean      | Error     | StdDev    |
    |--------- |----------:|----------:|----------:|
    | TestIf   | 0.0405 ns | 0.0042 ns | 0.0035 ns |
    | TestNull | 0.0638 ns | 0.0189 ns | 0.0194 ns |

    Todos preenchidos
    | Method   | Mean      | Error     | StdDev    |
    |--------- |----------:|----------:|----------:|
    | TestIf   | 0.2218 ns | 0.0040 ns | 0.0036 ns |
    | TestNull | 0.0443 ns | 0.0065 ns | 0.0060 ns |
*/