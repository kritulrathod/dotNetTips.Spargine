
    BenchmarkDotNet=v0.13.4, OS=Windows 10 (10.0.19045.2546)
    Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
    .NET SDK=7.0.102
      [Host]     : .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
      Job-IELWIR : .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
      Job-EXMGJK : .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2

    EvaluateOverhead=True  Server=True  Namespace=DotNetTips.Spargine.BenchmarkTests.IO  
    Categories=**NEW**,IO  

                    Method |  Runtime |      Mean |    Error |    StdDev |   StdErr |       Min |        Q1 |    Median |        Q3 |       Max |         Op/s | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Code Size | Allocated |
    ---------------------- |--------- |----------:|---------:|----------:|---------:|----------:|----------:|----------:|----------:|----------:|-------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |----------:|----------:|
       **EnsureTrailingSlash** | **.NET 6.0** |  **57.20 ns** | **0.547 ns** |  **0.484 ns** | **0.129 ns** |  **56.58 ns** |  **56.79 ns** |  **57.17 ns** |  **57.49 ns** |  **58.33 ns** | **17,481,947.8** |      **0.5465 ns** |      **14.00** |    **2.695** |  **2.000** |   **0.6897** |    **2** |            ***** |       **No** |     **563 B** |      **96 B** |
       EnsureTrailingSlash | .NET 7.0 |  55.71 ns | 0.829 ns |  0.735 ns | 0.196 ns |  54.58 ns |  55.26 ns |  55.66 ns |  55.98 ns |  57.03 ns | 17,948,642.9 |      0.8294 ns |      14.00 |    1.924 |  2.000 |   0.1800 |    1 |            * |       No |     691 B |      96 B |
     **HasInvalidFilterChars** | **.NET 6.0** | **355.66 ns** | **6.989 ns** |  **6.196 ns** | **1.656 ns** | **345.46 ns** | **351.48 ns** | **354.26 ns** | **360.74 ns** | **367.12 ns** |  **2,811,659.2** |      **6.9894 ns** |      **14.00** |    **1.809** |  **2.000** |   **0.2368** |    **5** |            ***** |       **No** |     **285 B** |    **2112 B** |
     HasInvalidFilterChars | .NET 7.0 | 432.03 ns | 8.455 ns | 13.892 ns | 2.348 ns | 416.14 ns | 421.36 ns | 427.06 ns | 436.37 ns | 466.46 ns |  2,314,657.0 |      8.4551 ns |      35.00 |    3.059 |  2.000 |   1.1127 |    6 |            * |       No |     720 B |    2112 B |
      **PathContainsWildcard** | **.NET 6.0** | **241.75 ns** | **4.771 ns** |  **5.105 ns** | **1.203 ns** | **230.18 ns** | **238.52 ns** | **242.88 ns** | **245.10 ns** | **251.03 ns** |  **4,136,539.0** |      **4.7709 ns** |      **18.00** |    **2.602** |  **2.000** |  **-0.3465** |    **3** |            ***** |       **No** |     **314 B** |    **2016 B** |
      PathContainsWildcard | .NET 7.0 | 334.08 ns | 6.628 ns | 16.505 ns | 1.932 ns | 313.14 ns | 320.71 ns | 329.19 ns | 343.65 ns | 375.92 ns |  2,993,299.7 |      6.6276 ns |      73.00 |    2.358 |  2.296 |   0.7123 |    4 |            * |       No |     445 B |    2016 B |
