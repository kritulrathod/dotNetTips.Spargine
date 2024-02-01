```

BenchmarkDotNet v0.13.12, Windows 10 (10.0.19045.3930/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.200-preview.23624.5
  [Host]     : .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
  Job-IJMHXV : .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
  Job-SQLDLM : .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2

EvaluateOverhead=True  Server=True  Namespace=DotNetTips.Spargine.Extensions.BenchmarkTests  
Categories=Collections  

```
| Method                     | Runtime  | Count | Mean        | Error    | StdDev   | StdErr   | Min         | Q1          | Median      | Q3          | Max         | Op/s         | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Code Size | Allocated |
|--------------------------- |--------- |------ |------------:|---------:|---------:|---------:|------------:|------------:|------------:|------------:|------------:|-------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |----------:|----------:|
| **&#39;HasItems: With Count&#39;**     | **.NET 6.0** | **10**    |    **75.94 ns** | **0.321 ns** | **0.284 ns** | **0.076 ns** |    **75.39 ns** |    **75.76 ns** |    **75.93 ns** |    **76.15 ns** |    **76.46 ns** | **13,168,664.7** |      **0.3208 ns** |      **14.00** |    **2.217** |  **2.000** |  **-0.0543** |    **9** | *****            | **No**       |     **199 B** |      **40 B** |
| &#39;HasItems: With Count&#39;     | .NET 7.0 | 10    |    69.43 ns | 0.357 ns | 0.334 ns | 0.086 ns |    68.98 ns |    69.18 ns |    69.30 ns |    69.63 ns |    70.15 ns | 14,403,814.9 |      0.3573 ns |      15.00 |    2.186 |  2.000 |   0.6134 |    7 | *            | No       |     175 B |      40 B |
| &#39;HasItems: With Count&#39;     | .NET 6.0 | 20    |   143.64 ns | 0.570 ns | 0.506 ns | 0.135 ns |   142.99 ns |   143.25 ns |   143.47 ns |   144.06 ns |   144.56 ns |  6,962,064.2 |      0.5705 ns |      14.00 |    1.541 |  2.000 |   0.3527 |   12 | *            | No       |     199 B |      40 B |
| &#39;HasItems: With Count&#39;     | .NET 7.0 | 20    |   130.83 ns | 0.845 ns | 0.790 ns | 0.204 ns |   129.81 ns |   130.21 ns |   130.82 ns |   131.28 ns |   132.52 ns |  7,643,674.0 |      0.8450 ns |      15.00 |    2.217 |  2.000 |   0.3136 |   11 | *            | No       |     175 B |      40 B |
| &#39;HasItems: With Count&#39;     | .NET 6.0 | 25    |   170.18 ns | 0.989 ns | 0.925 ns | 0.239 ns |   168.99 ns |   169.49 ns |   169.70 ns |   170.70 ns |   172.41 ns |  5,875,966.2 |      0.9891 ns |      15.00 |    2.716 |  2.000 |   0.7744 |   16 | *            | No       |     199 B |      40 B |
| &#39;HasItems: With Count&#39;     | .NET 7.0 | 25    |   158.66 ns | 0.707 ns | 0.626 ns | 0.167 ns |   157.68 ns |   158.25 ns |   158.52 ns |   158.98 ns |   160.13 ns |  6,302,852.5 |      0.7067 ns |      14.00 |    2.888 |  2.000 |   0.6964 |   15 | *            | No       |     175 B |      40 B |
| &#39;HasItems: With Count&#39;     | .NET 6.0 | 50    |   300.71 ns | 0.802 ns | 0.750 ns | 0.194 ns |   299.89 ns |   300.12 ns |   300.32 ns |   301.09 ns |   302.15 ns |  3,325,459.2 |      0.8017 ns |      15.00 |    1.756 |  2.000 |   0.5351 |   19 | *            | No       |     199 B |      40 B |
| &#39;HasItems: With Count&#39;     | .NET 7.0 | 50    |   266.10 ns | 0.696 ns | 0.581 ns | 0.161 ns |   264.87 ns |   265.76 ns |   266.06 ns |   266.43 ns |   267.11 ns |  3,758,012.9 |      0.6959 ns |      13.00 |    2.496 |  2.000 |  -0.3036 |   17 | *            | No       |     175 B |      40 B |
| &#39;HasItems: With Count&#39;     | .NET 6.0 | 75    |   433.26 ns | 1.515 ns | 1.417 ns | 0.366 ns |   431.51 ns |   432.06 ns |   433.00 ns |   434.25 ns |   435.64 ns |  2,308,090.5 |      1.5152 ns |      15.00 |    1.468 |  2.000 |   0.2646 |   22 | *            | No       |     199 B |      40 B |
| &#39;HasItems: With Count&#39;     | .NET 7.0 | 75    |   385.45 ns | 1.511 ns | 1.413 ns | 0.365 ns |   383.20 ns |   384.65 ns |   385.18 ns |   386.09 ns |   388.10 ns |  2,594,367.2 |      1.5107 ns |      15.00 |    2.111 |  2.000 |   0.5228 |   20 | *            | No       |     175 B |      40 B |
| &#39;HasItems: With Count&#39;     | .NET 6.0 | 100   |   509.40 ns | 1.559 ns | 1.382 ns | 0.369 ns |   508.06 ns |   508.53 ns |   508.92 ns |   509.58 ns |   512.58 ns |  1,963,094.7 |      1.5587 ns |      14.00 |    2.770 |  2.000 |   1.1148 |   23 | *            | No       |     199 B |      40 B |
| &#39;HasItems: With Count&#39;     | .NET 7.0 | 100   |   533.28 ns | 1.765 ns | 1.564 ns | 0.418 ns |   531.23 ns |   531.84 ns |   533.33 ns |   534.17 ns |   536.06 ns |  1,875,189.8 |      1.7645 ns |      14.00 |    1.749 |  2.000 |   0.3043 |   24 | *            | No       |     175 B |      40 B |
| &#39;HasItems: With Count&#39;     | .NET 6.0 | 250   | 1,224.05 ns | 4.921 ns | 4.362 ns | 1.166 ns | 1,220.21 ns | 1,221.02 ns | 1,222.24 ns | 1,226.35 ns | 1,234.89 ns |    816,963.3 |      4.9211 ns |      14.00 |    3.166 |  2.000 |   1.1785 |   25 | *            | No       |     199 B |      40 B |
| &#39;HasItems: With Count&#39;     | .NET 7.0 | 250   | 1,219.13 ns | 3.976 ns | 3.719 ns | 0.960 ns | 1,214.10 ns | 1,216.68 ns | 1,218.18 ns | 1,222.06 ns | 1,225.67 ns |    820,256.4 |      3.9759 ns |      15.00 |    1.630 |  2.000 |   0.1896 |   25 | *            | No       |     175 B |      40 B |
| **&#39;HasItems: With Predicate&#39;** | **.NET 6.0** | **10**    |    **24.65 ns** | **0.103 ns** | **0.086 ns** | **0.024 ns** |    **24.49 ns** |    **24.60 ns** |    **24.65 ns** |    **24.71 ns** |    **24.78 ns** | **40,570,197.2** |      **0.1027 ns** |      **13.00** |    **2.137** |  **2.000** |  **-0.5260** |    **1** | *****            | **No**       |     **540 B** |      **40 B** |
| &#39;HasItems: With Predicate&#39; | .NET 7.0 | 10    |    27.78 ns | 0.165 ns | 0.154 ns | 0.040 ns |    27.49 ns |    27.70 ns |    27.83 ns |    27.87 ns |    28.00 ns | 35,998,207.8 |      0.1648 ns |      15.00 |    1.998 |  2.000 |  -0.4794 |    5 | *            | No       |     530 B |      40 B |
| &#39;HasItems: With Predicate&#39; | .NET 6.0 | 20    |    24.22 ns | 0.119 ns | 0.106 ns | 0.028 ns |    24.04 ns |    24.15 ns |    24.23 ns |    24.31 ns |    24.39 ns | 41,280,501.6 |      0.1194 ns |      14.00 |    1.659 |  2.000 |  -0.0914 |    1 | *            | No       |     540 B |      40 B |
| &#39;HasItems: With Predicate&#39; | .NET 7.0 | 20    |    27.91 ns | 0.218 ns | 0.204 ns | 0.053 ns |    27.60 ns |    27.73 ns |    27.91 ns |    28.08 ns |    28.27 ns | 35,827,134.4 |      0.2184 ns |      15.00 |    1.552 |  2.000 |   0.1233 |    5 | *            | No       |     530 B |      40 B |
| &#39;HasItems: With Predicate&#39; | .NET 6.0 | 25    |    26.06 ns | 0.161 ns | 0.151 ns | 0.039 ns |    25.83 ns |    25.96 ns |    26.00 ns |    26.14 ns |    26.38 ns | 38,369,169.0 |      0.1615 ns |      15.00 |    2.460 |  2.000 |   0.6541 |    3 | *            | No       |     540 B |      40 B |
| &#39;HasItems: With Predicate&#39; | .NET 7.0 | 25    |    28.13 ns | 0.196 ns | 0.184 ns | 0.047 ns |    27.80 ns |    27.99 ns |    28.17 ns |    28.25 ns |    28.55 ns | 35,543,301.0 |      0.1964 ns |      15.00 |    2.723 |  2.000 |   0.2670 |    5 | *            | No       |     530 B |      40 B |
| &#39;HasItems: With Predicate&#39; | .NET 6.0 | 50    |    24.75 ns | 0.121 ns | 0.114 ns | 0.029 ns |    24.58 ns |    24.67 ns |    24.73 ns |    24.84 ns |    24.94 ns | 40,395,921.0 |      0.1215 ns |      15.00 |    1.612 |  2.000 |   0.1221 |    1 | *            | No       |     540 B |      40 B |
| &#39;HasItems: With Predicate&#39; | .NET 7.0 | 50    |    28.24 ns | 0.258 ns | 0.241 ns | 0.062 ns |    27.95 ns |    28.05 ns |    28.12 ns |    28.46 ns |    28.67 ns | 35,413,272.8 |      0.2579 ns |      15.00 |    1.457 |  2.000 |   0.3815 |    5 | *            | No       |     530 B |      40 B |
| &#39;HasItems: With Predicate&#39; | .NET 6.0 | 75    |    25.04 ns | 0.113 ns | 0.106 ns | 0.027 ns |    24.89 ns |    24.95 ns |    25.03 ns |    25.14 ns |    25.24 ns | 39,929,726.9 |      0.1129 ns |      15.00 |    1.709 |  2.000 |   0.1801 |    1 | *            | No       |     540 B |      40 B |
| &#39;HasItems: With Predicate&#39; | .NET 7.0 | 75    |    27.99 ns | 0.116 ns | 0.103 ns | 0.027 ns |    27.81 ns |    27.96 ns |    27.99 ns |    28.07 ns |    28.15 ns | 35,721,298.5 |      0.1159 ns |      14.00 |    1.917 |  2.000 |  -0.1872 |    5 | *            | No       |     530 B |      40 B |
| &#39;HasItems: With Predicate&#39; | .NET 6.0 | 100   |    24.45 ns | 0.074 ns | 0.062 ns | 0.017 ns |    24.35 ns |    24.43 ns |    24.45 ns |    24.49 ns |    24.56 ns | 40,897,339.8 |      0.0740 ns |      13.00 |    2.208 |  2.000 |  -0.1182 |    1 | *            | No       |     540 B |      40 B |
| &#39;HasItems: With Predicate&#39; | .NET 7.0 | 100   |    29.50 ns | 0.162 ns | 0.143 ns | 0.038 ns |    29.24 ns |    29.40 ns |    29.51 ns |    29.61 ns |    29.72 ns | 33,893,794.1 |      0.1616 ns |      14.00 |    1.768 |  2.000 |  -0.2362 |    6 | *            | No       |     530 B |      40 B |
| &#39;HasItems: With Predicate&#39; | .NET 6.0 | 250   |    25.54 ns | 0.104 ns | 0.097 ns | 0.025 ns |    25.36 ns |    25.50 ns |    25.53 ns |    25.59 ns |    25.71 ns | 39,151,183.5 |      0.1042 ns |      15.00 |    2.095 |  2.000 |   0.0034 |    2 | *            | No       |     540 B |      40 B |
| &#39;HasItems: With Predicate&#39; | .NET 7.0 | 250   |    27.33 ns | 0.134 ns | 0.119 ns | 0.032 ns |    27.11 ns |    27.26 ns |    27.34 ns |    27.37 ns |    27.57 ns | 36,587,635.6 |      0.1338 ns |      14.00 |    2.549 |  2.000 |   0.2169 |    4 | *            | No       |     530 B |      40 B |
| **HasItems**                   | **.NET 6.0** | **10**    |    **73.59 ns** | **0.178 ns** | **0.166 ns** | **0.043 ns** |    **73.31 ns** |    **73.48 ns** |    **73.62 ns** |    **73.68 ns** |    **73.90 ns** | **13,589,564.9** |      **0.1777 ns** |      **15.00** |    **2.029** |  **2.000** |   **0.0090** |    **8** | *****            | **No**       |     **198 B** |      **40 B** |
| HasItems                   | .NET 7.0 | 10    |    68.64 ns | 0.352 ns | 0.329 ns | 0.085 ns |    68.07 ns |    68.41 ns |    68.70 ns |    68.85 ns |    69.37 ns | 14,568,409.7 |      0.3520 ns |      15.00 |    2.574 |  2.000 |   0.2492 |    7 | *            | No       |     178 B |      40 B |
| HasItems                   | .NET 6.0 | 20    |   144.24 ns | 0.396 ns | 0.351 ns | 0.094 ns |   143.77 ns |   144.02 ns |   144.16 ns |   144.43 ns |   145.09 ns |  6,932,707.7 |      0.3959 ns |      14.00 |    2.982 |  2.000 |   0.8742 |   12 | *            | No       |     198 B |      40 B |
| HasItems                   | .NET 7.0 | 20    |   122.85 ns | 0.577 ns | 0.511 ns | 0.137 ns |   121.91 ns |   122.58 ns |   122.74 ns |   123.09 ns |   123.99 ns |  8,140,135.3 |      0.5767 ns |      14.00 |    2.830 |  2.000 |   0.4054 |   10 | *            | No       |     178 B |      40 B |
| HasItems                   | .NET 6.0 | 25    |   151.35 ns | 0.679 ns | 0.567 ns | 0.157 ns |   150.70 ns |   150.80 ns |   151.28 ns |   151.67 ns |   152.66 ns |  6,607,338.6 |      0.6794 ns |      13.00 |    2.664 |  2.000 |   0.6697 |   14 | *            | No       |     198 B |      40 B |
| HasItems                   | .NET 7.0 | 25    |   149.11 ns | 0.650 ns | 0.608 ns | 0.157 ns |   148.36 ns |   148.64 ns |   148.98 ns |   149.36 ns |   150.21 ns |  6,706,378.2 |      0.6498 ns |      15.00 |    1.981 |  2.000 |   0.6745 |   13 | *            | No       |     178 B |      40 B |
| HasItems                   | .NET 6.0 | 50    |   299.17 ns | 1.059 ns | 0.939 ns | 0.251 ns |   298.13 ns |   298.57 ns |   298.76 ns |   299.65 ns |   301.27 ns |  3,342,561.6 |      1.0589 ns |      14.00 |    2.535 |  2.000 |   0.8788 |   19 | *            | No       |     198 B |      40 B |
| HasItems                   | .NET 7.0 | 50    |   270.50 ns | 0.898 ns | 0.796 ns | 0.213 ns |   269.44 ns |   270.03 ns |   270.41 ns |   270.96 ns |   272.32 ns |  3,696,904.7 |      0.8981 ns |      14.00 |    2.639 |  2.000 |   0.5771 |   18 | *            | No       |     178 B |      40 B |
| HasItems                   | .NET 6.0 | 75    |   438.18 ns | 1.209 ns | 1.131 ns | 0.292 ns |   436.08 ns |   437.67 ns |   438.14 ns |   439.03 ns |   440.08 ns |  2,282,182.1 |      1.2094 ns |      15.00 |    2.121 |  2.000 |  -0.2370 |   22 | *            | No       |     198 B |      40 B |
| HasItems                   | .NET 7.0 | 75    |   409.12 ns | 1.316 ns | 1.231 ns | 0.318 ns |   407.68 ns |   408.05 ns |   408.79 ns |   410.58 ns |   410.93 ns |  2,444,272.6 |      1.3163 ns |      15.00 |    1.325 |  2.000 |   0.3792 |   21 | *            | No       |     178 B |      40 B |
| HasItems                   | .NET 6.0 | 100   |   510.41 ns | 2.239 ns | 1.985 ns | 0.531 ns |   508.50 ns |   508.86 ns |   509.96 ns |   510.85 ns |   514.92 ns |  1,959,201.5 |      2.2393 ns |      14.00 |    2.755 |  2.000 |   1.0304 |   23 | *            | No       |     198 B |      40 B |
| HasItems                   | .NET 7.0 | 100   |   532.28 ns | 2.272 ns | 2.125 ns | 0.549 ns |   528.99 ns |   530.99 ns |   531.66 ns |   533.40 ns |   536.79 ns |  1,878,699.9 |      2.2723 ns |      15.00 |    2.416 |  2.000 |   0.5890 |   24 | *            | No       |     178 B |      40 B |
| HasItems                   | .NET 6.0 | 250   | 1,352.98 ns | 4.954 ns | 4.634 ns | 1.196 ns | 1,346.65 ns | 1,350.11 ns | 1,351.01 ns | 1,356.39 ns | 1,361.91 ns |    739,107.6 |      4.9535 ns |      15.00 |    1.837 |  2.000 |   0.4196 |   26 | *            | No       |     198 B |      40 B |
| HasItems                   | .NET 7.0 | 250   | 1,224.57 ns | 4.260 ns | 3.985 ns | 1.029 ns | 1,218.75 ns | 1,221.99 ns | 1,223.32 ns | 1,228.16 ns | 1,231.33 ns |    816,610.1 |      4.2604 ns |      15.00 |    1.550 |  2.000 |   0.1577 |   25 | *            | No       |     178 B |      40 B |