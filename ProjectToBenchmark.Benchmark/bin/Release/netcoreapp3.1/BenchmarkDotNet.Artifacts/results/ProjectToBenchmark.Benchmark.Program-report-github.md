``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1500 (1909/November2018Update/19H2)
Intel Core i5-9300H CPU 2.40GHz, 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=6.0.100-preview.2.21155.3
  [Host]        : .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
  .NET Core 3.1 : .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT

Job=.NET Core 3.1  Runtime=.NET Core 3.1  

```
|                   Method |     N |            Mean |         Error |        StdDev |          Median | Ratio |       Gen 0 |      Gen 1 |      Gen 2 |   Allocated |
|------------------------- |------ |----------------:|--------------:|--------------:|----------------:|------:|------------:|-----------:|-----------:|------------:|
|  **StringConcatToBenchmark** |    **10** |        **484.2 ns** |       **2.71 ns** |       **2.53 ns** |        **483.9 ns** |  **1.00** |      **0.1373** |          **-** |          **-** |       **576 B** |
| StringBuilderToBenchmark |    10 |        313.9 ns |       2.25 ns |       1.99 ns |        313.3 ns |  0.65 |      0.0572 |          - |          - |       240 B |
|                          |       |                 |               |               |                 |       |             |            |            |             |
|  **StringConcatToBenchmark** |   **100** |      **6,996.3 ns** |      **90.78 ns** |      **80.47 ns** |      **6,982.4 ns** |  **1.00** |      **8.1863** |          **-** |          **-** |     **34240 B** |
| StringBuilderToBenchmark |   100 |      2,918.8 ns |      28.79 ns |      25.52 ns |      2,922.5 ns |  0.42 |      0.3433 |          - |          - |      1440 B |
|                          |       |                 |               |               |                 |       |             |            |            |             |
|  **StringConcatToBenchmark** |  **1000** |    **322,357.1 ns** |   **8,984.88 ns** |  **26,351.10 ns** |    **310,354.3 ns** |  **1.00** |    **921.3867** |          **-** |          **-** |   **3857440 B** |
| StringBuilderToBenchmark |  1000 |     29,932.5 ns |     383.55 ns |     358.77 ns |     29,737.7 ns |  0.08 |      4.3335 |          - |          - |     18144 B |
|                          |       |                 |               |               |                 |       |             |            |            |             |
|  **StringConcatToBenchmark** | **10000** | **36,230,850.0 ns** | **670,646.16 ns** | **627,322.84 ns** | **36,110,714.3 ns** | **1.000** | **122642.8571** | **37642.8571** | **36642.8571** | **479471440 B** |
| StringBuilderToBenchmark | 10000 |    353,715.4 ns |   5,249.81 ns |   4,653.82 ns |    353,578.5 ns | 0.010 |     47.3633 |     5.8594 |          - |    202354 B |
