## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       r9,[rsi+290]
       mov       rdx,r9
       cmp       dword ptr [r9+8],1
       setg      r9b
       movzx     r9d,r9b
       mov       r8,[rsi+30]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, Boolean)
       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
       mov       [rsp+28],rax
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 92
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rdx
       mov       rdi,r8
       test      rdi,rdi
       jne       short M01_L00
       mov       rax,rsi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L00:
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       je        short M01_L04
       test      r9b,r9b
       jne       short M01_L01
       mov       rax,rsi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L01:
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rdx,7FFD67B49C88
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L03:
       mov       rcx,rdx
       mov       rdx,rsi
       mov       r8,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
M01_L04:
       mov       ecx,4D
       mov       rdx,7FFD67929868
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,4F
       mov       rdx,7FFD67929868
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
; Total bytes of code 187
```

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       r9,[rsi+290]
       mov       rdi,r9
       mov       rbx,[rsi+30]
       cmp       dword ptr [r9+8],1
       setg      r9b
       movzx     r9d,r9b
       test      rbx,rbx
       jne       short M00_L00
       jmp       short M00_L02
M00_L00:
       test      r9d,r9d
       jne       short M00_L01
       jmp       short M00_L02
M00_L01:
       mov       rdx,rdi
       mov       r9,1917B4041C0
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,1917F402028
       mov       r9,[r9]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], System.String, System.String)
       xor       r8d,r8d
       call      qword ptr [7FFD52825588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       rdx,rax
       mov       r8,rbx
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       call      qword ptr [7FFD52A3D450]
       mov       rdi,rax
M00_L02:
       mov       [rsp+28],rdi
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[] ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFD52A35438]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 177
```
```assembly
; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-4],eax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       xor       eax,eax
       cmp       qword ptr [rbp+18],0
       setne     al
       mov       [rbp-4],eax
       cmp       dword ptr [rbp-4],0
       jne       short M01_L00
       cmp       qword ptr [rbp+20],0
       je        short M01_L00
       mov       rax,[rbp+20]
       mov       [rbp+18],rax
       jmp       short M01_L01
M01_L00:
       cmp       dword ptr [rbp-4],0
       jne       short M01_L01
       call      qword ptr [7FFD52825A98]
       mov       [rbp-10],rax
       mov       r8,[rbp-10]
       mov       rdx,[rbp+30]
       mov       rcx,[rbp+28]
       call      qword ptr [7FFD527C9000]
       mov       rcx,rax
       call      qword ptr [7FFD52825CF0]
M01_L01:
       mov       rax,[rbp+18]
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 124
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
       mov       rdx,[r8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       pop       rsi
       ret
; Total bytes of code 24
```

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       r9,[rsi+290]
       mov       rdx,r9
       cmp       dword ptr [r9+8],1
       setg      r9b
       movzx     r9d,r9b
       mov       r8,[rsi+30]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, Boolean)
       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
       mov       [rsp+28],rax
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 92
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rdx
       mov       rdi,r8
       test      rdi,rdi
       jne       short M01_L00
       mov       rax,rsi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L00:
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       je        short M01_L04
       test      r9b,r9b
       jne       short M01_L01
       mov       rax,rsi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L01:
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rdx,7FFD67B29D30
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L03:
       mov       rcx,rdx
       mov       rdx,rsi
       mov       r8,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
M01_L04:
       mov       ecx,4D
       mov       rdx,7FFD67909868
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,4F
       mov       rdx,7FFD67909868
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
; Total bytes of code 187
```

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       r9,[rsi+290]
       mov       rdi,r9
       mov       rbx,[rsi+30]
       cmp       dword ptr [r9+8],1
       setg      r9b
       movzx     r9d,r9b
       test      rbx,rbx
       jne       short M00_L00
       jmp       short M00_L02
M00_L00:
       test      r9d,r9d
       jne       short M00_L01
       jmp       short M00_L02
M00_L01:
       mov       rdx,rdi
       mov       r9,17A428085C8
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,17A42802028
       mov       r9,[r9]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], System.String, System.String)
       xor       r8d,r8d
       call      qword ptr [7FFD52835588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       rdx,rax
       mov       r8,rbx
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       call      qword ptr [7FFD52A4DA98]
       mov       rdi,rax
M00_L02:
       mov       [rsp+28],rdi
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[] ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFD52A450F0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 177
```
```assembly
; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-4],eax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       xor       eax,eax
       cmp       qword ptr [rbp+18],0
       setne     al
       mov       [rbp-4],eax
       cmp       dword ptr [rbp-4],0
       jne       short M01_L00
       cmp       qword ptr [rbp+20],0
       je        short M01_L00
       mov       rax,[rbp+20]
       mov       [rbp+18],rax
       jmp       short M01_L01
M01_L00:
       cmp       dword ptr [rbp-4],0
       jne       short M01_L01
       call      qword ptr [7FFD52835A98]
       mov       [rbp-10],rax
       mov       r8,[rbp-10]
       mov       rdx,[rbp+30]
       mov       rcx,[rbp+28]
       call      qword ptr [7FFD527D9000]
       mov       rcx,rax
       call      qword ptr [7FFD52835CF0]
M01_L01:
       mov       rax,[rbp+18]
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 124
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
       mov       rdx,[r8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       pop       rsi
       ret
; Total bytes of code 24
```

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       r9,[rsi+290]
       mov       rdx,r9
       cmp       dword ptr [r9+8],1
       setg      r9b
       movzx     r9d,r9b
       mov       r8,[rsi+30]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, Boolean)
       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
       mov       [rsp+28],rax
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 92
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rdx
       mov       rdi,r8
       test      rdi,rdi
       jne       short M01_L00
       mov       rax,rsi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L00:
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       je        short M01_L04
       test      r9b,r9b
       jne       short M01_L01
       mov       rax,rsi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L01:
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rdx,7FFD67B29C88
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L03:
       mov       rcx,rdx
       mov       rdx,rsi
       mov       r8,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
M01_L04:
       mov       ecx,4D
       mov       rdx,7FFD67909868
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,4F
       mov       rdx,7FFD67909868
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
; Total bytes of code 187
```

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       r9,[rsi+290]
       mov       rdi,r9
       mov       rbx,[rsi+30]
       cmp       dword ptr [r9+8],1
       setg      r9b
       movzx     r9d,r9b
       test      rbx,rbx
       jne       short M00_L00
       jmp       short M00_L02
M00_L00:
       test      r9d,r9d
       jne       short M00_L01
       jmp       short M00_L02
M00_L01:
       mov       rdx,rdi
       mov       r9,1AA03C085C8
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,1AA03C02028
       mov       r9,[r9]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], System.String, System.String)
       xor       r8d,r8d
       call      qword ptr [7FFD52845588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       rdx,rax
       mov       r8,rbx
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       call      qword ptr [7FFD52A5DF30]
       mov       rdi,rax
M00_L02:
       mov       [rsp+28],rdi
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[] ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFD52A550F0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 177
```
```assembly
; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-4],eax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       xor       eax,eax
       cmp       qword ptr [rbp+18],0
       setne     al
       mov       [rbp-4],eax
       cmp       dword ptr [rbp-4],0
       jne       short M01_L00
       cmp       qword ptr [rbp+20],0
       je        short M01_L00
       mov       rax,[rbp+20]
       mov       [rbp+18],rax
       jmp       short M01_L01
M01_L00:
       cmp       dword ptr [rbp-4],0
       jne       short M01_L01
       call      qword ptr [7FFD52845A98]
       mov       [rbp-10],rax
       mov       r8,[rbp-10]
       mov       rdx,[rbp+30]
       mov       rcx,[rbp+28]
       call      qword ptr [7FFD527E9000]
       mov       rcx,rax
       call      qword ptr [7FFD52845CF0]
M01_L01:
       mov       rax,[rbp+18]
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 124
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
       mov       rdx,[r8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       pop       rsi
       ret
; Total bytes of code 24
```

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       r9,[rsi+290]
       mov       rdx,r9
       cmp       dword ptr [r9+8],1
       setg      r9b
       movzx     r9d,r9b
       mov       r8,[rsi+30]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, Boolean)
       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
       mov       [rsp+28],rax
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 92
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rdx
       mov       rdi,r8
       test      rdi,rdi
       jne       short M01_L00
       mov       rax,rsi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L00:
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       je        short M01_L04
       test      r9b,r9b
       jne       short M01_L01
       mov       rax,rsi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L01:
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rdx,7FFD67B39CD8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L03:
       mov       rcx,rdx
       mov       rdx,rsi
       mov       r8,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
M01_L04:
       mov       ecx,4D
       mov       rdx,7FFD67919868
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,4F
       mov       rdx,7FFD67919868
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
; Total bytes of code 187
```

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       r9,[rsi+290]
       mov       rdi,r9
       mov       rbx,[rsi+30]
       cmp       dword ptr [r9+8],1
       setg      r9b
       movzx     r9d,r9b
       test      rbx,rbx
       jne       short M00_L00
       jmp       short M00_L02
M00_L00:
       test      r9d,r9d
       jne       short M00_L01
       jmp       short M00_L02
M00_L01:
       mov       rdx,rdi
       mov       r9,18BF84085C8
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,18BF8402028
       mov       r9,[r9]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], System.String, System.String)
       xor       r8d,r8d
       call      qword ptr [7FFD52825588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       rdx,rax
       mov       r8,rbx
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       call      qword ptr [7FFD52A3DF48]
       mov       rdi,rax
M00_L02:
       mov       [rsp+28],rdi
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[] ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFD52A330F0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 177
```
```assembly
; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-4],eax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       xor       eax,eax
       cmp       qword ptr [rbp+18],0
       setne     al
       mov       [rbp-4],eax
       cmp       dword ptr [rbp-4],0
       jne       short M01_L00
       cmp       qword ptr [rbp+20],0
       je        short M01_L00
       mov       rax,[rbp+20]
       mov       [rbp+18],rax
       jmp       short M01_L01
M01_L00:
       cmp       dword ptr [rbp-4],0
       jne       short M01_L01
       call      qword ptr [7FFD52825A98]
       mov       [rbp-10],rax
       mov       r8,[rbp-10]
       mov       rdx,[rbp+30]
       mov       rcx,[rbp+28]
       call      qword ptr [7FFD527C9000]
       mov       rcx,rax
       call      qword ptr [7FFD52825CF0]
M01_L01:
       mov       rax,[rbp+18]
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 124
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
       mov       rdx,[r8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       pop       rsi
       ret
; Total bytes of code 24
```

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       r9,[rsi+290]
       mov       rdx,r9
       cmp       dword ptr [r9+8],1
       setg      r9b
       movzx     r9d,r9b
       mov       r8,[rsi+30]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, Boolean)
       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
       mov       [rsp+28],rax
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 92
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rdx
       mov       rdi,r8
       test      rdi,rdi
       jne       short M01_L00
       mov       rax,rsi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L00:
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       je        short M01_L04
       test      r9b,r9b
       jne       short M01_L01
       mov       rax,rsi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L01:
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rdx,7FFD67B19C88
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L03:
       mov       rcx,rdx
       mov       rdx,rsi
       mov       r8,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
M01_L04:
       mov       ecx,4D
       mov       rdx,7FFD678F9868
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,4F
       mov       rdx,7FFD678F9868
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
; Total bytes of code 187
```

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       r9,[rsi+290]
       mov       rdi,r9
       mov       rbx,[rsi+30]
       cmp       dword ptr [r9+8],1
       setg      r9b
       movzx     r9d,r9b
       test      rbx,rbx
       jne       short M00_L00
       jmp       short M00_L02
M00_L00:
       test      r9d,r9d
       jne       short M00_L01
       jmp       short M00_L02
M00_L01:
       mov       rdx,rdi
       mov       r9,23B3A4085C8
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,23B3A402028
       mov       r9,[r9]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], System.String, System.String)
       xor       r8d,r8d
       call      qword ptr [7FFD52835588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       rdx,rax
       mov       r8,rbx
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       call      qword ptr [7FFD52A4DB10]
       mov       rdi,rax
M00_L02:
       mov       [rsp+28],rdi
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[] ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFD52A459A8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 177
```
```assembly
; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-4],eax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       xor       eax,eax
       cmp       qword ptr [rbp+18],0
       setne     al
       mov       [rbp-4],eax
       cmp       dword ptr [rbp-4],0
       jne       short M01_L00
       cmp       qword ptr [rbp+20],0
       je        short M01_L00
       mov       rax,[rbp+20]
       mov       [rbp+18],rax
       jmp       short M01_L01
M01_L00:
       cmp       dword ptr [rbp-4],0
       jne       short M01_L01
       call      qword ptr [7FFD52835A98]
       mov       [rbp-10],rax
       mov       r8,[rbp-10]
       mov       rdx,[rbp+30]
       mov       rcx,[rbp+28]
       call      qword ptr [7FFD527D9000]
       mov       rcx,rax
       call      qword ptr [7FFD52835CF0]
M01_L01:
       mov       rax,[rbp+18]
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 124
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
       mov       rdx,[r8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       pop       rsi
       ret
; Total bytes of code 24
```

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       r9,[rsi+290]
       mov       rdx,r9
       cmp       dword ptr [r9+8],1
       setg      r9b
       movzx     r9d,r9b
       mov       r8,[rsi+30]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, Boolean)
       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
       mov       [rsp+28],rax
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 92
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rdx
       mov       rdi,r8
       test      rdi,rdi
       jne       short M01_L00
       mov       rax,rsi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L00:
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       je        short M01_L04
       test      r9b,r9b
       jne       short M01_L01
       mov       rax,rsi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L01:
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rdx,7FFD67B59C88
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L03:
       mov       rcx,rdx
       mov       rdx,rsi
       mov       r8,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
M01_L04:
       mov       ecx,4D
       mov       rdx,7FFD67939868
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,4F
       mov       rdx,7FFD67939868
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
; Total bytes of code 187
```

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       r9,[rsi+290]
       mov       rdi,r9
       mov       rbx,[rsi+30]
       cmp       dword ptr [r9+8],1
       setg      r9b
       movzx     r9d,r9b
       test      rbx,rbx
       jne       short M00_L00
       jmp       short M00_L02
M00_L00:
       test      r9d,r9d
       jne       short M00_L01
       jmp       short M00_L02
M00_L01:
       mov       rdx,rdi
       mov       r9,1D3F10085C8
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,1D3F1002028
       mov       r9,[r9]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], System.String, System.String)
       xor       r8d,r8d
       call      qword ptr [7FFD52835588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       rdx,rax
       mov       r8,rbx
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       call      qword ptr [7FFD52A4DF48]
       mov       rdi,rax
M00_L02:
       mov       [rsp+28],rdi
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[] ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFD52A430F0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 177
```
```assembly
; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-4],eax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       xor       eax,eax
       cmp       qword ptr [rbp+18],0
       setne     al
       mov       [rbp-4],eax
       cmp       dword ptr [rbp-4],0
       jne       short M01_L00
       cmp       qword ptr [rbp+20],0
       je        short M01_L00
       mov       rax,[rbp+20]
       mov       [rbp+18],rax
       jmp       short M01_L01
M01_L00:
       cmp       dword ptr [rbp-4],0
       jne       short M01_L01
       call      qword ptr [7FFD52835A98]
       mov       [rbp-10],rax
       mov       r8,[rbp-10]
       mov       rdx,[rbp+30]
       mov       rcx,[rbp+28]
       call      qword ptr [7FFD527D9000]
       mov       rcx,rax
       call      qword ptr [7FFD52835CF0]
M01_L01:
       mov       rax,[rbp+18]
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 124
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
       mov       rdx,[r8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       pop       rsi
       ret
; Total bytes of code 24
```

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       r9,[rsi+290]
       mov       rdx,r9
       cmp       dword ptr [r9+8],1
       setg      r9b
       movzx     r9d,r9b
       mov       r8,[rsi+30]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, Boolean)
       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
       mov       [rsp+28],rax
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 92
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Boolean)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rdx
       mov       rdi,r8
       test      rdi,rdi
       jne       short M01_L00
       mov       rax,rsi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L00:
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       je        short M01_L04
       test      r9b,r9b
       jne       short M01_L01
       mov       rax,rsi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L01:
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rdx,7FFD67B49C88
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L03:
       mov       rcx,rdx
       mov       rdx,rsi
       mov       r8,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ArrayExtensions.Add[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
M01_L04:
       mov       ecx,4D
       mov       rdx,7FFD67929868
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,4F
       mov       rdx,7FFD67929868
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
; Total bytes of code 187
```

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf01()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       r9,[rsi+290]
       mov       rdi,r9
       mov       rbx,[rsi+30]
       cmp       dword ptr [r9+8],1
       setg      r9b
       movzx     r9d,r9b
       test      rbx,rbx
       jne       short M00_L00
       jmp       short M00_L02
M00_L00:
       test      r9d,r9d
       jne       short M00_L01
       jmp       short M00_L02
M00_L01:
       mov       rdx,rdi
       mov       r9,1439F0085C8
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,1439F002028
       mov       r9,[r9]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], System.String, System.String)
       xor       r8d,r8d
       call      qword ptr [7FFD52855588]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       rdx,rax
       mov       r8,rbx
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       call      qword ptr [7FFD52A6F1C8]
       mov       rdi,rax
M00_L02:
       mov       [rsp+28],rdi
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[], DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper[] ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFD52A659A8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 177
```
```assembly
; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-4],eax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       xor       eax,eax
       cmp       qword ptr [rbp+18],0
       setne     al
       mov       [rbp-4],eax
       cmp       dword ptr [rbp-4],0
       jne       short M01_L00
       cmp       qword ptr [rbp+20],0
       je        short M01_L00
       mov       rax,[rbp+20]
       mov       [rbp+18],rax
       jmp       short M01_L01
M01_L00:
       cmp       dword ptr [rbp-4],0
       jne       short M01_L01
       call      qword ptr [7FFD52855A98]
       mov       [rbp-10],rax
       mov       r8,[rbp-10]
       mov       rdx,[rbp+30]
       mov       rcx,[rbp+28]
       call      qword ptr [7FFD527F9000]
       mov       rcx,rax
       call      qword ptr [7FFD52855CF0]
M01_L01:
       mov       rax,[rbp+18]
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 124
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
       mov       rdx,[r8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       pop       rsi
       ret
; Total bytes of code 24
```

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,110
       xor       eax,eax
       mov       [rsp+98],rax
       mov       rbx,rcx
       mov       rbp,[rbx+288]
       mov       r14,rbp
       lea       rsi,[rbx+0A0]
       lea       rdi,[rsp+0A0]
       mov       ecx,0E
       rep movsq
       lea       rdi,[rsp+28]
       lea       rsi,[rsp+0A0]
       mov       ecx,0E
       rep movsq
       mov       rcx,r14
       lea       rdx,[rsp+28]
       cmp       dword ptr [rbp+8],1
       setg      r8b
       movzx     r8d,r8b
       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
       mov       [rsp+98],rax
       mov       rsi,[rbx+18]
       mov       rdx,[rsp+98]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,110
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 154
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,110
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       rax,0FFFFFFFFFFFFFF40
M01_L00:
       vmovdqa   xmmword ptr [rsp+rax+110],xmm4
       vmovdqa   xmmword ptr [rsp+rax+120],xmm4
       vmovdqa   xmmword ptr [rsp+rax+130],xmm4
       add       rax,30
       jne       short M01_L00
       mov       rbx,rcx
       test      rbx,rbx
       setne     al
       movzx     eax,al
       test      eax,eax
       je        near ptr M01_L03
       test      r8b,r8b
       jne       short M01_L01
       mov       rax,rbx
       add       rsp,110
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L01:
       lea       rdi,[rsp+0A0]
       mov       rsi,rdx
       mov       ecx,0E
       rep movsq
       mov       rcx,rbx
       mov       [rsp+28],rcx
       lea       rdi,[rsp+30]
       lea       rsi,[rsp+0A0]
       mov       ecx,0E
       rep movsq
       mov       rdx,[rsp+28]
       test      rdx,rdx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M01_L03
       mov       [rsp+28],rdx
       mov       rdx,[rsp+28]
       mov       edx,[rdx+8]
       add       edx,1
       jo        near ptr M01_L02
       lea       rcx,[rsp+28]
       call      System.Array.Resize[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[] ByRef, Int32)
       mov       rax,[rsp+28]
       mov       eax,[rax+8]
       lea       edx,[rax-1]
       cmp       edx,eax
       jae       near ptr M01_L04
       mov       rax,[rsp+28]
       movsxd    rdx,edx
       imul      rdx,70
       lea       rdi,[rax+rdx+10]
       lea       rsi,[rsp+30]
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       movsq
       mov       rax,[rsp+28]
       add       rsp,110
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L02:
       call      CORINFO_HELP_OVERFLOW
M01_L03:
       mov       ecx,4D
       mov       rdx,7FFD67929868
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,4F
       mov       rdx,7FFD67929868
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 423
```

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,1F0
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       rax,0FFFFFFFFFFFFFF40
M00_L00:
       vmovdqa   xmmword ptr [rsp+rax+110],xmm4
       vmovdqa   xmmword ptr [rsp+rax+120],xmm4
       vmovdqa   xmmword ptr [rsp+rax+130],xmm4
       add       rax,30
       jne       short M00_L00
       mov       rbx,rcx
       mov       rbp,[rbx+288]
       mov       r14,rbp
       lea       rsi,[rbx+0A0]
       lea       rdi,[rsp+180]
       mov       ecx,0E
       rep movsq
       lea       rdi,[rsp+110]
       lea       rsi,[rsp+180]
       mov       ecx,0E
       rep movsq
       xor       ecx,ecx
       cmp       dword ptr [rbp+8],1
       setg      cl
       test      ecx,ecx
       jne       short M00_L01
       jmp       short M00_L02
M00_L01:
       lea       rdi,[rsp+0A0]
       lea       rsi,[rsp+110]
       mov       ecx,0E
       rep movsq
       mov       rbp,r14
       lea       rdi,[rsp+28]
       lea       rsi,[rsp+0A0]
       mov       ecx,0E
       rep movsq
       mov       rcx,rbp
       lea       rdx,[rsp+28]
       call      qword ptr [7FFD52A43138]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       mov       r14,rax
M00_L02:
       mov       [rsp+98],r14
       mov       rcx,[rbx+18]
       lea       r8,[rsp+98]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[] ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFD52A43288]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,1F0
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 272
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+50],rcx
       mov       rsi,rdx
       mov       rdi,[rsp+50]
       test      rdi,rdi
       jne       near ptr M01_L03
       call      qword ptr [7FFD52835A98]
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       cmp       dword ptr [rbx+8],5
       jl        near ptr M01_L05
       lea       rcx,[rbx+0C]
       mov       rdx,1685C8085C8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FFD524799F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbx+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L06
       lea       rcx,[rbx+16]
       mov       rdx,1685C802090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFD524799F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [rbx+8],0
       je        short M01_L02
       mov       rcx,rbx
M01_L00:
       test      rcx,rcx
       jne       short M01_L01
       mov       eax,1
       jmp       near ptr M01_L07
M01_L01:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L07
M01_L02:
       mov       rdx,1685C802028
       mov       rcx,[rdx]
       jmp       short M01_L00
M01_L03:
       mov       [rsp+50],rdi
       mov       rdx,[rsp+50]
       mov       edx,[rdx+8]
       add       edx,1
       jo        short M01_L04
       lea       rcx,[rsp+50]
       call      qword ptr [7FFD52A431E0]; System.Array.Resize[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[] ByRef, Int32)
       mov       rax,[rsp+50]
       mov       eax,[rax+8]
       lea       edx,[rax-1]
       cmp       edx,eax
       jae       near ptr M01_L09
       mov       rax,[rsp+50]
       mov       edx,edx
       imul      rdx,70
       lea       rdi,[rax+rdx+10]
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       movsq
       mov       rax,[rsp+50]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L04:
       call      CORINFO_HELP_OVERFLOW
M01_L05:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFD525D1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L06:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFD525D1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L07:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L08
       call      qword ptr [7FFD52835BB8]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FFD52649A38
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFD52649A38
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFD527D9270]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFD52835798]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFD52835C78]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFD5260D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L08:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFD52433510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFD52835798]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFD5260D8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M01_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 633
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
       mov       rdx,[r8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       pop       rsi
       ret
; Total bytes of code 24
```

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,110
       xor       eax,eax
       mov       [rsp+98],rax
       mov       rbx,rcx
       mov       rbp,[rbx+288]
       mov       r14,rbp
       lea       rsi,[rbx+0A0]
       lea       rdi,[rsp+0A0]
       mov       ecx,0E
       rep movsq
       lea       rdi,[rsp+28]
       lea       rsi,[rsp+0A0]
       mov       ecx,0E
       rep movsq
       mov       rcx,r14
       lea       rdx,[rsp+28]
       cmp       dword ptr [rbp+8],1
       setg      r8b
       movzx     r8d,r8b
       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
       mov       [rsp+98],rax
       mov       rsi,[rbx+18]
       mov       rdx,[rsp+98]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,110
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 154
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,110
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       rax,0FFFFFFFFFFFFFF40
M01_L00:
       vmovdqa   xmmword ptr [rsp+rax+110],xmm4
       vmovdqa   xmmword ptr [rsp+rax+120],xmm4
       vmovdqa   xmmword ptr [rsp+rax+130],xmm4
       add       rax,30
       jne       short M01_L00
       mov       rbx,rcx
       test      rbx,rbx
       setne     al
       movzx     eax,al
       test      eax,eax
       je        near ptr M01_L03
       test      r8b,r8b
       jne       short M01_L01
       mov       rax,rbx
       add       rsp,110
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L01:
       lea       rdi,[rsp+0A0]
       mov       rsi,rdx
       mov       ecx,0E
       rep movsq
       mov       rcx,rbx
       mov       [rsp+28],rcx
       lea       rdi,[rsp+30]
       lea       rsi,[rsp+0A0]
       mov       ecx,0E
       rep movsq
       mov       rdx,[rsp+28]
       test      rdx,rdx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M01_L03
       mov       [rsp+28],rdx
       mov       rdx,[rsp+28]
       mov       edx,[rdx+8]
       add       edx,1
       jo        near ptr M01_L02
       lea       rcx,[rsp+28]
       call      System.Array.Resize[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[] ByRef, Int32)
       mov       rax,[rsp+28]
       mov       eax,[rax+8]
       lea       edx,[rax-1]
       cmp       edx,eax
       jae       near ptr M01_L04
       mov       rax,[rsp+28]
       movsxd    rdx,edx
       imul      rdx,70
       lea       rdi,[rax+rdx+10]
       lea       rsi,[rsp+30]
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       movsq
       mov       rax,[rsp+28]
       add       rsp,110
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L02:
       call      CORINFO_HELP_OVERFLOW
M01_L03:
       mov       ecx,4D
       mov       rdx,7FFD67929868
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,4F
       mov       rdx,7FFD67929868
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 423
```

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,1F0
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       rax,0FFFFFFFFFFFFFF40
M00_L00:
       vmovdqa   xmmword ptr [rsp+rax+110],xmm4
       vmovdqa   xmmword ptr [rsp+rax+120],xmm4
       vmovdqa   xmmword ptr [rsp+rax+130],xmm4
       add       rax,30
       jne       short M00_L00
       mov       rbx,rcx
       mov       rbp,[rbx+288]
       mov       r14,rbp
       lea       rsi,[rbx+0A0]
       lea       rdi,[rsp+180]
       mov       ecx,0E
       rep movsq
       lea       rdi,[rsp+110]
       lea       rsi,[rsp+180]
       mov       ecx,0E
       rep movsq
       xor       ecx,ecx
       cmp       dword ptr [rbp+8],1
       setg      cl
       test      ecx,ecx
       jne       short M00_L01
       jmp       short M00_L02
M00_L01:
       lea       rdi,[rsp+0A0]
       lea       rsi,[rsp+110]
       mov       ecx,0E
       rep movsq
       mov       rbp,r14
       lea       rdi,[rsp+28]
       lea       rsi,[rsp+0A0]
       mov       ecx,0E
       rep movsq
       mov       rcx,rbp
       lea       rdx,[rsp+28]
       call      qword ptr [7FFD52A53138]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       mov       r14,rax
M00_L02:
       mov       [rsp+98],r14
       mov       rcx,[rbx+18]
       lea       r8,[rsp+98]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[] ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFD52A53288]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,1F0
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 272
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+50],rcx
       mov       rsi,rdx
       mov       rdi,[rsp+50]
       test      rdi,rdi
       jne       near ptr M01_L03
       call      qword ptr [7FFD52845A98]
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       cmp       dword ptr [rbx+8],5
       jl        near ptr M01_L05
       lea       rcx,[rbx+0C]
       mov       rdx,26D98C085C8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FFD524899F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbx+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L06
       lea       rcx,[rbx+16]
       mov       rdx,26D98C02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFD524899F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [rbx+8],0
       je        short M01_L02
       mov       rcx,rbx
M01_L00:
       test      rcx,rcx
       jne       short M01_L01
       mov       eax,1
       jmp       near ptr M01_L07
M01_L01:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L07
M01_L02:
       mov       rdx,26D98C02028
       mov       rcx,[rdx]
       jmp       short M01_L00
M01_L03:
       mov       [rsp+50],rdi
       mov       rdx,[rsp+50]
       mov       edx,[rdx+8]
       add       edx,1
       jo        short M01_L04
       lea       rcx,[rsp+50]
       call      qword ptr [7FFD52A531E0]; System.Array.Resize[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[] ByRef, Int32)
       mov       rax,[rsp+50]
       mov       eax,[rax+8]
       lea       edx,[rax-1]
       cmp       edx,eax
       jae       near ptr M01_L09
       mov       rax,[rsp+50]
       mov       edx,edx
       imul      rdx,70
       lea       rdi,[rax+rdx+10]
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       movsq
       mov       rax,[rsp+50]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L04:
       call      CORINFO_HELP_OVERFLOW
M01_L05:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFD525E1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L06:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFD525E1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L07:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L08
       call      qword ptr [7FFD52845BB8]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FFD52659A38
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFD52659A38
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFD527E9270]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFD52845798]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFD52845C78]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFD5261D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L08:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFD52443510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFD52845798]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFD5261D8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M01_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 633
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
       mov       rdx,[r8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       pop       rsi
       ret
; Total bytes of code 24
```

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,110
       xor       eax,eax
       mov       [rsp+98],rax
       mov       rbx,rcx
       mov       rbp,[rbx+288]
       mov       r14,rbp
       lea       rsi,[rbx+0A0]
       lea       rdi,[rsp+0A0]
       mov       ecx,0E
       rep movsq
       lea       rdi,[rsp+28]
       lea       rsi,[rsp+0A0]
       mov       ecx,0E
       rep movsq
       mov       rcx,r14
       lea       rdx,[rsp+28]
       cmp       dword ptr [rbp+8],1
       setg      r8b
       movzx     r8d,r8b
       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
       mov       [rsp+98],rax
       mov       rsi,[rbx+18]
       mov       rdx,[rsp+98]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,110
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 154
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,110
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       rax,0FFFFFFFFFFFFFF40
M01_L00:
       vmovdqa   xmmword ptr [rsp+rax+110],xmm4
       vmovdqa   xmmword ptr [rsp+rax+120],xmm4
       vmovdqa   xmmword ptr [rsp+rax+130],xmm4
       add       rax,30
       jne       short M01_L00
       mov       rbx,rcx
       test      rbx,rbx
       setne     al
       movzx     eax,al
       test      eax,eax
       je        near ptr M01_L03
       test      r8b,r8b
       jne       short M01_L01
       mov       rax,rbx
       add       rsp,110
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L01:
       lea       rdi,[rsp+0A0]
       mov       rsi,rdx
       mov       ecx,0E
       rep movsq
       mov       rcx,rbx
       mov       [rsp+28],rcx
       lea       rdi,[rsp+30]
       lea       rsi,[rsp+0A0]
       mov       ecx,0E
       rep movsq
       mov       rdx,[rsp+28]
       test      rdx,rdx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M01_L03
       mov       [rsp+28],rdx
       mov       rdx,[rsp+28]
       mov       edx,[rdx+8]
       add       edx,1
       jo        near ptr M01_L02
       lea       rcx,[rsp+28]
       call      System.Array.Resize[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[] ByRef, Int32)
       mov       rax,[rsp+28]
       mov       eax,[rax+8]
       lea       edx,[rax-1]
       cmp       edx,eax
       jae       near ptr M01_L04
       mov       rax,[rsp+28]
       movsxd    rdx,edx
       imul      rdx,70
       lea       rdi,[rax+rdx+10]
       lea       rsi,[rsp+30]
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       movsq
       mov       rax,[rsp+28]
       add       rsp,110
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L02:
       call      CORINFO_HELP_OVERFLOW
M01_L03:
       mov       ecx,4D
       mov       rdx,7FFD67929868
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,4F
       mov       rdx,7FFD67929868
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 423
```

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,1F0
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       rax,0FFFFFFFFFFFFFF40
M00_L00:
       vmovdqa   xmmword ptr [rsp+rax+110],xmm4
       vmovdqa   xmmword ptr [rsp+rax+120],xmm4
       vmovdqa   xmmword ptr [rsp+rax+130],xmm4
       add       rax,30
       jne       short M00_L00
       mov       rbx,rcx
       mov       rbp,[rbx+288]
       mov       r14,rbp
       lea       rsi,[rbx+0A0]
       lea       rdi,[rsp+180]
       mov       ecx,0E
       rep movsq
       lea       rdi,[rsp+110]
       lea       rsi,[rsp+180]
       mov       ecx,0E
       rep movsq
       xor       ecx,ecx
       cmp       dword ptr [rbp+8],1
       setg      cl
       test      ecx,ecx
       jne       short M00_L01
       jmp       short M00_L02
M00_L01:
       lea       rdi,[rsp+0A0]
       lea       rsi,[rsp+110]
       mov       ecx,0E
       rep movsq
       mov       rbp,r14
       lea       rdi,[rsp+28]
       lea       rsi,[rsp+0A0]
       mov       ecx,0E
       rep movsq
       mov       rcx,rbp
       lea       rdx,[rsp+28]
       call      qword ptr [7FFD52A459F0]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       mov       r14,rax
M00_L02:
       mov       [rsp+98],r14
       mov       rcx,[rbx+18]
       lea       r8,[rsp+98]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[] ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFD52A45B40]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,1F0
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 272
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+50],rcx
       mov       rsi,rdx
       mov       rdi,[rsp+50]
       test      rdi,rdi
       jne       near ptr M01_L03
       call      qword ptr [7FFD52835A98]
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       cmp       dword ptr [rbx+8],5
       jl        near ptr M01_L05
       lea       rcx,[rbx+0C]
       mov       rdx,21F2A4085C8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FFD524799F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbx+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L06
       lea       rcx,[rbx+16]
       mov       rdx,21F2A402090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFD524799F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [rbx+8],0
       je        short M01_L02
       mov       rcx,rbx
M01_L00:
       test      rcx,rcx
       jne       short M01_L01
       mov       eax,1
       jmp       near ptr M01_L07
M01_L01:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L07
M01_L02:
       mov       rdx,21F2A402028
       mov       rcx,[rdx]
       jmp       short M01_L00
M01_L03:
       mov       [rsp+50],rdi
       mov       rdx,[rsp+50]
       mov       edx,[rdx+8]
       add       edx,1
       jo        short M01_L04
       lea       rcx,[rsp+50]
       call      qword ptr [7FFD52A45A98]; System.Array.Resize[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[] ByRef, Int32)
       mov       rax,[rsp+50]
       mov       eax,[rax+8]
       lea       edx,[rax-1]
       cmp       edx,eax
       jae       near ptr M01_L09
       mov       rax,[rsp+50]
       mov       edx,edx
       imul      rdx,70
       lea       rdi,[rax+rdx+10]
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       movsq
       mov       rax,[rsp+50]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L04:
       call      CORINFO_HELP_OVERFLOW
M01_L05:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFD525D1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L06:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFD525D1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L07:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L08
       call      qword ptr [7FFD52835BB8]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FFD52649A38
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFD52649A38
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFD527D9270]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFD52835798]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFD52835C78]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFD5260D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L08:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFD52433510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFD52835798]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFD5260D8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M01_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 633
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
       mov       rdx,[r8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       pop       rsi
       ret
; Total bytes of code 24
```

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,110
       xor       eax,eax
       mov       [rsp+98],rax
       mov       rbx,rcx
       mov       rbp,[rbx+288]
       mov       r14,rbp
       lea       rsi,[rbx+0A0]
       lea       rdi,[rsp+0A0]
       mov       ecx,0E
       rep movsq
       lea       rdi,[rsp+28]
       lea       rsi,[rsp+0A0]
       mov       ecx,0E
       rep movsq
       mov       rcx,r14
       lea       rdx,[rsp+28]
       cmp       dword ptr [rbp+8],1
       setg      r8b
       movzx     r8d,r8b
       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
       mov       [rsp+98],rax
       mov       rsi,[rbx+18]
       mov       rdx,[rsp+98]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,110
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 154
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,110
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       rax,0FFFFFFFFFFFFFF40
M01_L00:
       vmovdqa   xmmword ptr [rsp+rax+110],xmm4
       vmovdqa   xmmword ptr [rsp+rax+120],xmm4
       vmovdqa   xmmword ptr [rsp+rax+130],xmm4
       add       rax,30
       jne       short M01_L00
       mov       rbx,rcx
       test      rbx,rbx
       setne     al
       movzx     eax,al
       test      eax,eax
       je        near ptr M01_L03
       test      r8b,r8b
       jne       short M01_L01
       mov       rax,rbx
       add       rsp,110
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L01:
       lea       rdi,[rsp+0A0]
       mov       rsi,rdx
       mov       ecx,0E
       rep movsq
       mov       rcx,rbx
       mov       [rsp+28],rcx
       lea       rdi,[rsp+30]
       lea       rsi,[rsp+0A0]
       mov       ecx,0E
       rep movsq
       mov       rdx,[rsp+28]
       test      rdx,rdx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M01_L03
       mov       [rsp+28],rdx
       mov       rdx,[rsp+28]
       mov       edx,[rdx+8]
       add       edx,1
       jo        near ptr M01_L02
       lea       rcx,[rsp+28]
       call      System.Array.Resize[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[] ByRef, Int32)
       mov       rax,[rsp+28]
       mov       eax,[rax+8]
       lea       edx,[rax-1]
       cmp       edx,eax
       jae       near ptr M01_L04
       mov       rax,[rsp+28]
       movsxd    rdx,edx
       imul      rdx,70
       lea       rdi,[rax+rdx+10]
       lea       rsi,[rsp+30]
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       movsq
       mov       rax,[rsp+28]
       add       rsp,110
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L02:
       call      CORINFO_HELP_OVERFLOW
M01_L03:
       mov       ecx,4D
       mov       rdx,7FFD67939868
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,4F
       mov       rdx,7FFD67939868
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 423
```

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,1F0
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       rax,0FFFFFFFFFFFFFF40
M00_L00:
       vmovdqa   xmmword ptr [rsp+rax+110],xmm4
       vmovdqa   xmmword ptr [rsp+rax+120],xmm4
       vmovdqa   xmmword ptr [rsp+rax+130],xmm4
       add       rax,30
       jne       short M00_L00
       mov       rbx,rcx
       mov       rbp,[rbx+288]
       mov       r14,rbp
       lea       rsi,[rbx+0A0]
       lea       rdi,[rsp+180]
       mov       ecx,0E
       rep movsq
       lea       rdi,[rsp+110]
       lea       rsi,[rsp+180]
       mov       ecx,0E
       rep movsq
       xor       ecx,ecx
       cmp       dword ptr [rbp+8],1
       setg      cl
       test      ecx,ecx
       jne       short M00_L01
       jmp       short M00_L02
M00_L01:
       lea       rdi,[rsp+0A0]
       lea       rsi,[rsp+110]
       mov       ecx,0E
       rep movsq
       mov       rbp,r14
       lea       rdi,[rsp+28]
       lea       rsi,[rsp+0A0]
       mov       ecx,0E
       rep movsq
       mov       rcx,rbp
       lea       rdx,[rsp+28]
       call      qword ptr [7FFD52A45480]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       mov       r14,rax
M00_L02:
       mov       [rsp+98],r14
       mov       rcx,[rbx+18]
       lea       r8,[rsp+98]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[] ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFD52A455D0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,1F0
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 272
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+50],rcx
       mov       rsi,rdx
       mov       rdi,[rsp+50]
       test      rdi,rdi
       jne       near ptr M01_L03
       call      qword ptr [7FFD52835A98]
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       cmp       dword ptr [rbx+8],5
       jl        near ptr M01_L05
       lea       rcx,[rbx+0C]
       mov       rdx,21C7CC085C8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FFD524799F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbx+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L06
       lea       rcx,[rbx+16]
       mov       rdx,21C7CC02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFD524799F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [rbx+8],0
       je        short M01_L02
       mov       rcx,rbx
M01_L00:
       test      rcx,rcx
       jne       short M01_L01
       mov       eax,1
       jmp       near ptr M01_L07
M01_L01:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L07
M01_L02:
       mov       rdx,21C7CC02028
       mov       rcx,[rdx]
       jmp       short M01_L00
M01_L03:
       mov       [rsp+50],rdi
       mov       rdx,[rsp+50]
       mov       edx,[rdx+8]
       add       edx,1
       jo        short M01_L04
       lea       rcx,[rsp+50]
       call      qword ptr [7FFD52A45528]; System.Array.Resize[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[] ByRef, Int32)
       mov       rax,[rsp+50]
       mov       eax,[rax+8]
       lea       edx,[rax-1]
       cmp       edx,eax
       jae       near ptr M01_L09
       mov       rax,[rsp+50]
       mov       edx,edx
       imul      rdx,70
       lea       rdi,[rax+rdx+10]
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       movsq
       mov       rax,[rsp+50]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L04:
       call      CORINFO_HELP_OVERFLOW
M01_L05:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFD525D1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L06:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFD525D1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L07:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L08
       call      qword ptr [7FFD52835BB8]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FFD52649A38
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFD52649A38
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFD527D9270]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFD52835798]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFD52835C78]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFD5260D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L08:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFD52433510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFD52835798]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFD5260D8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M01_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 633
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
       mov       rdx,[r8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       pop       rsi
       ret
; Total bytes of code 24
```

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,110
       xor       eax,eax
       mov       [rsp+98],rax
       mov       rbx,rcx
       mov       rbp,[rbx+288]
       mov       r14,rbp
       lea       rsi,[rbx+0A0]
       lea       rdi,[rsp+0A0]
       mov       ecx,0E
       rep movsq
       lea       rdi,[rsp+28]
       lea       rsi,[rsp+0A0]
       mov       ecx,0E
       rep movsq
       mov       rcx,r14
       lea       rdx,[rsp+28]
       cmp       dword ptr [rbp+8],1
       setg      r8b
       movzx     r8d,r8b
       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
       mov       [rsp+98],rax
       mov       rsi,[rbx+18]
       mov       rdx,[rsp+98]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,110
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 154
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,110
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       rax,0FFFFFFFFFFFFFF40
M01_L00:
       vmovdqa   xmmword ptr [rsp+rax+110],xmm4
       vmovdqa   xmmword ptr [rsp+rax+120],xmm4
       vmovdqa   xmmword ptr [rsp+rax+130],xmm4
       add       rax,30
       jne       short M01_L00
       mov       rbx,rcx
       test      rbx,rbx
       setne     al
       movzx     eax,al
       test      eax,eax
       je        near ptr M01_L03
       test      r8b,r8b
       jne       short M01_L01
       mov       rax,rbx
       add       rsp,110
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L01:
       lea       rdi,[rsp+0A0]
       mov       rsi,rdx
       mov       ecx,0E
       rep movsq
       mov       rcx,rbx
       mov       [rsp+28],rcx
       lea       rdi,[rsp+30]
       lea       rsi,[rsp+0A0]
       mov       ecx,0E
       rep movsq
       mov       rdx,[rsp+28]
       test      rdx,rdx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M01_L03
       mov       [rsp+28],rdx
       mov       rdx,[rsp+28]
       mov       edx,[rdx+8]
       add       edx,1
       jo        near ptr M01_L02
       lea       rcx,[rsp+28]
       call      System.Array.Resize[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[] ByRef, Int32)
       mov       rax,[rsp+28]
       mov       eax,[rax+8]
       lea       edx,[rax-1]
       cmp       edx,eax
       jae       near ptr M01_L04
       mov       rax,[rsp+28]
       movsxd    rdx,edx
       imul      rdx,70
       lea       rdi,[rax+rdx+10]
       lea       rsi,[rsp+30]
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       movsq
       mov       rax,[rsp+28]
       add       rsp,110
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L02:
       call      CORINFO_HELP_OVERFLOW
M01_L03:
       mov       ecx,4D
       mov       rdx,7FFD67939868
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,4F
       mov       rdx,7FFD67939868
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 423
```

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,1F0
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       rax,0FFFFFFFFFFFFFF40
M00_L00:
       vmovdqa   xmmword ptr [rsp+rax+110],xmm4
       vmovdqa   xmmword ptr [rsp+rax+120],xmm4
       vmovdqa   xmmword ptr [rsp+rax+130],xmm4
       add       rax,30
       jne       short M00_L00
       mov       rbx,rcx
       mov       rbp,[rbx+288]
       mov       r14,rbp
       lea       rsi,[rbx+0A0]
       lea       rdi,[rsp+180]
       mov       ecx,0E
       rep movsq
       lea       rdi,[rsp+110]
       lea       rsi,[rsp+180]
       mov       ecx,0E
       rep movsq
       xor       ecx,ecx
       cmp       dword ptr [rbp+8],1
       setg      cl
       test      ecx,ecx
       jne       short M00_L01
       jmp       short M00_L02
M00_L01:
       lea       rdi,[rsp+0A0]
       lea       rsi,[rsp+110]
       mov       ecx,0E
       rep movsq
       mov       rbp,r14
       lea       rdi,[rsp+28]
       lea       rsi,[rsp+0A0]
       mov       ecx,0E
       rep movsq
       mov       rcx,rbp
       lea       rdx,[rsp+28]
       call      qword ptr [7FFD52A55480]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       mov       r14,rax
M00_L02:
       mov       [rsp+98],r14
       mov       rcx,[rbx+18]
       lea       r8,[rsp+98]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[] ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFD52A555D0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,1F0
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 272
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+50],rcx
       mov       rsi,rdx
       mov       rdi,[rsp+50]
       test      rdi,rdi
       jne       near ptr M01_L03
       call      qword ptr [7FFD52845A98]
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       cmp       dword ptr [rbx+8],5
       jl        near ptr M01_L05
       lea       rcx,[rbx+0C]
       mov       rdx,1757A4001E8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FFD524899F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbx+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L06
       lea       rcx,[rbx+16]
       mov       rdx,1757E402090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFD524899F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [rbx+8],0
       je        short M01_L02
       mov       rcx,rbx
M01_L00:
       test      rcx,rcx
       jne       short M01_L01
       mov       eax,1
       jmp       near ptr M01_L07
M01_L01:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L07
M01_L02:
       mov       rdx,1757E402028
       mov       rcx,[rdx]
       jmp       short M01_L00
M01_L03:
       mov       [rsp+50],rdi
       mov       rdx,[rsp+50]
       mov       edx,[rdx+8]
       add       edx,1
       jo        short M01_L04
       lea       rcx,[rsp+50]
       call      qword ptr [7FFD52A55528]; System.Array.Resize[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[] ByRef, Int32)
       mov       rax,[rsp+50]
       mov       eax,[rax+8]
       lea       edx,[rax-1]
       cmp       edx,eax
       jae       near ptr M01_L09
       mov       rax,[rsp+50]
       mov       edx,edx
       imul      rdx,70
       lea       rdi,[rax+rdx+10]
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       movsq
       mov       rax,[rsp+50]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L04:
       call      CORINFO_HELP_OVERFLOW
M01_L05:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFD525E1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L06:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFD525E1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L07:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L08
       call      qword ptr [7FFD52845BB8]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FFD52659A38
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFD52659A38
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFD527E9270]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFD52845798]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFD52845C78]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFD5261D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L08:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFD52443510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFD52845798]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFD5261D8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M01_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 633
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
       mov       rdx,[r8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       pop       rsi
       ret
; Total bytes of code 24
```

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,110
       xor       eax,eax
       mov       [rsp+98],rax
       mov       rbx,rcx
       mov       rbp,[rbx+288]
       mov       r14,rbp
       lea       rsi,[rbx+0A0]
       lea       rdi,[rsp+0A0]
       mov       ecx,0E
       rep movsq
       lea       rdi,[rsp+28]
       lea       rsi,[rsp+0A0]
       mov       ecx,0E
       rep movsq
       mov       rcx,r14
       lea       rdx,[rsp+28]
       cmp       dword ptr [rbp+8],1
       setg      r8b
       movzx     r8d,r8b
       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
       mov       [rsp+98],rax
       mov       rsi,[rbx+18]
       mov       rdx,[rsp+98]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,110
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 154
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,110
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       rax,0FFFFFFFFFFFFFF40
M01_L00:
       vmovdqa   xmmword ptr [rsp+rax+110],xmm4
       vmovdqa   xmmword ptr [rsp+rax+120],xmm4
       vmovdqa   xmmword ptr [rsp+rax+130],xmm4
       add       rax,30
       jne       short M01_L00
       mov       rbx,rcx
       test      rbx,rbx
       setne     al
       movzx     eax,al
       test      eax,eax
       je        near ptr M01_L03
       test      r8b,r8b
       jne       short M01_L01
       mov       rax,rbx
       add       rsp,110
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L01:
       lea       rdi,[rsp+0A0]
       mov       rsi,rdx
       mov       ecx,0E
       rep movsq
       mov       rcx,rbx
       mov       [rsp+28],rcx
       lea       rdi,[rsp+30]
       lea       rsi,[rsp+0A0]
       mov       ecx,0E
       rep movsq
       mov       rdx,[rsp+28]
       test      rdx,rdx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M01_L03
       mov       [rsp+28],rdx
       mov       rdx,[rsp+28]
       mov       edx,[rdx+8]
       add       edx,1
       jo        near ptr M01_L02
       lea       rcx,[rsp+28]
       call      System.Array.Resize[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[] ByRef, Int32)
       mov       rax,[rsp+28]
       mov       eax,[rax+8]
       lea       edx,[rax-1]
       cmp       edx,eax
       jae       near ptr M01_L04
       mov       rax,[rsp+28]
       movsxd    rdx,edx
       imul      rdx,70
       lea       rdi,[rax+rdx+10]
       lea       rsi,[rsp+30]
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       movsq
       mov       rax,[rsp+28]
       add       rsp,110
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L02:
       call      CORINFO_HELP_OVERFLOW
M01_L03:
       mov       ecx,4D
       mov       rdx,7FFD67919868
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,4F
       mov       rdx,7FFD67919868
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 423
```

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,1F0
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       rax,0FFFFFFFFFFFFFF40
M00_L00:
       vmovdqa   xmmword ptr [rsp+rax+110],xmm4
       vmovdqa   xmmword ptr [rsp+rax+120],xmm4
       vmovdqa   xmmword ptr [rsp+rax+130],xmm4
       add       rax,30
       jne       short M00_L00
       mov       rbx,rcx
       mov       rbp,[rbx+288]
       mov       r14,rbp
       lea       rsi,[rbx+0A0]
       lea       rdi,[rsp+180]
       mov       ecx,0E
       rep movsq
       lea       rdi,[rsp+110]
       lea       rsi,[rsp+180]
       mov       ecx,0E
       rep movsq
       xor       ecx,ecx
       cmp       dword ptr [rbp+8],1
       setg      cl
       test      ecx,ecx
       jne       short M00_L01
       jmp       short M00_L02
M00_L01:
       lea       rdi,[rsp+0A0]
       lea       rsi,[rsp+110]
       mov       ecx,0E
       rep movsq
       mov       rbp,r14
       lea       rdi,[rsp+28]
       lea       rsi,[rsp+0A0]
       mov       ecx,0E
       rep movsq
       mov       rcx,rbp
       lea       rdx,[rsp+28]
       call      qword ptr [7FFD52A23480]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       mov       r14,rax
M00_L02:
       mov       [rsp+98],r14
       mov       rcx,[rbx+18]
       lea       r8,[rsp+98]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[] ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFD52A235D0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,1F0
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 272
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+50],rcx
       mov       rsi,rdx
       mov       rdi,[rsp+50]
       test      rdi,rdi
       jne       near ptr M01_L03
       call      qword ptr [7FFD52815A98]
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       cmp       dword ptr [rbx+8],5
       jl        near ptr M01_L05
       lea       rcx,[rbx+0C]
       mov       rdx,260E20065D0
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FFD524599F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbx+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L06
       lea       rcx,[rbx+16]
       mov       rdx,260E2000098
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFD524599F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [rbx+8],0
       je        short M01_L02
       mov       rcx,rbx
M01_L00:
       test      rcx,rcx
       jne       short M01_L01
       mov       eax,1
       jmp       near ptr M01_L07
M01_L01:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L07
M01_L02:
       mov       rdx,260E2000030
       mov       rcx,[rdx]
       jmp       short M01_L00
M01_L03:
       mov       [rsp+50],rdi
       mov       rdx,[rsp+50]
       mov       edx,[rdx+8]
       add       edx,1
       jo        short M01_L04
       lea       rcx,[rsp+50]
       call      qword ptr [7FFD52A23528]; System.Array.Resize[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[] ByRef, Int32)
       mov       rax,[rsp+50]
       mov       eax,[rax+8]
       lea       edx,[rax-1]
       cmp       edx,eax
       jae       near ptr M01_L09
       mov       rax,[rsp+50]
       mov       edx,edx
       imul      rdx,70
       lea       rdi,[rax+rdx+10]
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       movsq
       mov       rax,[rsp+50]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L04:
       call      CORINFO_HELP_OVERFLOW
M01_L05:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFD525B1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L06:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFD525B1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L07:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L08
       call      qword ptr [7FFD52815BB8]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FFD52629A38
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFD52629A38
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFD527B9270]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFD52815798]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFD52815C78]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFD525ED8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L08:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFD52413510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFD52815798]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFD525ED8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M01_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 633
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
       mov       rdx,[r8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       pop       rsi
       ret
; Total bytes of code 24
```

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,110
       xor       eax,eax
       mov       [rsp+98],rax
       mov       rbx,rcx
       mov       rbp,[rbx+288]
       mov       r14,rbp
       lea       rsi,[rbx+0A0]
       lea       rdi,[rsp+0A0]
       mov       ecx,0E
       rep movsq
       lea       rdi,[rsp+28]
       lea       rsi,[rsp+0A0]
       mov       ecx,0E
       rep movsq
       mov       rcx,r14
       lea       rdx,[rsp+28]
       cmp       dword ptr [rbp+8],1
       setg      r8b
       movzx     r8d,r8b
       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
       mov       [rsp+98],rax
       mov       rsi,[rbx+18]
       mov       rdx,[rsp+98]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,110
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 154
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.AddIf[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person, Boolean)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,110
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       rax,0FFFFFFFFFFFFFF40
M01_L00:
       vmovdqa   xmmword ptr [rsp+rax+110],xmm4
       vmovdqa   xmmword ptr [rsp+rax+120],xmm4
       vmovdqa   xmmword ptr [rsp+rax+130],xmm4
       add       rax,30
       jne       short M01_L00
       mov       rbx,rcx
       test      rbx,rbx
       setne     al
       movzx     eax,al
       test      eax,eax
       je        near ptr M01_L03
       test      r8b,r8b
       jne       short M01_L01
       mov       rax,rbx
       add       rsp,110
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L01:
       lea       rdi,[rsp+0A0]
       mov       rsi,rdx
       mov       ecx,0E
       rep movsq
       mov       rcx,rbx
       mov       [rsp+28],rcx
       lea       rdi,[rsp+30]
       lea       rsi,[rsp+0A0]
       mov       ecx,0E
       rep movsq
       mov       rdx,[rsp+28]
       test      rdx,rdx
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M01_L03
       mov       [rsp+28],rdx
       mov       rdx,[rsp+28]
       mov       edx,[rdx+8]
       add       edx,1
       jo        near ptr M01_L02
       lea       rcx,[rsp+28]
       call      System.Array.Resize[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[] ByRef, Int32)
       mov       rax,[rsp+28]
       mov       eax,[rax+8]
       lea       edx,[rax-1]
       cmp       edx,eax
       jae       near ptr M01_L04
       mov       rax,[rsp+28]
       movsxd    rdx,edx
       imul      rdx,70
       lea       rdi,[rax+rdx+10]
       lea       rsi,[rsp+30]
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       movsq
       mov       rax,[rsp+28]
       add       rsp,110
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L02:
       call      CORINFO_HELP_OVERFLOW
M01_L03:
       mov       ecx,4D
       mov       rdx,7FFD67939868
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,4F
       mov       rdx,7FFD67939868
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 423
```

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.AddIf02()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,1F0
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       rax,0FFFFFFFFFFFFFF40
M00_L00:
       vmovdqa   xmmword ptr [rsp+rax+110],xmm4
       vmovdqa   xmmword ptr [rsp+rax+120],xmm4
       vmovdqa   xmmword ptr [rsp+rax+130],xmm4
       add       rax,30
       jne       short M00_L00
       mov       rbx,rcx
       mov       rbp,[rbx+288]
       mov       r14,rbp
       lea       rsi,[rbx+0A0]
       lea       rdi,[rsp+180]
       mov       ecx,0E
       rep movsq
       lea       rdi,[rsp+110]
       lea       rsi,[rsp+180]
       mov       ecx,0E
       rep movsq
       xor       ecx,ecx
       cmp       dword ptr [rbp+8],1
       setg      cl
       test      ecx,ecx
       jne       short M00_L01
       jmp       short M00_L02
M00_L01:
       lea       rdi,[rsp+0A0]
       lea       rsi,[rsp+110]
       mov       ecx,0E
       rep movsq
       mov       rbp,r14
       lea       rdi,[rsp+28]
       lea       rsi,[rsp+0A0]
       mov       ecx,0E
       rep movsq
       mov       rcx,rbp
       lea       rdx,[rsp+28]
       call      qword ptr [7FFD52A53138]; DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       mov       r14,rax
M00_L02:
       mov       [rsp+98],r14
       mov       rcx,[rbx+18]
       lea       r8,[rsp+98]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[] ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFD52A53288]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,1F0
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 272
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[], DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+50],rcx
       mov       rsi,rdx
       mov       rdi,[rsp+50]
       test      rdi,rdi
       jne       near ptr M01_L03
       call      qword ptr [7FFD52845A98]
       mov       ecx,7
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       cmp       dword ptr [rbx+8],5
       jl        near ptr M01_L05
       lea       rcx,[rbx+0C]
       mov       rdx,2B2840041C0
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,0A
       call      qword ptr [7FFD524899F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbx+8]
       sub       ecx,5
       cmp       ecx,2
       jl        near ptr M01_L06
       lea       rcx,[rbx+16]
       mov       rdx,2B288002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFD524899F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [rbx+8],0
       je        short M01_L02
       mov       rcx,rbx
M01_L00:
       test      rcx,rcx
       jne       short M01_L01
       mov       eax,1
       jmp       near ptr M01_L07
M01_L01:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L07
M01_L02:
       mov       rdx,2B288002028
       mov       rcx,[rdx]
       jmp       short M01_L00
M01_L03:
       mov       [rsp+50],rdi
       mov       rdx,[rsp+50]
       mov       edx,[rdx+8]
       add       edx,1
       jo        short M01_L04
       lea       rcx,[rsp+50]
       call      qword ptr [7FFD52A531E0]; System.Array.Resize[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.ValueTypes.Person[] ByRef, Int32)
       mov       rax,[rsp+50]
       mov       eax,[rax+8]
       lea       edx,[rax-1]
       cmp       edx,eax
       jae       near ptr M01_L09
       mov       rax,[rsp+50]
       mov       edx,edx
       imul      rdx,70
       lea       rdi,[rax+rdx+10]
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       movsq
       movsq
       mov       rax,[rsp+50]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L04:
       call      CORINFO_HELP_OVERFLOW
M01_L05:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFD525E1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L06:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFD525E1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L07:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L08
       call      qword ptr [7FFD52845BB8]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FFD52659A38
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFD52659A38
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFD527E9270]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFD52845798]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFD52845C78]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFD5261D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L08:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFD52443510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFD52845798]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFD5261D8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M01_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 633
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
       mov       rdx,[r8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       pop       rsi
       ret
; Total bytes of code 24
```
