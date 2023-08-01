## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogCritical_EazyLogger_Benchmark()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,[rcx+190]
       mov       rdi,[rcx+198]
       mov       rcx,rsi
       mov       r11,7FFA986B0708
       mov       edx,5
       call      qword ptr [7FFA986B0708]
       test      eax,eax
       je        short M00_L00
       mov       rcx,7FFA98956A60
       mov       edx,47
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,27A76418648
       mov       rax,[rcx]
       mov       rcx,[rax+8]
       mov       r8,27A66411BD8
       mov       r8,[r8]
       mov       rdx,rsi
       mov       r9,rdi
       mov       rax,[rax+18]
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
M00_L00:
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 124
```

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogCritical_EazyLogger_Benchmark()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,[rcx+190]
       mov       rdi,[rcx+198]
       mov       rcx,rsi
       mov       r11,7FFA96F70700
       mov       edx,5
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L00
       mov       rcx,7FFA973CA248
       mov       edx,50
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,199E08056A0
       mov       rax,[rcx]
       mov       rcx,[rax+8]
       mov       r8,199EC800C18
       mov       r8,[r8]
       mov       rdx,rsi
       mov       r9,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax+18]
M00_L00:
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 118
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogDebug_EasyLogger_Benchmark()
       push      rsi
       sub       rsp,20
       mov       rsi,[rcx+190]
       mov       rcx,rsi
       mov       r11,7FFA986C0758
       mov       edx,1
       call      qword ptr [7FFA986C0758]
       test      eax,eax
       je        short M00_L00
       mov       rcx,7FFA98966A60
       mov       edx,47
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,23457A58650
       mov       rax,[rcx]
       mov       rcx,[rax+8]
       mov       r8,234A7A51BD8
       mov       r8,[r8]
       mov       rdx,rsi
       xor       r9d,r9d
       mov       rax,[rax+18]
       add       rsp,20
       pop       rsi
       jmp       rax
M00_L00:
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 114
```

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogDebug_EasyLogger_Benchmark()
       push      rsi
       sub       rsp,20
       mov       rsi,[rcx+190]
       mov       rcx,rsi
       mov       r11,7FFA96F70700
       mov       edx,1
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L00
       mov       rcx,7FFA973CA248
       mov       edx,50
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,22A890076A0
       mov       rax,[rcx]
       mov       rcx,[rax+8]
       mov       r8,22A97000C18
       mov       r8,[r8]
       mov       rdx,rsi
       xor       r9d,r9d
       add       rsp,20
       pop       rsi
       jmp       qword ptr [rax+18]
M00_L00:
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 108
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogError_EasyLogger_Benchmark()
       push      rsi
       sub       rsp,20
       mov       rsi,[rcx+190]
       mov       rcx,rsi
       mov       r11,7FFA986C0768
       mov       edx,4
       call      qword ptr [7FFA986C0768]
       test      eax,eax
       je        short M00_L00
       mov       rcx,7FFA98966A60
       mov       edx,47
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1CBDADA8658
       mov       rax,[rcx]
       mov       rcx,[rax+8]
       mov       r8,1CC4ADA1BD8
       mov       r8,[r8]
       mov       rdx,rsi
       xor       r9d,r9d
       mov       rax,[rax+18]
       add       rsp,20
       pop       rsi
       jmp       rax
M00_L00:
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 114
```

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogError_EasyLogger_Benchmark()
       push      rsi
       sub       rsp,20
       mov       rsi,[rcx+190]
       mov       rcx,rsi
       mov       r11,7FFA96F506F0
       mov       edx,4
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L00
       mov       rcx,7FFA973AA248
       mov       edx,50
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,16EDA4076A8
       mov       rax,[rcx]
       mov       rcx,[rax+8]
       mov       r8,16ED8401C30
       mov       r8,[r8]
       mov       rdx,rsi
       xor       r9d,r9d
       add       rsp,20
       pop       rsi
       jmp       qword ptr [rax+18]
M00_L00:
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 108
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogException_EasyLogger_Benchmark()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,[rcx+190]
       mov       rdi,[rcx+198]
       mov       rcx,rsi
       mov       r11,7FFA986A0768
       mov       edx,4
       call      qword ptr [7FFA986A0768]
       test      eax,eax
       je        short M00_L00
       mov       rcx,7FFA98946A60
       mov       edx,47
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,18730F88660
       mov       rax,[rcx]
       mov       rcx,[rax+8]
       mov       r8,18790F81BD8
       mov       r8,[r8]
       mov       rdx,rsi
       mov       r9,rdi
       mov       rax,[rax+18]
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       rax
M00_L00:
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 124
```

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogException_EasyLogger_Benchmark()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,[rcx+190]
       mov       rdi,[rcx+198]
       mov       rcx,rsi
       mov       r11,7FFA96F506F0
       mov       edx,4
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L00
       mov       rcx,7FFA973AA248
       mov       edx,50
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,21C0B4076B0
       mov       rax,[rcx]
       mov       rcx,[rax+8]
       mov       r8,21C0F409BC8
       mov       r8,[r8]
       mov       rdx,rsi
       mov       r9,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax+18]
M00_L00:
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 118
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogInformation_EasyLogger_Benchmark()
       push      rsi
       sub       rsp,20
       mov       rsi,[rcx+190]
       mov       rcx,rsi
       mov       r11,7FFA986C0708
       mov       edx,2
       call      qword ptr [7FFA986C0708]
       test      eax,eax
       je        short M00_L00
       mov       rcx,7FFA98966A60
       mov       edx,47
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1B8D5738668
       mov       rax,[rcx]
       mov       rcx,[rax+8]
       mov       r8,1B935731BD8
       mov       r8,[r8]
       mov       rdx,rsi
       xor       r9d,r9d
       mov       rax,[rax+18]
       add       rsp,20
       pop       rsi
       jmp       rax
M00_L00:
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 114
```

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogInformation_EasyLogger_Benchmark()
       push      rsi
       sub       rsp,20
       mov       rsi,[rcx+190]
       mov       rcx,rsi
       mov       r11,7FFA96F50700
       mov       edx,2
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L00
       mov       rcx,7FFA973AA248
       mov       edx,50
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1E726C032B0
       mov       rax,[rcx]
       mov       rcx,[rax+8]
       mov       r8,1E726C05408
       mov       r8,[r8]
       mov       rdx,rsi
       xor       r9d,r9d
       add       rsp,20
       pop       rsi
       jmp       qword ptr [rax+18]
M00_L00:
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 108
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogTrace_EasyLogger_Benchmark()
       push      rsi
       sub       rsp,20
       mov       rsi,[rcx+190]
       mov       rcx,rsi
       mov       r11,7FFA986C0768
       xor       edx,edx
       call      qword ptr [7FFA986C0768]
       test      eax,eax
       je        short M00_L00
       mov       rcx,7FFA98966A60
       mov       edx,47
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1DE6FE38670
       mov       rax,[rcx]
       mov       rcx,[rax+8]
       mov       r8,1DEBFE31BD8
       mov       r8,[r8]
       mov       rdx,rsi
       xor       r9d,r9d
       mov       rax,[rax+18]
       add       rsp,20
       pop       rsi
       jmp       rax
M00_L00:
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 111
```

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogTrace_EasyLogger_Benchmark()
       push      rsi
       sub       rsp,20
       mov       rsi,[rcx+190]
       mov       rcx,rsi
       mov       r11,7FFA96F50700
       xor       edx,edx
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L00
       mov       rcx,7FFA973AA248
       mov       edx,50
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,23E914076C0
       mov       rax,[rcx]
       mov       rcx,[rax+8]
       mov       r8,23E99400C18
       mov       r8,[r8]
       mov       rdx,rsi
       xor       r9d,r9d
       add       rsp,20
       pop       rsi
       jmp       qword ptr [rax+18]
M00_L00:
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 105
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogWarning_EasyLogger_Benchmark()
       push      rsi
       sub       rsp,20
       mov       rsi,[rcx+190]
       mov       rcx,rsi
       mov       r11,7FFA98690768
       mov       edx,3
       call      qword ptr [7FFA98690768]
       test      eax,eax
       je        short M00_L00
       mov       rcx,7FFA98936A60
       mov       edx,47
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1729EDF8678
       mov       rax,[rcx]
       mov       rcx,[rax+8]
       mov       r8,1730EDF1BD8
       mov       r8,[r8]
       mov       rdx,rsi
       xor       r9d,r9d
       mov       rax,[rax+18]
       add       rsp,20
       pop       rsi
       jmp       rax
M00_L00:
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 114
```

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogWarning_EasyLogger_Benchmark()
       push      rsi
       sub       rsp,20
       mov       rsi,[rcx+190]
       mov       rcx,rsi
       mov       r11,7FFA96F80690
       mov       edx,3
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L00
       mov       rcx,7FFA973DA248
       mov       edx,50
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1F03EC076C8
       mov       rax,[rcx]
       mov       rcx,[rax+8]
       mov       r8,1F03EC127C0
       mov       r8,[r8]
       mov       rdx,rsi
       xor       r9d,r9d
       add       rsp,20
       pop       rsi
       jmp       qword ptr [rax+18]
M00_L00:
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 108
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogCritical_EazyLoggerExtensions_Benchmark()
       mov       [rsp+8],rcx
       mov       rcx,[rcx+190]
       mov       r8,[rsp+8]
       mov       r8,[r8+198]
       mov       rdx,2A05E583780
       mov       rdx,[rdx]
       mov       r9,2A05E583788
       mov       r9,[r9]
       jmp       near ptr DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions.LogCriticalMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.Exception, System.String)
; Total bytes of code 55
```
```assembly
; DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions.LogCriticalMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.Exception, System.String)
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,50
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rbp,r9
       mov       rcx,rsi
       mov       r11,7FFA98690770
       mov       edx,5
       call      qword ptr [7FFA98690770]
       test      eax,eax
       je        near ptr M01_L00
       mov       r14d,390
       mov       rcx,2A05E583790
       mov       r15,[rcx]
       mov       rcx,rsi
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log[[DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions+__LogCriticalMessageStruct, dotNetTips.Spargine.6.Core]](Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, __LogCriticalMessageStruct, System.Exception, System.Func`3<__LogCriticalMessageStruct,System.Exception,System.String>)
       call      CORINFO_HELP_VIRTUAL_FUNC_PTR
       mov       r12,rax
       mov       [rsp+40],r15
       mov       [rsp+48],r14d
       mov       [rsp+30],rdi
       mov       [rsp+38],rbp
       mov       rcx,7FFA98936A60
       mov       edx,6D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,2A05E578700
       mov       rcx,[rcx]
       mov       [rsp+28],rcx
       mov       rcx,rsi
       lea       r8,[rsp+40]
       lea       r9,[rsp+30]
       mov       [rsp+20],rbx
       mov       edx,5
       call      r12
M01_L00:
       nop
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
; Total bytes of code 224
```

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogCritical_EazyLoggerExtensions_Benchmark()
       mov       [rsp+8],rcx
       mov       rcx,[rcx+190]
       mov       r8,[rsp+8]
       mov       r8,[r8+198]
       mov       rdx,232FC0117A8
       mov       rdx,[rdx]
       mov       r9,232FC0117B0
       mov       r9,[r9]
       jmp       qword ptr [7FFA977FD000]; DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions.LogCriticalMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.Exception, System.String)
; Total bytes of code 56
```
```assembly
; DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions.LogCriticalMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.Exception, System.String)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rax
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rbp,r9
       mov       rcx,rsi
       mov       r11,7FFA96F806A8
       mov       edx,5
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M01_L00
       mov       rcx,232FC0117B8
       mov       r14,[rcx]
       mov       rcx,rsi
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log[[DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions+__LogCriticalMessageStruct, dotNetTips.Spargine.6.Core]](Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, __LogCriticalMessageStruct, System.Exception, System.Func`3<__LogCriticalMessageStruct,System.Exception,System.String>)
       call      CORINFO_HELP_VIRTUAL_FUNC_PTR
       mov       r15,rax
       mov       [rsp+48],r14
       mov       dword ptr [rsp+50],390
       mov       [rsp+38],rdi
       mov       [rsp+40],rbp
       mov       rcx,7FFA973DA248
       mov       edx,7F
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,232FC007758
       mov       rcx,[rcx]
       mov       [rsp+28],rcx
       mov       rcx,rsi
       lea       r8,[rsp+48]
       lea       r9,[rsp+38]
       mov       [rsp+20],rbx
       mov       edx,5
       call      r15
M01_L00:
       nop
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 220
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogError_EazyLoggerExtensions_Benchmark()
       mov       rcx,[rcx+190]
       mov       rdx,1CB4FEE1BD8
       mov       rdx,[rdx]
       mov       r8,1CB4FEE1BE0
       mov       r8,[r8]
       jmp       near ptr DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions.LogErrorMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.String)
; Total bytes of code 38
```
```assembly
; DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions.LogErrorMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.String)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rax
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rcx,rsi
       mov       r11,7FFA986B0770
       mov       edx,4
       call      qword ptr [7FFA986B0770]
       test      eax,eax
       je        near ptr M01_L00
       mov       ebp,12D
       mov       rcx,1CB4FEE1BE8
       mov       r14,[rcx]
       mov       rcx,rsi
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log[[DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions+__LogErrorMessageStruct, dotNetTips.Spargine.6.Core]](Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, __LogErrorMessageStruct, System.Exception, System.Func`3<__LogErrorMessageStruct,System.Exception,System.String>)
       call      CORINFO_HELP_VIRTUAL_FUNC_PTR
       mov       r15,rax
       mov       [rsp+48],r14
       mov       [rsp+50],ebp
       mov       [rsp+38],rdi
       mov       [rsp+40],rbx
       mov       rcx,7FFA98956A60
       mov       edx,6F
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1CADFEE8710
       mov       rcx,[rcx]
       mov       [rsp+28],rcx
       mov       rcx,rsi
       lea       r8,[rsp+48]
       lea       r9,[rsp+38]
       mov       edx,4
       xor       eax,eax
       mov       [rsp+20],rax
       call      r15
M01_L00:
       nop
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 223
```

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogError_EazyLoggerExtensions_Benchmark()
       mov       rcx,[rcx+190]
       mov       rdx,1C730C01C30
       mov       rdx,[rdx]
       mov       r8,1C730C01C38
       mov       r8,[r8]
       jmp       qword ptr [7FFA9780B030]; DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions.LogErrorMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.String)
; Total bytes of code 39
```
```assembly
; DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions.LogErrorMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.String)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,50
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rcx,rsi
       mov       r11,7FFA96F90698
       mov       edx,4
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M01_L00
       mov       rcx,1C730C01C40
       mov       rbp,[rcx]
       mov       rcx,rsi
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log[[DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions+__LogErrorMessageStruct, dotNetTips.Spargine.6.Core]](Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, __LogErrorMessageStruct, System.Exception, System.Func`3<__LogErrorMessageStruct,System.Exception,System.String>)
       call      CORINFO_HELP_VIRTUAL_FUNC_PTR
       mov       r14,rax
       mov       [rsp+40],rbp
       mov       dword ptr [rsp+48],12D
       mov       [rsp+30],rdi
       mov       [rsp+38],rbx
       mov       rcx,7FFA973EA248
       mov       edx,81
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1C734C03360
       mov       rcx,[rcx]
       mov       [rsp+28],rcx
       mov       rcx,rsi
       lea       r8,[rsp+40]
       lea       r9,[rsp+30]
       mov       edx,4
       xor       eax,eax
       mov       [rsp+20],rax
       call      r14
M01_L00:
       nop
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 209
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogException_EazyLoggerExtensions_Benchmark()
       mov       rcx,[rcx+190]
       mov       rdx,24D750E1BD8
       mov       rdx,[rdx]
       mov       r8,24D750E1BE0
       mov       r8,[r8]
       jmp       near ptr DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions.LogDebugMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.String)
; Total bytes of code 38
```
```assembly
; DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions.LogDebugMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.String)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rax
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rcx,rsi
       mov       r11,7FFA986B0770
       mov       edx,1
       call      qword ptr [7FFA986B0770]
       test      eax,eax
       je        near ptr M01_L00
       mov       ebp,0C9
       mov       rcx,24CE50E9888
       mov       r14,[rcx]
       mov       rcx,rsi
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log[[DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions+__LogDebugMessageStruct, dotNetTips.Spargine.6.Core]](Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, __LogDebugMessageStruct, System.Exception, System.Func`3<__LogDebugMessageStruct,System.Exception,System.String>)
       call      CORINFO_HELP_VIRTUAL_FUNC_PTR
       mov       r15,rax
       mov       [rsp+48],r14
       mov       [rsp+50],ebp
       mov       [rsp+38],rdi
       mov       [rsp+40],rbx
       mov       rcx,7FFA98956A60
       mov       edx,6E
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,24CE50E8708
       mov       rcx,[rcx]
       mov       [rsp+28],rcx
       mov       rcx,rsi
       lea       r8,[rsp+48]
       lea       r9,[rsp+38]
       mov       edx,1
       xor       eax,eax
       mov       [rsp+20],rax
       call      r15
M01_L00:
       nop
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 223
```

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogException_EazyLoggerExtensions_Benchmark()
       mov       rcx,[rcx+190]
       mov       rdx,23B3A0117A8
       mov       rdx,[rdx]
       mov       r8,23B3A0117B0
       mov       r8,[r8]
       jmp       qword ptr [7FFA977DB318]; DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions.LogDebugMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.String)
; Total bytes of code 39
```
```assembly
; DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions.LogDebugMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.String)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,50
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rcx,rsi
       mov       r11,7FFA96F606A8
       mov       edx,1
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M01_L00
       mov       rcx,23B3A0088B0
       mov       rbp,[rcx]
       mov       rcx,rsi
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log[[DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions+__LogDebugMessageStruct, dotNetTips.Spargine.6.Core]](Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, __LogDebugMessageStruct, System.Exception, System.Func`3<__LogDebugMessageStruct,System.Exception,System.String>)
       call      CORINFO_HELP_VIRTUAL_FUNC_PTR
       mov       r14,rax
       mov       [rsp+40],rbp
       mov       dword ptr [rsp+48],0C9
       mov       [rsp+30],rdi
       mov       [rsp+38],rbx
       mov       rcx,7FFA973BA248
       mov       edx,80
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,23B3A007760
       mov       rcx,[rcx]
       mov       [rsp+28],rcx
       mov       rcx,rsi
       lea       r8,[rsp+40]
       lea       r9,[rsp+30]
       mov       edx,1
       xor       eax,eax
       mov       [rsp+20],rax
       call      r14
M01_L00:
       nop
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 209
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogInformation_EazyLoggerExtensions_Benchmark()
       mov       rcx,[rcx+190]
       mov       rdx,18A6BB21BD8
       mov       rdx,[rdx]
       mov       r8,18A6BB21BE0
       mov       r8,[r8]
       jmp       near ptr DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions.LogInformationMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.String)
; Total bytes of code 38
```
```assembly
; DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions.LogInformationMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.String)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rax
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rcx,rsi
       mov       r11,7FFA986C0700
       mov       edx,2
       call      qword ptr [7FFA986C0700]
       test      eax,eax
       je        near ptr M01_L00
       mov       ebp,191
       mov       rcx,18A6BB21BE8
       mov       r14,[rcx]
       mov       rcx,rsi
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log[[DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions+__LogInformationMessageStruct, dotNetTips.Spargine.6.Core]](Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, __LogInformationMessageStruct, System.Exception, System.Func`3<__LogInformationMessageStruct,System.Exception,System.String>)
       call      CORINFO_HELP_VIRTUAL_FUNC_PTR
       mov       r15,rax
       mov       [rsp+48],r14
       mov       [rsp+50],ebp
       mov       [rsp+38],rdi
       mov       [rsp+40],rbx
       mov       rcx,7FFA98966A60
       mov       edx,71
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,189DBB26728
       mov       rcx,[rcx]
       mov       [rsp+28],rcx
       mov       rcx,rsi
       lea       r8,[rsp+48]
       lea       r9,[rsp+38]
       mov       edx,2
       xor       eax,eax
       mov       [rsp+20],rax
       call      r15
M01_L00:
       nop
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 223
```

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogInformation_EazyLoggerExtensions_Benchmark()
       mov       rcx,[rcx+190]
       mov       rdx,2767F800C18
       mov       rdx,[rdx]
       mov       r8,2767F800C20
       mov       r8,[r8]
       jmp       qword ptr [7FFA977DB060]; DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions.LogInformationMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.String)
; Total bytes of code 39
```
```assembly
; DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions.LogInformationMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.String)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,50
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rcx,rsi
       mov       r11,7FFA96F60708
       mov       edx,2
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M01_L00
       mov       rcx,2767F800C28
       mov       rbp,[rcx]
       mov       rcx,rsi
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log[[DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions+__LogInformationMessageStruct, dotNetTips.Spargine.6.Core]](Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, __LogInformationMessageStruct, System.Exception, System.Func`3<__LogInformationMessageStruct,System.Exception,System.String>)
       call      CORINFO_HELP_VIRTUAL_FUNC_PTR
       mov       r14,rax
       mov       [rsp+40],rbp
       mov       dword ptr [rsp+48],191
       mov       [rsp+30],rdi
       mov       [rsp+38],rbx
       mov       rcx,7FFA973BA248
       mov       edx,83
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,27675807778
       mov       rcx,[rcx]
       mov       [rsp+28],rcx
       mov       rcx,rsi
       lea       r8,[rsp+40]
       lea       r9,[rsp+30]
       mov       edx,2
       xor       eax,eax
       mov       [rsp+20],rax
       call      r14
M01_L00:
       nop
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 209
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogStoredProcedureError_EazyLoggerExtensions_Benchmark()
       mov       [rsp+8],rcx
       mov       rcx,[rcx+190]
       mov       r8,[rsp+8]
       mov       r8,[r8+198]
       mov       rdx,281E3FB2768
       mov       rdx,[rdx]
       mov       r9,281E3FB2770
       mov       r9,[r9]
       jmp       near ptr DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions.LogStoredProcedureError(Microsoft.Extensions.Logging.ILogger, System.String, System.Exception, System.String)
; Total bytes of code 55
```
```assembly
; DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions.LogStoredProcedureError(Microsoft.Extensions.Logging.ILogger, System.String, System.Exception, System.String)
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,50
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rbp,r9
       mov       rcx,rsi
       mov       r11,7FFA986B0770
       mov       edx,4
       call      qword ptr [7FFA986B0770]
       test      eax,eax
       je        near ptr M01_L00
       mov       r14d,1F6
       mov       rcx,281E3FB2778
       mov       r15,[rcx]
       mov       rcx,rsi
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log[[DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions+__LogStoredProcedureErrorStruct, dotNetTips.Spargine.6.Core]](Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, __LogStoredProcedureErrorStruct, System.Exception, System.Func`3<__LogStoredProcedureErrorStruct,System.Exception,System.String>)
       call      CORINFO_HELP_VIRTUAL_FUNC_PTR
       mov       r12,rax
       mov       [rsp+40],r15
       mov       [rsp+48],r14d
       mov       [rsp+30],rdi
       mov       [rsp+38],rbp
       mov       rcx,7FFA98956A60
       mov       edx,72
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,281E3FA8728
       mov       rcx,[rcx]
       mov       [rsp+28],rcx
       mov       rcx,rsi
       lea       r8,[rsp+40]
       lea       r9,[rsp+30]
       mov       [rsp+20],rbx
       mov       edx,4
       call      r12
M01_L00:
       nop
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
; Total bytes of code 224
```

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogStoredProcedureError_EazyLoggerExtensions_Benchmark()
       mov       [rsp+8],rcx
       mov       rcx,[rcx+190]
       mov       r8,[rsp+8]
       mov       r8,[r8+198]
       mov       rdx,229C9800C18
       mov       rdx,[rdx]
       mov       r9,229C9800C20
       mov       r9,[r9]
       jmp       qword ptr [7FFA977DB078]; DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions.LogStoredProcedureError(Microsoft.Extensions.Logging.ILogger, System.String, System.Exception, System.String)
; Total bytes of code 56
```
```assembly
; DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions.LogStoredProcedureError(Microsoft.Extensions.Logging.ILogger, System.String, System.Exception, System.String)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rax
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rbp,r9
       mov       rcx,rsi
       mov       r11,7FFA96F606A8
       mov       edx,4
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M01_L00
       mov       rcx,229C9800C28
       mov       r14,[rcx]
       mov       rcx,rsi
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log[[DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions+__LogStoredProcedureErrorStruct, dotNetTips.Spargine.6.Core]](Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, __LogStoredProcedureErrorStruct, System.Exception, System.Func`3<__LogStoredProcedureErrorStruct,System.Exception,System.String>)
       call      CORINFO_HELP_VIRTUAL_FUNC_PTR
       mov       r15,rax
       mov       [rsp+48],r14
       mov       dword ptr [rsp+50],1F6
       mov       [rsp+38],rdi
       mov       [rsp+40],rbp
       mov       rcx,7FFA973BA248
       mov       edx,84
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,229B7807780
       mov       rcx,[rcx]
       mov       [rsp+28],rcx
       mov       rcx,rsi
       lea       r8,[rsp+48]
       lea       r9,[rsp+38]
       mov       [rsp+20],rbx
       mov       edx,4
       call      r15
M01_L00:
       nop
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 220
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogStoredProcedureNoRecordsFound_EazyLoggerExtensions_Benchmark()
       mov       rcx,[rcx+190]
       mov       rdx,27F93CA1BD8
       mov       rdx,[rdx]
       mov       r8,27F93CA1BE0
       mov       r8,[r8]
       jmp       near ptr DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions.LogStoredProcedureNoRecordsFound(Microsoft.Extensions.Logging.ILogger, System.String, System.String)
; Total bytes of code 38
```
```assembly
; DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions.LogStoredProcedureNoRecordsFound(Microsoft.Extensions.Logging.ILogger, System.String, System.String)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rax
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rcx,rsi
       mov       r11,7FFA986A0710
       mov       edx,4
       call      qword ptr [7FFA986A0710]
       test      eax,eax
       je        near ptr M01_L00
       mov       ebp,25A
       mov       rcx,27F93CA1BE8
       mov       r14,[rcx]
       mov       rcx,rsi
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log[[DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions+__LogStoredProcedureNoRecordsFoundStruct, dotNetTips.Spargine.6.Core]](Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, __LogStoredProcedureNoRecordsFoundStruct, System.Exception, System.Func`3<__LogStoredProcedureNoRecordsFoundStruct,System.Exception,System.String>)
       call      CORINFO_HELP_VIRTUAL_FUNC_PTR
       mov       r15,rax
       mov       [rsp+48],r14
       mov       [rsp+50],ebp
       mov       [rsp+38],rdi
       mov       [rsp+40],rbx
       mov       rcx,7FFA98946A60
       mov       edx,73
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,27F33CA8730
       mov       rcx,[rcx]
       mov       [rsp+28],rcx
       mov       rcx,rsi
       lea       r8,[rsp+48]
       lea       r9,[rsp+38]
       mov       edx,4
       xor       eax,eax
       mov       [rsp+20],rax
       call      r15
M01_L00:
       nop
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 223
```

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogStoredProcedureNoRecordsFound_EazyLoggerExtensions_Benchmark()
       mov       rcx,[rcx+190]
       mov       rdx,27B8EC01C30
       mov       rdx,[rdx]
       mov       r8,27B8EC01C38
       mov       r8,[r8]
       jmp       qword ptr [7FFA977CB390]; DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions.LogStoredProcedureNoRecordsFound(Microsoft.Extensions.Logging.ILogger, System.String, System.String)
; Total bytes of code 39
```
```assembly
; DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions.LogStoredProcedureNoRecordsFound(Microsoft.Extensions.Logging.ILogger, System.String, System.String)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,50
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rcx,rsi
       mov       r11,7FFA96F50698
       mov       edx,4
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M01_L00
       mov       rcx,27B8EC01C40
       mov       rbp,[rcx]
       mov       rcx,rsi
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log[[DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions+__LogStoredProcedureNoRecordsFoundStruct, dotNetTips.Spargine.6.Core]](Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, __LogStoredProcedureNoRecordsFoundStruct, System.Exception, System.Func`3<__LogStoredProcedureNoRecordsFoundStruct,System.Exception,System.String>)
       call      CORINFO_HELP_VIRTUAL_FUNC_PTR
       mov       r14,rax
       mov       [rsp+40],rbp
       mov       dword ptr [rsp+48],25A
       mov       [rsp+30],rdi
       mov       [rsp+38],rbx
       mov       rcx,7FFA973AA248
       mov       edx,85
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,27B92C07788
       mov       rcx,[rcx]
       mov       [rsp+28],rcx
       mov       rcx,rsi
       lea       r8,[rsp+40]
       lea       r9,[rsp+30]
       mov       edx,4
       xor       eax,eax
       mov       [rsp+20],rax
       call      r14
M01_L00:
       nop
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 209
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogTrace_EazyLoggerExtensions_Benchmark()
       mov       rcx,[rcx+190]
       mov       rdx,1DBC3A51BD8
       mov       rdx,[rdx]
       mov       r8,1DBC3A51BE0
       mov       r8,[r8]
       jmp       near ptr DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions.LogTraceMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.String)
; Total bytes of code 38
```
```assembly
; DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions.LogTraceMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.String)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rax
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rcx,rsi
       mov       r11,7FFA986B0710
       xor       edx,edx
       call      qword ptr [7FFA986B0710]
       test      eax,eax
       je        near ptr M01_L00
       mov       ebp,65
       mov       rcx,1DBC3A51BE8
       mov       r14,[rcx]
       mov       rcx,rsi
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log[[DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions+__LogTraceMessageStruct, dotNetTips.Spargine.6.Core]](Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, __LogTraceMessageStruct, System.Exception, System.Func`3<__LogTraceMessageStruct,System.Exception,System.String>)
       call      CORINFO_HELP_VIRTUAL_FUNC_PTR
       mov       r15,rax
       mov       [rsp+48],r14
       mov       [rsp+50],ebp
       mov       [rsp+38],rdi
       mov       [rsp+40],rbx
       mov       rcx,7FFA98956A60
       mov       edx,74
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1DB53A58738
       mov       rcx,[rcx]
       mov       [rsp+28],rcx
       mov       rcx,rsi
       lea       r8,[rsp+48]
       lea       r9,[rsp+38]
       xor       edx,edx
       xor       eax,eax
       mov       [rsp+20],rax
       call      r15
M01_L00:
       nop
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 217
```

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogTrace_EazyLoggerExtensions_Benchmark()
       mov       rcx,[rcx+190]
       mov       rdx,1B436000C18
       mov       rdx,[rdx]
       mov       r8,1B436000C20
       mov       r8,[r8]
       jmp       qword ptr [7FFA9780B0A8]; DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions.LogTraceMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.String)
; Total bytes of code 39
```
```assembly
; DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions.LogTraceMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.String)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,50
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rcx,rsi
       mov       r11,7FFA96F90698
       xor       edx,edx
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M01_L00
       mov       rcx,1B436000C28
       mov       rbp,[rcx]
       mov       rcx,rsi
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log[[DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions+__LogTraceMessageStruct, dotNetTips.Spargine.6.Core]](Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, __LogTraceMessageStruct, System.Exception, System.Func`3<__LogTraceMessageStruct,System.Exception,System.String>)
       call      CORINFO_HELP_VIRTUAL_FUNC_PTR
       mov       r14,rax
       mov       [rsp+40],rbp
       mov       dword ptr [rsp+48],65
       mov       [rsp+30],rdi
       mov       [rsp+38],rbx
       mov       rcx,7FFA973EA248
       mov       edx,86
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1B424007790
       mov       rcx,[rcx]
       mov       [rsp+28],rcx
       mov       rcx,rsi
       lea       r8,[rsp+40]
       lea       r9,[rsp+30]
       xor       edx,edx
       xor       eax,eax
       mov       [rsp+20],rax
       call      r14
M01_L00:
       nop
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 203
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogWarning_EazyLoggerExtensions_Benchmark()
       mov       rcx,[rcx+190]
       mov       rdx,19B42371BD8
       mov       rdx,[rdx]
       mov       r8,19B42371BE0
       mov       r8,[r8]
       jmp       near ptr DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions.LogWarningMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.String)
; Total bytes of code 38
```
```assembly
; DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions.LogWarningMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.String)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rax
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rcx,rsi
       mov       r11,7FFA986A0770
       mov       edx,3
       call      qword ptr [7FFA986A0770]
       test      eax,eax
       je        near ptr M01_L00
       mov       ebp,259
       mov       rcx,19B42371BE8
       mov       r14,[rcx]
       mov       rcx,rsi
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log[[DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions+__LogWarningMessageStruct, dotNetTips.Spargine.6.Core]](Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, __LogWarningMessageStruct, System.Exception, System.Func`3<__LogWarningMessageStruct,System.Exception,System.String>)
       call      CORINFO_HELP_VIRTUAL_FUNC_PTR
       mov       r15,rax
       mov       [rsp+48],r14
       mov       [rsp+50],ebp
       mov       [rsp+38],rdi
       mov       [rsp+40],rbx
       mov       rcx,7FFA98946A60
       mov       edx,75
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,19AB2378740
       mov       rcx,[rcx]
       mov       [rsp+28],rcx
       mov       rcx,rsi
       lea       r8,[rsp+48]
       lea       r9,[rsp+38]
       mov       edx,3
       xor       eax,eax
       mov       [rsp+20],rax
       call      r15
M01_L00:
       nop
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 223
```

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogWarning_EazyLoggerExtensions_Benchmark()
       mov       rcx,[rcx+190]
       mov       rdx,27128401C30
       mov       rdx,[rdx]
       mov       r8,27128401C38
       mov       r8,[r8]
       jmp       qword ptr [7FFA977ED0C0]; DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions.LogWarningMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.String)
; Total bytes of code 39
```
```assembly
; DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions.LogWarningMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.String)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,50
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rcx,rsi
       mov       r11,7FFA96F706A8
       mov       edx,3
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M01_L00
       mov       rcx,27128401C40
       mov       rbp,[rcx]
       mov       rcx,rsi
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log[[DotNetTips.Spargine.Core.Logging.EasyLoggerExtentions+__LogWarningMessageStruct, dotNetTips.Spargine.6.Core]](Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, __LogWarningMessageStruct, System.Exception, System.Func`3<__LogWarningMessageStruct,System.Exception,System.String>)
       call      CORINFO_HELP_VIRTUAL_FUNC_PTR
       mov       r14,rax
       mov       [rsp+40],rbp
       mov       dword ptr [rsp+48],259
       mov       [rsp+30],rdi
       mov       [rsp+38],rbx
       mov       rcx,7FFA973CA248
       mov       edx,87
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,2711C4057A0
       mov       rcx,[rcx]
       mov       [rsp+28],rcx
       mov       rcx,rsi
       lea       r8,[rsp+40]
       lea       r9,[rsp+30]
       mov       edx,3
       xor       eax,eax
       mov       [rsp+20],rax
       call      r14
M01_L00:
       nop
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 209
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogCritical_ILogger_Benchmark()
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+38],rax
       mov       r8,[rcx+190]
       xor       r9d,r9d
       mov       edx,64
       mov       rax,[rcx+198]
       mov       rcx,2A969DB2F48
       mov       rcx,[rcx]
       mov       [rsp+38],r9
       mov       [rsp+40],edx
       mov       r9,2A969DC2768
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       [rsp+28],rcx
       mov       rcx,r8
       lea       r8,[rsp+38]
       mov       r9,rax
       mov       edx,5
       call      Microsoft.Extensions.Logging.LoggerExtensions.Log(Microsoft.Extensions.Logging.ILogger, Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.Exception, System.String, System.Object[])
       nop
       add       rsp,48
       ret
; Total bytes of code 105
```
```assembly
; Microsoft.Extensions.Logging.LoggerExtensions.Log(Microsoft.Extensions.Logging.ILogger, Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.Exception, System.String, System.Object[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       mov       [rsp+60],rax
       mov       rdi,rcx
       mov       ebp,edx
       mov       rsi,r8
       mov       rbx,r9
       test      rdi,rdi
       je        near ptr M01_L00
       lea       rcx,[rsp+50]
       mov       rdx,[rsp+0B0]
       mov       r8,[rsp+0B8]
       call      Microsoft.Extensions.Logging.FormattedLogValues..ctor(System.String, System.Object[])
       mov       rcx,rdi
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log[[Microsoft.Extensions.Logging.FormattedLogValues, Microsoft.Extensions.Logging.Abstractions]](Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, Microsoft.Extensions.Logging.FormattedLogValues, System.Exception, System.Func`3<Microsoft.Extensions.Logging.FormattedLogValues,System.Exception,System.String>)
       call      CORINFO_HELP_VIRTUAL_FUNC_PTR
       mov       rcx,rdi
       mov       edx,ebp
       mov       r8,rsi
       mov       r9,[rsp+50]
       mov       [rsp+38],r9
       mov       r9,[rsp+58]
       mov       [rsp+40],r9
       mov       r9,[rsp+60]
       mov       [rsp+48],r9
       mov       [rsp+20],rbx
       mov       r9,2A969DB8D90
       mov       r9,[r9]
       mov       [rsp+28],r9
       lea       r9,[rsp+38]
       call      rax
       nop
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L00:
       mov       ecx,191
       mov       rdx,7FFA98ABBEE0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.ThrowHelper.Throw(System.String)
       int       3
; Total bytes of code 217
```

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogCritical_ILogger_Benchmark()
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+38],rax
       mov       r8,[rcx+190]
       mov       r9,[rcx+198]
       mov       rcx,r8
       xor       r8d,r8d
       mov       [rsp+38],r8
       mov       dword ptr [rsp+40],64
       mov       r8,22340000C18
       mov       r8,[r8]
       mov       [rsp+20],r8
       mov       r8,22332001F78
       mov       r8,[r8]
       mov       [rsp+28],r8
       lea       r8,[rsp+38]
       mov       edx,5
       call      qword ptr [7FFA977CB6F0]; Microsoft.Extensions.Logging.LoggerExtensions.Log(Microsoft.Extensions.Logging.ILogger, Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.Exception, System.String, System.Object[])
       nop
       add       rsp,48
       ret
; Total bytes of code 102
```
```assembly
; Microsoft.Extensions.Logging.LoggerExtensions.Log(Microsoft.Extensions.Logging.ILogger, Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.Exception, System.String, System.Object[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       mov       [rsp+60],rax
       mov       rdi,rcx
       mov       ebp,edx
       mov       rsi,r8
       mov       rbx,r9
       test      rdi,rdi
       je        near ptr M01_L00
       lea       rcx,[rsp+50]
       mov       rdx,[rsp+0B0]
       mov       r8,[rsp+0B8]
       call      qword ptr [7FFA977CB768]; Microsoft.Extensions.Logging.FormattedLogValues..ctor(System.String, System.Object[])
       mov       rcx,rdi
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log[[Microsoft.Extensions.Logging.FormattedLogValues, Microsoft.Extensions.Logging.Abstractions]](Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, Microsoft.Extensions.Logging.FormattedLogValues, System.Exception, System.Func`3<Microsoft.Extensions.Logging.FormattedLogValues,System.Exception,System.String>)
       call      CORINFO_HELP_VIRTUAL_FUNC_PTR
       mov       rcx,rdi
       mov       edx,ebp
       mov       r8,rsi
       mov       r9,[rsp+50]
       mov       [rsp+38],r9
       mov       r9,[rsp+58]
       mov       [rsp+40],r9
       mov       r9,[rsp+60]
       mov       [rsp+48],r9
       mov       [rsp+20],rbx
       mov       r9,2232E006008
       mov       r9,[r9]
       mov       [rsp+28],r9
       lea       r9,[rsp+38]
       call      rax
       nop
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L00:
       mov       ecx,191
       mov       rdx,7FFA975126E0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFA977753D8]
       int       3
; Total bytes of code 219
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogDebug_ILogger_Benchmark()
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+38],rax
       mov       r8,[rcx+190]
       xor       r9d,r9d
       mov       edx,64
       mov       rax,[rcx+198]
       mov       rcx,1D301F52F48
       mov       rcx,[rcx]
       mov       [rsp+38],r9
       mov       [rsp+40],edx
       mov       r9,1D371F51BD8
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       [rsp+28],rcx
       mov       rcx,r8
       lea       r8,[rsp+38]
       mov       r9,rax
       mov       edx,1
       call      Microsoft.Extensions.Logging.LoggerExtensions.Log(Microsoft.Extensions.Logging.ILogger, Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.Exception, System.String, System.Object[])
       nop
       add       rsp,48
       ret
; Total bytes of code 105
```
```assembly
; Microsoft.Extensions.Logging.LoggerExtensions.Log(Microsoft.Extensions.Logging.ILogger, Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.Exception, System.String, System.Object[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       mov       [rsp+60],rax
       mov       rdi,rcx
       mov       ebp,edx
       mov       rsi,r8
       mov       rbx,r9
       test      rdi,rdi
       je        near ptr M01_L00
       lea       rcx,[rsp+50]
       mov       rdx,[rsp+0B0]
       mov       r8,[rsp+0B8]
       call      Microsoft.Extensions.Logging.FormattedLogValues..ctor(System.String, System.Object[])
       mov       rcx,rdi
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log[[Microsoft.Extensions.Logging.FormattedLogValues, Microsoft.Extensions.Logging.Abstractions]](Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, Microsoft.Extensions.Logging.FormattedLogValues, System.Exception, System.Func`3<Microsoft.Extensions.Logging.FormattedLogValues,System.Exception,System.String>)
       call      CORINFO_HELP_VIRTUAL_FUNC_PTR
       mov       rcx,rdi
       mov       edx,ebp
       mov       r8,rsi
       mov       r9,[rsp+50]
       mov       [rsp+38],r9
       mov       r9,[rsp+58]
       mov       [rsp+40],r9
       mov       r9,[rsp+60]
       mov       [rsp+48],r9
       mov       [rsp+20],rbx
       mov       r9,1D301F58D90
       mov       r9,[r9]
       mov       [rsp+28],r9
       lea       r9,[rsp+38]
       call      rax
       nop
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L00:
       mov       ecx,191
       mov       rdx,7FFA98ABBEE0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.ThrowHelper.Throw(System.String)
       int       3
; Total bytes of code 217
```

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogDebug_ILogger_Benchmark()
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+38],rax
       mov       r8,[rcx+190]
       mov       r9,[rcx+198]
       mov       rcx,r8
       xor       r8d,r8d
       mov       [rsp+38],r8
       mov       dword ptr [rsp+40],64
       mov       r8,1F9DCC02C10
       mov       r8,[r8]
       mov       [rsp+20],r8
       mov       r8,1F9DCC01F78
       mov       r8,[r8]
       mov       [rsp+28],r8
       lea       r8,[rsp+38]
       mov       edx,1
       call      qword ptr [7FFA977DF3D8]; Microsoft.Extensions.Logging.LoggerExtensions.Log(Microsoft.Extensions.Logging.ILogger, Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.Exception, System.String, System.Object[])
       nop
       add       rsp,48
       ret
; Total bytes of code 102
```
```assembly
; Microsoft.Extensions.Logging.LoggerExtensions.Log(Microsoft.Extensions.Logging.ILogger, Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.Exception, System.String, System.Object[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       mov       [rsp+60],rax
       mov       rdi,rcx
       mov       ebp,edx
       mov       rsi,r8
       mov       rbx,r9
       test      rdi,rdi
       je        near ptr M01_L00
       lea       rcx,[rsp+50]
       mov       rdx,[rsp+0B0]
       mov       r8,[rsp+0B8]
       call      qword ptr [7FFA977DF450]; Microsoft.Extensions.Logging.FormattedLogValues..ctor(System.String, System.Object[])
       mov       rcx,rdi
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log[[Microsoft.Extensions.Logging.FormattedLogValues, Microsoft.Extensions.Logging.Abstractions]](Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, Microsoft.Extensions.Logging.FormattedLogValues, System.Exception, System.Func`3<Microsoft.Extensions.Logging.FormattedLogValues,System.Exception,System.String>)
       call      CORINFO_HELP_VIRTUAL_FUNC_PTR
       mov       rcx,rdi
       mov       edx,ebp
       mov       r8,rsi
       mov       r9,[rsp+50]
       mov       [rsp+38],r9
       mov       r9,[rsp+58]
       mov       [rsp+40],r9
       mov       r9,[rsp+60]
       mov       [rsp+48],r9
       mov       [rsp+20],rbx
       mov       r9,1F9D8C06008
       mov       r9,[r9]
       mov       [rsp+28],r9
       lea       r9,[rsp+38]
       call      rax
       nop
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L00:
       mov       ecx,191
       mov       rdx,7FFA975226E0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFA97787FA8]
       int       3
; Total bytes of code 219
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogError_ILogger_Benchmark()
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+38],rax
       mov       r8,[rcx+190]
       xor       r9d,r9d
       mov       edx,64
       mov       rax,[rcx+198]
       mov       rcx,225EE7A2F48
       mov       rcx,[rcx]
       mov       [rsp+38],r9
       mov       [rsp+40],edx
       mov       r9,2264E7A1BD8
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       [rsp+28],rcx
       mov       rcx,r8
       lea       r8,[rsp+38]
       mov       r9,rax
       mov       edx,4
       call      Microsoft.Extensions.Logging.LoggerExtensions.Log(Microsoft.Extensions.Logging.ILogger, Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.Exception, System.String, System.Object[])
       nop
       add       rsp,48
       ret
; Total bytes of code 105
```
```assembly
; Microsoft.Extensions.Logging.LoggerExtensions.Log(Microsoft.Extensions.Logging.ILogger, Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.Exception, System.String, System.Object[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       mov       [rsp+60],rax
       mov       rdi,rcx
       mov       ebp,edx
       mov       rsi,r8
       mov       rbx,r9
       test      rdi,rdi
       je        near ptr M01_L00
       lea       rcx,[rsp+50]
       mov       rdx,[rsp+0B0]
       mov       r8,[rsp+0B8]
       call      Microsoft.Extensions.Logging.FormattedLogValues..ctor(System.String, System.Object[])
       mov       rcx,rdi
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log[[Microsoft.Extensions.Logging.FormattedLogValues, Microsoft.Extensions.Logging.Abstractions]](Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, Microsoft.Extensions.Logging.FormattedLogValues, System.Exception, System.Func`3<Microsoft.Extensions.Logging.FormattedLogValues,System.Exception,System.String>)
       call      CORINFO_HELP_VIRTUAL_FUNC_PTR
       mov       rcx,rdi
       mov       edx,ebp
       mov       r8,rsi
       mov       r9,[rsp+50]
       mov       [rsp+38],r9
       mov       r9,[rsp+58]
       mov       [rsp+40],r9
       mov       r9,[rsp+60]
       mov       [rsp+48],r9
       mov       [rsp+20],rbx
       mov       r9,225EE7A8D90
       mov       r9,[r9]
       mov       [rsp+28],r9
       lea       r9,[rsp+38]
       call      rax
       nop
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L00:
       mov       ecx,191
       mov       rdx,7FFA98ACBEE0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.ThrowHelper.Throw(System.String)
       int       3
; Total bytes of code 217
```

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogError_ILogger_Benchmark()
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+38],rax
       mov       r8,[rcx+190]
       mov       r9,[rcx+198]
       mov       rcx,r8
       xor       r8d,r8d
       mov       [rsp+38],r8
       mov       dword ptr [rsp+40],64
       mov       r8,15578C00C18
       mov       r8,[r8]
       mov       [rsp+20],r8
       mov       r8,15566C01F78
       mov       r8,[r8]
       mov       [rsp+28],r8
       lea       r8,[rsp+38]
       mov       edx,4
       call      qword ptr [7FFA977EB6F0]; Microsoft.Extensions.Logging.LoggerExtensions.Log(Microsoft.Extensions.Logging.ILogger, Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.Exception, System.String, System.Object[])
       nop
       add       rsp,48
       ret
; Total bytes of code 102
```
```assembly
; Microsoft.Extensions.Logging.LoggerExtensions.Log(Microsoft.Extensions.Logging.ILogger, Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.Exception, System.String, System.Object[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       mov       [rsp+60],rax
       mov       rdi,rcx
       mov       ebp,edx
       mov       rsi,r8
       mov       rbx,r9
       test      rdi,rdi
       je        near ptr M01_L00
       lea       rcx,[rsp+50]
       mov       rdx,[rsp+0B0]
       mov       r8,[rsp+0B8]
       call      qword ptr [7FFA977EB768]; Microsoft.Extensions.Logging.FormattedLogValues..ctor(System.String, System.Object[])
       mov       rcx,rdi
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log[[Microsoft.Extensions.Logging.FormattedLogValues, Microsoft.Extensions.Logging.Abstractions]](Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, Microsoft.Extensions.Logging.FormattedLogValues, System.Exception, System.Func`3<Microsoft.Extensions.Logging.FormattedLogValues,System.Exception,System.String>)
       call      CORINFO_HELP_VIRTUAL_FUNC_PTR
       mov       rcx,rdi
       mov       edx,ebp
       mov       r8,rsi
       mov       r9,[rsp+50]
       mov       [rsp+38],r9
       mov       r9,[rsp+58]
       mov       [rsp+40],r9
       mov       r9,[rsp+60]
       mov       [rsp+48],r9
       mov       [rsp+20],rbx
       mov       r9,15566C08000
       mov       r9,[r9]
       mov       [rsp+28],r9
       lea       r9,[rsp+38]
       call      rax
       nop
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L00:
       mov       ecx,191
       mov       rdx,7FFA975326E0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFA977953D8]
       int       3
; Total bytes of code 219
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogInformation_ILogger_Benchmark()
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+38],rax
       mov       r8,[rcx+190]
       xor       r9d,r9d
       mov       edx,64
       mov       rax,[rcx+198]
       mov       rcx,2854D692F48
       mov       rcx,[rcx]
       mov       [rsp+38],r9
       mov       [rsp+40],edx
       mov       r9,2859D691BD8
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       [rsp+28],rcx
       mov       rcx,r8
       lea       r8,[rsp+38]
       mov       r9,rax
       mov       edx,2
       call      Microsoft.Extensions.Logging.LoggerExtensions.Log(Microsoft.Extensions.Logging.ILogger, Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.Exception, System.String, System.Object[])
       nop
       add       rsp,48
       ret
; Total bytes of code 105
```
```assembly
; Microsoft.Extensions.Logging.LoggerExtensions.Log(Microsoft.Extensions.Logging.ILogger, Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.Exception, System.String, System.Object[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       mov       [rsp+60],rax
       mov       rdi,rcx
       mov       ebp,edx
       mov       rsi,r8
       mov       rbx,r9
       test      rdi,rdi
       je        near ptr M01_L00
       lea       rcx,[rsp+50]
       mov       rdx,[rsp+0B0]
       mov       r8,[rsp+0B8]
       call      Microsoft.Extensions.Logging.FormattedLogValues..ctor(System.String, System.Object[])
       mov       rcx,rdi
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log[[Microsoft.Extensions.Logging.FormattedLogValues, Microsoft.Extensions.Logging.Abstractions]](Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, Microsoft.Extensions.Logging.FormattedLogValues, System.Exception, System.Func`3<Microsoft.Extensions.Logging.FormattedLogValues,System.Exception,System.String>)
       call      CORINFO_HELP_VIRTUAL_FUNC_PTR
       mov       rcx,rdi
       mov       edx,ebp
       mov       r8,rsi
       mov       r9,[rsp+50]
       mov       [rsp+38],r9
       mov       r9,[rsp+58]
       mov       [rsp+40],r9
       mov       r9,[rsp+60]
       mov       [rsp+48],r9
       mov       [rsp+20],rbx
       mov       r9,2854D698D90
       mov       r9,[r9]
       mov       [rsp+28],r9
       lea       r9,[rsp+38]
       call      rax
       nop
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L00:
       mov       ecx,191
       mov       rdx,7FFA98ADBEE0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.ThrowHelper.Throw(System.String)
       int       3
; Total bytes of code 217
```

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogInformation_ILogger_Benchmark()
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+38],rax
       mov       r8,[rcx+190]
       mov       r9,[rcx+198]
       mov       rcx,r8
       xor       r8d,r8d
       mov       [rsp+38],r8
       mov       dword ptr [rsp+40],64
       mov       r8,182BC4117A8
       mov       r8,[r8]
       mov       [rsp+20],r8
       mov       r8,182BC401F78
       mov       r8,[r8]
       mov       [rsp+28],r8
       lea       r8,[rsp+38]
       mov       edx,2
       call      qword ptr [7FFA977DD3F0]; Microsoft.Extensions.Logging.LoggerExtensions.Log(Microsoft.Extensions.Logging.ILogger, Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.Exception, System.String, System.Object[])
       nop
       add       rsp,48
       ret
; Total bytes of code 102
```
```assembly
; Microsoft.Extensions.Logging.LoggerExtensions.Log(Microsoft.Extensions.Logging.ILogger, Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.Exception, System.String, System.Object[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       mov       [rsp+60],rax
       mov       rdi,rcx
       mov       ebp,edx
       mov       rsi,r8
       mov       rbx,r9
       test      rdi,rdi
       je        near ptr M01_L00
       lea       rcx,[rsp+50]
       mov       rdx,[rsp+0B0]
       mov       r8,[rsp+0B8]
       call      qword ptr [7FFA977DD468]; Microsoft.Extensions.Logging.FormattedLogValues..ctor(System.String, System.Object[])
       mov       rcx,rdi
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log[[Microsoft.Extensions.Logging.FormattedLogValues, Microsoft.Extensions.Logging.Abstractions]](Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, Microsoft.Extensions.Logging.FormattedLogValues, System.Exception, System.Func`3<Microsoft.Extensions.Logging.FormattedLogValues,System.Exception,System.String>)
       call      CORINFO_HELP_VIRTUAL_FUNC_PTR
       mov       rcx,rdi
       mov       edx,ebp
       mov       r8,rsi
       mov       r9,[rsp+50]
       mov       [rsp+38],r9
       mov       r9,[rsp+58]
       mov       [rsp+40],r9
       mov       r9,[rsp+60]
       mov       [rsp+48],r9
       mov       [rsp+20],rbx
       mov       r9,182BC408000
       mov       r9,[r9]
       mov       [rsp+28],r9
       lea       r9,[rsp+38]
       call      rax
       nop
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L00:
       mov       ecx,191
       mov       rdx,7FFA975226E0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFA97785FA8]
       int       3
; Total bytes of code 219
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogTrace_ILogger_Benchmark()
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+38],rax
       mov       r8,[rcx+190]
       xor       r9d,r9d
       mov       edx,64
       mov       rax,[rcx+198]
       mov       rcx,1DEA1502F48
       mov       rcx,[rcx]
       mov       [rsp+38],r9
       mov       [rsp+40],edx
       mov       r9,1DF01501BD8
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       [rsp+28],rcx
       mov       rcx,r8
       lea       r8,[rsp+38]
       mov       r9,rax
       xor       edx,edx
       call      Microsoft.Extensions.Logging.LoggerExtensions.Log(Microsoft.Extensions.Logging.ILogger, Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.Exception, System.String, System.Object[])
       nop
       add       rsp,48
       ret
; Total bytes of code 102
```
```assembly
; Microsoft.Extensions.Logging.LoggerExtensions.Log(Microsoft.Extensions.Logging.ILogger, Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.Exception, System.String, System.Object[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       mov       [rsp+60],rax
       mov       rdi,rcx
       mov       ebp,edx
       mov       rsi,r8
       mov       rbx,r9
       test      rdi,rdi
       je        near ptr M01_L00
       lea       rcx,[rsp+50]
       mov       rdx,[rsp+0B0]
       mov       r8,[rsp+0B8]
       call      Microsoft.Extensions.Logging.FormattedLogValues..ctor(System.String, System.Object[])
       mov       rcx,rdi
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log[[Microsoft.Extensions.Logging.FormattedLogValues, Microsoft.Extensions.Logging.Abstractions]](Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, Microsoft.Extensions.Logging.FormattedLogValues, System.Exception, System.Func`3<Microsoft.Extensions.Logging.FormattedLogValues,System.Exception,System.String>)
       call      CORINFO_HELP_VIRTUAL_FUNC_PTR
       mov       rcx,rdi
       mov       edx,ebp
       mov       r8,rsi
       mov       r9,[rsp+50]
       mov       [rsp+38],r9
       mov       r9,[rsp+58]
       mov       [rsp+40],r9
       mov       r9,[rsp+60]
       mov       [rsp+48],r9
       mov       [rsp+20],rbx
       mov       r9,1DEA1508D90
       mov       r9,[r9]
       mov       [rsp+28],r9
       lea       r9,[rsp+38]
       call      rax
       nop
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L00:
       mov       ecx,191
       mov       rdx,7FFA98ADBEE0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.ThrowHelper.Throw(System.String)
       int       3
; Total bytes of code 217
```

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogTrace_ILogger_Benchmark()
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+38],rax
       mov       r8,[rcx+190]
       mov       r9,[rcx+198]
       mov       rcx,r8
       xor       r8d,r8d
       mov       [rsp+38],r8
       mov       dword ptr [rsp+40],64
       mov       r8,2BA23800C18
       mov       r8,[r8]
       mov       [rsp+20],r8
       mov       r8,2BA13801F78
       mov       r8,[r8]
       mov       [rsp+28],r8
       lea       r8,[rsp+38]
       xor       edx,edx
       call      qword ptr [7FFA977CB6F0]; Microsoft.Extensions.Logging.LoggerExtensions.Log(Microsoft.Extensions.Logging.ILogger, Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.Exception, System.String, System.Object[])
       nop
       add       rsp,48
       ret
; Total bytes of code 99
```
```assembly
; Microsoft.Extensions.Logging.LoggerExtensions.Log(Microsoft.Extensions.Logging.ILogger, Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.Exception, System.String, System.Object[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       mov       [rsp+60],rax
       mov       rdi,rcx
       mov       ebp,edx
       mov       rsi,r8
       mov       rbx,r9
       test      rdi,rdi
       je        near ptr M01_L00
       lea       rcx,[rsp+50]
       mov       rdx,[rsp+0B0]
       mov       r8,[rsp+0B8]
       call      qword ptr [7FFA977CB768]; Microsoft.Extensions.Logging.FormattedLogValues..ctor(System.String, System.Object[])
       mov       rcx,rdi
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log[[Microsoft.Extensions.Logging.FormattedLogValues, Microsoft.Extensions.Logging.Abstractions]](Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, Microsoft.Extensions.Logging.FormattedLogValues, System.Exception, System.Func`3<Microsoft.Extensions.Logging.FormattedLogValues,System.Exception,System.String>)
       call      CORINFO_HELP_VIRTUAL_FUNC_PTR
       mov       rcx,rdi
       mov       edx,ebp
       mov       r8,rsi
       mov       r9,[rsp+50]
       mov       [rsp+38],r9
       mov       r9,[rsp+58]
       mov       [rsp+40],r9
       mov       r9,[rsp+60]
       mov       [rsp+48],r9
       mov       [rsp+20],rbx
       mov       r9,2BA13808000
       mov       r9,[r9]
       mov       [rsp+28],r9
       lea       r9,[rsp+38]
       call      rax
       nop
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L00:
       mov       ecx,191
       mov       rdx,7FFA975126E0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFA977753D8]
       int       3
; Total bytes of code 219
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogWarning_ILogger_Benchmark()
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+38],rax
       mov       r8,[rcx+190]
       xor       r9d,r9d
       mov       edx,64
       mov       rax,[rcx+198]
       mov       rcx,22072132F48
       mov       rcx,[rcx]
       mov       [rsp+38],r9
       mov       [rsp+40],edx
       mov       r9,22072143780
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       [rsp+28],rcx
       mov       rcx,r8
       lea       r8,[rsp+38]
       mov       r9,rax
       mov       edx,3
       call      Microsoft.Extensions.Logging.LoggerExtensions.Log(Microsoft.Extensions.Logging.ILogger, Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.Exception, System.String, System.Object[])
       nop
       add       rsp,48
       ret
; Total bytes of code 105
```
```assembly
; Microsoft.Extensions.Logging.LoggerExtensions.Log(Microsoft.Extensions.Logging.ILogger, Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.Exception, System.String, System.Object[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       mov       [rsp+60],rax
       mov       rdi,rcx
       mov       ebp,edx
       mov       rsi,r8
       mov       rbx,r9
       test      rdi,rdi
       je        near ptr M01_L00
       lea       rcx,[rsp+50]
       mov       rdx,[rsp+0B0]
       mov       r8,[rsp+0B8]
       call      Microsoft.Extensions.Logging.FormattedLogValues..ctor(System.String, System.Object[])
       mov       rcx,rdi
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log[[Microsoft.Extensions.Logging.FormattedLogValues, Microsoft.Extensions.Logging.Abstractions]](Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, Microsoft.Extensions.Logging.FormattedLogValues, System.Exception, System.Func`3<Microsoft.Extensions.Logging.FormattedLogValues,System.Exception,System.String>)
       call      CORINFO_HELP_VIRTUAL_FUNC_PTR
       mov       rcx,rdi
       mov       edx,ebp
       mov       r8,rsi
       mov       r9,[rsp+50]
       mov       [rsp+38],r9
       mov       r9,[rsp+58]
       mov       [rsp+40],r9
       mov       r9,[rsp+60]
       mov       [rsp+48],r9
       mov       [rsp+20],rbx
       mov       r9,22072138D90
       mov       r9,[r9]
       mov       [rsp+28],r9
       lea       r9,[rsp+38]
       call      rax
       nop
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L00:
       mov       ecx,191
       mov       rdx,7FFA98AABEE0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.ThrowHelper.Throw(System.String)
       int       3
; Total bytes of code 217
```

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogWarning_ILogger_Benchmark()
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+38],rax
       mov       r8,[rcx+190]
       mov       r9,[rcx+198]
       mov       rcx,r8
       xor       r8d,r8d
       mov       [rsp+38],r8
       mov       dword ptr [rsp+40],64
       mov       r8,251A1401C30
       mov       r8,[r8]
       mov       [rsp+20],r8
       mov       r8,2519F401F78
       mov       r8,[r8]
       mov       [rsp+28],r8
       lea       r8,[rsp+38]
       mov       edx,3
       call      qword ptr [7FFA977DDF48]; Microsoft.Extensions.Logging.LoggerExtensions.Log(Microsoft.Extensions.Logging.ILogger, Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.Exception, System.String, System.Object[])
       nop
       add       rsp,48
       ret
; Total bytes of code 102
```
```assembly
; Microsoft.Extensions.Logging.LoggerExtensions.Log(Microsoft.Extensions.Logging.ILogger, Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.Exception, System.String, System.Object[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       mov       [rsp+60],rax
       mov       rdi,rcx
       mov       ebp,edx
       mov       rsi,r8
       mov       rbx,r9
       test      rdi,rdi
       je        near ptr M01_L00
       lea       rcx,[rsp+50]
       mov       rdx,[rsp+0B0]
       mov       r8,[rsp+0B8]
       call      qword ptr [7FFA977DF018]; Microsoft.Extensions.Logging.FormattedLogValues..ctor(System.String, System.Object[])
       mov       rcx,rdi
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log[[Microsoft.Extensions.Logging.FormattedLogValues, Microsoft.Extensions.Logging.Abstractions]](Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, Microsoft.Extensions.Logging.FormattedLogValues, System.Exception, System.Func`3<Microsoft.Extensions.Logging.FormattedLogValues,System.Exception,System.String>)
       call      CORINFO_HELP_VIRTUAL_FUNC_PTR
       mov       rcx,rdi
       mov       edx,ebp
       mov       r8,rsi
       mov       r9,[rsp+50]
       mov       [rsp+38],r9
       mov       r9,[rsp+58]
       mov       [rsp+40],r9
       mov       r9,[rsp+60]
       mov       [rsp+48],r9
       mov       [rsp+20],rbx
       mov       r9,2519F408000
       mov       r9,[r9]
       mov       [rsp+28],r9
       lea       r9,[rsp+38]
       call      rax
       nop
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L00:
       mov       ecx,191
       mov       rdx,7FFA975226E0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFA977893D8]
       int       3
; Total bytes of code 219
```
