``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i5-9300H CPU 2.40GHz, 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=6.0.100-preview.2.21155.3
  [Host]        : .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
  .NET Core 3.1 : .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT

Job=.NET Core 3.1  Runtime=.NET Core 3.1  

```
|            Method | Length |         Mean |      Error |     StdDev | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------------ |------- |-------------:|-----------:|-----------:|------:|--------:|------:|------:|------:|----------:|
|  **ClassTobenchmark** |    **100** |     **33.47 ns** |   **0.249 ns** |   **0.195 ns** |  **1.00** |    **0.00** |     **-** |     **-** |     **-** |         **-** |
|  ClassTobenchmark |    100 |     32.96 ns |   0.257 ns |   0.228 ns |  0.98 |    0.01 |     - |     - |     - |         - |
| StructTobenchmark |    100 |     32.99 ns |   0.177 ns |   0.148 ns |  0.99 |    0.01 |     - |     - |     - |         - |
| StructTobenchmark |    100 |     33.07 ns |   0.315 ns |   0.280 ns |  0.99 |    0.01 |     - |     - |     - |         - |
|                   |        |              |            |            |       |         |       |       |       |           |
|  **ClassTobenchmark** |  **10000** |  **2,586.62 ns** |  **32.470 ns** |  **30.372 ns** |  **1.00** |    **0.00** |     **-** |     **-** |     **-** |         **-** |
| StructTobenchmark |  10000 |  2,579.84 ns |  20.645 ns |  18.301 ns |  1.00 |    0.02 |     - |     - |     - |         - |
|                   |        |              |            |            |       |         |       |       |       |           |
|  **ClassTobenchmark** | **100000** | **25,816.32 ns** | **292.530 ns** | **273.633 ns** |  **1.00** |    **0.00** |     **-** |     **-** |     **-** |         **-** |
| StructTobenchmark | 100000 | 25,569.77 ns | 187.207 ns | 165.954 ns |  0.99 |    0.01 |     - |     - |     - |         - |
