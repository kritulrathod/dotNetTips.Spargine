
BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19044.1826 (21H2)
Intel Core i7-7660U CPU 2.50GHz (Kaby Lake), 1 CPU, 4 logical and 2 physical cores
.NET SDK=7.0.100-preview.6.22352.1
  [Host]     : .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
  Job-YKIQEX : .NET 6.0.7 (6.0.722.32202), X64 RyuJIT

EvaluateOverhead=True  Runtime=.NET 6.0  Server=True  
Namespace=DotNetTips.Spargine.Core.BenchmarkTests  Categories=Collections,Strings  

        Method | Count |        Mean |      Error |     StdDev |    StdErr |      Median |         Min |          Q1 |          Q3 |         Max |     Op/s | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline |    Gen 0 | Code Size |    Gen 1 |   Gen 2 | Allocated |
-------------- |------ |------------:|-----------:|-----------:|----------:|------------:|------------:|------------:|------------:|------------:|---------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |---------:|----------:|---------:|--------:|----------:|
 BytesToString |     2 |    61.28 μs |   1.175 μs |   1.443 μs |  0.308 μs |    60.69 μs |    59.47 μs |    60.02 μs |    62.53 μs |    63.96 μs | 16,319.8 |       1.175 μs |      22.00 |    1.693 |  2.000 |   0.4571 |    1 |            * |       No |   9.9487 |      1 KB |   0.3052 |       - |     89 KB |
 BytesToString |     5 |   151.71 μs |   3.005 μs |   6.206 μs |  0.861 μs |   149.87 μs |   143.82 μs |   147.22 μs |   154.83 μs |   168.53 μs |  6,591.5 |       3.005 μs |      52.00 |    3.189 |  2.105 |   1.0071 |    2 |            * |       No |  23.9258 |      1 KB |   1.7090 |       - |    212 KB |
 BytesToString |    10 |   309.38 μs |   6.169 μs |  15.015 μs |  1.795 μs |   306.87 μs |   283.08 μs |   297.78 μs |   319.41 μs |   348.87 μs |  3,232.2 |       6.169 μs |      70.00 |    2.766 |  2.000 |   0.7234 |    3 |            * |       No |  48.8281 |      1 KB |   5.8594 |       - |    408 KB |
 BytesToString |    20 |   619.12 μs |  12.348 μs |  36.019 μs |  3.638 μs |   605.13 μs |   569.51 μs |   592.31 μs |   638.89 μs |   712.71 μs |  1,615.2 |      12.348 μs |      98.00 |    2.761 |  2.136 |   0.9559 |    4 |            * |       No |  92.7734 |      1 KB |  17.5781 |       - |    815 KB |
 BytesToString |    25 |   858.50 μs |  17.079 μs |  47.891 μs |  5.020 μs |   850.23 μs |   767.63 μs |   819.25 μs |   894.40 μs |   994.80 μs |  1,164.8 |      17.079 μs |      91.00 |    2.460 |  2.080 |   0.4682 |    5 |            * |       No | 108.3984 |      1 KB |  22.4609 |  9.7656 |  1,011 KB |
 BytesToString |    50 | 1,654.36 μs |  33.837 μs |  97.629 μs |  9.964 μs | 1,627.66 μs | 1,477.85 μs | 1,581.99 μs | 1,706.38 μs | 1,902.07 μs |    604.5 |      33.837 μs |      96.00 |    2.738 |  2.148 |   0.7593 |    6 |            * |       No | 214.8438 |      1 KB |  46.8750 | 19.5313 |  2,005 KB |
 BytesToString |    75 | 2,450.75 μs |  48.590 μs | 129.697 μs | 14.236 μs | 2,432.83 μs | 2,210.69 μs | 2,356.85 μs | 2,533.09 μs | 2,758.45 μs |    408.0 |      48.590 μs |      83.00 |    2.503 |  2.000 |   0.4106 |    7 |            * |       No | 312.5000 |      1 KB |  93.7500 | 27.3438 |  3,015 KB |
 BytesToString |   100 | 3,294.45 μs |  64.818 μs | 161.419 μs | 18.893 μs | 3,272.21 μs | 3,034.37 μs | 3,184.26 μs | 3,379.38 μs | 3,740.52 μs |    303.5 |      64.818 μs |      73.00 |    2.945 |  2.000 |   0.7271 |    8 |            * |       No | 429.6875 |      1 KB | 136.7188 | 39.0625 |  4,009 KB |
 BytesToString |   250 | 8,036.91 μs | 160.447 μs | 348.799 μs | 46.200 μs | 7,922.96 μs | 7,565.42 μs | 7,794.80 μs | 8,272.38 μs | 8,934.50 μs |    124.4 |     160.447 μs |      57.00 |    2.567 |  2.649 |   0.8131 |    9 |            * |       No | 406.2500 |      1 KB | 187.5000 | 78.1250 | 10,006 KB |
