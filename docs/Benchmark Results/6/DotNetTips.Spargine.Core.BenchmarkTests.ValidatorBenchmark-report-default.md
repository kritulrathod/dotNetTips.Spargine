
BenchmarkDotNet v0.13.12, Windows 10 (10.0.19045.3930/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.200-preview.23624.5
  [Host]     : .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
  Job-LJBPBB : .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
  Job-GJRVUV : .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2

EvaluateOverhead=True  Server=True  Namespace=DotNetTips.Spargine.Core.BenchmarkTests  

 Method                                                | Runtime  | Categories                            | Mean     | Error     | StdDev    | StdErr    | Min      | Q1       | Median   | Q3       | Max      | Op/s          | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Code Size | Allocated |
------------------------------------------------------ |--------- |-------------------------------------- |---------:|----------:|----------:|----------:|---------:|---------:|---------:|---------:|---------:|--------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |----------:|----------:|
 **'Validating Collection: No Validation'**                | **.NET 6.0** | **Validation,**NEW**,**FOR COMPARISON**** | **5.517 ns** | **0.0159 ns** | **0.0141 ns** | **0.0038 ns** | **5.499 ns** | **5.507 ns** | **5.515 ns** | **5.528 ns** | **5.543 ns** | **181,254,158.2** |      **0.0159 ns** |      **14.00** |    **1.796** |  **2.000** |   **0.4957** |    **4** | *****            | **No**       |      **72 B** |         **-** |
 'Validating Collection: No Validation'                | .NET 7.0 | Validation,**NEW**,**FOR COMPARISON** | 2.709 ns | 0.0235 ns | 0.0197 ns | 0.0055 ns | 2.675 ns | 2.700 ns | 2.707 ns | 2.720 ns | 2.745 ns | 369,109,841.6 |      0.0235 ns |      13.00 |    1.983 |  2.000 |  -0.0053 |    2 | *            | No       |      73 B |         - |
 **'Validating Collection: Validation + Inlining'**        | **.NET 6.0** | **Validation,**NEW****                    | **6.735 ns** | **0.0257 ns** | **0.0215 ns** | **0.0060 ns** | **6.698 ns** | **6.728 ns** | **6.735 ns** | **6.742 ns** | **6.783 ns** | **148,472,423.8** |      **0.0257 ns** |      **13.00** |    **2.857** |  **2.000** |   **0.2897** |    **8** | *****            | **No**       |     **250 B** |         **-** |
 'Validating Collection: Validation + Inlining'        | .NET 7.0 | Validation,**NEW**                    | 7.109 ns | 0.0369 ns | 0.0327 ns | 0.0087 ns | 7.065 ns | 7.079 ns | 7.116 ns | 7.128 ns | 7.174 ns | 140,673,249.5 |      0.0369 ns |      14.00 |    1.918 |  2.000 |   0.2380 |    9 | *            | No       |     237 B |         - |
 **'Validating Collection: Validation'**                   | **.NET 6.0** | **Validation,**NEW****                    | **6.631 ns** | **0.0440 ns** | **0.0390 ns** | **0.0104 ns** | **6.592 ns** | **6.604 ns** | **6.617 ns** | **6.649 ns** | **6.734 ns** | **150,803,695.8** |      **0.0440 ns** |      **14.00** |    **3.739** |  **2.000** |   **1.2456** |    **7** | *****            | **No**       |     **250 B** |         **-** |
 'Validating Collection: Validation'                   | .NET 7.0 | Validation,**NEW**                    | 7.039 ns | 0.0245 ns | 0.0205 ns | 0.0057 ns | 7.001 ns | 7.029 ns | 7.038 ns | 7.051 ns | 7.072 ns | 142,070,891.0 |      0.0245 ns |      13.00 |    1.973 |  2.000 |  -0.0799 |    9 | *            | No       |     237 B |         - |
 **'Validating Empty/Null String: No Validation'**         | **.NET 6.0** | **Validation,**NEW**,**FOR COMPARISON**** | **2.465 ns** | **0.0069 ns** | **0.0061 ns** | **0.0016 ns** | **2.449 ns** | **2.463 ns** | **2.465 ns** | **2.467 ns** | **2.473 ns** | **405,736,275.4** |      **0.0069 ns** |      **14.00** |    **3.847** |  **2.000** |  **-0.9383** |    **1** | *****            | **No**       |      **78 B** |         **-** |
 'Validating Empty/Null String: No Validation'         | .NET 7.0 | Validation,**NEW**,**FOR COMPARISON** | 2.768 ns | 0.0181 ns | 0.0170 ns | 0.0044 ns | 2.745 ns | 2.756 ns | 2.765 ns | 2.781 ns | 2.804 ns | 361,286,105.6 |      0.0181 ns |      15.00 |    2.129 |  2.000 |   0.5594 |    3 | *            | No       |      79 B |         - |
 **'Validating Empty/Null String: Validation + Inlining'** | **.NET 6.0** | **Validation,**NEW**,**FOR COMPARISON**** | **5.993 ns** | **0.0239 ns** | **0.0223 ns** | **0.0058 ns** | **5.966 ns** | **5.979 ns** | **5.991 ns** | **6.005 ns** | **6.038 ns** | **166,847,615.6** |      **0.0239 ns** |      **15.00** |    **2.056** |  **2.000** |   **0.5468** |    **5** | *****            | **No**       |     **495 B** |         **-** |
 'Validating Empty/Null String: Validation + Inlining' | .NET 7.0 | Validation,**NEW**,**FOR COMPARISON** | 6.155 ns | 0.0224 ns | 0.0175 ns | 0.0051 ns | 6.128 ns | 6.141 ns | 6.160 ns | 6.171 ns | 6.179 ns | 162,460,520.1 |      0.0224 ns |      12.00 |    1.409 |  2.000 |  -0.2280 |    6 | *            | No       |     794 B |         - |
 **'Validating Empty/Null String: Validation'**            | **.NET 6.0** | **Validation,**NEW**,**FOR COMPARISON**** | **6.170 ns** | **0.0309 ns** | **0.0274 ns** | **0.0073 ns** | **6.126 ns** | **6.154 ns** | **6.168 ns** | **6.175 ns** | **6.226 ns** | **162,080,394.4** |      **0.0309 ns** |      **14.00** |    **2.485** |  **2.000** |   **0.5876** |    **6** | *****            | **No**       |     **495 B** |         **-** |
 'Validating Empty/Null String: Validation'            | .NET 7.0 | Validation,**NEW**,**FOR COMPARISON** | 6.164 ns | 0.0444 ns | 0.0415 ns | 0.0107 ns | 6.117 ns | 6.132 ns | 6.149 ns | 6.192 ns | 6.255 ns | 162,232,020.3 |      0.0444 ns |      15.00 |    2.275 |  2.000 |   0.6744 |    6 | *            | No       |     885 B |         - |