
    BenchmarkDotNet v0.13.6, Windows 10 (10.0.19045.3208/22H2/2022Update)
    Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
    .NET SDK 8.0.100-preview.6.23330.14
      [Host]     : .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
      Job-TPLMSH : .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
      Job-KEOQYR : .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2

    EvaluateOverhead=True  Server=True  Namespace=DotNetTips.Spargine.Core.BenchmarkTests  

                                         Method |  Runtime | Categories |        Mean |     Error |    StdDev |    StdErr |         Min |          Q1 |      Median |          Q3 |         Max |      Op/s | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Code Size | Allocated |
    ------------------------------------------- |--------- |----------- |------------:|----------:|----------:|----------:|------------:|------------:|------------:|------------:|------------:|----------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |----------:|----------:|
     **'Looping Collection: Normal StringBuilder'** | **.NET 6.0** |    **Strings** |  **3,612.7 ns** |   **6.89 ns** |   **6.11 ns** |   **1.63 ns** |  **3,603.6 ns** |  **3,609.2 ns** |  **3,611.7 ns** |  **3,616.1 ns** |  **3,624.6 ns** | **276,803.7** |       **6.887 ns** |      **14.00** |    **2.076** |  **2.000** |   **0.3255** |    **1** |            ***** |       **No** |   **3,148 B** |   **7.86 KB** |
     'Looping Collection: Normal StringBuilder' | .NET 7.0 |    Strings |  3,628.2 ns |   7.50 ns |   7.02 ns |   1.81 ns |  3,614.8 ns |  3,624.0 ns |  3,626.7 ns |  3,635.7 ns |  3,638.5 ns | 275,621.7 |       7.500 ns |      15.00 |    1.846 |  2.000 |   0.0166 |    1 |            * |       No |   2,905 B |   7.87 KB |
                              **GetPropertyValues** | **.NET 6.0** | **Reflection** | **41,694.6 ns** | **631.53 ns** | **590.74 ns** | **152.53 ns** | **41,104.5 ns** | **41,234.2 ns** | **41,538.8 ns** | **41,938.0 ns** | **42,992.4 ns** |  **23,983.9** |     **631.534 ns** |      **15.00** |    **2.450** |  **2.000** |   **0.9043** |    **3** |            ***** |       **No** |   **2,585 B** |   **4.56 KB** |
                              GetPropertyValues | .NET 7.0 | Reflection | 39,815.5 ns | 121.54 ns | 107.74 ns |  28.79 ns | 39,637.9 ns | 39,723.9 ns | 39,804.4 ns | 39,903.2 ns | 39,962.7 ns |  25,115.9 |     121.535 ns |      14.00 |    1.451 |  2.000 |  -0.0471 |    2 |            * |       No |   2,993 B |   4.56 KB |
