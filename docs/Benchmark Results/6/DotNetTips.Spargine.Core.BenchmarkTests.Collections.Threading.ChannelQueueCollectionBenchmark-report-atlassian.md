{noformat}

BenchmarkDotNet v0.13.12, Windows 10 (10.0.19045.3930/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.200-preview.23624.5
  [Host]     : .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
  Job-LJBPBB : .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
  Job-GJRVUV : .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2

EvaluateOverhead=True  Server=True  Namespace=DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading  
Categories=Async  

{noformat}
||Method                            ||Runtime  ||Count ||Mean         ||Error       ||StdDev      ||StdErr      ||Min          ||Q1           ||Median       ||Q3           ||Max          ||Op/s      ||CI99.9% Margin ||Iterations ||Kurtosis ||MValue ||Skewness ||Rank ||LogicalGroup ||Baseline ||Code Size ||Allocated ||
| *'Write & Listen Async'*            | *.NET 6.0* | *10*    |  *41,079.0 ns* |   *189.65 ns* |   *168.12 ns* |    *44.93 ns* |  *40,698.7 ns* |  *40,995.6 ns* |  *41,117.2 ns* |  *41,199.1 ns* |  *41,309.2 ns* |  *24,343.4* |     *189.654 ns* |      *14.00* |    *2.613* |  *2.000* |  *-0.7268* |   *35* | ***            | *No*       |   *2,679 B* |   *3.19 KB* |
| 'Write & Listen Async'            | .NET 7.0 | 10    |  39,771.2 ns |   288.40 ns |   269.77 ns |    69.65 ns |  39,228.3 ns |  39,648.3 ns |  39,769.2 ns |  39,932.0 ns |  40,253.7 ns |  25,143.8 |     288.397 ns |      15.00 |    2.338 |  2.000 |  -0.1551 |   34 | *            | No       |   3,600 B |    3.2 KB |
| 'Write & Listen Async'            | .NET 6.0 | 20    |  79,614.3 ns |   426.51 ns |   398.96 ns |   103.01 ns |  79,150.1 ns |  79,321.4 ns |  79,504.0 ns |  79,779.3 ns |  80,351.9 ns |  12,560.6 |     426.509 ns |      15.00 |    2.083 |  2.000 |   0.7196 |   41 | *            | No       |   2,679 B |   4.43 KB |
| 'Write & Listen Async'            | .NET 7.0 | 20    |  78,470.7 ns |   456.53 ns |   427.03 ns |   110.26 ns |  77,959.3 ns |  78,109.0 ns |  78,507.8 ns |  78,816.0 ns |  79,119.7 ns |  12,743.6 |     456.525 ns |      15.00 |    1.424 |  2.000 |   0.2913 |   40 | *            | No       |   3,600 B |   4.44 KB |
| 'Write & Listen Async'            | .NET 6.0 | 25    |  98,163.0 ns |   345.01 ns |   322.72 ns |    83.33 ns |  97,757.7 ns |  97,938.1 ns |  98,063.0 ns |  98,441.2 ns |  98,717.5 ns |  10,187.1 |     345.012 ns |      15.00 |    1.635 |  2.000 |   0.5252 |   44 | *            | No       |   2,679 B |   4.97 KB |
| 'Write & Listen Async'            | .NET 7.0 | 25    |  97,493.2 ns |   507.43 ns |   474.65 ns |   122.55 ns |  96,663.5 ns |  97,178.3 ns |  97,389.9 ns |  97,686.5 ns |  98,351.6 ns |  10,257.1 |     507.430 ns |      15.00 |    2.138 |  2.000 |   0.3100 |   44 | *            | No       |   3,600 B |   5.08 KB |
| 'Write & Listen Async'            | .NET 6.0 | 50    | 194,958.3 ns |   853.21 ns |   798.09 ns |   206.07 ns | 193,561.7 ns | 194,502.7 ns | 194,841.5 ns | 195,559.5 ns | 196,387.9 ns |   5,129.3 |     853.209 ns |      15.00 |    2.025 |  2.000 |   0.2581 |   47 | *            | No       |   2,679 B |   9.48 KB |
| 'Write & Listen Async'            | .NET 7.0 | 50    | 194,398.6 ns |   438.54 ns |   366.20 ns |   101.57 ns | 193,720.3 ns | 194,123.9 ns | 194,479.6 ns | 194,530.7 ns | 195,123.6 ns |   5,144.1 |     438.542 ns |      13.00 |    2.421 |  2.000 |   0.0195 |   47 | *            | No       |   3,600 B |   9.41 KB |
| 'Write & Listen Async'            | .NET 6.0 | 75    | 294,013.8 ns | 2,161.05 ns | 2,021.44 ns |   521.93 ns | 289,824.3 ns | 292,981.5 ns | 293,945.9 ns | 295,560.9 ns | 297,380.7 ns |   3,401.2 |   2,161.046 ns |      15.00 |    2.285 |  2.000 |  -0.1764 |   52 | *            | No       |   2,679 B |  12.56 KB |
| 'Write & Listen Async'            | .NET 7.0 | 75    | 289,123.5 ns | 1,880.38 ns | 1,758.91 ns |   454.15 ns | 286,573.5 ns | 287,664.1 ns | 289,205.6 ns | 290,235.6 ns | 292,231.6 ns |   3,458.7 |   1,880.383 ns |      15.00 |    1.744 |  2.000 |   0.2993 |   51 | *            | No       |   3,600 B |  12.47 KB |
| 'Write & Listen Async'            | .NET 6.0 | 100   | 388,129.1 ns | 1,874.05 ns | 1,661.29 ns |   444.00 ns | 385,785.8 ns | 386,958.9 ns | 387,966.7 ns | 388,458.4 ns | 391,692.2 ns |   2,576.5 |   1,874.046 ns |      14.00 |    2.595 |  2.000 |   0.7357 |   53 | *            | No       |   2,679 B |  17.86 KB |
| 'Write & Listen Async'            | .NET 7.0 | 100   | 387,368.5 ns | 1,863.67 ns | 1,743.28 ns |   450.11 ns | 385,284.8 ns | 385,665.1 ns | 387,303.6 ns | 388,577.0 ns | 390,190.3 ns |   2,581.5 |   1,863.667 ns |      15.00 |    1.551 |  2.000 |   0.2808 |   53 | *            | No       |   3,600 B |  17.91 KB |
| 'Write & Listen Async'            | .NET 6.0 | 250   | 955,245.8 ns | 5,399.39 ns | 4,786.42 ns | 1,279.22 ns | 948,943.3 ns | 952,278.2 ns | 954,127.0 ns | 957,011.1 ns | 966,286.1 ns |   1,046.9 |   5,399.387 ns |      14.00 |    2.810 |  2.000 |   0.8657 |   54 | *            | No       |   2,679 B |  40.94 KB |
| 'Write & Listen Async'            | .NET 7.0 | 250   | 965,266.9 ns | 4,369.47 ns | 3,873.42 ns | 1,035.21 ns | 957,662.3 ns | 963,121.4 ns | 964,872.8 ns | 968,095.4 ns | 972,580.7 ns |   1,036.0 |   4,369.465 ns |      14.00 |    2.315 |  2.000 |   0.0178 |   54 | *            | No       |   3,600 B |  40.93 KB |
| *'Write & Read Async: IEnumerable'* | *.NET 6.0* | *10*    |  *14,026.2 ns* |    *32.97 ns* |    *30.84 ns* |     *7.96 ns* |  *13,966.6 ns* |  *14,009.9 ns* |  *14,024.0 ns* |  *14,048.9 ns* |  *14,079.6 ns* |  *71,294.9* |      *32.970 ns* |      *15.00* |    *2.155* |  *2.000* |   *0.0184* |   *25* | ***            | *No*       |     *509 B* |   *5.18 KB* |
| 'Write & Read Async: IEnumerable' | .NET 7.0 | 10    |   9,849.8 ns |    34.71 ns |    30.77 ns |     8.22 ns |   9,777.1 ns |   9,841.0 ns |   9,849.6 ns |   9,868.2 ns |   9,906.6 ns | 101,525.3 |      34.709 ns |      14.00 |    3.295 |  2.000 |  -0.5411 |   23 | *            | No       |     513 B |   5.14 KB |
| 'Write & Read Async: IEnumerable' | .NET 6.0 | 20    |  24,804.0 ns |    32.09 ns |    30.01 ns |     7.75 ns |  24,741.7 ns |  24,793.3 ns |  24,804.3 ns |  24,821.0 ns |  24,855.2 ns |  40,316.0 |      32.088 ns |      15.00 |    2.619 |  2.000 |  -0.4374 |   31 | *            | No       |     509 B |   8.77 KB |
| 'Write & Read Async: IEnumerable' | .NET 7.0 | 20    |  19,260.4 ns |    55.75 ns |    52.15 ns |    13.47 ns |  19,167.2 ns |  19,223.8 ns |  19,265.6 ns |  19,290.3 ns |  19,348.3 ns |  51,919.9 |      55.753 ns |      15.00 |    1.959 |  2.000 |  -0.1587 |   28 | *            | No       |     513 B |   8.77 KB |
| 'Write & Read Async: IEnumerable' | .NET 6.0 | 25    |  29,317.8 ns |    40.66 ns |    36.04 ns |     9.63 ns |  29,261.2 ns |  29,302.4 ns |  29,310.7 ns |  29,337.1 ns |  29,384.9 ns |  34,109.0 |      40.655 ns |      14.00 |    2.162 |  2.000 |   0.3786 |   32 | *            | No       |     509 B |  10.57 KB |
| 'Write & Read Async: IEnumerable' | .NET 7.0 | 25    |  22,667.8 ns |    91.83 ns |    85.90 ns |    22.18 ns |  22,524.4 ns |  22,602.7 ns |  22,676.2 ns |  22,744.8 ns |  22,780.2 ns |  44,115.4 |      91.834 ns |      15.00 |    1.519 |  2.000 |  -0.1814 |   30 | *            | No       |     513 B |  10.57 KB |
| 'Write & Read Async: IEnumerable' | .NET 6.0 | 50    |  55,849.0 ns |   375.28 ns |   351.04 ns |    90.64 ns |  55,156.3 ns |  55,937.7 ns |  56,014.6 ns |  56,037.5 ns |  56,104.9 ns |  17,905.4 |     375.285 ns |      15.00 |    2.763 |  2.000 |  -1.2950 |   37 | *            | No       |     509 B |  20.79 KB |
| 'Write & Read Async: IEnumerable' | .NET 7.0 | 50    |  42,488.1 ns |   100.06 ns |    93.60 ns |    24.17 ns |  42,271.4 ns |  42,450.3 ns |  42,497.3 ns |  42,538.5 ns |  42,613.8 ns |  23,536.0 |     100.064 ns |      15.00 |    2.753 |  2.000 |  -0.7442 |   36 | *            | No       |     513 B |  20.77 KB |
| 'Write & Read Async: IEnumerable' | .NET 6.0 | 75    |  81,315.3 ns |   551.00 ns |   515.40 ns |   133.08 ns |  80,043.0 ns |  81,348.4 ns |  81,486.4 ns |  81,612.2 ns |  81,704.8 ns |  12,297.8 |     550.995 ns |      15.00 |    4.139 |  2.000 |  -1.6143 |   42 | *            | No       |     509 B |  29.74 KB |
| 'Write & Read Async: IEnumerable' | .NET 7.0 | 75    |  59,759.4 ns |   133.47 ns |   118.32 ns |    31.62 ns |  59,557.0 ns |  59,699.5 ns |  59,763.5 ns |  59,823.0 ns |  59,936.7 ns |  16,733.8 |     133.472 ns |      14.00 |    1.857 |  2.000 |  -0.3370 |   38 | *            | No       |     513 B |  29.74 KB |
| 'Write & Read Async: IEnumerable' | .NET 6.0 | 100   | 109,824.5 ns |   141.43 ns |   132.30 ns |    34.16 ns | 109,553.2 ns | 109,741.8 ns | 109,856.9 ns | 109,911.8 ns | 110,026.9 ns |   9,105.4 |     141.435 ns |      15.00 |    2.147 |  2.000 |  -0.5817 |   45 | *            | No       |     509 B |  40.96 KB |
| 'Write & Read Async: IEnumerable' | .NET 7.0 | 100   |  81,551.5 ns |   274.89 ns |   257.13 ns |    66.39 ns |  80,847.1 ns |  81,406.4 ns |  81,597.0 ns |  81,708.6 ns |  81,878.1 ns |  12,262.2 |     274.892 ns |      15.00 |    4.178 |  2.000 |  -1.1138 |   42 | *            | No       |     513 B |  40.92 KB |
| 'Write & Read Async: IEnumerable' | .NET 6.0 | 250   | 273,103.8 ns |   326.90 ns |   289.78 ns |    77.45 ns | 272,535.8 ns | 272,965.5 ns | 273,090.3 ns | 273,245.3 ns | 273,594.5 ns |   3,661.6 |     326.896 ns |      14.00 |    2.406 |  2.000 |  -0.0750 |   49 | *            | No       |     509 B |     99 KB |
| 'Write & Read Async: IEnumerable' | .NET 7.0 | 250   | 199,520.6 ns |   853.69 ns |   798.54 ns |   206.18 ns | 197,600.9 ns | 199,174.0 ns | 199,661.0 ns | 200,141.5 ns | 200,437.0 ns |   5,012.0 |     853.685 ns |      15.00 |    3.020 |  2.000 |  -0.9652 |   48 | *            | No       |     513 B |  98.92 KB |
| *'Write & Read Async'*              | *.NET 6.0* | *10*    |  *13,601.0 ns* |    *19.92 ns* |    *16.64 ns* |     *4.61 ns* |  *13,579.3 ns* |  *13,587.8 ns* |  *13,596.1 ns* |  *13,611.7 ns* |  *13,638.2 ns* |  *73,524.0* |      *19.925 ns* |      *13.00* |    *2.477* |  *2.000* |   *0.5595* |   *24* | ***            | *No*       |     *510 B* |   *5.14 KB* |
| 'Write & Read Async'              | .NET 7.0 | 10    |   9,615.4 ns |    62.26 ns |    58.24 ns |    15.04 ns |   9,499.0 ns |   9,577.9 ns |   9,620.2 ns |   9,657.0 ns |   9,714.7 ns | 104,000.2 |      62.259 ns |      15.00 |    2.114 |  2.000 |  -0.1933 |   22 | *            | No       |     514 B |    5.1 KB |
| 'Write & Read Async'              | .NET 6.0 | 20    |  24,839.6 ns |    24.93 ns |    23.32 ns |     6.02 ns |  24,801.3 ns |  24,822.0 ns |  24,834.3 ns |  24,858.6 ns |  24,881.8 ns |  40,258.2 |      24.926 ns |      15.00 |    1.738 |  2.000 |   0.2122 |   31 | *            | No       |     510 B |   8.73 KB |
| 'Write & Read Async'              | .NET 7.0 | 20    |  19,037.1 ns |    87.08 ns |    81.45 ns |    21.03 ns |  18,859.0 ns |  18,992.1 ns |  19,049.3 ns |  19,091.3 ns |  19,144.5 ns |  52,529.1 |      87.080 ns |      15.00 |    2.263 |  2.000 |  -0.4715 |   28 | *            | No       |     514 B |   8.73 KB |
| 'Write & Read Async'              | .NET 6.0 | 25    |  29,883.9 ns |    38.00 ns |    35.55 ns |     9.18 ns |  29,829.5 ns |  29,858.7 ns |  29,885.9 ns |  29,909.3 ns |  29,962.1 ns |  33,462.8 |      38.002 ns |      15.00 |    2.305 |  2.000 |   0.3559 |   33 | *            | No       |     510 B |  10.53 KB |
| 'Write & Read Async'              | .NET 7.0 | 25    |  22,707.2 ns |    58.03 ns |    54.29 ns |    14.02 ns |  22,619.6 ns |  22,683.3 ns |  22,703.8 ns |  22,750.3 ns |  22,789.5 ns |  44,038.8 |      58.034 ns |      15.00 |    1.822 |  2.000 |  -0.3667 |   30 | *            | No       |     514 B |  10.53 KB |
| 'Write & Read Async'              | .NET 6.0 | 50    |  55,875.5 ns |    39.89 ns |    37.32 ns |     9.64 ns |  55,813.9 ns |  55,847.0 ns |  55,866.9 ns |  55,902.8 ns |  55,945.3 ns |  17,896.9 |      39.893 ns |      15.00 |    1.895 |  2.000 |   0.2396 |   37 | *            | No       |     510 B |  20.75 KB |
| 'Write & Read Async'              | .NET 7.0 | 50    |  42,086.4 ns |   108.48 ns |    96.16 ns |    25.70 ns |  41,918.7 ns |  42,008.2 ns |  42,111.3 ns |  42,156.3 ns |  42,228.1 ns |  23,760.6 |     108.476 ns |      14.00 |    1.772 |  2.000 |  -0.4733 |   36 | *            | No       |     514 B |  20.74 KB |
| 'Write & Read Async'              | .NET 6.0 | 75    |  85,059.0 ns |   127.58 ns |   113.10 ns |    30.23 ns |  84,853.5 ns |  85,004.2 ns |  85,049.0 ns |  85,118.0 ns |  85,303.0 ns |  11,756.5 |     127.583 ns |      14.00 |    2.667 |  2.000 |   0.3227 |   43 | *            | No       |     510 B |  29.69 KB |
| 'Write & Read Async'              | .NET 7.0 | 75    |  63,735.4 ns |   244.59 ns |   228.79 ns |    59.07 ns |  63,376.0 ns |  63,553.4 ns |  63,801.8 ns |  63,904.0 ns |  64,127.2 ns |  15,689.9 |     244.588 ns |      15.00 |    1.600 |  2.000 |  -0.0478 |   39 | *            | No       |     514 B |  29.68 KB |
| 'Write & Read Async'              | .NET 6.0 | 100   | 114,285.4 ns |   770.87 ns |   721.07 ns |   186.18 ns | 113,683.5 ns | 113,871.6 ns | 113,919.9 ns | 114,669.1 ns | 115,520.0 ns |   8,750.0 |     770.872 ns |      15.00 |    1.862 |  2.000 |   0.9256 |   46 | *            | No       |     510 B |  40.91 KB |
| 'Write & Read Async'              | .NET 7.0 | 100   |  81,701.2 ns |   375.20 ns |   350.96 ns |    90.62 ns |  81,038.0 ns |  81,525.5 ns |  81,771.6 ns |  81,897.7 ns |  82,321.1 ns |  12,239.7 |     375.201 ns |      15.00 |    2.486 |  2.000 |  -0.4338 |   42 | *            | No       |     514 B |  40.86 KB |
| 'Write & Read Async'              | .NET 6.0 | 250   | 277,028.0 ns |   325.27 ns |   304.26 ns |    78.56 ns | 276,642.7 ns | 276,768.7 ns | 276,980.1 ns | 277,262.0 ns | 277,683.3 ns |   3,609.7 |     325.271 ns |      15.00 |    2.049 |  2.000 |   0.4808 |   50 | *            | No       |     510 B |  99.02 KB |
| 'Write & Read Async'              | .NET 7.0 | 250   | 197,230.1 ns |   521.14 ns |   487.47 ns |   125.87 ns | 196,645.1 ns | 196,902.9 ns | 197,157.5 ns | 197,546.7 ns | 198,295.7 ns |   5,070.2 |     521.138 ns |      15.00 |    2.414 |  2.000 |   0.7330 |   47 | *            | No       |     514 B |  98.82 KB |
| *'WriteAsync: IEnumerable'*         | *.NET 6.0* | *10*    |   *1,696.2 ns* |    *13.65 ns* |    *12.77 ns* |     *3.30 ns* |   *1,678.0 ns* |   *1,686.9 ns* |   *1,695.2 ns* |   *1,708.1 ns* |   *1,715.4 ns* | *589,536.6* |      *13.653 ns* |      *15.00* |    *1.478* |  *2.000* |   *0.1573* |    *1* | ***            | *No*       |     *503 B* |    *1.8 KB* |
| 'WriteAsync: IEnumerable'         | .NET 7.0 | 10    |   1,774.0 ns |     6.63 ns |     6.20 ns |     1.60 ns |   1,763.7 ns |   1,769.8 ns |   1,774.5 ns |   1,777.1 ns |   1,786.6 ns | 563,711.1 |       6.627 ns |      15.00 |    2.317 |  2.000 |   0.1516 |    2 | *            | No       |     507 B |    1.8 KB |
| 'WriteAsync: IEnumerable'         | .NET 6.0 | 20    |   2,174.2 ns |     7.02 ns |     6.57 ns |     1.70 ns |   2,162.1 ns |   2,169.4 ns |   2,173.2 ns |   2,179.0 ns |   2,187.2 ns | 459,949.0 |       7.022 ns |      15.00 |    2.166 |  2.000 |   0.1048 |    4 | *            | No       |     503 B |    1.8 KB |
| 'WriteAsync: IEnumerable'         | .NET 7.0 | 20    |   2,250.9 ns |    11.19 ns |    10.47 ns |     2.70 ns |   2,235.1 ns |   2,242.4 ns |   2,252.0 ns |   2,257.4 ns |   2,271.4 ns | 444,265.5 |      11.193 ns |      15.00 |    1.986 |  2.000 |   0.0775 |    5 | *            | No       |     507 B |    1.8 KB |
| 'WriteAsync: IEnumerable'         | .NET 6.0 | 25    |   2,413.0 ns |     8.36 ns |     7.82 ns |     2.02 ns |   2,399.2 ns |   2,408.5 ns |   2,412.8 ns |   2,418.0 ns |   2,429.2 ns | 414,426.4 |       8.363 ns |      15.00 |    2.378 |  2.000 |   0.0550 |    7 | *            | No       |     503 B |    1.8 KB |
| 'WriteAsync: IEnumerable'         | .NET 7.0 | 25    |   2,460.5 ns |    16.60 ns |    15.53 ns |     4.01 ns |   2,437.2 ns |   2,451.1 ns |   2,456.9 ns |   2,471.9 ns |   2,484.5 ns | 406,423.5 |      16.603 ns |      15.00 |    1.653 |  2.000 |   0.1557 |    8 | *            | No       |     507 B |    1.8 KB |
| 'WriteAsync: IEnumerable'         | .NET 6.0 | 50    |   3,735.7 ns |    12.56 ns |    11.75 ns |     3.03 ns |   3,710.7 ns |   3,729.3 ns |   3,735.9 ns |   3,744.7 ns |   3,754.5 ns | 267,689.2 |      12.564 ns |      15.00 |    2.328 |  2.000 |  -0.2520 |   11 | *            | No       |     503 B |   3.05 KB |
| 'WriteAsync: IEnumerable'         | .NET 7.0 | 50    |   3,768.6 ns |    16.35 ns |    15.29 ns |     3.95 ns |   3,745.0 ns |   3,760.9 ns |   3,764.5 ns |   3,784.1 ns |   3,791.9 ns | 265,347.8 |      16.349 ns |      15.00 |    1.555 |  2.000 |   0.0378 |   11 | *            | No       |     507 B |   3.05 KB |
| 'WriteAsync: IEnumerable'         | .NET 6.0 | 75    |   4,825.2 ns |    13.37 ns |    12.51 ns |     3.23 ns |   4,804.6 ns |   4,815.0 ns |   4,828.3 ns |   4,834.3 ns |   4,844.8 ns | 207,247.1 |      13.371 ns |      15.00 |    1.577 |  2.000 |  -0.1420 |   14 | *            | No       |     503 B |   3.05 KB |
| 'WriteAsync: IEnumerable'         | .NET 7.0 | 75    |   4,902.4 ns |    13.77 ns |    12.21 ns |     3.26 ns |   4,886.9 ns |   4,894.0 ns |   4,898.6 ns |   4,909.5 ns |   4,930.8 ns | 203,980.6 |      13.771 ns |      14.00 |    2.743 |  2.000 |   0.8806 |   15 | *            | No       |     507 B |   3.05 KB |
| 'WriteAsync: IEnumerable'         | .NET 6.0 | 100   |   6,304.1 ns |    31.74 ns |    29.69 ns |     7.67 ns |   6,235.6 ns |   6,302.7 ns |   6,306.5 ns |   6,320.1 ns |   6,342.3 ns | 158,627.3 |      31.741 ns |      15.00 |    3.058 |  2.000 |  -1.0446 |   18 | *            | No       |     503 B |    5.3 KB |
| 'WriteAsync: IEnumerable'         | .NET 7.0 | 100   |   6,424.2 ns |    33.78 ns |    31.60 ns |     8.16 ns |   6,361.9 ns |   6,404.2 ns |   6,424.7 ns |   6,451.6 ns |   6,464.9 ns | 155,661.5 |      33.784 ns |      15.00 |    1.813 |  2.000 |  -0.2642 |   19 | *            | No       |     507 B |    5.3 KB |
| 'WriteAsync: IEnumerable'         | .NET 6.0 | 250   |  14,635.3 ns |    76.30 ns |    71.37 ns |    18.43 ns |  14,525.1 ns |  14,599.0 ns |  14,611.1 ns |  14,680.5 ns |  14,779.1 ns |  68,328.0 |      76.300 ns |      15.00 |    2.267 |  2.000 |   0.4137 |   26 | *            | No       |     503 B |   9.55 KB |
| 'WriteAsync: IEnumerable'         | .NET 7.0 | 250   |  15,802.4 ns |   172.30 ns |   161.17 ns |    41.61 ns |  15,529.3 ns |  15,670.2 ns |  15,788.2 ns |  15,943.2 ns |  16,056.5 ns |  63,281.5 |     172.299 ns |      15.00 |    1.637 |  2.000 |  -0.0212 |   27 | *            | No       |     507 B |   9.55 KB |
| *WriteAsync*                        | *.NET 6.0* | *10*    |   *1,825.7 ns* |     *5.87 ns* |     *5.49 ns* |     *1.42 ns* |   *1,813.6 ns* |   *1,822.2 ns* |   *1,825.6 ns* |   *1,829.4 ns* |   *1,834.2 ns* | *547,730.9* |       *5.866 ns* |      *15.00* |    *2.428* |  *2.000* |  *-0.3188* |    *3* | ***            | *No*       |     *504 B* |   *1.76 KB* |
| WriteAsync                        | .NET 7.0 | 10    |   1,810.2 ns |     7.19 ns |     6.73 ns |     1.74 ns |   1,796.8 ns |   1,807.4 ns |   1,809.2 ns |   1,815.3 ns |   1,822.8 ns | 552,411.1 |       7.195 ns |      15.00 |    2.348 |  2.000 |   0.0202 |    3 | *            | No       |     508 B |   1.76 KB |
| WriteAsync                        | .NET 6.0 | 20    |   2,443.7 ns |     4.52 ns |     4.01 ns |     1.07 ns |   2,435.5 ns |   2,440.9 ns |   2,444.3 ns |   2,446.5 ns |   2,449.6 ns | 409,211.8 |       4.522 ns |      14.00 |    2.091 |  2.000 |  -0.3979 |    8 | *            | No       |     504 B |   1.76 KB |
| WriteAsync                        | .NET 7.0 | 20    |   2,312.0 ns |     9.15 ns |     8.56 ns |     2.21 ns |   2,294.4 ns |   2,310.6 ns |   2,313.8 ns |   2,316.0 ns |   2,322.9 ns | 432,526.6 |       9.146 ns |      15.00 |    2.585 |  2.000 |  -0.7921 |    6 | *            | No       |     508 B |   1.76 KB |
| WriteAsync                        | .NET 6.0 | 25    |   2,750.7 ns |     6.83 ns |     6.39 ns |     1.65 ns |   2,739.6 ns |   2,746.4 ns |   2,751.0 ns |   2,756.3 ns |   2,760.4 ns | 363,549.7 |       6.832 ns |      15.00 |    1.712 |  2.000 |  -0.1979 |   10 | *            | No       |     504 B |   1.76 KB |
| WriteAsync                        | .NET 7.0 | 25    |   2,561.1 ns |    14.67 ns |    13.73 ns |     3.54 ns |   2,539.0 ns |   2,554.0 ns |   2,559.4 ns |   2,569.9 ns |   2,587.9 ns | 390,453.0 |      14.674 ns |      15.00 |    2.210 |  2.000 |   0.3325 |    9 | *            | No       |     508 B |   1.76 KB |
| WriteAsync                        | .NET 6.0 | 50    |   4,510.3 ns |    18.89 ns |    17.67 ns |     4.56 ns |   4,481.6 ns |   4,500.5 ns |   4,507.2 ns |   4,521.9 ns |   4,548.3 ns | 221,712.7 |      18.892 ns |      15.00 |    2.486 |  2.000 |   0.2163 |   13 | *            | No       |     504 B |   3.01 KB |
| WriteAsync                        | .NET 7.0 | 50    |   4,084.9 ns |    24.13 ns |    21.39 ns |     5.72 ns |   4,056.3 ns |   4,068.4 ns |   4,083.4 ns |   4,102.2 ns |   4,117.7 ns | 244,805.4 |      24.134 ns |      14.00 |    1.561 |  2.000 |   0.1788 |   12 | *            | No       |     508 B |   3.01 KB |
| WriteAsync                        | .NET 6.0 | 75    |   6,002.3 ns |    17.78 ns |    15.76 ns |     4.21 ns |   5,971.7 ns |   5,992.2 ns |   6,006.8 ns |   6,014.7 ns |   6,021.6 ns | 166,601.5 |      17.779 ns |      14.00 |    1.900 |  2.000 |  -0.6337 |   17 | *            | No       |     504 B |   3.01 KB |
| WriteAsync                        | .NET 7.0 | 75    |   5,390.3 ns |    21.28 ns |    19.91 ns |     5.14 ns |   5,355.2 ns |   5,379.5 ns |   5,392.0 ns |   5,401.0 ns |   5,428.8 ns | 185,519.1 |      21.284 ns |      15.00 |    2.237 |  2.000 |   0.0162 |   16 | *            | No       |     508 B |   3.01 KB |
| WriteAsync                        | .NET 6.0 | 100   |   8,173.1 ns |    58.88 ns |    55.07 ns |    14.22 ns |   8,068.5 ns |   8,130.9 ns |   8,172.2 ns |   8,231.3 ns |   8,248.4 ns | 122,351.9 |      58.877 ns |      15.00 |    1.732 |  2.000 |  -0.1923 |   21 | *            | No       |     504 B |   5.26 KB |
| WriteAsync                        | .NET 7.0 | 100   |   7,142.8 ns |    41.60 ns |    38.91 ns |    10.05 ns |   7,090.3 ns |   7,110.8 ns |   7,149.8 ns |   7,164.8 ns |   7,221.8 ns | 140,001.5 |      41.596 ns |      15.00 |    1.945 |  2.000 |   0.2775 |   20 | *            | No       |     508 B |   5.26 KB |
| WriteAsync                        | .NET 6.0 | 250   |  21,088.0 ns |   167.73 ns |   156.90 ns |    40.51 ns |  20,882.4 ns |  20,955.2 ns |  21,044.7 ns |  21,177.2 ns |  21,434.2 ns |  47,420.3 |     167.731 ns |      15.00 |    2.306 |  2.000 |   0.6193 |   29 | *            | No       |     504 B |   9.51 KB |
| WriteAsync                        | .NET 7.0 | 250   |  19,481.1 ns |   110.16 ns |   103.05 ns |    26.61 ns |  19,305.1 ns |  19,409.3 ns |  19,508.2 ns |  19,542.1 ns |  19,674.7 ns |  51,331.8 |     110.164 ns |      15.00 |    2.027 |  2.000 |  -0.1397 |   28 | *            | No       |     508 B |   9.51 KB |