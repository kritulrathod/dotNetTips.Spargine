
    BenchmarkDotNet=v0.13.4, OS=Windows 10 (10.0.19045.2546)
    Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
    .NET SDK=7.0.102
      [Host]     : .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
      Job-URMJSQ : .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
      Job-NCETOA : .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2

    EvaluateOverhead=True  Server=True  Namespace=DotNetTips.Spargine.Extensions.BenchmarkTests  

             Method |  Runtime |     Mean |   Error |  StdDev |  StdErr |      Min |       Q1 |   Median |       Q3 |      Max |        Op/s | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Code Size | Allocated |
    --------------- |--------- |---------:|--------:|--------:|--------:|---------:|---------:|---------:|---------:|---------:|------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |----------:|----------:|
     GetAllMessages | .NET 6.0 | 160.8 ns | 0.24 ns | 0.22 ns | 0.06 ns | 160.3 ns | 160.7 ns | 160.8 ns | 161.0 ns | 161.1 ns | 6,217,955.2 |      0.2374 ns |      15.00 |    2.528 |  2.000 |  -0.5587 |    1 |            * |       No |     483 B |     272 B |
     GetAllMessages | .NET 7.0 | 168.2 ns | 1.22 ns | 1.08 ns | 0.29 ns | 166.8 ns | 167.1 ns | 168.4 ns | 169.3 ns | 169.6 ns | 5,945,235.6 |      1.2238 ns |      14.00 |    1.132 |  2.000 |  -0.0270 |    2 |            * |       No |     854 B |     272 B |
