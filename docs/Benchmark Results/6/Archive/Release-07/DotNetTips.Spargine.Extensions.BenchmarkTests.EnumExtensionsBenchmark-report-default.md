
BenchmarkDotNet v0.13.9+228a464e8be6c580ad9408e98f18813f6407fb5a, Windows 10 (10.0.19045.3570/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.100-rc.2.23502.2
  [Host]     : .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
  Job-XHVJJL : .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
  Job-SWNUOI : .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2

EvaluateOverhead=True  Server=True  Namespace=DotNetTips.Spargine.Extensions.BenchmarkTests  
Categories=Collections  

 Method         | Runtime  | Mean     | Error    | StdDev   | StdErr  | Min      | Q1       | Median   | Q3       | Max      | Op/s        | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Code Size | Allocated |
--------------- |--------- |---------:|---------:|---------:|--------:|---------:|---------:|---------:|---------:|---------:|------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |----------:|----------:|
 **GetDescription** | **.NET 6.0** | **248.1 ns** |  **0.74 ns** |  **0.61 ns** | **0.17 ns** | **247.4 ns** | **247.7 ns** | **247.8 ns** | **248.2 ns** | **249.5 ns** | **4,031,208.3** |      **0.7364 ns** |      **13.00** |    **2.906** |  **2.000** |   **1.1084** |    **2** | *****            | **No**       |     **525 B** |      **24 B** |
 GetDescription | .NET 7.0 | 171.4 ns |  3.39 ns |  3.33 ns | 0.83 ns | 167.2 ns | 167.7 ns | 173.1 ns | 173.4 ns | 176.9 ns | 5,833,422.5 |      3.3932 ns |      16.00 |    1.397 |  2.000 |  -0.0850 |    1 | *            | No       |     529 B |      24 B |
 **GetItems**       | **.NET 6.0** | **879.9 ns** | **10.89 ns** | **10.18 ns** | **2.63 ns** | **865.3 ns** | **871.7 ns** | **878.3 ns** | **888.8 ns** | **895.1 ns** | **1,136,480.8** |     **10.8854 ns** |      **15.00** |    **1.403** |  **2.000** |   **0.1841** |    **4** | *****            | **No**       |     **580 B** |     **512 B** |
 GetItems       | .NET 7.0 | 708.4 ns |  2.40 ns |  2.13 ns | 0.57 ns | 705.5 ns | 707.0 ns | 708.3 ns | 709.6 ns | 712.7 ns | 1,411,581.4 |      2.3973 ns |      14.00 |    2.091 |  2.000 |   0.3610 |    3 | *            | No       |     586 B |     512 B |
