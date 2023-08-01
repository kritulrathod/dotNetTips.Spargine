
    BenchmarkDotNet=v0.13.5, OS=Windows 10 (10.0.19045.2846/22H2/2022Update)
    Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
    .NET SDK=7.0.203
      [Host]     : .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
      Job-ICYIAI : .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
      Job-QAMYPG : .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2

    EvaluateOverhead=True  Server=True  Namespace=DotNetTips.Spargine.Extensions.BenchmarkTests  
    Categories=**FOR COMPARISON**  

             Method |  Runtime |     Mean |     Error |    StdDev |    StdErr |      Min |       Q1 |   Median |       Q3 |      Max |          Op/s | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Code Size | Allocated |
    --------------- |--------- |---------:|----------:|----------:|----------:|---------:|---------:|---------:|---------:|---------:|--------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |----------:|----------:|
     'Equals: Guid' | .NET 6.0 | 2.672 ns | 0.0628 ns | 0.0588 ns | 0.0152 ns | 2.591 ns | 2.617 ns | 2.696 ns | 2.717 ns | 2.751 ns | 374,318,633.5 |      0.0628 ns |      15.00 |    1.216 |  2.000 |  -0.1350 |    2 |            * |       No |     117 B |         - |
     'Equals: Guid' | .NET 7.0 | 2.214 ns | 0.0204 ns | 0.0181 ns | 0.0048 ns | 2.165 ns | 2.205 ns | 2.220 ns | 2.225 ns | 2.236 ns | 451,683,679.7 |      0.0204 ns |      14.00 |    4.070 |  2.000 |  -1.2509 |    1 |            * |       No |     105 B |         - |