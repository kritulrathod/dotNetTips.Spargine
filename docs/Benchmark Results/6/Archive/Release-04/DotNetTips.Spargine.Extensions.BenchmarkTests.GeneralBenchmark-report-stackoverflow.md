
    BenchmarkDotNet=v0.13.4, OS=Windows 10 (10.0.19045.2546)
    Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
    .NET SDK=7.0.102
      [Host]     : .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
      Job-URMJSQ : .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
      Job-NCETOA : .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2

    EvaluateOverhead=True  Server=True  Namespace=DotNetTips.Spargine.Extensions.BenchmarkTests  
    Categories=**FOR COMPARISON**  

             Method |  Runtime |     Mean |     Error |    StdDev |    StdErr |      Min |       Q1 |   Median |       Q3 |      Max |          Op/s | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Code Size | Allocated |
    --------------- |--------- |---------:|----------:|----------:|----------:|---------:|---------:|---------:|---------:|---------:|--------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |----------:|----------:|
     'Equals: Guid' | .NET 6.0 | 2.367 ns | 0.0113 ns | 0.0094 ns | 0.0026 ns | 2.356 ns | 2.360 ns | 2.364 ns | 2.376 ns | 2.385 ns | 422,393,633.5 |      0.0113 ns |      13.00 |    1.640 |  2.000 |   0.4596 |    2 |            * |       No |     117 B |         - |
     'Equals: Guid' | .NET 7.0 | 2.236 ns | 0.0040 ns | 0.0035 ns | 0.0009 ns | 2.229 ns | 2.234 ns | 2.235 ns | 2.238 ns | 2.243 ns | 447,263,753.1 |      0.0040 ns |      14.00 |    2.214 |  2.000 |   0.1930 |    1 |            * |       No |     105 B |         - |