{noformat}

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19044.1706 (21H2)
Intel Core i7-7660U CPU 2.50GHz (Kaby Lake), 1 CPU, 4 logical and 2 physical cores
.NET SDK=6.0.300
  [Host]     : .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
  Job-NMJDOV : .NET 6.0.5 (6.0.522.21309), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET 6.0  
Namespace=DotNetTips.Spargine.BenchmarkTests.IO  Categories=IO  

{noformat}
||                   Method ||      Mean ||     Error ||    StdDev ||   StdErr ||       Min ||        Q1 ||    Median ||        Q3 ||       Max ||     Op/s ||CI99.9% Margin ||Iterations ||Kurtosis ||MValue ||Skewness ||Rank ||LogicalGroup ||Baseline || Gen 0 ||Code Size ||Allocated ||
|             *AppDataFolder* |   *3.187 μs* |  *0.1563 μs* |  *0.4608 μs* | *0.0461 μs* |   *2.471 μs* |   *2.785 μs* |   *3.140 μs* |   *3.470 μs* |   *4.412 μs* | *313,816.7* |      *0.1563 μs* |     *100.00* |    *2.756* |  *3.517* |   *0.6379* |    *1* |            *** |       *No* | *0.0763* |     *395 B* |     *736 B* |
|       *LoadOneDriveFolders* |  *98.935 μs* |  *1.8037 μs* |  *1.6871 μs* | *0.4356 μs* |  *96.714 μs* |  *97.528 μs* |  *98.971 μs* | *100.291 μs* | *101.968 μs* |  *10,107.6* |      *1.8037 μs* |      *15.00* |    *1.557* |  *2.000* |   *0.1447* |    *3* |            *** |       *No* | *0.3662* |   *1,089 B* |   *4,161 B* |
|       *SafeDirectorySearch* |  *81.764 μs* |  *1.6274 μs* |  *3.7391 μs* | *0.4711 μs* |  *74.521 μs* |  *78.834 μs* |  *81.150 μs* |  *84.904 μs* |  *89.862 μs* |  *12,230.3* |      *1.6274 μs* |      *63.00* |    *2.040* |  *2.333* |   *0.0139* |    *2* |            *** |       *No* |      *-* |     *875 B* |     *448 B* |
|            *SafeFileSearch* | *792.114 μs* | *15.8038 μs* | *39.9383 μs* | *4.6117 μs* | *697.317 μs* | *772.799 μs* | *793.586 μs* | *816.218 μs* | *879.198 μs* |   *1,262.4* |     *15.8038 μs* |      *75.00* |    *2.982* |  *2.000* |  *-0.1383* |    *5* |            *** |       *No* | *5.8594* |     *632 B* |  *58,562 B* |
| *SetFileAttributesToNormal* | *243.354 μs* |  *5.7562 μs* | *16.6997 μs* | *1.6956 μs* | *210.134 μs* | *231.450 μs* | *241.369 μs* | *252.998 μs* | *286.731 μs* |   *4,109.2* |      *5.7562 μs* |      *97.00* |    *2.936* |  *2.000* |   *0.4264* |    *4* |            *** |       *No* |      *-* |     *229 B* |   *1,008 B* |