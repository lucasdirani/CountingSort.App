``` ini

BenchmarkDotNet=v0.13.5, OS=Windows 10 (10.0.19045.3930/22H2/2022Update)
Intel Core i7-10510U CPU 1.80GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=7.0.404
  [Host]     : .NET 7.0.14 (7.0.1423.51910), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.14 (7.0.1423.51910), X64 RyuJIT AVX2


```
|                    Method |         Array |            Mean |         Error |        StdDev |          Median | Rank |      Gen0 |     Gen1 |     Gen2 |  Allocated |
|-------------------------- |-------------- |----------------:|--------------:|--------------:|----------------:|-----:|----------:|---------:|---------:|-----------:|
| **MedirPerformanceCountSort** | **Int32[100000]** |   **841,646.91 ns** | **30,117.137 ns** | **87,853.101 ns** |   **859,533.50 ns** |    **9** |  **249.0234** | **249.0234** | **249.0234** |   **800140 B** |
| MedirPerformanceMergeSort | Int32[100000] | 5,830,174.39 ns | 94,010.820 ns | 83,338.143 ns | 5,837,587.50 ns |   10 | 2679.6875 | 242.1875 | 242.1875 | 12031270 B |
| **MedirPerformanceCountSort** |  **Int32[10000]** |    **59,967.30 ns** |  **2,084.672 ns** |  **6,081.086 ns** |    **61,987.08 ns** |    **7** |   **19.0430** |        **-** |        **-** |    **80056 B** |
| MedirPerformanceMergeSort |  Int32[10000] |   478,494.04 ns |  9,461.539 ns | 14,448.769 ns |   474,393.95 ns |    8 |  255.8594 |        - |        - |  1072017 B |
| **MedirPerformanceCountSort** |   **Int32[1000]** |     **5,552.46 ns** |    **109.114 ns** |    **163.317 ns** |     **5,520.62 ns** |    **5** |    **1.9226** |        **-** |        **-** |     **8056 B** |
| MedirPerformanceMergeSort |   Int32[1000] |    37,605.10 ns |    183.336 ns |    153.094 ns |    37,661.83 ns |    6 |   22.0337 |        - |        - |    92304 B |
| **MedirPerformanceCountSort** |    **Int32[100]** |       **582.54 ns** |      **3.502 ns** |      **2.924 ns** |       **582.81 ns** |    **3** |    **0.2041** |        **-** |        **-** |      **856 B** |
| MedirPerformanceMergeSort |    Int32[100] |     3,688.87 ns |     73.706 ns |     84.880 ns |     3,666.86 ns |    4 |    1.9112 |        - |        - |     8000 B |
| **MedirPerformanceCountSort** |     **Int32[10]** |        **69.94 ns** |      **1.233 ns** |      **1.153 ns** |        **70.11 ns** |    **1** |    **0.0324** |        **-** |        **-** |      **136 B** |
| MedirPerformanceMergeSort |     Int32[10] |       207.22 ns |      2.078 ns |      1.842 ns |       207.07 ns |    2 |    0.1490 |        - |        - |      624 B |
