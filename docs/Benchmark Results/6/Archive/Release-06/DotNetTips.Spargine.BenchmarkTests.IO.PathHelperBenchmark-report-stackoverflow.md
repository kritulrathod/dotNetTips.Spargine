
    BenchmarkDotNet v0.13.6, Windows 10 (10.0.19045.3208/22H2/2022Update)
    Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
    .NET SDK 8.0.100-preview.6.23330.14
      [Host]     : .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
      Job-JDVVBH : .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
      Job-GJNMGF : .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2

    EvaluateOverhead=True  Server=True  Namespace=DotNetTips.Spargine.BenchmarkTests.IO  
    Categories=**NEW**,IO  

                    Method |  Runtime |      Mean |    Error |   StdDev |   StdErr |       Min |        Q1 |    Median |        Q3 |       Max |         Op/s | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Code Size | Allocated |
    ---------------------- |--------- |----------:|---------:|---------:|---------:|----------:|----------:|----------:|----------:|----------:|-------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |----------:|----------:|
       **EnsureTrailingSlash** | **.NET 6.0** |  **57.33 ns** | **0.063 ns** | **0.053 ns** | **0.015 ns** |  **57.22 ns** |  **57.32 ns** |  **57.32 ns** |  **57.35 ns** |  **57.45 ns** | **17,442,314.9** |      **0.0630 ns** |      **13.00** |    **3.469** |  **2.000** |   **0.0470** |    **1** |            ***** |       **No** |     **573 B** |      **96 B** |
       EnsureTrailingSlash | .NET 7.0 |  63.15 ns | 0.265 ns | 0.248 ns | 0.064 ns |  62.77 ns |  62.95 ns |  63.24 ns |  63.31 ns |  63.62 ns | 15,835,160.8 |      0.2653 ns |      15.00 |    1.818 |  2.000 |  -0.0747 |    2 |            * |       No |     701 B |      96 B |
     **HasInvalidFilterChars** | **.NET 6.0** | **332.90 ns** | **1.131 ns** | **1.058 ns** | **0.273 ns** | **331.64 ns** | **331.94 ns** | **332.76 ns** | **333.82 ns** | **334.67 ns** |  **3,003,906.8** |      **1.1307 ns** |      **15.00** |    **1.431** |  **2.000** |   **0.2969** |    **5** |            ***** |       **No** |     **285 B** |    **2112 B** |
     HasInvalidFilterChars | .NET 7.0 | 413.33 ns | 0.892 ns | 0.791 ns | 0.211 ns | 412.29 ns | 412.62 ns | 413.31 ns | 413.84 ns | 414.87 ns |  2,419,381.2 |      0.8924 ns |      14.00 |    1.882 |  2.000 |   0.2310 |    6 |            * |       No |     720 B |    2112 B |
      **PathContainsWildcard** | **.NET 6.0** | **233.54 ns** | **3.539 ns** | **3.634 ns** | **0.881 ns** | **228.97 ns** | **231.51 ns** | **232.80 ns** | **233.24 ns** | **243.08 ns** |  **4,281,995.6** |      **3.5386 ns** |      **17.00** |    **4.616** |  **2.000** |   **1.5897** |    **3** |            ***** |       **No** |     **314 B** |    **2016 B** |
      PathContainsWildcard | .NET 7.0 | 310.28 ns | 2.737 ns | 2.285 ns | 0.634 ns | 306.86 ns | 308.74 ns | 310.12 ns | 311.77 ns | 314.98 ns |  3,222,884.6 |      2.7365 ns |      13.00 |    2.172 |  2.000 |   0.2859 |    4 |            * |       No |     445 B |    2016 B |
