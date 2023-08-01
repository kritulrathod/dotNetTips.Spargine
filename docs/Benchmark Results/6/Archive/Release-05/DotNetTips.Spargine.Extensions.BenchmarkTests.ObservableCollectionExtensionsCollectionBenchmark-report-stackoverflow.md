
    BenchmarkDotNet=v0.13.5, OS=Windows 10 (10.0.19045.2846/22H2/2022Update)
    Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
    .NET SDK=7.0.203
      [Host]     : .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
      Job-ICYIAI : .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
      Job-QAMYPG : .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2

    EvaluateOverhead=True  Server=True  Namespace=DotNetTips.Spargine.Extensions.BenchmarkTests  
    Categories=Collections  

                         Method |  Runtime | Count |        Mean |    Error |   StdDev |   StdErr |         Min |          Q1 |      Median |          Q3 |         Max |         Op/s | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Code Size | Allocated |
    --------------------------- |--------- |------ |------------:|---------:|---------:|---------:|------------:|------------:|------------:|------------:|------------:|-------------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |----------:|----------:|
         **'HasItems: With Count'** | **.NET 6.0** |    **10** |    **71.99 ns** | **0.202 ns** | **0.179 ns** | **0.048 ns** |    **71.74 ns** |    **71.90 ns** |    **71.96 ns** |    **72.10 ns** |    **72.39 ns** | **13,890,789.7** |      **0.2021 ns** |      **14.00** |    **2.503** |  **2.000** |   **0.5622** |    **6** |            ***** |       **No** |     **199 B** |      **40 B** |
         'HasItems: With Count' | .NET 7.0 |    10 |    69.33 ns | 0.242 ns | 0.215 ns | 0.057 ns |    68.90 ns |    69.28 ns |    69.36 ns |    69.45 ns |    69.69 ns | 14,422,819.5 |      0.2421 ns |      14.00 |    2.451 |  2.000 |  -0.4868 |    5 |            * |       No |     175 B |      40 B |
         'HasItems: With Count' | .NET 6.0 |    20 |   125.42 ns | 0.404 ns | 0.378 ns | 0.098 ns |   124.64 ns |   125.21 ns |   125.44 ns |   125.70 ns |   126.18 ns |  7,973,264.9 |      0.4044 ns |      15.00 |    2.585 |  2.000 |   0.0055 |    8 |            * |       No |     199 B |      40 B |
         'HasItems: With Count' | .NET 7.0 |    20 |   129.56 ns | 0.492 ns | 0.460 ns | 0.119 ns |   128.90 ns |   129.17 ns |   129.47 ns |   129.83 ns |   130.32 ns |  7,718,467.6 |      0.4922 ns |      15.00 |    1.715 |  2.000 |   0.3554 |    9 |            * |       No |     175 B |      40 B |
         'HasItems: With Count' | .NET 6.0 |    25 |   160.66 ns | 0.565 ns | 0.529 ns | 0.136 ns |   159.65 ns |   160.29 ns |   160.64 ns |   161.10 ns |   161.51 ns |  6,224,501.1 |      0.5651 ns |      15.00 |    1.888 |  2.000 |  -0.1103 |   12 |            * |       No |     199 B |      40 B |
         'HasItems: With Count' | .NET 7.0 |    25 |   159.62 ns | 0.406 ns | 0.379 ns | 0.098 ns |   158.89 ns |   159.41 ns |   159.52 ns |   160.01 ns |   160.19 ns |  6,265,075.3 |      0.4056 ns |      15.00 |    1.890 |  2.000 |  -0.0900 |   12 |            * |       No |     175 B |      40 B |
         'HasItems: With Count' | .NET 6.0 |    50 |   266.36 ns | 0.793 ns | 0.742 ns | 0.192 ns |   264.82 ns |   266.09 ns |   266.32 ns |   266.78 ns |   267.66 ns |  3,754,299.7 |      0.7933 ns |      15.00 |    2.458 |  2.000 |  -0.2648 |   13 |            * |       No |     199 B |      40 B |
         'HasItems: With Count' | .NET 7.0 |    50 |   290.95 ns | 0.665 ns | 0.590 ns | 0.158 ns |   290.43 ns |   290.57 ns |   290.68 ns |   291.22 ns |   292.35 ns |  3,437,018.3 |      0.6654 ns |      14.00 |    2.952 |  2.000 |   1.1079 |   15 |            * |       No |     175 B |      40 B |
         'HasItems: With Count' | .NET 6.0 |    75 |   391.05 ns | 0.680 ns | 0.568 ns | 0.157 ns |   389.88 ns |   390.84 ns |   390.97 ns |   391.39 ns |   391.94 ns |  2,557,224.1 |      0.6799 ns |      13.00 |    2.376 |  2.000 |  -0.1630 |   16 |            * |       No |     199 B |      40 B |
         'HasItems: With Count' | .NET 7.0 |    75 |   419.45 ns | 1.241 ns | 1.036 ns | 0.287 ns |   417.14 ns |   418.66 ns |   419.83 ns |   420.14 ns |   420.85 ns |  2,384,072.3 |      1.2407 ns |      13.00 |    2.468 |  2.000 |  -0.7584 |   19 |            * |       No |     175 B |      40 B |
         'HasItems: With Count' | .NET 6.0 |   100 |   498.08 ns | 1.776 ns | 1.574 ns | 0.421 ns |   495.30 ns |   497.13 ns |   497.85 ns |   498.77 ns |   501.41 ns |  2,007,726.7 |      1.7759 ns |      14.00 |    2.499 |  2.000 |   0.3900 |   20 |            * |       No |     199 B |      40 B |
         'HasItems: With Count' | .NET 7.0 |   100 |   546.29 ns | 2.131 ns | 1.993 ns | 0.515 ns |   541.26 ns |   545.30 ns |   547.10 ns |   547.59 ns |   548.53 ns |  1,830,522.5 |      2.1306 ns |      15.00 |    3.255 |  2.000 |  -1.0861 |   22 |            * |       No |     175 B |      40 B |
         'HasItems: With Count' | .NET 6.0 |   250 | 1,199.16 ns | 3.598 ns | 3.366 ns | 0.869 ns | 1,192.01 ns | 1,196.91 ns | 1,199.11 ns | 1,201.37 ns | 1,204.38 ns |    833,913.9 |      3.5982 ns |      15.00 |    2.249 |  2.000 |  -0.3065 |   23 |            * |       No |     199 B |      40 B |
         'HasItems: With Count' | .NET 7.0 |   250 | 1,252.34 ns | 4.717 ns | 4.412 ns | 1.139 ns | 1,243.72 ns | 1,249.52 ns | 1,253.85 ns | 1,255.75 ns | 1,257.80 ns |    798,504.8 |      4.7170 ns |      15.00 |    1.893 |  2.000 |  -0.6355 |   24 |            * |       No |     175 B |      40 B |
     **'HasItems: With Predicate'** | **.NET 6.0** |    **10** |    **23.99 ns** | **0.078 ns** | **0.070 ns** | **0.019 ns** |    **23.88 ns** |    **23.94 ns** |    **23.98 ns** |    **24.03 ns** |    **24.11 ns** | **41,688,128.3** |      **0.0784 ns** |      **14.00** |    **1.893** |  **2.000** |   **0.2566** |    **1** |            ***** |       **No** |     **540 B** |      **40 B** |
     'HasItems: With Predicate' | .NET 7.0 |    10 |    28.84 ns | 0.184 ns | 0.172 ns | 0.044 ns |    28.55 ns |    28.69 ns |    28.86 ns |    28.92 ns |    29.19 ns | 34,674,730.0 |      0.1841 ns |      15.00 |    2.319 |  2.000 |   0.3314 |    4 |            * |       No |     530 B |      40 B |
     'HasItems: With Predicate' | .NET 6.0 |    20 |    24.13 ns | 0.089 ns | 0.079 ns | 0.021 ns |    23.98 ns |    24.10 ns |    24.15 ns |    24.18 ns |    24.24 ns | 41,443,272.6 |      0.0894 ns |      14.00 |    2.067 |  2.000 |  -0.6594 |    1 |            * |       No |     540 B |      40 B |
     'HasItems: With Predicate' | .NET 7.0 |    20 |    28.77 ns | 0.130 ns | 0.115 ns | 0.031 ns |    28.57 ns |    28.72 ns |    28.77 ns |    28.84 ns |    29.01 ns | 34,759,516.1 |      0.1296 ns |      14.00 |    2.569 |  2.000 |  -0.0213 |    4 |            * |       No |     530 B |      40 B |
     'HasItems: With Predicate' | .NET 6.0 |    25 |    25.20 ns | 0.083 ns | 0.069 ns | 0.019 ns |    25.09 ns |    25.15 ns |    25.20 ns |    25.25 ns |    25.32 ns | 39,685,370.6 |      0.0828 ns |      13.00 |    1.525 |  2.000 |   0.0803 |    3 |            * |       No |     540 B |      40 B |
     'HasItems: With Predicate' | .NET 7.0 |    25 |    28.56 ns | 0.098 ns | 0.087 ns | 0.023 ns |    28.40 ns |    28.51 ns |    28.55 ns |    28.60 ns |    28.70 ns | 35,014,309.6 |      0.0980 ns |      14.00 |    2.201 |  2.000 |  -0.0641 |    4 |            * |       No |     530 B |      40 B |
     'HasItems: With Predicate' | .NET 6.0 |    50 |    24.63 ns | 0.084 ns | 0.079 ns | 0.020 ns |    24.50 ns |    24.58 ns |    24.63 ns |    24.69 ns |    24.76 ns | 40,607,771.9 |      0.0844 ns |      15.00 |    1.796 |  2.000 |   0.0190 |    2 |            * |       No |     540 B |      40 B |
     'HasItems: With Predicate' | .NET 7.0 |    50 |    28.97 ns | 0.254 ns | 0.237 ns | 0.061 ns |    28.61 ns |    28.79 ns |    28.95 ns |    29.13 ns |    29.41 ns | 34,513,723.5 |      0.2535 ns |      15.00 |    1.737 |  2.000 |   0.2186 |    4 |            * |       No |     530 B |      40 B |
     'HasItems: With Predicate' | .NET 6.0 |    75 |    24.71 ns | 0.082 ns | 0.076 ns | 0.020 ns |    24.59 ns |    24.65 ns |    24.73 ns |    24.75 ns |    24.82 ns | 40,473,783.6 |      0.0817 ns |      15.00 |    1.696 |  2.000 |  -0.3088 |    2 |            * |       No |     540 B |      40 B |
     'HasItems: With Predicate' | .NET 7.0 |    75 |    29.19 ns | 0.289 ns | 0.270 ns | 0.070 ns |    28.81 ns |    28.98 ns |    29.10 ns |    29.46 ns |    29.63 ns | 34,262,504.1 |      0.2891 ns |      15.00 |    1.492 |  2.000 |   0.2328 |    4 |            * |       No |     530 B |      40 B |
     'HasItems: With Predicate' | .NET 6.0 |   100 |    25.30 ns | 0.133 ns | 0.124 ns | 0.032 ns |    25.03 ns |    25.23 ns |    25.33 ns |    25.38 ns |    25.49 ns | 39,527,907.6 |      0.1326 ns |      15.00 |    2.361 |  2.000 |  -0.5024 |    3 |            * |       No |     540 B |      40 B |
     'HasItems: With Predicate' | .NET 7.0 |   100 |    28.58 ns | 0.201 ns | 0.188 ns | 0.049 ns |    28.32 ns |    28.40 ns |    28.63 ns |    28.69 ns |    28.93 ns | 34,991,809.2 |      0.2011 ns |      15.00 |    1.665 |  2.000 |   0.1771 |    4 |            * |       No |     530 B |      40 B |
     'HasItems: With Predicate' | .NET 6.0 |   250 |    25.23 ns | 0.095 ns | 0.089 ns | 0.023 ns |    25.05 ns |    25.16 ns |    25.22 ns |    25.30 ns |    25.35 ns | 39,636,836.1 |      0.0951 ns |      15.00 |    1.789 |  2.000 |  -0.2036 |    3 |            * |       No |     540 B |      40 B |
     'HasItems: With Predicate' | .NET 7.0 |   250 |    28.55 ns | 0.140 ns | 0.131 ns | 0.034 ns |    28.36 ns |    28.47 ns |    28.53 ns |    28.62 ns |    28.79 ns | 35,020,145.6 |      0.1397 ns |      15.00 |    1.976 |  2.000 |   0.3108 |    4 |            * |       No |     530 B |      40 B |
                       **HasItems** | **.NET 6.0** |    **10** |    **71.75 ns** | **0.223 ns** | **0.198 ns** | **0.053 ns** |    **71.43 ns** |    **71.61 ns** |    **71.73 ns** |    **71.86 ns** |    **72.21 ns** | **13,937,058.8** |      **0.2229 ns** |      **14.00** |    **2.810** |  **2.000** |   **0.5512** |    **6** |            ***** |       **No** |     **198 B** |      **40 B** |
                       HasItems | .NET 7.0 |    10 |    78.11 ns | 0.909 ns | 0.850 ns | 0.220 ns |    76.71 ns |    77.50 ns |    78.13 ns |    78.79 ns |    79.45 ns | 12,803,169.7 |      0.9091 ns |      15.00 |    1.627 |  2.000 |  -0.0853 |    7 |            * |       No |     178 B |      40 B |
                       HasItems | .NET 6.0 |    20 |   135.27 ns | 0.372 ns | 0.311 ns | 0.086 ns |   134.74 ns |   135.21 ns |   135.33 ns |   135.44 ns |   135.75 ns |  7,392,494.4 |      0.3722 ns |      13.00 |    1.921 |  2.000 |  -0.3986 |   10 |            * |       No |     198 B |      40 B |
                       HasItems | .NET 7.0 |    20 |   136.03 ns | 0.380 ns | 0.356 ns | 0.092 ns |   135.24 ns |   135.88 ns |   136.08 ns |   136.27 ns |   136.67 ns |  7,351,501.8 |      0.3803 ns |      15.00 |    2.702 |  2.000 |  -0.3662 |   10 |            * |       No |     178 B |      40 B |
                       HasItems | .NET 6.0 |    25 |   161.60 ns | 0.514 ns | 0.480 ns | 0.124 ns |   160.88 ns |   161.28 ns |   161.57 ns |   161.98 ns |   162.36 ns |  6,188,079.6 |      0.5135 ns |      15.00 |    1.623 |  2.000 |  -0.0481 |   12 |            * |       No |     198 B |      40 B |
                       HasItems | .NET 7.0 |    25 |   151.59 ns | 0.268 ns | 0.250 ns | 0.065 ns |   151.16 ns |   151.44 ns |   151.53 ns |   151.75 ns |   152.02 ns |  6,596,864.1 |      0.2677 ns |      15.00 |    2.002 |  2.000 |   0.3182 |   11 |            * |       No |     178 B |      40 B |
                       HasItems | .NET 6.0 |    50 |   282.13 ns | 1.096 ns | 1.025 ns | 0.265 ns |   280.40 ns |   281.32 ns |   282.06 ns |   283.01 ns |   283.53 ns |  3,544,444.5 |      1.0963 ns |      15.00 |    1.554 |  2.000 |  -0.1896 |   14 |            * |       No |     198 B |      40 B |
                       HasItems | .NET 7.0 |    50 |   284.85 ns | 1.138 ns | 1.009 ns | 0.270 ns |   283.37 ns |   284.06 ns |   284.64 ns |   285.86 ns |   286.33 ns |  3,510,662.3 |      1.1378 ns |      14.00 |    1.408 |  2.000 |   0.1652 |   14 |            * |       No |     178 B |      40 B |
                       HasItems | .NET 6.0 |    75 |   407.07 ns | 1.170 ns | 1.095 ns | 0.283 ns |   404.72 ns |   406.47 ns |   406.68 ns |   407.79 ns |   408.79 ns |  2,456,593.6 |      1.1702 ns |      15.00 |    2.270 |  2.000 |  -0.2244 |   18 |            * |       No |     198 B |      40 B |
                       HasItems | .NET 7.0 |    75 |   399.28 ns | 2.227 ns | 1.974 ns | 0.528 ns |   395.10 ns |   398.46 ns |   399.32 ns |   400.36 ns |   402.50 ns |  2,504,492.6 |      2.2269 ns |      14.00 |    2.538 |  2.000 |  -0.2623 |   17 |            * |       No |     178 B |      40 B |
                       HasItems | .NET 6.0 |   100 |   531.79 ns | 3.342 ns | 3.126 ns | 0.807 ns |   525.08 ns |   529.64 ns |   532.52 ns |   534.00 ns |   535.55 ns |  1,880,430.5 |      3.3418 ns |      15.00 |    2.224 |  2.000 |  -0.7141 |   21 |            * |       No |     198 B |      40 B |
                       HasItems | .NET 7.0 |   100 |   548.28 ns | 2.261 ns | 2.115 ns | 0.546 ns |   545.07 ns |   546.67 ns |   548.39 ns |   550.20 ns |   551.06 ns |  1,823,875.6 |      2.2613 ns |      15.00 |    1.508 |  2.000 |  -0.2493 |   22 |            * |       No |     178 B |      40 B |
                       HasItems | .NET 6.0 |   250 | 1,258.98 ns | 7.035 ns | 6.581 ns | 1.699 ns | 1,246.58 ns | 1,254.35 ns | 1,259.69 ns | 1,263.76 ns | 1,268.02 ns |    794,290.8 |      7.0353 ns |      15.00 |    1.883 |  2.000 |  -0.2215 |   24 |            * |       No |     198 B |      40 B |
                       HasItems | .NET 7.0 |   250 | 1,318.21 ns | 3.763 ns | 3.519 ns | 0.909 ns | 1,313.12 ns | 1,315.38 ns | 1,317.51 ns | 1,320.97 ns | 1,325.24 ns |    758,605.1 |      3.7625 ns |      15.00 |    1.834 |  2.000 |   0.3068 |   25 |            * |       No |     178 B |      40 B |