## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ExceptionExtensionsBenchmark.GetAllMessages01()
; 			base.Consumer.Consume(this._testException.GetAllMessages());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,[rcx+20]
       mov       rcx,[rcx+0B8]
       mov       edx,2C
       call      DotNetTips.Spargine.Extensions.ExceptionExtensions.GetAllMessages(System.Exception, Char)
       cmp       [rsi],esi
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 47
```
```assembly
; DotNetTips.Spargine.Extensions.ExceptionExtensions.GetAllMessages(System.Exception, Char)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+20],rax
       mov       [rsp+28],rax
       mov       esi,edx
       mov       rdi,rcx
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       mov       rax,2A6D0CC3020
       mov       rbx,[rax]
       mov       rax,2A6D0CD3168
       mov       rbp,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,rbp
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       mov       rcx,2A6D0CCBF48
       mov       r8,[rcx]
       test      r8,r8
       jne       short M01_L01
       mov       rcx,offset MT_System.Func`2[[System.Exception, System.Private.CoreLib],[System.Exception, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,2A6D0CCBF40
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.ExceptionExtensions+<>c.<GetAllMessages>b__2_0(System.Exception)
       mov       [rbx+18],rdx
       mov       rcx,2A6D0CCBF48
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M01_L01:
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ExceptionExtensions.FromHierarchy(!!0, System.Func`2<!!0,!!0>)
       call      DotNetTips.Spargine.Extensions.ExceptionExtensions.FromHierarchy[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.Func`2<System.__Canon,System.__Canon>)
       mov       rdi,rax
       mov       rcx,2A6D0CCBF50
       mov       r8,[rcx]
       test      r8,r8
       jne       short M01_L02
       mov       rcx,offset MT_System.Func`2[[System.Exception, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,2A6D0CCBF40
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.ExceptionExtensions+<>c.<GetAllMessages>b__2_1(System.Exception)
       mov       [rbx+18],rdx
       mov       rcx,2A6D0CCBF50
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M01_L02:
       mov       rdx,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.Select(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,!!1>)
       call      System.Linq.Enumerable.Select[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>)
       mov       r8,rax
       movzx     edx,si
       mov       [rsp+34],dx
       lea       rdx,[rsp+34]
       mov       ecx,1
       mov       [rsp+20],rdx
       mov       [rsp+28],ecx
       lea       rdx,[rsp+20]
       mov       rcx,offset MD_System.String.JoinCore(System.ReadOnlySpan`1<Char>, System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.String.JoinCore[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 376
```

