
    BenchmarkDotNet v0.13.12, Windows 10 (10.0.19045.3930/22H2/2022Update)
    Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
    .NET SDK 8.0.200-preview.23624.5
      [Host]     : .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
      Job-SIJEBH : .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
      Job-QKIZEW : .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2

    EvaluateOverhead=True  Server=True  Namespace=DotNetTips.Spargine.BenchmarkTests.IO  
    Categories=**NEW**,IO  

     Method                | Runtime  | Mean      | Error    | StdDev   | StdErr   | Min       | Q1        | Median    | Q3        | Max       | Op/s         | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Code Size | Allocated |
    ---------------------- |--------- |----------:|---------:|---------:|---------:|----------:|----------:|----------:|----------:|----------:|-------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |----------:|----------:|
     **EnsureTrailingSlash**   | **.NET 6.0** |  **49.89 ns** | **0.241 ns** | **0.225 ns** | **0.058 ns** |  **49.61 ns** |  **49.71 ns** |  **49.79 ns** |  **50.01 ns** |  **50.36 ns** | **20,045,847.7** |      **0.2407 ns** |      **15.00** |    **2.361** |  **2.000** |   **0.7720** |    **1** | *****            | **No**       |     **573 B** |      **96 B** |
     EnsureTrailingSlash   | .NET 7.0 |  56.02 ns | 0.299 ns | 0.250 ns | 0.069 ns |  55.62 ns |  55.80 ns |  56.02 ns |  56.25 ns |  56.33 ns | 17,851,586.8 |      0.2991 ns |      13.00 |    1.331 |  2.000 |  -0.1238 |    2 | *            | No       |     701 B |      96 B |
     **HasInvalidFilterChars** | **.NET 6.0** | **337.41 ns** | **2.671 ns** | **2.498 ns** | **0.645 ns** | **333.62 ns** | **335.60 ns** | **337.46 ns** | **340.02 ns** | **340.59 ns** |  **2,963,775.1** |      **2.6709 ns** |      **15.00** |    **1.477** |  **2.000** |  **-0.0720** |    **5** | *****            | **No**       |     **285 B** |    **2112 B** |
     HasInvalidFilterChars | .NET 7.0 | 407.14 ns | 2.385 ns | 2.231 ns | 0.576 ns | 403.03 ns | 405.83 ns | 407.20 ns | 409.09 ns | 410.72 ns |  2,456,173.1 |      2.3851 ns |      15.00 |    1.814 |  2.000 |  -0.1921 |    6 | *            | No       |     720 B |    2112 B |
     **PathContainsWildcard**  | **.NET 6.0** | **228.49 ns** | **1.569 ns** | **1.468 ns** | **0.379 ns** | **226.63 ns** | **227.68 ns** | **228.01 ns** | **229.48 ns** | **231.99 ns** |  **4,376,562.7** |      **1.5695 ns** |      **15.00** |    **2.761** |  **2.000** |   **0.8191** |    **3** | *****            | **No**       |     **314 B** |    **2016 B** |
     PathContainsWildcard  | .NET 7.0 | 305.13 ns | 1.452 ns | 1.358 ns | 0.351 ns | 303.05 ns | 304.19 ns | 305.11 ns | 306.05 ns | 307.24 ns |  3,277,341.8 |      1.4523 ns |      15.00 |    1.707 |  2.000 |   0.1222 |    4 | *            | No       |     445 B |    2016 B |
