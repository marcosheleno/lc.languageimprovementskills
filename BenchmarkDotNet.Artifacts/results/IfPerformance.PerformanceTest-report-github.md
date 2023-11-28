```

BenchmarkDotNet v0.13.9+228a464e8be6c580ad9408e98f18813f6407fb5a, macOS Sonoma 14.1.1 (23B81) [Darwin 23.1.0]
Apple M2 Pro, 1 CPU, 10 logical and 10 physical cores
.NET SDK 6.0.114
  [Host]     : .NET 6.0.14 (6.0.1423.11501), Arm64 RyuJIT AdvSIMD
  DefaultJob : .NET 6.0.14 (6.0.1423.11501), Arm64 RyuJIT AdvSIMD


```
| Method   | Mean      | Error     | StdDev    |
|--------- |----------:|----------:|----------:|
| TestIf   | 0.2218 ns | 0.0040 ns | 0.0036 ns |
| TestNull | 0.0443 ns | 0.0065 ns | 0.0060 ns |
