``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1500 (1909/November2018Update/19H2)
Intel Core i5-9300H CPU 2.40GHz, 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=6.0.100-preview.2.21155.3
  [Host]        : .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
  .NET Core 3.1 : .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT

Job=.NET Core 3.1  Runtime=.NET Core 3.1  

```
|                             Method |      Mean |    Error |   StdDev |    Gen 0 |    Gen 1 |    Gen 2 |  Allocated |
|----------------------------------- |----------:|---------:|---------:|---------:|---------:|---------:|-----------:|
|                   ClassTobenchmark | 135.06 μs | 0.970 μs | 0.860 μs | 249.7559 | 249.7559 | 249.7559 | 1015.68 KB |
|                  StructTobenchmark |  50.55 μs | 0.356 μs | 0.333 μs | 249.9390 | 249.9390 | 249.9390 |   781.3 KB |
|  GrowableArrayTobenchmarkWithClass | 118.95 μs | 1.088 μs | 1.018 μs | 249.8779 | 249.8779 | 249.8779 | 1015.65 KB |
| GrowableArrayTobenchmarkWithStruct |  50.89 μs | 0.663 μs | 0.620 μs | 249.9390 | 249.9390 | 249.9390 |  781.27 KB |
