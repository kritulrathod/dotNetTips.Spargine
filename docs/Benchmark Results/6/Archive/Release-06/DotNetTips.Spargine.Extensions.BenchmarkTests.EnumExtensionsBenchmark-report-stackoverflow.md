
    BenchmarkDotNet v0.13.6, Windows 10 (10.0.19045.3208/22H2/2022Update)
    Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
    .NET SDK 8.0.100-preview.6.23330.14
      [Host]     : .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
      Job-RQFQWF : .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
      Job-MOWSHR : .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2

    EvaluateOverhead=True  Server=True  Namespace=DotNetTips.Spargine.Extensions.BenchmarkTests  
    Categories=Collections  

             Method |  Runtime |     Mean |   Error |  StdDev |  StdErr |      Min |       Q1 |   Median |       Q3 |      Max |        Op/s | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Code Size | Allocated |
    --------------- |--------- |---------:|--------:|--------:|--------:|---------:|---------:|---------:|---------:|---------:|------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |----------:|----------:|
     **GetDescription** | **.NET 6.0** | **237.3 ns** | **0.26 ns** | **0.21 ns** | **0.06 ns** | **236.9 ns** | **237.2 ns** | **237.3 ns** | **237.4 ns** | **237.8 ns** | **4,213,697.1** |      **0.2568 ns** |      **13.00** |    **2.797** |  **2.000** |  **-0.1375** |    **2** |            ***** |       **No** |     **357 B** |      **24 B** |
     GetDescription | .NET 7.0 | 160.5 ns | 0.16 ns | 0.14 ns | 0.04 ns | 160.3 ns | 160.4 ns | 160.5 ns | 160.6 ns | 160.7 ns | 6,230,277.8 |      0.1628 ns |      13.00 |    1.565 |  2.000 |  -0.4312 |    1 |            * |       No |     732 B |      24 B |
           **GetItems** | **.NET 6.0** | **800.8 ns** | **1.24 ns** | **1.10 ns** | **0.29 ns** | **798.7 ns** | **800.1 ns** | **800.7 ns** | **801.4 ns** | **803.1 ns** | **1,248,752.4** |      **1.2370 ns** |      **14.00** |    **2.648** |  **2.000** |   **0.1558** |    **4** |            ***** |       **No** |     **526 B** |     **512 B** |
           GetItems | .NET 7.0 | 640.8 ns | 5.00 ns | 4.68 ns | 1.21 ns | 636.4 ns | 637.2 ns | 638.9 ns | 644.0 ns | 650.2 ns | 1,560,600.7 |      5.0044 ns |      15.00 |    2.006 |  2.000 |   0.7688 |    3 |            * |       No |     931 B |     512 B |
