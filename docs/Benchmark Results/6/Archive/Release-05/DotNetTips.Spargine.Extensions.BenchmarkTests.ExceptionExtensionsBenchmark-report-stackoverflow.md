
    BenchmarkDotNet=v0.13.5, OS=Windows 10 (10.0.19045.2846/22H2/2022Update)
    Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
    .NET SDK=7.0.203
      [Host]     : .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
      Job-ICYIAI : .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
      Job-QAMYPG : .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2

    EvaluateOverhead=True  Server=True  Namespace=DotNetTips.Spargine.Extensions.BenchmarkTests  

             Method |  Runtime |     Mean |   Error |  StdDev |  StdErr |      Min |       Q1 |   Median |       Q3 |      Max |        Op/s | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Code Size | Allocated |
    --------------- |--------- |---------:|--------:|--------:|--------:|---------:|---------:|---------:|---------:|---------:|------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |----------:|----------:|
     GetAllMessages | .NET 6.0 | 158.8 ns | 0.41 ns | 0.34 ns | 0.10 ns | 158.4 ns | 158.5 ns | 158.7 ns | 159.0 ns | 159.6 ns | 6,297,013.1 |      0.4106 ns |      13.00 |    2.444 |  2.000 |   0.6519 |    1 |            * |       No |     493 B |     272 B |
     GetAllMessages | .NET 7.0 | 165.4 ns | 0.61 ns | 0.51 ns | 0.14 ns | 164.7 ns | 165.1 ns | 165.5 ns | 165.7 ns | 166.5 ns | 6,044,809.4 |      0.6136 ns |      13.00 |    2.347 |  2.000 |   0.2027 |    2 |            * |       No |     864 B |     272 B |
