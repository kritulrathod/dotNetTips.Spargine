
    BenchmarkDotNet=v0.13.2.2004-nightly, OS=Windows 10 (10.0.19044.2251/21H2/November2021Update)
    Intel Core i7-7660U CPU 2.50GHz (Kaby Lake), 1 CPU, 4 logical and 2 physical cores
    .NET SDK=7.0.100
      [Host]     : .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
      Job-FOHVKI : .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
      Job-FJLZQV : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2

    EvaluateOverhead=True  Server=True  Namespace=DotNetTips.Spargine.Extensions.BenchmarkTests  

             Method |  Runtime |     Mean |  StdErr |      Min |       Q1 |       Q3 |      Max |        Op/s | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Code Size | Allocated |
    --------------- |--------- |---------:|--------:|---------:|---------:|---------:|---------:|------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |----------:|----------:|
     GetAllMessages | .NET 6.0 | 208.3 ns | 1.21 ns | 183.7 ns | 202.2 ns | 215.8 ns | 231.1 ns | 4,800,946.3 |       4.164 ns |      63.00 |    2.793 |  2.000 |  -0.1437 |    2 |            * |       No |     483 B |     272 B |
     GetAllMessages | .NET 7.0 | 190.3 ns | 1.55 ns | 167.3 ns | 177.3 ns | 205.4 ns | 235.4 ns | 5,255,451.0 |       5.261 ns |     100.00 |    2.491 |  2.857 |   0.5845 |    1 |            * |       No |     846 B |     272 B |
