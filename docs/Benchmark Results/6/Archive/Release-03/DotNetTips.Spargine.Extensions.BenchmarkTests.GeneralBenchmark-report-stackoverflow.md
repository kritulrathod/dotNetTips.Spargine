
    BenchmarkDotNet=v0.13.2.2004-nightly, OS=Windows 10 (10.0.19044.2251/21H2/November2021Update)
    Intel Core i7-7660U CPU 2.50GHz (Kaby Lake), 1 CPU, 4 logical and 2 physical cores
    .NET SDK=7.0.100
      [Host]     : .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
      Job-FOHVKI : .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
      Job-FJLZQV : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2

    EvaluateOverhead=True  Server=True  Namespace=DotNetTips.Spargine.Extensions.BenchmarkTests  

                 Method |  Runtime |         Categories |     Mean |    StdErr |      Min |       Q1 |       Q3 |      Max |          Op/s | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Code Size | Allocated |
    ------------------- |--------- |------------------- |---------:|----------:|---------:|---------:|---------:|---------:|--------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |----------:|----------:|
         **'Equals: Guid'** | **.NET 6.0** | ****FOR COMPARISON**** | **2.717 ns** | **0.0102 ns** | **2.663 ns** | **2.690 ns** | **2.732 ns** | **2.792 ns** | **368,033,690.1** |      **0.0429 ns** |      **14.00** |    **2.247** |  **2.000** |   **0.5380** |    **3** |            ***** |       **No** |     **117 B** |         **-** |
         'Equals: Guid' | .NET 7.0 | **FOR COMPARISON** | 2.349 ns | 0.0062 ns | 2.327 ns | 2.331 ns | 2.363 ns | 2.392 ns | 425,658,916.2 |      0.0255 ns |      15.00 |    1.779 |  2.000 |   0.6864 |    1 |            * |       No |     105 B |         - |
     **'FastEquals: Guid'** | **.NET 6.0** |                   **** | **3.038 ns** | **0.0251 ns** | **2.784 ns** | **2.909 ns** | **3.102 ns** | **3.517 ns** | **329,163,331.2** |      **0.0877 ns** |      **53.00** |    **3.229** |  **2.000** |   **1.0764** |    **4** |            ***** |       **No** |     **106 B** |         **-** |
     'FastEquals: Guid' | .NET 7.0 |                    | 2.534 ns | 0.0047 ns | 2.518 ns | 2.521 ns | 2.542 ns | 2.573 ns | 394,679,767.5 |      0.0200 ns |      14.00 |    2.848 |  2.000 |   1.0827 |    2 |            * |       No |     102 B |         - |
