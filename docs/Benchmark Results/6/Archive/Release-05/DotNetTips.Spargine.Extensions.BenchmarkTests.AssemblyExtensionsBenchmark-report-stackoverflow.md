
    BenchmarkDotNet=v0.13.5, OS=Windows 10 (10.0.19045.2846/22H2/2022Update)
    Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
    .NET SDK=7.0.203
      [Host]     : .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
      Job-ICYIAI : .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
      Job-QAMYPG : .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2

    EvaluateOverhead=True  Server=True  Namespace=DotNetTips.Spargine.Extensions.BenchmarkTests  
    Categories=Reflection  

               Method |  Runtime |       Mean |    Error |   StdDev |  StdErr |        Min |         Q1 |     Median |         Q3 |        Max |        Op/s | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Code Size | Allocated |
    ----------------- |--------- |-----------:|---------:|---------:|--------:|-----------:|-----------:|-----------:|-----------:|-----------:|------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |----------:|----------:|
     **GetAllInterfaces** | **.NET 6.0** | **2,580.6 ns** | **10.01 ns** |  **8.87 ns** | **2.37 ns** | **2,568.3 ns** | **2,575.2 ns** | **2,579.4 ns** | **2,583.7 ns** | **2,600.0 ns** |   **387,507.6** |      **10.008 ns** |      **14.00** |    **2.457** |  **2.000** |   **0.6717** |    **5** |            ***** |       **No** |     **358 B** |    **1088 B** |
     GetAllInterfaces | .NET 7.0 | 2,806.7 ns | 14.26 ns | 12.64 ns | 3.38 ns | 2,786.7 ns | 2,798.6 ns | 2,807.4 ns | 2,809.5 ns | 2,832.9 ns |   356,289.9 |      14.258 ns |      14.00 |    2.489 |  2.000 |   0.5204 |    6 |            * |       No |     711 B |    1096 B |
          **GetAllTypes** | **.NET 6.0** | **1,422.0 ns** |  **3.00 ns** |  **2.66 ns** | **0.71 ns** | **1,418.0 ns** | **1,420.3 ns** | **1,421.5 ns** | **1,423.4 ns** | **1,426.9 ns** |   **703,249.1** |       **3.003 ns** |      **14.00** |    **2.090** |  **2.000** |   **0.4576** |    **3** |            ***** |       **No** |     **347 B** |     **456 B** |
          GetAllTypes | .NET 7.0 | 1,448.7 ns |  4.66 ns |  4.36 ns | 1.13 ns | 1,440.4 ns | 1,445.7 ns | 1,448.2 ns | 1,451.7 ns | 1,457.2 ns |   690,297.8 |       4.659 ns |      15.00 |    2.272 |  2.000 |   0.0250 |    4 |            * |       No |     724 B |     464 B |
         **GetInstances** | **.NET 6.0** |   **596.4 ns** |  **1.71 ns** |  **1.60 ns** | **0.41 ns** |   **593.1 ns** |   **595.6 ns** |   **596.4 ns** |   **597.5 ns** |   **600.0 ns** | **1,676,625.9** |       **1.710 ns** |      **15.00** |    **3.007** |  **2.000** |   **0.1004** |    **2** |            ***** |       **No** |     **162 B** |      **56 B** |
         GetInstances | .NET 7.0 |   554.2 ns |  2.98 ns |  2.64 ns | 0.71 ns |   546.2 ns |   553.7 ns |   554.9 ns |   555.3 ns |   557.4 ns | 1,804,547.7 |       2.978 ns |      14.00 |    6.029 |  2.000 |  -1.7788 |    1 |            * |       No |     165 B |      56 B |