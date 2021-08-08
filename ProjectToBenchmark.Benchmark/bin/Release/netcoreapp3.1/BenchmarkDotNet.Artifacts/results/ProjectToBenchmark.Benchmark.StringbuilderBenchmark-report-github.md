``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1500 (1909/November2018Update/19H2)
Intel Core i5-9300H CPU 2.40GHz, 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=6.0.100-preview.2.21155.3
  [Host]        : .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT
  .NET Core 3.1 : .NET Core 3.1.14 (CoreCLR 4.700.21.16201, CoreFX 4.700.21.16208), X64 RyuJIT

Job=.NET Core 3.1  Runtime=.NET Core 3.1  

```
|                   Method |     N |            Mean |         Error |          StdDev |          Median | Ratio | RatioSD |       Gen 0 |      Gen 1 |      Gen 2 |   Allocated |
|------------------------- |------ |----------------:|--------------:|----------------:|----------------:|------:|--------:|------------:|-----------:|-----------:|------------:|
| **StringBuilderToBenchmark** |    **10** |        **317.0 ns** |       **0.83 ns** |         **0.78 ns** |        **316.8 ns** |  **0.64** |    **0.02** |      **0.0572** |          **-** |          **-** |       **240 B** |
|  StringConcatToBenchmark |    10 |        493.8 ns |       9.40 ns |        17.88 ns |        487.4 ns |  1.00 |    0.00 |      0.1373 |          - |          - |       576 B |
|                          |       |                 |               |                 |                 |       |         |             |            |            |             |
| **StringBuilderToBenchmark** |   **100** |      **2,853.2 ns** |      **11.81 ns** |        **10.47 ns** |      **2,854.1 ns** |  **0.42** |    **0.00** |      **0.3433** |          **-** |          **-** |      **1440 B** |
|  StringConcatToBenchmark |   100 |      6,795.1 ns |      65.76 ns |        58.30 ns |      6,802.3 ns |  1.00 |    0.00 |      8.1863 |          - |          - |     34240 B |
|                          |       |                 |               |                 |                 |       |         |             |            |            |             |
| **StringBuilderToBenchmark** |  **1000** |     **29,478.9 ns** |     **389.65 ns** |       **345.42 ns** |     **29,345.7 ns** |  **0.09** |    **0.01** |      **4.3335** |          **-** |          **-** |     **18144 B** |
|  StringConcatToBenchmark |  1000 |    316,528.7 ns |   9,864.48 ns |    28,930.82 ns |    308,134.9 ns |  1.00 |    0.00 |    921.3867 |          - |          - |   3857440 B |
|                          |       |                 |               |                 |                 |       |         |             |            |            |             |
| **StringBuilderToBenchmark** | **10000** |    **331,421.9 ns** |   **4,504.40 ns** |     **3,761.38 ns** |    **331,611.7 ns** | **0.009** |    **0.00** |     **47.3633** |     **5.8594** |          **-** |    **202353 B** |
|  StringConcatToBenchmark | 10000 | 35,427,583.7 ns | 696,614.48 ns | 1,201,625.75 ns | 35,018,443.3 ns | 1.000 |    0.00 | 122666.6667 | 37666.6667 | 36666.6667 | 479471440 B |
