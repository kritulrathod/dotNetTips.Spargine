{noformat}

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19044.1706 (21H2)
Intel Core i7-7660U CPU 2.50GHz (Kaby Lake), 1 CPU, 4 logical and 2 physical cores
.NET SDK=6.0.300
  [Host]     : .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
  Job-SPYWVM : .NET 6.0.5 (6.0.522.21309), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET 6.0  
Namespace=DotNetTips.Spargine.Extensions.BenchmarkTests.Tester  

{noformat}
||                              Method ||    Mean ||   Error ||  StdDev ||  StdErr ||     Min ||      Q1 ||  Median ||      Q3 ||     Max ||    Op/s ||CI99.9% Margin ||Iterations ||Kurtosis ||MValue ||Skewness ||Rank ||LogicalGroup ||Baseline ||Code Size || Gen 0 ||Allocated ||
|                   *'Creating: Person'* | *24.34 μs* | *0.174 μs* | *0.163 μs* | *0.042 μs* | *24.06 μs* | *24.23 μs* | *24.39 μs* | *24.48 μs* | *24.56 μs* | *41,077.8* |      *0.1743 μs* |      *15.00* |    *1.671* |  *2.000* |  *-0.3429* |    *1* |            *** |       *No* |      *1 KB* | *0.2747* |      *3 KB* |
|             *'Creating: PersonProper'* | *24.73 μs* | *0.327 μs* | *0.306 μs* | *0.079 μs* | *24.28 μs* | *24.44 μs* | *24.74 μs* | *24.99 μs* | *25.14 μs* | *40,444.3* |      *0.3269 μs* |      *15.00* |    *1.280* |  *2.000* |  *-0.0039* |    *1* |            *** |       *No* |      *1 KB* | *0.2747* |      *3 KB* |
|             *'Creating: PersonRecord'* | *32.10 μs* | *0.261 μs* | *0.244 μs* | *0.063 μs* | *31.69 μs* | *31.90 μs* | *32.11 μs* | *32.28 μs* | *32.61 μs* | *31,150.9* |      *0.2610 μs* |      *15.00* |    *2.202* |  *2.000* |   *0.2088* |    *2* |            *** |       *No* |      *2 KB* | *0.3662* |      *4 KB* |
| *'PropertiesToString(): PersonProper'* | *44.88 μs* | *0.594 μs* | *0.527 μs* | *0.141 μs* | *43.99 μs* | *44.59 μs* | *44.84 μs* | *45.10 μs* | *46.06 μs* | *22,282.0* |      *0.5944 μs* |      *14.00* |    *2.725* |  *2.000* |   *0.4369* |    *3* |            *** |       *No* |      *1 KB* | *3.4180* |     *31 KB* |
| *'PropertiesToString(): PersonRecord'* | *58.87 μs* | *0.518 μs* | *0.484 μs* | *0.125 μs* | *57.95 μs* | *58.63 μs* | *59.04 μs* | *59.17 μs* | *59.62 μs* | *16,986.7* |      *0.5176 μs* |      *15.00* |    *2.043* |  *2.000* |  *-0.5679* |    *4* |            *** |       *No* |      *2 KB* | *4.9438* |     *44 KB* |
