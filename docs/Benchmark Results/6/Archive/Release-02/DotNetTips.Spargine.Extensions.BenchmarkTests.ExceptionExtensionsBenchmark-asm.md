## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ExceptionExtensionsBenchmark.GetAllMessages01()
; 			Consumer.Consume(this._testException.GetAllMessages());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,[rcx+18]
       mov       rcx,[rcx+1C8]
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
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rax
       mov       esi,edx
       mov       rdi,rcx
       test      rdi,rdi
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M01_L02
       mov       rcx,1E99FC7DB80
       mov       r8,[rcx]
       test      r8,r8
       jne       short M01_L00
       mov       rcx,offset MT_System.Func`2[[System.Exception, System.Private.CoreLib],[System.Exception, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1E99FC7DB78
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.ExceptionExtensions+<>c.<GetAllMessages>b__2_0(System.Exception)
       mov       [rbx+18],rdx
       mov       rcx,1E99FC7DB80
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M01_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ExceptionExtensions.FromHierarchy(!!0, System.Func`2<!!0,!!0>)
       call      DotNetTips.Spargine.Extensions.ExceptionExtensions.FromHierarchy[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.Func`2<System.__Canon,System.__Canon>)
       mov       rdi,rax
       mov       rcx,1E99FC7DB88
       mov       r8,[rcx]
       test      r8,r8
       jne       short M01_L01
       mov       rcx,offset MT_System.Func`2[[System.Exception, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1E99FC7DB78
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.ExceptionExtensions+<>c.<GetAllMessages>b__2_1(System.Exception)
       mov       [rbx+18],rdx
       mov       rcx,1E99FC7DB88
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M01_L01:
       mov       rdx,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.Select(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,!!1>)
       call      System.Linq.Enumerable.Select[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>)
       mov       r8,rax
       movzx     edx,si
       mov       [rsp+3C],dx
       lea       rdx,[rsp+3C]
       mov       ecx,1
       mov       [rsp+28],rdx
       mov       [rsp+30],ecx
       lea       rdx,[rsp+28]
       mov       rcx,offset MD_System.String.JoinCore(System.ReadOnlySpan`1<Char>, System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.String.JoinCore[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.Collections.Generic.IEnumerable`1<System.__Canon>)
       nop
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L02:
       mov       ecx,4D
       mov       rdx,7FFB476D49D0
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,357
       mov       rdx,7FFB476D49D0
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
; Total bytes of code 399
```

