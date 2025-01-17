{noformat}

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19044.1706 (21H2)
Intel Core i7-7660U CPU 2.50GHz (Kaby Lake), 1 CPU, 4 logical and 2 physical cores
.NET SDK=6.0.300
  [Host]     : .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
  Job-ZCARTZ : .NET 6.0.5 (6.0.522.21309), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET 6.0  
Namespace=DotNetTips.Spargine.Core.BenchmarkTests.Logging  Categories=LOGGING  

{noformat}
||                   Method ||     Mean ||    Error ||   StdDev ||   StdErr ||      Min ||       Q1 ||   Median ||       Q3 ||      Max ||         Op/s ||CI99.9% Margin ||Iterations ||Kurtosis ||MValue ||Skewness ||Rank ||LogicalGroup ||Baseline || Gen 0 ||Code Size ||Allocated ||
|    *EasyLogger.LogCritical* | *23.276 ns* | *0.3687 ns* | *0.3268 ns* | *0.0873 ns* | *22.825 ns* | *23.105 ns* | *23.236 ns* | *23.421 ns* | *23.926 ns* |  *42,961,995.3* |      *0.3687 ns* |      *14.00* |    *2.218* |  *2.000* |   *0.4328* |    *5* |            *** |       *No* | *0.0153* |     *188 B* |     *136 B* |
|       *EasyLogger.LogDebug* |  *5.822 ns* | *0.3216 ns* | *0.9228 ns* | *0.0947 ns* |  *4.549 ns* |  *5.081 ns* |  *5.662 ns* |  *6.301 ns* |  *8.441 ns* | *171,759,041.3* |      *0.3216 ns* |      *95.00* |    *2.777* |  *5.185* |   *0.7396* |    *3* |            *** |       *No* |      *-* |     *114 B* |         *-* |
|       *EasyLogger.LogError* | *17.196 ns* | *0.3016 ns* | *0.2519 ns* | *0.0699 ns* | *16.711 ns* | *17.197 ns* | *17.271 ns* | *17.353 ns* | *17.507 ns* |  *58,151,853.4* |      *0.3016 ns* |      *13.00* |    *2.324* |  *2.000* |  *-0.8563* |    *4* |            *** |       *No* | *0.0150* |     *188 B* |     *136 B* |
| *EasyLogger.LogInformation* |  *4.743 ns* | *0.0318 ns* | *0.0266 ns* | *0.0074 ns* |  *4.704 ns* |  *4.719 ns* |  *4.744 ns* |  *4.759 ns* |  *4.788 ns* | *210,848,887.8* |      *0.0318 ns* |      *13.00* |    *1.603* |  *2.000* |   *0.0503* |    *2* |            *** |       *No* |      *-* |     *114 B* |         *-* |
|       *EasyLogger.LogTrace* |  *4.407 ns* | *0.0466 ns* | *0.0413 ns* | *0.0110 ns* |  *4.354 ns* |  *4.376 ns* |  *4.407 ns* |  *4.436 ns* |  *4.487 ns* | *226,916,972.9* |      *0.0466 ns* |      *14.00* |    *1.638* |  *2.000* |   *0.2344* |    *1* |            *** |       *No* |      *-* |     *111 B* |         *-* |
|        *EasyLogger.Warning* |  *4.705 ns* | *0.0520 ns* | *0.0461 ns* | *0.0123 ns* |  *4.645 ns* |  *4.669 ns* |  *4.696 ns* |  *4.740 ns* |  *4.789 ns* | *212,539,390.7* |      *0.0520 ns* |      *14.00* |    *1.706* |  *2.000* |   *0.4128* |    *2* |            *** |       *No* |      *-* |     *114 B* |         *-* |
