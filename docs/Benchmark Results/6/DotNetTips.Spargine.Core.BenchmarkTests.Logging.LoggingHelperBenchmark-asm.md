## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingHelperBenchmark.LogEasyCriticalBenchmark()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
; 			var testException = new ArgumentInvalidException("TEST EX MESSAGE");
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentInvalidException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+70],0E0434352
       mov       dword ptr [rdi+74],80131500
       mov       rdx,22BC6BE77B0
       mov       rdx,[rdx]
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rdi+74],80131501
       mov       dword ptr [rdi+74],80070057
; 			for (var index = 0; index < this.Count; index++)
; 			     ^^^^^^^^^^^^^
       xor       ebx,ebx
       cmp       dword ptr [rsi+0A8],0
       jle       short M00_L02
; 				EasyLogger.LogCritical(this._logger, "CRITICAL ENTRY", testException);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M00_L00:
       mov       rbp,[rsi+0B0]
       mov       rcx,rbp
       mov       r11,7FFE642704A0
       mov       edx,5
       call      qword ptr [7FFE646004A0]
       test      eax,eax
       je        short M00_L01
       mov       rcx,7FFE646786F8
       mov       edx,35
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,22BC6BE6798
       mov       rax,[rcx]
       mov       rcx,[rax+8]
       mov       r8,22BC6BE77B8
       mov       r8,[r8]
       mov       rdx,rbp
       mov       r9,rdi
       call      qword ptr [rax+18]
M00_L01:
       inc       ebx
       cmp       ebx,[rsi+0A8]
       jl        short M00_L00
M00_L02:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 203
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingHelperBenchmark.LogEasyCriticalBenchmark()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
; 			var testException = new ArgumentInvalidException("TEST EX MESSAGE");
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentInvalidException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+70],0E0434352
       mov       dword ptr [rdi+74],80131500
       mov       rdx,1E6B0123010
       mov       rdx,[rdx]
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rdi+74],80131501
       mov       dword ptr [rdi+74],80070057
; 			for (var index = 0; index < this.Count; index++)
; 			     ^^^^^^^^^^^^^
       xor       ebx,ebx
       cmp       dword ptr [rsi+0A8],0
       jle       short M00_L02
; 				EasyLogger.LogCritical(this._logger, "CRITICAL ENTRY", testException);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M00_L00:
       mov       rbp,[rsi+0B0]
       mov       rcx,rbp
       mov       r11,7FFE642704A0
       mov       edx,5
       call      qword ptr [7FFE646004A0]
       test      eax,eax
       je        short M00_L01
       mov       rcx,7FFE646786F8
       mov       edx,35
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1E6D0128BA8
       mov       rax,[rcx]
       mov       rcx,[rax+8]
       mov       r8,1E6B0123018
       mov       r8,[r8]
       mov       rdx,rbp
       mov       r9,rdi
       call      qword ptr [rax+18]
M00_L01:
       inc       ebx
       cmp       ebx,[rsi+0A8]
       jl        short M00_L00
M00_L02:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 203
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingHelperBenchmark.LogEasyCriticalBenchmark()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
; 			var testException = new ArgumentInvalidException("TEST EX MESSAGE");
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentInvalidException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+70],0E0434352
       mov       dword ptr [rdi+74],80131500
       mov       rdx,1E71D7E27F8
       mov       rdx,[rdx]
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rdi+74],80131501
       mov       dword ptr [rdi+74],80070057
; 			for (var index = 0; index < this.Count; index++)
; 			     ^^^^^^^^^^^^^
       xor       ebx,ebx
       cmp       dword ptr [rsi+0A8],0
       jle       short M00_L02
; 				EasyLogger.LogCritical(this._logger, "CRITICAL ENTRY", testException);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M00_L00:
       mov       rbp,[rsi+0B0]
       mov       rcx,rbp
       mov       r11,7FFE642904A0
       mov       edx,5
       call      qword ptr [7FFE646204A0]
       test      eax,eax
       je        short M00_L01
       mov       rcx,7FFE646986F8
       mov       edx,35
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1E72D7E47A0
       mov       rax,[rcx]
       mov       rcx,[rax+8]
       mov       r8,1E71D7E2800
       mov       r8,[r8]
       mov       rdx,rbp
       mov       r9,rdi
       call      qword ptr [rax+18]
M00_L01:
       inc       ebx
       cmp       ebx,[rsi+0A8]
       jl        short M00_L00
M00_L02:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 203
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingHelperBenchmark.LogEasyCriticalBenchmark()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
; 			var testException = new ArgumentInvalidException("TEST EX MESSAGE");
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentInvalidException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+70],0E0434352
       mov       dword ptr [rdi+74],80131500
       mov       rdx,21D4AE98BE0
       mov       rdx,[rdx]
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rdi+74],80131501
       mov       dword ptr [rdi+74],80070057
; 			for (var index = 0; index < this.Count; index++)
; 			     ^^^^^^^^^^^^^
       xor       ebx,ebx
       cmp       dword ptr [rsi+0A8],0
       jle       short M00_L02
; 				EasyLogger.LogCritical(this._logger, "CRITICAL ENTRY", testException);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M00_L00:
       mov       rbp,[rsi+0B0]
       mov       rcx,rbp
       mov       r11,7FFE642904A0
       mov       edx,5
       call      qword ptr [7FFE646204A0]
       test      eax,eax
       je        short M00_L01
       mov       rcx,7FFE646986F8
       mov       edx,35
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,21D4AE96BB0
       mov       rax,[rcx]
       mov       rcx,[rax+8]
       mov       r8,21D4AE98BE8
       mov       r8,[r8]
       mov       rdx,rbp
       mov       r9,rdi
       call      qword ptr [rax+18]
M00_L01:
       inc       ebx
       cmp       ebx,[rsi+0A8]
       jl        short M00_L00
M00_L02:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 203
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingHelperBenchmark.LogEasyCriticalBenchmark()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
; 			var testException = new ArgumentInvalidException("TEST EX MESSAGE");
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentInvalidException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+70],0E0434352
       mov       dword ptr [rdi+74],80131500
       mov       rdx,1DC0F381FF8
       mov       rdx,[rdx]
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rdi+74],80131501
       mov       dword ptr [rdi+74],80070057
; 			for (var index = 0; index < this.Count; index++)
; 			     ^^^^^^^^^^^^^
       xor       ebx,ebx
       cmp       dword ptr [rsi+0A8],0
       jle       short M00_L02
; 				EasyLogger.LogCritical(this._logger, "CRITICAL ENTRY", testException);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M00_L00:
       mov       rbp,[rsi+0B0]
       mov       rcx,rbp
       mov       r11,7FFE642804A0
       mov       edx,5
       call      qword ptr [7FFE646104A0]
       test      eax,eax
       je        short M00_L01
       mov       rcx,7FFE646886F8
       mov       edx,35
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1DC2F388BA8
       mov       rax,[rcx]
       mov       rcx,[rax+8]
       mov       r8,1DC0F382000
       mov       r8,[r8]
       mov       rdx,rbp
       mov       r9,rdi
       call      qword ptr [rax+18]
M00_L01:
       inc       ebx
       cmp       ebx,[rsi+0A8]
       jl        short M00_L00
M00_L02:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 203
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingHelperBenchmark.LogEasyCriticalBenchmark()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
; 			var testException = new ArgumentInvalidException("TEST EX MESSAGE");
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentInvalidException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+70],0E0434352
       mov       dword ptr [rdi+74],80131500
       mov       rdx,290770057B8
       mov       rdx,[rdx]
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rdi+74],80131501
       mov       dword ptr [rdi+74],80070057
; 			for (var index = 0; index < this.Count; index++)
; 			     ^^^^^^^^^^^^^
       xor       ebx,ebx
       cmp       dword ptr [rsi+0A8],0
       jle       short M00_L02
; 				EasyLogger.LogCritical(this._logger, "CRITICAL ENTRY", testException);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M00_L00:
       mov       rbp,[rsi+0B0]
       mov       rcx,rbp
       mov       r11,7FFE642A04A0
       mov       edx,5
       call      qword ptr [7FFE646304A0]
       test      eax,eax
       je        short M00_L01
       mov       rcx,7FFE646A86F8
       mov       edx,35
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,290770047A0
       mov       rax,[rcx]
       mov       rcx,[rax+8]
       mov       r8,290770057C0
       mov       r8,[r8]
       mov       rdx,rbp
       mov       r9,rdi
       call      qword ptr [rax+18]
M00_L01:
       inc       ebx
       cmp       ebx,[rsi+0A8]
       jl        short M00_L00
M00_L02:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 203
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingHelperBenchmark.LogEasyCriticalBenchmark()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
; 			var testException = new ArgumentInvalidException("TEST EX MESSAGE");
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentInvalidException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+70],0E0434352
       mov       dword ptr [rdi+74],80131500
       mov       rdx,22DE4A43010
       mov       rdx,[rdx]
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rdi+74],80131501
       mov       dword ptr [rdi+74],80070057
; 			for (var index = 0; index < this.Count; index++)
; 			     ^^^^^^^^^^^^^
       xor       ebx,ebx
       cmp       dword ptr [rsi+0A8],0
       jle       short M00_L02
; 				EasyLogger.LogCritical(this._logger, "CRITICAL ENTRY", testException);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M00_L00:
       mov       rbp,[rsi+0B0]
       mov       rcx,rbp
       mov       r11,7FFE642604A0
       mov       edx,5
       call      qword ptr [7FFE645F04A0]
       test      eax,eax
       je        short M00_L01
       mov       rcx,7FFE646686F8
       mov       edx,35
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,22E04A48BA8
       mov       rax,[rcx]
       mov       rcx,[rax+8]
       mov       r8,22DE4A43018
       mov       r8,[r8]
       mov       rdx,rbp
       mov       r9,rdi
       call      qword ptr [rax+18]
M00_L01:
       inc       ebx
       cmp       ebx,[rsi+0A8]
       jl        short M00_L00
M00_L02:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 203
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingHelperBenchmark.LogEasyCriticalBenchmark()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
; 			var testException = new ArgumentInvalidException("TEST EX MESSAGE");
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentInvalidException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+70],0E0434352
       mov       dword ptr [rdi+74],80131500
       mov       rdx,1C3B583ABD8
       mov       rdx,[rdx]
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rdi+74],80131501
       mov       dword ptr [rdi+74],80070057
; 			for (var index = 0; index < this.Count; index++)
; 			     ^^^^^^^^^^^^^
       xor       ebx,ebx
       cmp       dword ptr [rsi+0A8],0
       jle       short M00_L02
; 				EasyLogger.LogCritical(this._logger, "CRITICAL ENTRY", testException);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M00_L00:
       mov       rbp,[rsi+0B0]
       mov       rcx,rbp
       mov       r11,7FFE642804A0
       mov       edx,5
       call      qword ptr [7FFE646104A0]
       test      eax,eax
       je        short M00_L01
       mov       rcx,7FFE646886F8
       mov       edx,35
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1C3B5838BA8
       mov       rax,[rcx]
       mov       rcx,[rax+8]
       mov       r8,1C3B583ABE0
       mov       r8,[r8]
       mov       rdx,rbp
       mov       r9,rdi
       call      qword ptr [rax+18]
M00_L01:
       inc       ebx
       cmp       ebx,[rsi+0A8]
       jl        short M00_L00
M00_L02:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 203
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingHelperBenchmark.LogEasyDebugBenchmark()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
; 			var testException = new ArgumentInvalidException("TEST EX MESSAGE");
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentInvalidException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+70],0E0434352
       mov       dword ptr [rdi+74],80131500
       mov       rdx,1C8E9133FF0
       mov       rdx,[rdx]
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rdi+74],80131501
       mov       dword ptr [rdi+74],80070057
; 			for (var index = 0; index < this.Count; index++)
; 			     ^^^^^^^^^^^^^
       xor       ebx,ebx
       cmp       dword ptr [rsi+0A8],0
       jle       short M00_L02
; 				EasyLogger.LogCritical(this._logger, "DEBUG ENTRY", testException);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M00_L00:
       mov       rbp,[rsi+0B0]
       mov       rcx,rbp
       mov       r11,7FFE642804A0
       mov       edx,5
       call      qword ptr [7FFE646104A0]
       test      eax,eax
       je        short M00_L01
       mov       rcx,7FFE646886F8
       mov       edx,35
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1C909136BB0
       mov       rax,[rcx]
       mov       rcx,[rax+8]
       mov       r8,1C8E9133FF8
       mov       r8,[r8]
       mov       rdx,rbp
       mov       r9,rdi
       call      qword ptr [rax+18]
M00_L01:
       inc       ebx
       cmp       ebx,[rsi+0A8]
       jl        short M00_L00
M00_L02:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 203
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingHelperBenchmark.LogEasyDebugBenchmark()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
; 			var testException = new ArgumentInvalidException("TEST EX MESSAGE");
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentInvalidException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+70],0E0434352
       mov       dword ptr [rdi+74],80131500
       mov       rdx,28E80ED1FF8
       mov       rdx,[rdx]
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rdi+74],80131501
       mov       dword ptr [rdi+74],80070057
; 			for (var index = 0; index < this.Count; index++)
; 			     ^^^^^^^^^^^^^
       xor       ebx,ebx
       cmp       dword ptr [rsi+0A8],0
       jle       short M00_L02
; 				EasyLogger.LogCritical(this._logger, "DEBUG ENTRY", testException);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M00_L00:
       mov       rbp,[rsi+0B0]
       mov       rcx,rbp
       mov       r11,7FFE642704A0
       mov       edx,5
       call      qword ptr [7FFE646004A0]
       test      eax,eax
       je        short M00_L01
       mov       rcx,7FFE646786F8
       mov       edx,35
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,28EA0ED8BA8
       mov       rax,[rcx]
       mov       rcx,[rax+8]
       mov       r8,28E80ED2000
       mov       r8,[r8]
       mov       rdx,rbp
       mov       r9,rdi
       call      qword ptr [rax+18]
M00_L01:
       inc       ebx
       cmp       ebx,[rsi+0A8]
       jl        short M00_L00
M00_L02:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 203
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingHelperBenchmark.LogEasyDebugBenchmark()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
; 			var testException = new ArgumentInvalidException("TEST EX MESSAGE");
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentInvalidException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+70],0E0434352
       mov       dword ptr [rdi+74],80131500
       mov       rdx,2412CE593F8
       mov       rdx,[rdx]
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rdi+74],80131501
       mov       dword ptr [rdi+74],80070057
; 			for (var index = 0; index < this.Count; index++)
; 			     ^^^^^^^^^^^^^
       xor       ebx,ebx
       cmp       dword ptr [rsi+0A8],0
       jle       short M00_L02
; 				EasyLogger.LogCritical(this._logger, "DEBUG ENTRY", testException);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M00_L00:
       mov       rbp,[rsi+0B0]
       mov       rcx,rbp
       mov       r11,7FFE642804A0
       mov       edx,5
       call      qword ptr [7FFE646104A0]
       test      eax,eax
       je        short M00_L01
       mov       rcx,7FFE646886F8
       mov       edx,35
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,2412CE56BB0
       mov       rax,[rcx]
       mov       rcx,[rax+8]
       mov       r8,2412CE59400
       mov       r8,[r8]
       mov       rdx,rbp
       mov       r9,rdi
       call      qword ptr [rax+18]
M00_L01:
       inc       ebx
       cmp       ebx,[rsi+0A8]
       jl        short M00_L00
M00_L02:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 203
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingHelperBenchmark.LogEasyDebugBenchmark()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
; 			var testException = new ArgumentInvalidException("TEST EX MESSAGE");
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentInvalidException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+70],0E0434352
       mov       dword ptr [rdi+74],80131500
       mov       rdx,22457167418
       mov       rdx,[rdx]
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rdi+74],80131501
       mov       dword ptr [rdi+74],80070057
; 			for (var index = 0; index < this.Count; index++)
; 			     ^^^^^^^^^^^^^
       xor       ebx,ebx
       cmp       dword ptr [rsi+0A8],0
       jle       short M00_L02
; 				EasyLogger.LogCritical(this._logger, "DEBUG ENTRY", testException);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M00_L00:
       mov       rbp,[rsi+0B0]
       mov       rcx,rbp
       mov       r11,7FFE642A04A0
       mov       edx,5
       call      qword ptr [7FFE646304A0]
       test      eax,eax
       je        short M00_L01
       mov       rcx,7FFE646A86F8
       mov       edx,35
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,224771647A0
       mov       rax,[rcx]
       mov       rcx,[rax+8]
       mov       r8,22457167420
       mov       r8,[r8]
       mov       rdx,rbp
       mov       r9,rdi
       call      qword ptr [rax+18]
M00_L01:
       inc       ebx
       cmp       ebx,[rsi+0A8]
       jl        short M00_L00
M00_L02:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 203
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingHelperBenchmark.LogEasyDebugBenchmark()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
; 			var testException = new ArgumentInvalidException("TEST EX MESSAGE");
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentInvalidException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+70],0E0434352
       mov       dword ptr [rdi+74],80131500
       mov       rdx,22496824408
       mov       rdx,[rdx]
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rdi+74],80131501
       mov       dword ptr [rdi+74],80070057
; 			for (var index = 0; index < this.Count; index++)
; 			     ^^^^^^^^^^^^^
       xor       ebx,ebx
       cmp       dword ptr [rsi+0A8],0
       jle       short M00_L02
; 				EasyLogger.LogCritical(this._logger, "DEBUG ENTRY", testException);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M00_L00:
       mov       rbp,[rsi+0B0]
       mov       rcx,rbp
       mov       r11,7FFE642804A0
       mov       edx,5
       call      qword ptr [7FFE646104A0]
       test      eax,eax
       je        short M00_L01
       mov       rcx,7FFE646886F8
       mov       edx,35
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,224C68247A0
       mov       rax,[rcx]
       mov       rcx,[rax+8]
       mov       r8,22496824410
       mov       r8,[r8]
       mov       rdx,rbp
       mov       r9,rdi
       call      qword ptr [rax+18]
M00_L01:
       inc       ebx
       cmp       ebx,[rsi+0A8]
       jl        short M00_L00
M00_L02:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 203
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingHelperBenchmark.LogEasyDebugBenchmark()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
; 			var testException = new ArgumentInvalidException("TEST EX MESSAGE");
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentInvalidException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+70],0E0434352
       mov       dword ptr [rdi+74],80131500
       mov       rdx,25A0FD76400
       mov       rdx,[rdx]
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rdi+74],80131501
       mov       dword ptr [rdi+74],80070057
; 			for (var index = 0; index < this.Count; index++)
; 			     ^^^^^^^^^^^^^
       xor       ebx,ebx
       cmp       dword ptr [rsi+0A8],0
       jle       short M00_L02
; 				EasyLogger.LogCritical(this._logger, "DEBUG ENTRY", testException);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M00_L00:
       mov       rbp,[rsi+0B0]
       mov       rcx,rbp
       mov       r11,7FFE642A04A0
       mov       edx,5
       call      qword ptr [7FFE646304A0]
       test      eax,eax
       je        short M00_L01
       mov       rcx,7FFE646A86F8
       mov       edx,35
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,25A3FD747A0
       mov       rax,[rcx]
       mov       rcx,[rax+8]
       mov       r8,25A0FD76408
       mov       r8,[r8]
       mov       rdx,rbp
       mov       r9,rdi
       call      qword ptr [rax+18]
M00_L01:
       inc       ebx
       cmp       ebx,[rsi+0A8]
       jl        short M00_L00
M00_L02:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 203
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingHelperBenchmark.LogEasyDebugBenchmark()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
; 			var testException = new ArgumentInvalidException("TEST EX MESSAGE");
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentInvalidException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+70],0E0434352
       mov       dword ptr [rdi+74],80131500
       mov       rdx,1606FEA9BC0
       mov       rdx,[rdx]
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rdi+74],80131501
       mov       dword ptr [rdi+74],80070057
; 			for (var index = 0; index < this.Count; index++)
; 			     ^^^^^^^^^^^^^
       xor       ebx,ebx
       cmp       dword ptr [rsi+0A8],0
       jle       short M00_L02
; 				EasyLogger.LogCritical(this._logger, "DEBUG ENTRY", testException);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M00_L00:
       mov       rbp,[rsi+0B0]
       mov       rcx,rbp
       mov       r11,7FFE642704A0
       mov       edx,5
       call      qword ptr [7FFE646004A0]
       test      eax,eax
       je        short M00_L01
       mov       rcx,7FFE646786F8
       mov       edx,35
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1606FEA8BA8
       mov       rax,[rcx]
       mov       rcx,[rax+8]
       mov       r8,1606FEA9BC8
       mov       r8,[r8]
       mov       rdx,rbp
       mov       r9,rdi
       call      qword ptr [rax+18]
M00_L01:
       inc       ebx
       cmp       ebx,[rsi+0A8]
       jl        short M00_L00
M00_L02:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 203
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingHelperBenchmark.LogEasyDebugBenchmark()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
; 			var testException = new ArgumentInvalidException("TEST EX MESSAGE");
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentInvalidException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+70],0E0434352
       mov       dword ptr [rdi+74],80131500
       mov       rdx,1FB69F587C8
       mov       rdx,[rdx]
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rdi+74],80131501
       mov       dword ptr [rdi+74],80070057
; 			for (var index = 0; index < this.Count; index++)
; 			     ^^^^^^^^^^^^^
       xor       ebx,ebx
       cmp       dword ptr [rsi+0A8],0
       jle       short M00_L02
; 				EasyLogger.LogCritical(this._logger, "DEBUG ENTRY", testException);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M00_L00:
       mov       rbp,[rsi+0B0]
       mov       rcx,rbp
       mov       r11,7FFE642904A0
       mov       edx,5
       call      qword ptr [7FFE646204A0]
       test      eax,eax
       je        short M00_L01
       mov       rcx,7FFE646986F8
       mov       edx,35
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1FB69F56798
       mov       rax,[rcx]
       mov       rcx,[rax+8]
       mov       r8,1FB69F587D0
       mov       r8,[r8]
       mov       rdx,rbp
       mov       r9,rdi
       call      qword ptr [rax+18]
M00_L01:
       inc       ebx
       cmp       ebx,[rsi+0A8]
       jl        short M00_L00
M00_L02:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 203
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingHelperBenchmark.LogEasyErrorBenchmark()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
; 			var testException = new ArgumentInvalidException("TEST EX MESSAGE");
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentInvalidException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+70],0E0434352
       mov       dword ptr [rdi+74],80131500
       mov       rdx,23BEE5EB3F0
       mov       rdx,[rdx]
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rdi+74],80131501
       mov       dword ptr [rdi+74],80070057
; 			for (var index = 0; index < this.Count; index++)
; 			     ^^^^^^^^^^^^^
       xor       ebx,ebx
       cmp       dword ptr [rsi+0A8],0
       jle       short M00_L02
; 				EasyLogger.LogError(this._logger, "ERROR ENTRY", testException);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M00_L00:
       mov       rbp,[rsi+0B0]
       mov       rcx,rbp
       mov       r11,7FFE642804A0
       mov       edx,4
       call      qword ptr [7FFE646104A0]
       test      eax,eax
       je        short M00_L01
       mov       rcx,7FFE646886F8
       mov       edx,35
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,23BEE5E8BB8
       mov       rax,[rcx]
       mov       rcx,[rax+8]
       mov       r8,23BEE5EB3F8
       mov       r8,[r8]
       mov       rdx,rbp
       mov       r9,rdi
       call      qword ptr [rax+18]
M00_L01:
       inc       ebx
       cmp       ebx,[rsi+0A8]
       jl        short M00_L00
M00_L02:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 203
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingHelperBenchmark.LogEasyErrorBenchmark()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
; 			var testException = new ArgumentInvalidException("TEST EX MESSAGE");
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentInvalidException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+70],0E0434352
       mov       dword ptr [rdi+74],80131500
       mov       rdx,2A428233010
       mov       rdx,[rdx]
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rdi+74],80131501
       mov       dword ptr [rdi+74],80070057
; 			for (var index = 0; index < this.Count; index++)
; 			     ^^^^^^^^^^^^^
       xor       ebx,ebx
       cmp       dword ptr [rsi+0A8],0
       jle       short M00_L02
; 				EasyLogger.LogError(this._logger, "ERROR ENTRY", testException);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M00_L00:
       mov       rbp,[rsi+0B0]
       mov       rcx,rbp
       mov       r11,7FFE642704A0
       mov       edx,4
       call      qword ptr [7FFE646004A0]
       test      eax,eax
       je        short M00_L01
       mov       rcx,7FFE646786F8
       mov       edx,35
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,2A448238BB8
       mov       rax,[rcx]
       mov       rcx,[rax+8]
       mov       r8,2A428233018
       mov       r8,[r8]
       mov       rdx,rbp
       mov       r9,rdi
       call      qword ptr [rax+18]
M00_L01:
       inc       ebx
       cmp       ebx,[rsi+0A8]
       jl        short M00_L00
M00_L02:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 203
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingHelperBenchmark.LogEasyErrorBenchmark()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
; 			var testException = new ArgumentInvalidException("TEST EX MESSAGE");
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentInvalidException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+70],0E0434352
       mov       dword ptr [rdi+74],80131500
       mov       rdx,1FE39574408
       mov       rdx,[rdx]
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rdi+74],80131501
       mov       dword ptr [rdi+74],80070057
; 			for (var index = 0; index < this.Count; index++)
; 			     ^^^^^^^^^^^^^
       xor       ebx,ebx
       cmp       dword ptr [rsi+0A8],0
       jle       short M00_L02
; 				EasyLogger.LogError(this._logger, "ERROR ENTRY", testException);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M00_L00:
       mov       rbp,[rsi+0B0]
       mov       rcx,rbp
       mov       r11,7FFE642904A0
       mov       edx,4
       call      qword ptr [7FFE646204A0]
       test      eax,eax
       je        short M00_L01
       mov       rcx,7FFE646986F8
       mov       edx,35
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1FE595767A8
       mov       rax,[rcx]
       mov       rcx,[rax+8]
       mov       r8,1FE39574410
       mov       r8,[r8]
       mov       rdx,rbp
       mov       r9,rdi
       call      qword ptr [rax+18]
M00_L01:
       inc       ebx
       cmp       ebx,[rsi+0A8]
       jl        short M00_L00
M00_L02:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 203
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingHelperBenchmark.LogEasyErrorBenchmark()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
; 			var testException = new ArgumentInvalidException("TEST EX MESSAGE");
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentInvalidException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+70],0E0434352
       mov       dword ptr [rdi+74],80131500
       mov       rdx,2F222631FF8
       mov       rdx,[rdx]
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rdi+74],80131501
       mov       dword ptr [rdi+74],80070057
; 			for (var index = 0; index < this.Count; index++)
; 			     ^^^^^^^^^^^^^
       xor       ebx,ebx
       cmp       dword ptr [rsi+0A8],0
       jle       short M00_L02
; 				EasyLogger.LogError(this._logger, "ERROR ENTRY", testException);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M00_L00:
       mov       rbp,[rsi+0B0]
       mov       rcx,rbp
       mov       r11,7FFE642804A0
       mov       edx,4
       call      qword ptr [7FFE646104A0]
       test      eax,eax
       je        short M00_L01
       mov       rcx,7FFE646886F8
       mov       edx,35
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,2F242638BB8
       mov       rax,[rcx]
       mov       rcx,[rax+8]
       mov       r8,2F222632000
       mov       r8,[r8]
       mov       rdx,rbp
       mov       r9,rdi
       call      qword ptr [rax+18]
M00_L01:
       inc       ebx
       cmp       ebx,[rsi+0A8]
       jl        short M00_L00
M00_L02:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 203
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingHelperBenchmark.LogEasyErrorBenchmark()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
; 			var testException = new ArgumentInvalidException("TEST EX MESSAGE");
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentInvalidException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+70],0E0434352
       mov       dword ptr [rdi+74],80131500
       mov       rdx,1EA47AF17E0
       mov       rdx,[rdx]
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rdi+74],80131501
       mov       dword ptr [rdi+74],80070057
; 			for (var index = 0; index < this.Count; index++)
; 			     ^^^^^^^^^^^^^
       xor       ebx,ebx
       cmp       dword ptr [rsi+0A8],0
       jle       short M00_L02
; 				EasyLogger.LogError(this._logger, "ERROR ENTRY", testException);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M00_L00:
       mov       rbp,[rsi+0B0]
       mov       rcx,rbp
       mov       r11,7FFE642A04A0
       mov       edx,4
       call      qword ptr [7FFE646304A0]
       test      eax,eax
       je        short M00_L01
       mov       rcx,7FFE646A86F8
       mov       edx,35
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1EA57AF6BC0
       mov       rax,[rcx]
       mov       rcx,[rax+8]
       mov       r8,1EA47AF17E8
       mov       r8,[r8]
       mov       rdx,rbp
       mov       r9,rdi
       call      qword ptr [rax+18]
M00_L01:
       inc       ebx
       cmp       ebx,[rsi+0A8]
       jl        short M00_L00
M00_L02:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 203
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingHelperBenchmark.LogEasyErrorBenchmark()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
; 			var testException = new ArgumentInvalidException("TEST EX MESSAGE");
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentInvalidException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+70],0E0434352
       mov       dword ptr [rdi+74],80131500
       mov       rdx,1FDC9949BC0
       mov       rdx,[rdx]
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rdi+74],80131501
       mov       dword ptr [rdi+74],80070057
; 			for (var index = 0; index < this.Count; index++)
; 			     ^^^^^^^^^^^^^
       xor       ebx,ebx
       cmp       dword ptr [rsi+0A8],0
       jle       short M00_L02
; 				EasyLogger.LogError(this._logger, "ERROR ENTRY", testException);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M00_L00:
       mov       rbp,[rsi+0B0]
       mov       rcx,rbp
       mov       r11,7FFE642904A0
       mov       edx,4
       call      qword ptr [7FFE646204A0]
       test      eax,eax
       je        short M00_L01
       mov       rcx,7FFE646986F8
       mov       edx,35
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1FDC9948BB8
       mov       rax,[rcx]
       mov       rcx,[rax+8]
       mov       r8,1FDC9949BC8
       mov       r8,[r8]
       mov       rdx,rbp
       mov       r9,rdi
       call      qword ptr [rax+18]
M00_L01:
       inc       ebx
       cmp       ebx,[rsi+0A8]
       jl        short M00_L00
M00_L02:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 203
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingHelperBenchmark.LogEasyErrorBenchmark()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
; 			var testException = new ArgumentInvalidException("TEST EX MESSAGE");
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentInvalidException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+70],0E0434352
       mov       dword ptr [rdi+74],80131500
       mov       rdx,20111103010
       mov       rdx,[rdx]
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rdi+74],80131501
       mov       dword ptr [rdi+74],80070057
; 			for (var index = 0; index < this.Count; index++)
; 			     ^^^^^^^^^^^^^
       xor       ebx,ebx
       cmp       dword ptr [rsi+0A8],0
       jle       short M00_L02
; 				EasyLogger.LogError(this._logger, "ERROR ENTRY", testException);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M00_L00:
       mov       rbp,[rsi+0B0]
       mov       rcx,rbp
       mov       r11,7FFE642804A0
       mov       edx,4
       call      qword ptr [7FFE646104A0]
       test      eax,eax
       je        short M00_L01
       mov       rcx,7FFE646886F8
       mov       edx,35
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,20131108BB8
       mov       rax,[rcx]
       mov       rcx,[rax+8]
       mov       r8,20111103018
       mov       r8,[r8]
       mov       rdx,rbp
       mov       r9,rdi
       call      qword ptr [rax+18]
M00_L01:
       inc       ebx
       cmp       ebx,[rsi+0A8]
       jl        short M00_L00
M00_L02:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 203
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingHelperBenchmark.LogEasyErrorBenchmark()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
; 			var testException = new ArgumentInvalidException("TEST EX MESSAGE");
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentInvalidException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+70],0E0434352
       mov       dword ptr [rdi+74],80131500
       mov       rdx,20087DC1FF8
       mov       rdx,[rdx]
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rdi+74],80131501
       mov       dword ptr [rdi+74],80070057
; 			for (var index = 0; index < this.Count; index++)
; 			     ^^^^^^^^^^^^^
       xor       ebx,ebx
       cmp       dword ptr [rsi+0A8],0
       jle       short M00_L02
; 				EasyLogger.LogError(this._logger, "ERROR ENTRY", testException);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M00_L00:
       mov       rbp,[rsi+0B0]
       mov       rcx,rbp
       mov       r11,7FFE642704A0
       mov       edx,4
       call      qword ptr [7FFE646004A0]
       test      eax,eax
       je        short M00_L01
       mov       rcx,7FFE646786F8
       mov       edx,35
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,200A7DC8BB8
       mov       rax,[rcx]
       mov       rcx,[rax+8]
       mov       r8,20087DC2000
       mov       r8,[r8]
       mov       rdx,rbp
       mov       r9,rdi
       call      qword ptr [rax+18]
M00_L01:
       inc       ebx
       cmp       ebx,[rsi+0A8]
       jl        short M00_L00
M00_L02:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 203
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingHelperBenchmark.LogEasyInformationBenchmark()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
; 			for (var index = 0; index < this.Count; index++)
; 			     ^^^^^^^^^^^^^
       xor       edi,edi
       cmp       dword ptr [rsi+0A8],0
       jle       short M00_L02
; 				EasyLogger.LogInformation(this._logger, "ERROR ENTRY");
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M00_L00:
       mov       rbx,[rsi+0B0]
       mov       rcx,rbx
       mov       r11,7FFE642704A0
       mov       edx,2
       call      qword ptr [7FFE646004A0]
       test      eax,eax
       je        short M00_L01
       mov       rcx,7FFE646786F8
       mov       edx,35
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1B74CE047B8
       mov       rax,[rcx]
       mov       rcx,[rax+8]
       mov       r8,1B71CE07418
       mov       r8,[r8]
       mov       rdx,rbx
       xor       r9d,r9d
       call      qword ptr [rax+18]
M00_L01:
       inc       edi
       cmp       edi,[rsi+0A8]
       jl        short M00_L00
M00_L02:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 133
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingHelperBenchmark.LogEasyInformationBenchmark()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
; 			for (var index = 0; index < this.Count; index++)
; 			     ^^^^^^^^^^^^^
       xor       edi,edi
       cmp       dword ptr [rsi+0A8],0
       jle       short M00_L02
; 				EasyLogger.LogInformation(this._logger, "ERROR ENTRY");
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M00_L00:
       mov       rbx,[rsi+0B0]
       mov       rcx,rbx
       mov       r11,7FFE642804A0
       mov       edx,2
       call      qword ptr [7FFE646104A0]
       test      eax,eax
       je        short M00_L01
       mov       rcx,7FFE646886F8
       mov       edx,35
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,2826B8847B8
       mov       rax,[rcx]
       mov       rcx,[rax+8]
       mov       r8,2823B886400
       mov       r8,[r8]
       mov       rdx,rbx
       xor       r9d,r9d
       call      qword ptr [rax+18]
M00_L01:
       inc       edi
       cmp       edi,[rsi+0A8]
       jl        short M00_L00
M00_L02:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 133
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingHelperBenchmark.LogEasyInformationBenchmark()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
; 			for (var index = 0; index < this.Count; index++)
; 			     ^^^^^^^^^^^^^
       xor       edi,edi
       cmp       dword ptr [rsi+0A8],0
       jle       short M00_L02
; 				EasyLogger.LogInformation(this._logger, "ERROR ENTRY");
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M00_L00:
       mov       rbx,[rsi+0B0]
       mov       rcx,rbx
       mov       r11,7FFE642804A0
       mov       edx,2
       call      qword ptr [7FFE646104A0]
       test      eax,eax
       je        short M00_L01
       mov       rcx,7FFE646886F8
       mov       edx,35
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,284300C6BC8
       mov       rax,[rcx]
       mov       rcx,[rax+8]
       mov       r8,284100C3FF0
       mov       r8,[r8]
       mov       rdx,rbx
       xor       r9d,r9d
       call      qword ptr [rax+18]
M00_L01:
       inc       edi
       cmp       edi,[rsi+0A8]
       jl        short M00_L00
M00_L02:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 133
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingHelperBenchmark.LogEasyInformationBenchmark()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
; 			for (var index = 0; index < this.Count; index++)
; 			     ^^^^^^^^^^^^^
       xor       edi,edi
       cmp       dword ptr [rsi+0A8],0
       jle       short M00_L02
; 				EasyLogger.LogInformation(this._logger, "ERROR ENTRY");
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M00_L00:
       mov       rbx,[rsi+0B0]
       mov       rcx,rbx
       mov       r11,7FFE642604A0
       mov       edx,2
       call      qword ptr [7FFE645F04A0]
       test      eax,eax
       je        short M00_L01
       mov       rcx,7FFE646686F8
       mov       edx,35
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,200ADEF47B8
       mov       rax,[rcx]
       mov       rcx,[rax+8]
       mov       r8,2007DEF6400
       mov       r8,[r8]
       mov       rdx,rbx
       xor       r9d,r9d
       call      qword ptr [rax+18]
M00_L01:
       inc       edi
       cmp       edi,[rsi+0A8]
       jl        short M00_L00
M00_L02:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 133
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingHelperBenchmark.LogEasyInformationBenchmark()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
; 			for (var index = 0; index < this.Count; index++)
; 			     ^^^^^^^^^^^^^
       xor       edi,edi
       cmp       dword ptr [rsi+0A8],0
       jle       short M00_L02
; 				EasyLogger.LogInformation(this._logger, "ERROR ENTRY");
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M00_L00:
       mov       rbx,[rsi+0B0]
       mov       rcx,rbx
       mov       r11,7FFE642704A0
       mov       edx,2
       call      qword ptr [7FFE646004A0]
       test      eax,eax
       je        short M00_L01
       mov       rcx,7FFE646786F8
       mov       edx,35
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,253EB1847B8
       mov       rax,[rcx]
       mov       rcx,[rax+8]
       mov       r8,253DB1827F8
       mov       r8,[r8]
       mov       rdx,rbx
       xor       r9d,r9d
       call      qword ptr [rax+18]
M00_L01:
       inc       edi
       cmp       edi,[rsi+0A8]
       jl        short M00_L00
M00_L02:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 133
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingHelperBenchmark.LogEasyInformationBenchmark()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
; 			for (var index = 0; index < this.Count; index++)
; 			     ^^^^^^^^^^^^^
       xor       edi,edi
       cmp       dword ptr [rsi+0A8],0
       jle       short M00_L02
; 				EasyLogger.LogInformation(this._logger, "ERROR ENTRY");
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M00_L00:
       mov       rbx,[rsi+0B0]
       mov       rcx,rbx
       mov       r11,7FFE642904A0
       mov       edx,2
       call      qword ptr [7FFE646204A0]
       test      eax,eax
       je        short M00_L01
       mov       rcx,7FFE646986F8
       mov       edx,35
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1C3CE1D8BC0
       mov       rax,[rcx]
       mov       rcx,[rax+8]
       mov       r8,1C3AE1D3010
       mov       r8,[r8]
       mov       rdx,rbx
       xor       r9d,r9d
       call      qword ptr [rax+18]
M00_L01:
       inc       edi
       cmp       edi,[rsi+0A8]
       jl        short M00_L00
M00_L02:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 133
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingHelperBenchmark.LogEasyInformationBenchmark()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
; 			for (var index = 0; index < this.Count; index++)
; 			     ^^^^^^^^^^^^^
       xor       edi,edi
       cmp       dword ptr [rsi+0A8],0
       jle       short M00_L02
; 				EasyLogger.LogInformation(this._logger, "ERROR ENTRY");
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M00_L00:
       mov       rbx,[rsi+0B0]
       mov       rcx,rbx
       mov       r11,7FFE642904A0
       mov       edx,2
       call      qword ptr [7FFE646204A0]
       test      eax,eax
       je        short M00_L01
       mov       rcx,7FFE646986F8
       mov       edx,35
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1CBBB3147B8
       mov       rax,[rcx]
       mov       rcx,[rax+8]
       mov       r8,1CB8B316400
       mov       r8,[r8]
       mov       rdx,rbx
       xor       r9d,r9d
       call      qword ptr [rax+18]
M00_L01:
       inc       edi
       cmp       edi,[rsi+0A8]
       jl        short M00_L00
M00_L02:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 133
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingHelperBenchmark.LogEasyInformationBenchmark()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
; 			for (var index = 0; index < this.Count; index++)
; 			     ^^^^^^^^^^^^^
       xor       edi,edi
       cmp       dword ptr [rsi+0A8],0
       jle       short M00_L02
; 				EasyLogger.LogInformation(this._logger, "ERROR ENTRY");
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M00_L00:
       mov       rbx,[rsi+0B0]
       mov       rcx,rbx
       mov       r11,7FFE642704A0
       mov       edx,2
       call      qword ptr [7FFE646004A0]
       test      eax,eax
       je        short M00_L01
       mov       rcx,7FFE646786F8
       mov       edx,35
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,22087928BC0
       mov       rax,[rcx]
       mov       rcx,[rax+8]
       mov       r8,22087929BC0
       mov       r8,[r8]
       mov       rdx,rbx
       xor       r9d,r9d
       call      qword ptr [rax+18]
M00_L01:
       inc       edi
       cmp       edi,[rsi+0A8]
       jl        short M00_L00
M00_L02:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 133
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingHelperBenchmark.LogEasyTraceBenchmark()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
; 			for (var index = 0; index < this.Count; index++)
; 			     ^^^^^^^^^^^^^
       xor       edi,edi
       cmp       dword ptr [rsi+0A8],0
       jle       short M00_L02
; 				EasyLogger.LogTrace(this._logger, "TRACE ENTRY");
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M00_L00:
       mov       rbx,[rsi+0B0]
       mov       rcx,rbx
       mov       r11,7FFE642904A0
       xor       edx,edx
       call      qword ptr [7FFE646204A0]
       test      eax,eax
       je        short M00_L01
       mov       rcx,7FFE646986F8
       mov       edx,35
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,18E80E48BC8
       mov       rax,[rcx]
       mov       rcx,[rax+8]
       mov       r8,18E60E41FF8
       mov       r8,[r8]
       mov       rdx,rbx
       xor       r9d,r9d
       call      qword ptr [rax+18]
M00_L01:
       inc       edi
       cmp       edi,[rsi+0A8]
       jl        short M00_L00
M00_L02:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 130
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingHelperBenchmark.LogEasyTraceBenchmark()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
; 			for (var index = 0; index < this.Count; index++)
; 			     ^^^^^^^^^^^^^
       xor       edi,edi
       cmp       dword ptr [rsi+0A8],0
       jle       short M00_L02
; 				EasyLogger.LogTrace(this._logger, "TRACE ENTRY");
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M00_L00:
       mov       rbx,[rsi+0B0]
       mov       rcx,rbx
       mov       r11,7FFE642604A0
       xor       edx,edx
       call      qword ptr [7FFE645F04A0]
       test      eax,eax
       je        short M00_L01
       mov       rcx,7FFE646686F8
       mov       edx,35
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,2104FD747C0
       mov       rax,[rcx]
       mov       rcx,[rax+8]
       mov       r8,2101FD727F8
       mov       r8,[r8]
       mov       rdx,rbx
       xor       r9d,r9d
       call      qword ptr [rax+18]
M00_L01:
       inc       edi
       cmp       edi,[rsi+0A8]
       jl        short M00_L00
M00_L02:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 130
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingHelperBenchmark.LogEasyTraceBenchmark()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
; 			for (var index = 0; index < this.Count; index++)
; 			     ^^^^^^^^^^^^^
       xor       edi,edi
       cmp       dword ptr [rsi+0A8],0
       jle       short M00_L02
; 				EasyLogger.LogTrace(this._logger, "TRACE ENTRY");
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M00_L00:
       mov       rbx,[rsi+0B0]
       mov       rcx,rbx
       mov       r11,7FFE642804A0
       xor       edx,edx
       call      qword ptr [7FFE646104A0]
       test      eax,eax
       je        short M00_L01
       mov       rcx,7FFE646886F8
       mov       edx,35
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,238752E6BD0
       mov       rax,[rcx]
       mov       rcx,[rax+8]
       mov       r8,238552E3010
       mov       r8,[r8]
       mov       rdx,rbx
       xor       r9d,r9d
       call      qword ptr [rax+18]
M00_L01:
       inc       edi
       cmp       edi,[rsi+0A8]
       jl        short M00_L00
M00_L02:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 130
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingHelperBenchmark.LogEasyTraceBenchmark()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
; 			for (var index = 0; index < this.Count; index++)
; 			     ^^^^^^^^^^^^^
       xor       edi,edi
       cmp       dword ptr [rsi+0A8],0
       jle       short M00_L02
; 				EasyLogger.LogTrace(this._logger, "TRACE ENTRY");
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M00_L00:
       mov       rbx,[rsi+0B0]
       mov       rcx,rbx
       mov       r11,7FFE642804A0
       xor       edx,edx
       call      qword ptr [7FFE646104A0]
       test      eax,eax
       je        short M00_L01
       mov       rcx,7FFE646886F8
       mov       edx,35
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,250A2C58BC8
       mov       rax,[rcx]
       mov       rcx,[rax+8]
       mov       r8,25092C517E0
       mov       r8,[r8]
       mov       rdx,rbx
       xor       r9d,r9d
       call      qword ptr [rax+18]
M00_L01:
       inc       edi
       cmp       edi,[rsi+0A8]
       jl        short M00_L00
M00_L02:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 130
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingHelperBenchmark.LogEasyTraceBenchmark()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
; 			for (var index = 0; index < this.Count; index++)
; 			     ^^^^^^^^^^^^^
       xor       edi,edi
       cmp       dword ptr [rsi+0A8],0
       jle       short M00_L02
; 				EasyLogger.LogTrace(this._logger, "TRACE ENTRY");
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M00_L00:
       mov       rbx,[rsi+0B0]
       mov       rcx,rbx
       mov       r11,7FFE642704A0
       xor       edx,edx
       call      qword ptr [7FFE646004A0]
       test      eax,eax
       je        short M00_L01
       mov       rcx,7FFE646786F8
       mov       edx,35
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,22BD8968BC8
       mov       rax,[rcx]
       mov       rcx,[rax+8]
       mov       r8,22BD8969BC0
       mov       r8,[r8]
       mov       rdx,rbx
       xor       r9d,r9d
       call      qword ptr [rax+18]
M00_L01:
       inc       edi
       cmp       edi,[rsi+0A8]
       jl        short M00_L00
M00_L02:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 130
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingHelperBenchmark.LogEasyTraceBenchmark()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
; 			for (var index = 0; index < this.Count; index++)
; 			     ^^^^^^^^^^^^^
       xor       edi,edi
       cmp       dword ptr [rsi+0A8],0
       jle       short M00_L02
; 				EasyLogger.LogTrace(this._logger, "TRACE ENTRY");
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M00_L00:
       mov       rbx,[rsi+0B0]
       mov       rcx,rbx
       mov       r11,7FFE642804A0
       xor       edx,edx
       call      qword ptr [7FFE646104A0]
       test      eax,eax
       je        short M00_L01
       mov       rcx,7FFE646886F8
       mov       edx,35
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1EFE8B68BC8
       mov       rax,[rcx]
       mov       rcx,[rax+8]
       mov       r8,1EFC8B63010
       mov       r8,[r8]
       mov       rdx,rbx
       xor       r9d,r9d
       call      qword ptr [rax+18]
M00_L01:
       inc       edi
       cmp       edi,[rsi+0A8]
       jl        short M00_L00
M00_L02:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 130
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingHelperBenchmark.LogEasyTraceBenchmark()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
; 			for (var index = 0; index < this.Count; index++)
; 			     ^^^^^^^^^^^^^
       xor       edi,edi
       cmp       dword ptr [rsi+0A8],0
       jle       short M00_L02
; 				EasyLogger.LogTrace(this._logger, "TRACE ENTRY");
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M00_L00:
       mov       rbx,[rsi+0B0]
       mov       rcx,rbx
       mov       r11,7FFE642804A0
       xor       edx,edx
       call      qword ptr [7FFE646104A0]
       test      eax,eax
       je        short M00_L01
       mov       rcx,7FFE646886F8
       mov       edx,35
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1B7235C47C0
       mov       rax,[rcx]
       mov       rcx,[rax+8]
       mov       r8,1B6F35C6400
       mov       r8,[r8]
       mov       rdx,rbx
       xor       r9d,r9d
       call      qword ptr [rax+18]
M00_L01:
       inc       edi
       cmp       edi,[rsi+0A8]
       jl        short M00_L00
M00_L02:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 130
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingHelperBenchmark.LogEasyTraceBenchmark()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
; 			for (var index = 0; index < this.Count; index++)
; 			     ^^^^^^^^^^^^^
       xor       edi,edi
       cmp       dword ptr [rsi+0A8],0
       jle       short M00_L02
; 				EasyLogger.LogTrace(this._logger, "TRACE ENTRY");
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M00_L00:
       mov       rbx,[rsi+0B0]
       mov       rcx,rbx
       mov       r11,7FFE642604A0
       xor       edx,edx
       call      qword ptr [7FFE645F04A0]
       test      eax,eax
       je        short M00_L01
       mov       rcx,7FFE646686F8
       mov       edx,35
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,2375A508BC8
       mov       rax,[rcx]
       mov       rcx,[rax+8]
       mov       r8,2375A509BC0
       mov       r8,[r8]
       mov       rdx,rbx
       xor       r9d,r9d
       call      qword ptr [rax+18]
M00_L01:
       inc       edi
       cmp       edi,[rsi+0A8]
       jl        short M00_L00
M00_L02:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 130
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingHelperBenchmark.LogErrorBenchmark()
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rax
       mov       rsi,rcx
; 			var testException = new ArgumentInvalidException("TEST EX MESSAGE");
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentInvalidException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+70],0E0434352
       mov       dword ptr [rdi+74],80131500
       mov       rdx,221738D7418
       mov       rdx,[rdx]
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rdi+74],80131501
       mov       dword ptr [rdi+74],80070057
; 			for (var index = 0; index < this.Count; index++)
; 			     ^^^^^^^^^^^^^
       xor       ebx,ebx
       cmp       dword ptr [rsi+0A8],0
       jle       short M00_L01
       mov       rcx,221738D7420
       mov       rbp,[rcx]
; 				this._logger.LogError(100, testException, "ERROR ENTRY");
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M00_L00:
       mov       r14,[rsi+0B0]
       xor       r15d,r15d
       mov       r12d,64
       mov       rcx,7FFE64374928
       mov       edx,2D
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,221738D2F78
       mov       rcx,[rcx]
       mov       [rsp+30],r15
       mov       [rsp+38],r12d
       mov       [rsp+20],rbp
       mov       [rsp+28],rcx
       mov       rcx,r14
       lea       r8,[rsp+30]
       mov       r9,rdi
       mov       edx,4
       call      Microsoft.Extensions.Logging.LoggerExtensions.Log(Microsoft.Extensions.Logging.ILogger, Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.Exception, System.String, System.Object[])
       inc       ebx
       cmp       ebx,[rsi+0A8]
       jl        short M00_L00
M00_L01:
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
; Total bytes of code 236
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
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log(Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, !!0, System.Exception, System.Func`3<!!0,System.Exception,System.String>)
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
       mov       r9,221938D4518
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
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,191
       mov       rdx,7FFE64675D18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      System.ArgumentNullException..ctor(System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 246
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingHelperBenchmark.LogErrorBenchmark()
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rax
       mov       rsi,rcx
; 			var testException = new ArgumentInvalidException("TEST EX MESSAGE");
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentInvalidException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+70],0E0434352
       mov       dword ptr [rdi+74],80131500
       mov       rdx,2881A333FF0
       mov       rdx,[rdx]
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rdi+74],80131501
       mov       dword ptr [rdi+74],80070057
; 			for (var index = 0; index < this.Count; index++)
; 			     ^^^^^^^^^^^^^
       xor       ebx,ebx
       cmp       dword ptr [rsi+0A8],0
       jle       short M00_L01
       mov       rcx,2881A333FF8
       mov       rbp,[rcx]
; 				this._logger.LogError(100, testException, "ERROR ENTRY");
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M00_L00:
       mov       r14,[rsi+0B0]
       xor       r15d,r15d
       mov       r12d,64
       mov       rcx,7FFE64394928
       mov       edx,2D
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,2881A332F78
       mov       rcx,[rcx]
       mov       [rsp+30],r15
       mov       [rsp+38],r12d
       mov       [rsp+20],rbp
       mov       [rsp+28],rcx
       mov       rcx,r14
       lea       r8,[rsp+30]
       mov       r9,rdi
       mov       edx,4
       call      Microsoft.Extensions.Logging.LoggerExtensions.Log(Microsoft.Extensions.Logging.ILogger, Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.Exception, System.String, System.Object[])
       inc       ebx
       cmp       ebx,[rsi+0A8]
       jl        short M00_L00
M00_L01:
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
; Total bytes of code 236
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
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log(Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, !!0, System.Exception, System.Func`3<!!0,System.Exception,System.String>)
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
       mov       r9,287FA336928
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
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,191
       mov       rdx,7FFE64695D18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      System.ArgumentNullException..ctor(System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 246
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingHelperBenchmark.LogErrorBenchmark()
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rax
       mov       rsi,rcx
; 			var testException = new ArgumentInvalidException("TEST EX MESSAGE");
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentInvalidException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+70],0E0434352
       mov       dword ptr [rdi+74],80131500
       mov       rdx,1D0D0F61FF8
       mov       rdx,[rdx]
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rdi+74],80131501
       mov       dword ptr [rdi+74],80070057
; 			for (var index = 0; index < this.Count; index++)
; 			     ^^^^^^^^^^^^^
       xor       ebx,ebx
       cmp       dword ptr [rsi+0A8],0
       jle       short M00_L01
       mov       rcx,1D0D0F62000
       mov       rbp,[rcx]
; 				this._logger.LogError(100, testException, "ERROR ENTRY");
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M00_L00:
       mov       r14,[rsi+0B0]
       xor       r15d,r15d
       mov       r12d,64
       mov       rcx,7FFE643A4928
       mov       edx,2D
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1D0F0F62F78
       mov       rcx,[rcx]
       mov       [rsp+30],r15
       mov       [rsp+38],r12d
       mov       [rsp+20],rbp
       mov       [rsp+28],rcx
       mov       rcx,r14
       lea       r8,[rsp+30]
       mov       r9,rdi
       mov       edx,4
       call      Microsoft.Extensions.Logging.LoggerExtensions.Log(Microsoft.Extensions.Logging.ILogger, Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.Exception, System.String, System.Object[])
       inc       ebx
       cmp       ebx,[rsi+0A8]
       jl        short M00_L00
M00_L01:
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
; Total bytes of code 236
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
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log(Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, !!0, System.Exception, System.Func`3<!!0,System.Exception,System.String>)
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
       mov       r9,1D0F0F68920
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
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,191
       mov       rdx,7FFE646A5D18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      System.ArgumentNullException..ctor(System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 246
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingHelperBenchmark.LogErrorBenchmark()
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rax
       mov       rsi,rcx
; 			var testException = new ArgumentInvalidException("TEST EX MESSAGE");
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentInvalidException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+70],0E0434352
       mov       dword ptr [rdi+74],80131500
       mov       rdx,251C6953010
       mov       rdx,[rdx]
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rdi+74],80131501
       mov       dword ptr [rdi+74],80070057
; 			for (var index = 0; index < this.Count; index++)
; 			     ^^^^^^^^^^^^^
       xor       ebx,ebx
       cmp       dword ptr [rsi+0A8],0
       jle       short M00_L01
       mov       rcx,251C6953018
       mov       rbp,[rcx]
; 				this._logger.LogError(100, testException, "ERROR ENTRY");
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M00_L00:
       mov       r14,[rsi+0B0]
       xor       r15d,r15d
       mov       r12d,64
       mov       rcx,7FFE64394928
       mov       edx,2D
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,251E6952F78
       mov       rcx,[rcx]
       mov       [rsp+30],r15
       mov       [rsp+38],r12d
       mov       [rsp+20],rbp
       mov       [rsp+28],rcx
       mov       rcx,r14
       lea       r8,[rsp+30]
       mov       r9,rdi
       mov       edx,4
       call      Microsoft.Extensions.Logging.LoggerExtensions.Log(Microsoft.Extensions.Logging.ILogger, Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.Exception, System.String, System.Object[])
       inc       ebx
       cmp       ebx,[rsi+0A8]
       jl        short M00_L00
M00_L01:
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
; Total bytes of code 236
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
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log(Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, !!0, System.Exception, System.Func`3<!!0,System.Exception,System.String>)
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
       mov       r9,251E6958920
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
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,191
       mov       rdx,7FFE64695D18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      System.ArgumentNullException..ctor(System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 246
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingHelperBenchmark.LogErrorBenchmark()
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rax
       mov       rsi,rcx
; 			var testException = new ArgumentInvalidException("TEST EX MESSAGE");
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentInvalidException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+70],0E0434352
       mov       dword ptr [rdi+74],80131500
       mov       rdx,28E034FB3F0
       mov       rdx,[rdx]
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rdi+74],80131501
       mov       dword ptr [rdi+74],80070057
; 			for (var index = 0; index < this.Count; index++)
; 			     ^^^^^^^^^^^^^
       xor       ebx,ebx
       cmp       dword ptr [rsi+0A8],0
       jle       short M00_L01
       mov       rcx,28E034FB3F8
       mov       rbp,[rcx]
; 				this._logger.LogError(100, testException, "ERROR ENTRY");
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M00_L00:
       mov       r14,[rsi+0B0]
       xor       r15d,r15d
       mov       r12d,64
       mov       rcx,7FFE64374928
       mov       edx,2D
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,28E034F2F78
       mov       rcx,[rcx]
       mov       [rsp+30],r15
       mov       [rsp+38],r12d
       mov       [rsp+20],rbp
       mov       [rsp+28],rcx
       mov       rcx,r14
       lea       r8,[rsp+30]
       mov       r9,rdi
       mov       edx,4
       call      Microsoft.Extensions.Logging.LoggerExtensions.Log(Microsoft.Extensions.Logging.ILogger, Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.Exception, System.String, System.Object[])
       inc       ebx
       cmp       ebx,[rsi+0A8]
       jl        short M00_L00
M00_L01:
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
; Total bytes of code 236
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
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log(Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, !!0, System.Exception, System.Func`3<!!0,System.Exception,System.String>)
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
       mov       r9,28E034F8920
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
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,191
       mov       rdx,7FFE64675D18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      System.ArgumentNullException..ctor(System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 246
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingHelperBenchmark.LogErrorBenchmark()
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rax
       mov       rsi,rcx
; 			var testException = new ArgumentInvalidException("TEST EX MESSAGE");
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentInvalidException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+70],0E0434352
       mov       dword ptr [rdi+74],80131500
       mov       rdx,29FA19D3010
       mov       rdx,[rdx]
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rdi+74],80131501
       mov       dword ptr [rdi+74],80070057
; 			for (var index = 0; index < this.Count; index++)
; 			     ^^^^^^^^^^^^^
       xor       ebx,ebx
       cmp       dword ptr [rsi+0A8],0
       jle       short M00_L01
       mov       rcx,29FA19D3018
       mov       rbp,[rcx]
; 				this._logger.LogError(100, testException, "ERROR ENTRY");
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M00_L00:
       mov       r14,[rsi+0B0]
       xor       r15d,r15d
       mov       r12d,64
       mov       rcx,7FFE64364928
       mov       edx,2D
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,29FC19D2F78
       mov       rcx,[rcx]
       mov       [rsp+30],r15
       mov       [rsp+38],r12d
       mov       [rsp+20],rbp
       mov       [rsp+28],rcx
       mov       rcx,r14
       lea       r8,[rsp+30]
       mov       r9,rdi
       mov       edx,4
       call      Microsoft.Extensions.Logging.LoggerExtensions.Log(Microsoft.Extensions.Logging.ILogger, Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.Exception, System.String, System.Object[])
       inc       ebx
       cmp       ebx,[rsi+0A8]
       jl        short M00_L00
M00_L01:
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
; Total bytes of code 236
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
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log(Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, !!0, System.Exception, System.Func`3<!!0,System.Exception,System.String>)
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
       mov       r9,29FC19D8920
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
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,191
       mov       rdx,7FFE64665D18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      System.ArgumentNullException..ctor(System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 246
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingHelperBenchmark.LogErrorBenchmark()
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rax
       mov       rsi,rcx
; 			var testException = new ArgumentInvalidException("TEST EX MESSAGE");
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentInvalidException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+70],0E0434352
       mov       dword ptr [rdi+74],80131500
       mov       rdx,29684355BE8
       mov       rdx,[rdx]
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rdi+74],80131501
       mov       dword ptr [rdi+74],80070057
; 			for (var index = 0; index < this.Count; index++)
; 			     ^^^^^^^^^^^^^
       xor       ebx,ebx
       cmp       dword ptr [rsi+0A8],0
       jle       short M00_L01
       mov       rcx,29684355BF0
       mov       rbp,[rcx]
; 				this._logger.LogError(100, testException, "ERROR ENTRY");
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M00_L00:
       mov       r14,[rsi+0B0]
       xor       r15d,r15d
       mov       r12d,64
       mov       rcx,7FFE64384928
       mov       edx,2D
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,29684352F78
       mov       rcx,[rcx]
       mov       [rsp+30],r15
       mov       [rsp+38],r12d
       mov       [rsp+20],rbp
       mov       [rsp+28],rcx
       mov       rcx,r14
       lea       r8,[rsp+30]
       mov       r9,rdi
       mov       edx,4
       call      Microsoft.Extensions.Logging.LoggerExtensions.Log(Microsoft.Extensions.Logging.ILogger, Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.Exception, System.String, System.Object[])
       inc       ebx
       cmp       ebx,[rsi+0A8]
       jl        short M00_L00
M00_L01:
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
; Total bytes of code 236
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
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log(Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, !!0, System.Exception, System.Func`3<!!0,System.Exception,System.String>)
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
       mov       r9,296A4354518
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
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,191
       mov       rdx,7FFE64685D18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      System.ArgumentNullException..ctor(System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 246
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingHelperBenchmark.LogErrorBenchmark()
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rax
       mov       rsi,rcx
; 			var testException = new ArgumentInvalidException("TEST EX MESSAGE");
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentInvalidException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+70],0E0434352
       mov       dword ptr [rdi+74],80131500
       mov       rdx,166CF3217E0
       mov       rdx,[rdx]
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rdi+74],80131501
       mov       dword ptr [rdi+74],80070057
; 			for (var index = 0; index < this.Count; index++)
; 			     ^^^^^^^^^^^^^
       xor       ebx,ebx
       cmp       dword ptr [rsi+0A8],0
       jle       short M00_L01
       mov       rcx,166CF3217E8
       mov       rbp,[rcx]
; 				this._logger.LogError(100, testException, "ERROR ENTRY");
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M00_L00:
       mov       r14,[rsi+0B0]
       xor       r15d,r15d
       mov       r12d,64
       mov       rcx,7FFE64394928
       mov       edx,2D
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,166AF322F78
       mov       rcx,[rcx]
       mov       [rsp+30],r15
       mov       [rsp+38],r12d
       mov       [rsp+20],rbp
       mov       [rsp+28],rcx
       mov       rcx,r14
       lea       r8,[rsp+30]
       mov       r9,rdi
       mov       edx,4
       call      Microsoft.Extensions.Logging.LoggerExtensions.Log(Microsoft.Extensions.Logging.ILogger, Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.Exception, System.String, System.Object[])
       inc       ebx
       cmp       ebx,[rsi+0A8]
       jl        short M00_L00
M00_L01:
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
; Total bytes of code 236
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
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log(Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, !!0, System.Exception, System.Func`3<!!0,System.Exception,System.String>)
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
       mov       r9,166DF324518
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
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,191
       mov       rdx,7FFE64695D18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      System.ArgumentNullException..ctor(System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 246
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingHelperBenchmark.LogInformationBenchmark()
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rax
       mov       rsi,rcx
; 			var testException = new ArgumentInvalidException("TEST EX MESSAGE");
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentInvalidException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+70],0E0434352
       mov       dword ptr [rdi+74],80131500
       mov       rdx,2CB710E7BC8
       mov       rdx,[rdx]
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rdi+74],80131501
       mov       dword ptr [rdi+74],80070057
; 			for (var index = 0; index < this.Count; index++)
; 			     ^^^^^^^^^^^^^
       xor       ebx,ebx
       cmp       dword ptr [rsi+0A8],0
       jle       short M00_L01
       mov       rcx,2CB710E7BD0
       mov       rbp,[rcx]
; 				this._logger.LogInformation(100, testException, "INFORMATION ENTRY");
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M00_L00:
       mov       r14,[rsi+0B0]
       xor       r15d,r15d
       mov       r12d,64
       mov       rcx,7FFE64394928
       mov       edx,2D
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,2CB810E2F78
       mov       rcx,[rcx]
       mov       [rsp+30],r15
       mov       [rsp+38],r12d
       mov       [rsp+20],rbp
       mov       [rsp+28],rcx
       mov       rcx,r14
       lea       r8,[rsp+30]
       mov       r9,rdi
       mov       edx,2
       call      Microsoft.Extensions.Logging.LoggerExtensions.Log(Microsoft.Extensions.Logging.ILogger, Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.Exception, System.String, System.Object[])
       inc       ebx
       cmp       ebx,[rsi+0A8]
       jl        short M00_L00
M00_L01:
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
; Total bytes of code 236
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
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log(Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, !!0, System.Exception, System.Func`3<!!0,System.Exception,System.String>)
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
       mov       r9,2CB710E6928
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
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,191
       mov       rdx,7FFE64695D18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      System.ArgumentNullException..ctor(System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 246
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingHelperBenchmark.LogInformationBenchmark()
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rax
       mov       rsi,rcx
; 			var testException = new ArgumentInvalidException("TEST EX MESSAGE");
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentInvalidException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+70],0E0434352
       mov       dword ptr [rdi+74],80131500
       mov       rdx,2557DE44408
       mov       rdx,[rdx]
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rdi+74],80131501
       mov       dword ptr [rdi+74],80070057
; 			for (var index = 0; index < this.Count; index++)
; 			     ^^^^^^^^^^^^^
       xor       ebx,ebx
       cmp       dword ptr [rsi+0A8],0
       jle       short M00_L01
       mov       rcx,2557DE44410
       mov       rbp,[rcx]
; 				this._logger.LogInformation(100, testException, "INFORMATION ENTRY");
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M00_L00:
       mov       r14,[rsi+0B0]
       xor       r15d,r15d
       mov       r12d,64
       mov       rcx,7FFE64394928
       mov       edx,2D
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,2559DE42F78
       mov       rcx,[rcx]
       mov       [rsp+30],r15
       mov       [rsp+38],r12d
       mov       [rsp+20],rbp
       mov       [rsp+28],rcx
       mov       rcx,r14
       lea       r8,[rsp+30]
       mov       r9,rdi
       mov       edx,2
       call      Microsoft.Extensions.Logging.LoggerExtensions.Log(Microsoft.Extensions.Logging.ILogger, Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.Exception, System.String, System.Object[])
       inc       ebx
       cmp       ebx,[rsi+0A8]
       jl        short M00_L00
M00_L01:
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
; Total bytes of code 236
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
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log(Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, !!0, System.Exception, System.Func`3<!!0,System.Exception,System.String>)
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
       mov       r9,255ADE44518
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
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,191
       mov       rdx,7FFE64695D18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      System.ArgumentNullException..ctor(System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 246
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingHelperBenchmark.LogInformationBenchmark()
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rax
       mov       rsi,rcx
; 			var testException = new ArgumentInvalidException("TEST EX MESSAGE");
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentInvalidException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+70],0E0434352
       mov       dword ptr [rdi+74],80131500
       mov       rdx,1CAB8B99BC0
       mov       rdx,[rdx]
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rdi+74],80131501
       mov       dword ptr [rdi+74],80070057
; 			for (var index = 0; index < this.Count; index++)
; 			     ^^^^^^^^^^^^^
       xor       ebx,ebx
       cmp       dword ptr [rsi+0A8],0
       jle       short M00_L01
       mov       rcx,1CAB8B99BC8
       mov       rbp,[rcx]
; 				this._logger.LogInformation(100, testException, "INFORMATION ENTRY");
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M00_L00:
       mov       r14,[rsi+0B0]
       xor       r15d,r15d
       mov       r12d,64
       mov       rcx,7FFE643A4928
       mov       edx,2D
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1CAB8B92F78
       mov       rcx,[rcx]
       mov       [rsp+30],r15
       mov       [rsp+38],r12d
       mov       [rsp+20],rbp
       mov       [rsp+28],rcx
       mov       rcx,r14
       lea       r8,[rsp+30]
       mov       r9,rdi
       mov       edx,2
       call      Microsoft.Extensions.Logging.LoggerExtensions.Log(Microsoft.Extensions.Logging.ILogger, Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.Exception, System.String, System.Object[])
       inc       ebx
       cmp       ebx,[rsi+0A8]
       jl        short M00_L00
M00_L01:
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
; Total bytes of code 236
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
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log(Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, !!0, System.Exception, System.Func`3<!!0,System.Exception,System.String>)
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
       mov       r9,1CAB8B98920
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
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,191
       mov       rdx,7FFE646A5D18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      System.ArgumentNullException..ctor(System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 246
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingHelperBenchmark.LogInformationBenchmark()
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rax
       mov       rsi,rcx
; 			var testException = new ArgumentInvalidException("TEST EX MESSAGE");
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentInvalidException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+70],0E0434352
       mov       dword ptr [rdi+74],80131500
       mov       rdx,127F2E01FF8
       mov       rdx,[rdx]
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rdi+74],80131501
       mov       dword ptr [rdi+74],80070057
; 			for (var index = 0; index < this.Count; index++)
; 			     ^^^^^^^^^^^^^
       xor       ebx,ebx
       cmp       dword ptr [rsi+0A8],0
       jle       short M00_L01
       mov       rcx,127F2E02000
       mov       rbp,[rcx]
; 				this._logger.LogInformation(100, testException, "INFORMATION ENTRY");
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M00_L00:
       mov       r14,[rsi+0B0]
       xor       r15d,r15d
       mov       r12d,64
       mov       rcx,7FFE64374928
       mov       edx,2D
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,12812E02F78
       mov       rcx,[rcx]
       mov       [rsp+30],r15
       mov       [rsp+38],r12d
       mov       [rsp+20],rbp
       mov       [rsp+28],rcx
       mov       rcx,r14
       lea       r8,[rsp+30]
       mov       r9,rdi
       mov       edx,2
       call      Microsoft.Extensions.Logging.LoggerExtensions.Log(Microsoft.Extensions.Logging.ILogger, Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.Exception, System.String, System.Object[])
       inc       ebx
       cmp       ebx,[rsi+0A8]
       jl        short M00_L00
M00_L01:
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
; Total bytes of code 236
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
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log(Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, !!0, System.Exception, System.Func`3<!!0,System.Exception,System.String>)
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
       mov       r9,12812E08920
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
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,191
       mov       rdx,7FFE64675D18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      System.ArgumentNullException..ctor(System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 246
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingHelperBenchmark.LogInformationBenchmark()
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rax
       mov       rsi,rcx
; 			var testException = new ArgumentInvalidException("TEST EX MESSAGE");
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentInvalidException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+70],0E0434352
       mov       dword ptr [rdi+74],80131500
       mov       rdx,1FA28F457B8
       mov       rdx,[rdx]
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rdi+74],80131501
       mov       dword ptr [rdi+74],80070057
; 			for (var index = 0; index < this.Count; index++)
; 			     ^^^^^^^^^^^^^
       xor       ebx,ebx
       cmp       dword ptr [rsi+0A8],0
       jle       short M00_L01
       mov       rcx,1FA28F457C0
       mov       rbp,[rcx]
; 				this._logger.LogInformation(100, testException, "INFORMATION ENTRY");
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M00_L00:
       mov       r14,[rsi+0B0]
       xor       r15d,r15d
       mov       r12d,64
       mov       rcx,7FFE64374928
       mov       edx,2D
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1FA48F42F78
       mov       rcx,[rcx]
       mov       [rsp+30],r15
       mov       [rsp+38],r12d
       mov       [rsp+20],rbp
       mov       [rsp+28],rcx
       mov       rcx,r14
       lea       r8,[rsp+30]
       mov       r9,rdi
       mov       edx,2
       call      Microsoft.Extensions.Logging.LoggerExtensions.Log(Microsoft.Extensions.Logging.ILogger, Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.Exception, System.String, System.Object[])
       inc       ebx
       cmp       ebx,[rsi+0A8]
       jl        short M00_L00
M00_L01:
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
; Total bytes of code 236
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
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log(Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, !!0, System.Exception, System.Func`3<!!0,System.Exception,System.String>)
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
       mov       r9,1FA28F44518
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
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,191
       mov       rdx,7FFE64675D18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      System.ArgumentNullException..ctor(System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 246
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingHelperBenchmark.LogInformationBenchmark()
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rax
       mov       rsi,rcx
; 			var testException = new ArgumentInvalidException("TEST EX MESSAGE");
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentInvalidException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+70],0E0434352
       mov       dword ptr [rdi+74],80131500
       mov       rdx,2660FB5A3D8
       mov       rdx,[rdx]
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rdi+74],80131501
       mov       dword ptr [rdi+74],80070057
; 			for (var index = 0; index < this.Count; index++)
; 			     ^^^^^^^^^^^^^
       xor       ebx,ebx
       cmp       dword ptr [rsi+0A8],0
       jle       short M00_L01
       mov       rcx,2660FB5A3E0
       mov       rbp,[rcx]
; 				this._logger.LogInformation(100, testException, "INFORMATION ENTRY");
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M00_L00:
       mov       r14,[rsi+0B0]
       xor       r15d,r15d
       mov       r12d,64
       mov       rcx,7FFE64384928
       mov       edx,2D
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,2660FB52F78
       mov       rcx,[rcx]
       mov       [rsp+30],r15
       mov       [rsp+38],r12d
       mov       [rsp+20],rbp
       mov       [rsp+28],rcx
       mov       rcx,r14
       lea       r8,[rsp+30]
       mov       r9,rdi
       mov       edx,2
       call      Microsoft.Extensions.Logging.LoggerExtensions.Log(Microsoft.Extensions.Logging.ILogger, Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.Exception, System.String, System.Object[])
       inc       ebx
       cmp       ebx,[rsi+0A8]
       jl        short M00_L00
M00_L01:
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
; Total bytes of code 236
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
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log(Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, !!0, System.Exception, System.Func`3<!!0,System.Exception,System.String>)
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
       mov       r9,2660FB58920
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
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,191
       mov       rdx,7FFE64685D18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      System.ArgumentNullException..ctor(System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 246
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingHelperBenchmark.LogInformationBenchmark()
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rax
       mov       rsi,rcx
; 			var testException = new ArgumentInvalidException("TEST EX MESSAGE");
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentInvalidException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+70],0E0434352
       mov       dword ptr [rdi+74],80131500
       mov       rdx,195C5871FF8
       mov       rdx,[rdx]
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rdi+74],80131501
       mov       dword ptr [rdi+74],80070057
; 			for (var index = 0; index < this.Count; index++)
; 			     ^^^^^^^^^^^^^
       xor       ebx,ebx
       cmp       dword ptr [rsi+0A8],0
       jle       short M00_L01
       mov       rcx,195C5872000
       mov       rbp,[rcx]
; 				this._logger.LogInformation(100, testException, "INFORMATION ENTRY");
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M00_L00:
       mov       r14,[rsi+0B0]
       xor       r15d,r15d
       mov       r12d,64
       mov       rcx,7FFE64364928
       mov       edx,2D
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,195F5872F78
       mov       rcx,[rcx]
       mov       [rsp+30],r15
       mov       [rsp+38],r12d
       mov       [rsp+20],rbp
       mov       [rsp+28],rcx
       mov       rcx,r14
       lea       r8,[rsp+30]
       mov       r9,rdi
       mov       edx,2
       call      Microsoft.Extensions.Logging.LoggerExtensions.Log(Microsoft.Extensions.Logging.ILogger, Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.Exception, System.String, System.Object[])
       inc       ebx
       cmp       ebx,[rsi+0A8]
       jl        short M00_L00
M00_L01:
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
; Total bytes of code 236
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
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log(Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, !!0, System.Exception, System.Func`3<!!0,System.Exception,System.String>)
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
       mov       r9,195E5876928
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
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,191
       mov       rdx,7FFE64665D18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      System.ArgumentNullException..ctor(System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 246
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingHelperBenchmark.LogInformationBenchmark()
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rax
       mov       rsi,rcx
; 			var testException = new ArgumentInvalidException("TEST EX MESSAGE");
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentInvalidException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+70],0E0434352
       mov       dword ptr [rdi+74],80131500
       mov       rdx,25A77B467D0
       mov       rdx,[rdx]
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rdi+74],80131501
       mov       dword ptr [rdi+74],80070057
; 			for (var index = 0; index < this.Count; index++)
; 			     ^^^^^^^^^^^^^
       xor       ebx,ebx
       cmp       dword ptr [rsi+0A8],0
       jle       short M00_L01
       mov       rcx,25A77B467D8
       mov       rbp,[rcx]
; 				this._logger.LogInformation(100, testException, "INFORMATION ENTRY");
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M00_L00:
       mov       r14,[rsi+0B0]
       xor       r15d,r15d
       mov       r12d,64
       mov       rcx,7FFE64384928
       mov       edx,2D
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,25A57B42F78
       mov       rcx,[rcx]
       mov       [rsp+30],r15
       mov       [rsp+38],r12d
       mov       [rsp+20],rbp
       mov       [rsp+28],rcx
       mov       rcx,r14
       lea       r8,[rsp+30]
       mov       r9,rdi
       mov       edx,2
       call      Microsoft.Extensions.Logging.LoggerExtensions.Log(Microsoft.Extensions.Logging.ILogger, Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.Exception, System.String, System.Object[])
       inc       ebx
       cmp       ebx,[rsi+0A8]
       jl        short M00_L00
M00_L01:
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
; Total bytes of code 236
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
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log(Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, !!0, System.Exception, System.Func`3<!!0,System.Exception,System.String>)
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
       mov       r9,25A77B44518
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
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,191
       mov       rdx,7FFE64685D18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      System.ArgumentNullException..ctor(System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 246
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingHelperBenchmark.LogTraceBenchmark()
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rax
       mov       rsi,rcx
; 			var testException = new ArgumentInvalidException("TEST EX MESSAGE");
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentInvalidException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+70],0E0434352
       mov       dword ptr [rdi+74],80131500
       mov       rdx,1A64B8B5BE8
       mov       rdx,[rdx]
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rdi+74],80131501
       mov       dword ptr [rdi+74],80070057
; 			for (var index = 0; index < this.Count; index++)
; 			     ^^^^^^^^^^^^^
       xor       ebx,ebx
       cmp       dword ptr [rsi+0A8],0
       jle       short M00_L01
       mov       rcx,1A64B8B5BF0
       mov       rbp,[rcx]
; 				this._logger.LogTrace(100, testException, "TRACE ENTRY");
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M00_L00:
       mov       r14,[rsi+0B0]
       xor       r15d,r15d
       mov       r12d,64
       mov       rcx,7FFE64364928
       mov       edx,2D
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1A64B8B2F78
       mov       rcx,[rcx]
       mov       [rsp+30],r15
       mov       [rsp+38],r12d
       mov       [rsp+20],rbp
       mov       [rsp+28],rcx
       mov       rcx,r14
       lea       r8,[rsp+30]
       mov       r9,rdi
       xor       edx,edx
       call      Microsoft.Extensions.Logging.LoggerExtensions.Log(Microsoft.Extensions.Logging.ILogger, Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.Exception, System.String, System.Object[])
       inc       ebx
       cmp       ebx,[rsi+0A8]
       jl        short M00_L00
M00_L01:
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
; Total bytes of code 233
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
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log(Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, !!0, System.Exception, System.Func`3<!!0,System.Exception,System.String>)
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
       mov       r9,1A67B8B4518
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
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,191
       mov       rdx,7FFE64665D18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      System.ArgumentNullException..ctor(System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 246
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingHelperBenchmark.LogTraceBenchmark()
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rax
       mov       rsi,rcx
; 			var testException = new ArgumentInvalidException("TEST EX MESSAGE");
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentInvalidException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+70],0E0434352
       mov       dword ptr [rdi+74],80131500
       mov       rdx,2B301013010
       mov       rdx,[rdx]
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rdi+74],80131501
       mov       dword ptr [rdi+74],80070057
; 			for (var index = 0; index < this.Count; index++)
; 			     ^^^^^^^^^^^^^
       xor       ebx,ebx
       cmp       dword ptr [rsi+0A8],0
       jle       short M00_L01
       mov       rcx,2B301013018
       mov       rbp,[rcx]
; 				this._logger.LogTrace(100, testException, "TRACE ENTRY");
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M00_L00:
       mov       r14,[rsi+0B0]
       xor       r15d,r15d
       mov       r12d,64
       mov       rcx,7FFE64394928
       mov       edx,2D
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,2B321012F78
       mov       rcx,[rcx]
       mov       [rsp+30],r15
       mov       [rsp+38],r12d
       mov       [rsp+20],rbp
       mov       [rsp+28],rcx
       mov       rcx,r14
       lea       r8,[rsp+30]
       mov       r9,rdi
       xor       edx,edx
       call      Microsoft.Extensions.Logging.LoggerExtensions.Log(Microsoft.Extensions.Logging.ILogger, Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.Exception, System.String, System.Object[])
       inc       ebx
       cmp       ebx,[rsi+0A8]
       jl        short M00_L00
M00_L01:
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
; Total bytes of code 233
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
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log(Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, !!0, System.Exception, System.Func`3<!!0,System.Exception,System.String>)
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
       mov       r9,2B321018920
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
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,191
       mov       rdx,7FFE64695D18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      System.ArgumentNullException..ctor(System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 246
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingHelperBenchmark.LogTraceBenchmark()
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rax
       mov       rsi,rcx
; 			var testException = new ArgumentInvalidException("TEST EX MESSAGE");
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentInvalidException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+70],0E0434352
       mov       dword ptr [rdi+74],80131500
       mov       rdx,1D022E277B0
       mov       rdx,[rdx]
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rdi+74],80131501
       mov       dword ptr [rdi+74],80070057
; 			for (var index = 0; index < this.Count; index++)
; 			     ^^^^^^^^^^^^^
       xor       ebx,ebx
       cmp       dword ptr [rsi+0A8],0
       jle       short M00_L01
       mov       rcx,1D022E277B8
       mov       rbp,[rcx]
; 				this._logger.LogTrace(100, testException, "TRACE ENTRY");
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M00_L00:
       mov       r14,[rsi+0B0]
       xor       r15d,r15d
       mov       r12d,64
       mov       rcx,7FFE64374928
       mov       edx,2D
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1D022E22F78
       mov       rcx,[rcx]
       mov       [rsp+30],r15
       mov       [rsp+38],r12d
       mov       [rsp+20],rbp
       mov       [rsp+28],rcx
       mov       rcx,r14
       lea       r8,[rsp+30]
       mov       r9,rdi
       xor       edx,edx
       call      Microsoft.Extensions.Logging.LoggerExtensions.Log(Microsoft.Extensions.Logging.ILogger, Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.Exception, System.String, System.Object[])
       inc       ebx
       cmp       ebx,[rsi+0A8]
       jl        short M00_L00
M00_L01:
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
; Total bytes of code 233
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
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log(Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, !!0, System.Exception, System.Func`3<!!0,System.Exception,System.String>)
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
       mov       r9,1D022E26510
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
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,191
       mov       rdx,7FFE64675D18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      System.ArgumentNullException..ctor(System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 246
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingHelperBenchmark.LogTraceBenchmark()
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rax
       mov       rsi,rcx
; 			var testException = new ArgumentInvalidException("TEST EX MESSAGE");
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentInvalidException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+70],0E0434352
       mov       dword ptr [rdi+74],80131500
       mov       rdx,2A5BDB55008
       mov       rdx,[rdx]
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rdi+74],80131501
       mov       dword ptr [rdi+74],80070057
; 			for (var index = 0; index < this.Count; index++)
; 			     ^^^^^^^^^^^^^
       xor       ebx,ebx
       cmp       dword ptr [rsi+0A8],0
       jle       short M00_L01
       mov       rcx,2A5BDB55010
       mov       rbp,[rcx]
; 				this._logger.LogTrace(100, testException, "TRACE ENTRY");
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M00_L00:
       mov       r14,[rsi+0B0]
       xor       r15d,r15d
       mov       r12d,64
       mov       rcx,7FFE64374928
       mov       edx,2D
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,2A5BDB52F78
       mov       rcx,[rcx]
       mov       [rsp+30],r15
       mov       [rsp+38],r12d
       mov       [rsp+20],rbp
       mov       [rsp+28],rcx
       mov       rcx,r14
       lea       r8,[rsp+30]
       mov       r9,rdi
       xor       edx,edx
       call      Microsoft.Extensions.Logging.LoggerExtensions.Log(Microsoft.Extensions.Logging.ILogger, Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.Exception, System.String, System.Object[])
       inc       ebx
       cmp       ebx,[rsi+0A8]
       jl        short M00_L00
M00_L01:
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
; Total bytes of code 233
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
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log(Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, !!0, System.Exception, System.Func`3<!!0,System.Exception,System.String>)
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
       mov       r9,2A5DDB56928
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
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,191
       mov       rdx,7FFE64675D18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      System.ArgumentNullException..ctor(System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 246
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingHelperBenchmark.LogTraceBenchmark()
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rax
       mov       rsi,rcx
; 			var testException = new ArgumentInvalidException("TEST EX MESSAGE");
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentInvalidException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+70],0E0434352
       mov       dword ptr [rdi+74],80131500
       mov       rdx,19729F75420
       mov       rdx,[rdx]
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rdi+74],80131501
       mov       dword ptr [rdi+74],80070057
; 			for (var index = 0; index < this.Count; index++)
; 			     ^^^^^^^^^^^^^
       xor       ebx,ebx
       cmp       dword ptr [rsi+0A8],0
       jle       short M00_L01
       mov       rcx,19729F75428
       mov       rbp,[rcx]
; 				this._logger.LogTrace(100, testException, "TRACE ENTRY");
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M00_L00:
       mov       r14,[rsi+0B0]
       xor       r15d,r15d
       mov       r12d,64
       mov       rcx,7FFE64374928
       mov       edx,2D
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,19729F72F78
       mov       rcx,[rcx]
       mov       [rsp+30],r15
       mov       [rsp+38],r12d
       mov       [rsp+20],rbp
       mov       [rsp+28],rcx
       mov       rcx,r14
       lea       r8,[rsp+30]
       mov       r9,rdi
       xor       edx,edx
       call      Microsoft.Extensions.Logging.LoggerExtensions.Log(Microsoft.Extensions.Logging.ILogger, Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.Exception, System.String, System.Object[])
       inc       ebx
       cmp       ebx,[rsi+0A8]
       jl        short M00_L00
M00_L01:
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
; Total bytes of code 233
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
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log(Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, !!0, System.Exception, System.Func`3<!!0,System.Exception,System.String>)
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
       mov       r9,19749F76510
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
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,191
       mov       rdx,7FFE64675D18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      System.ArgumentNullException..ctor(System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 246
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingHelperBenchmark.LogTraceBenchmark()
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rax
       mov       rsi,rcx
; 			var testException = new ArgumentInvalidException("TEST EX MESSAGE");
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentInvalidException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+70],0E0434352
       mov       dword ptr [rdi+74],80131500
       mov       rdx,136B6544408
       mov       rdx,[rdx]
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rdi+74],80131501
       mov       dword ptr [rdi+74],80070057
; 			for (var index = 0; index < this.Count; index++)
; 			     ^^^^^^^^^^^^^
       xor       ebx,ebx
       cmp       dword ptr [rsi+0A8],0
       jle       short M00_L01
       mov       rcx,136B6544410
       mov       rbp,[rcx]
; 				this._logger.LogTrace(100, testException, "TRACE ENTRY");
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M00_L00:
       mov       r14,[rsi+0B0]
       xor       r15d,r15d
       mov       r12d,64
       mov       rcx,7FFE64384928
       mov       edx,2D
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,136B6542F78
       mov       rcx,[rcx]
       mov       [rsp+30],r15
       mov       [rsp+38],r12d
       mov       [rsp+20],rbp
       mov       [rsp+28],rcx
       mov       rcx,r14
       lea       r8,[rsp+30]
       mov       r9,rdi
       xor       edx,edx
       call      Microsoft.Extensions.Logging.LoggerExtensions.Log(Microsoft.Extensions.Logging.ILogger, Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.Exception, System.String, System.Object[])
       inc       ebx
       cmp       ebx,[rsi+0A8]
       jl        short M00_L00
M00_L01:
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
; Total bytes of code 233
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
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log(Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, !!0, System.Exception, System.Func`3<!!0,System.Exception,System.String>)
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
       mov       r9,136D6546510
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
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,191
       mov       rdx,7FFE64685D18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      System.ArgumentNullException..ctor(System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 246
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingHelperBenchmark.LogTraceBenchmark()
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rax
       mov       rsi,rcx
; 			var testException = new ArgumentInvalidException("TEST EX MESSAGE");
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentInvalidException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+70],0E0434352
       mov       dword ptr [rdi+74],80131500
       mov       rdx,1D8A3387BC8
       mov       rdx,[rdx]
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rdi+74],80131501
       mov       dword ptr [rdi+74],80070057
; 			for (var index = 0; index < this.Count; index++)
; 			     ^^^^^^^^^^^^^
       xor       ebx,ebx
       cmp       dword ptr [rsi+0A8],0
       jle       short M00_L01
       mov       rcx,1D8A3387BD0
       mov       rbp,[rcx]
; 				this._logger.LogTrace(100, testException, "TRACE ENTRY");
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M00_L00:
       mov       r14,[rsi+0B0]
       xor       r15d,r15d
       mov       r12d,64
       mov       rcx,7FFE64394928
       mov       edx,2D
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1D8B3382F78
       mov       rcx,[rcx]
       mov       [rsp+30],r15
       mov       [rsp+38],r12d
       mov       [rsp+20],rbp
       mov       [rsp+28],rcx
       mov       rcx,r14
       lea       r8,[rsp+30]
       mov       r9,rdi
       xor       edx,edx
       call      Microsoft.Extensions.Logging.LoggerExtensions.Log(Microsoft.Extensions.Logging.ILogger, Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.Exception, System.String, System.Object[])
       inc       ebx
       cmp       ebx,[rsi+0A8]
       jl        short M00_L00
M00_L01:
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
; Total bytes of code 233
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
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log(Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, !!0, System.Exception, System.Func`3<!!0,System.Exception,System.String>)
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
       mov       r9,1D8A3386928
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
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,191
       mov       rdx,7FFE64695D18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      System.ArgumentNullException..ctor(System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 246
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingHelperBenchmark.LogTraceBenchmark()
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rax
       mov       rsi,rcx
; 			var testException = new ArgumentInvalidException("TEST EX MESSAGE");
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentInvalidException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+70],0E0434352
       mov       dword ptr [rdi+74],80131500
       mov       rdx,2DDB5CE47F0
       mov       rdx,[rdx]
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rdi+74],80131501
       mov       dword ptr [rdi+74],80070057
; 			for (var index = 0; index < this.Count; index++)
; 			     ^^^^^^^^^^^^^
       xor       ebx,ebx
       cmp       dword ptr [rsi+0A8],0
       jle       short M00_L01
       mov       rcx,2DDB5CE47F8
       mov       rbp,[rcx]
; 				this._logger.LogTrace(100, testException, "TRACE ENTRY");
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M00_L00:
       mov       r14,[rsi+0B0]
       xor       r15d,r15d
       mov       r12d,64
       mov       rcx,7FFE64394928
       mov       edx,2D
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,2DDB5CE2F78
       mov       rcx,[rcx]
       mov       [rsp+30],r15
       mov       [rsp+38],r12d
       mov       [rsp+20],rbp
       mov       [rsp+28],rcx
       mov       rcx,r14
       lea       r8,[rsp+30]
       mov       r9,rdi
       xor       edx,edx
       call      Microsoft.Extensions.Logging.LoggerExtensions.Log(Microsoft.Extensions.Logging.ILogger, Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.Exception, System.String, System.Object[])
       inc       ebx
       cmp       ebx,[rsi+0A8]
       jl        short M00_L00
M00_L01:
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
; Total bytes of code 233
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
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log(Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, !!0, System.Exception, System.Func`3<!!0,System.Exception,System.String>)
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
       mov       r9,2DDC5CE4518
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
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,191
       mov       rdx,7FFE64695D18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      System.ArgumentNullException..ctor(System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 246
```
