
    BenchmarkDotNet=v0.13.4, OS=Windows 10 (10.0.19045.2546)
    Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
    .NET SDK=7.0.102
      [Host]     : .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
      Job-ANELUY : .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
      Job-JEZFWT : .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2

    EvaluateOverhead=True  Server=True  Namespace=DotNetTips.Spargine.Extensions.BenchmarkTests  
    Categories=Collections  

               Method |  Runtime | Count |     Mean |    Error |   StdDev |   StdErr |      Min |       Q1 |   Median |       Q3 |      Max |         Op/s | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Code Size | Allocated |
    ----------------- |--------- |------ |---------:|---------:|---------:|---------:|---------:|---------:|---------:|---------:|---------:|-------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |----------:|----------:|
     DoesNotHaveItems | .NET 6.0 |     2 | 17.56 ns | 0.196 ns | 0.183 ns | 0.047 ns | 17.34 ns | 17.40 ns | 17.53 ns | 17.68 ns | 17.86 ns | 56,951,292.7 |      0.1956 ns |      15.00 |    1.632 |  2.000 |   0.4055 |    1 |            * |       No |     186 B |      32 B |
     DoesNotHaveItems | .NET 7.0 |     2 | 17.57 ns | 0.256 ns | 0.240 ns | 0.062 ns | 17.23 ns | 17.34 ns | 17.60 ns | 17.73 ns | 17.99 ns | 56,924,840.7 |      0.2564 ns |      15.00 |    1.779 |  2.000 |   0.1162 |    1 |            * |       No |     177 B |      32 B |
     DoesNotHaveItems | .NET 6.0 |     5 | 23.80 ns | 0.098 ns | 0.077 ns | 0.022 ns | 23.65 ns | 23.75 ns | 23.81 ns | 23.85 ns | 23.91 ns | 42,012,256.1 |      0.0980 ns |      12.00 |    1.905 |  2.000 |  -0.3322 |    3 |            * |       No |     186 B |      32 B |
     DoesNotHaveItems | .NET 7.0 |     5 | 23.07 ns | 0.179 ns | 0.158 ns | 0.042 ns | 22.88 ns | 22.97 ns | 23.04 ns | 23.13 ns | 23.40 ns | 43,343,569.8 |      0.1788 ns |      14.00 |    2.240 |  2.000 |   0.6905 |    2 |            * |       No |     177 B |      32 B |
     DoesNotHaveItems | .NET 6.0 |    10 | 33.65 ns | 0.330 ns | 0.257 ns | 0.074 ns | 33.41 ns | 33.49 ns | 33.58 ns | 33.72 ns | 34.38 ns | 29,718,711.2 |      0.3297 ns |      12.00 |    5.576 |  2.000 |   1.7822 |    4 |            * |       No |     186 B |      32 B |
     DoesNotHaveItems | .NET 7.0 |    10 | 34.29 ns | 0.144 ns | 0.120 ns | 0.033 ns | 34.14 ns | 34.20 ns | 34.29 ns | 34.32 ns | 34.55 ns | 29,166,823.8 |      0.1439 ns |      13.00 |    2.397 |  2.000 |   0.6330 |    5 |            * |       No |     177 B |      32 B |
     DoesNotHaveItems | .NET 6.0 |    20 |       NA |       NA |       NA |       NA |       NA |       NA |       NA |       NA |       NA |           NA |             NA |         NA |       NA |     NA |       NA |    ? |            * |       No |         - |         - |

    Benchmarks with issues:
      ReadOnlyCollectionBenchmark.DoesNotHaveItems: Job-ANELUY(EvaluateOverhead=True, Runtime=.NET 6.0, Server=True) [Count=20]
