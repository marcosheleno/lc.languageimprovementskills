```

BenchmarkDotNet v0.13.9+228a464e8be6c580ad9408e98f18813f6407fb5a, macOS Sonoma 14.0 (23A344) [Darwin 23.0.0]
Apple M2 Pro, 1 CPU, 10 logical and 10 physical cores
.NET SDK 7.0.100
  [Host]     : .NET 7.0.0 (7.0.22.61201), Arm64 RyuJIT AdvSIMD
  DefaultJob : .NET 7.0.0 (7.0.22.61201), Arm64 RyuJIT AdvSIMD


```
| Method   | Mean     | Error     | StdDev    |
|--------- |---------:|----------:|----------:|
| Parallel | 7.553 μs | 0.1508 μs | 0.2941 μs |
