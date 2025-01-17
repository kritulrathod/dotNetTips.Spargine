```

BenchmarkDotNet v0.13.9+228a464e8be6c580ad9408e98f18813f6407fb5a, Windows 10 (10.0.19045.3570/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.100-rc.2.23502.2
  [Host]     : .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
  Job-XGXFJX : .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
  Job-TJKJTW : .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2

EvaluateOverhead=True  Server=True  Namespace=DotNetTips.Spargine.Core.BenchmarkTests.Security  
Categories=Encryption  

```
| Method              | Runtime  | Mean       | Error    | StdDev    | StdErr   | Median     | Min        | Q1         | Q3         | Max        | Op/s      | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Code Size | Allocated |
|-------------------- |--------- |-----------:|---------:|----------:|---------:|-----------:|-----------:|-----------:|-----------:|-----------:|----------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |----------:|----------:|
| **AesDecrypt**          | **.NET 6.0** | **5,775.3 ns** | **66.10 ns** |  **58.60 ns** | **15.66 ns** | **5,749.8 ns** | **5,717.4 ns** | **5,737.0 ns** | **5,800.2 ns** | **5,892.4 ns** | **173,150.3** |       **66.10 ns** |      **14.00** |    **2.178** |  **2.000** |   **0.9068** |    **4** | *****            | **No**       |     **917 B** |  **13.79 KB** |
| AesDecrypt          | .NET 7.0 | 5,199.3 ns | 99.59 ns |  97.81 ns | 24.45 ns | 5,168.3 ns | 5,077.5 ns | 5,135.4 ns | 5,261.0 ns | 5,418.5 ns | 192,334.9 |       99.59 ns |      16.00 |    2.277 |  2.000 |   0.6492 |    3 | *            | No       |     908 B |  13.75 KB |
| **AesEncrypt**          | **.NET 6.0** | **4,702.8 ns** | **68.15 ns** |  **63.74 ns** | **16.46 ns** | **4,690.5 ns** | **4,637.5 ns** | **4,649.8 ns** | **4,744.9 ns** | **4,854.3 ns** | **212,641.2** |       **68.15 ns** |      **15.00** |    **2.705** |  **2.000** |   **0.8345** |    **2** | *****            | **No**       |     **914 B** |   **12.4 KB** |
| AesEncrypt          | .NET 7.0 | 4,478.2 ns | 86.82 ns | 112.89 ns | 23.04 ns | 4,403.1 ns | 4,381.4 ns | 4,385.6 ns | 4,545.4 ns | 4,700.8 ns | 223,306.1 |       86.82 ns |      24.00 |    1.837 |  2.286 |   0.7053 |    1 | *            | No       |     905 B |  12.36 KB |
| **SimpleSHA256Decrypt** | **.NET 6.0** | **5,687.8 ns** | **13.76 ns** |  **12.87 ns** |  **3.32 ns** | **5,687.5 ns** | **5,669.7 ns** | **5,679.3 ns** | **5,692.4 ns** | **5,711.3 ns** | **175,814.3** |       **13.76 ns** |      **15.00** |    **2.079** |  **2.000** |   **0.4418** |    **4** | *****            | **No**       |     **347 B** |  **11.02 KB** |
| SimpleSHA256Decrypt | .NET 7.0 | 6,507.5 ns | 17.46 ns |  16.33 ns |  4.22 ns | 6,509.5 ns | 6,477.8 ns | 6,499.6 ns | 6,515.5 ns | 6,533.8 ns | 153,669.9 |       17.46 ns |      15.00 |    2.192 |  2.000 |  -0.2169 |    6 | *            | No       |     351 B |  10.98 KB |
| **SimpleSHA256Encrypt** | **.NET 6.0** | **5,904.1 ns** | **60.22 ns** |  **53.39 ns** | **14.27 ns** | **5,892.5 ns** | **5,841.1 ns** | **5,864.2 ns** | **5,923.4 ns** | **5,998.0 ns** | **169,374.8** |       **60.22 ns** |      **14.00** |    **1.813** |  **2.000** |   **0.5452** |    **5** | *****            | **No**       |     **344 B** |  **12.63 KB** |
| SimpleSHA256Encrypt | .NET 7.0 | 5,591.8 ns | 84.62 ns |  79.15 ns | 20.44 ns | 5,573.4 ns | 5,515.5 ns | 5,523.4 ns | 5,659.3 ns | 5,765.3 ns | 178,833.0 |       84.62 ns |      15.00 |    2.094 |  2.000 |   0.6561 |    4 | *            | No       |     348 B |  12.59 KB |
