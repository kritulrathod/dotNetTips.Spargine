{noformat}

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19044.1706 (21H2)
Intel Core i7-7660U CPU 2.50GHz (Kaby Lake), 1 CPU, 4 logical and 2 physical cores
.NET SDK=6.0.300
  [Host]     : .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
  Job-SPYWVM : .NET 6.0.5 (6.0.522.21309), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET 6.0  
Namespace=DotNetTips.Spargine.Extensions.BenchmarkTests  Categories=Strings  

{noformat}
||            Method ||Count ||       Mean ||    Error ||   StdDev ||   StdErr ||        Min ||         Q1 ||     Median ||         Q3 ||        Max ||       Op/s ||CI99.9% Margin ||Iterations ||Kurtosis ||MValue ||Skewness ||Rank ||LogicalGroup ||Baseline || Gen 0 ||Code Size || Gen 1 ||Allocated ||
|    *AppendBytes:01** |     *2* | *28,700.1 ns* | *242.74 ns* | *227.06 ns* |  *58.63 ns* | *28,208.1 ns* | *28,528.8 ns* | *28,703.7 ns* | *28,874.2 ns* | *29,010.9 ns* |    *34,843.0* |     *242.742 ns* |      *15.00* |    *2.172* |  *2.000* |  *-0.4842* |    *4* |            *** |       *No* | *5.0354* |      *2 KB* | *0.0610* |     *45 KB* |
|    AppendBytes:01* |     5 | 29,780.3 ns | 257.00 ns | 227.83 ns |  60.89 ns | 29,503.8 ns | 29,599.4 ns | 29,698.7 ns | 29,975.5 ns | 30,219.8 ns |    33,579.2 |     257.004 ns |      14.00 |    1.729 |  2.000 |   0.4511 |    5 |            * |       No | 5.0354 |      2 KB | 0.0610 |     45 KB |
|    AppendBytes:01* |    10 | 29,847.3 ns | 253.28 ns | 236.92 ns |  61.17 ns | 29,428.8 ns | 29,649.0 ns | 29,884.7 ns | 29,983.7 ns | 30,241.5 ns |    33,503.9 |     253.282 ns |      15.00 |    1.815 |  2.000 |  -0.2278 |    5 |            * |       No | 5.0354 |      2 KB | 0.0610 |     45 KB |
|    AppendBytes:01* |    20 | 30,303.3 ns | 484.93 ns | 453.60 ns | 117.12 ns | 29,459.7 ns | 29,997.1 ns | 30,315.8 ns | 30,520.5 ns | 31,069.8 ns |    32,999.7 |     484.926 ns |      15.00 |    2.130 |  2.000 |   0.1522 |    5 |            * |       No | 5.0049 |      2 KB | 0.0610 |     45 KB |
|    AppendBytes:01* |    25 | 30,066.5 ns | 336.91 ns | 298.66 ns |  79.82 ns | 29,521.7 ns | 29,962.4 ns | 30,104.3 ns | 30,259.9 ns | 30,560.4 ns |    33,259.6 |     336.907 ns |      14.00 |    2.069 |  2.000 |  -0.3155 |    5 |            * |       No | 5.0354 |      2 KB | 0.0610 |     45 KB |
|    AppendBytes:01* |    50 | 30,504.3 ns | 304.20 ns | 269.66 ns |  72.07 ns | 30,067.6 ns | 30,335.9 ns | 30,478.3 ns | 30,679.9 ns | 30,954.0 ns |    32,782.2 |     304.198 ns |      14.00 |    1.774 |  2.000 |   0.1395 |    5 |            * |       No | 5.0354 |      2 KB | 0.0610 |     45 KB |
|    AppendBytes:01* |    75 | 30,141.8 ns | 218.42 ns | 182.39 ns |  50.59 ns | 29,765.2 ns | 30,036.8 ns | 30,204.5 ns | 30,228.1 ns | 30,459.6 ns |    33,176.5 |     218.416 ns |      13.00 |    2.464 |  2.000 |  -0.4708 |    5 |            * |       No | 5.0354 |      2 KB | 0.0610 |     45 KB |
|    AppendBytes:01* |   100 | 28,372.9 ns | 162.30 ns | 151.82 ns |  39.20 ns | 28,064.0 ns | 28,289.7 ns | 28,341.4 ns | 28,431.7 ns | 28,623.3 ns |    35,245.0 |     162.304 ns |      15.00 |    2.412 |  2.000 |   0.1081 |    4 |            * |       No | 5.0354 |      2 KB |      - |     45 KB |
|    AppendBytes:01* |   250 | 30,099.4 ns | 316.34 ns | 295.90 ns |  76.40 ns | 29,661.8 ns | 29,879.5 ns | 30,038.3 ns | 30,291.1 ns | 30,761.6 ns |    33,223.3 |     316.337 ns |      15.00 |    2.405 |  2.000 |   0.5166 |    5 |            * |       No | 5.0354 |      2 KB | 0.0610 |     45 KB |
|     *AppendKeyValue* |     *2* |  *3,336.3 ns* |  *31.56 ns* |  *29.52 ns* |   *7.62 ns* |  *3,281.0 ns* |  *3,316.8 ns* |  *3,333.8 ns* |  *3,357.6 ns* |  *3,395.5 ns* |   *299,734.4* |      *31.555 ns* |      *15.00* |    *2.284* |  *2.000* |   *0.1127* |    *3* |            *** |       *No* | *0.3014* |      *2 KB* |      *-* |      *3 KB* |
|     AppendKeyValue |     5 |  3,315.0 ns |  30.46 ns |  28.49 ns |   7.36 ns |  3,275.0 ns |  3,285.2 ns |  3,317.6 ns |  3,336.1 ns |  3,353.7 ns |   301,656.3 |      30.455 ns |      15.00 |    1.389 |  2.000 |  -0.1444 |    3 |            * |       No | 0.3052 |      2 KB |      - |      3 KB |
|     AppendKeyValue |    10 |  3,419.3 ns |  50.58 ns |  47.31 ns |  12.22 ns |  3,365.0 ns |  3,383.5 ns |  3,412.8 ns |  3,444.4 ns |  3,520.8 ns |   292,458.3 |      50.579 ns |      15.00 |    2.280 |  2.000 |   0.7557 |    3 |            * |       No | 0.3052 |      2 KB |      - |      3 KB |
|     AppendKeyValue |    20 |  3,377.0 ns |  51.21 ns |  47.90 ns |  12.37 ns |  3,310.4 ns |  3,336.9 ns |  3,376.2 ns |  3,408.8 ns |  3,475.1 ns |   296,124.3 |      51.206 ns |      15.00 |    2.021 |  2.000 |   0.1761 |    3 |            * |       No | 0.3014 |      2 KB |      - |      3 KB |
|     AppendKeyValue |    25 |  3,305.6 ns |  40.61 ns |  37.98 ns |   9.81 ns |  3,233.6 ns |  3,291.5 ns |  3,302.7 ns |  3,333.4 ns |  3,358.2 ns |   302,515.9 |      40.606 ns |      15.00 |    2.191 |  2.000 |  -0.3712 |    3 |            * |       No | 0.2975 |      2 KB |      - |      3 KB |
|     AppendKeyValue |    50 |  3,363.8 ns |  43.27 ns |  40.47 ns |  10.45 ns |  3,301.5 ns |  3,334.3 ns |  3,364.7 ns |  3,384.9 ns |  3,455.3 ns |   297,281.9 |      43.269 ns |      15.00 |    2.612 |  2.000 |   0.3885 |    3 |            * |       No | 0.3090 |      2 KB |      - |      3 KB |
|     AppendKeyValue |    75 |  3,394.6 ns |  47.58 ns |  44.51 ns |  11.49 ns |  3,326.9 ns |  3,370.1 ns |  3,377.6 ns |  3,432.0 ns |  3,487.0 ns |   294,584.7 |      47.584 ns |      15.00 |    2.101 |  2.000 |   0.5437 |    3 |            * |       No | 0.3052 |      2 KB |      - |      3 KB |
|     AppendKeyValue |   100 |  3,432.1 ns |  22.63 ns |  20.06 ns |   5.36 ns |  3,389.2 ns |  3,425.1 ns |  3,432.2 ns |  3,440.6 ns |  3,467.3 ns |   291,369.8 |      22.632 ns |      14.00 |    2.597 |  2.000 |  -0.2694 |    3 |            * |       No | 0.3014 |      2 KB |      - |      3 KB |
|     AppendKeyValue |   250 |  3,435.8 ns |  34.07 ns |  31.87 ns |   8.23 ns |  3,385.6 ns |  3,416.7 ns |  3,437.3 ns |  3,458.4 ns |  3,501.0 ns |   291,049.8 |      34.074 ns |      15.00 |    2.096 |  2.000 |   0.1299 |    3 |            * |       No | 0.3090 |      2 KB |      - |      3 KB |
|       *AppendValues* |     *2* |    *657.4 ns* |   *8.02 ns* |   *7.50 ns* |   *1.94 ns* |    *645.3 ns* |    *653.1 ns* |    *655.8 ns* |    *662.7 ns* |    *670.5 ns* | *1,521,161.8* |       *8.023 ns* |      *15.00* |    *1.872* |  *2.000* |   *0.0206* |    *1* |            *** |       *No* | *0.1612* |      *1 KB* |      *-* |      *1 KB* |
|       AppendValues |     5 |    657.4 ns |   7.04 ns |   6.58 ns |   1.70 ns |    647.2 ns |    652.7 ns |    658.1 ns |    662.6 ns |    668.0 ns | 1,521,151.6 |       7.038 ns |      15.00 |    1.562 |  2.000 |  -0.1027 |    1 |            * |       No | 0.1621 |      1 KB |      - |      1 KB |
|       AppendValues |    10 |    653.8 ns |   6.28 ns |   5.24 ns |   1.45 ns |    645.7 ns |    650.4 ns |    652.5 ns |    659.3 ns |    661.1 ns | 1,529,420.6 |       6.278 ns |      13.00 |    1.320 |  2.000 |   0.0658 |    1 |            * |       No | 0.1612 |      1 KB |      - |      1 KB |
|       AppendValues |    20 |    645.8 ns |   8.67 ns |   7.69 ns |   2.05 ns |    632.3 ns |    640.7 ns |    646.4 ns |    652.6 ns |    656.3 ns | 1,548,361.6 |       8.674 ns |      14.00 |    1.527 |  2.000 |  -0.2297 |    1 |            * |       No | 0.1631 |      1 KB |      - |      1 KB |
|       AppendValues |    25 |    718.4 ns |  14.21 ns |  25.25 ns |   3.99 ns |    649.7 ns |    714.0 ns |    729.1 ns |    733.8 ns |    743.8 ns | 1,391,922.0 |      14.208 ns |      40.00 |    4.176 |  2.000 |  -1.5496 |    2 |            * |       No | 0.1602 |      1 KB |      - |      1 KB |
|       AppendValues |    50 |    655.1 ns |   5.70 ns |   5.33 ns |   1.38 ns |    643.7 ns |    653.4 ns |    656.6 ns |    658.8 ns |    661.1 ns | 1,526,475.6 |       5.702 ns |      15.00 |    2.442 |  2.000 |  -0.8316 |    1 |            * |       No | 0.1621 |      1 KB |      - |      1 KB |
|       AppendValues |    75 |    650.0 ns |   8.39 ns |   7.85 ns |   2.03 ns |    636.2 ns |    645.4 ns |    651.7 ns |    657.0 ns |    661.6 ns | 1,538,394.4 |       8.391 ns |      15.00 |    1.704 |  2.000 |  -0.2647 |    1 |            * |       No | 0.1640 |      1 KB |      - |      1 KB |
|       AppendValues |   100 |    644.7 ns |  10.64 ns |   9.96 ns |   2.57 ns |    627.3 ns |    637.4 ns |    644.9 ns |    652.4 ns |    659.8 ns | 1,551,010.9 |      10.644 ns |      15.00 |    1.720 |  2.000 |  -0.0659 |    1 |            * |       No | 0.1631 |      1 KB |      - |      1 KB |
|       AppendValues |   250 |    656.4 ns |   5.50 ns |   4.88 ns |   1.30 ns |    647.9 ns |    653.6 ns |    656.5 ns |    660.1 ns |    665.4 ns | 1,523,511.5 |       5.503 ns |      14.00 |    1.981 |  2.000 |  -0.0037 |    1 |            * |       No | 0.1621 |      1 KB |      - |      1 KB |
| *BytesToString:01*** |     *2* | *30,333.8 ns* | *360.51 ns* | *319.58 ns* |  *85.41 ns* | *29,532.2 ns* | *30,255.4 ns* | *30,380.7 ns* | *30,509.6 ns* | *30,836.0 ns* |    *32,966.6* |     *360.512 ns* |      *14.00* |    *3.520* |  *2.000* |  *-0.8742* |    *5* |            *** |       *No* | *5.0049* |      *2 KB* | *0.0610* |     *45 KB* |
| BytesToString:01** |     5 | 29,964.7 ns | 378.09 ns | 353.66 ns |  91.32 ns | 29,309.0 ns | 29,739.6 ns | 29,987.8 ns | 30,217.7 ns | 30,448.1 ns |    33,372.6 |     378.089 ns |      15.00 |    1.865 |  2.000 |  -0.2612 |    5 |            * |       No | 5.0049 |      2 KB | 0.0610 |     45 KB |
| BytesToString:01** |    10 | 30,705.1 ns | 384.37 ns | 359.54 ns |  92.83 ns | 29,859.4 ns | 30,592.9 ns | 30,739.9 ns | 30,913.7 ns | 31,357.8 ns |    32,567.9 |     384.370 ns |      15.00 |    3.124 |  2.000 |  -0.5901 |    5 |            * |       No | 5.0049 |      2 KB |      - |     45 KB |
| BytesToString:01** |    20 | 29,214.3 ns | 278.58 ns | 260.59 ns |  67.28 ns | 28,693.4 ns | 29,005.1 ns | 29,241.0 ns | 29,349.7 ns | 29,648.2 ns |    34,229.8 |     278.583 ns |      15.00 |    2.130 |  2.000 |  -0.1860 |    5 |            * |       No | 5.0354 |      2 KB | 0.0610 |     45 KB |
| BytesToString:01** |    25 | 30,426.6 ns | 282.41 ns | 264.16 ns |  68.21 ns | 29,773.4 ns | 30,286.7 ns | 30,465.8 ns | 30,623.1 ns | 30,769.3 ns |    32,866.0 |     282.408 ns |      15.00 |    3.033 |  2.000 |  -0.8970 |    5 |            * |       No | 5.0354 |      2 KB | 0.0610 |     45 KB |
| BytesToString:01** |    50 | 30,732.5 ns | 550.69 ns | 515.12 ns | 133.00 ns | 29,812.9 ns | 30,460.5 ns | 30,758.2 ns | 31,030.6 ns | 31,850.1 ns |    32,538.8 |     550.690 ns |      15.00 |    2.602 |  2.000 |   0.1668 |    5 |            * |       No | 5.0049 |      2 KB | 0.0610 |     45 KB |
| BytesToString:01** |    75 | 31,440.8 ns | 273.65 ns | 242.58 ns |  64.83 ns | 31,035.3 ns | 31,248.8 ns | 31,446.7 ns | 31,567.1 ns | 31,834.8 ns |    31,805.8 |     273.651 ns |      14.00 |    1.762 |  2.000 |   0.1831 |    6 |            * |       No | 5.0049 |      2 KB |      - |     45 KB |
| BytesToString:01** |   100 | 29,605.7 ns | 413.26 ns | 386.56 ns |  99.81 ns | 28,862.3 ns | 29,407.2 ns | 29,611.5 ns | 29,894.1 ns | 30,212.4 ns |    33,777.3 |     413.257 ns |      15.00 |    2.016 |  2.000 |  -0.1372 |    5 |            * |       No | 5.0049 |      2 KB | 0.0610 |     45 KB |
| BytesToString:01** |   250 | 30,351.4 ns | 234.89 ns | 219.72 ns |  56.73 ns | 30,047.4 ns | 30,170.8 ns | 30,288.9 ns | 30,536.4 ns | 30,751.8 ns |    32,947.4 |     234.891 ns |      15.00 |    1.625 |  2.000 |   0.2915 |    5 |            * |       No | 5.0049 |      2 KB | 0.0610 |     45 KB |