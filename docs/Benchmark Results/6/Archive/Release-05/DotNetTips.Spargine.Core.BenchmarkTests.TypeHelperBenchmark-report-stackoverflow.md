
    BenchmarkDotNet=v0.13.5, OS=Windows 10 (10.0.19045.2846/22H2/2022Update)
    Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
    .NET SDK=7.0.203
      [Host]     : .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
      Job-HKLNRY : .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
      Job-YUPBRV : .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2

    EvaluateOverhead=True  Server=True  Namespace=DotNetTips.Spargine.Core.BenchmarkTests  

                                         Method |  Runtime | Categories |        Mean |     Error |    StdDev |   StdErr |         Min |          Q1 |      Median |          Q3 |         Max |      Op/s | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Code Size | Allocated |
    ------------------------------------------- |--------- |----------- |------------:|----------:|----------:|---------:|------------:|------------:|------------:|------------:|------------:|----------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |----------:|----------:|
     **'Looping Collection: Normal StringBuilder'** | **.NET 6.0** |    **Strings** |  **3,904.4 ns** |  **47.72 ns** |  **42.31 ns** | **11.31 ns** |  **3,859.6 ns** |  **3,870.4 ns** |  **3,896.4 ns** |  **3,920.2 ns** |  **4,005.1 ns** | **256,121.7** |       **47.72 ns** |      **14.00** |    **2.975** |  **2.000** |   **0.9696** |    **1** |            ***** |       **No** |   **3,148 B** |      **8 KB** |
     'Looping Collection: Normal StringBuilder' | .NET 7.0 |    Strings |  4,081.0 ns |  42.36 ns |  39.63 ns | 10.23 ns |  4,029.4 ns |  4,045.2 ns |  4,078.2 ns |  4,101.9 ns |  4,153.7 ns | 245,040.4 |       42.36 ns |      15.00 |    1.806 |  2.000 |   0.3051 |    2 |            * |       No |   2,905 B |   8.03 KB |
                              **GetPropertyValues** | **.NET 6.0** | **Reflection** | **41,491.4 ns** | **307.99 ns** | **288.09 ns** | **74.39 ns** | **41,146.2 ns** | **41,264.9 ns** | **41,440.5 ns** | **41,667.8 ns** | **42,241.5 ns** |  **24,101.4** |      **307.99 ns** |      **15.00** |    **3.496** |  **2.000** |   **0.9728** |    **4** |            ***** |       **No** |   **2,585 B** |   **4.56 KB** |
                              GetPropertyValues | .NET 7.0 | Reflection | 40,514.0 ns | 148.29 ns | 138.71 ns | 35.82 ns | 40,302.1 ns | 40,412.1 ns | 40,501.8 ns | 40,587.4 ns | 40,773.5 ns |  24,682.8 |      148.29 ns |      15.00 |    2.171 |  2.000 |   0.3688 |    3 |            * |       No |   2,993 B |   4.56 KB |
