{noformat}

BenchmarkDotNet v0.13.12, Windows 10 (10.0.19045.3930/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.200-preview.23624.5
  [Host]     : .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
  Job-LJBPBB : .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
  Job-GJRVUV : .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2

EvaluateOverhead=True  Server=True  Namespace=DotNetTips.Spargine.Core.BenchmarkTests.Serialization  

{noformat}
||Method                                                              ||Runtime  ||Categories                                ||Mean         ||Error       ||StdDev      ||StdErr    ||Min          ||Q1           ||Median       ||Q3           ||Max          ||Op/s      ||CI99.9% Margin ||Iterations ||Kurtosis ||MValue ||Skewness ||Rank ||LogicalGroup ||Baseline ||Code Size ||Allocated ||
| *'Deserialize JSON: JsonSerializer + Generator - List<PersonProper>'* | *.NET 6.0* | *JSON,**NEW**,JsonSerializer,Serialization* | *228,857.8 ns* |   *862.68 ns* |   *806.95 ns* | *208.35 ns* | *227,851.6 ns* | *228,380.0 ns* | *228,424.5 ns* | *229,477.6 ns* | *230,284.9 ns* |   *4,369.5* |     *862.677 ns* |      *15.00* |    *1.621* |  *2.000* |   *0.4973* |   *21* | ***            | *No*       |     *499 B* |   *79064 B* |
| 'Deserialize JSON: JsonSerializer + Generator - List<PersonProper>' | .NET 7.0 | JSON,**NEW**,JsonSerializer,Serialization | 213,030.3 ns | 1,110.11 ns | 1,038.40 ns | 268.11 ns | 211,546.7 ns | 212,277.9 ns | 212,817.7 ns | 213,691.5 ns | 214,847.1 ns |   4,694.2 |   1,110.112 ns |      15.00 |    1.799 |  2.000 |   0.2226 |   20 | *            | No       |     587 B |   78320 B |
| *'Deserialize JSON: JsonSerializer + Generator - PersonProper'*       | *.NET 6.0* | *JSON,**NEW**,JsonSerializer,Serialization* |   *1,918.8 ns* |     *7.63 ns* |     *7.13 ns* |   *1.84 ns* |   *1,907.1 ns* |   *1,912.8 ns* |   *1,919.9 ns* |   *1,923.7 ns* |   *1,932.2 ns* | *521,153.1* |       *7.627 ns* |      *15.00* |    *1.856* |  *2.000* |   *0.1025* |    *6* | ***            | *No*       |     *503 B* |     *760 B* |
| 'Deserialize JSON: JsonSerializer + Generator - PersonProper'       | .NET 7.0 | JSON,**NEW**,JsonSerializer,Serialization |   1,632.4 ns |    11.56 ns |    10.81 ns |   2.79 ns |   1,615.6 ns |   1,624.6 ns |   1,632.8 ns |   1,639.5 ns |   1,651.0 ns | 612,608.1 |      11.562 ns |      15.00 |    1.802 |  2.000 |   0.2265 |    5 | *            | No       |     508 B |     760 B |
| *'Deserialize: JSON-PersonRecord'*                                    | *.NET 6.0* | *JSON,Serialization*                        |   *7,395.3 ns* |    *55.89 ns* |    *52.28 ns* |  *13.50 ns* |   *7,311.3 ns* |   *7,374.1 ns* |   *7,391.0 ns* |   *7,442.2 ns* |   *7,472.7 ns* | *135,221.9* |      *55.890 ns* |      *15.00* |    *1.731* |  *2.000* |  *-0.2272* |   *10* | ***            | *No*       |     *440 B* |    *2626 B* |
| 'Deserialize: JSON-PersonRecord'                                    | .NET 7.0 | JSON,Serialization                        |   6,341.5 ns |    32.69 ns |    30.58 ns |   7.90 ns |   6,280.1 ns |   6,321.0 ns |   6,332.2 ns |   6,365.0 ns |   6,388.6 ns | 157,691.7 |      32.694 ns |      15.00 |    1.941 |  2.000 |  -0.0959 |    9 | *            | No       |     443 B |    2594 B |
| *'Deserialize: List<PersonProper>'*                                   | *.NET 6.0* | *JSON,Serialization*                        | *236,607.6 ns* |   *966.19 ns* |   *806.81 ns* | *223.77 ns* | *235,698.9 ns* | *236,196.9 ns* | *236,425.2 ns* | *236,668.4 ns* | *238,776.5 ns* |   *4,226.4* |     *966.188 ns* |      *13.00* |    *4.318* |  *2.000* |   *1.3880* |   *22* | ***            | *No*       |     *440 B* |   *79181 B* |
| 'Deserialize: List<PersonProper>'                                   | .NET 7.0 | JSON,Serialization                        | 213,203.7 ns |   785.20 ns |   734.48 ns | 189.64 ns | 212,003.1 ns | 212,687.3 ns | 213,289.5 ns | 213,642.6 ns | 214,567.8 ns |   4,690.3 |     785.203 ns |      15.00 |    1.899 |  2.000 |   0.1062 |   20 | *            | No       |     443 B |   78942 B |
| *'Deserialize: XML=PersonProper'*                                     | *.NET 6.0* | *XML,Serialization*                         |  *21,746.3 ns* |   *109.71 ns* |    *97.25 ns* |  *25.99 ns* |  *21,638.7 ns* |  *21,671.3 ns* |  *21,720.8 ns* |  *21,789.4 ns* |  *21,937.6 ns* |  *45,984.9* |     *109.707 ns* |      *14.00* |    *2.077* |  *2.000* |   *0.6848* |   *13* | ***            | *No*       |     *782 B* |   *18898 B* |
| 'Deserialize: XML=PersonProper'                                     | .NET 7.0 | XML,Serialization                         |  22,457.9 ns |   160.45 ns |   150.09 ns |  38.75 ns |  22,241.4 ns |  22,348.2 ns |  22,444.0 ns |  22,539.4 ns |  22,797.2 ns |  44,527.8 |     160.454 ns |      15.00 |    2.463 |  2.000 |   0.4847 |   14 | *            | No       |     751 B |   18993 B |
| *'Deserialize: XML=PersonRecord'*                                     | *.NET 6.0* | *XML,Serialization*                         |  *27,612.1 ns* |   *147.13 ns* |   *137.62 ns* |  *35.53 ns* |  *27,388.6 ns* |  *27,524.9 ns* |  *27,596.6 ns* |  *27,689.5 ns* |  *27,848.0 ns* |  *36,216.0* |     *147.129 ns* |      *15.00* |    *1.930* |  *2.000* |   *0.2491* |   *15* | ***            | *No*       |     *782 B* |   *22850 B* |
| 'Deserialize: XML=PersonRecord'                                     | .NET 7.0 | XML,Serialization                         |  28,168.4 ns |   128.78 ns |   120.46 ns |  31.10 ns |  27,953.5 ns |  28,058.2 ns |  28,189.9 ns |  28,271.0 ns |  28,318.3 ns |  35,500.8 |     128.781 ns |      15.00 |    1.580 |  2.000 |  -0.3709 |   16 | *            | No       |     751 B |   22897 B |
| *'Serialize JSON: JsonSerializer + Generator - List<PersonProper>'*   | *.NET 6.0* | *JSON,**NEW**,JsonSerializer,Serialization* | *120,295.0 ns* |   *437.38 ns* |   *409.12 ns* | *105.63 ns* | *119,575.4 ns* | *119,963.9 ns* | *120,315.8 ns* | *120,541.4 ns* | *121,178.2 ns* |   *8,312.9* |     *437.376 ns* |      *15.00* |    *2.435* |  *2.000* |   *0.3111* |   *19* | ***            | *No*       |     *400 B* |   *78416 B* |
| 'Serialize JSON: JsonSerializer + Generator - List<PersonProper>'   | .NET 7.0 | JSON,**NEW**,JsonSerializer,Serialization | 105,159.0 ns |   491.83 ns |   460.06 ns | 118.79 ns | 104,361.7 ns | 104,917.5 ns | 105,220.3 ns | 105,488.6 ns | 105,779.9 ns |   9,509.4 |     491.832 ns |      15.00 |    1.835 |  2.000 |  -0.4278 |   17 | *            | No       |     404 B |   77848 B |
| *'Serialize JSON: JsonSerializer + Generator - PersonProper'*         | *.NET 6.0* | *JSON,**NEW**,JsonSerializer,Serialization* |   *1,037.6 ns* |     *6.57 ns* |     *5.82 ns* |   *1.56 ns* |   *1,032.0 ns* |   *1,033.8 ns* |   *1,035.3 ns* |   *1,040.5 ns* |   *1,051.0 ns* | *963,786.0* |       *6.566 ns* |      *14.00* |    *2.627* |  *2.000* |   *0.9923* |    *2* | ***            | *No*       |     *397 B* |     *848 B* |
| 'Serialize JSON: JsonSerializer + Generator - PersonProper'         | .NET 7.0 | JSON,**NEW**,JsonSerializer,Serialization |   1,001.9 ns |     7.01 ns |     6.22 ns |   1.66 ns |     991.9 ns |     998.7 ns |   1,001.0 ns |   1,004.3 ns |   1,014.2 ns | 998,079.3 |       7.013 ns |      14.00 |    2.474 |  2.000 |   0.4734 |    1 | *            | No       |     401 B |     792 B |
| *'Serialize: JSON=PersonProper'*                                      | *.NET 6.0* | *JSON,Serialization*                        |   *1,147.2 ns* |     *5.57 ns* |     *5.21 ns* |   *1.34 ns* |   *1,139.1 ns* |   *1,142.9 ns* |   *1,147.9 ns* |   *1,150.5 ns* |   *1,157.3 ns* | *871,721.9* |       *5.568 ns* |      *15.00* |    *1.892* |  *2.000* |   *0.1194* |    *4* | ***            | *No*       |     *781 B* |     *776 B* |
| 'Serialize: JSON=PersonProper'                                      | .NET 7.0 | JSON,Serialization                        |   1,072.3 ns |     6.31 ns |     5.91 ns |   1.52 ns |   1,065.0 ns |   1,068.0 ns |   1,070.8 ns |   1,074.3 ns |   1,083.6 ns | 932,606.7 |       6.313 ns |      15.00 |    2.081 |  2.000 |   0.7384 |    3 | *            | No       |     659 B |     792 B |
| *'Serialize: JSON=PersonRecord'*                                      | *.NET 6.0* | *JSON,Serialization*                        |   *2,545.9 ns* |     *8.67 ns* |     *8.11 ns* |   *2.09 ns* |   *2,531.3 ns* |   *2,540.0 ns* |   *2,545.8 ns* |   *2,551.1 ns* |   *2,559.8 ns* | *392,793.8* |       *8.670 ns* |      *15.00* |    *1.998* |  *2.000* |  *-0.0591* |    *8* | ***            | *No*       |     *781 B* |    *1912 B* |
| 'Serialize: JSON=PersonRecord'                                      | .NET 7.0 | JSON,Serialization                        |   2,202.8 ns |    11.68 ns |    10.93 ns |   2.82 ns |   2,184.8 ns |   2,194.3 ns |   2,205.9 ns |   2,209.1 ns |   2,221.4 ns | 453,973.5 |      11.683 ns |      15.00 |    1.762 |  2.000 |  -0.0099 |    7 | *            | No       |     659 B |    1952 B |
| *'Serialize: List<PersonProper>'*                                     | *.NET 6.0* | *JSON,Serialization*                        | *121,096.6 ns* |   *406.72 ns* |   *380.45 ns* |  *98.23 ns* | *120,685.2 ns* | *120,759.8 ns* | *121,044.1 ns* | *121,317.3 ns* | *121,872.2 ns* |   *8,257.9* |     *406.721 ns* |      *15.00* |    *2.018* |  *2.000* |   *0.6384* |   *19* | ***            | *No*       |     *784 B* |   *77856 B* |
| 'Serialize: List<PersonProper>'                                     | .NET 7.0 | JSON,Serialization                        | 107,090.5 ns |   467.45 ns |   437.26 ns | 112.90 ns | 106,415.4 ns | 106,813.7 ns | 107,100.9 ns | 107,402.0 ns | 107,876.8 ns |   9,337.9 |     467.455 ns |      15.00 |    1.787 |  2.000 |   0.1835 |   18 | *            | No       |     662 B |   78000 B |
| *'Serialize: XML=PersonProper'*                                       | *.NET 6.0* | *XML,Serialization*                         |  *17,869.1 ns* |    *77.06 ns* |    *68.31 ns* |  *18.26 ns* |  *17,749.2 ns* |  *17,840.4 ns* |  *17,867.6 ns* |  *17,893.3 ns* |  *17,987.2 ns* |  *55,962.6* |      *77.063 ns* |      *14.00* |    *2.301* |  *2.000* |   *0.1790* |   *11* | ***            | *No*       |     *888 B* |   *21178 B* |
| 'Serialize: XML=PersonProper'                                       | .NET 7.0 | XML,Serialization                         |  18,640.6 ns |   123.63 ns |   115.65 ns |  29.86 ns |  18,454.4 ns |  18,546.2 ns |  18,629.0 ns |  18,712.9 ns |  18,884.3 ns |  53,646.3 |     123.635 ns |      15.00 |    2.141 |  2.000 |   0.3432 |   12 | *            | No       |     860 B |   21017 B |