
    BenchmarkDotNet v0.13.6, Windows 10 (10.0.19045.3208/22H2/2022Update)
    Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
    .NET SDK 8.0.100-preview.6.23330.14
      [Host]     : .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
      Job-TPLMSH : .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
      Job-KEOQYR : .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2

    EvaluateOverhead=True  Server=True  Namespace=DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading  
    Categories=Async  

                                Method |  Runtime | Count |           Mean |       Error |      StdDev |    StdErr |            Min |             Q1 |         Median |             Q3 |            Max |      Op/s | CI99.9% Margin | Iterations | Kurtosis | MValue | Skewness | Rank | LogicalGroup | Baseline | Code Size | Allocated |
    ---------------------------------- |--------- |------ |---------------:|------------:|------------:|----------:|---------------:|---------------:|---------------:|---------------:|---------------:|----------:|---------------:|-----------:|---------:|-------:|---------:|-----:|------------- |--------- |----------:|----------:|
                **'Write & Listen Async'** | **.NET 6.0** |    **10** |    **43,505.4 ns** |   **102.82 ns** |    **91.15 ns** |  **24.36 ns** |    **43,350.7 ns** |    **43,442.8 ns** |    **43,516.9 ns** |    **43,546.5 ns** |    **43,705.6 ns** |  **22,985.7** |     **102.819 ns** |      **14.00** |    **2.670** |  **2.000** |   **0.2523** |   **38** |            ***** |       **No** |   **2,679 B** |   **3.19 KB** |
                'Write & Listen Async' | .NET 7.0 |    10 |    43,061.3 ns |   135.53 ns |   126.78 ns |  32.73 ns |    42,856.6 ns |    42,990.2 ns |    43,034.3 ns |    43,144.3 ns |    43,263.5 ns |  23,222.7 |     135.531 ns |      15.00 |    1.737 |  2.000 |   0.1684 |   38 |            * |       No |   3,600 B |   3.21 KB |
                'Write & Listen Async' | .NET 6.0 |    20 |    83,989.9 ns |   417.31 ns |   390.35 ns | 100.79 ns |    83,369.6 ns |    83,699.1 ns |    83,912.4 ns |    84,249.1 ns |    84,691.3 ns |  11,906.2 |     417.308 ns |      15.00 |    1.896 |  2.000 |   0.2524 |   43 |            * |       No |   2,679 B |   4.39 KB |
                'Write & Listen Async' | .NET 7.0 |    20 |    84,957.3 ns |   383.38 ns |   358.62 ns |  92.59 ns |    84,375.3 ns |    84,734.7 ns |    84,858.0 ns |    85,238.0 ns |    85,520.8 ns |  11,770.6 |     383.382 ns |      15.00 |    1.734 |  2.000 |   0.0473 |   43 |            * |       No |   3,600 B |   4.43 KB |
                'Write & Listen Async' | .NET 6.0 |    25 |   105,288.2 ns |   297.83 ns |   278.59 ns |  71.93 ns |   104,805.6 ns |   105,168.1 ns |   105,261.5 ns |   105,488.5 ns |   105,859.3 ns |   9,497.7 |     297.827 ns |      15.00 |    2.309 |  2.000 |   0.1079 |   44 |            * |       No |   2,679 B |   5.06 KB |
                'Write & Listen Async' | .NET 7.0 |    25 |   104,710.9 ns |   361.23 ns |   337.90 ns |  87.25 ns |   104,028.0 ns |   104,534.1 ns |   104,787.7 ns |   104,939.1 ns |   105,182.7 ns |   9,550.1 |     361.235 ns |      15.00 |    2.096 |  2.000 |  -0.5592 |   44 |            * |       No |   3,600 B |   5.08 KB |
                'Write & Listen Async' | .NET 6.0 |    50 |   209,864.2 ns |   755.66 ns |   631.01 ns | 175.01 ns |   208,428.5 ns |   209,763.4 ns |   210,134.6 ns |   210,228.6 ns |   210,600.0 ns |   4,765.0 |     755.658 ns |      13.00 |    2.868 |  2.000 |  -1.0595 |   49 |            * |       No |   2,679 B |   9.36 KB |
                'Write & Listen Async' | .NET 7.0 |    50 |   210,101.3 ns | 1,143.61 ns | 1,069.73 ns | 276.20 ns |   208,415.6 ns |   209,262.9 ns |   209,829.7 ns |   211,148.0 ns |   211,528.0 ns |   4,759.6 |   1,143.608 ns |      15.00 |    1.369 |  2.000 |  -0.0910 |   49 |            * |       No |   3,600 B |   9.41 KB |
                'Write & Listen Async' | .NET 6.0 |    75 |   313,528.4 ns |   799.26 ns |   747.62 ns | 193.04 ns |   312,430.9 ns |   313,056.4 ns |   313,373.9 ns |   313,904.5 ns |   315,025.6 ns |   3,189.5 |     799.255 ns |      15.00 |    2.119 |  2.000 |   0.4928 |   52 |            * |       No |   2,679 B |  12.47 KB |
                'Write & Listen Async' | .NET 7.0 |    75 |   313,241.1 ns | 1,445.55 ns | 1,352.17 ns | 349.13 ns |   310,043.1 ns |   312,800.1 ns |   313,291.8 ns |   314,238.1 ns |   314,979.3 ns |   3,192.4 |   1,445.550 ns |      15.00 |    2.974 |  2.000 |  -0.8805 |   52 |            * |       No |   3,600 B |  12.58 KB |
                'Write & Listen Async' | .NET 6.0 |   100 |   414,483.8 ns |   807.12 ns |   673.98 ns | 186.93 ns |   412,782.3 ns |   414,137.5 ns |   414,651.6 ns |   414,873.7 ns |   415,513.8 ns |   2,412.6 |     807.120 ns |      13.00 |    3.664 |  2.000 |  -0.9612 |   53 |            * |       No |   2,679 B |  17.93 KB |
                'Write & Listen Async' | .NET 7.0 |   100 |   413,490.8 ns |   769.01 ns |   681.71 ns | 182.19 ns |   412,015.9 ns |   413,069.5 ns |   413,556.6 ns |   413,826.7 ns |   414,905.6 ns |   2,418.4 |     769.014 ns |      14.00 |    3.076 |  2.000 |  -0.1466 |   53 |            * |       No |   3,600 B |  18.02 KB |
                'Write & Listen Async' | .NET 6.0 |   250 | 1,040,145.2 ns | 3,783.85 ns | 3,539.41 ns | 913.87 ns | 1,033,050.9 ns | 1,038,105.1 ns | 1,040,556.0 ns | 1,041,965.2 ns | 1,046,798.5 ns |     961.4 |   3,783.849 ns |      15.00 |    2.586 |  2.000 |   0.1336 |   55 |            * |       No |   2,679 B |  40.61 KB |
                'Write & Listen Async' | .NET 7.0 |   250 | 1,026,716.5 ns | 3,321.57 ns | 2,773.66 ns | 769.28 ns | 1,022,563.4 ns | 1,024,597.6 ns | 1,025,990.9 ns | 1,027,970.0 ns | 1,032,925.7 ns |     974.0 |   3,321.571 ns |      13.00 |    2.730 |  2.000 |   0.7024 |   54 |            * |       No |   3,600 B |  40.99 KB |
     **'Write & Read Async: IEnumerable'** | **.NET 6.0** |    **10** |    **14,101.6 ns** |    **30.82 ns** |    **24.07 ns** |   **6.95 ns** |    **14,037.8 ns** |    **14,101.7 ns** |    **14,105.8 ns** |    **14,112.3 ns** |    **14,130.0 ns** |  **70,914.0** |      **30.824 ns** |      **12.00** |    **4.437** |  **2.000** |  **-1.4083** |   **26** |            ***** |       **No** |     **509 B** |   **5.18 KB** |
     'Write & Read Async: IEnumerable' | .NET 7.0 |    10 |     9,333.4 ns |    40.02 ns |    37.43 ns |   9.66 ns |     9,264.9 ns |     9,304.1 ns |     9,351.0 ns |     9,362.4 ns |     9,380.0 ns | 107,141.7 |      40.016 ns |      15.00 |    1.545 |  2.000 |  -0.4066 |   25 |            * |       No |     513 B |   5.14 KB |
     'Write & Read Async: IEnumerable' | .NET 6.0 |    20 |    24,411.1 ns |    62.66 ns |    52.33 ns |  14.51 ns |    24,316.7 ns |    24,403.4 ns |    24,422.3 ns |    24,439.4 ns |    24,490.1 ns |  40,964.9 |      62.662 ns |      13.00 |    2.031 |  2.000 |  -0.5258 |   34 |            * |       No |     509 B |   8.77 KB |
     'Write & Read Async: IEnumerable' | .NET 7.0 |    20 |    19,305.9 ns |    35.56 ns |    33.26 ns |   8.59 ns |    19,241.5 ns |    19,288.2 ns |    19,308.0 ns |    19,330.3 ns |    19,353.3 ns |  51,797.6 |      35.556 ns |      15.00 |    1.981 |  2.000 |  -0.4138 |   30 |            * |       No |     513 B |   8.77 KB |
     'Write & Read Async: IEnumerable' | .NET 6.0 |    25 |    29,842.9 ns |    45.16 ns |    40.03 ns |  10.70 ns |    29,777.6 ns |    29,822.5 ns |    29,839.5 ns |    29,858.0 ns |    29,935.0 ns |  33,508.9 |      45.157 ns |      14.00 |    2.853 |  2.000 |   0.5637 |   35 |            * |       No |     509 B |  10.57 KB |
     'Write & Read Async: IEnumerable' | .NET 7.0 |    25 |    23,007.5 ns |    54.31 ns |    50.80 ns |  13.12 ns |    22,877.2 ns |    22,974.8 ns |    23,019.1 ns |    23,037.0 ns |    23,077.3 ns |  43,464.0 |      54.313 ns |      15.00 |    3.423 |  2.000 |  -0.8364 |   33 |            * |       No |     513 B |  10.57 KB |
     'Write & Read Async: IEnumerable' | .NET 6.0 |    50 |    56,524.0 ns |    55.76 ns |    49.43 ns |  13.21 ns |    56,415.1 ns |    56,507.8 ns |    56,519.2 ns |    56,552.9 ns |    56,617.3 ns |  17,691.6 |      55.761 ns |      14.00 |    2.845 |  2.000 |  -0.2729 |   39 |            * |       No |     509 B |  20.79 KB |
     'Write & Read Async: IEnumerable' | .NET 7.0 |    50 |    40,827.8 ns |   148.85 ns |   139.23 ns |  35.95 ns |    40,654.6 ns |    40,720.5 ns |    40,792.3 ns |    40,924.6 ns |    41,068.4 ns |  24,493.1 |     148.846 ns |      15.00 |    1.738 |  2.000 |   0.4878 |   37 |            * |       No |     513 B |  20.78 KB |
     'Write & Read Async: IEnumerable' | .NET 6.0 |    75 |    82,962.2 ns |   132.30 ns |   117.28 ns |  31.34 ns |    82,774.3 ns |    82,901.1 ns |    82,956.0 ns |    83,032.3 ns |    83,145.4 ns |  12,053.7 |     132.301 ns |      14.00 |    1.710 |  2.000 |  -0.0851 |   43 |            * |       No |     509 B |  29.75 KB |
     'Write & Read Async: IEnumerable' | .NET 7.0 |    75 |    60,231.0 ns |   229.37 ns |   203.33 ns |  54.34 ns |    59,784.6 ns |    60,212.9 ns |    60,262.4 ns |    60,357.3 ns |    60,557.1 ns |  16,602.7 |     229.368 ns |      14.00 |    2.883 |  2.000 |  -0.7753 |   42 |            * |       No |     513 B |  29.74 KB |
     'Write & Read Async: IEnumerable' | .NET 6.0 |   100 |   111,055.8 ns |   155.50 ns |   145.45 ns |  37.56 ns |   110,852.0 ns |   110,933.1 ns |   111,075.1 ns |   111,178.3 ns |   111,260.7 ns |   9,004.5 |     155.496 ns |      15.00 |    1.230 |  2.000 |   0.0052 |   45 |            * |       No |     509 B |  40.95 KB |
     'Write & Read Async: IEnumerable' | .NET 7.0 |   100 |    82,618.0 ns |   354.07 ns |   331.20 ns |  85.51 ns |    82,061.2 ns |    82,406.8 ns |    82,586.2 ns |    82,819.5 ns |    83,158.5 ns |  12,103.9 |     354.071 ns |      15.00 |    1.805 |  2.000 |   0.0131 |   43 |            * |       No |     513 B |  40.96 KB |
     'Write & Read Async: IEnumerable' | .NET 6.0 |   250 |   273,444.6 ns |   343.75 ns |   321.54 ns |  83.02 ns |   272,952.0 ns |   273,194.6 ns |   273,492.2 ns |   273,580.0 ns |   274,033.0 ns |   3,657.0 |     343.749 ns |      15.00 |    1.961 |  2.000 |   0.1238 |   50 |            * |       No |     509 B |  99.03 KB |
     'Write & Read Async: IEnumerable' | .NET 7.0 |   250 |   197,888.4 ns |   671.25 ns |   627.88 ns | 162.12 ns |   196,428.5 ns |   197,566.7 ns |   197,929.0 ns |   198,282.0 ns |   199,116.3 ns |   5,053.4 |     671.245 ns |      15.00 |    3.151 |  2.000 |  -0.2832 |   47 |            * |       No |     513 B |  98.91 KB |
                  **'Write & Read Async'** | **.NET 6.0** |    **10** |    **14,143.0 ns** |    **24.19 ns** |    **21.44 ns** |   **5.73 ns** |    **14,096.1 ns** |    **14,135.8 ns** |    **14,149.1 ns** |    **14,154.9 ns** |    **14,177.0 ns** |  **70,706.3** |      **24.185 ns** |      **14.00** |    **2.673** |  **2.000** |  **-0.6549** |   **26** |            ***** |       **No** |     **510 B** |   **5.14 KB** |
                  'Write & Read Async' | .NET 7.0 |    10 |     9,229.9 ns |    49.11 ns |    43.53 ns |  11.63 ns |     9,127.7 ns |     9,209.4 ns |     9,232.8 ns |     9,256.5 ns |     9,296.2 ns | 108,343.1 |      49.105 ns |      14.00 |    2.943 |  2.000 |  -0.5936 |   25 |            * |       No |     514 B |    5.1 KB |
                  'Write & Read Async' | .NET 6.0 |    20 |    24,662.8 ns |    62.35 ns |    55.27 ns |  14.77 ns |    24,541.0 ns |    24,626.6 ns |    24,675.0 ns |    24,693.6 ns |    24,765.2 ns |  40,546.9 |      62.345 ns |      14.00 |    2.748 |  2.000 |  -0.3599 |   34 |            * |       No |     510 B |   8.73 KB |
                  'Write & Read Async' | .NET 7.0 |    20 |    18,892.7 ns |    55.64 ns |    49.33 ns |  13.18 ns |    18,780.3 ns |    18,874.0 ns |    18,878.3 ns |    18,908.7 ns |    18,969.0 ns |  52,930.6 |      55.645 ns |      14.00 |    2.964 |  2.000 |  -0.1770 |   29 |            * |       No |     514 B |   8.73 KB |
                  'Write & Read Async' | .NET 6.0 |    25 |    30,583.2 ns |    48.12 ns |    45.01 ns |  11.62 ns |    30,515.8 ns |    30,548.7 ns |    30,600.0 ns |    30,610.2 ns |    30,659.8 ns |  32,697.7 |      48.118 ns |      15.00 |    1.598 |  2.000 |  -0.0272 |   36 |            * |       No |     510 B |  10.53 KB |
                  'Write & Read Async' | .NET 7.0 |    25 |    23,176.2 ns |    92.83 ns |    86.83 ns |  22.42 ns |    23,048.8 ns |    23,110.7 ns |    23,171.5 ns |    23,237.1 ns |    23,308.7 ns |  43,147.8 |      92.832 ns |      15.00 |    1.528 |  2.000 |   0.1684 |   33 |            * |       No |     514 B |  10.53 KB |
                  'Write & Read Async' | .NET 6.0 |    50 |    57,179.0 ns |    50.25 ns |    44.55 ns |  11.91 ns |    57,100.4 ns |    57,158.6 ns |    57,173.7 ns |    57,197.5 ns |    57,258.1 ns |  17,488.9 |      50.253 ns |      14.00 |    2.289 |  2.000 |   0.2932 |   40 |            * |       No |     510 B |  20.74 KB |
                  'Write & Read Async' | .NET 7.0 |    50 |    42,673.7 ns |   149.31 ns |   139.66 ns |  36.06 ns |    42,474.1 ns |    42,557.5 ns |    42,668.9 ns |    42,741.7 ns |    42,995.0 ns |  23,433.7 |     149.306 ns |      15.00 |    2.587 |  2.000 |   0.4875 |   38 |            * |       No |     514 B |  20.73 KB |
                  'Write & Read Async' | .NET 6.0 |    75 |    84,665.6 ns |   178.72 ns |   139.53 ns |  40.28 ns |    84,403.9 ns |    84,580.3 ns |    84,653.4 ns |    84,772.0 ns |    84,899.5 ns |  11,811.2 |     178.717 ns |      12.00 |    1.963 |  2.000 |  -0.1207 |   43 |            * |       No |     510 B |   29.7 KB |
                  'Write & Read Async' | .NET 7.0 |    75 |    59,095.0 ns |    89.37 ns |    79.23 ns |  21.17 ns |    58,937.3 ns |    59,062.2 ns |    59,095.3 ns |    59,135.4 ns |    59,270.8 ns |  16,921.9 |      89.375 ns |      14.00 |    3.074 |  2.000 |   0.1831 |   41 |            * |       No |     514 B |   29.7 KB |
                  'Write & Read Async' | .NET 6.0 |   100 |   115,533.4 ns |   291.23 ns |   272.42 ns |  70.34 ns |   114,779.6 ns |   115,433.5 ns |   115,619.7 ns |   115,725.0 ns |   115,793.4 ns |   8,655.5 |     291.230 ns |      15.00 |    4.248 |  2.000 |  -1.3508 |   46 |            * |       No |     510 B |   40.9 KB |
                  'Write & Read Async' | .NET 7.0 |   100 |    81,833.1 ns |   195.69 ns |   173.47 ns |  46.36 ns |    81,571.3 ns |    81,724.6 ns |    81,802.5 ns |    81,981.9 ns |    82,166.4 ns |  12,220.0 |     195.689 ns |      14.00 |    1.866 |  2.000 |   0.2374 |   43 |            * |       No |     514 B |  40.89 KB |
                  'Write & Read Async' | .NET 6.0 |   250 |   282,882.4 ns |   756.57 ns |   707.70 ns | 182.73 ns |   281,825.9 ns |   282,357.9 ns |   282,600.7 ns |   283,427.8 ns |   284,254.5 ns |   3,535.0 |     756.570 ns |      15.00 |    1.764 |  2.000 |   0.3333 |   51 |            * |       No |     510 B |  98.95 KB |
                  'Write & Read Async' | .NET 7.0 |   250 |   205,483.1 ns |   472.10 ns |   441.60 ns | 114.02 ns |   204,546.1 ns |   205,282.7 ns |   205,595.7 ns |   205,835.5 ns |   205,939.9 ns |   4,866.6 |     472.102 ns |      15.00 |    2.292 |  2.000 |  -0.8035 |   48 |            * |       No |     514 B |  98.92 KB |
             **'WriteAsync: IEnumerable'** | **.NET 6.0** |    **10** |     **1,712.1 ns** |     **3.34 ns** |     **3.13 ns** |   **0.81 ns** |     **1,707.3 ns** |     **1,709.4 ns** |     **1,712.2 ns** |     **1,714.4 ns** |     **1,716.6 ns** | **584,080.2** |       **3.343 ns** |      **15.00** |    **1.524** |  **2.000** |   **0.0010** |    **1** |            ***** |       **No** |     **503 B** |    **1.8 KB** |
             'WriteAsync: IEnumerable' | .NET 7.0 |    10 |     1,770.1 ns |     4.61 ns |     4.31 ns |   1.11 ns |     1,763.4 ns |     1,767.6 ns |     1,770.2 ns |     1,772.4 ns |     1,778.9 ns | 564,932.3 |       4.608 ns |      15.00 |    2.197 |  2.000 |   0.2552 |    2 |            * |       No |     507 B |    1.8 KB |
             'WriteAsync: IEnumerable' | .NET 6.0 |    20 |     2,192.6 ns |     5.96 ns |     5.57 ns |   1.44 ns |     2,183.8 ns |     2,188.8 ns |     2,190.8 ns |     2,196.2 ns |     2,202.4 ns | 456,086.1 |       5.958 ns |      15.00 |    1.832 |  2.000 |   0.4185 |    5 |            * |       No |     503 B |    1.8 KB |
             'WriteAsync: IEnumerable' | .NET 7.0 |    20 |     2,261.4 ns |    11.04 ns |    10.33 ns |   2.67 ns |     2,242.5 ns |     2,258.8 ns |     2,262.7 ns |     2,268.0 ns |     2,276.6 ns | 442,213.1 |      11.042 ns |      15.00 |    2.206 |  2.000 |  -0.5823 |    6 |            * |       No |     507 B |    1.8 KB |
             'WriteAsync: IEnumerable' | .NET 6.0 |    25 |     2,381.5 ns |     7.87 ns |     7.36 ns |   1.90 ns |     2,367.6 ns |     2,374.4 ns |     2,382.5 ns |     2,387.3 ns |     2,392.8 ns | 419,906.0 |       7.867 ns |      15.00 |    1.752 |  2.000 |  -0.3687 |    8 |            * |       No |     503 B |    1.8 KB |
             'WriteAsync: IEnumerable' | .NET 7.0 |    25 |     2,459.5 ns |    11.89 ns |    11.12 ns |   2.87 ns |     2,434.5 ns |     2,451.0 ns |     2,461.5 ns |     2,468.4 ns |     2,472.8 ns | 406,584.5 |      11.893 ns |      15.00 |    2.244 |  2.000 |  -0.5520 |   10 |            * |       No |     507 B |    1.8 KB |
             'WriteAsync: IEnumerable' | .NET 6.0 |    50 |     3,721.5 ns |    10.31 ns |     9.14 ns |   2.44 ns |     3,702.4 ns |     3,718.2 ns |     3,721.3 ns |     3,726.2 ns |     3,737.8 ns | 268,707.7 |      10.307 ns |      14.00 |    2.606 |  2.000 |  -0.2649 |   13 |            * |       No |     503 B |   3.05 KB |
             'WriteAsync: IEnumerable' | .NET 7.0 |    50 |     3,864.1 ns |    20.23 ns |    18.92 ns |   4.89 ns |     3,833.5 ns |     3,851.5 ns |     3,861.2 ns |     3,873.1 ns |     3,900.0 ns | 258,792.6 |      20.229 ns |      15.00 |    2.105 |  2.000 |   0.3023 |   14 |            * |       No |     507 B |   3.05 KB |
             'WriteAsync: IEnumerable' | .NET 6.0 |    75 |     4,852.1 ns |    26.32 ns |    24.62 ns |   6.36 ns |     4,805.7 ns |     4,831.5 ns |     4,855.4 ns |     4,876.6 ns |     4,882.3 ns | 206,095.9 |      26.322 ns |      15.00 |    1.560 |  2.000 |  -0.1823 |   17 |            * |       No |     503 B |   3.05 KB |
             'WriteAsync: IEnumerable' | .NET 7.0 |    75 |     4,990.4 ns |    14.19 ns |    12.58 ns |   3.36 ns |     4,963.6 ns |     4,984.8 ns |     4,989.5 ns |     4,997.5 ns |     5,018.0 ns | 200,386.5 |      14.192 ns |      14.00 |    3.285 |  2.000 |   0.1052 |   18 |            * |       No |     507 B |   3.05 KB |
             'WriteAsync: IEnumerable' | .NET 6.0 |   100 |     6,331.2 ns |    30.17 ns |    28.22 ns |   7.29 ns |     6,273.4 ns |     6,310.7 ns |     6,327.2 ns |     6,350.7 ns |     6,385.7 ns | 157,948.9 |      30.166 ns |      15.00 |    2.426 |  2.000 |  -0.0399 |   21 |            * |       No |     503 B |    5.3 KB |
             'WriteAsync: IEnumerable' | .NET 7.0 |   100 |     6,567.9 ns |    34.41 ns |    30.50 ns |   8.15 ns |     6,520.9 ns |     6,552.8 ns |     6,562.8 ns |     6,585.7 ns |     6,640.8 ns | 152,255.8 |      34.411 ns |      14.00 |    3.020 |  2.000 |   0.6972 |   22 |            * |       No |     507 B |    5.3 KB |
             'WriteAsync: IEnumerable' | .NET 6.0 |   250 |    15,166.6 ns |    71.86 ns |    67.22 ns |  17.36 ns |    15,072.4 ns |    15,111.0 ns |    15,156.8 ns |    15,210.7 ns |    15,277.9 ns |  65,934.4 |      71.864 ns |      15.00 |    1.708 |  2.000 |   0.2364 |   27 |            * |       No |     503 B |   9.55 KB |
             'WriteAsync: IEnumerable' | .NET 7.0 |   250 |    15,882.9 ns |   115.00 ns |   107.57 ns |  27.77 ns |    15,629.6 ns |    15,829.0 ns |    15,914.7 ns |    15,957.0 ns |    16,017.0 ns |  62,960.7 |     115.000 ns |      15.00 |    2.713 |  2.000 |  -0.8740 |   28 |            * |       No |     507 B |   9.55 KB |
                            **WriteAsync** | **.NET 6.0** |    **10** |     **1,838.8 ns** |    **15.76 ns** |    **14.74 ns** |   **3.81 ns** |     **1,819.8 ns** |     **1,827.1 ns** |     **1,829.9 ns** |     **1,853.7 ns** |     **1,856.8 ns** | **543,845.0** |      **15.761 ns** |      **15.00** |    **1.007** |  **2.000** |   **0.0770** |    **4** |            ***** |       **No** |     **504 B** |   **1.76 KB** |
                            WriteAsync | .NET 7.0 |    10 |     1,804.9 ns |     6.91 ns |     6.46 ns |   1.67 ns |     1,793.9 ns |     1,800.3 ns |     1,805.2 ns |     1,809.6 ns |     1,815.7 ns | 554,041.1 |       6.907 ns |      15.00 |    1.718 |  2.000 |  -0.1770 |    3 |            * |       No |     508 B |   1.76 KB |
                            WriteAsync | .NET 6.0 |    20 |     2,427.7 ns |     7.25 ns |     6.78 ns |   1.75 ns |     2,419.1 ns |     2,422.9 ns |     2,426.9 ns |     2,432.6 ns |     2,438.9 ns | 411,904.2 |       7.250 ns |      15.00 |    1.705 |  2.000 |   0.3636 |    9 |            * |       No |     504 B |   1.76 KB |
                            WriteAsync | .NET 7.0 |    20 |     2,319.2 ns |    15.31 ns |    14.32 ns |   3.70 ns |     2,292.4 ns |     2,311.8 ns |     2,321.4 ns |     2,328.4 ns |     2,342.8 ns | 431,183.9 |      15.310 ns |      15.00 |    1.986 |  2.000 |  -0.3184 |    7 |            * |       No |     508 B |   1.76 KB |
                            WriteAsync | .NET 6.0 |    25 |     2,746.5 ns |     7.10 ns |     6.65 ns |   1.72 ns |     2,735.8 ns |     2,743.4 ns |     2,745.8 ns |     2,752.9 ns |     2,755.7 ns | 364,098.4 |       7.105 ns |      15.00 |    1.699 |  2.000 |  -0.1443 |   12 |            * |       No |     504 B |   1.76 KB |
                            WriteAsync | .NET 7.0 |    25 |     2,597.9 ns |    13.03 ns |    11.55 ns |   3.09 ns |     2,571.3 ns |     2,594.2 ns |     2,598.4 ns |     2,605.3 ns |     2,618.3 ns | 384,929.1 |      13.027 ns |      14.00 |    2.940 |  2.000 |  -0.5180 |   11 |            * |       No |     508 B |   1.76 KB |
                            WriteAsync | .NET 6.0 |    50 |     4,477.3 ns |    18.96 ns |    17.73 ns |   4.58 ns |     4,453.6 ns |     4,467.8 ns |     4,472.8 ns |     4,492.4 ns |     4,505.9 ns | 223,347.9 |      18.960 ns |      15.00 |    1.667 |  2.000 |   0.2572 |   16 |            * |       No |     504 B |   3.01 KB |
                            WriteAsync | .NET 7.0 |    50 |     4,178.3 ns |    25.06 ns |    23.44 ns |   6.05 ns |     4,135.7 ns |     4,163.2 ns |     4,181.8 ns |     4,195.4 ns |     4,217.7 ns | 239,332.7 |      25.056 ns |      15.00 |    2.020 |  2.000 |  -0.3240 |   15 |            * |       No |     508 B |   3.01 KB |
                            WriteAsync | .NET 6.0 |    75 |     5,986.5 ns |    29.37 ns |    27.48 ns |   7.09 ns |     5,951.6 ns |     5,960.5 ns |     5,982.7 ns |     6,005.2 ns |     6,027.9 ns | 167,041.9 |      29.374 ns |      15.00 |    1.477 |  2.000 |   0.3012 |   20 |            * |       No |     504 B |   3.01 KB |
                            WriteAsync | .NET 7.0 |    75 |     5,474.2 ns |    30.48 ns |    28.51 ns |   7.36 ns |     5,438.5 ns |     5,449.1 ns |     5,473.3 ns |     5,488.4 ns |     5,538.4 ns | 182,675.7 |      30.476 ns |      15.00 |    2.392 |  2.000 |   0.5700 |   19 |            * |       No |     508 B |   3.01 KB |
                            WriteAsync | .NET 6.0 |   100 |     8,335.4 ns |    41.70 ns |    39.00 ns |  10.07 ns |     8,262.4 ns |     8,322.9 ns |     8,334.6 ns |     8,361.9 ns |     8,386.5 ns | 119,970.3 |      41.696 ns |      15.00 |    2.181 |  2.000 |  -0.4291 |   24 |            * |       No |     504 B |   5.26 KB |
                            WriteAsync | .NET 7.0 |   100 |     7,241.9 ns |    36.43 ns |    34.07 ns |   8.80 ns |     7,202.7 ns |     7,211.8 ns |     7,240.5 ns |     7,257.3 ns |     7,316.2 ns | 138,084.9 |      36.426 ns |      15.00 |    2.388 |  2.000 |   0.6524 |   23 |            * |       No |     508 B |   5.26 KB |
                            WriteAsync | .NET 6.0 |   250 |    21,440.9 ns |    81.20 ns |    75.95 ns |  19.61 ns |    21,295.3 ns |    21,395.3 ns |    21,433.3 ns |    21,491.0 ns |    21,553.1 ns |  46,639.9 |      81.196 ns |      15.00 |    2.025 |  2.000 |  -0.1622 |   32 |            * |       No |     504 B |   9.51 KB |
                            WriteAsync | .NET 7.0 |   250 |    19,883.6 ns |    96.95 ns |    90.69 ns |  23.42 ns |    19,786.4 ns |    19,812.2 ns |    19,864.5 ns |    19,925.6 ns |    20,055.7 ns |  50,292.8 |      96.952 ns |      15.00 |    1.964 |  2.000 |   0.6566 |   31 |            * |       No |     508 B |   9.51 KB |