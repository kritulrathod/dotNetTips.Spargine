## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AddIfNotExists02()
; 			var people = new List<PersonProper>(base.GetPersonProperArray());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.AddIfNotExists(this.GetPeopleToInsert());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdi,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists(System.Collections.Generic.ICollection`1<!!0>, !!0[])
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon[])
       mov       rdx,[rsi+20]
       mov       [rdx+54],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 113
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       mov       rax,209D8EE3020
       mov       rbx,[rax]
       mov       rax,209B8EE15C8
       mov       rbp,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,rbp
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFAAF2F0570
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
; Total bytes of code 148
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       mov       [rbp+0FFB0],rsp
       mov       [rbp+0FFD0],rcx
       mov       [rbp+10],rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M02_L22
       mov       rdi,[rcx]
       mov       rdx,rdi
       mov       rax,[rdx+30]
       mov       rbx,[rax]
       mov       rax,[rbx+78]
       test      rax,rax
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdx
       mov       rdx,7FFAAF4F99D8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M02_L01:
       mov       rcx,rax
       mov       rdx,rsi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r14,rax
       test      r14,r14
       je        near ptr M02_L11
       mov       rcx,rdi
       mov       r11,[rbx+90]
       test      r11,r11
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rdx,7FFAAF4F9A18
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L03:
       mov       rcx,r14
       call      qword ptr [r11]
       mov       esi,eax
       test      esi,esi
       je        short M02_L04
       mov       rcx,rdi
       mov       rdx,[rbx+60]
       test      rdx,rdx
       je        short M02_L07
       mov       [rbp+0FFC8],rdx
       jmp       short M02_L08
M02_L04:
       mov       rcx,rdi
       mov       rdx,[rbx+58]
       test      rdx,rdx
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rdx,7FFAAF4F3710
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M02_L06:
       mov       rcx,rdx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L07:
       mov       rdx,7FFAAF4F3720
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp+0FFC8],rax
M02_L08:
       movsxd    rdx,esi
       mov       rcx,[rbp+0FFC8]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       r15,[rcx+8]
       mov       rdx,rdi
       mov       r11,[rbx+98]
       test      r11,r11
       je        short M02_L09
       jmp       short M02_L10
M02_L09:
       mov       rcx,rdx
       mov       rdx,7FFAAF4F9A30
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L10:
       mov       rcx,r14
       mov       rdx,r15
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       mov       [rcx+10],esi
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L11:
       mov       rdx,rdi
       mov       rax,[rbx+58]
       test      rax,rax
       je        short M02_L12
       jmp       short M02_L13
M02_L12:
       mov       rcx,rdx
       mov       rdx,7FFAAF4F3710
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M02_L13:
       mov       rcx,rax
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       r11,[rbx+80]
       test      r11,r11
       je        short M02_L14
       jmp       short M02_L15
M02_L14:
       mov       rdx,7FFAAF4F99E8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L15:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       [rbp+0FFC0],rax
       mov       rcx,rax
       mov       r11,7FFAAEE20760
       call      qword ptr [7FFAAF400760]
       test      eax,eax
       je        short M02_L21
M02_L16:
       mov       rcx,rdi
       mov       r11,[rbx+88]
       test      r11,r11
       je        short M02_L17
       jmp       short M02_L18
M02_L17:
       mov       rdx,7FFAAF4F9A00
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L18:
       mov       rcx,[rbp+0FFC0]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rdx,[rcx+8]
       mov       eax,[rcx+10]
       cmp       [rdx+8],eax
       jbe       short M02_L19
       lea       r9d,[rax+1]
       mov       [rcx+10],r9d
       mov       rcx,rdx
       mov       edx,eax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M02_L20
M02_L19:
       mov       rdx,r8
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M02_L20:
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFAAEE20760
       call      qword ptr [7FFAAF400760]
       test      eax,eax
       jne       short M02_L16
M02_L21:
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFAAEE20768
       call      qword ptr [7FFAAF400768]
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L22:
       mov       ecx,17
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp+0FFC0],0
       je        short M02_L23
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFAAEE20768
       call      qword ptr [7FFAAF400768]
M02_L23:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 717
```
```assembly
; DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       [rsp+68],rdx
       mov       rdi,rcx
       mov       rsi,r8
       mov       rbx,[rsp+68]
       mov       rbp,[rdi+10]
       test      rbx,rbx
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L00
       mov       rax,209D8EE3020
       mov       r14,[rax]
       mov       rax,209B8EE2EA0
       mov       r15,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r15
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L00:
       cmp       qword ptr [rbp+18],0
       je        short M03_L01
       mov       rcx,[rbp+18]
       jmp       short M03_L02
M03_L01:
       mov       rcx,rdi
       mov       rdx,7FFAAF4B19F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L02:
       mov       r8,209D8EE3020
       mov       r8,[r8]
       mov       r9,209B8EE3430
       mov       r9,[r9]
       mov       rdx,rbx
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
       mov       [rsp+68],rax
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L03
       mov       rax,209D8EE3020
       mov       rbx,[rax]
       mov       rax,209B8EE2E90
       mov       r14,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L03:
       cmp       qword ptr [rbp+28],0
       je        short M03_L04
       mov       rbx,[rbp+28]
       jmp       short M03_L05
M03_L04:
       mov       rcx,rdi
       mov       rdx,7FFAAF4B1B08
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rbx,rax
M03_L05:
       mov       rcx,offset MT_System.Boolean
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rdx,[rsp+68]
       mov       rcx,rbx
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.CreateCollectionIfNull[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon> ByRef)
       mov       [rbp+8],al
       mov       rcx,rbp
       call      System.Diagnostics.TraceInternal.WriteLine(System.Object)
       xor       ebx,ebx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
       test      eax,eax
       je        short M03_L10
       xor       ebp,ebp
       mov       r14d,[rsi+8]
       test      r14d,r14d
       jle       short M03_L10
M03_L06:
       movsxd    rcx,ebp
       mov       r15,[rsi+rcx*8+10]
       mov       rcx,r15
       test      rcx,rcx
       je        short M03_L09
       mov       rcx,[rdi+10]
       mov       rbx,[rsp+68]
       cmp       qword ptr [rcx+8],30
       jle       short M03_L07
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M03_L07
       jmp       short M03_L08
M03_L07:
       mov       rcx,rdi
       mov       rdx,7FFAAF4B3550
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L08:
       mov       rdx,rbx
       mov       r8,r15
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon)
       mov       ebx,1
M03_L09:
       add       ebp,1
       jo        short M03_L11
       cmp       r14d,ebp
       jg        short M03_L06
M03_L10:
       mov       eax,ebx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L11:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 454
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AddIfNotExists02()
; 			var people = new List<PersonProper>(base.GetPersonProperArray());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.AddIfNotExists(this.GetPeopleToInsert());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdi,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists(System.Collections.Generic.ICollection`1<!!0>, !!0[])
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon[])
       mov       rdx,[rsi+20]
       mov       [rdx+54],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 113
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       mov       rax,27F7DAA3020
       mov       rbx,[rax]
       mov       rax,27F9DAA15C8
       mov       rbp,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,rbp
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFAAF2E0570
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
; Total bytes of code 148
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       mov       [rbp+0FFB0],rsp
       mov       [rbp+0FFD0],rcx
       mov       [rbp+10],rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M02_L22
       mov       rdi,[rcx]
       mov       rdx,rdi
       mov       rax,[rdx+30]
       mov       rbx,[rax]
       mov       rax,[rbx+78]
       test      rax,rax
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdx
       mov       rdx,7FFAAF4E99C8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M02_L01:
       mov       rcx,rax
       mov       rdx,rsi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r14,rax
       test      r14,r14
       je        near ptr M02_L11
       mov       rcx,rdi
       mov       r11,[rbx+90]
       test      r11,r11
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rdx,7FFAAF4E9A08
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L03:
       mov       rcx,r14
       call      qword ptr [r11]
       mov       esi,eax
       test      esi,esi
       je        short M02_L04
       mov       rcx,rdi
       mov       rdx,[rbx+70]
       test      rdx,rdx
       je        short M02_L07
       mov       [rbp+0FFC8],rdx
       jmp       short M02_L08
M02_L04:
       mov       rcx,rdi
       mov       rdx,[rbx+68]
       test      rdx,rdx
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rdx,7FFAAF4E51F8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M02_L06:
       mov       rcx,rdx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L07:
       mov       rdx,7FFAAF4E5208
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp+0FFC8],rax
M02_L08:
       movsxd    rdx,esi
       mov       rcx,[rbp+0FFC8]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       r15,[rcx+8]
       mov       rdx,rdi
       mov       r11,[rbx+98]
       test      r11,r11
       je        short M02_L09
       jmp       short M02_L10
M02_L09:
       mov       rcx,rdx
       mov       rdx,7FFAAF4E9A20
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L10:
       mov       rcx,r14
       mov       rdx,r15
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       mov       [rcx+10],esi
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L11:
       mov       rdx,rdi
       mov       rax,[rbx+68]
       test      rax,rax
       je        short M02_L12
       jmp       short M02_L13
M02_L12:
       mov       rcx,rdx
       mov       rdx,7FFAAF4E51F8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M02_L13:
       mov       rcx,rax
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       r11,[rbx+80]
       test      r11,r11
       je        short M02_L14
       jmp       short M02_L15
M02_L14:
       mov       rdx,7FFAAF4E99D8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L15:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       [rbp+0FFC0],rax
       mov       rcx,rax
       mov       r11,7FFAAEE10760
       call      qword ptr [7FFAAF3F0760]
       test      eax,eax
       je        short M02_L21
M02_L16:
       mov       rcx,rdi
       mov       r11,[rbx+88]
       test      r11,r11
       je        short M02_L17
       jmp       short M02_L18
M02_L17:
       mov       rdx,7FFAAF4E99F0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L18:
       mov       rcx,[rbp+0FFC0]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rdx,[rcx+8]
       mov       eax,[rcx+10]
       cmp       [rdx+8],eax
       jbe       short M02_L19
       lea       r9d,[rax+1]
       mov       [rcx+10],r9d
       mov       rcx,rdx
       mov       edx,eax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M02_L20
M02_L19:
       mov       rdx,r8
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M02_L20:
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFAAEE10760
       call      qword ptr [7FFAAF3F0760]
       test      eax,eax
       jne       short M02_L16
M02_L21:
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFAAEE10768
       call      qword ptr [7FFAAF3F0768]
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L22:
       mov       ecx,17
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp+0FFC0],0
       je        short M02_L23
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFAAEE10768
       call      qword ptr [7FFAAF3F0768]
M02_L23:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 717
```
```assembly
; DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       [rsp+68],rdx
       mov       rdi,rcx
       mov       rsi,r8
       mov       rbx,[rsp+68]
       mov       rbp,[rdi+10]
       test      rbx,rbx
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L00
       mov       rax,27F7DAA3020
       mov       r14,[rax]
       mov       rax,27F7DAA5A78
       mov       r15,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r15
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L00:
       cmp       qword ptr [rbp+18],0
       je        short M03_L01
       mov       rcx,[rbp+18]
       jmp       short M03_L02
M03_L01:
       mov       rcx,rdi
       mov       rdx,7FFAAF4A1988
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L02:
       mov       r8,27F7DAA3020
       mov       r8,[r8]
       mov       r9,27F7DAA6008
       mov       r9,[r9]
       mov       rdx,rbx
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
       mov       [rsp+68],rax
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L03
       mov       rax,27F7DAA3020
       mov       rbx,[rax]
       mov       rax,27F7DAA5A68
       mov       r14,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L03:
       cmp       qword ptr [rbp+28],0
       je        short M03_L04
       mov       rbx,[rbp+28]
       jmp       short M03_L05
M03_L04:
       mov       rcx,rdi
       mov       rdx,7FFAAF4A1AA0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rbx,rax
M03_L05:
       mov       rcx,offset MT_System.Boolean
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rdx,[rsp+68]
       mov       rcx,rbx
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.CreateCollectionIfNull[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon> ByRef)
       mov       [rbp+8],al
       mov       rcx,rbp
       call      System.Diagnostics.TraceInternal.WriteLine(System.Object)
       xor       ebx,ebx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
       test      eax,eax
       je        short M03_L10
       xor       ebp,ebp
       mov       r14d,[rsi+8]
       test      r14d,r14d
       jle       short M03_L10
M03_L06:
       movsxd    rcx,ebp
       mov       r15,[rsi+rcx*8+10]
       mov       rcx,r15
       test      rcx,rcx
       je        short M03_L09
       mov       rcx,[rdi+10]
       mov       rbx,[rsp+68]
       cmp       qword ptr [rcx+8],30
       jle       short M03_L07
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M03_L07
       jmp       short M03_L08
M03_L07:
       mov       rcx,rdi
       mov       rdx,7FFAAF4A34E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L08:
       mov       rdx,rbx
       mov       r8,r15
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon)
       mov       ebx,1
M03_L09:
       add       ebp,1
       jo        short M03_L11
       cmp       r14d,ebp
       jg        short M03_L06
M03_L10:
       mov       eax,ebx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L11:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 454
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AddIfNotExists02()
; 			var people = new List<PersonProper>(base.GetPersonProperArray());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.AddIfNotExists(this.GetPeopleToInsert());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdi,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists(System.Collections.Generic.ICollection`1<!!0>, !!0[])
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon[])
       mov       rdx,[rsi+20]
       mov       [rdx+54],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 113
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       mov       rax,23614C43020
       mov       rbx,[rax]
       mov       rax,23614C459D0
       mov       rbp,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,rbp
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFAAF2E0570
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
; Total bytes of code 148
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       mov       [rbp+0FFB0],rsp
       mov       [rbp+0FFD0],rcx
       mov       [rbp+10],rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M02_L22
       mov       rdi,[rcx]
       mov       rdx,rdi
       mov       rax,[rdx+30]
       mov       rbx,[rax]
       mov       rax,[rbx+78]
       test      rax,rax
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdx
       mov       rdx,7FFAAF4E9B00
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M02_L01:
       mov       rcx,rax
       mov       rdx,rsi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r14,rax
       test      r14,r14
       je        near ptr M02_L11
       mov       rcx,rdi
       mov       r11,[rbx+90]
       test      r11,r11
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rdx,7FFAAF4E9B40
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L03:
       mov       rcx,r14
       call      qword ptr [r11]
       mov       esi,eax
       test      esi,esi
       je        short M02_L04
       mov       rcx,rdi
       mov       rdx,[rbx+70]
       test      rdx,rdx
       je        short M02_L07
       mov       [rbp+0FFC8],rdx
       jmp       short M02_L08
M02_L04:
       mov       rcx,rdi
       mov       rdx,[rbx+68]
       test      rdx,rdx
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rdx,7FFAAF4E50B0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M02_L06:
       mov       rcx,rdx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L07:
       mov       rdx,7FFAAF4E50C0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp+0FFC8],rax
M02_L08:
       movsxd    rdx,esi
       mov       rcx,[rbp+0FFC8]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       r15,[rcx+8]
       mov       rdx,rdi
       mov       r11,[rbx+98]
       test      r11,r11
       je        short M02_L09
       jmp       short M02_L10
M02_L09:
       mov       rcx,rdx
       mov       rdx,7FFAAF4E9B58
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L10:
       mov       rcx,r14
       mov       rdx,r15
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       mov       [rcx+10],esi
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L11:
       mov       rdx,rdi
       mov       rax,[rbx+68]
       test      rax,rax
       je        short M02_L12
       jmp       short M02_L13
M02_L12:
       mov       rcx,rdx
       mov       rdx,7FFAAF4E50B0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M02_L13:
       mov       rcx,rax
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       r11,[rbx+80]
       test      r11,r11
       je        short M02_L14
       jmp       short M02_L15
M02_L14:
       mov       rdx,7FFAAF4E9B10
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L15:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       [rbp+0FFC0],rax
       mov       rcx,rax
       mov       r11,7FFAAEE10768
       call      qword ptr [7FFAAF3F0768]
       test      eax,eax
       je        short M02_L21
M02_L16:
       mov       rcx,rdi
       mov       r11,[rbx+88]
       test      r11,r11
       je        short M02_L17
       jmp       short M02_L18
M02_L17:
       mov       rdx,7FFAAF4E9B28
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L18:
       mov       rcx,[rbp+0FFC0]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rdx,[rcx+8]
       mov       eax,[rcx+10]
       cmp       [rdx+8],eax
       jbe       short M02_L19
       lea       r9d,[rax+1]
       mov       [rcx+10],r9d
       mov       rcx,rdx
       mov       edx,eax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M02_L20
M02_L19:
       mov       rdx,r8
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M02_L20:
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFAAEE10768
       call      qword ptr [7FFAAF3F0768]
       test      eax,eax
       jne       short M02_L16
M02_L21:
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFAAEE10770
       call      qword ptr [7FFAAF3F0770]
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L22:
       mov       ecx,17
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp+0FFC0],0
       je        short M02_L23
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFAAEE10770
       call      qword ptr [7FFAAF3F0770]
M02_L23:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 717
```
```assembly
; DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       [rsp+68],rdx
       mov       rdi,rcx
       mov       rsi,r8
       mov       rbx,[rsp+68]
       mov       rbp,[rdi+10]
       test      rbx,rbx
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L00
       mov       rax,23614C43020
       mov       r14,[rax]
       mov       rax,23634C4EAB8
       mov       r15,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r15
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L00:
       cmp       qword ptr [rbp+18],0
       je        short M03_L01
       mov       rcx,[rbp+18]
       jmp       short M03_L02
M03_L01:
       mov       rcx,rdi
       mov       rdx,7FFAAF4A19F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L02:
       mov       r8,23614C43020
       mov       r8,[r8]
       mov       r9,23634C4F048
       mov       r9,[r9]
       mov       rdx,rbx
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
       mov       [rsp+68],rax
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L03
       mov       rax,23614C43020
       mov       rbx,[rax]
       mov       rax,23634C4EAA8
       mov       r14,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L03:
       cmp       qword ptr [rbp+28],0
       je        short M03_L04
       mov       rbx,[rbp+28]
       jmp       short M03_L05
M03_L04:
       mov       rcx,rdi
       mov       rdx,7FFAAF4A1B08
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rbx,rax
M03_L05:
       mov       rcx,offset MT_System.Boolean
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rdx,[rsp+68]
       mov       rcx,rbx
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.CreateCollectionIfNull[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon> ByRef)
       mov       [rbp+8],al
       mov       rcx,rbp
       call      System.Diagnostics.TraceInternal.WriteLine(System.Object)
       xor       ebx,ebx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
       test      eax,eax
       je        short M03_L10
       xor       ebp,ebp
       mov       r14d,[rsi+8]
       test      r14d,r14d
       jle       short M03_L10
M03_L06:
       movsxd    rcx,ebp
       mov       r15,[rsi+rcx*8+10]
       mov       rcx,r15
       test      rcx,rcx
       je        short M03_L09
       mov       rcx,[rdi+10]
       mov       rbx,[rsp+68]
       cmp       qword ptr [rcx+8],30
       jle       short M03_L07
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M03_L07
       jmp       short M03_L08
M03_L07:
       mov       rcx,rdi
       mov       rdx,7FFAAF4A3550
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L08:
       mov       rdx,rbx
       mov       r8,r15
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon)
       mov       ebx,1
M03_L09:
       add       ebp,1
       jo        short M03_L11
       cmp       r14d,ebp
       jg        short M03_L06
M03_L10:
       mov       eax,ebx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L11:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 454
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AddIfNotExists02()
; 			var people = new List<PersonProper>(base.GetPersonProperArray());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.AddIfNotExists(this.GetPeopleToInsert());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdi,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists(System.Collections.Generic.ICollection`1<!!0>, !!0[])
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon[])
       mov       rdx,[rsi+20]
       mov       [rdx+54],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 113
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       mov       rax,20DBA8D3020
       mov       rbx,[rax]
       mov       rax,20DBA8D59D0
       mov       rbp,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,rbp
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFAAF2E0570
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
; Total bytes of code 148
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       mov       [rbp+0FFB0],rsp
       mov       [rbp+0FFD0],rcx
       mov       [rbp+10],rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M02_L22
       mov       rdi,[rcx]
       mov       rdx,rdi
       mov       rax,[rdx+30]
       mov       rbx,[rax]
       mov       rax,[rbx+78]
       test      rax,rax
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdx
       mov       rdx,7FFAAF4E9910
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M02_L01:
       mov       rcx,rax
       mov       rdx,rsi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r14,rax
       test      r14,r14
       je        near ptr M02_L11
       mov       rcx,rdi
       mov       r11,[rbx+90]
       test      r11,r11
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rdx,7FFAAF4E9950
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L03:
       mov       rcx,r14
       call      qword ptr [r11]
       mov       esi,eax
       test      esi,esi
       je        short M02_L04
       mov       rcx,rdi
       mov       rdx,[rbx+70]
       test      rdx,rdx
       je        short M02_L07
       mov       [rbp+0FFC8],rdx
       jmp       short M02_L08
M02_L04:
       mov       rcx,rdi
       mov       rdx,[rbx+68]
       test      rdx,rdx
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rdx,7FFAAF4E5140
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M02_L06:
       mov       rcx,rdx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L07:
       mov       rdx,7FFAAF4E5150
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp+0FFC8],rax
M02_L08:
       movsxd    rdx,esi
       mov       rcx,[rbp+0FFC8]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       r15,[rcx+8]
       mov       rdx,rdi
       mov       r11,[rbx+98]
       test      r11,r11
       je        short M02_L09
       jmp       short M02_L10
M02_L09:
       mov       rcx,rdx
       mov       rdx,7FFAAF4E9968
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L10:
       mov       rcx,r14
       mov       rdx,r15
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       mov       [rcx+10],esi
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L11:
       mov       rdx,rdi
       mov       rax,[rbx+68]
       test      rax,rax
       je        short M02_L12
       jmp       short M02_L13
M02_L12:
       mov       rcx,rdx
       mov       rdx,7FFAAF4E5140
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M02_L13:
       mov       rcx,rax
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       r11,[rbx+80]
       test      r11,r11
       je        short M02_L14
       jmp       short M02_L15
M02_L14:
       mov       rdx,7FFAAF4E9920
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L15:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       [rbp+0FFC0],rax
       mov       rcx,rax
       mov       r11,7FFAAEE10760
       call      qword ptr [7FFAAF3F0760]
       test      eax,eax
       je        short M02_L21
M02_L16:
       mov       rcx,rdi
       mov       r11,[rbx+88]
       test      r11,r11
       je        short M02_L17
       jmp       short M02_L18
M02_L17:
       mov       rdx,7FFAAF4E9938
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L18:
       mov       rcx,[rbp+0FFC0]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rdx,[rcx+8]
       mov       eax,[rcx+10]
       cmp       [rdx+8],eax
       jbe       short M02_L19
       lea       r9d,[rax+1]
       mov       [rcx+10],r9d
       mov       rcx,rdx
       mov       edx,eax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M02_L20
M02_L19:
       mov       rdx,r8
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M02_L20:
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFAAEE10760
       call      qword ptr [7FFAAF3F0760]
       test      eax,eax
       jne       short M02_L16
M02_L21:
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFAAEE10768
       call      qword ptr [7FFAAF3F0768]
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L22:
       mov       ecx,17
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp+0FFC0],0
       je        short M02_L23
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFAAEE10768
       call      qword ptr [7FFAAF3F0768]
M02_L23:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 717
```
```assembly
; DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       [rsp+68],rdx
       mov       rdi,rcx
       mov       rsi,r8
       mov       rbx,[rsp+68]
       mov       rbp,[rdi+10]
       test      rbx,rbx
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L00
       mov       rax,20DBA8D3020
       mov       r14,[rax]
       mov       rax,20DDA8DDAA0
       mov       r15,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r15
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L00:
       cmp       qword ptr [rbp+18],0
       je        short M03_L01
       mov       rcx,[rbp+18]
       jmp       short M03_L02
M03_L01:
       mov       rcx,rdi
       mov       rdx,7FFAAF4A19F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L02:
       mov       r8,20DBA8D3020
       mov       r8,[r8]
       mov       r9,20DDA8DE030
       mov       r9,[r9]
       mov       rdx,rbx
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
       mov       [rsp+68],rax
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L03
       mov       rax,20DBA8D3020
       mov       rbx,[rax]
       mov       rax,20DDA8DDA90
       mov       r14,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L03:
       cmp       qword ptr [rbp+28],0
       je        short M03_L04
       mov       rbx,[rbp+28]
       jmp       short M03_L05
M03_L04:
       mov       rcx,rdi
       mov       rdx,7FFAAF4A1B08
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rbx,rax
M03_L05:
       mov       rcx,offset MT_System.Boolean
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rdx,[rsp+68]
       mov       rcx,rbx
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.CreateCollectionIfNull[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon> ByRef)
       mov       [rbp+8],al
       mov       rcx,rbp
       call      System.Diagnostics.TraceInternal.WriteLine(System.Object)
       xor       ebx,ebx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
       test      eax,eax
       je        short M03_L10
       xor       ebp,ebp
       mov       r14d,[rsi+8]
       test      r14d,r14d
       jle       short M03_L10
M03_L06:
       movsxd    rcx,ebp
       mov       r15,[rsi+rcx*8+10]
       mov       rcx,r15
       test      rcx,rcx
       je        short M03_L09
       mov       rcx,[rdi+10]
       mov       rbx,[rsp+68]
       cmp       qword ptr [rcx+8],30
       jle       short M03_L07
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M03_L07
       jmp       short M03_L08
M03_L07:
       mov       rcx,rdi
       mov       rdx,7FFAAF4A3550
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L08:
       mov       rdx,rbx
       mov       r8,r15
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon)
       mov       ebx,1
M03_L09:
       add       ebp,1
       jo        short M03_L11
       cmp       r14d,ebp
       jg        short M03_L06
M03_L10:
       mov       eax,ebx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L11:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 454
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AddIfNotExists02()
; 			var people = new List<PersonProper>(base.GetPersonProperArray());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.AddIfNotExists(this.GetPeopleToInsert());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdi,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists(System.Collections.Generic.ICollection`1<!!0>, !!0[])
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon[])
       mov       rdx,[rsi+20]
       mov       [rdx+54],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 113
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       mov       rax,243B4B73020
       mov       rbx,[rax]
       mov       rax,243B4B81E00
       mov       rbp,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,rbp
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFAAF2D0570
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
; Total bytes of code 148
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       mov       [rbp+0FFB0],rsp
       mov       [rbp+0FFD0],rcx
       mov       [rbp+10],rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M02_L22
       mov       rdi,[rcx]
       mov       rdx,rdi
       mov       rax,[rdx+30]
       mov       rbx,[rax]
       mov       rax,[rbx+78]
       test      rax,rax
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdx
       mov       rdx,7FFAAF4D9A20
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M02_L01:
       mov       rcx,rax
       mov       rdx,rsi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r14,rax
       test      r14,r14
       je        near ptr M02_L11
       mov       rcx,rdi
       mov       r11,[rbx+90]
       test      r11,r11
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rdx,7FFAAF4D9A60
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L03:
       mov       rcx,r14
       call      qword ptr [r11]
       mov       esi,eax
       test      esi,esi
       je        short M02_L04
       mov       rcx,rdi
       mov       rdx,[rbx+70]
       test      rdx,rdx
       je        short M02_L07
       mov       [rbp+0FFC8],rdx
       jmp       short M02_L08
M02_L04:
       mov       rcx,rdi
       mov       rdx,[rbx+68]
       test      rdx,rdx
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rdx,7FFAAF4D5078
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M02_L06:
       mov       rcx,rdx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L07:
       mov       rdx,7FFAAF4D5088
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp+0FFC8],rax
M02_L08:
       movsxd    rdx,esi
       mov       rcx,[rbp+0FFC8]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       r15,[rcx+8]
       mov       rdx,rdi
       mov       r11,[rbx+98]
       test      r11,r11
       je        short M02_L09
       jmp       short M02_L10
M02_L09:
       mov       rcx,rdx
       mov       rdx,7FFAAF4D9A78
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L10:
       mov       rcx,r14
       mov       rdx,r15
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       mov       [rcx+10],esi
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L11:
       mov       rdx,rdi
       mov       rax,[rbx+68]
       test      rax,rax
       je        short M02_L12
       jmp       short M02_L13
M02_L12:
       mov       rcx,rdx
       mov       rdx,7FFAAF4D5078
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M02_L13:
       mov       rcx,rax
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       r11,[rbx+80]
       test      r11,r11
       je        short M02_L14
       jmp       short M02_L15
M02_L14:
       mov       rdx,7FFAAF4D9A30
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L15:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       [rbp+0FFC0],rax
       mov       rcx,rax
       mov       r11,7FFAAEE00760
       call      qword ptr [7FFAAF3E0760]
       test      eax,eax
       je        short M02_L21
M02_L16:
       mov       rcx,rdi
       mov       r11,[rbx+88]
       test      r11,r11
       je        short M02_L17
       jmp       short M02_L18
M02_L17:
       mov       rdx,7FFAAF4D9A48
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L18:
       mov       rcx,[rbp+0FFC0]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rdx,[rcx+8]
       mov       eax,[rcx+10]
       cmp       [rdx+8],eax
       jbe       short M02_L19
       lea       r9d,[rax+1]
       mov       [rcx+10],r9d
       mov       rcx,rdx
       mov       edx,eax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M02_L20
M02_L19:
       mov       rdx,r8
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M02_L20:
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFAAEE00760
       call      qword ptr [7FFAAF3E0760]
       test      eax,eax
       jne       short M02_L16
M02_L21:
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFAAEE00768
       call      qword ptr [7FFAAF3E0768]
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L22:
       mov       ecx,17
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp+0FFC0],0
       je        short M02_L23
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFAAEE00768
       call      qword ptr [7FFAAF3E0768]
M02_L23:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 717
```
```assembly
; DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       [rsp+68],rdx
       mov       rdi,rcx
       mov       rsi,r8
       mov       rbx,[rsp+68]
       mov       rbp,[rdi+10]
       test      rbx,rbx
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L00
       mov       rax,243B4B73020
       mov       r14,[rax]
       mov       rax,243B4B826C0
       mov       r15,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r15
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L00:
       cmp       qword ptr [rbp+18],0
       je        short M03_L01
       mov       rcx,[rbp+18]
       jmp       short M03_L02
M03_L01:
       mov       rcx,rdi
       mov       rdx,7FFAAF4919F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L02:
       mov       r8,243B4B73020
       mov       r8,[r8]
       mov       r9,243B4B82C50
       mov       r9,[r9]
       mov       rdx,rbx
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
       mov       [rsp+68],rax
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L03
       mov       rax,243B4B73020
       mov       rbx,[rax]
       mov       rax,243B4B826B0
       mov       r14,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L03:
       cmp       qword ptr [rbp+28],0
       je        short M03_L04
       mov       rbx,[rbp+28]
       jmp       short M03_L05
M03_L04:
       mov       rcx,rdi
       mov       rdx,7FFAAF491B08
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rbx,rax
M03_L05:
       mov       rcx,offset MT_System.Boolean
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rdx,[rsp+68]
       mov       rcx,rbx
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.CreateCollectionIfNull[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon> ByRef)
       mov       [rbp+8],al
       mov       rcx,rbp
       call      System.Diagnostics.TraceInternal.WriteLine(System.Object)
       xor       ebx,ebx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
       test      eax,eax
       je        short M03_L10
       xor       ebp,ebp
       mov       r14d,[rsi+8]
       test      r14d,r14d
       jle       short M03_L10
M03_L06:
       movsxd    rcx,ebp
       mov       r15,[rsi+rcx*8+10]
       mov       rcx,r15
       test      rcx,rcx
       je        short M03_L09
       mov       rcx,[rdi+10]
       mov       rbx,[rsp+68]
       cmp       qword ptr [rcx+8],30
       jle       short M03_L07
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M03_L07
       jmp       short M03_L08
M03_L07:
       mov       rcx,rdi
       mov       rdx,7FFAAF493550
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L08:
       mov       rdx,rbx
       mov       r8,r15
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon)
       mov       ebx,1
M03_L09:
       add       ebp,1
       jo        short M03_L11
       cmp       r14d,ebp
       jg        short M03_L06
M03_L10:
       mov       eax,ebx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L11:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 454
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AddIfNotExists02()
; 			var people = new List<PersonProper>(base.GetPersonProperArray());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.AddIfNotExists(this.GetPeopleToInsert());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdi,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists(System.Collections.Generic.ICollection`1<!!0>, !!0[])
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon[])
       mov       rdx,[rsi+20]
       mov       [rdx+54],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 113
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       mov       rax,213BBF93020
       mov       rbx,[rax]
       mov       rax,213BBFA1E00
       mov       rbp,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,rbp
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFAAF2D0570
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
; Total bytes of code 148
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       mov       [rbp+0FFB0],rsp
       mov       [rbp+0FFD0],rcx
       mov       [rbp+10],rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M02_L22
       mov       rdi,[rcx]
       mov       rdx,rdi
       mov       rax,[rdx+30]
       mov       rbx,[rax]
       mov       rax,[rbx+78]
       test      rax,rax
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdx
       mov       rdx,7FFAAF4E9A90
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M02_L01:
       mov       rcx,rax
       mov       rdx,rsi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r14,rax
       test      r14,r14
       je        near ptr M02_L11
       mov       rcx,rdi
       mov       r11,[rbx+90]
       test      r11,r11
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rdx,7FFAAF4E9AD0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L03:
       mov       rcx,r14
       call      qword ptr [r11]
       mov       esi,eax
       test      esi,esi
       je        short M02_L04
       mov       rcx,rdi
       mov       rdx,[rbx+70]
       test      rdx,rdx
       je        short M02_L07
       mov       [rbp+0FFC8],rdx
       jmp       short M02_L08
M02_L04:
       mov       rcx,rdi
       mov       rdx,[rbx+68]
       test      rdx,rdx
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rdx,7FFAAF4E50A8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M02_L06:
       mov       rcx,rdx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L07:
       mov       rdx,7FFAAF4E50B8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp+0FFC8],rax
M02_L08:
       movsxd    rdx,esi
       mov       rcx,[rbp+0FFC8]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       r15,[rcx+8]
       mov       rdx,rdi
       mov       r11,[rbx+98]
       test      r11,r11
       je        short M02_L09
       jmp       short M02_L10
M02_L09:
       mov       rcx,rdx
       mov       rdx,7FFAAF4E9AE8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L10:
       mov       rcx,r14
       mov       rdx,r15
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       mov       [rcx+10],esi
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L11:
       mov       rdx,rdi
       mov       rax,[rbx+68]
       test      rax,rax
       je        short M02_L12
       jmp       short M02_L13
M02_L12:
       mov       rcx,rdx
       mov       rdx,7FFAAF4E50A8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M02_L13:
       mov       rcx,rax
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       r11,[rbx+80]
       test      r11,r11
       je        short M02_L14
       jmp       short M02_L15
M02_L14:
       mov       rdx,7FFAAF4E9AA0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L15:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       [rbp+0FFC0],rax
       mov       rcx,rax
       mov       r11,7FFAAEE00768
       call      qword ptr [7FFAAF3E0768]
       test      eax,eax
       je        short M02_L21
M02_L16:
       mov       rcx,rdi
       mov       r11,[rbx+88]
       test      r11,r11
       je        short M02_L17
       jmp       short M02_L18
M02_L17:
       mov       rdx,7FFAAF4E9AB8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L18:
       mov       rcx,[rbp+0FFC0]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rdx,[rcx+8]
       mov       eax,[rcx+10]
       cmp       [rdx+8],eax
       jbe       short M02_L19
       lea       r9d,[rax+1]
       mov       [rcx+10],r9d
       mov       rcx,rdx
       mov       edx,eax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M02_L20
M02_L19:
       mov       rdx,r8
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M02_L20:
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFAAEE00768
       call      qword ptr [7FFAAF3E0768]
       test      eax,eax
       jne       short M02_L16
M02_L21:
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFAAEE00770
       call      qword ptr [7FFAAF3E0770]
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L22:
       mov       ecx,17
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp+0FFC0],0
       je        short M02_L23
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFAAEE00770
       call      qword ptr [7FFAAF3E0770]
M02_L23:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 717
```
```assembly
; DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       [rsp+68],rdx
       mov       rdi,rcx
       mov       rsi,r8
       mov       rbx,[rsp+68]
       mov       rbp,[rdi+10]
       test      rbx,rbx
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L00
       mov       rax,213BBF93020
       mov       r14,[rax]
       mov       rax,2139BF91670
       mov       r15,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r15
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L00:
       cmp       qword ptr [rbp+18],0
       je        short M03_L01
       mov       rcx,[rbp+18]
       jmp       short M03_L02
M03_L01:
       mov       rcx,rdi
       mov       rdx,7FFAAF491988
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L02:
       mov       r8,213BBF93020
       mov       r8,[r8]
       mov       r9,2139BF91C00
       mov       r9,[r9]
       mov       rdx,rbx
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
       mov       [rsp+68],rax
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L03
       mov       rax,213BBF93020
       mov       rbx,[rax]
       mov       rax,2139BF91660
       mov       r14,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L03:
       cmp       qword ptr [rbp+28],0
       je        short M03_L04
       mov       rbx,[rbp+28]
       jmp       short M03_L05
M03_L04:
       mov       rcx,rdi
       mov       rdx,7FFAAF491AA0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rbx,rax
M03_L05:
       mov       rcx,offset MT_System.Boolean
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rdx,[rsp+68]
       mov       rcx,rbx
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.CreateCollectionIfNull[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon> ByRef)
       mov       [rbp+8],al
       mov       rcx,rbp
       call      System.Diagnostics.TraceInternal.WriteLine(System.Object)
       xor       ebx,ebx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
       test      eax,eax
       je        short M03_L10
       xor       ebp,ebp
       mov       r14d,[rsi+8]
       test      r14d,r14d
       jle       short M03_L10
M03_L06:
       movsxd    rcx,ebp
       mov       r15,[rsi+rcx*8+10]
       mov       rcx,r15
       test      rcx,rcx
       je        short M03_L09
       mov       rcx,[rdi+10]
       mov       rbx,[rsp+68]
       cmp       qword ptr [rcx+8],30
       jle       short M03_L07
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M03_L07
       jmp       short M03_L08
M03_L07:
       mov       rcx,rdi
       mov       rdx,7FFAAF4934E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L08:
       mov       rdx,rbx
       mov       r8,r15
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon)
       mov       ebx,1
M03_L09:
       add       ebp,1
       jo        short M03_L11
       cmp       r14d,ebp
       jg        short M03_L06
M03_L10:
       mov       eax,ebx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L11:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 454
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AddIfNotExists02()
; 			var people = new List<PersonProper>(base.GetPersonProperArray());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.AddIfNotExists(this.GetPeopleToInsert());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdi,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists(System.Collections.Generic.ICollection`1<!!0>, !!0[])
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon[])
       mov       rdx,[rsi+20]
       mov       [rdx+54],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 113
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       mov       rax,261D20B3020
       mov       rbx,[rax]
       mov       rax,261D20C1E00
       mov       rbp,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,rbp
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFAAF2E0570
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
; Total bytes of code 148
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       mov       [rbp+0FFB0],rsp
       mov       [rbp+0FFD0],rcx
       mov       [rbp+10],rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M02_L22
       mov       rdi,[rcx]
       mov       rdx,rdi
       mov       rax,[rdx+30]
       mov       rbx,[rax]
       mov       rax,[rbx+78]
       test      rax,rax
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdx
       mov       rdx,7FFAAF4EB210
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M02_L01:
       mov       rcx,rax
       mov       rdx,rsi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r14,rax
       test      r14,r14
       je        near ptr M02_L11
       mov       rcx,rdi
       mov       r11,[rbx+90]
       test      r11,r11
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rdx,7FFAAF4EB250
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L03:
       mov       rcx,r14
       call      qword ptr [r11]
       mov       esi,eax
       test      esi,esi
       je        short M02_L04
       mov       rcx,rdi
       mov       rdx,[rbx+70]
       test      rdx,rdx
       je        short M02_L07
       mov       [rbp+0FFC8],rdx
       jmp       short M02_L08
M02_L04:
       mov       rcx,rdi
       mov       rdx,[rbx+68]
       test      rdx,rdx
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rdx,7FFAAF4E5110
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M02_L06:
       mov       rcx,rdx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L07:
       mov       rdx,7FFAAF4E5120
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp+0FFC8],rax
M02_L08:
       movsxd    rdx,esi
       mov       rcx,[rbp+0FFC8]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       r15,[rcx+8]
       mov       rdx,rdi
       mov       r11,[rbx+98]
       test      r11,r11
       je        short M02_L09
       jmp       short M02_L10
M02_L09:
       mov       rcx,rdx
       mov       rdx,7FFAAF4EB268
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L10:
       mov       rcx,r14
       mov       rdx,r15
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       mov       [rcx+10],esi
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L11:
       mov       rdx,rdi
       mov       rax,[rbx+68]
       test      rax,rax
       je        short M02_L12
       jmp       short M02_L13
M02_L12:
       mov       rcx,rdx
       mov       rdx,7FFAAF4E5110
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M02_L13:
       mov       rcx,rax
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       r11,[rbx+80]
       test      r11,r11
       je        short M02_L14
       jmp       short M02_L15
M02_L14:
       mov       rdx,7FFAAF4EB220
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L15:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       [rbp+0FFC0],rax
       mov       rcx,rax
       mov       r11,7FFAAEE10760
       call      qword ptr [7FFAAF3F0760]
       test      eax,eax
       je        short M02_L21
M02_L16:
       mov       rcx,rdi
       mov       r11,[rbx+88]
       test      r11,r11
       je        short M02_L17
       jmp       short M02_L18
M02_L17:
       mov       rdx,7FFAAF4EB238
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L18:
       mov       rcx,[rbp+0FFC0]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rdx,[rcx+8]
       mov       eax,[rcx+10]
       cmp       [rdx+8],eax
       jbe       short M02_L19
       lea       r9d,[rax+1]
       mov       [rcx+10],r9d
       mov       rcx,rdx
       mov       edx,eax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M02_L20
M02_L19:
       mov       rdx,r8
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M02_L20:
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFAAEE10760
       call      qword ptr [7FFAAF3F0760]
       test      eax,eax
       jne       short M02_L16
M02_L21:
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFAAEE10768
       call      qword ptr [7FFAAF3F0768]
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L22:
       mov       ecx,17
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp+0FFC0],0
       je        short M02_L23
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFAAEE10768
       call      qword ptr [7FFAAF3F0768]
M02_L23:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 717
```
```assembly
; DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       [rsp+68],rdx
       mov       rdi,rcx
       mov       rsi,r8
       mov       rbx,[rsp+68]
       mov       rbp,[rdi+10]
       test      rbx,rbx
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L00
       mov       rax,261D20B3020
       mov       r14,[rax]
       mov       rax,261C20B2688
       mov       r15,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r15
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L00:
       cmp       qword ptr [rbp+18],0
       je        short M03_L01
       mov       rcx,[rbp+18]
       jmp       short M03_L02
M03_L01:
       mov       rcx,rdi
       mov       rdx,7FFAAF4A19A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L02:
       mov       r8,261D20B3020
       mov       r8,[r8]
       mov       r9,261C20B2C18
       mov       r9,[r9]
       mov       rdx,rbx
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
       mov       [rsp+68],rax
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L03
       mov       rax,261D20B3020
       mov       rbx,[rax]
       mov       rax,261C20B2678
       mov       r14,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L03:
       cmp       qword ptr [rbp+28],0
       je        short M03_L04
       mov       rbx,[rbp+28]
       jmp       short M03_L05
M03_L04:
       mov       rcx,rdi
       mov       rdx,7FFAAF4A1AB8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rbx,rax
M03_L05:
       mov       rcx,offset MT_System.Boolean
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rdx,[rsp+68]
       mov       rcx,rbx
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.CreateCollectionIfNull[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon> ByRef)
       mov       [rbp+8],al
       mov       rcx,rbp
       call      System.Diagnostics.TraceInternal.WriteLine(System.Object)
       xor       ebx,ebx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
       test      eax,eax
       je        short M03_L10
       xor       ebp,ebp
       mov       r14d,[rsi+8]
       test      r14d,r14d
       jle       short M03_L10
M03_L06:
       movsxd    rcx,ebp
       mov       r15,[rsi+rcx*8+10]
       mov       rcx,r15
       test      rcx,rcx
       je        short M03_L09
       mov       rcx,[rdi+10]
       mov       rbx,[rsp+68]
       cmp       qword ptr [rcx+8],30
       jle       short M03_L07
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M03_L07
       jmp       short M03_L08
M03_L07:
       mov       rcx,rdi
       mov       rdx,7FFAAF4A3500
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L08:
       mov       rdx,rbx
       mov       r8,r15
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon)
       mov       ebx,1
M03_L09:
       add       ebp,1
       jo        short M03_L11
       cmp       r14d,ebp
       jg        short M03_L06
M03_L10:
       mov       eax,ebx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L11:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 454
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AddIfNotExists02()
; 			var people = new List<PersonProper>(base.GetPersonProperArray());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.AddIfNotExists(this.GetPeopleToInsert());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdi,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists(System.Collections.Generic.ICollection`1<!!0>, !!0[])
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon[])
       mov       rdx,[rsi+20]
       mov       [rdx+54],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 113
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       mov       rax,133722D3020
       mov       rbx,[rax]
       mov       rax,133722D59D0
       mov       rbp,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,rbp
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFAAF2E0570
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
; Total bytes of code 148
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       mov       [rbp+0FFB0],rsp
       mov       [rbp+0FFD0],rcx
       mov       [rbp+10],rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M02_L22
       mov       rdi,[rcx]
       mov       rdx,rdi
       mov       rax,[rdx+30]
       mov       rbx,[rax]
       mov       rax,[rbx+78]
       test      rax,rax
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdx
       mov       rdx,7FFAAF504168
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M02_L01:
       mov       rcx,rax
       mov       rdx,rsi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r14,rax
       test      r14,r14
       je        near ptr M02_L11
       mov       rcx,rdi
       mov       r11,[rbx+90]
       test      r11,r11
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rdx,7FFAAF5041A8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L03:
       mov       rcx,r14
       call      qword ptr [r11]
       mov       esi,eax
       test      esi,esi
       je        short M02_L04
       mov       rcx,rdi
       mov       rdx,[rbx+38]
       test      rdx,rdx
       je        short M02_L07
       mov       [rbp+0FFC8],rdx
       jmp       short M02_L08
M02_L04:
       mov       rcx,rdi
       mov       rdx,[rbx+40]
       test      rdx,rdx
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rdx,7FFAAF3A7D68
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M02_L06:
       mov       rcx,rdx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L07:
       mov       rdx,7FFAAF3A7D60
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp+0FFC8],rax
M02_L08:
       movsxd    rdx,esi
       mov       rcx,[rbp+0FFC8]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       r15,[rcx+8]
       mov       rdx,rdi
       mov       r11,[rbx+98]
       test      r11,r11
       je        short M02_L09
       jmp       short M02_L10
M02_L09:
       mov       rcx,rdx
       mov       rdx,7FFAAF5041C0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L10:
       mov       rcx,r14
       mov       rdx,r15
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       mov       [rcx+10],esi
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L11:
       mov       rdx,rdi
       mov       rax,[rbx+40]
       test      rax,rax
       je        short M02_L12
       jmp       short M02_L13
M02_L12:
       mov       rcx,rdx
       mov       rdx,7FFAAF3A7D68
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M02_L13:
       mov       rcx,rax
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       r11,[rbx+80]
       test      r11,r11
       je        short M02_L14
       jmp       short M02_L15
M02_L14:
       mov       rdx,7FFAAF504178
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L15:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       [rbp+0FFC0],rax
       mov       rcx,rax
       mov       r11,7FFAAEE108C0
       call      qword ptr [7FFAAF4008C0]
       test      eax,eax
       je        short M02_L21
M02_L16:
       mov       rcx,rdi
       mov       r11,[rbx+88]
       test      r11,r11
       je        short M02_L17
       jmp       short M02_L18
M02_L17:
       mov       rdx,7FFAAF504190
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L18:
       mov       rcx,[rbp+0FFC0]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rdx,[rcx+8]
       mov       eax,[rcx+10]
       cmp       [rdx+8],eax
       jbe       short M02_L19
       lea       r9d,[rax+1]
       mov       [rcx+10],r9d
       mov       rcx,rdx
       mov       edx,eax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M02_L20
M02_L19:
       mov       rdx,r8
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M02_L20:
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFAAEE108C0
       call      qword ptr [7FFAAF4008C0]
       test      eax,eax
       jne       short M02_L16
M02_L21:
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFAAEE108C8
       call      qword ptr [7FFAAF4008C8]
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L22:
       mov       ecx,17
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp+0FFC0],0
       je        short M02_L23
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFAAEE108C8
       call      qword ptr [7FFAAF4008C8]
M02_L23:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 717
```
```assembly
; DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       [rsp+68],rdx
       mov       rdi,rcx
       mov       rsi,r8
       mov       rbx,[rsp+68]
       mov       rbp,[rdi+10]
       test      rbx,rbx
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L00
       mov       rax,133722D3020
       mov       r14,[rax]
       mov       rax,133722D6290
       mov       r15,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r15
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L00:
       cmp       qword ptr [rbp+18],0
       je        short M03_L01
       mov       rcx,[rbp+18]
       jmp       short M03_L02
M03_L01:
       mov       rcx,rdi
       mov       rdx,7FFAAF4C19A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L02:
       mov       r8,133722D3020
       mov       r8,[r8]
       mov       r9,133722D6820
       mov       r9,[r9]
       mov       rdx,rbx
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
       mov       [rsp+68],rax
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L03
       mov       rax,133722D3020
       mov       rbx,[rax]
       mov       rax,133722D6280
       mov       r14,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L03:
       cmp       qword ptr [rbp+28],0
       je        short M03_L04
       mov       rbx,[rbp+28]
       jmp       short M03_L05
M03_L04:
       mov       rcx,rdi
       mov       rdx,7FFAAF4C1AB8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rbx,rax
M03_L05:
       mov       rcx,offset MT_System.Boolean
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rdx,[rsp+68]
       mov       rcx,rbx
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.CreateCollectionIfNull[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon> ByRef)
       mov       [rbp+8],al
       mov       rcx,rbp
       call      System.Diagnostics.TraceInternal.WriteLine(System.Object)
       xor       ebx,ebx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
       test      eax,eax
       je        short M03_L10
       xor       ebp,ebp
       mov       r14d,[rsi+8]
       test      r14d,r14d
       jle       short M03_L10
M03_L06:
       movsxd    rcx,ebp
       mov       r15,[rsi+rcx*8+10]
       mov       rcx,r15
       test      rcx,rcx
       je        short M03_L09
       mov       rcx,[rdi+10]
       mov       rbx,[rsp+68]
       cmp       qword ptr [rcx+8],30
       jle       short M03_L07
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M03_L07
       jmp       short M03_L08
M03_L07:
       mov       rcx,rdi
       mov       rdx,7FFAAF4C3500
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L08:
       mov       rdx,rbx
       mov       r8,r15
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon)
       mov       ebx,1
M03_L09:
       add       ebp,1
       jo        short M03_L11
       cmp       r14d,ebp
       jg        short M03_L06
M03_L10:
       mov       eax,ebx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L11:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 454
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AddIfNotExists01()
; 			var people = new List<PersonProper>(base.GetPersonProperArray());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.AddIfNotExists(this.GetPeopleToInsert());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdi,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists(System.Collections.Generic.ICollection`1<!!0>, !!0[])
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon[])
       mov       rdx,[rsi+20]
       mov       [rdx+54],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 113
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       mov       rax,1EF27043020
       mov       rbx,[rax]
       mov       rax,1EF470415C8
       mov       rbp,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,rbp
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFAAF2D0570
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
; Total bytes of code 148
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       mov       [rbp+0FFB0],rsp
       mov       [rbp+0FFD0],rcx
       mov       [rbp+10],rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M02_L22
       mov       rdi,[rcx]
       mov       rdx,rdi
       mov       rax,[rdx+30]
       mov       rbx,[rax]
       mov       rax,[rbx+78]
       test      rax,rax
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdx
       mov       rdx,7FFAAF4D9868
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M02_L01:
       mov       rcx,rax
       mov       rdx,rsi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r14,rax
       test      r14,r14
       je        near ptr M02_L11
       mov       rcx,rdi
       mov       r11,[rbx+90]
       test      r11,r11
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rdx,7FFAAF4D98A8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L03:
       mov       rcx,r14
       call      qword ptr [r11]
       mov       esi,eax
       test      esi,esi
       je        short M02_L04
       mov       rcx,rdi
       mov       rdx,[rbx+60]
       test      rdx,rdx
       je        short M02_L07
       mov       [rbp+0FFC8],rdx
       jmp       short M02_L08
M02_L04:
       mov       rcx,rdi
       mov       rdx,[rbx+58]
       test      rdx,rdx
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rdx,7FFAAF4D3640
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M02_L06:
       mov       rcx,rdx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L07:
       mov       rdx,7FFAAF4D3650
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp+0FFC8],rax
M02_L08:
       movsxd    rdx,esi
       mov       rcx,[rbp+0FFC8]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       r15,[rcx+8]
       mov       rdx,rdi
       mov       r11,[rbx+98]
       test      r11,r11
       je        short M02_L09
       jmp       short M02_L10
M02_L09:
       mov       rcx,rdx
       mov       rdx,7FFAAF4D98C0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L10:
       mov       rcx,r14
       mov       rdx,r15
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       mov       [rcx+10],esi
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L11:
       mov       rdx,rdi
       mov       rax,[rbx+58]
       test      rax,rax
       je        short M02_L12
       jmp       short M02_L13
M02_L12:
       mov       rcx,rdx
       mov       rdx,7FFAAF4D3640
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M02_L13:
       mov       rcx,rax
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       r11,[rbx+80]
       test      r11,r11
       je        short M02_L14
       jmp       short M02_L15
M02_L14:
       mov       rdx,7FFAAF4D9878
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L15:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       [rbp+0FFC0],rax
       mov       rcx,rax
       mov       r11,7FFAAEE00760
       call      qword ptr [7FFAAF3E0760]
       test      eax,eax
       je        short M02_L21
M02_L16:
       mov       rcx,rdi
       mov       r11,[rbx+88]
       test      r11,r11
       je        short M02_L17
       jmp       short M02_L18
M02_L17:
       mov       rdx,7FFAAF4D9890
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L18:
       mov       rcx,[rbp+0FFC0]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rdx,[rcx+8]
       mov       eax,[rcx+10]
       cmp       [rdx+8],eax
       jbe       short M02_L19
       lea       r9d,[rax+1]
       mov       [rcx+10],r9d
       mov       rcx,rdx
       mov       edx,eax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M02_L20
M02_L19:
       mov       rdx,r8
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M02_L20:
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFAAEE00760
       call      qword ptr [7FFAAF3E0760]
       test      eax,eax
       jne       short M02_L16
M02_L21:
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFAAEE00768
       call      qword ptr [7FFAAF3E0768]
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L22:
       mov       ecx,17
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp+0FFC0],0
       je        short M02_L23
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFAAEE00768
       call      qword ptr [7FFAAF3E0768]
M02_L23:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 717
```
```assembly
; DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       [rsp+68],rdx
       mov       rdi,rcx
       mov       rsi,r8
       mov       rbx,[rsp+68]
       mov       rbp,[rdi+10]
       test      rbx,rbx
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L00
       mov       rax,1EF27043020
       mov       r14,[rax]
       mov       rax,1EF47041E88
       mov       r15,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r15
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L00:
       cmp       qword ptr [rbp+18],0
       je        short M03_L01
       mov       rcx,[rbp+18]
       jmp       short M03_L02
M03_L01:
       mov       rcx,rdi
       mov       rdx,7FFAAF4919F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L02:
       mov       r8,1EF27043020
       mov       r8,[r8]
       mov       r9,1EF47042418
       mov       r9,[r9]
       mov       rdx,rbx
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
       mov       [rsp+68],rax
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L03
       mov       rax,1EF27043020
       mov       rbx,[rax]
       mov       rax,1EF47041E78
       mov       r14,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L03:
       cmp       qword ptr [rbp+28],0
       je        short M03_L04
       mov       rbx,[rbp+28]
       jmp       short M03_L05
M03_L04:
       mov       rcx,rdi
       mov       rdx,7FFAAF491B08
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rbx,rax
M03_L05:
       mov       rcx,offset MT_System.Boolean
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rdx,[rsp+68]
       mov       rcx,rbx
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.CreateCollectionIfNull[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon> ByRef)
       mov       [rbp+8],al
       mov       rcx,rbp
       call      System.Diagnostics.TraceInternal.WriteLine(System.Object)
       xor       ebx,ebx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
       test      eax,eax
       je        short M03_L10
       xor       ebp,ebp
       mov       r14d,[rsi+8]
       test      r14d,r14d
       jle       short M03_L10
M03_L06:
       movsxd    rcx,ebp
       mov       r15,[rsi+rcx*8+10]
       mov       rcx,r15
       test      rcx,rcx
       je        short M03_L09
       mov       rcx,[rdi+10]
       mov       rbx,[rsp+68]
       cmp       qword ptr [rcx+8],30
       jle       short M03_L07
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M03_L07
       jmp       short M03_L08
M03_L07:
       mov       rcx,rdi
       mov       rdx,7FFAAF493550
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L08:
       mov       rdx,rbx
       mov       r8,r15
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon)
       mov       ebx,1
M03_L09:
       add       ebp,1
       jo        short M03_L11
       cmp       r14d,ebp
       jg        short M03_L06
M03_L10:
       mov       eax,ebx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L11:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 454
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AddIfNotExists01()
; 			var people = new List<PersonProper>(base.GetPersonProperArray());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.AddIfNotExists(this.GetPeopleToInsert());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdi,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists(System.Collections.Generic.ICollection`1<!!0>, !!0[])
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon[])
       mov       rdx,[rsi+20]
       mov       [rdx+54],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 113
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       mov       rax,22DDEAD3020
       mov       rbx,[rax]
       mov       rax,22DDEAE1E00
       mov       rbp,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,rbp
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFAAF2E0570
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
; Total bytes of code 148
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       mov       [rbp+0FFB0],rsp
       mov       [rbp+0FFD0],rcx
       mov       [rbp+10],rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M02_L22
       mov       rdi,[rcx]
       mov       rdx,rdi
       mov       rax,[rdx+30]
       mov       rbx,[rax]
       mov       rax,[rbx+78]
       test      rax,rax
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdx
       mov       rdx,7FFAAF4E9A08
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M02_L01:
       mov       rcx,rax
       mov       rdx,rsi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r14,rax
       test      r14,r14
       je        near ptr M02_L11
       mov       rcx,rdi
       mov       r11,[rbx+90]
       test      r11,r11
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rdx,7FFAAF4E9A48
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L03:
       mov       rcx,r14
       call      qword ptr [r11]
       mov       esi,eax
       test      esi,esi
       je        short M02_L04
       mov       rcx,rdi
       mov       rdx,[rbx+70]
       test      rdx,rdx
       je        short M02_L07
       mov       [rbp+0FFC8],rdx
       jmp       short M02_L08
M02_L04:
       mov       rcx,rdi
       mov       rdx,[rbx+68]
       test      rdx,rdx
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rdx,7FFAAF4E5238
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M02_L06:
       mov       rcx,rdx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L07:
       mov       rdx,7FFAAF4E5248
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp+0FFC8],rax
M02_L08:
       movsxd    rdx,esi
       mov       rcx,[rbp+0FFC8]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       r15,[rcx+8]
       mov       rdx,rdi
       mov       r11,[rbx+98]
       test      r11,r11
       je        short M02_L09
       jmp       short M02_L10
M02_L09:
       mov       rcx,rdx
       mov       rdx,7FFAAF4E9A60
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L10:
       mov       rcx,r14
       mov       rdx,r15
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       mov       [rcx+10],esi
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L11:
       mov       rdx,rdi
       mov       rax,[rbx+68]
       test      rax,rax
       je        short M02_L12
       jmp       short M02_L13
M02_L12:
       mov       rcx,rdx
       mov       rdx,7FFAAF4E5238
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M02_L13:
       mov       rcx,rax
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       r11,[rbx+80]
       test      r11,r11
       je        short M02_L14
       jmp       short M02_L15
M02_L14:
       mov       rdx,7FFAAF4E9A18
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L15:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       [rbp+0FFC0],rax
       mov       rcx,rax
       mov       r11,7FFAAEE10760
       call      qword ptr [7FFAAF3F0760]
       test      eax,eax
       je        short M02_L21
M02_L16:
       mov       rcx,rdi
       mov       r11,[rbx+88]
       test      r11,r11
       je        short M02_L17
       jmp       short M02_L18
M02_L17:
       mov       rdx,7FFAAF4E9A30
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L18:
       mov       rcx,[rbp+0FFC0]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rdx,[rcx+8]
       mov       eax,[rcx+10]
       cmp       [rdx+8],eax
       jbe       short M02_L19
       lea       r9d,[rax+1]
       mov       [rcx+10],r9d
       mov       rcx,rdx
       mov       edx,eax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M02_L20
M02_L19:
       mov       rdx,r8
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M02_L20:
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFAAEE10760
       call      qword ptr [7FFAAF3F0760]
       test      eax,eax
       jne       short M02_L16
M02_L21:
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFAAEE10768
       call      qword ptr [7FFAAF3F0768]
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L22:
       mov       ecx,17
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp+0FFC0],0
       je        short M02_L23
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFAAEE10768
       call      qword ptr [7FFAAF3F0768]
M02_L23:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 717
```
```assembly
; DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       [rsp+68],rdx
       mov       rdi,rcx
       mov       rsi,r8
       mov       rbx,[rsp+68]
       mov       rbp,[rdi+10]
       test      rbx,rbx
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L00
       mov       rax,22DDEAD3020
       mov       r14,[rax]
       mov       rax,22DDEAE26C0
       mov       r15,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r15
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L00:
       cmp       qword ptr [rbp+18],0
       je        short M03_L01
       mov       rcx,[rbp+18]
       jmp       short M03_L02
M03_L01:
       mov       rcx,rdi
       mov       rdx,7FFAAF4A19F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L02:
       mov       r8,22DDEAD3020
       mov       r8,[r8]
       mov       r9,22DDEAE2C50
       mov       r9,[r9]
       mov       rdx,rbx
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
       mov       [rsp+68],rax
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L03
       mov       rax,22DDEAD3020
       mov       rbx,[rax]
       mov       rax,22DDEAE26B0
       mov       r14,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L03:
       cmp       qword ptr [rbp+28],0
       je        short M03_L04
       mov       rbx,[rbp+28]
       jmp       short M03_L05
M03_L04:
       mov       rcx,rdi
       mov       rdx,7FFAAF4A1B08
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rbx,rax
M03_L05:
       mov       rcx,offset MT_System.Boolean
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rdx,[rsp+68]
       mov       rcx,rbx
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.CreateCollectionIfNull[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon> ByRef)
       mov       [rbp+8],al
       mov       rcx,rbp
       call      System.Diagnostics.TraceInternal.WriteLine(System.Object)
       xor       ebx,ebx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
       test      eax,eax
       je        short M03_L10
       xor       ebp,ebp
       mov       r14d,[rsi+8]
       test      r14d,r14d
       jle       short M03_L10
M03_L06:
       movsxd    rcx,ebp
       mov       r15,[rsi+rcx*8+10]
       mov       rcx,r15
       test      rcx,rcx
       je        short M03_L09
       mov       rcx,[rdi+10]
       mov       rbx,[rsp+68]
       cmp       qword ptr [rcx+8],30
       jle       short M03_L07
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M03_L07
       jmp       short M03_L08
M03_L07:
       mov       rcx,rdi
       mov       rdx,7FFAAF4A3550
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L08:
       mov       rdx,rbx
       mov       r8,r15
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon)
       mov       ebx,1
M03_L09:
       add       ebp,1
       jo        short M03_L11
       cmp       r14d,ebp
       jg        short M03_L06
M03_L10:
       mov       eax,ebx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L11:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 454
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AddIfNotExists01()
; 			var people = new List<PersonProper>(base.GetPersonProperArray());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.AddIfNotExists(this.GetPeopleToInsert());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdi,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists(System.Collections.Generic.ICollection`1<!!0>, !!0[])
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon[])
       mov       rdx,[rsi+20]
       mov       [rdx+54],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 113
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       mov       rax,1A15AC51028
       mov       rbx,[rax]
       mov       rax,1A18AC55A60
       mov       rbp,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,rbp
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFAAF2C0570
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
; Total bytes of code 148
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       mov       [rbp+0FFB0],rsp
       mov       [rbp+0FFD0],rcx
       mov       [rbp+10],rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M02_L22
       mov       rdi,[rcx]
       mov       rdx,rdi
       mov       rax,[rdx+30]
       mov       rbx,[rax]
       mov       rax,[rbx+78]
       test      rax,rax
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdx
       mov       rdx,7FFAAF4C9998
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M02_L01:
       mov       rcx,rax
       mov       rdx,rsi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r14,rax
       test      r14,r14
       je        near ptr M02_L11
       mov       rcx,rdi
       mov       r11,[rbx+90]
       test      r11,r11
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rdx,7FFAAF4C99D8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L03:
       mov       rcx,r14
       call      qword ptr [r11]
       mov       esi,eax
       test      esi,esi
       je        short M02_L04
       mov       rcx,rdi
       mov       rdx,[rbx+70]
       test      rdx,rdx
       je        short M02_L07
       mov       [rbp+0FFC8],rdx
       jmp       short M02_L08
M02_L04:
       mov       rcx,rdi
       mov       rdx,[rbx+68]
       test      rdx,rdx
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rdx,7FFAAF4C5120
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M02_L06:
       mov       rcx,rdx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L07:
       mov       rdx,7FFAAF4C5130
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp+0FFC8],rax
M02_L08:
       movsxd    rdx,esi
       mov       rcx,[rbp+0FFC8]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       r15,[rcx+8]
       mov       rdx,rdi
       mov       r11,[rbx+98]
       test      r11,r11
       je        short M02_L09
       jmp       short M02_L10
M02_L09:
       mov       rcx,rdx
       mov       rdx,7FFAAF4C99F0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L10:
       mov       rcx,r14
       mov       rdx,r15
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       mov       [rcx+10],esi
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L11:
       mov       rdx,rdi
       mov       rax,[rbx+68]
       test      rax,rax
       je        short M02_L12
       jmp       short M02_L13
M02_L12:
       mov       rcx,rdx
       mov       rdx,7FFAAF4C5120
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M02_L13:
       mov       rcx,rax
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       r11,[rbx+80]
       test      r11,r11
       je        short M02_L14
       jmp       short M02_L15
M02_L14:
       mov       rdx,7FFAAF4C99A8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L15:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       [rbp+0FFC0],rax
       mov       rcx,rax
       mov       r11,7FFAAEDF0760
       call      qword ptr [7FFAAF3D0760]
       test      eax,eax
       je        short M02_L21
M02_L16:
       mov       rcx,rdi
       mov       r11,[rbx+88]
       test      r11,r11
       je        short M02_L17
       jmp       short M02_L18
M02_L17:
       mov       rdx,7FFAAF4C99C0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L18:
       mov       rcx,[rbp+0FFC0]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rdx,[rcx+8]
       mov       eax,[rcx+10]
       cmp       [rdx+8],eax
       jbe       short M02_L19
       lea       r9d,[rax+1]
       mov       [rcx+10],r9d
       mov       rcx,rdx
       mov       edx,eax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M02_L20
M02_L19:
       mov       rdx,r8
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M02_L20:
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFAAEDF0760
       call      qword ptr [7FFAAF3D0760]
       test      eax,eax
       jne       short M02_L16
M02_L21:
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFAAEDF0768
       call      qword ptr [7FFAAF3D0768]
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L22:
       mov       ecx,17
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp+0FFC0],0
       je        short M02_L23
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFAAEDF0768
       call      qword ptr [7FFAAF3D0768]
M02_L23:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 717
```
```assembly
; DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       [rsp+68],rdx
       mov       rdi,rcx
       mov       rsi,r8
       mov       rbx,[rsp+68]
       mov       rbp,[rdi+10]
       test      rbx,rbx
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L00
       mov       rax,1A15AC51028
       mov       r14,[rax]
       mov       rax,1A15AC5BA18
       mov       r15,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r15
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L00:
       cmp       qword ptr [rbp+18],0
       je        short M03_L01
       mov       rcx,[rbp+18]
       jmp       short M03_L02
M03_L01:
       mov       rcx,rdi
       mov       rdx,7FFAAF4819F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L02:
       mov       r8,1A15AC51028
       mov       r8,[r8]
       mov       r9,1A15AC5BFA8
       mov       r9,[r9]
       mov       rdx,rbx
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
       mov       [rsp+68],rax
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L03
       mov       rax,1A15AC51028
       mov       rbx,[rax]
       mov       rax,1A15AC5BA08
       mov       r14,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L03:
       cmp       qword ptr [rbp+28],0
       je        short M03_L04
       mov       rbx,[rbp+28]
       jmp       short M03_L05
M03_L04:
       mov       rcx,rdi
       mov       rdx,7FFAAF481B08
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rbx,rax
M03_L05:
       mov       rcx,offset MT_System.Boolean
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rdx,[rsp+68]
       mov       rcx,rbx
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.CreateCollectionIfNull[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon> ByRef)
       mov       [rbp+8],al
       mov       rcx,rbp
       call      System.Diagnostics.TraceInternal.WriteLine(System.Object)
       xor       ebx,ebx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
       test      eax,eax
       je        short M03_L10
       xor       ebp,ebp
       mov       r14d,[rsi+8]
       test      r14d,r14d
       jle       short M03_L10
M03_L06:
       movsxd    rcx,ebp
       mov       r15,[rsi+rcx*8+10]
       mov       rcx,r15
       test      rcx,rcx
       je        short M03_L09
       mov       rcx,[rdi+10]
       mov       rbx,[rsp+68]
       cmp       qword ptr [rcx+8],30
       jle       short M03_L07
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M03_L07
       jmp       short M03_L08
M03_L07:
       mov       rcx,rdi
       mov       rdx,7FFAAF483550
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L08:
       mov       rdx,rbx
       mov       r8,r15
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon)
       mov       ebx,1
M03_L09:
       add       ebp,1
       jo        short M03_L11
       cmp       r14d,ebp
       jg        short M03_L06
M03_L10:
       mov       eax,ebx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L11:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 454
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AddIfNotExists01()
; 			var people = new List<PersonProper>(base.GetPersonProperArray());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.AddIfNotExists(this.GetPeopleToInsert());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdi,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists(System.Collections.Generic.ICollection`1<!!0>, !!0[])
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon[])
       mov       rdx,[rsi+20]
       mov       [rdx+54],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 113
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       mov       rax,14E0FCF3020
       mov       rbx,[rax]
       mov       rax,14E0FD01E00
       mov       rbp,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,rbp
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFAAF2F0570
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
; Total bytes of code 148
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       mov       [rbp+0FFB0],rsp
       mov       [rbp+0FFD0],rcx
       mov       [rbp+10],rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M02_L22
       mov       rdi,[rcx]
       mov       rdx,rdi
       mov       rax,[rdx+30]
       mov       rbx,[rax]
       mov       rax,[rbx+78]
       test      rax,rax
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdx
       mov       rdx,7FFAAF4F9928
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M02_L01:
       mov       rcx,rax
       mov       rdx,rsi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r14,rax
       test      r14,r14
       je        near ptr M02_L11
       mov       rcx,rdi
       mov       r11,[rbx+90]
       test      r11,r11
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rdx,7FFAAF4F9968
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L03:
       mov       rcx,r14
       call      qword ptr [r11]
       mov       esi,eax
       test      esi,esi
       je        short M02_L04
       mov       rcx,rdi
       mov       rdx,[rbx+70]
       test      rdx,rdx
       je        short M02_L07
       mov       [rbp+0FFC8],rdx
       jmp       short M02_L08
M02_L04:
       mov       rcx,rdi
       mov       rdx,[rbx+68]
       test      rdx,rdx
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rdx,7FFAAF4F50F0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M02_L06:
       mov       rcx,rdx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L07:
       mov       rdx,7FFAAF4F5100
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp+0FFC8],rax
M02_L08:
       movsxd    rdx,esi
       mov       rcx,[rbp+0FFC8]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       r15,[rcx+8]
       mov       rdx,rdi
       mov       r11,[rbx+98]
       test      r11,r11
       je        short M02_L09
       jmp       short M02_L10
M02_L09:
       mov       rcx,rdx
       mov       rdx,7FFAAF4F9980
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L10:
       mov       rcx,r14
       mov       rdx,r15
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       mov       [rcx+10],esi
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L11:
       mov       rdx,rdi
       mov       rax,[rbx+68]
       test      rax,rax
       je        short M02_L12
       jmp       short M02_L13
M02_L12:
       mov       rcx,rdx
       mov       rdx,7FFAAF4F50F0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M02_L13:
       mov       rcx,rax
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       r11,[rbx+80]
       test      r11,r11
       je        short M02_L14
       jmp       short M02_L15
M02_L14:
       mov       rdx,7FFAAF4F9938
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L15:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       [rbp+0FFC0],rax
       mov       rcx,rax
       mov       r11,7FFAAEE20760
       call      qword ptr [7FFAAF400760]
       test      eax,eax
       je        short M02_L21
M02_L16:
       mov       rcx,rdi
       mov       r11,[rbx+88]
       test      r11,r11
       je        short M02_L17
       jmp       short M02_L18
M02_L17:
       mov       rdx,7FFAAF4F9950
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L18:
       mov       rcx,[rbp+0FFC0]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rdx,[rcx+8]
       mov       eax,[rcx+10]
       cmp       [rdx+8],eax
       jbe       short M02_L19
       lea       r9d,[rax+1]
       mov       [rcx+10],r9d
       mov       rcx,rdx
       mov       edx,eax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M02_L20
M02_L19:
       mov       rdx,r8
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M02_L20:
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFAAEE20760
       call      qword ptr [7FFAAF400760]
       test      eax,eax
       jne       short M02_L16
M02_L21:
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFAAEE20768
       call      qword ptr [7FFAAF400768]
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L22:
       mov       ecx,17
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp+0FFC0],0
       je        short M02_L23
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFAAEE20768
       call      qword ptr [7FFAAF400768]
M02_L23:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 717
```
```assembly
; DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       [rsp+68],rdx
       mov       rdi,rcx
       mov       rsi,r8
       mov       rbx,[rsp+68]
       mov       rbp,[rdi+10]
       test      rbx,rbx
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L00
       mov       rax,14E0FCF3020
       mov       r14,[rax]
       mov       rax,14E0FD036D8
       mov       r15,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r15
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L00:
       cmp       qword ptr [rbp+18],0
       je        short M03_L01
       mov       rcx,[rbp+18]
       jmp       short M03_L02
M03_L01:
       mov       rcx,rdi
       mov       rdx,7FFAAF4B1988
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L02:
       mov       r8,14E0FCF3020
       mov       r8,[r8]
       mov       r9,14E0FD03C68
       mov       r9,[r9]
       mov       rdx,rbx
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
       mov       [rsp+68],rax
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L03
       mov       rax,14E0FCF3020
       mov       rbx,[rax]
       mov       rax,14E0FD036C8
       mov       r14,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L03:
       cmp       qword ptr [rbp+28],0
       je        short M03_L04
       mov       rbx,[rbp+28]
       jmp       short M03_L05
M03_L04:
       mov       rcx,rdi
       mov       rdx,7FFAAF4B1AA0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rbx,rax
M03_L05:
       mov       rcx,offset MT_System.Boolean
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rdx,[rsp+68]
       mov       rcx,rbx
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.CreateCollectionIfNull[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon> ByRef)
       mov       [rbp+8],al
       mov       rcx,rbp
       call      System.Diagnostics.TraceInternal.WriteLine(System.Object)
       xor       ebx,ebx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
       test      eax,eax
       je        short M03_L10
       xor       ebp,ebp
       mov       r14d,[rsi+8]
       test      r14d,r14d
       jle       short M03_L10
M03_L06:
       movsxd    rcx,ebp
       mov       r15,[rsi+rcx*8+10]
       mov       rcx,r15
       test      rcx,rcx
       je        short M03_L09
       mov       rcx,[rdi+10]
       mov       rbx,[rsp+68]
       cmp       qword ptr [rcx+8],30
       jle       short M03_L07
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M03_L07
       jmp       short M03_L08
M03_L07:
       mov       rcx,rdi
       mov       rdx,7FFAAF4B34E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L08:
       mov       rdx,rbx
       mov       r8,r15
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon)
       mov       ebx,1
M03_L09:
       add       ebp,1
       jo        short M03_L11
       cmp       r14d,ebp
       jg        short M03_L06
M03_L10:
       mov       eax,ebx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L11:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 454
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AddIfNotExists01()
; 			var people = new List<PersonProper>(base.GetPersonProperArray());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.AddIfNotExists(this.GetPeopleToInsert());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdi,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists(System.Collections.Generic.ICollection`1<!!0>, !!0[])
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon[])
       mov       rdx,[rsi+20]
       mov       [rdx+54],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 113
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       mov       rax,14D2BD81028
       mov       rbx,[rax]
       mov       rax,14D0BD835C0
       mov       rbp,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,rbp
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFAAF2F0570
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
; Total bytes of code 148
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       mov       [rbp+0FFB0],rsp
       mov       [rbp+0FFD0],rcx
       mov       [rbp+10],rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M02_L22
       mov       rdi,[rcx]
       mov       rdx,rdi
       mov       rax,[rdx+30]
       mov       rbx,[rax]
       mov       rax,[rbx+78]
       test      rax,rax
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdx
       mov       rdx,7FFAAF509B00
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M02_L01:
       mov       rcx,rax
       mov       rdx,rsi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r14,rax
       test      r14,r14
       je        near ptr M02_L11
       mov       rcx,rdi
       mov       r11,[rbx+90]
       test      r11,r11
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rdx,7FFAAF509B40
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L03:
       mov       rcx,r14
       call      qword ptr [r11]
       mov       esi,eax
       test      esi,esi
       je        short M02_L04
       mov       rcx,rdi
       mov       rdx,[rbx+70]
       test      rdx,rdx
       je        short M02_L07
       mov       [rbp+0FFC8],rdx
       jmp       short M02_L08
M02_L04:
       mov       rcx,rdi
       mov       rdx,[rbx+68]
       test      rdx,rdx
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rdx,7FFAAF505210
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M02_L06:
       mov       rcx,rdx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L07:
       mov       rdx,7FFAAF505220
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp+0FFC8],rax
M02_L08:
       movsxd    rdx,esi
       mov       rcx,[rbp+0FFC8]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       r15,[rcx+8]
       mov       rdx,rdi
       mov       r11,[rbx+98]
       test      r11,r11
       je        short M02_L09
       jmp       short M02_L10
M02_L09:
       mov       rcx,rdx
       mov       rdx,7FFAAF509B58
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L10:
       mov       rcx,r14
       mov       rdx,r15
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       mov       [rcx+10],esi
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L11:
       mov       rdx,rdi
       mov       rax,[rbx+68]
       test      rax,rax
       je        short M02_L12
       jmp       short M02_L13
M02_L12:
       mov       rcx,rdx
       mov       rdx,7FFAAF505210
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M02_L13:
       mov       rcx,rax
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       r11,[rbx+80]
       test      r11,r11
       je        short M02_L14
       jmp       short M02_L15
M02_L14:
       mov       rdx,7FFAAF509B10
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L15:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       [rbp+0FFC0],rax
       mov       rcx,rax
       mov       r11,7FFAAEE20768
       call      qword ptr [7FFAAF400768]
       test      eax,eax
       je        short M02_L21
M02_L16:
       mov       rcx,rdi
       mov       r11,[rbx+88]
       test      r11,r11
       je        short M02_L17
       jmp       short M02_L18
M02_L17:
       mov       rdx,7FFAAF509B28
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L18:
       mov       rcx,[rbp+0FFC0]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rdx,[rcx+8]
       mov       eax,[rcx+10]
       cmp       [rdx+8],eax
       jbe       short M02_L19
       lea       r9d,[rax+1]
       mov       [rcx+10],r9d
       mov       rcx,rdx
       mov       edx,eax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M02_L20
M02_L19:
       mov       rdx,r8
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M02_L20:
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFAAEE20768
       call      qword ptr [7FFAAF400768]
       test      eax,eax
       jne       short M02_L16
M02_L21:
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFAAEE20770
       call      qword ptr [7FFAAF400770]
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L22:
       mov       ecx,17
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp+0FFC0],0
       je        short M02_L23
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFAAEE20770
       call      qword ptr [7FFAAF400770]
M02_L23:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 717
```
```assembly
; DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       [rsp+68],rdx
       mov       rdi,rcx
       mov       rsi,r8
       mov       rbx,[rsp+68]
       mov       rbp,[rdi+10]
       test      rbx,rbx
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L00
       mov       rax,14D2BD81028
       mov       r14,[rax]
       mov       rax,14D0BD84E98
       mov       r15,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r15
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L00:
       cmp       qword ptr [rbp+18],0
       je        short M03_L01
       mov       rcx,[rbp+18]
       jmp       short M03_L02
M03_L01:
       mov       rcx,rdi
       mov       rdx,7FFAAF4B19F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L02:
       mov       r8,14D2BD81028
       mov       r8,[r8]
       mov       r9,14D0BD85428
       mov       r9,[r9]
       mov       rdx,rbx
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
       mov       [rsp+68],rax
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L03
       mov       rax,14D2BD81028
       mov       rbx,[rax]
       mov       rax,14D0BD84E88
       mov       r14,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L03:
       cmp       qword ptr [rbp+28],0
       je        short M03_L04
       mov       rbx,[rbp+28]
       jmp       short M03_L05
M03_L04:
       mov       rcx,rdi
       mov       rdx,7FFAAF4B1B08
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rbx,rax
M03_L05:
       mov       rcx,offset MT_System.Boolean
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rdx,[rsp+68]
       mov       rcx,rbx
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.CreateCollectionIfNull[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon> ByRef)
       mov       [rbp+8],al
       mov       rcx,rbp
       call      System.Diagnostics.TraceInternal.WriteLine(System.Object)
       xor       ebx,ebx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
       test      eax,eax
       je        short M03_L10
       xor       ebp,ebp
       mov       r14d,[rsi+8]
       test      r14d,r14d
       jle       short M03_L10
M03_L06:
       movsxd    rcx,ebp
       mov       r15,[rsi+rcx*8+10]
       mov       rcx,r15
       test      rcx,rcx
       je        short M03_L09
       mov       rcx,[rdi+10]
       mov       rbx,[rsp+68]
       cmp       qword ptr [rcx+8],30
       jle       short M03_L07
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M03_L07
       jmp       short M03_L08
M03_L07:
       mov       rcx,rdi
       mov       rdx,7FFAAF4B3550
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L08:
       mov       rdx,rbx
       mov       r8,r15
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon)
       mov       ebx,1
M03_L09:
       add       ebp,1
       jo        short M03_L11
       cmp       r14d,ebp
       jg        short M03_L06
M03_L10:
       mov       eax,ebx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L11:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 454
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AddIfNotExists01()
; 			var people = new List<PersonProper>(base.GetPersonProperArray());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.AddIfNotExists(this.GetPeopleToInsert());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdi,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists(System.Collections.Generic.ICollection`1<!!0>, !!0[])
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon[])
       mov       rdx,[rsi+20]
       mov       [rdx+54],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 113
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       mov       rax,28F33273020
       mov       rbx,[rax]
       mov       rax,28F33281E00
       mov       rbp,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,rbp
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFAAF2C0570
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
; Total bytes of code 148
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       mov       [rbp+0FFB0],rsp
       mov       [rbp+0FFD0],rcx
       mov       [rbp+10],rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M02_L22
       mov       rdi,[rcx]
       mov       rdx,rdi
       mov       rax,[rdx+30]
       mov       rbx,[rax]
       mov       rax,[rbx+78]
       test      rax,rax
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdx
       mov       rdx,7FFAAF4C99B0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M02_L01:
       mov       rcx,rax
       mov       rdx,rsi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r14,rax
       test      r14,r14
       je        near ptr M02_L11
       mov       rcx,rdi
       mov       r11,[rbx+90]
       test      r11,r11
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rdx,7FFAAF4C99F0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L03:
       mov       rcx,r14
       call      qword ptr [r11]
       mov       esi,eax
       test      esi,esi
       je        short M02_L04
       mov       rcx,rdi
       mov       rdx,[rbx+70]
       test      rdx,rdx
       je        short M02_L07
       mov       [rbp+0FFC8],rdx
       jmp       short M02_L08
M02_L04:
       mov       rcx,rdi
       mov       rdx,[rbx+68]
       test      rdx,rdx
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rdx,7FFAAF4C5378
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M02_L06:
       mov       rcx,rdx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L07:
       mov       rdx,7FFAAF4C5388
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp+0FFC8],rax
M02_L08:
       movsxd    rdx,esi
       mov       rcx,[rbp+0FFC8]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       r15,[rcx+8]
       mov       rdx,rdi
       mov       r11,[rbx+98]
       test      r11,r11
       je        short M02_L09
       jmp       short M02_L10
M02_L09:
       mov       rcx,rdx
       mov       rdx,7FFAAF4C9A08
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L10:
       mov       rcx,r14
       mov       rdx,r15
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       mov       [rcx+10],esi
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L11:
       mov       rdx,rdi
       mov       rax,[rbx+68]
       test      rax,rax
       je        short M02_L12
       jmp       short M02_L13
M02_L12:
       mov       rcx,rdx
       mov       rdx,7FFAAF4C5378
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M02_L13:
       mov       rcx,rax
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       r11,[rbx+80]
       test      r11,r11
       je        short M02_L14
       jmp       short M02_L15
M02_L14:
       mov       rdx,7FFAAF4C99C0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L15:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       [rbp+0FFC0],rax
       mov       rcx,rax
       mov       r11,7FFAAEDF0760
       call      qword ptr [7FFAAF3D0760]
       test      eax,eax
       je        short M02_L21
M02_L16:
       mov       rcx,rdi
       mov       r11,[rbx+88]
       test      r11,r11
       je        short M02_L17
       jmp       short M02_L18
M02_L17:
       mov       rdx,7FFAAF4C99D8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L18:
       mov       rcx,[rbp+0FFC0]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rdx,[rcx+8]
       mov       eax,[rcx+10]
       cmp       [rdx+8],eax
       jbe       short M02_L19
       lea       r9d,[rax+1]
       mov       [rcx+10],r9d
       mov       rcx,rdx
       mov       edx,eax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M02_L20
M02_L19:
       mov       rdx,r8
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M02_L20:
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFAAEDF0760
       call      qword ptr [7FFAAF3D0760]
       test      eax,eax
       jne       short M02_L16
M02_L21:
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFAAEDF0768
       call      qword ptr [7FFAAF3D0768]
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L22:
       mov       ecx,17
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp+0FFC0],0
       je        short M02_L23
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFAAEDF0768
       call      qword ptr [7FFAAF3D0768]
M02_L23:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 717
```
```assembly
; DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       [rsp+68],rdx
       mov       rdi,rcx
       mov       rsi,r8
       mov       rbx,[rsp+68]
       mov       rbp,[rdi+10]
       test      rbx,rbx
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L00
       mov       rax,28F33273020
       mov       r14,[rax]
       mov       rax,28F13272688
       mov       r15,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r15
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L00:
       cmp       qword ptr [rbp+18],0
       je        short M03_L01
       mov       rcx,[rbp+18]
       jmp       short M03_L02
M03_L01:
       mov       rcx,rdi
       mov       rdx,7FFAAF4819F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L02:
       mov       r8,28F33273020
       mov       r8,[r8]
       mov       r9,28F13272C18
       mov       r9,[r9]
       mov       rdx,rbx
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
       mov       [rsp+68],rax
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L03
       mov       rax,28F33273020
       mov       rbx,[rax]
       mov       rax,28F13272678
       mov       r14,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L03:
       cmp       qword ptr [rbp+28],0
       je        short M03_L04
       mov       rbx,[rbp+28]
       jmp       short M03_L05
M03_L04:
       mov       rcx,rdi
       mov       rdx,7FFAAF481B08
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rbx,rax
M03_L05:
       mov       rcx,offset MT_System.Boolean
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rdx,[rsp+68]
       mov       rcx,rbx
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.CreateCollectionIfNull[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon> ByRef)
       mov       [rbp+8],al
       mov       rcx,rbp
       call      System.Diagnostics.TraceInternal.WriteLine(System.Object)
       xor       ebx,ebx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
       test      eax,eax
       je        short M03_L10
       xor       ebp,ebp
       mov       r14d,[rsi+8]
       test      r14d,r14d
       jle       short M03_L10
M03_L06:
       movsxd    rcx,ebp
       mov       r15,[rsi+rcx*8+10]
       mov       rcx,r15
       test      rcx,rcx
       je        short M03_L09
       mov       rcx,[rdi+10]
       mov       rbx,[rsp+68]
       cmp       qword ptr [rcx+8],30
       jle       short M03_L07
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M03_L07
       jmp       short M03_L08
M03_L07:
       mov       rcx,rdi
       mov       rdx,7FFAAF483550
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L08:
       mov       rdx,rbx
       mov       r8,r15
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon)
       mov       ebx,1
M03_L09:
       add       ebp,1
       jo        short M03_L11
       cmp       r14d,ebp
       jg        short M03_L06
M03_L10:
       mov       eax,ebx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L11:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 454
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AddIfNotExists01()
; 			var people = new List<PersonProper>(base.GetPersonProperArray());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.AddIfNotExists(this.GetPeopleToInsert());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdi,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists(System.Collections.Generic.ICollection`1<!!0>, !!0[])
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon[])
       mov       rdx,[rsi+20]
       mov       [rdx+54],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 113
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       mov       rax,292A7983020
       mov       rbx,[rax]
       mov       rax,292A7991E00
       mov       rbp,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,rbp
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFAAF2E0570
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
; Total bytes of code 148
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       mov       [rbp+0FFB0],rsp
       mov       [rbp+0FFD0],rcx
       mov       [rbp+10],rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M02_L22
       mov       rdi,[rcx]
       mov       rdx,rdi
       mov       rax,[rdx+30]
       mov       rbx,[rax]
       mov       rax,[rbx+78]
       test      rax,rax
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdx
       mov       rdx,7FFAAF4EB120
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M02_L01:
       mov       rcx,rax
       mov       rdx,rsi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r14,rax
       test      r14,r14
       je        near ptr M02_L11
       mov       rcx,rdi
       mov       r11,[rbx+90]
       test      r11,r11
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rdx,7FFAAF4EB160
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L03:
       mov       rcx,r14
       call      qword ptr [r11]
       mov       esi,eax
       test      esi,esi
       je        short M02_L04
       mov       rcx,rdi
       mov       rdx,[rbx+70]
       test      rdx,rdx
       je        short M02_L07
       mov       [rbp+0FFC8],rdx
       jmp       short M02_L08
M02_L04:
       mov       rcx,rdi
       mov       rdx,[rbx+68]
       test      rdx,rdx
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rdx,7FFAAF4E5160
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M02_L06:
       mov       rcx,rdx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L07:
       mov       rdx,7FFAAF4E5170
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp+0FFC8],rax
M02_L08:
       movsxd    rdx,esi
       mov       rcx,[rbp+0FFC8]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       r15,[rcx+8]
       mov       rdx,rdi
       mov       r11,[rbx+98]
       test      r11,r11
       je        short M02_L09
       jmp       short M02_L10
M02_L09:
       mov       rcx,rdx
       mov       rdx,7FFAAF4EB178
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L10:
       mov       rcx,r14
       mov       rdx,r15
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       mov       [rcx+10],esi
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L11:
       mov       rdx,rdi
       mov       rax,[rbx+68]
       test      rax,rax
       je        short M02_L12
       jmp       short M02_L13
M02_L12:
       mov       rcx,rdx
       mov       rdx,7FFAAF4E5160
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M02_L13:
       mov       rcx,rax
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       r11,[rbx+80]
       test      r11,r11
       je        short M02_L14
       jmp       short M02_L15
M02_L14:
       mov       rdx,7FFAAF4EB130
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L15:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       [rbp+0FFC0],rax
       mov       rcx,rax
       mov       r11,7FFAAEE10760
       call      qword ptr [7FFAAF3F0760]
       test      eax,eax
       je        short M02_L21
M02_L16:
       mov       rcx,rdi
       mov       r11,[rbx+88]
       test      r11,r11
       je        short M02_L17
       jmp       short M02_L18
M02_L17:
       mov       rdx,7FFAAF4EB148
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L18:
       mov       rcx,[rbp+0FFC0]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rdx,[rcx+8]
       mov       eax,[rcx+10]
       cmp       [rdx+8],eax
       jbe       short M02_L19
       lea       r9d,[rax+1]
       mov       [rcx+10],r9d
       mov       rcx,rdx
       mov       edx,eax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M02_L20
M02_L19:
       mov       rdx,r8
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M02_L20:
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFAAEE10760
       call      qword ptr [7FFAAF3F0760]
       test      eax,eax
       jne       short M02_L16
M02_L21:
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFAAEE10768
       call      qword ptr [7FFAAF3F0768]
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L22:
       mov       ecx,17
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp+0FFC0],0
       je        short M02_L23
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFAAEE10768
       call      qword ptr [7FFAAF3F0768]
M02_L23:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 717
```
```assembly
; DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       [rsp+68],rdx
       mov       rdi,rcx
       mov       rsi,r8
       mov       rbx,[rsp+68]
       mov       rbp,[rdi+10]
       test      rbx,rbx
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L00
       mov       rax,292A7983020
       mov       r14,[rax]
       mov       rax,29287981670
       mov       r15,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r15
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L00:
       cmp       qword ptr [rbp+18],0
       je        short M03_L01
       mov       rcx,[rbp+18]
       jmp       short M03_L02
M03_L01:
       mov       rcx,rdi
       mov       rdx,7FFAAF4A1A08
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L02:
       mov       r8,292A7983020
       mov       r8,[r8]
       mov       r9,29287981C00
       mov       r9,[r9]
       mov       rdx,rbx
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
       mov       [rsp+68],rax
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L03
       mov       rax,292A7983020
       mov       rbx,[rax]
       mov       rax,29287981660
       mov       r14,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L03:
       cmp       qword ptr [rbp+28],0
       je        short M03_L04
       mov       rbx,[rbp+28]
       jmp       short M03_L05
M03_L04:
       mov       rcx,rdi
       mov       rdx,7FFAAF4A1B20
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rbx,rax
M03_L05:
       mov       rcx,offset MT_System.Boolean
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rdx,[rsp+68]
       mov       rcx,rbx
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.CreateCollectionIfNull[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon> ByRef)
       mov       [rbp+8],al
       mov       rcx,rbp
       call      System.Diagnostics.TraceInternal.WriteLine(System.Object)
       xor       ebx,ebx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
       test      eax,eax
       je        short M03_L10
       xor       ebp,ebp
       mov       r14d,[rsi+8]
       test      r14d,r14d
       jle       short M03_L10
M03_L06:
       movsxd    rcx,ebp
       mov       r15,[rsi+rcx*8+10]
       mov       rcx,r15
       test      rcx,rcx
       je        short M03_L09
       mov       rcx,[rdi+10]
       mov       rbx,[rsp+68]
       cmp       qword ptr [rcx+8],30
       jle       short M03_L07
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M03_L07
       jmp       short M03_L08
M03_L07:
       mov       rcx,rdi
       mov       rdx,7FFAAF4A3568
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L08:
       mov       rdx,rbx
       mov       r8,r15
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon)
       mov       ebx,1
M03_L09:
       add       ebp,1
       jo        short M03_L11
       cmp       r14d,ebp
       jg        short M03_L06
M03_L10:
       mov       eax,ebx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L11:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 454
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AddIfNotExists01()
; 			var people = new List<PersonProper>(base.GetPersonProperArray());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.AddIfNotExists(this.GetPeopleToInsert());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdi,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists(System.Collections.Generic.ICollection`1<!!0>, !!0[])
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon[])
       mov       rdx,[rsi+20]
       mov       [rdx+54],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 113
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       mov       rax,1FF3FF73020
       mov       rbx,[rax]
       mov       rax,1FF5FF715C8
       mov       rbp,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,rbp
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFAAF2D0570
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
; Total bytes of code 148
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       mov       [rbp+0FFB0],rsp
       mov       [rbp+0FFD0],rcx
       mov       [rbp+10],rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M02_L22
       mov       rdi,[rcx]
       mov       rdx,rdi
       mov       rax,[rdx+30]
       mov       rbx,[rax]
       mov       rax,[rbx+78]
       test      rax,rax
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdx
       mov       rdx,7FFAAF4F4280
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M02_L01:
       mov       rcx,rax
       mov       rdx,rsi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r14,rax
       test      r14,r14
       je        near ptr M02_L11
       mov       rcx,rdi
       mov       r11,[rbx+90]
       test      r11,r11
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rdx,7FFAAF4F42C0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L03:
       mov       rcx,r14
       call      qword ptr [r11]
       mov       esi,eax
       test      esi,esi
       je        short M02_L04
       mov       rcx,rdi
       mov       rdx,[rbx+38]
       test      rdx,rdx
       je        short M02_L07
       mov       [rbp+0FFC8],rdx
       jmp       short M02_L08
M02_L04:
       mov       rcx,rdi
       mov       rdx,[rbx+40]
       test      rdx,rdx
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rdx,7FFAAF397D68
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M02_L06:
       mov       rcx,rdx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L07:
       mov       rdx,7FFAAF397D60
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp+0FFC8],rax
M02_L08:
       movsxd    rdx,esi
       mov       rcx,[rbp+0FFC8]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       r15,[rcx+8]
       mov       rdx,rdi
       mov       r11,[rbx+98]
       test      r11,r11
       je        short M02_L09
       jmp       short M02_L10
M02_L09:
       mov       rcx,rdx
       mov       rdx,7FFAAF4F42D8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L10:
       mov       rcx,r14
       mov       rdx,r15
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       mov       [rcx+10],esi
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L11:
       mov       rdx,rdi
       mov       rax,[rbx+40]
       test      rax,rax
       je        short M02_L12
       jmp       short M02_L13
M02_L12:
       mov       rcx,rdx
       mov       rdx,7FFAAF397D68
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M02_L13:
       mov       rcx,rax
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       r11,[rbx+80]
       test      r11,r11
       je        short M02_L14
       jmp       short M02_L15
M02_L14:
       mov       rdx,7FFAAF4F4290
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L15:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       [rbp+0FFC0],rax
       mov       rcx,rax
       mov       r11,7FFAAEE008C0
       call      qword ptr [7FFAAF3F08C0]
       test      eax,eax
       je        short M02_L21
M02_L16:
       mov       rcx,rdi
       mov       r11,[rbx+88]
       test      r11,r11
       je        short M02_L17
       jmp       short M02_L18
M02_L17:
       mov       rdx,7FFAAF4F42A8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L18:
       mov       rcx,[rbp+0FFC0]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rdx,[rcx+8]
       mov       eax,[rcx+10]
       cmp       [rdx+8],eax
       jbe       short M02_L19
       lea       r9d,[rax+1]
       mov       [rcx+10],r9d
       mov       rcx,rdx
       mov       edx,eax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M02_L20
M02_L19:
       mov       rdx,r8
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M02_L20:
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFAAEE008C0
       call      qword ptr [7FFAAF3F08C0]
       test      eax,eax
       jne       short M02_L16
M02_L21:
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFAAEE008C8
       call      qword ptr [7FFAAF3F08C8]
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L22:
       mov       ecx,17
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp+0FFC0],0
       je        short M02_L23
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFAAEE008C8
       call      qword ptr [7FFAAF3F08C8]
M02_L23:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 717
```
```assembly
; DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       [rsp+68],rdx
       mov       rdi,rcx
       mov       rsi,r8
       mov       rbx,[rsp+68]
       mov       rbp,[rdi+10]
       test      rbx,rbx
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L00
       mov       rax,1FF3FF73020
       mov       r14,[rax]
       mov       rax,1FF3FF75A78
       mov       r15,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r15
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L00:
       cmp       qword ptr [rbp+18],0
       je        short M03_L01
       mov       rcx,[rbp+18]
       jmp       short M03_L02
M03_L01:
       mov       rcx,rdi
       mov       rdx,7FFAAF4B1A08
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L02:
       mov       r8,1FF3FF73020
       mov       r8,[r8]
       mov       r9,1FF3FF76008
       mov       r9,[r9]
       mov       rdx,rbx
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.String, System.String)
       mov       [rsp+68],rax
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L03
       mov       rax,1FF3FF73020
       mov       rbx,[rax]
       mov       rax,1FF3FF75A68
       mov       r14,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L03:
       cmp       qword ptr [rbp+28],0
       je        short M03_L04
       mov       rbx,[rbp+28]
       jmp       short M03_L05
M03_L04:
       mov       rcx,rdi
       mov       rdx,7FFAAF4B1B20
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rbx,rax
M03_L05:
       mov       rcx,offset MT_System.Boolean
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rdx,[rsp+68]
       mov       rcx,rbx
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.CreateCollectionIfNull[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon> ByRef)
       mov       [rbp+8],al
       mov       rcx,rbp
       call      System.Diagnostics.TraceInternal.WriteLine(System.Object)
       xor       ebx,ebx
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
       test      eax,eax
       je        short M03_L10
       xor       ebp,ebp
       mov       r14d,[rsi+8]
       test      r14d,r14d
       jle       short M03_L10
M03_L06:
       movsxd    rcx,ebp
       mov       r15,[rsi+rcx*8+10]
       mov       rcx,r15
       test      rcx,rcx
       je        short M03_L09
       mov       rcx,[rdi+10]
       mov       rbx,[rsp+68]
       cmp       qword ptr [rcx+8],30
       jle       short M03_L07
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M03_L07
       jmp       short M03_L08
M03_L07:
       mov       rcx,rdi
       mov       rdx,7FFAAF4B3568
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L08:
       mov       rdx,rbx
       mov       r8,r15
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon)
       mov       ebx,1
M03_L09:
       add       ebp,1
       jo        short M03_L11
       cmp       r14d,ebp
       jg        short M03_L06
M03_L10:
       mov       eax,ebx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L11:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 454
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.BytesToString02()
; 			var readOnlySpan = new ReadOnlySpan<byte>(base.GetByteArray(1));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = readOnlySpan.BytesToString();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,38
       vzeroupper
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rax
       mov       rsi,rcx
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       mov       edx,1
       call      System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       test      rax,rax
       jne       short M00_L00
       mov       rdi,[rsi+8]
       vmovsd    xmm0,qword ptr [7FFAAF3DB2D0]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       mov       r8,rax
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,1
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(Int32, System.__Canon, System.Collections.Generic.InsertionBehavior)
M00_L00:
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       mov       edx,1
       call      System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       test      rax,rax
       je        short M00_L03
       mov       rcx,[rax]
       test      rcx,rcx
       je        short M00_L02
       lea       rax,[rcx+10]
       mov       ecx,[rcx+8]
M00_L01:
       mov       [rsp+28],rax
       mov       [rsp+30],ecx
       lea       rcx,[rsp+28]
       call      DotNetTips.Spargine.Extensions.ArrayExtensions.BytesToString(System.ReadOnlySpan`1<Byte>)
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,38
       pop       rsi
       pop       rdi
       ret
M00_L02:
       xor       eax,eax
       xor       ecx,ecx
       jmp       short M00_L01
M00_L03:
       mov       ecx,1
       call      System.ThrowHelper.ThrowKeyNotFoundException[[System.Int32, System.Private.CoreLib]](Int32)
       int       3
; Total bytes of code 184
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       edi,edx
       mov       rax,[rsi]
       mov       rax,[rax+30]
       mov       rbx,[rax]
       cmp       qword ptr [rsi+8],0
       jne       short M01_L01
M01_L00:
       cmp       qword ptr [rbx+28],0
       je        near ptr M01_L05
       jmp       near ptr M01_L05
M01_L01:
       mov       rbp,[rsi+18]
       test      rbp,rbp
       jne       near ptr M01_L06
       mov       eax,edi
       mov       rcx,[rsi+8]
       mov       edx,[rcx+8]
       mov       r11d,edx
       mov       r8,[rsi+30]
       mov       r9d,eax
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       r11d,r11d
       imul      r11,r8
       shr       r11,20
       cmp       r11d,edx
       jae       near ptr M01_L11
       movsxd    rdx,r11d
       lea       rcx,[rcx+rdx*4+10]
       mov       ecx,[rcx]
       mov       rdx,[rsi+10]
       xor       r11d,r11d
       dec       ecx
       mov       r8d,[rdx+8]
M01_L02:
       cmp       r8d,ecx
       jbe       short M01_L00
       movsxd    rcx,ecx
       lea       rcx,[rcx+rcx*2]
       lea       r14,[rdx+rcx*8+10]
       cmp       [r14+8],edi
       jne       short M01_L03
       mov       ecx,[r14+10]
       cmp       ecx,eax
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       short M01_L04
M01_L03:
       mov       ecx,[r14+0C]
       inc       r11d
       cmp       r8d,r11d
       jb        near ptr M01_L09
       jmp       short M01_L02
M01_L04:
       mov       rax,r14
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L05:
       xor       r14d,r14d
       jmp       short M01_L04
M01_L06:
       mov       rcx,rbp
       mov       edx,edi
       mov       r11,7FFAAEE20670
       call      qword ptr [7FFAAF3E0670]
       mov       r14d,eax
       mov       rdx,[rsi+8]
       mov       ecx,[rdx+8]
       mov       r8,[rsi+30]
       mov       r11d,r14d
       imul      r8,r11
       shr       r8,20
       inc       r8
       mov       ecx,ecx
       imul      rcx,r8
       shr       rcx,20
       cmp       ecx,[rdx+8]
       jae       short M01_L11
       movsxd    rcx,ecx
       lea       rdx,[rdx+rcx*4+10]
       mov       r15d,[rdx]
       mov       r12,[rsi+10]
       xor       r13d,r13d
       dec       r15d
M01_L07:
       cmp       [r12+8],r15d
       jbe       near ptr M01_L00
       movsxd    rdx,r15d
       lea       rdx,[rdx+rdx*2]
       lea       rdx,[r12+rdx*8+10]
       mov       r15,rdx
       cmp       [r15+8],r14d
       jne       short M01_L08
       mov       edx,[r15+10]
       mov       rcx,rbp
       mov       r8d,edi
       mov       r11,7FFAAEE20678
       call      qword ptr [7FFAAF3E0678]
       test      eax,eax
       jne       short M01_L10
M01_L08:
       mov       r15d,[r15+0C]
       inc       r13d
       cmp       [r12+8],r13d
       jae       short M01_L07
M01_L09:
       call      System.ThrowHelper.ThrowInvalidOperationException_ConcurrentOperationsNotSupported()
       int       3
M01_L10:
       mov       r14,r15
       jmp       near ptr M01_L04
M01_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 408
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       push      rbp
       sub       rsp,0A0
       vzeroupper
       lea       rbp,[rsp+0A0]
       xor       eax,eax
       mov       [rbp+0FF98],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFA0
M02_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M02_L00
       mov       [rbp+0FF88],rsp
       vmovsd    qword ptr [rbp+10],xmm0
       call      System.Globalization.CultureInfo.get_InvariantCulture()
       mov       [rbp+0FFD8],rax
       mov       rcx,offset MT_System.Double
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp+0FFD0],rax
       call      DotNetTips.Spargine.Tester.Properties.Resources.get_SizeMustBeEpsilon()
       mov       [rbp+0FFC8],rax
       mov       r8,[rbp+0FFD0]
       mov       qword ptr [r8+8],1
       mov       r8,[rbp+0FFD0]
       mov       rcx,[rbp+0FFD8]
       mov       rdx,[rbp+0FFC8]
       call      System.String.Format(System.IFormatProvider, System.String, System.Object)
       mov       [rbp+0FFC0],rax
       mov       r9,237CAB52D58
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,[rbp+0FFC0]
       vmovsd    xmm2,qword ptr [rbp+10]
       vucomisd  xmm2,qword ptr [7FFAAF1E8A38]
       setae     dl
       movzx     edx,dl
       vxorps    xmm2,xmm2,xmm2
       vmovsd    xmm0,qword ptr [rbp+10]
       call      DotNetTips.Spargine.Core.Validator.ArgumentMeetsCondition[[System.Double, System.Private.CoreLib]](Double, Boolean, Double, System.String, System.String)
       vmovsd    qword ptr [rbp+10],xmm0
       vmovsd    xmm0,qword ptr [rbp+10]
       vmulsd    xmm0,xmm0,qword ptr [7FFAAF1E8A40]
       call      System.Convert.ToInt32(Double)
       movsxd    rdx,eax
       mov       [rbp+0FFB8],rdx
       mov       rdx,[rbp+0FFB8]
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp+0FFB0],rax
       mov       rdx,[rbp+0FFB0]
       lea       rcx,[rbp+0FFF0]
       call      System.Span`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte[])
       mov       rdx,237CAB4B850
       mov       rdx,[rdx]
       mov       [rbp+0FFE8],rdx
       xor       edx,edx
       mov       [rbp+0FFE0],edx
       lea       rdx,[rbp+0FFE0]
       mov       rcx,[rbp+0FFE8]
       call      System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,237CAB4B858
       mov       rcx,[rcx]
       mov       [rbp+0FF98],rcx
       vmovdqu   xmm0,xmmword ptr [rbp+0FFF0]
       vmovdqu   xmmword ptr [rbp+0FFA0],xmm0
       mov       rcx,[rbp+0FF98]
       lea       rdx,[rbp+0FFA0]
       mov       rax,[rbp+0FF98]
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       jmp       short M02_L01
M02_L01:
       mov       rcx,rsp
       call      M02_L02
       nop
       lea       rcx,[rbp+0FFF0]
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].ToArray()
       nop
       add       rsp,0A0
       pop       rbp
       ret
M02_L02:
       push      rbp
       sub       rsp,30
       vzeroupper
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+0A0]
       mov       ecx,[rbp+0FFE0]
       movzx     ecx,cl
       test      ecx,ecx
       je        short M02_L03
       mov       rcx,[rbp+0FFE8]
       call      System.Threading.Monitor.Exit(System.Object)
M02_L03:
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 425
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(Int32, System.__Canon, System.Collections.Generic.InsertionBehavior)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rsi,rcx
       mov       edi,edx
       mov       rbx,r8
       mov       ebp,r9d
       cmp       qword ptr [rsi+8],0
       jne       short M03_L00
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFB0D975AE0]
M03_L00:
       mov       r14,[rsi+10]
       mov       r15,[rsi+18]
       test      r15,r15
       jne       near ptr M03_L20
       mov       r12d,edi
M03_L01:
       xor       r13d,r13d
       mov       rdx,[rsi+8]
       mov       ecx,[rdx+8]
       mov       eax,ecx
       mov       r8,[rsi+30]
       mov       r9d,r12d
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       eax,eax
       imul      rax,r8
       shr       rax,20
       cmp       eax,ecx
       jae       near ptr M03_L21
       movsxd    rcx,eax
       lea       rax,[rdx+rcx*4+10]
       mov       r8d,[rax]
       dec       r8d
       test      r15,r15
       jne       near ptr M03_L13
M03_L02:
       cmp       [r14+8],r8d
       ja        short M03_L07
M03_L03:
       cmp       dword ptr [rsi+40],0
       jg        near ptr M03_L10
       mov       r15d,[rsi+38]
       cmp       [r14+8],r15d
       je        near ptr M03_L09
M03_L04:
       lea       edx,[r15+1]
       mov       [rsi+38],edx
       mov       r14,[rsi+10]
M03_L05:
       cmp       r15d,[r14+8]
       jae       near ptr M03_L21
       movsxd    rdx,r15d
       lea       rdx,[rdx+rdx*2]
       lea       rcx,[r14+rdx*8+10]
       mov       [rcx+8],r12d
       mov       [rsp+28],rax
       mov       edx,[rax]
       dec       edx
       mov       [rcx+0C],edx
       mov       [rcx+10],edi
       mov       rdx,rbx
       call      qword ptr [7FFB0D970590]
       inc       r15d
       mov       rbx,[rsp+28]
       mov       [rbx],r15d
       inc       dword ptr [rsi+44]
M03_L06:
       mov       eax,1
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L07:
       movsxd    rcx,r8d
       lea       rcx,[rcx+rcx*2]
       lea       r15,[r14+rcx*8+10]
       cmp       [r15+8],r12d
       mov       [rsp+34],r8d
       je        near ptr M03_L11
M03_L08:
       mov       r8d,[r15+0C]
       inc       r13d
       cmp       [r14+8],r13d
       jb        near ptr M03_L19
       jmp       near ptr M03_L02
M03_L09:
       mov       ecx,[rsi+38]
       call      qword ptr [7FFB0D974AE0]
       mov       edx,eax
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFB0D975AF0]
       mov       rax,[rsi+8]
       mov       edx,[rax+8]
       mov       ecx,edx
       mov       r8,[rsi+30]
       mov       r9d,r12d
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       ecx,ecx
       imul      rcx,r8
       shr       rcx,20
       cmp       ecx,edx
       jae       near ptr M03_L21
       movsxd    rdx,ecx
       lea       rax,[rax+rdx*4+10]
       mov       [rsp+28],rax
       mov       rax,[rsp+28]
       jmp       near ptr M03_L04
M03_L10:
       mov       edx,[rsi+3C]
       mov       r15d,edx
       cmp       edx,[r14+8]
       jae       near ptr M03_L21
       movsxd    rdx,edx
       lea       rdx,[rdx+rdx*2]
       mov       edx,[r14+rdx*8+1C]
       neg       edx
       add       edx,0FFFFFFFD
       mov       [rsi+3C],edx
       dec       dword ptr [rsi+40]
       jmp       near ptr M03_L05
M03_L11:
       mov       [rsp+28],rax
       call      qword ptr [7FFB0D971340]
       mov       rdx,[rax]
       mov       ecx,[r15+10]
       cmp       [rdx],edx
       cmp       ecx,edi
       sete      dl
       movzx     edx,dl
       test      edx,edx
       mov       rax,[rsp+28]
       je        near ptr M03_L08
       mov       r8d,[rsp+34]
       cmp       bpl,1
       jne       short M03_L12
       movsxd    rdx,r8d
       lea       rdx,[rdx+rdx*2]
       lea       rcx,[r14+rdx*8+10]
       mov       rdx,rbx
       call      qword ptr [7FFB0D970588]
       jmp       near ptr M03_L06
M03_L12:
       cmp       bpl,2
       jne       near ptr M03_L17
       jmp       near ptr M03_L16
M03_L13:
       cmp       [r14+8],r8d
       jbe       near ptr M03_L03
       movsxd    rdx,r8d
       lea       rdx,[rdx+rdx*2]
       cmp       [r14+rdx*8+18],r12d
       jne       near ptr M03_L18
       mov       [rsp+28],rax
       mov       [rsp+34],r8d
       movsxd    rdx,r8d
       lea       rdx,[rdx+rdx*2]
       mov       edx,[r14+rdx*8+20]
       mov       rcx,r15
       mov       r8d,edi
       lea       r11,[7FFB0D96FDC0]
       call      qword ptr [7FFB0D96FDC0]
       test      al,al
       mov       rax,[rsp+28]
       je        short M03_L14
       cmp       bpl,1
       jne       short M03_L15
       mov       esi,[rsp+34]
       movsxd    rdx,esi
       lea       rdx,[rdx+rdx*2]
       lea       rcx,[r14+rdx*8+10]
       mov       rdx,rbx
       call      qword ptr [7FFB0D970588]
       jmp       near ptr M03_L06
M03_L14:
       mov       r8d,[rsp+34]
       jmp       short M03_L18
M03_L15:
       cmp       bpl,2
       jne       short M03_L17
M03_L16:
       mov       ecx,edi
       call      qword ptr [7FFB0D969248]
       int       3
M03_L17:
       xor       eax,eax
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L18:
       movsxd    r8,r8d
       lea       rdx,[r8+r8*2]
       mov       r8d,[r14+rdx*8+1C]
       inc       r13d
       cmp       [r14+8],r13d
       jae       near ptr M03_L13
M03_L19:
       call      qword ptr [7FFB0D96D150]
       int       3
M03_L20:
       mov       rcx,r15
       mov       edx,edi
       lea       r11,[7FFB0D96FDC8]
       call      qword ptr [7FFB0D96FDC8]
       mov       r12d,eax
       jmp       near ptr M03_L01
M03_L21:
       call      qword ptr [7FFB0D970578]
       int       3
; Total bytes of code 760
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.BytesToString(System.ReadOnlySpan`1<Byte>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       vzeroupper
       mov       rsi,rcx
       mov       rcx,rsi
       vmovdqu   xmm0,xmmword ptr [rsi]
       vmovdqu   xmmword ptr [rsp+20],xmm0
       lea       rdx,[rsp+20]
       mov       r8,237DAB41200
       mov       r9,[r8]
       mov       r8,r9
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotEmpty[[System.Byte, System.Private.CoreLib]](System.ReadOnlySpan`1<Byte>, System.String, System.String)
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       edx,[rsi+8]
       mov       rcx,rdi
       mov       r8d,7FFFFFFF
       call      System.Text.StringBuilder..ctor(Int32, Int32)
       xor       ebx,ebx
       cmp       dword ptr [rsi+8],0
       jle       short M04_L01
       mov       rdx,237CAB41568
       mov       rbp,[rdx]
       mov       rdx,237CAB53440
       mov       r14,[rdx]
M04_L00:
       cmp       ebx,[rsi+8]
       jae       short M04_L03
       movsxd    rdx,ebx
       add       rdx,[rsi]
       mov       r8,rbp
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r14
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|42_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       add       ebx,1
       jo        short M04_L02
       cmp       ebx,[rsi+8]
       jl        short M04_L00
M04_L01:
       mov       rcx,rdi
       call      qword ptr [7FFAAF3D78C0]
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M04_L02:
       call      CORINFO_HELP_OVERFLOW
       int       3
M04_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 203
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowKeyNotFoundException[[System.Int32, System.Private.CoreLib]](Int32)

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.BytesToString02()
; 			var readOnlySpan = new ReadOnlySpan<byte>(base.GetByteArray(1));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = readOnlySpan.BytesToString();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,38
       vzeroupper
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rax
       mov       rsi,rcx
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       mov       edx,1
       call      System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       test      rax,rax
       jne       short M00_L00
       mov       rdi,[rsi+8]
       vmovsd    xmm0,qword ptr [7FFAAF3DB3F0]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       mov       r8,rax
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,1
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(Int32, System.__Canon, System.Collections.Generic.InsertionBehavior)
M00_L00:
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       mov       edx,1
       call      System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       test      rax,rax
       je        short M00_L03
       mov       rcx,[rax]
       test      rcx,rcx
       je        short M00_L02
       lea       rax,[rcx+10]
       mov       ecx,[rcx+8]
M00_L01:
       mov       [rsp+28],rax
       mov       [rsp+30],ecx
       lea       rcx,[rsp+28]
       call      DotNetTips.Spargine.Extensions.ArrayExtensions.BytesToString(System.ReadOnlySpan`1<Byte>)
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,38
       pop       rsi
       pop       rdi
       ret
M00_L02:
       xor       eax,eax
       xor       ecx,ecx
       jmp       short M00_L01
M00_L03:
       mov       ecx,1
       call      System.ThrowHelper.ThrowKeyNotFoundException[[System.Int32, System.Private.CoreLib]](Int32)
       int       3
; Total bytes of code 184
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       edi,edx
       mov       rax,[rsi]
       mov       rax,[rax+30]
       mov       rbx,[rax]
       cmp       qword ptr [rsi+8],0
       jne       short M01_L01
M01_L00:
       cmp       qword ptr [rbx+28],0
       je        near ptr M01_L05
       jmp       near ptr M01_L05
M01_L01:
       mov       rbp,[rsi+18]
       test      rbp,rbp
       jne       near ptr M01_L06
       mov       eax,edi
       mov       rcx,[rsi+8]
       mov       edx,[rcx+8]
       mov       r11d,edx
       mov       r8,[rsi+30]
       mov       r9d,eax
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       r11d,r11d
       imul      r11,r8
       shr       r11,20
       cmp       r11d,edx
       jae       near ptr M01_L11
       movsxd    rdx,r11d
       lea       rcx,[rcx+rdx*4+10]
       mov       ecx,[rcx]
       mov       rdx,[rsi+10]
       xor       r11d,r11d
       dec       ecx
       mov       r8d,[rdx+8]
M01_L02:
       cmp       r8d,ecx
       jbe       short M01_L00
       movsxd    rcx,ecx
       lea       rcx,[rcx+rcx*2]
       lea       r14,[rdx+rcx*8+10]
       cmp       [r14+8],edi
       jne       short M01_L03
       mov       ecx,[r14+10]
       cmp       ecx,eax
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       short M01_L04
M01_L03:
       mov       ecx,[r14+0C]
       inc       r11d
       cmp       r8d,r11d
       jb        near ptr M01_L09
       jmp       short M01_L02
M01_L04:
       mov       rax,r14
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L05:
       xor       r14d,r14d
       jmp       short M01_L04
M01_L06:
       mov       rcx,rbp
       mov       edx,edi
       mov       r11,7FFAAEE20670
       call      qword ptr [7FFAAF3E0670]
       mov       r14d,eax
       mov       rdx,[rsi+8]
       mov       ecx,[rdx+8]
       mov       r8,[rsi+30]
       mov       r11d,r14d
       imul      r8,r11
       shr       r8,20
       inc       r8
       mov       ecx,ecx
       imul      rcx,r8
       shr       rcx,20
       cmp       ecx,[rdx+8]
       jae       short M01_L11
       movsxd    rcx,ecx
       lea       rdx,[rdx+rcx*4+10]
       mov       r15d,[rdx]
       mov       r12,[rsi+10]
       xor       r13d,r13d
       dec       r15d
M01_L07:
       cmp       [r12+8],r15d
       jbe       near ptr M01_L00
       movsxd    rdx,r15d
       lea       rdx,[rdx+rdx*2]
       lea       rdx,[r12+rdx*8+10]
       mov       r15,rdx
       cmp       [r15+8],r14d
       jne       short M01_L08
       mov       edx,[r15+10]
       mov       rcx,rbp
       mov       r8d,edi
       mov       r11,7FFAAEE20678
       call      qword ptr [7FFAAF3E0678]
       test      eax,eax
       jne       short M01_L10
M01_L08:
       mov       r15d,[r15+0C]
       inc       r13d
       cmp       [r12+8],r13d
       jae       short M01_L07
M01_L09:
       call      System.ThrowHelper.ThrowInvalidOperationException_ConcurrentOperationsNotSupported()
       int       3
M01_L10:
       mov       r14,r15
       jmp       near ptr M01_L04
M01_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 408
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       push      rbp
       sub       rsp,0A0
       vzeroupper
       lea       rbp,[rsp+0A0]
       xor       eax,eax
       mov       [rbp+0FF98],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFA0
M02_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M02_L00
       mov       [rbp+0FF88],rsp
       vmovsd    qword ptr [rbp+10],xmm0
       call      System.Globalization.CultureInfo.get_InvariantCulture()
       mov       [rbp+0FFD8],rax
       mov       rcx,offset MT_System.Double
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp+0FFD0],rax
       call      DotNetTips.Spargine.Tester.Properties.Resources.get_SizeMustBeEpsilon()
       mov       [rbp+0FFC8],rax
       mov       r8,[rbp+0FFD0]
       mov       qword ptr [r8+8],1
       mov       r8,[rbp+0FFD0]
       mov       rcx,[rbp+0FFD8]
       mov       rdx,[rbp+0FFC8]
       call      System.String.Format(System.IFormatProvider, System.String, System.Object)
       mov       [rbp+0FFC0],rax
       mov       r9,2199483D938
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,[rbp+0FFC0]
       vmovsd    xmm2,qword ptr [rbp+10]
       vucomisd  xmm2,qword ptr [7FFAAF1E8A38]
       setae     dl
       movzx     edx,dl
       vxorps    xmm2,xmm2,xmm2
       vmovsd    xmm0,qword ptr [rbp+10]
       call      DotNetTips.Spargine.Core.Validator.ArgumentMeetsCondition[[System.Double, System.Private.CoreLib]](Double, Boolean, Double, System.String, System.String)
       vmovsd    qword ptr [rbp+10],xmm0
       vmovsd    xmm0,qword ptr [rbp+10]
       vmulsd    xmm0,xmm0,qword ptr [7FFAAF1E8A40]
       call      System.Convert.ToInt32(Double)
       movsxd    rdx,eax
       mov       [rbp+0FFB8],rdx
       mov       rdx,[rbp+0FFB8]
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp+0FFB0],rax
       mov       rdx,[rbp+0FFB0]
       lea       rcx,[rbp+0FFF0]
       call      System.Span`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte[])
       mov       rdx,21994837448
       mov       rdx,[rdx]
       mov       [rbp+0FFE8],rdx
       xor       edx,edx
       mov       [rbp+0FFE0],edx
       lea       rdx,[rbp+0FFE0]
       mov       rcx,[rbp+0FFE8]
       call      System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,21994837450
       mov       rcx,[rcx]
       mov       [rbp+0FF98],rcx
       vmovdqu   xmm0,xmmword ptr [rbp+0FFF0]
       vmovdqu   xmmword ptr [rbp+0FFA0],xmm0
       mov       rcx,[rbp+0FF98]
       lea       rdx,[rbp+0FFA0]
       mov       rax,[rbp+0FF98]
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       jmp       short M02_L01
M02_L01:
       mov       rcx,rsp
       call      M02_L02
       nop
       lea       rcx,[rbp+0FFF0]
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].ToArray()
       nop
       add       rsp,0A0
       pop       rbp
       ret
M02_L02:
       push      rbp
       sub       rsp,30
       vzeroupper
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+0A0]
       mov       ecx,[rbp+0FFE0]
       movzx     ecx,cl
       test      ecx,ecx
       je        short M02_L03
       mov       rcx,[rbp+0FFE8]
       call      System.Threading.Monitor.Exit(System.Object)
M02_L03:
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 425
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(Int32, System.__Canon, System.Collections.Generic.InsertionBehavior)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rsi,rcx
       mov       edi,edx
       mov       rbx,r8
       mov       ebp,r9d
       cmp       qword ptr [rsi+8],0
       jne       short M03_L00
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFB0D975AE0]
M03_L00:
       mov       r14,[rsi+10]
       mov       r15,[rsi+18]
       test      r15,r15
       jne       near ptr M03_L20
       mov       r12d,edi
M03_L01:
       xor       r13d,r13d
       mov       rdx,[rsi+8]
       mov       ecx,[rdx+8]
       mov       eax,ecx
       mov       r8,[rsi+30]
       mov       r9d,r12d
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       eax,eax
       imul      rax,r8
       shr       rax,20
       cmp       eax,ecx
       jae       near ptr M03_L21
       movsxd    rcx,eax
       lea       rax,[rdx+rcx*4+10]
       mov       r8d,[rax]
       dec       r8d
       test      r15,r15
       jne       near ptr M03_L13
M03_L02:
       cmp       [r14+8],r8d
       ja        short M03_L07
M03_L03:
       cmp       dword ptr [rsi+40],0
       jg        near ptr M03_L10
       mov       r15d,[rsi+38]
       cmp       [r14+8],r15d
       je        near ptr M03_L09
M03_L04:
       lea       edx,[r15+1]
       mov       [rsi+38],edx
       mov       r14,[rsi+10]
M03_L05:
       cmp       r15d,[r14+8]
       jae       near ptr M03_L21
       movsxd    rdx,r15d
       lea       rdx,[rdx+rdx*2]
       lea       rcx,[r14+rdx*8+10]
       mov       [rcx+8],r12d
       mov       [rsp+28],rax
       mov       edx,[rax]
       dec       edx
       mov       [rcx+0C],edx
       mov       [rcx+10],edi
       mov       rdx,rbx
       call      qword ptr [7FFB0D970590]
       inc       r15d
       mov       rbx,[rsp+28]
       mov       [rbx],r15d
       inc       dword ptr [rsi+44]
M03_L06:
       mov       eax,1
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L07:
       movsxd    rcx,r8d
       lea       rcx,[rcx+rcx*2]
       lea       r15,[r14+rcx*8+10]
       cmp       [r15+8],r12d
       mov       [rsp+34],r8d
       je        near ptr M03_L11
M03_L08:
       mov       r8d,[r15+0C]
       inc       r13d
       cmp       [r14+8],r13d
       jb        near ptr M03_L19
       jmp       near ptr M03_L02
M03_L09:
       mov       ecx,[rsi+38]
       call      qword ptr [7FFB0D974AE0]
       mov       edx,eax
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFB0D975AF0]
       mov       rax,[rsi+8]
       mov       edx,[rax+8]
       mov       ecx,edx
       mov       r8,[rsi+30]
       mov       r9d,r12d
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       ecx,ecx
       imul      rcx,r8
       shr       rcx,20
       cmp       ecx,edx
       jae       near ptr M03_L21
       movsxd    rdx,ecx
       lea       rax,[rax+rdx*4+10]
       mov       [rsp+28],rax
       mov       rax,[rsp+28]
       jmp       near ptr M03_L04
M03_L10:
       mov       edx,[rsi+3C]
       mov       r15d,edx
       cmp       edx,[r14+8]
       jae       near ptr M03_L21
       movsxd    rdx,edx
       lea       rdx,[rdx+rdx*2]
       mov       edx,[r14+rdx*8+1C]
       neg       edx
       add       edx,0FFFFFFFD
       mov       [rsi+3C],edx
       dec       dword ptr [rsi+40]
       jmp       near ptr M03_L05
M03_L11:
       mov       [rsp+28],rax
       call      qword ptr [7FFB0D971340]
       mov       rdx,[rax]
       mov       ecx,[r15+10]
       cmp       [rdx],edx
       cmp       ecx,edi
       sete      dl
       movzx     edx,dl
       test      edx,edx
       mov       rax,[rsp+28]
       je        near ptr M03_L08
       mov       r8d,[rsp+34]
       cmp       bpl,1
       jne       short M03_L12
       movsxd    rdx,r8d
       lea       rdx,[rdx+rdx*2]
       lea       rcx,[r14+rdx*8+10]
       mov       rdx,rbx
       call      qword ptr [7FFB0D970588]
       jmp       near ptr M03_L06
M03_L12:
       cmp       bpl,2
       jne       near ptr M03_L17
       jmp       near ptr M03_L16
M03_L13:
       cmp       [r14+8],r8d
       jbe       near ptr M03_L03
       movsxd    rdx,r8d
       lea       rdx,[rdx+rdx*2]
       cmp       [r14+rdx*8+18],r12d
       jne       near ptr M03_L18
       mov       [rsp+28],rax
       mov       [rsp+34],r8d
       movsxd    rdx,r8d
       lea       rdx,[rdx+rdx*2]
       mov       edx,[r14+rdx*8+20]
       mov       rcx,r15
       mov       r8d,edi
       lea       r11,[7FFB0D96FDC0]
       call      qword ptr [7FFB0D96FDC0]
       test      al,al
       mov       rax,[rsp+28]
       je        short M03_L14
       cmp       bpl,1
       jne       short M03_L15
       mov       esi,[rsp+34]
       movsxd    rdx,esi
       lea       rdx,[rdx+rdx*2]
       lea       rcx,[r14+rdx*8+10]
       mov       rdx,rbx
       call      qword ptr [7FFB0D970588]
       jmp       near ptr M03_L06
M03_L14:
       mov       r8d,[rsp+34]
       jmp       short M03_L18
M03_L15:
       cmp       bpl,2
       jne       short M03_L17
M03_L16:
       mov       ecx,edi
       call      qword ptr [7FFB0D969248]
       int       3
M03_L17:
       xor       eax,eax
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L18:
       movsxd    r8,r8d
       lea       rdx,[r8+r8*2]
       mov       r8d,[r14+rdx*8+1C]
       inc       r13d
       cmp       [r14+8],r13d
       jae       near ptr M03_L13
M03_L19:
       call      qword ptr [7FFB0D96D150]
       int       3
M03_L20:
       mov       rcx,r15
       mov       edx,edi
       lea       r11,[7FFB0D96FDC8]
       call      qword ptr [7FFB0D96FDC8]
       mov       r12d,eax
       jmp       near ptr M03_L01
M03_L21:
       call      qword ptr [7FFB0D970578]
       int       3
; Total bytes of code 760
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.BytesToString(System.ReadOnlySpan`1<Byte>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       vzeroupper
       mov       rsi,rcx
       mov       rcx,rsi
       vmovdqu   xmm0,xmmword ptr [rsi]
       vmovdqu   xmmword ptr [rsp+20],xmm0
       lea       rdx,[rsp+20]
       mov       r8,219848331F8
       mov       r9,[r8]
       mov       r8,r9
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotEmpty[[System.Byte, System.Private.CoreLib]](System.ReadOnlySpan`1<Byte>, System.String, System.String)
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       edx,[rsi+8]
       mov       rcx,rdi
       mov       r8d,7FFFFFFF
       call      System.Text.StringBuilder..ctor(Int32, Int32)
       xor       ebx,ebx
       cmp       dword ptr [rsi+8],0
       jle       short M04_L01
       mov       rdx,21964831568
       mov       rbp,[rdx]
       mov       rdx,2199483E020
       mov       r14,[rdx]
M04_L00:
       cmp       ebx,[rsi+8]
       jae       short M04_L03
       movsxd    rdx,ebx
       add       rdx,[rsi]
       mov       r8,rbp
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r14
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|42_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       add       ebx,1
       jo        short M04_L02
       cmp       ebx,[rsi+8]
       jl        short M04_L00
M04_L01:
       mov       rcx,rdi
       call      qword ptr [7FFAAF3D78C0]
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M04_L02:
       call      CORINFO_HELP_OVERFLOW
       int       3
M04_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 203
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowKeyNotFoundException[[System.Int32, System.Private.CoreLib]](Int32)

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.BytesToString02()
; 			var readOnlySpan = new ReadOnlySpan<byte>(base.GetByteArray(1));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = readOnlySpan.BytesToString();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,38
       vzeroupper
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rax
       mov       rsi,rcx
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       mov       edx,1
       call      System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       test      rax,rax
       jne       short M00_L00
       mov       rdi,[rsi+8]
       vmovsd    xmm0,qword ptr [7FFAAF3DB3F0]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       mov       r8,rax
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,1
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(Int32, System.__Canon, System.Collections.Generic.InsertionBehavior)
M00_L00:
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       mov       edx,1
       call      System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       test      rax,rax
       je        short M00_L03
       mov       rcx,[rax]
       test      rcx,rcx
       je        short M00_L02
       lea       rax,[rcx+10]
       mov       ecx,[rcx+8]
M00_L01:
       mov       [rsp+28],rax
       mov       [rsp+30],ecx
       lea       rcx,[rsp+28]
       call      DotNetTips.Spargine.Extensions.ArrayExtensions.BytesToString(System.ReadOnlySpan`1<Byte>)
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,38
       pop       rsi
       pop       rdi
       ret
M00_L02:
       xor       eax,eax
       xor       ecx,ecx
       jmp       short M00_L01
M00_L03:
       mov       ecx,1
       call      System.ThrowHelper.ThrowKeyNotFoundException[[System.Int32, System.Private.CoreLib]](Int32)
       int       3
; Total bytes of code 184
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       edi,edx
       mov       rax,[rsi]
       mov       rax,[rax+30]
       mov       rbx,[rax]
       cmp       qword ptr [rsi+8],0
       jne       short M01_L01
M01_L00:
       cmp       qword ptr [rbx+28],0
       je        near ptr M01_L05
       jmp       near ptr M01_L05
M01_L01:
       mov       rbp,[rsi+18]
       test      rbp,rbp
       jne       near ptr M01_L06
       mov       eax,edi
       mov       rcx,[rsi+8]
       mov       edx,[rcx+8]
       mov       r11d,edx
       mov       r8,[rsi+30]
       mov       r9d,eax
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       r11d,r11d
       imul      r11,r8
       shr       r11,20
       cmp       r11d,edx
       jae       near ptr M01_L11
       movsxd    rdx,r11d
       lea       rcx,[rcx+rdx*4+10]
       mov       ecx,[rcx]
       mov       rdx,[rsi+10]
       xor       r11d,r11d
       dec       ecx
       mov       r8d,[rdx+8]
M01_L02:
       cmp       r8d,ecx
       jbe       short M01_L00
       movsxd    rcx,ecx
       lea       rcx,[rcx+rcx*2]
       lea       r14,[rdx+rcx*8+10]
       cmp       [r14+8],edi
       jne       short M01_L03
       mov       ecx,[r14+10]
       cmp       ecx,eax
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       short M01_L04
M01_L03:
       mov       ecx,[r14+0C]
       inc       r11d
       cmp       r8d,r11d
       jb        near ptr M01_L09
       jmp       short M01_L02
M01_L04:
       mov       rax,r14
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L05:
       xor       r14d,r14d
       jmp       short M01_L04
M01_L06:
       mov       rcx,rbp
       mov       edx,edi
       mov       r11,7FFAAEE20670
       call      qword ptr [7FFAAF3E0670]
       mov       r14d,eax
       mov       rdx,[rsi+8]
       mov       ecx,[rdx+8]
       mov       r8,[rsi+30]
       mov       r11d,r14d
       imul      r8,r11
       shr       r8,20
       inc       r8
       mov       ecx,ecx
       imul      rcx,r8
       shr       rcx,20
       cmp       ecx,[rdx+8]
       jae       short M01_L11
       movsxd    rcx,ecx
       lea       rdx,[rdx+rcx*4+10]
       mov       r15d,[rdx]
       mov       r12,[rsi+10]
       xor       r13d,r13d
       dec       r15d
M01_L07:
       cmp       [r12+8],r15d
       jbe       near ptr M01_L00
       movsxd    rdx,r15d
       lea       rdx,[rdx+rdx*2]
       lea       rdx,[r12+rdx*8+10]
       mov       r15,rdx
       cmp       [r15+8],r14d
       jne       short M01_L08
       mov       edx,[r15+10]
       mov       rcx,rbp
       mov       r8d,edi
       mov       r11,7FFAAEE20678
       call      qword ptr [7FFAAF3E0678]
       test      eax,eax
       jne       short M01_L10
M01_L08:
       mov       r15d,[r15+0C]
       inc       r13d
       cmp       [r12+8],r13d
       jae       short M01_L07
M01_L09:
       call      System.ThrowHelper.ThrowInvalidOperationException_ConcurrentOperationsNotSupported()
       int       3
M01_L10:
       mov       r14,r15
       jmp       near ptr M01_L04
M01_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 408
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       push      rbp
       sub       rsp,0A0
       vzeroupper
       lea       rbp,[rsp+0A0]
       xor       eax,eax
       mov       [rbp+0FF98],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFA0
M02_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M02_L00
       mov       [rbp+0FF88],rsp
       vmovsd    qword ptr [rbp+10],xmm0
       call      System.Globalization.CultureInfo.get_InvariantCulture()
       mov       [rbp+0FFD8],rax
       mov       rcx,offset MT_System.Double
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp+0FFD0],rax
       call      DotNetTips.Spargine.Tester.Properties.Resources.get_SizeMustBeEpsilon()
       mov       [rbp+0FFC8],rax
       mov       r8,[rbp+0FFD0]
       mov       qword ptr [r8+8],1
       mov       r8,[rbp+0FFD0]
       mov       rcx,[rbp+0FFD8]
       mov       rdx,[rbp+0FFC8]
       call      System.String.Format(System.IFormatProvider, System.String, System.Object)
       mov       [rbp+0FFC0],rax
       mov       r9,2C5DAB6D938
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,[rbp+0FFC0]
       vmovsd    xmm2,qword ptr [rbp+10]
       vucomisd  xmm2,qword ptr [7FFAAF1E8A38]
       setae     dl
       movzx     edx,dl
       vxorps    xmm2,xmm2,xmm2
       vmovsd    xmm0,qword ptr [rbp+10]
       call      DotNetTips.Spargine.Core.Validator.ArgumentMeetsCondition[[System.Double, System.Private.CoreLib]](Double, Boolean, Double, System.String, System.String)
       vmovsd    qword ptr [rbp+10],xmm0
       vmovsd    xmm0,qword ptr [rbp+10]
       vmulsd    xmm0,xmm0,qword ptr [7FFAAF1E8A40]
       call      System.Convert.ToInt32(Double)
       movsxd    rdx,eax
       mov       [rbp+0FFB8],rdx
       mov       rdx,[rbp+0FFB8]
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp+0FFB0],rax
       mov       rdx,[rbp+0FFB0]
       lea       rcx,[rbp+0FFF0]
       call      System.Span`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte[])
       mov       rdx,2C5DAB67448
       mov       rdx,[rdx]
       mov       [rbp+0FFE8],rdx
       xor       edx,edx
       mov       [rbp+0FFE0],edx
       lea       rdx,[rbp+0FFE0]
       mov       rcx,[rbp+0FFE8]
       call      System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,2C5DAB67450
       mov       rcx,[rcx]
       mov       [rbp+0FF98],rcx
       vmovdqu   xmm0,xmmword ptr [rbp+0FFF0]
       vmovdqu   xmmword ptr [rbp+0FFA0],xmm0
       mov       rcx,[rbp+0FF98]
       lea       rdx,[rbp+0FFA0]
       mov       rax,[rbp+0FF98]
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       jmp       short M02_L01
M02_L01:
       mov       rcx,rsp
       call      M02_L02
       nop
       lea       rcx,[rbp+0FFF0]
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].ToArray()
       nop
       add       rsp,0A0
       pop       rbp
       ret
M02_L02:
       push      rbp
       sub       rsp,30
       vzeroupper
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+0A0]
       mov       ecx,[rbp+0FFE0]
       movzx     ecx,cl
       test      ecx,ecx
       je        short M02_L03
       mov       rcx,[rbp+0FFE8]
       call      System.Threading.Monitor.Exit(System.Object)
M02_L03:
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 425
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(Int32, System.__Canon, System.Collections.Generic.InsertionBehavior)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rsi,rcx
       mov       edi,edx
       mov       rbx,r8
       mov       ebp,r9d
       cmp       qword ptr [rsi+8],0
       jne       short M03_L00
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFB0D975AE0]
M03_L00:
       mov       r14,[rsi+10]
       mov       r15,[rsi+18]
       test      r15,r15
       jne       near ptr M03_L20
       mov       r12d,edi
M03_L01:
       xor       r13d,r13d
       mov       rdx,[rsi+8]
       mov       ecx,[rdx+8]
       mov       eax,ecx
       mov       r8,[rsi+30]
       mov       r9d,r12d
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       eax,eax
       imul      rax,r8
       shr       rax,20
       cmp       eax,ecx
       jae       near ptr M03_L21
       movsxd    rcx,eax
       lea       rax,[rdx+rcx*4+10]
       mov       r8d,[rax]
       dec       r8d
       test      r15,r15
       jne       near ptr M03_L13
M03_L02:
       cmp       [r14+8],r8d
       ja        short M03_L07
M03_L03:
       cmp       dword ptr [rsi+40],0
       jg        near ptr M03_L10
       mov       r15d,[rsi+38]
       cmp       [r14+8],r15d
       je        near ptr M03_L09
M03_L04:
       lea       edx,[r15+1]
       mov       [rsi+38],edx
       mov       r14,[rsi+10]
M03_L05:
       cmp       r15d,[r14+8]
       jae       near ptr M03_L21
       movsxd    rdx,r15d
       lea       rdx,[rdx+rdx*2]
       lea       rcx,[r14+rdx*8+10]
       mov       [rcx+8],r12d
       mov       [rsp+28],rax
       mov       edx,[rax]
       dec       edx
       mov       [rcx+0C],edx
       mov       [rcx+10],edi
       mov       rdx,rbx
       call      qword ptr [7FFB0D970590]
       inc       r15d
       mov       rbx,[rsp+28]
       mov       [rbx],r15d
       inc       dword ptr [rsi+44]
M03_L06:
       mov       eax,1
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L07:
       movsxd    rcx,r8d
       lea       rcx,[rcx+rcx*2]
       lea       r15,[r14+rcx*8+10]
       cmp       [r15+8],r12d
       mov       [rsp+34],r8d
       je        near ptr M03_L11
M03_L08:
       mov       r8d,[r15+0C]
       inc       r13d
       cmp       [r14+8],r13d
       jb        near ptr M03_L19
       jmp       near ptr M03_L02
M03_L09:
       mov       ecx,[rsi+38]
       call      qword ptr [7FFB0D974AE0]
       mov       edx,eax
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFB0D975AF0]
       mov       rax,[rsi+8]
       mov       edx,[rax+8]
       mov       ecx,edx
       mov       r8,[rsi+30]
       mov       r9d,r12d
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       ecx,ecx
       imul      rcx,r8
       shr       rcx,20
       cmp       ecx,edx
       jae       near ptr M03_L21
       movsxd    rdx,ecx
       lea       rax,[rax+rdx*4+10]
       mov       [rsp+28],rax
       mov       rax,[rsp+28]
       jmp       near ptr M03_L04
M03_L10:
       mov       edx,[rsi+3C]
       mov       r15d,edx
       cmp       edx,[r14+8]
       jae       near ptr M03_L21
       movsxd    rdx,edx
       lea       rdx,[rdx+rdx*2]
       mov       edx,[r14+rdx*8+1C]
       neg       edx
       add       edx,0FFFFFFFD
       mov       [rsi+3C],edx
       dec       dword ptr [rsi+40]
       jmp       near ptr M03_L05
M03_L11:
       mov       [rsp+28],rax
       call      qword ptr [7FFB0D971340]
       mov       rdx,[rax]
       mov       ecx,[r15+10]
       cmp       [rdx],edx
       cmp       ecx,edi
       sete      dl
       movzx     edx,dl
       test      edx,edx
       mov       rax,[rsp+28]
       je        near ptr M03_L08
       mov       r8d,[rsp+34]
       cmp       bpl,1
       jne       short M03_L12
       movsxd    rdx,r8d
       lea       rdx,[rdx+rdx*2]
       lea       rcx,[r14+rdx*8+10]
       mov       rdx,rbx
       call      qword ptr [7FFB0D970588]
       jmp       near ptr M03_L06
M03_L12:
       cmp       bpl,2
       jne       near ptr M03_L17
       jmp       near ptr M03_L16
M03_L13:
       cmp       [r14+8],r8d
       jbe       near ptr M03_L03
       movsxd    rdx,r8d
       lea       rdx,[rdx+rdx*2]
       cmp       [r14+rdx*8+18],r12d
       jne       near ptr M03_L18
       mov       [rsp+28],rax
       mov       [rsp+34],r8d
       movsxd    rdx,r8d
       lea       rdx,[rdx+rdx*2]
       mov       edx,[r14+rdx*8+20]
       mov       rcx,r15
       mov       r8d,edi
       lea       r11,[7FFB0D96FDC0]
       call      qword ptr [7FFB0D96FDC0]
       test      al,al
       mov       rax,[rsp+28]
       je        short M03_L14
       cmp       bpl,1
       jne       short M03_L15
       mov       esi,[rsp+34]
       movsxd    rdx,esi
       lea       rdx,[rdx+rdx*2]
       lea       rcx,[r14+rdx*8+10]
       mov       rdx,rbx
       call      qword ptr [7FFB0D970588]
       jmp       near ptr M03_L06
M03_L14:
       mov       r8d,[rsp+34]
       jmp       short M03_L18
M03_L15:
       cmp       bpl,2
       jne       short M03_L17
M03_L16:
       mov       ecx,edi
       call      qword ptr [7FFB0D969248]
       int       3
M03_L17:
       xor       eax,eax
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L18:
       movsxd    r8,r8d
       lea       rdx,[r8+r8*2]
       mov       r8d,[r14+rdx*8+1C]
       inc       r13d
       cmp       [r14+8],r13d
       jae       near ptr M03_L13
M03_L19:
       call      qword ptr [7FFB0D96D150]
       int       3
M03_L20:
       mov       rcx,r15
       mov       edx,edi
       lea       r11,[7FFB0D96FDC8]
       call      qword ptr [7FFB0D96FDC8]
       mov       r12d,eax
       jmp       near ptr M03_L01
M03_L21:
       call      qword ptr [7FFB0D970578]
       int       3
; Total bytes of code 760
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.BytesToString(System.ReadOnlySpan`1<Byte>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       vzeroupper
       mov       rsi,rcx
       mov       rcx,rsi
       vmovdqu   xmm0,xmmword ptr [rsi]
       vmovdqu   xmmword ptr [rsp+20],xmm0
       lea       rdx,[rsp+20]
       mov       r8,2C5BAB65608
       mov       r9,[r8]
       mov       r8,r9
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotEmpty[[System.Byte, System.Private.CoreLib]](System.ReadOnlySpan`1<Byte>, System.String, System.String)
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       edx,[rsi+8]
       mov       rcx,rdi
       mov       r8d,7FFFFFFF
       call      System.Text.StringBuilder..ctor(Int32, Int32)
       xor       ebx,ebx
       cmp       dword ptr [rsi+8],0
       jle       short M04_L01
       mov       rdx,2C5BAB61568
       mov       rbp,[rdx]
       mov       rdx,2C5DAB6E020
       mov       r14,[rdx]
M04_L00:
       cmp       ebx,[rsi+8]
       jae       short M04_L03
       movsxd    rdx,ebx
       add       rdx,[rsi]
       mov       r8,rbp
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r14
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|42_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       add       ebx,1
       jo        short M04_L02
       cmp       ebx,[rsi+8]
       jl        short M04_L00
M04_L01:
       mov       rcx,rdi
       call      qword ptr [7FFAAF3D78C0]
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M04_L02:
       call      CORINFO_HELP_OVERFLOW
       int       3
M04_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 203
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowKeyNotFoundException[[System.Int32, System.Private.CoreLib]](Int32)

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.BytesToString02()
; 			var readOnlySpan = new ReadOnlySpan<byte>(base.GetByteArray(1));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = readOnlySpan.BytesToString();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,38
       vzeroupper
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rax
       mov       rsi,rcx
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       mov       edx,1
       call      System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       test      rax,rax
       jne       short M00_L00
       mov       rdi,[rsi+8]
       vmovsd    xmm0,qword ptr [7FFAAF3BB2D0]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       mov       r8,rax
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,1
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(Int32, System.__Canon, System.Collections.Generic.InsertionBehavior)
M00_L00:
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       mov       edx,1
       call      System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       test      rax,rax
       je        short M00_L03
       mov       rcx,[rax]
       test      rcx,rcx
       je        short M00_L02
       lea       rax,[rcx+10]
       mov       ecx,[rcx+8]
M00_L01:
       mov       [rsp+28],rax
       mov       [rsp+30],ecx
       lea       rcx,[rsp+28]
       call      DotNetTips.Spargine.Extensions.ArrayExtensions.BytesToString(System.ReadOnlySpan`1<Byte>)
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,38
       pop       rsi
       pop       rdi
       ret
M00_L02:
       xor       eax,eax
       xor       ecx,ecx
       jmp       short M00_L01
M00_L03:
       mov       ecx,1
       call      System.ThrowHelper.ThrowKeyNotFoundException[[System.Int32, System.Private.CoreLib]](Int32)
       int       3
; Total bytes of code 184
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       edi,edx
       mov       rax,[rsi]
       mov       rax,[rax+30]
       mov       rbx,[rax]
       cmp       qword ptr [rsi+8],0
       jne       short M01_L01
M01_L00:
       cmp       qword ptr [rbx+28],0
       je        near ptr M01_L05
       jmp       near ptr M01_L05
M01_L01:
       mov       rbp,[rsi+18]
       test      rbp,rbp
       jne       near ptr M01_L06
       mov       eax,edi
       mov       rcx,[rsi+8]
       mov       edx,[rcx+8]
       mov       r11d,edx
       mov       r8,[rsi+30]
       mov       r9d,eax
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       r11d,r11d
       imul      r11,r8
       shr       r11,20
       cmp       r11d,edx
       jae       near ptr M01_L11
       movsxd    rdx,r11d
       lea       rcx,[rcx+rdx*4+10]
       mov       ecx,[rcx]
       mov       rdx,[rsi+10]
       xor       r11d,r11d
       dec       ecx
       mov       r8d,[rdx+8]
M01_L02:
       cmp       r8d,ecx
       jbe       short M01_L00
       movsxd    rcx,ecx
       lea       rcx,[rcx+rcx*2]
       lea       r14,[rdx+rcx*8+10]
       cmp       [r14+8],edi
       jne       short M01_L03
       mov       ecx,[r14+10]
       cmp       ecx,eax
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       short M01_L04
M01_L03:
       mov       ecx,[r14+0C]
       inc       r11d
       cmp       r8d,r11d
       jb        near ptr M01_L09
       jmp       short M01_L02
M01_L04:
       mov       rax,r14
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L05:
       xor       r14d,r14d
       jmp       short M01_L04
M01_L06:
       mov       rcx,rbp
       mov       edx,edi
       mov       r11,7FFAAEE00670
       call      qword ptr [7FFAAF3C0670]
       mov       r14d,eax
       mov       rdx,[rsi+8]
       mov       ecx,[rdx+8]
       mov       r8,[rsi+30]
       mov       r11d,r14d
       imul      r8,r11
       shr       r8,20
       inc       r8
       mov       ecx,ecx
       imul      rcx,r8
       shr       rcx,20
       cmp       ecx,[rdx+8]
       jae       short M01_L11
       movsxd    rcx,ecx
       lea       rdx,[rdx+rcx*4+10]
       mov       r15d,[rdx]
       mov       r12,[rsi+10]
       xor       r13d,r13d
       dec       r15d
M01_L07:
       cmp       [r12+8],r15d
       jbe       near ptr M01_L00
       movsxd    rdx,r15d
       lea       rdx,[rdx+rdx*2]
       lea       rdx,[r12+rdx*8+10]
       mov       r15,rdx
       cmp       [r15+8],r14d
       jne       short M01_L08
       mov       edx,[r15+10]
       mov       rcx,rbp
       mov       r8d,edi
       mov       r11,7FFAAEE00678
       call      qword ptr [7FFAAF3C0678]
       test      eax,eax
       jne       short M01_L10
M01_L08:
       mov       r15d,[r15+0C]
       inc       r13d
       cmp       [r12+8],r13d
       jae       short M01_L07
M01_L09:
       call      System.ThrowHelper.ThrowInvalidOperationException_ConcurrentOperationsNotSupported()
       int       3
M01_L10:
       mov       r14,r15
       jmp       near ptr M01_L04
M01_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 408
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       push      rbp
       sub       rsp,0A0
       vzeroupper
       lea       rbp,[rsp+0A0]
       xor       eax,eax
       mov       [rbp+0FF98],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFA0
M02_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M02_L00
       mov       [rbp+0FF88],rsp
       vmovsd    qword ptr [rbp+10],xmm0
       call      System.Globalization.CultureInfo.get_InvariantCulture()
       mov       [rbp+0FFD8],rax
       mov       rcx,offset MT_System.Double
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp+0FFD0],rax
       call      DotNetTips.Spargine.Tester.Properties.Resources.get_SizeMustBeEpsilon()
       mov       [rbp+0FFC8],rax
       mov       r8,[rbp+0FFD0]
       mov       qword ptr [r8+8],1
       mov       r8,[rbp+0FFD0]
       mov       rcx,[rbp+0FFD8]
       mov       rdx,[rbp+0FFC8]
       call      System.String.Format(System.IFormatProvider, System.String, System.Object)
       mov       [rbp+0FFC0],rax
       mov       r9,203DE7E1D20
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,[rbp+0FFC0]
       vmovsd    xmm2,qword ptr [rbp+10]
       vucomisd  xmm2,qword ptr [7FFAAF1C8A38]
       setae     dl
       movzx     edx,dl
       vxorps    xmm2,xmm2,xmm2
       vmovsd    xmm0,qword ptr [rbp+10]
       call      DotNetTips.Spargine.Core.Validator.ArgumentMeetsCondition[[System.Double, System.Private.CoreLib]](Double, Boolean, Double, System.String, System.String)
       vmovsd    qword ptr [rbp+10],xmm0
       vmovsd    xmm0,qword ptr [rbp+10]
       vmulsd    xmm0,xmm0,qword ptr [7FFAAF1C8A40]
       call      System.Convert.ToInt32(Double)
       movsxd    rdx,eax
       mov       [rbp+0FFB8],rdx
       mov       rdx,[rbp+0FFB8]
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp+0FFB0],rax
       mov       rdx,[rbp+0FFB0]
       lea       rcx,[rbp+0FFF0]
       call      System.Span`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte[])
       mov       rdx,203EE7E7448
       mov       rdx,[rdx]
       mov       [rbp+0FFE8],rdx
       xor       edx,edx
       mov       [rbp+0FFE0],edx
       lea       rdx,[rbp+0FFE0]
       mov       rcx,[rbp+0FFE8]
       call      System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,203EE7E7450
       mov       rcx,[rcx]
       mov       [rbp+0FF98],rcx
       vmovdqu   xmm0,xmmword ptr [rbp+0FFF0]
       vmovdqu   xmmword ptr [rbp+0FFA0],xmm0
       mov       rcx,[rbp+0FF98]
       lea       rdx,[rbp+0FFA0]
       mov       rax,[rbp+0FF98]
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       jmp       short M02_L01
M02_L01:
       mov       rcx,rsp
       call      M02_L02
       nop
       lea       rcx,[rbp+0FFF0]
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].ToArray()
       nop
       add       rsp,0A0
       pop       rbp
       ret
M02_L02:
       push      rbp
       sub       rsp,30
       vzeroupper
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+0A0]
       mov       ecx,[rbp+0FFE0]
       movzx     ecx,cl
       test      ecx,ecx
       je        short M02_L03
       mov       rcx,[rbp+0FFE8]
       call      System.Threading.Monitor.Exit(System.Object)
M02_L03:
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 425
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(Int32, System.__Canon, System.Collections.Generic.InsertionBehavior)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rsi,rcx
       mov       edi,edx
       mov       rbx,r8
       mov       ebp,r9d
       cmp       qword ptr [rsi+8],0
       jne       short M03_L00
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFB0D975AE0]
M03_L00:
       mov       r14,[rsi+10]
       mov       r15,[rsi+18]
       test      r15,r15
       jne       near ptr M03_L20
       mov       r12d,edi
M03_L01:
       xor       r13d,r13d
       mov       rdx,[rsi+8]
       mov       ecx,[rdx+8]
       mov       eax,ecx
       mov       r8,[rsi+30]
       mov       r9d,r12d
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       eax,eax
       imul      rax,r8
       shr       rax,20
       cmp       eax,ecx
       jae       near ptr M03_L21
       movsxd    rcx,eax
       lea       rax,[rdx+rcx*4+10]
       mov       r8d,[rax]
       dec       r8d
       test      r15,r15
       jne       near ptr M03_L13
M03_L02:
       cmp       [r14+8],r8d
       ja        short M03_L07
M03_L03:
       cmp       dword ptr [rsi+40],0
       jg        near ptr M03_L10
       mov       r15d,[rsi+38]
       cmp       [r14+8],r15d
       je        near ptr M03_L09
M03_L04:
       lea       edx,[r15+1]
       mov       [rsi+38],edx
       mov       r14,[rsi+10]
M03_L05:
       cmp       r15d,[r14+8]
       jae       near ptr M03_L21
       movsxd    rdx,r15d
       lea       rdx,[rdx+rdx*2]
       lea       rcx,[r14+rdx*8+10]
       mov       [rcx+8],r12d
       mov       [rsp+28],rax
       mov       edx,[rax]
       dec       edx
       mov       [rcx+0C],edx
       mov       [rcx+10],edi
       mov       rdx,rbx
       call      qword ptr [7FFB0D970590]
       inc       r15d
       mov       rbx,[rsp+28]
       mov       [rbx],r15d
       inc       dword ptr [rsi+44]
M03_L06:
       mov       eax,1
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L07:
       movsxd    rcx,r8d
       lea       rcx,[rcx+rcx*2]
       lea       r15,[r14+rcx*8+10]
       cmp       [r15+8],r12d
       mov       [rsp+34],r8d
       je        near ptr M03_L11
M03_L08:
       mov       r8d,[r15+0C]
       inc       r13d
       cmp       [r14+8],r13d
       jb        near ptr M03_L19
       jmp       near ptr M03_L02
M03_L09:
       mov       ecx,[rsi+38]
       call      qword ptr [7FFB0D974AE0]
       mov       edx,eax
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFB0D975AF0]
       mov       rax,[rsi+8]
       mov       edx,[rax+8]
       mov       ecx,edx
       mov       r8,[rsi+30]
       mov       r9d,r12d
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       ecx,ecx
       imul      rcx,r8
       shr       rcx,20
       cmp       ecx,edx
       jae       near ptr M03_L21
       movsxd    rdx,ecx
       lea       rax,[rax+rdx*4+10]
       mov       [rsp+28],rax
       mov       rax,[rsp+28]
       jmp       near ptr M03_L04
M03_L10:
       mov       edx,[rsi+3C]
       mov       r15d,edx
       cmp       edx,[r14+8]
       jae       near ptr M03_L21
       movsxd    rdx,edx
       lea       rdx,[rdx+rdx*2]
       mov       edx,[r14+rdx*8+1C]
       neg       edx
       add       edx,0FFFFFFFD
       mov       [rsi+3C],edx
       dec       dword ptr [rsi+40]
       jmp       near ptr M03_L05
M03_L11:
       mov       [rsp+28],rax
       call      qword ptr [7FFB0D971340]
       mov       rdx,[rax]
       mov       ecx,[r15+10]
       cmp       [rdx],edx
       cmp       ecx,edi
       sete      dl
       movzx     edx,dl
       test      edx,edx
       mov       rax,[rsp+28]
       je        near ptr M03_L08
       mov       r8d,[rsp+34]
       cmp       bpl,1
       jne       short M03_L12
       movsxd    rdx,r8d
       lea       rdx,[rdx+rdx*2]
       lea       rcx,[r14+rdx*8+10]
       mov       rdx,rbx
       call      qword ptr [7FFB0D970588]
       jmp       near ptr M03_L06
M03_L12:
       cmp       bpl,2
       jne       near ptr M03_L17
       jmp       near ptr M03_L16
M03_L13:
       cmp       [r14+8],r8d
       jbe       near ptr M03_L03
       movsxd    rdx,r8d
       lea       rdx,[rdx+rdx*2]
       cmp       [r14+rdx*8+18],r12d
       jne       near ptr M03_L18
       mov       [rsp+28],rax
       mov       [rsp+34],r8d
       movsxd    rdx,r8d
       lea       rdx,[rdx+rdx*2]
       mov       edx,[r14+rdx*8+20]
       mov       rcx,r15
       mov       r8d,edi
       lea       r11,[7FFB0D96FDC0]
       call      qword ptr [7FFB0D96FDC0]
       test      al,al
       mov       rax,[rsp+28]
       je        short M03_L14
       cmp       bpl,1
       jne       short M03_L15
       mov       esi,[rsp+34]
       movsxd    rdx,esi
       lea       rdx,[rdx+rdx*2]
       lea       rcx,[r14+rdx*8+10]
       mov       rdx,rbx
       call      qword ptr [7FFB0D970588]
       jmp       near ptr M03_L06
M03_L14:
       mov       r8d,[rsp+34]
       jmp       short M03_L18
M03_L15:
       cmp       bpl,2
       jne       short M03_L17
M03_L16:
       mov       ecx,edi
       call      qword ptr [7FFB0D969248]
       int       3
M03_L17:
       xor       eax,eax
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L18:
       movsxd    r8,r8d
       lea       rdx,[r8+r8*2]
       mov       r8d,[r14+rdx*8+1C]
       inc       r13d
       cmp       [r14+8],r13d
       jae       near ptr M03_L13
M03_L19:
       call      qword ptr [7FFB0D96D150]
       int       3
M03_L20:
       mov       rcx,r15
       mov       edx,edi
       lea       r11,[7FFB0D96FDC8]
       call      qword ptr [7FFB0D96FDC8]
       mov       r12d,eax
       jmp       near ptr M03_L01
M03_L21:
       call      qword ptr [7FFB0D970578]
       int       3
; Total bytes of code 760
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.BytesToString(System.ReadOnlySpan`1<Byte>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       vzeroupper
       mov       rsi,rcx
       mov       rcx,rsi
       vmovdqu   xmm0,xmmword ptr [rsi]
       vmovdqu   xmmword ptr [rsp+20],xmm0
       lea       rdx,[rsp+20]
       mov       r8,203DE7E1200
       mov       r9,[r8]
       mov       r8,r9
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotEmpty[[System.Byte, System.Private.CoreLib]](System.ReadOnlySpan`1<Byte>, System.String, System.String)
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       edx,[rsi+8]
       mov       rcx,rdi
       mov       r8d,7FFFFFFF
       call      System.Text.StringBuilder..ctor(Int32, Int32)
       xor       ebx,ebx
       cmp       dword ptr [rsi+8],0
       jle       short M04_L01
       mov       rdx,203BE7E1568
       mov       rbp,[rdx]
       mov       rdx,203DE7E2408
       mov       r14,[rdx]
M04_L00:
       cmp       ebx,[rsi+8]
       jae       short M04_L03
       movsxd    rdx,ebx
       add       rdx,[rsi]
       mov       r8,rbp
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r14
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|42_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       add       ebx,1
       jo        short M04_L02
       cmp       ebx,[rsi+8]
       jl        short M04_L00
M04_L01:
       mov       rcx,rdi
       call      qword ptr [7FFAAF3B78C0]
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M04_L02:
       call      CORINFO_HELP_OVERFLOW
       int       3
M04_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 203
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowKeyNotFoundException[[System.Int32, System.Private.CoreLib]](Int32)

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.BytesToString02()
; 			var readOnlySpan = new ReadOnlySpan<byte>(base.GetByteArray(1));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = readOnlySpan.BytesToString();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,38
       vzeroupper
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rax
       mov       rsi,rcx
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       mov       edx,1
       call      System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       test      rax,rax
       jne       short M00_L00
       mov       rdi,[rsi+8]
       vmovsd    xmm0,qword ptr [7FFAAF3CB570]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       mov       r8,rax
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,1
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(Int32, System.__Canon, System.Collections.Generic.InsertionBehavior)
M00_L00:
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       mov       edx,1
       call      System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       test      rax,rax
       je        short M00_L03
       mov       rcx,[rax]
       test      rcx,rcx
       je        short M00_L02
       lea       rax,[rcx+10]
       mov       ecx,[rcx+8]
M00_L01:
       mov       [rsp+28],rax
       mov       [rsp+30],ecx
       lea       rcx,[rsp+28]
       call      DotNetTips.Spargine.Extensions.ArrayExtensions.BytesToString(System.ReadOnlySpan`1<Byte>)
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,38
       pop       rsi
       pop       rdi
       ret
M00_L02:
       xor       eax,eax
       xor       ecx,ecx
       jmp       short M00_L01
M00_L03:
       mov       ecx,1
       call      System.ThrowHelper.ThrowKeyNotFoundException[[System.Int32, System.Private.CoreLib]](Int32)
       int       3
; Total bytes of code 184
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       edi,edx
       mov       rax,[rsi]
       mov       rax,[rax+30]
       mov       rbx,[rax]
       cmp       qword ptr [rsi+8],0
       jne       short M01_L01
M01_L00:
       cmp       qword ptr [rbx+28],0
       je        near ptr M01_L05
       jmp       near ptr M01_L05
M01_L01:
       mov       rbp,[rsi+18]
       test      rbp,rbp
       jne       near ptr M01_L06
       mov       eax,edi
       mov       rcx,[rsi+8]
       mov       edx,[rcx+8]
       mov       r11d,edx
       mov       r8,[rsi+30]
       mov       r9d,eax
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       r11d,r11d
       imul      r11,r8
       shr       r11,20
       cmp       r11d,edx
       jae       near ptr M01_L11
       movsxd    rdx,r11d
       lea       rcx,[rcx+rdx*4+10]
       mov       ecx,[rcx]
       mov       rdx,[rsi+10]
       xor       r11d,r11d
       dec       ecx
       mov       r8d,[rdx+8]
M01_L02:
       cmp       r8d,ecx
       jbe       short M01_L00
       movsxd    rcx,ecx
       lea       rcx,[rcx+rcx*2]
       lea       r14,[rdx+rcx*8+10]
       cmp       [r14+8],edi
       jne       short M01_L03
       mov       ecx,[r14+10]
       cmp       ecx,eax
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       short M01_L04
M01_L03:
       mov       ecx,[r14+0C]
       inc       r11d
       cmp       r8d,r11d
       jb        near ptr M01_L09
       jmp       short M01_L02
M01_L04:
       mov       rax,r14
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L05:
       xor       r14d,r14d
       jmp       short M01_L04
M01_L06:
       mov       rcx,rbp
       mov       edx,edi
       mov       r11,7FFAAEE10670
       call      qword ptr [7FFAAF3D0670]
       mov       r14d,eax
       mov       rdx,[rsi+8]
       mov       ecx,[rdx+8]
       mov       r8,[rsi+30]
       mov       r11d,r14d
       imul      r8,r11
       shr       r8,20
       inc       r8
       mov       ecx,ecx
       imul      rcx,r8
       shr       rcx,20
       cmp       ecx,[rdx+8]
       jae       short M01_L11
       movsxd    rcx,ecx
       lea       rdx,[rdx+rcx*4+10]
       mov       r15d,[rdx]
       mov       r12,[rsi+10]
       xor       r13d,r13d
       dec       r15d
M01_L07:
       cmp       [r12+8],r15d
       jbe       near ptr M01_L00
       movsxd    rdx,r15d
       lea       rdx,[rdx+rdx*2]
       lea       rdx,[r12+rdx*8+10]
       mov       r15,rdx
       cmp       [r15+8],r14d
       jne       short M01_L08
       mov       edx,[r15+10]
       mov       rcx,rbp
       mov       r8d,edi
       mov       r11,7FFAAEE10678
       call      qword ptr [7FFAAF3D0678]
       test      eax,eax
       jne       short M01_L10
M01_L08:
       mov       r15d,[r15+0C]
       inc       r13d
       cmp       [r12+8],r13d
       jae       short M01_L07
M01_L09:
       call      System.ThrowHelper.ThrowInvalidOperationException_ConcurrentOperationsNotSupported()
       int       3
M01_L10:
       mov       r14,r15
       jmp       near ptr M01_L04
M01_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 408
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       push      rbp
       sub       rsp,0A0
       vzeroupper
       lea       rbp,[rsp+0A0]
       xor       eax,eax
       mov       [rbp+0FF98],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFA0
M02_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M02_L00
       mov       [rbp+0FF88],rsp
       vmovsd    qword ptr [rbp+10],xmm0
       call      System.Globalization.CultureInfo.get_InvariantCulture()
       mov       [rbp+0FFD8],rax
       mov       rcx,offset MT_System.Double
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp+0FFD0],rax
       call      DotNetTips.Spargine.Tester.Properties.Resources.get_SizeMustBeEpsilon()
       mov       [rbp+0FFC8],rax
       mov       r8,[rbp+0FFD0]
       mov       qword ptr [r8+8],1
       mov       r8,[rbp+0FFD0]
       mov       rcx,[rbp+0FFD8]
       mov       rdx,[rbp+0FFC8]
       call      System.String.Format(System.IFormatProvider, System.String, System.Object)
       mov       [rbp+0FFC0],rax
       mov       r9,23C148A3570
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,[rbp+0FFC0]
       vmovsd    xmm2,qword ptr [rbp+10]
       vucomisd  xmm2,qword ptr [7FFAAF1D8A38]
       setae     dl
       movzx     edx,dl
       vxorps    xmm2,xmm2,xmm2
       vmovsd    xmm0,qword ptr [rbp+10]
       call      DotNetTips.Spargine.Core.Validator.ArgumentMeetsCondition[[System.Double, System.Private.CoreLib]](Double, Boolean, Double, System.String, System.String)
       vmovsd    qword ptr [rbp+10],xmm0
       vmovsd    xmm0,qword ptr [rbp+10]
       vmulsd    xmm0,xmm0,qword ptr [7FFAAF1D8A40]
       call      System.Convert.ToInt32(Double)
       movsxd    rdx,eax
       mov       [rbp+0FFB8],rdx
       mov       rdx,[rbp+0FFB8]
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp+0FFB0],rax
       mov       rdx,[rbp+0FFB0]
       lea       rcx,[rbp+0FFF0]
       call      System.Span`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte[])
       mov       rdx,23C1489B850
       mov       rdx,[rdx]
       mov       [rbp+0FFE8],rdx
       xor       edx,edx
       mov       [rbp+0FFE0],edx
       lea       rdx,[rbp+0FFE0]
       mov       rcx,[rbp+0FFE8]
       call      System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,23C1489B858
       mov       rcx,[rcx]
       mov       [rbp+0FF98],rcx
       vmovdqu   xmm0,xmmword ptr [rbp+0FFF0]
       vmovdqu   xmmword ptr [rbp+0FFA0],xmm0
       mov       rcx,[rbp+0FF98]
       lea       rdx,[rbp+0FFA0]
       mov       rax,[rbp+0FF98]
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       jmp       short M02_L01
M02_L01:
       mov       rcx,rsp
       call      M02_L02
       nop
       lea       rcx,[rbp+0FFF0]
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].ToArray()
       nop
       add       rsp,0A0
       pop       rbp
       ret
M02_L02:
       push      rbp
       sub       rsp,30
       vzeroupper
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+0A0]
       mov       ecx,[rbp+0FFE0]
       movzx     ecx,cl
       test      ecx,ecx
       je        short M02_L03
       mov       rcx,[rbp+0FFE8]
       call      System.Threading.Monitor.Exit(System.Object)
M02_L03:
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 425
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(Int32, System.__Canon, System.Collections.Generic.InsertionBehavior)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rsi,rcx
       mov       edi,edx
       mov       rbx,r8
       mov       ebp,r9d
       cmp       qword ptr [rsi+8],0
       jne       short M03_L00
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFB0D975AE0]
M03_L00:
       mov       r14,[rsi+10]
       mov       r15,[rsi+18]
       test      r15,r15
       jne       near ptr M03_L20
       mov       r12d,edi
M03_L01:
       xor       r13d,r13d
       mov       rdx,[rsi+8]
       mov       ecx,[rdx+8]
       mov       eax,ecx
       mov       r8,[rsi+30]
       mov       r9d,r12d
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       eax,eax
       imul      rax,r8
       shr       rax,20
       cmp       eax,ecx
       jae       near ptr M03_L21
       movsxd    rcx,eax
       lea       rax,[rdx+rcx*4+10]
       mov       r8d,[rax]
       dec       r8d
       test      r15,r15
       jne       near ptr M03_L13
M03_L02:
       cmp       [r14+8],r8d
       ja        short M03_L07
M03_L03:
       cmp       dword ptr [rsi+40],0
       jg        near ptr M03_L10
       mov       r15d,[rsi+38]
       cmp       [r14+8],r15d
       je        near ptr M03_L09
M03_L04:
       lea       edx,[r15+1]
       mov       [rsi+38],edx
       mov       r14,[rsi+10]
M03_L05:
       cmp       r15d,[r14+8]
       jae       near ptr M03_L21
       movsxd    rdx,r15d
       lea       rdx,[rdx+rdx*2]
       lea       rcx,[r14+rdx*8+10]
       mov       [rcx+8],r12d
       mov       [rsp+28],rax
       mov       edx,[rax]
       dec       edx
       mov       [rcx+0C],edx
       mov       [rcx+10],edi
       mov       rdx,rbx
       call      qword ptr [7FFB0D970590]
       inc       r15d
       mov       rbx,[rsp+28]
       mov       [rbx],r15d
       inc       dword ptr [rsi+44]
M03_L06:
       mov       eax,1
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L07:
       movsxd    rcx,r8d
       lea       rcx,[rcx+rcx*2]
       lea       r15,[r14+rcx*8+10]
       cmp       [r15+8],r12d
       mov       [rsp+34],r8d
       je        near ptr M03_L11
M03_L08:
       mov       r8d,[r15+0C]
       inc       r13d
       cmp       [r14+8],r13d
       jb        near ptr M03_L19
       jmp       near ptr M03_L02
M03_L09:
       mov       ecx,[rsi+38]
       call      qword ptr [7FFB0D974AE0]
       mov       edx,eax
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFB0D975AF0]
       mov       rax,[rsi+8]
       mov       edx,[rax+8]
       mov       ecx,edx
       mov       r8,[rsi+30]
       mov       r9d,r12d
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       ecx,ecx
       imul      rcx,r8
       shr       rcx,20
       cmp       ecx,edx
       jae       near ptr M03_L21
       movsxd    rdx,ecx
       lea       rax,[rax+rdx*4+10]
       mov       [rsp+28],rax
       mov       rax,[rsp+28]
       jmp       near ptr M03_L04
M03_L10:
       mov       edx,[rsi+3C]
       mov       r15d,edx
       cmp       edx,[r14+8]
       jae       near ptr M03_L21
       movsxd    rdx,edx
       lea       rdx,[rdx+rdx*2]
       mov       edx,[r14+rdx*8+1C]
       neg       edx
       add       edx,0FFFFFFFD
       mov       [rsi+3C],edx
       dec       dword ptr [rsi+40]
       jmp       near ptr M03_L05
M03_L11:
       mov       [rsp+28],rax
       call      qword ptr [7FFB0D971340]
       mov       rdx,[rax]
       mov       ecx,[r15+10]
       cmp       [rdx],edx
       cmp       ecx,edi
       sete      dl
       movzx     edx,dl
       test      edx,edx
       mov       rax,[rsp+28]
       je        near ptr M03_L08
       mov       r8d,[rsp+34]
       cmp       bpl,1
       jne       short M03_L12
       movsxd    rdx,r8d
       lea       rdx,[rdx+rdx*2]
       lea       rcx,[r14+rdx*8+10]
       mov       rdx,rbx
       call      qword ptr [7FFB0D970588]
       jmp       near ptr M03_L06
M03_L12:
       cmp       bpl,2
       jne       near ptr M03_L17
       jmp       near ptr M03_L16
M03_L13:
       cmp       [r14+8],r8d
       jbe       near ptr M03_L03
       movsxd    rdx,r8d
       lea       rdx,[rdx+rdx*2]
       cmp       [r14+rdx*8+18],r12d
       jne       near ptr M03_L18
       mov       [rsp+28],rax
       mov       [rsp+34],r8d
       movsxd    rdx,r8d
       lea       rdx,[rdx+rdx*2]
       mov       edx,[r14+rdx*8+20]
       mov       rcx,r15
       mov       r8d,edi
       lea       r11,[7FFB0D96FDC0]
       call      qword ptr [7FFB0D96FDC0]
       test      al,al
       mov       rax,[rsp+28]
       je        short M03_L14
       cmp       bpl,1
       jne       short M03_L15
       mov       esi,[rsp+34]
       movsxd    rdx,esi
       lea       rdx,[rdx+rdx*2]
       lea       rcx,[r14+rdx*8+10]
       mov       rdx,rbx
       call      qword ptr [7FFB0D970588]
       jmp       near ptr M03_L06
M03_L14:
       mov       r8d,[rsp+34]
       jmp       short M03_L18
M03_L15:
       cmp       bpl,2
       jne       short M03_L17
M03_L16:
       mov       ecx,edi
       call      qword ptr [7FFB0D969248]
       int       3
M03_L17:
       xor       eax,eax
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L18:
       movsxd    r8,r8d
       lea       rdx,[r8+r8*2]
       mov       r8d,[r14+rdx*8+1C]
       inc       r13d
       cmp       [r14+8],r13d
       jae       near ptr M03_L13
M03_L19:
       call      qword ptr [7FFB0D96D150]
       int       3
M03_L20:
       mov       rcx,r15
       mov       edx,edi
       lea       r11,[7FFB0D96FDC8]
       call      qword ptr [7FFB0D96FDC8]
       mov       r12d,eax
       jmp       near ptr M03_L01
M03_L21:
       call      qword ptr [7FFB0D970578]
       int       3
; Total bytes of code 760
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.BytesToString(System.ReadOnlySpan`1<Byte>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       vzeroupper
       mov       rsi,rcx
       mov       rcx,rsi
       vmovdqu   xmm0,xmmword ptr [rsi]
       vmovdqu   xmmword ptr [rsp+20],xmm0
       lea       rdx,[rsp+20]
       mov       r8,23C148A1A38
       mov       r9,[r8]
       mov       r8,r9
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotEmpty[[System.Byte, System.Private.CoreLib]](System.ReadOnlySpan`1<Byte>, System.String, System.String)
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       edx,[rsi+8]
       mov       rcx,rdi
       mov       r8d,7FFFFFFF
       call      System.Text.StringBuilder..ctor(Int32, Int32)
       xor       ebx,ebx
       cmp       dword ptr [rsi+8],0
       jle       short M04_L01
       mov       rdx,23C14891568
       mov       rbp,[rdx]
       mov       rdx,23C148A3C58
       mov       r14,[rdx]
M04_L00:
       cmp       ebx,[rsi+8]
       jae       short M04_L03
       movsxd    rdx,ebx
       add       rdx,[rsi]
       mov       r8,rbp
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r14
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|42_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       add       ebx,1
       jo        short M04_L02
       cmp       ebx,[rsi+8]
       jl        short M04_L00
M04_L01:
       mov       rcx,rdi
       call      qword ptr [7FFAAF3C78C0]
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M04_L02:
       call      CORINFO_HELP_OVERFLOW
       int       3
M04_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 203
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowKeyNotFoundException[[System.Int32, System.Private.CoreLib]](Int32)

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.BytesToString02()
; 			var readOnlySpan = new ReadOnlySpan<byte>(base.GetByteArray(1));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = readOnlySpan.BytesToString();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,38
       vzeroupper
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rax
       mov       rsi,rcx
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       mov       edx,1
       call      System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       test      rax,rax
       jne       short M00_L00
       mov       rdi,[rsi+8]
       vmovsd    xmm0,qword ptr [7FFAAF3DB3F0]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       mov       r8,rax
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,1
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(Int32, System.__Canon, System.Collections.Generic.InsertionBehavior)
M00_L00:
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       mov       edx,1
       call      System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       test      rax,rax
       je        short M00_L03
       mov       rcx,[rax]
       test      rcx,rcx
       je        short M00_L02
       lea       rax,[rcx+10]
       mov       ecx,[rcx+8]
M00_L01:
       mov       [rsp+28],rax
       mov       [rsp+30],ecx
       lea       rcx,[rsp+28]
       call      DotNetTips.Spargine.Extensions.ArrayExtensions.BytesToString(System.ReadOnlySpan`1<Byte>)
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,38
       pop       rsi
       pop       rdi
       ret
M00_L02:
       xor       eax,eax
       xor       ecx,ecx
       jmp       short M00_L01
M00_L03:
       mov       ecx,1
       call      System.ThrowHelper.ThrowKeyNotFoundException[[System.Int32, System.Private.CoreLib]](Int32)
       int       3
; Total bytes of code 184
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       edi,edx
       mov       rax,[rsi]
       mov       rax,[rax+30]
       mov       rbx,[rax]
       cmp       qword ptr [rsi+8],0
       jne       short M01_L01
M01_L00:
       cmp       qword ptr [rbx+28],0
       je        near ptr M01_L05
       jmp       near ptr M01_L05
M01_L01:
       mov       rbp,[rsi+18]
       test      rbp,rbp
       jne       near ptr M01_L06
       mov       eax,edi
       mov       rcx,[rsi+8]
       mov       edx,[rcx+8]
       mov       r11d,edx
       mov       r8,[rsi+30]
       mov       r9d,eax
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       r11d,r11d
       imul      r11,r8
       shr       r11,20
       cmp       r11d,edx
       jae       near ptr M01_L11
       movsxd    rdx,r11d
       lea       rcx,[rcx+rdx*4+10]
       mov       ecx,[rcx]
       mov       rdx,[rsi+10]
       xor       r11d,r11d
       dec       ecx
       mov       r8d,[rdx+8]
M01_L02:
       cmp       r8d,ecx
       jbe       short M01_L00
       movsxd    rcx,ecx
       lea       rcx,[rcx+rcx*2]
       lea       r14,[rdx+rcx*8+10]
       cmp       [r14+8],edi
       jne       short M01_L03
       mov       ecx,[r14+10]
       cmp       ecx,eax
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       short M01_L04
M01_L03:
       mov       ecx,[r14+0C]
       inc       r11d
       cmp       r8d,r11d
       jb        near ptr M01_L09
       jmp       short M01_L02
M01_L04:
       mov       rax,r14
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L05:
       xor       r14d,r14d
       jmp       short M01_L04
M01_L06:
       mov       rcx,rbp
       mov       edx,edi
       mov       r11,7FFAAEE20670
       call      qword ptr [7FFAAF3E0670]
       mov       r14d,eax
       mov       rdx,[rsi+8]
       mov       ecx,[rdx+8]
       mov       r8,[rsi+30]
       mov       r11d,r14d
       imul      r8,r11
       shr       r8,20
       inc       r8
       mov       ecx,ecx
       imul      rcx,r8
       shr       rcx,20
       cmp       ecx,[rdx+8]
       jae       short M01_L11
       movsxd    rcx,ecx
       lea       rdx,[rdx+rcx*4+10]
       mov       r15d,[rdx]
       mov       r12,[rsi+10]
       xor       r13d,r13d
       dec       r15d
M01_L07:
       cmp       [r12+8],r15d
       jbe       near ptr M01_L00
       movsxd    rdx,r15d
       lea       rdx,[rdx+rdx*2]
       lea       rdx,[r12+rdx*8+10]
       mov       r15,rdx
       cmp       [r15+8],r14d
       jne       short M01_L08
       mov       edx,[r15+10]
       mov       rcx,rbp
       mov       r8d,edi
       mov       r11,7FFAAEE20678
       call      qword ptr [7FFAAF3E0678]
       test      eax,eax
       jne       short M01_L10
M01_L08:
       mov       r15d,[r15+0C]
       inc       r13d
       cmp       [r12+8],r13d
       jae       short M01_L07
M01_L09:
       call      System.ThrowHelper.ThrowInvalidOperationException_ConcurrentOperationsNotSupported()
       int       3
M01_L10:
       mov       r14,r15
       jmp       near ptr M01_L04
M01_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 408
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       push      rbp
       sub       rsp,0A0
       vzeroupper
       lea       rbp,[rsp+0A0]
       xor       eax,eax
       mov       [rbp+0FF98],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFA0
M02_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M02_L00
       mov       [rbp+0FF88],rsp
       vmovsd    qword ptr [rbp+10],xmm0
       call      System.Globalization.CultureInfo.get_InvariantCulture()
       mov       [rbp+0FFD8],rax
       mov       rcx,offset MT_System.Double
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp+0FFD0],rax
       call      DotNetTips.Spargine.Tester.Properties.Resources.get_SizeMustBeEpsilon()
       mov       [rbp+0FFC8],rax
       mov       r8,[rbp+0FFD0]
       mov       qword ptr [r8+8],1
       mov       r8,[rbp+0FFD0]
       mov       rcx,[rbp+0FFD8]
       mov       rdx,[rbp+0FFC8]
       call      System.String.Format(System.IFormatProvider, System.String, System.Object)
       mov       [rbp+0FFC0],rax
       mov       r9,1341C072520
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,[rbp+0FFC0]
       vmovsd    xmm2,qword ptr [rbp+10]
       vucomisd  xmm2,qword ptr [7FFAAF1E8A38]
       setae     dl
       movzx     edx,dl
       vxorps    xmm2,xmm2,xmm2
       vmovsd    xmm0,qword ptr [rbp+10]
       call      DotNetTips.Spargine.Core.Validator.ArgumentMeetsCondition[[System.Double, System.Private.CoreLib]](Double, Boolean, Double, System.String, System.String)
       vmovsd    qword ptr [rbp+10],xmm0
       vmovsd    xmm0,qword ptr [rbp+10]
       vmulsd    xmm0,xmm0,qword ptr [7FFAAF1E8A40]
       call      System.Convert.ToInt32(Double)
       movsxd    rdx,eax
       mov       [rbp+0FFB8],rdx
       mov       rdx,[rbp+0FFB8]
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp+0FFB0],rax
       mov       rdx,[rbp+0FFB0]
       lea       rcx,[rbp+0FFF0]
       call      System.Span`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte[])
       mov       rdx,1343C07B850
       mov       rdx,[rdx]
       mov       [rbp+0FFE8],rdx
       xor       edx,edx
       mov       [rbp+0FFE0],edx
       lea       rdx,[rbp+0FFE0]
       mov       rcx,[rbp+0FFE8]
       call      System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,1343C07B858
       mov       rcx,[rcx]
       mov       [rbp+0FF98],rcx
       vmovdqu   xmm0,xmmword ptr [rbp+0FFF0]
       vmovdqu   xmmword ptr [rbp+0FFA0],xmm0
       mov       rcx,[rbp+0FF98]
       lea       rdx,[rbp+0FFA0]
       mov       rax,[rbp+0FF98]
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       jmp       short M02_L01
M02_L01:
       mov       rcx,rsp
       call      M02_L02
       nop
       lea       rcx,[rbp+0FFF0]
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].ToArray()
       nop
       add       rsp,0A0
       pop       rbp
       ret
M02_L02:
       push      rbp
       sub       rsp,30
       vzeroupper
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+0A0]
       mov       ecx,[rbp+0FFE0]
       movzx     ecx,cl
       test      ecx,ecx
       je        short M02_L03
       mov       rcx,[rbp+0FFE8]
       call      System.Threading.Monitor.Exit(System.Object)
M02_L03:
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 425
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(Int32, System.__Canon, System.Collections.Generic.InsertionBehavior)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rsi,rcx
       mov       edi,edx
       mov       rbx,r8
       mov       ebp,r9d
       cmp       qword ptr [rsi+8],0
       jne       short M03_L00
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFB0D975AE0]
M03_L00:
       mov       r14,[rsi+10]
       mov       r15,[rsi+18]
       test      r15,r15
       jne       near ptr M03_L20
       mov       r12d,edi
M03_L01:
       xor       r13d,r13d
       mov       rdx,[rsi+8]
       mov       ecx,[rdx+8]
       mov       eax,ecx
       mov       r8,[rsi+30]
       mov       r9d,r12d
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       eax,eax
       imul      rax,r8
       shr       rax,20
       cmp       eax,ecx
       jae       near ptr M03_L21
       movsxd    rcx,eax
       lea       rax,[rdx+rcx*4+10]
       mov       r8d,[rax]
       dec       r8d
       test      r15,r15
       jne       near ptr M03_L13
M03_L02:
       cmp       [r14+8],r8d
       ja        short M03_L07
M03_L03:
       cmp       dword ptr [rsi+40],0
       jg        near ptr M03_L10
       mov       r15d,[rsi+38]
       cmp       [r14+8],r15d
       je        near ptr M03_L09
M03_L04:
       lea       edx,[r15+1]
       mov       [rsi+38],edx
       mov       r14,[rsi+10]
M03_L05:
       cmp       r15d,[r14+8]
       jae       near ptr M03_L21
       movsxd    rdx,r15d
       lea       rdx,[rdx+rdx*2]
       lea       rcx,[r14+rdx*8+10]
       mov       [rcx+8],r12d
       mov       [rsp+28],rax
       mov       edx,[rax]
       dec       edx
       mov       [rcx+0C],edx
       mov       [rcx+10],edi
       mov       rdx,rbx
       call      qword ptr [7FFB0D970590]
       inc       r15d
       mov       rbx,[rsp+28]
       mov       [rbx],r15d
       inc       dword ptr [rsi+44]
M03_L06:
       mov       eax,1
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L07:
       movsxd    rcx,r8d
       lea       rcx,[rcx+rcx*2]
       lea       r15,[r14+rcx*8+10]
       cmp       [r15+8],r12d
       mov       [rsp+34],r8d
       je        near ptr M03_L11
M03_L08:
       mov       r8d,[r15+0C]
       inc       r13d
       cmp       [r14+8],r13d
       jb        near ptr M03_L19
       jmp       near ptr M03_L02
M03_L09:
       mov       ecx,[rsi+38]
       call      qword ptr [7FFB0D974AE0]
       mov       edx,eax
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFB0D975AF0]
       mov       rax,[rsi+8]
       mov       edx,[rax+8]
       mov       ecx,edx
       mov       r8,[rsi+30]
       mov       r9d,r12d
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       ecx,ecx
       imul      rcx,r8
       shr       rcx,20
       cmp       ecx,edx
       jae       near ptr M03_L21
       movsxd    rdx,ecx
       lea       rax,[rax+rdx*4+10]
       mov       [rsp+28],rax
       mov       rax,[rsp+28]
       jmp       near ptr M03_L04
M03_L10:
       mov       edx,[rsi+3C]
       mov       r15d,edx
       cmp       edx,[r14+8]
       jae       near ptr M03_L21
       movsxd    rdx,edx
       lea       rdx,[rdx+rdx*2]
       mov       edx,[r14+rdx*8+1C]
       neg       edx
       add       edx,0FFFFFFFD
       mov       [rsi+3C],edx
       dec       dword ptr [rsi+40]
       jmp       near ptr M03_L05
M03_L11:
       mov       [rsp+28],rax
       call      qword ptr [7FFB0D971340]
       mov       rdx,[rax]
       mov       ecx,[r15+10]
       cmp       [rdx],edx
       cmp       ecx,edi
       sete      dl
       movzx     edx,dl
       test      edx,edx
       mov       rax,[rsp+28]
       je        near ptr M03_L08
       mov       r8d,[rsp+34]
       cmp       bpl,1
       jne       short M03_L12
       movsxd    rdx,r8d
       lea       rdx,[rdx+rdx*2]
       lea       rcx,[r14+rdx*8+10]
       mov       rdx,rbx
       call      qword ptr [7FFB0D970588]
       jmp       near ptr M03_L06
M03_L12:
       cmp       bpl,2
       jne       near ptr M03_L17
       jmp       near ptr M03_L16
M03_L13:
       cmp       [r14+8],r8d
       jbe       near ptr M03_L03
       movsxd    rdx,r8d
       lea       rdx,[rdx+rdx*2]
       cmp       [r14+rdx*8+18],r12d
       jne       near ptr M03_L18
       mov       [rsp+28],rax
       mov       [rsp+34],r8d
       movsxd    rdx,r8d
       lea       rdx,[rdx+rdx*2]
       mov       edx,[r14+rdx*8+20]
       mov       rcx,r15
       mov       r8d,edi
       lea       r11,[7FFB0D96FDC0]
       call      qword ptr [7FFB0D96FDC0]
       test      al,al
       mov       rax,[rsp+28]
       je        short M03_L14
       cmp       bpl,1
       jne       short M03_L15
       mov       esi,[rsp+34]
       movsxd    rdx,esi
       lea       rdx,[rdx+rdx*2]
       lea       rcx,[r14+rdx*8+10]
       mov       rdx,rbx
       call      qword ptr [7FFB0D970588]
       jmp       near ptr M03_L06
M03_L14:
       mov       r8d,[rsp+34]
       jmp       short M03_L18
M03_L15:
       cmp       bpl,2
       jne       short M03_L17
M03_L16:
       mov       ecx,edi
       call      qword ptr [7FFB0D969248]
       int       3
M03_L17:
       xor       eax,eax
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L18:
       movsxd    r8,r8d
       lea       rdx,[r8+r8*2]
       mov       r8d,[r14+rdx*8+1C]
       inc       r13d
       cmp       [r14+8],r13d
       jae       near ptr M03_L13
M03_L19:
       call      qword ptr [7FFB0D96D150]
       int       3
M03_L20:
       mov       rcx,r15
       mov       edx,edi
       lea       r11,[7FFB0D96FDC8]
       call      qword ptr [7FFB0D96FDC8]
       mov       r12d,eax
       jmp       near ptr M03_L01
M03_L21:
       call      qword ptr [7FFB0D970578]
       int       3
; Total bytes of code 760
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.BytesToString(System.ReadOnlySpan`1<Byte>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       vzeroupper
       mov       rsi,rcx
       mov       rcx,rsi
       vmovdqu   xmm0,xmmword ptr [rsi]
       vmovdqu   xmmword ptr [rsp+20],xmm0
       lea       rdx,[rsp+20]
       mov       r8,1343C081A38
       mov       r9,[r8]
       mov       r8,r9
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotEmpty[[System.Byte, System.Private.CoreLib]](System.ReadOnlySpan`1<Byte>, System.String, System.String)
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       edx,[rsi+8]
       mov       rcx,rdi
       mov       r8d,7FFFFFFF
       call      System.Text.StringBuilder..ctor(Int32, Int32)
       xor       ebx,ebx
       cmp       dword ptr [rsi+8],0
       jle       short M04_L01
       mov       rdx,1343C071568
       mov       rbp,[rdx]
       mov       rdx,1341C072C08
       mov       r14,[rdx]
M04_L00:
       cmp       ebx,[rsi+8]
       jae       short M04_L03
       movsxd    rdx,ebx
       add       rdx,[rsi]
       mov       r8,rbp
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r14
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|42_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       add       ebx,1
       jo        short M04_L02
       cmp       ebx,[rsi+8]
       jl        short M04_L00
M04_L01:
       mov       rcx,rdi
       call      qword ptr [7FFAAF3D78C0]
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M04_L02:
       call      CORINFO_HELP_OVERFLOW
       int       3
M04_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 203
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowKeyNotFoundException[[System.Int32, System.Private.CoreLib]](Int32)

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.BytesToString02()
; 			var readOnlySpan = new ReadOnlySpan<byte>(base.GetByteArray(1));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = readOnlySpan.BytesToString();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,38
       vzeroupper
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rax
       mov       rsi,rcx
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       mov       edx,1
       call      System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       test      rax,rax
       jne       short M00_L00
       mov       rdi,[rsi+8]
       vmovsd    xmm0,qword ptr [7FFAAF3AB300]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       mov       r8,rax
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,1
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(Int32, System.__Canon, System.Collections.Generic.InsertionBehavior)
M00_L00:
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       mov       edx,1
       call      System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       test      rax,rax
       je        short M00_L03
       mov       rcx,[rax]
       test      rcx,rcx
       je        short M00_L02
       lea       rax,[rcx+10]
       mov       ecx,[rcx+8]
M00_L01:
       mov       [rsp+28],rax
       mov       [rsp+30],ecx
       lea       rcx,[rsp+28]
       call      DotNetTips.Spargine.Extensions.ArrayExtensions.BytesToString(System.ReadOnlySpan`1<Byte>)
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,38
       pop       rsi
       pop       rdi
       ret
M00_L02:
       xor       eax,eax
       xor       ecx,ecx
       jmp       short M00_L01
M00_L03:
       mov       ecx,1
       call      System.ThrowHelper.ThrowKeyNotFoundException[[System.Int32, System.Private.CoreLib]](Int32)
       int       3
; Total bytes of code 184
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       edi,edx
       mov       rax,[rsi]
       mov       rax,[rax+30]
       mov       rbx,[rax]
       cmp       qword ptr [rsi+8],0
       jne       short M01_L01
M01_L00:
       cmp       qword ptr [rbx+28],0
       je        near ptr M01_L05
       jmp       near ptr M01_L05
M01_L01:
       mov       rbp,[rsi+18]
       test      rbp,rbp
       jne       near ptr M01_L06
       mov       eax,edi
       mov       rcx,[rsi+8]
       mov       edx,[rcx+8]
       mov       r11d,edx
       mov       r8,[rsi+30]
       mov       r9d,eax
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       r11d,r11d
       imul      r11,r8
       shr       r11,20
       cmp       r11d,edx
       jae       near ptr M01_L11
       movsxd    rdx,r11d
       lea       rcx,[rcx+rdx*4+10]
       mov       ecx,[rcx]
       mov       rdx,[rsi+10]
       xor       r11d,r11d
       dec       ecx
       mov       r8d,[rdx+8]
M01_L02:
       cmp       r8d,ecx
       jbe       short M01_L00
       movsxd    rcx,ecx
       lea       rcx,[rcx+rcx*2]
       lea       r14,[rdx+rcx*8+10]
       cmp       [r14+8],edi
       jne       short M01_L03
       mov       ecx,[r14+10]
       cmp       ecx,eax
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       short M01_L04
M01_L03:
       mov       ecx,[r14+0C]
       inc       r11d
       cmp       r8d,r11d
       jb        near ptr M01_L09
       jmp       short M01_L02
M01_L04:
       mov       rax,r14
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L05:
       xor       r14d,r14d
       jmp       short M01_L04
M01_L06:
       mov       rcx,rbp
       mov       edx,edi
       mov       r11,7FFAAEDF0670
       call      qword ptr [7FFAAF3B0670]
       mov       r14d,eax
       mov       rdx,[rsi+8]
       mov       ecx,[rdx+8]
       mov       r8,[rsi+30]
       mov       r11d,r14d
       imul      r8,r11
       shr       r8,20
       inc       r8
       mov       ecx,ecx
       imul      rcx,r8
       shr       rcx,20
       cmp       ecx,[rdx+8]
       jae       short M01_L11
       movsxd    rcx,ecx
       lea       rdx,[rdx+rcx*4+10]
       mov       r15d,[rdx]
       mov       r12,[rsi+10]
       xor       r13d,r13d
       dec       r15d
M01_L07:
       cmp       [r12+8],r15d
       jbe       near ptr M01_L00
       movsxd    rdx,r15d
       lea       rdx,[rdx+rdx*2]
       lea       rdx,[r12+rdx*8+10]
       mov       r15,rdx
       cmp       [r15+8],r14d
       jne       short M01_L08
       mov       edx,[r15+10]
       mov       rcx,rbp
       mov       r8d,edi
       mov       r11,7FFAAEDF0678
       call      qword ptr [7FFAAF3B0678]
       test      eax,eax
       jne       short M01_L10
M01_L08:
       mov       r15d,[r15+0C]
       inc       r13d
       cmp       [r12+8],r13d
       jae       short M01_L07
M01_L09:
       call      System.ThrowHelper.ThrowInvalidOperationException_ConcurrentOperationsNotSupported()
       int       3
M01_L10:
       mov       r14,r15
       jmp       near ptr M01_L04
M01_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 408
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       push      rbp
       sub       rsp,0A0
       vzeroupper
       lea       rbp,[rsp+0A0]
       xor       eax,eax
       mov       [rbp+0FF98],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFA0
M02_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M02_L00
       mov       [rbp+0FF88],rsp
       vmovsd    qword ptr [rbp+10],xmm0
       call      System.Globalization.CultureInfo.get_InvariantCulture()
       mov       [rbp+0FFD8],rax
       mov       rcx,offset MT_System.Double
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp+0FFD0],rax
       call      DotNetTips.Spargine.Tester.Properties.Resources.get_SizeMustBeEpsilon()
       mov       [rbp+0FFC8],rax
       mov       r8,[rbp+0FFD0]
       mov       qword ptr [r8+8],1
       mov       r8,[rbp+0FFD0]
       mov       rcx,[rbp+0FFD8]
       mov       rdx,[rbp+0FFC8]
       call      System.String.Format(System.IFormatProvider, System.String, System.Object)
       mov       [rbp+0FFC0],rax
       mov       r9,243BBA22520
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,[rbp+0FFC0]
       vmovsd    xmm2,qword ptr [rbp+10]
       vucomisd  xmm2,qword ptr [7FFAAF1B8A38]
       setae     dl
       movzx     edx,dl
       vxorps    xmm2,xmm2,xmm2
       vmovsd    xmm0,qword ptr [rbp+10]
       call      DotNetTips.Spargine.Core.Validator.ArgumentMeetsCondition[[System.Double, System.Private.CoreLib]](Double, Boolean, Double, System.String, System.String)
       vmovsd    qword ptr [rbp+10],xmm0
       vmovsd    xmm0,qword ptr [rbp+10]
       vmulsd    xmm0,xmm0,qword ptr [7FFAAF1B8A40]
       call      System.Convert.ToInt32(Double)
       movsxd    rdx,eax
       mov       [rbp+0FFB8],rdx
       mov       rdx,[rbp+0FFB8]
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp+0FFB0],rax
       mov       rdx,[rbp+0FFB0]
       lea       rcx,[rbp+0FFF0]
       call      System.Span`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte[])
       mov       rdx,243EBA27448
       mov       rdx,[rdx]
       mov       [rbp+0FFE8],rdx
       xor       edx,edx
       mov       [rbp+0FFE0],edx
       lea       rdx,[rbp+0FFE0]
       mov       rcx,[rbp+0FFE8]
       call      System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,243EBA27450
       mov       rcx,[rcx]
       mov       [rbp+0FF98],rcx
       vmovdqu   xmm0,xmmword ptr [rbp+0FFF0]
       vmovdqu   xmmword ptr [rbp+0FFA0],xmm0
       mov       rcx,[rbp+0FF98]
       lea       rdx,[rbp+0FFA0]
       mov       rax,[rbp+0FF98]
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       jmp       short M02_L01
M02_L01:
       mov       rcx,rsp
       call      M02_L02
       nop
       lea       rcx,[rbp+0FFF0]
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].ToArray()
       nop
       add       rsp,0A0
       pop       rbp
       ret
M02_L02:
       push      rbp
       sub       rsp,30
       vzeroupper
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+0A0]
       mov       ecx,[rbp+0FFE0]
       movzx     ecx,cl
       test      ecx,ecx
       je        short M02_L03
       mov       rcx,[rbp+0FFE8]
       call      System.Threading.Monitor.Exit(System.Object)
M02_L03:
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 425
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(Int32, System.__Canon, System.Collections.Generic.InsertionBehavior)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rsi,rcx
       mov       edi,edx
       mov       rbx,r8
       mov       ebp,r9d
       cmp       qword ptr [rsi+8],0
       jne       short M03_L00
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFB0D975AE0]
M03_L00:
       mov       r14,[rsi+10]
       mov       r15,[rsi+18]
       test      r15,r15
       jne       near ptr M03_L20
       mov       r12d,edi
M03_L01:
       xor       r13d,r13d
       mov       rdx,[rsi+8]
       mov       ecx,[rdx+8]
       mov       eax,ecx
       mov       r8,[rsi+30]
       mov       r9d,r12d
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       eax,eax
       imul      rax,r8
       shr       rax,20
       cmp       eax,ecx
       jae       near ptr M03_L21
       movsxd    rcx,eax
       lea       rax,[rdx+rcx*4+10]
       mov       r8d,[rax]
       dec       r8d
       test      r15,r15
       jne       near ptr M03_L13
M03_L02:
       cmp       [r14+8],r8d
       ja        short M03_L07
M03_L03:
       cmp       dword ptr [rsi+40],0
       jg        near ptr M03_L10
       mov       r15d,[rsi+38]
       cmp       [r14+8],r15d
       je        near ptr M03_L09
M03_L04:
       lea       edx,[r15+1]
       mov       [rsi+38],edx
       mov       r14,[rsi+10]
M03_L05:
       cmp       r15d,[r14+8]
       jae       near ptr M03_L21
       movsxd    rdx,r15d
       lea       rdx,[rdx+rdx*2]
       lea       rcx,[r14+rdx*8+10]
       mov       [rcx+8],r12d
       mov       [rsp+28],rax
       mov       edx,[rax]
       dec       edx
       mov       [rcx+0C],edx
       mov       [rcx+10],edi
       mov       rdx,rbx
       call      qword ptr [7FFB0D970590]
       inc       r15d
       mov       rbx,[rsp+28]
       mov       [rbx],r15d
       inc       dword ptr [rsi+44]
M03_L06:
       mov       eax,1
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L07:
       movsxd    rcx,r8d
       lea       rcx,[rcx+rcx*2]
       lea       r15,[r14+rcx*8+10]
       cmp       [r15+8],r12d
       mov       [rsp+34],r8d
       je        near ptr M03_L11
M03_L08:
       mov       r8d,[r15+0C]
       inc       r13d
       cmp       [r14+8],r13d
       jb        near ptr M03_L19
       jmp       near ptr M03_L02
M03_L09:
       mov       ecx,[rsi+38]
       call      qword ptr [7FFB0D974AE0]
       mov       edx,eax
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFB0D975AF0]
       mov       rax,[rsi+8]
       mov       edx,[rax+8]
       mov       ecx,edx
       mov       r8,[rsi+30]
       mov       r9d,r12d
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       ecx,ecx
       imul      rcx,r8
       shr       rcx,20
       cmp       ecx,edx
       jae       near ptr M03_L21
       movsxd    rdx,ecx
       lea       rax,[rax+rdx*4+10]
       mov       [rsp+28],rax
       mov       rax,[rsp+28]
       jmp       near ptr M03_L04
M03_L10:
       mov       edx,[rsi+3C]
       mov       r15d,edx
       cmp       edx,[r14+8]
       jae       near ptr M03_L21
       movsxd    rdx,edx
       lea       rdx,[rdx+rdx*2]
       mov       edx,[r14+rdx*8+1C]
       neg       edx
       add       edx,0FFFFFFFD
       mov       [rsi+3C],edx
       dec       dword ptr [rsi+40]
       jmp       near ptr M03_L05
M03_L11:
       mov       [rsp+28],rax
       call      qword ptr [7FFB0D971340]
       mov       rdx,[rax]
       mov       ecx,[r15+10]
       cmp       [rdx],edx
       cmp       ecx,edi
       sete      dl
       movzx     edx,dl
       test      edx,edx
       mov       rax,[rsp+28]
       je        near ptr M03_L08
       mov       r8d,[rsp+34]
       cmp       bpl,1
       jne       short M03_L12
       movsxd    rdx,r8d
       lea       rdx,[rdx+rdx*2]
       lea       rcx,[r14+rdx*8+10]
       mov       rdx,rbx
       call      qword ptr [7FFB0D970588]
       jmp       near ptr M03_L06
M03_L12:
       cmp       bpl,2
       jne       near ptr M03_L17
       jmp       near ptr M03_L16
M03_L13:
       cmp       [r14+8],r8d
       jbe       near ptr M03_L03
       movsxd    rdx,r8d
       lea       rdx,[rdx+rdx*2]
       cmp       [r14+rdx*8+18],r12d
       jne       near ptr M03_L18
       mov       [rsp+28],rax
       mov       [rsp+34],r8d
       movsxd    rdx,r8d
       lea       rdx,[rdx+rdx*2]
       mov       edx,[r14+rdx*8+20]
       mov       rcx,r15
       mov       r8d,edi
       lea       r11,[7FFB0D96FDC0]
       call      qword ptr [7FFB0D96FDC0]
       test      al,al
       mov       rax,[rsp+28]
       je        short M03_L14
       cmp       bpl,1
       jne       short M03_L15
       mov       esi,[rsp+34]
       movsxd    rdx,esi
       lea       rdx,[rdx+rdx*2]
       lea       rcx,[r14+rdx*8+10]
       mov       rdx,rbx
       call      qword ptr [7FFB0D970588]
       jmp       near ptr M03_L06
M03_L14:
       mov       r8d,[rsp+34]
       jmp       short M03_L18
M03_L15:
       cmp       bpl,2
       jne       short M03_L17
M03_L16:
       mov       ecx,edi
       call      qword ptr [7FFB0D969248]
       int       3
M03_L17:
       xor       eax,eax
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L18:
       movsxd    r8,r8d
       lea       rdx,[r8+r8*2]
       mov       r8d,[r14+rdx*8+1C]
       inc       r13d
       cmp       [r14+8],r13d
       jae       near ptr M03_L13
M03_L19:
       call      qword ptr [7FFB0D96D150]
       int       3
M03_L20:
       mov       rcx,r15
       mov       edx,edi
       lea       r11,[7FFB0D96FDC8]
       call      qword ptr [7FFB0D96FDC8]
       mov       r12d,eax
       jmp       near ptr M03_L01
M03_L21:
       call      qword ptr [7FFB0D970578]
       int       3
; Total bytes of code 760
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.BytesToString(System.ReadOnlySpan`1<Byte>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       vzeroupper
       mov       rsi,rcx
       mov       rcx,rsi
       vmovdqu   xmm0,xmmword ptr [rsi]
       vmovdqu   xmmword ptr [rsp+20],xmm0
       lea       rdx,[rsp+20]
       mov       r8,243DBA25608
       mov       r9,[r8]
       mov       r8,r9
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotEmpty[[System.Byte, System.Private.CoreLib]](System.ReadOnlySpan`1<Byte>, System.String, System.String)
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       edx,[rsi+8]
       mov       rcx,rdi
       mov       r8d,7FFFFFFF
       call      System.Text.StringBuilder..ctor(Int32, Int32)
       xor       ebx,ebx
       cmp       dword ptr [rsi+8],0
       jle       short M04_L01
       mov       rdx,243DBA21568
       mov       rbp,[rdx]
       mov       rdx,243BBA22C08
       mov       r14,[rdx]
M04_L00:
       cmp       ebx,[rsi+8]
       jae       short M04_L03
       movsxd    rdx,ebx
       add       rdx,[rsi]
       mov       r8,rbp
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r14
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|42_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       add       ebx,1
       jo        short M04_L02
       cmp       ebx,[rsi+8]
       jl        short M04_L00
M04_L01:
       mov       rcx,rdi
       call      qword ptr [7FFAAF3A78C0]
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M04_L02:
       call      CORINFO_HELP_OVERFLOW
       int       3
M04_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 203
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowKeyNotFoundException[[System.Int32, System.Private.CoreLib]](Int32)

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.BytesToString02()
; 			var readOnlySpan = new ReadOnlySpan<byte>(base.GetByteArray(1));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = readOnlySpan.BytesToString();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,38
       vzeroupper
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rax
       mov       rsi,rcx
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       mov       edx,1
       call      System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       test      rax,rax
       jne       short M00_L00
       mov       rdi,[rsi+8]
       vmovsd    xmm0,qword ptr [7FFAAF3C7E40]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       mov       r8,rax
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,1
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(Int32, System.__Canon, System.Collections.Generic.InsertionBehavior)
M00_L00:
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       mov       edx,1
       call      System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       test      rax,rax
       je        short M00_L03
       mov       rcx,[rax]
       test      rcx,rcx
       je        short M00_L02
       lea       rax,[rcx+10]
       mov       ecx,[rcx+8]
M00_L01:
       mov       [rsp+28],rax
       mov       [rsp+30],ecx
       lea       rcx,[rsp+28]
       call      DotNetTips.Spargine.Extensions.ArrayExtensions.BytesToString(System.ReadOnlySpan`1<Byte>)
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,38
       pop       rsi
       pop       rdi
       ret
M00_L02:
       xor       eax,eax
       xor       ecx,ecx
       jmp       short M00_L01
M00_L03:
       mov       ecx,1
       call      System.ThrowHelper.ThrowKeyNotFoundException[[System.Int32, System.Private.CoreLib]](Int32)
       int       3
; Total bytes of code 184
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       edi,edx
       mov       rax,[rsi]
       mov       rax,[rax+30]
       mov       rbx,[rax]
       cmp       qword ptr [rsi+8],0
       jne       short M01_L01
M01_L00:
       cmp       qword ptr [rbx+28],0
       je        near ptr M01_L05
       jmp       near ptr M01_L05
M01_L01:
       mov       rbp,[rsi+18]
       test      rbp,rbp
       jne       near ptr M01_L06
       mov       eax,edi
       mov       rcx,[rsi+8]
       mov       edx,[rcx+8]
       mov       r11d,edx
       mov       r8,[rsi+30]
       mov       r9d,eax
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       r11d,r11d
       imul      r11,r8
       shr       r11,20
       cmp       r11d,edx
       jae       near ptr M01_L11
       movsxd    rdx,r11d
       lea       rcx,[rcx+rdx*4+10]
       mov       ecx,[rcx]
       mov       rdx,[rsi+10]
       xor       r11d,r11d
       dec       ecx
       mov       r8d,[rdx+8]
M01_L02:
       cmp       r8d,ecx
       jbe       short M01_L00
       movsxd    rcx,ecx
       lea       rcx,[rcx+rcx*2]
       lea       r14,[rdx+rcx*8+10]
       cmp       [r14+8],edi
       jne       short M01_L03
       mov       ecx,[r14+10]
       cmp       ecx,eax
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       short M01_L04
M01_L03:
       mov       ecx,[r14+0C]
       inc       r11d
       cmp       r8d,r11d
       jb        near ptr M01_L09
       jmp       short M01_L02
M01_L04:
       mov       rax,r14
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L05:
       xor       r14d,r14d
       jmp       short M01_L04
M01_L06:
       mov       rcx,rbp
       mov       edx,edi
       mov       r11,7FFAAEE006E0
       call      qword ptr [7FFAAF3D06E0]
       mov       r14d,eax
       mov       rdx,[rsi+8]
       mov       ecx,[rdx+8]
       mov       r8,[rsi+30]
       mov       r11d,r14d
       imul      r8,r11
       shr       r8,20
       inc       r8
       mov       ecx,ecx
       imul      rcx,r8
       shr       rcx,20
       cmp       ecx,[rdx+8]
       jae       short M01_L11
       movsxd    rcx,ecx
       lea       rdx,[rdx+rcx*4+10]
       mov       r15d,[rdx]
       mov       r12,[rsi+10]
       xor       r13d,r13d
       dec       r15d
M01_L07:
       cmp       [r12+8],r15d
       jbe       near ptr M01_L00
       movsxd    rdx,r15d
       lea       rdx,[rdx+rdx*2]
       lea       rdx,[r12+rdx*8+10]
       mov       r15,rdx
       cmp       [r15+8],r14d
       jne       short M01_L08
       mov       edx,[r15+10]
       mov       rcx,rbp
       mov       r8d,edi
       mov       r11,7FFAAEE006E8
       call      qword ptr [7FFAAF3D06E8]
       test      eax,eax
       jne       short M01_L10
M01_L08:
       mov       r15d,[r15+0C]
       inc       r13d
       cmp       [r12+8],r13d
       jae       short M01_L07
M01_L09:
       call      System.ThrowHelper.ThrowInvalidOperationException_ConcurrentOperationsNotSupported()
       int       3
M01_L10:
       mov       r14,r15
       jmp       near ptr M01_L04
M01_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 408
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       push      rbp
       sub       rsp,0A0
       vzeroupper
       lea       rbp,[rsp+0A0]
       xor       eax,eax
       mov       [rbp+0FF98],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFA0
M02_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M02_L00
       mov       [rbp+0FF88],rsp
       vmovsd    qword ptr [rbp+10],xmm0
       call      System.Globalization.CultureInfo.get_InvariantCulture()
       mov       [rbp+0FFD8],rax
       mov       rcx,offset MT_System.Double
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp+0FFD0],rax
       call      DotNetTips.Spargine.Tester.Properties.Resources.get_SizeMustBeEpsilon()
       mov       [rbp+0FFC8],rax
       mov       r8,[rbp+0FFD0]
       mov       qword ptr [r8+8],1
       mov       r8,[rbp+0FFD0]
       mov       rcx,[rbp+0FFD8]
       mov       rdx,[rbp+0FFC8]
       call      System.String.Format(System.IFormatProvider, System.String, System.Object)
       mov       [rbp+0FFC0],rax
       mov       r9,1EF6C6A5910
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,[rbp+0FFC0]
       vmovsd    xmm2,qword ptr [rbp+10]
       vucomisd  xmm2,qword ptr [7FFAAF1C8A38]
       setae     dl
       movzx     edx,dl
       vxorps    xmm2,xmm2,xmm2
       vmovsd    xmm0,qword ptr [rbp+10]
       call      DotNetTips.Spargine.Core.Validator.ArgumentMeetsCondition[[System.Double, System.Private.CoreLib]](Double, Boolean, Double, System.String, System.String)
       vmovsd    qword ptr [rbp+10],xmm0
       vmovsd    xmm0,qword ptr [rbp+10]
       vmulsd    xmm0,xmm0,qword ptr [7FFAAF1C8A40]
       call      System.Convert.ToInt32(Double)
       movsxd    rdx,eax
       mov       [rbp+0FFB8],rdx
       mov       rdx,[rbp+0FFB8]
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp+0FFB0],rax
       mov       rdx,[rbp+0FFB0]
       lea       rcx,[rbp+0FFF0]
       call      System.Span`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte[])
       mov       rdx,1EF9C6A7448
       mov       rdx,[rdx]
       mov       [rbp+0FFE8],rdx
       xor       edx,edx
       mov       [rbp+0FFE0],edx
       lea       rdx,[rbp+0FFE0]
       mov       rcx,[rbp+0FFE8]
       call      System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,1EF9C6A7450
       mov       rcx,[rcx]
       mov       [rbp+0FF98],rcx
       vmovdqu   xmm0,xmmword ptr [rbp+0FFF0]
       vmovdqu   xmmword ptr [rbp+0FFA0],xmm0
       mov       rcx,[rbp+0FF98]
       lea       rdx,[rbp+0FFA0]
       mov       rax,[rbp+0FF98]
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       jmp       short M02_L01
M02_L01:
       mov       rcx,rsp
       call      M02_L02
       nop
       lea       rcx,[rbp+0FFF0]
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].ToArray()
       nop
       add       rsp,0A0
       pop       rbp
       ret
M02_L02:
       push      rbp
       sub       rsp,30
       vzeroupper
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+0A0]
       mov       ecx,[rbp+0FFE0]
       movzx     ecx,cl
       test      ecx,ecx
       je        short M02_L03
       mov       rcx,[rbp+0FFE8]
       call      System.Threading.Monitor.Exit(System.Object)
M02_L03:
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 425
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(Int32, System.__Canon, System.Collections.Generic.InsertionBehavior)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rsi,rcx
       mov       edi,edx
       mov       rbx,r8
       mov       ebp,r9d
       cmp       qword ptr [rsi+8],0
       jne       short M03_L00
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFB0D975AE0]
M03_L00:
       mov       r14,[rsi+10]
       mov       r15,[rsi+18]
       test      r15,r15
       jne       near ptr M03_L20
       mov       r12d,edi
M03_L01:
       xor       r13d,r13d
       mov       rdx,[rsi+8]
       mov       ecx,[rdx+8]
       mov       eax,ecx
       mov       r8,[rsi+30]
       mov       r9d,r12d
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       eax,eax
       imul      rax,r8
       shr       rax,20
       cmp       eax,ecx
       jae       near ptr M03_L21
       movsxd    rcx,eax
       lea       rax,[rdx+rcx*4+10]
       mov       r8d,[rax]
       dec       r8d
       test      r15,r15
       jne       near ptr M03_L13
M03_L02:
       cmp       [r14+8],r8d
       ja        short M03_L07
M03_L03:
       cmp       dword ptr [rsi+40],0
       jg        near ptr M03_L10
       mov       r15d,[rsi+38]
       cmp       [r14+8],r15d
       je        near ptr M03_L09
M03_L04:
       lea       edx,[r15+1]
       mov       [rsi+38],edx
       mov       r14,[rsi+10]
M03_L05:
       cmp       r15d,[r14+8]
       jae       near ptr M03_L21
       movsxd    rdx,r15d
       lea       rdx,[rdx+rdx*2]
       lea       rcx,[r14+rdx*8+10]
       mov       [rcx+8],r12d
       mov       [rsp+28],rax
       mov       edx,[rax]
       dec       edx
       mov       [rcx+0C],edx
       mov       [rcx+10],edi
       mov       rdx,rbx
       call      qword ptr [7FFB0D970590]
       inc       r15d
       mov       rbx,[rsp+28]
       mov       [rbx],r15d
       inc       dword ptr [rsi+44]
M03_L06:
       mov       eax,1
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L07:
       movsxd    rcx,r8d
       lea       rcx,[rcx+rcx*2]
       lea       r15,[r14+rcx*8+10]
       cmp       [r15+8],r12d
       mov       [rsp+34],r8d
       je        near ptr M03_L11
M03_L08:
       mov       r8d,[r15+0C]
       inc       r13d
       cmp       [r14+8],r13d
       jb        near ptr M03_L19
       jmp       near ptr M03_L02
M03_L09:
       mov       ecx,[rsi+38]
       call      qword ptr [7FFB0D974AE0]
       mov       edx,eax
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFB0D975AF0]
       mov       rax,[rsi+8]
       mov       edx,[rax+8]
       mov       ecx,edx
       mov       r8,[rsi+30]
       mov       r9d,r12d
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       ecx,ecx
       imul      rcx,r8
       shr       rcx,20
       cmp       ecx,edx
       jae       near ptr M03_L21
       movsxd    rdx,ecx
       lea       rax,[rax+rdx*4+10]
       mov       [rsp+28],rax
       mov       rax,[rsp+28]
       jmp       near ptr M03_L04
M03_L10:
       mov       edx,[rsi+3C]
       mov       r15d,edx
       cmp       edx,[r14+8]
       jae       near ptr M03_L21
       movsxd    rdx,edx
       lea       rdx,[rdx+rdx*2]
       mov       edx,[r14+rdx*8+1C]
       neg       edx
       add       edx,0FFFFFFFD
       mov       [rsi+3C],edx
       dec       dword ptr [rsi+40]
       jmp       near ptr M03_L05
M03_L11:
       mov       [rsp+28],rax
       call      qword ptr [7FFB0D971340]
       mov       rdx,[rax]
       mov       ecx,[r15+10]
       cmp       [rdx],edx
       cmp       ecx,edi
       sete      dl
       movzx     edx,dl
       test      edx,edx
       mov       rax,[rsp+28]
       je        near ptr M03_L08
       mov       r8d,[rsp+34]
       cmp       bpl,1
       jne       short M03_L12
       movsxd    rdx,r8d
       lea       rdx,[rdx+rdx*2]
       lea       rcx,[r14+rdx*8+10]
       mov       rdx,rbx
       call      qword ptr [7FFB0D970588]
       jmp       near ptr M03_L06
M03_L12:
       cmp       bpl,2
       jne       near ptr M03_L17
       jmp       near ptr M03_L16
M03_L13:
       cmp       [r14+8],r8d
       jbe       near ptr M03_L03
       movsxd    rdx,r8d
       lea       rdx,[rdx+rdx*2]
       cmp       [r14+rdx*8+18],r12d
       jne       near ptr M03_L18
       mov       [rsp+28],rax
       mov       [rsp+34],r8d
       movsxd    rdx,r8d
       lea       rdx,[rdx+rdx*2]
       mov       edx,[r14+rdx*8+20]
       mov       rcx,r15
       mov       r8d,edi
       lea       r11,[7FFB0D96FDC0]
       call      qword ptr [7FFB0D96FDC0]
       test      al,al
       mov       rax,[rsp+28]
       je        short M03_L14
       cmp       bpl,1
       jne       short M03_L15
       mov       esi,[rsp+34]
       movsxd    rdx,esi
       lea       rdx,[rdx+rdx*2]
       lea       rcx,[r14+rdx*8+10]
       mov       rdx,rbx
       call      qword ptr [7FFB0D970588]
       jmp       near ptr M03_L06
M03_L14:
       mov       r8d,[rsp+34]
       jmp       short M03_L18
M03_L15:
       cmp       bpl,2
       jne       short M03_L17
M03_L16:
       mov       ecx,edi
       call      qword ptr [7FFB0D969248]
       int       3
M03_L17:
       xor       eax,eax
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L18:
       movsxd    r8,r8d
       lea       rdx,[r8+r8*2]
       mov       r8d,[r14+rdx*8+1C]
       inc       r13d
       cmp       [r14+8],r13d
       jae       near ptr M03_L13
M03_L19:
       call      qword ptr [7FFB0D96D150]
       int       3
M03_L20:
       mov       rcx,r15
       mov       edx,edi
       lea       r11,[7FFB0D96FDC8]
       call      qword ptr [7FFB0D96FDC8]
       mov       r12d,eax
       jmp       near ptr M03_L01
M03_L21:
       call      qword ptr [7FFB0D970578]
       int       3
; Total bytes of code 760
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.BytesToString(System.ReadOnlySpan`1<Byte>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       vzeroupper
       mov       rsi,rcx
       mov       rcx,rsi
       vmovdqu   xmm0,xmmword ptr [rsi]
       vmovdqu   xmmword ptr [rsp+20],xmm0
       lea       rdx,[rsp+20]
       mov       r8,1EF8C6A1200
       mov       r9,[r8]
       mov       r8,r9
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotEmpty[[System.Byte, System.Private.CoreLib]](System.ReadOnlySpan`1<Byte>, System.String, System.String)
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       edx,[rsi+8]
       mov       rcx,rdi
       mov       r8d,7FFFFFFF
       call      System.Text.StringBuilder..ctor(Int32, Int32)
       xor       ebx,ebx
       cmp       dword ptr [rsi+8],0
       jle       short M04_L01
       mov       rdx,1EF6C6A1568
       mov       rbp,[rdx]
       mov       rdx,1EF6C6A5FF8
       mov       r14,[rdx]
M04_L00:
       cmp       ebx,[rsi+8]
       jae       short M04_L03
       movsxd    rdx,ebx
       add       rdx,[rsi]
       mov       r8,rbp
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r14
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|42_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       add       ebx,1
       jo        short M04_L02
       cmp       ebx,[rsi+8]
       jl        short M04_L00
M04_L01:
       mov       rcx,rdi
       call      qword ptr [7FFAAF3C78C0]
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M04_L02:
       call      CORINFO_HELP_OVERFLOW
       int       3
M04_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 203
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowKeyNotFoundException[[System.Int32, System.Private.CoreLib]](Int32)

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.Clone03()
; 			var result = base.GetCoordinateArray().Clone<Coordinate[]>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+0B8]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 73
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       mov       rax,250CA793020
       mov       rbx,[rax]
       mov       rax,250EA7915C8
       mov       rbp,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,rbp
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFAAF2D0570
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
; Total bytes of code 148
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.Clone03()
; 			var result = base.GetCoordinateArray().Clone<Coordinate[]>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+0B8]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 73
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       mov       rax,216C8F23020
       mov       rbx,[rax]
       mov       rax,216D8F215C8
       mov       rbp,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,rbp
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFAAF2F0570
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
; Total bytes of code 148
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.Clone03()
; 			var result = base.GetCoordinateArray().Clone<Coordinate[]>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+0B8]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 73
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       mov       rax,125EC493020
       mov       rbx,[rax]
       mov       rax,125EC4959D0
       mov       rbp,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,rbp
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFAAF2D0570
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
; Total bytes of code 148
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.Clone03()
; 			var result = base.GetCoordinateArray().Clone<Coordinate[]>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+0B8]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 73
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       mov       rax,17C187D1028
       mov       rbx,[rax]
       mov       rax,17C387D15C8
       mov       rbp,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,rbp
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFAAF2F0570
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
; Total bytes of code 148
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.Clone03()
; 			var result = base.GetCoordinateArray().Clone<Coordinate[]>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+0B8]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 73
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       mov       rax,18313E53020
       mov       rbx,[rax]
       mov       rax,18333E515C8
       mov       rbp,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,rbp
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFAAF2D0570
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
; Total bytes of code 148
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.Clone03()
; 			var result = base.GetCoordinateArray().Clone<Coordinate[]>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+0B8]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 73
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       mov       rax,2127ECF3020
       mov       rbx,[rax]
       mov       rax,2129ECFD9F8
       mov       rbp,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,rbp
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFAAF2C0570
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
; Total bytes of code 148
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.Clone03()
; 			var result = base.GetCoordinateArray().Clone<Coordinate[]>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+0B8]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 73
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       mov       rax,2967C831028
       mov       rbx,[rax]
       mov       rax,2968C8315C8
       mov       rbp,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,rbp
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFAAF2E0570
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
; Total bytes of code 148
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.Clone03()
; 			var result = base.GetCoordinateArray().Clone<Coordinate[]>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+0B8]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 73
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       mov       rax,2DFD6E43020
       mov       rbx,[rax]
       mov       rax,2DFD6E51E00
       mov       rbp,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,rbp
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFAAF2F0570
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
; Total bytes of code 148
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.Clone01()
; 			var result = base.GetPersonProperArray(Tristate.False).Clone<PersonProper[]>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 55
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       mov       rax,21D1D143020
       mov       rbx,[rax]
       mov       rax,21D3D1415C8
       mov       rbp,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,rbp
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFAAF2D0570
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
; Total bytes of code 148
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.Clone01()
; 			var result = base.GetPersonProperArray(Tristate.False).Clone<PersonProper[]>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 55
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       mov       rax,12513DC3020
       mov       rbx,[rax]
       mov       rax,12513DC59D0
       mov       rbp,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,rbp
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFAAF2C0570
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
; Total bytes of code 148
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.Clone01()
; 			var result = base.GetPersonProperArray(Tristate.False).Clone<PersonProper[]>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 55
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       mov       rax,252F3C41028
       mov       rbx,[rax]
       mov       rax,252F3C4FE08
       mov       rbp,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,rbp
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFAAF2C0570
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
; Total bytes of code 148
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.Clone01()
; 			var result = base.GetPersonProperArray(Tristate.False).Clone<PersonProper[]>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 55
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       mov       rax,1C4D5711028
       mov       rbx,[rax]
       mov       rax,1C4F57135C0
       mov       rbp,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,rbp
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFAAF2E0570
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
; Total bytes of code 148
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.Clone01()
; 			var result = base.GetPersonProperArray(Tristate.False).Clone<PersonProper[]>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 55
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       mov       rax,2D5F8AD3020
       mov       rbx,[rax]
       mov       rax,2D618AD15C8
       mov       rbp,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,rbp
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFAAF2C0570
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
; Total bytes of code 148
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.Clone01()
; 			var result = base.GetPersonProperArray(Tristate.False).Clone<PersonProper[]>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 55
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       mov       rax,244AFC33020
       mov       rbx,[rax]
       mov       rax,244AFC41E00
       mov       rbp,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,rbp
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFAAF300570
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
; Total bytes of code 148
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.Clone01()
; 			var result = base.GetPersonProperArray(Tristate.False).Clone<PersonProper[]>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 55
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       mov       rax,1EB0B061028
       mov       rbx,[rax]
       mov       rax,1EB2B0635C0
       mov       rbp,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,rbp
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFAAF300570
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
; Total bytes of code 148
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.Clone01()
; 			var result = base.GetPersonProperArray(Tristate.False).Clone<PersonProper[]>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 55
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       mov       rax,1ECE7AE3020
       mov       rbx,[rax]
       mov       rax,1ECE7AF1E00
       mov       rbp,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,rbp
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFAAF2D0570
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
; Total bytes of code 148
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.Clone02()
; 			var result = base.GetPersonRecordArray(Tristate.False).Clone<PersonRecord[]>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+120]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 55
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       mov       rax,1EA692E1028
       mov       rbx,[rax]
       mov       rax,1EA792E15C8
       mov       rbp,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,rbp
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFAAF2F0570
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
; Total bytes of code 148
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.Clone02()
; 			var result = base.GetPersonRecordArray(Tristate.False).Clone<PersonRecord[]>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+120]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 55
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       mov       rax,1873C781028
       mov       rbx,[rax]
       mov       rax,1875C7835C0
       mov       rbp,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,rbp
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFAAF2E0570
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
; Total bytes of code 148
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.Clone02()
; 			var result = base.GetPersonRecordArray(Tristate.False).Clone<PersonRecord[]>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+120]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 55
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       mov       rax,1B9090B1028
       mov       rbx,[rax]
       mov       rax,1B8F90B35C0
       mov       rbp,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,rbp
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFAAF2D0570
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
; Total bytes of code 148
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.Clone02()
; 			var result = base.GetPersonRecordArray(Tristate.False).Clone<PersonRecord[]>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+120]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 55
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       mov       rax,2282EDF3020
       mov       rbx,[rax]
       mov       rax,2284EDF15C8
       mov       rbp,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,rbp
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFAAF300570
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
; Total bytes of code 148
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.Clone02()
; 			var result = base.GetPersonRecordArray(Tristate.False).Clone<PersonRecord[]>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+120]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 55
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       mov       rax,1576E563020
       mov       rbx,[rax]
       mov       rax,1576E571E00
       mov       rbp,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,rbp
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFAAF2E0570
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
; Total bytes of code 148
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.Clone02()
; 			var result = base.GetPersonRecordArray(Tristate.False).Clone<PersonRecord[]>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+120]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 55
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       mov       rax,2142FB43020
       mov       rbx,[rax]
       mov       rax,2144FB4D9F8
       mov       rbp,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,rbp
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFAAF2C0570
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
; Total bytes of code 148
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.Clone02()
; 			var result = base.GetPersonRecordArray(Tristate.False).Clone<PersonRecord[]>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+120]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 55
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       mov       rax,19A729B1028
       mov       rbx,[rax]
       mov       rax,19A829B35C0
       mov       rbp,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,rbp
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFAAF2D0570
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
; Total bytes of code 148
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.Clone02()
; 			var result = base.GetPersonRecordArray(Tristate.False).Clone<PersonRecord[]>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+120]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 55
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       mov       rax,20B49053020
       mov       rbx,[rax]
       mov       rax,20B49061E00
       mov       rbp,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,rbp
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFAAF300570
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
; Total bytes of code 148
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AddFirst01()
; 			var people = this.GetPersonProperArray().Clone<List<PersonProper>>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.ToArray().AddFirst(this.PersonProper01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rcx,rax
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       mov       rdx,rax
       mov       r8,[rsi+28]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddFirst(!!0[], !!0)
       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddFirst[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 105
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       mov       rax,20DE9E33020
       mov       rbx,[rax]
       mov       rax,20E09E35A60
       mov       rbp,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,rbp
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFAAF2D1DF8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
; Total bytes of code 148
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       edi,[rsi+10]
       test      edi,edi
       je        short M02_L00
       mov       ebx,edi
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+58]
       test      rdx,rdx
       je        short M02_L03
       mov       [rsp+20],rdx
       jmp       short M02_L04
M02_L00:
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+50]
       test      rdx,rdx
       je        short M02_L01
       jmp       short M02_L02
M02_L01:
       mov       rdx,7FFAAF4A7B98
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M02_L02:
       mov       rcx,rdx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rdx,7FFAAF4A7BA8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rsp+20],rax
M02_L04:
       movsxd    rdx,ebx
       mov       rcx,[rsp+20]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       mov       rcx,[rsi+8]
       mov       r8d,edi
       mov       rdx,rbx
       call      System.Array.Copy(System.Array, System.Array, Int32)
       mov       rax,rbx
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 170
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.AddFirst[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rbx,r8
       mov       rbp,[rdi+10]
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L00
       mov       rax,20DE9E33020
       mov       r14,[rax]
       mov       rax,20E09E35698
       mov       r15,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r15
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L00:
       test      rbx,rbx
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L01
       mov       rax,20DE9E33020
       mov       r14,[rax]
       mov       rax,20E09E368B0
       mov       r15,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r15
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L01:
       mov       r14d,[rsi+8]
       add       r14d,1
       jo        near ptr M03_L05
       cmp       qword ptr [rbp+20],0
       je        short M03_L02
       mov       rcx,[rbp+20]
       jmp       short M03_L03
M03_L02:
       mov       rcx,rdi
       mov       rdx,7FFAAF4A1A80
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L03:
       movsxd    rdx,r14d
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,rdi
       mov       r8,rbx
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       mov       rcx,[rdi]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       je        short M03_L04
       cmp       ecx,1
       jne       short M03_L06
M03_L04:
       mov       rcx,rsi
       xor       edx,edx
       call      System.Array.GetLowerBound(Int32)
       mov       edx,eax
       mov       ecx,[rsi+8]
       test      ecx,ecx
       jl        short M03_L05
       mov       [rsp+20],ecx
       mov       rcx,rsi
       mov       r8,rdi
       mov       r9d,1
       call      System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       rax,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L05:
       call      CORINFO_HELP_OVERFLOW
M03_L06:
       mov       ecx,7
       call      System.ThrowHelper.ThrowArgumentException(System.ExceptionResource)
       int       3
; Total bytes of code 325
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AddFirst01()
; 			var people = this.GetPersonProperArray().Clone<List<PersonProper>>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.ToArray().AddFirst(this.PersonProper01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rcx,rax
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       mov       rdx,rax
       mov       r8,[rsi+28]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddFirst(!!0[], !!0)
       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddFirst[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 105
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       mov       rax,237CE5D3020
       mov       rbx,[rax]
       mov       rax,237EE5D15C8
       mov       rbp,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,rbp
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFAAF2E0570
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
; Total bytes of code 148
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       edi,[rsi+10]
       test      edi,edi
       je        short M02_L00
       mov       ebx,edi
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+58]
       test      rdx,rdx
       je        short M02_L03
       mov       [rsp+20],rdx
       jmp       short M02_L04
M02_L00:
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+50]
       test      rdx,rdx
       je        short M02_L01
       jmp       short M02_L02
M02_L01:
       mov       rdx,7FFAAF4AFF00
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M02_L02:
       mov       rcx,rdx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rdx,7FFAAF4AFF10
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rsp+20],rax
M02_L04:
       movsxd    rdx,ebx
       mov       rcx,[rsp+20]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       mov       rcx,[rsi+8]
       mov       r8d,edi
       mov       rdx,rbx
       call      System.Array.Copy(System.Array, System.Array, Int32)
       mov       rax,rbx
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 170
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.AddFirst[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rbx,r8
       mov       rbp,[rdi+10]
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L00
       mov       rax,237CE5D3020
       mov       r14,[rax]
       mov       rax,237EE5D1200
       mov       r15,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r15
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L00:
       test      rbx,rbx
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L01
       mov       rax,237CE5D3020
       mov       r14,[rax]
       mov       rax,237EE5D3430
       mov       r15,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r15
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L01:
       mov       r14d,[rsi+8]
       add       r14d,1
       jo        near ptr M03_L05
       cmp       qword ptr [rbp+20],0
       je        short M03_L02
       mov       rcx,[rbp+20]
       jmp       short M03_L03
M03_L02:
       mov       rcx,rdi
       mov       rdx,7FFAAF4A1A98
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L03:
       movsxd    rdx,r14d
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,rdi
       mov       r8,rbx
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       mov       rcx,[rdi]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       je        short M03_L04
       cmp       ecx,1
       jne       short M03_L06
M03_L04:
       mov       rcx,rsi
       xor       edx,edx
       call      System.Array.GetLowerBound(Int32)
       mov       edx,eax
       mov       ecx,[rsi+8]
       test      ecx,ecx
       jl        short M03_L05
       mov       [rsp+20],ecx
       mov       rcx,rsi
       mov       r8,rdi
       mov       r9d,1
       call      System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       rax,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L05:
       call      CORINFO_HELP_OVERFLOW
M03_L06:
       mov       ecx,7
       call      System.ThrowHelper.ThrowArgumentException(System.ExceptionResource)
       int       3
; Total bytes of code 325
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AddFirst01()
; 			var people = this.GetPersonProperArray().Clone<List<PersonProper>>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.ToArray().AddFirst(this.PersonProper01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rcx,rax
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       mov       rdx,rax
       mov       r8,[rsi+28]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddFirst(!!0[], !!0)
       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddFirst[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 105
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       mov       rax,2E45A2F3020
       mov       rbx,[rax]
       mov       rax,2E44A2F15C8
       mov       rbp,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,rbp
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFAAF2C0570
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
; Total bytes of code 148
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       edi,[rsi+10]
       test      edi,edi
       je        short M02_L00
       mov       ebx,edi
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+58]
       test      rdx,rdx
       je        short M02_L03
       mov       [rsp+20],rdx
       jmp       short M02_L04
M02_L00:
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+50]
       test      rdx,rdx
       je        short M02_L01
       jmp       short M02_L02
M02_L01:
       mov       rdx,7FFAAF48FD58
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M02_L02:
       mov       rcx,rdx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rdx,7FFAAF48FD68
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rsp+20],rax
M02_L04:
       movsxd    rdx,ebx
       mov       rcx,[rsp+20]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       mov       rcx,[rsi+8]
       mov       r8d,edi
       mov       rdx,rbx
       call      System.Array.Copy(System.Array, System.Array, Int32)
       mov       rax,rbx
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 170
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.AddFirst[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rbx,r8
       mov       rbp,[rdi+10]
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L00
       mov       rax,2E45A2F3020
       mov       r14,[rax]
       mov       rax,2E44A2F1200
       mov       r15,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r15
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L00:
       test      rbx,rbx
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L01
       mov       rax,2E45A2F3020
       mov       r14,[rax]
       mov       rax,2E44A2F2418
       mov       r15,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r15
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L01:
       mov       r14d,[rsi+8]
       add       r14d,1
       jo        near ptr M03_L05
       cmp       qword ptr [rbp+20],0
       je        short M03_L02
       mov       rcx,[rbp+20]
       jmp       short M03_L03
M03_L02:
       mov       rcx,rdi
       mov       rdx,7FFAAF481A98
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L03:
       movsxd    rdx,r14d
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,rdi
       mov       r8,rbx
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       mov       rcx,[rdi]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       je        short M03_L04
       cmp       ecx,1
       jne       short M03_L06
M03_L04:
       mov       rcx,rsi
       xor       edx,edx
       call      System.Array.GetLowerBound(Int32)
       mov       edx,eax
       mov       ecx,[rsi+8]
       test      ecx,ecx
       jl        short M03_L05
       mov       [rsp+20],ecx
       mov       rcx,rsi
       mov       r8,rdi
       mov       r9d,1
       call      System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       rax,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L05:
       call      CORINFO_HELP_OVERFLOW
M03_L06:
       mov       ecx,7
       call      System.ThrowHelper.ThrowArgumentException(System.ExceptionResource)
       int       3
; Total bytes of code 325
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AddFirst01()
; 			var people = this.GetPersonProperArray().Clone<List<PersonProper>>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.ToArray().AddFirst(this.PersonProper01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rcx,rax
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       mov       rdx,rax
       mov       r8,[rsi+28]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddFirst(!!0[], !!0)
       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddFirst[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 105
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       mov       rax,1C5E5813020
       mov       rbx,[rax]
       mov       rax,1C5F58115C8
       mov       rbp,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,rbp
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFAAF2D0570
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
; Total bytes of code 148
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       edi,[rsi+10]
       test      edi,edi
       je        short M02_L00
       mov       ebx,edi
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+58]
       test      rdx,rdx
       je        short M02_L03
       mov       [rsp+20],rdx
       jmp       short M02_L04
M02_L00:
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+50]
       test      rdx,rdx
       je        short M02_L01
       jmp       short M02_L02
M02_L01:
       mov       rdx,7FFAAF49FDC0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M02_L02:
       mov       rcx,rdx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rdx,7FFAAF49FDD0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rsp+20],rax
M02_L04:
       movsxd    rdx,ebx
       mov       rcx,[rsp+20]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       mov       rcx,[rsi+8]
       mov       r8d,edi
       mov       rdx,rbx
       call      System.Array.Copy(System.Array, System.Array, Int32)
       mov       rax,rbx
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 170
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.AddFirst[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rbx,r8
       mov       rbp,[rdi+10]
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L00
       mov       rax,1C5E5813020
       mov       r14,[rax]
       mov       rax,1C5F5811200
       mov       r15,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r15
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L00:
       test      rbx,rbx
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L01
       mov       rax,1C5E5813020
       mov       r14,[rax]
       mov       rax,1C5E5816008
       mov       r15,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r15
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L01:
       mov       r14d,[rsi+8]
       add       r14d,1
       jo        near ptr M03_L05
       cmp       qword ptr [rbp+20],0
       je        short M03_L02
       mov       rcx,[rbp+20]
       jmp       short M03_L03
M03_L02:
       mov       rcx,rdi
       mov       rdx,7FFAAF491A98
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L03:
       movsxd    rdx,r14d
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,rdi
       mov       r8,rbx
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       mov       rcx,[rdi]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       je        short M03_L04
       cmp       ecx,1
       jne       short M03_L06
M03_L04:
       mov       rcx,rsi
       xor       edx,edx
       call      System.Array.GetLowerBound(Int32)
       mov       edx,eax
       mov       ecx,[rsi+8]
       test      ecx,ecx
       jl        short M03_L05
       mov       [rsp+20],ecx
       mov       rcx,rsi
       mov       r8,rdi
       mov       r9d,1
       call      System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       rax,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L05:
       call      CORINFO_HELP_OVERFLOW
M03_L06:
       mov       ecx,7
       call      System.ThrowHelper.ThrowArgumentException(System.ExceptionResource)
       int       3
; Total bytes of code 325
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AddFirst01()
; 			var people = this.GetPersonProperArray().Clone<List<PersonProper>>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.ToArray().AddFirst(this.PersonProper01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rcx,rax
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       mov       rdx,rax
       mov       r8,[rsi+28]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddFirst(!!0[], !!0)
       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddFirst[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 105
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       mov       rax,2129FF23020
       mov       rbx,[rax]
       mov       rax,212BFF215C8
       mov       rbp,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,rbp
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFAAF2D0570
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
; Total bytes of code 148
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       edi,[rsi+10]
       test      edi,edi
       je        short M02_L00
       mov       ebx,edi
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+58]
       test      rdx,rdx
       je        short M02_L03
       mov       [rsp+20],rdx
       jmp       short M02_L04
M02_L00:
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+50]
       test      rdx,rdx
       je        short M02_L01
       jmp       short M02_L02
M02_L01:
       mov       rdx,7FFAAF49FDC0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M02_L02:
       mov       rcx,rdx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rdx,7FFAAF49FDD0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rsp+20],rax
M02_L04:
       movsxd    rdx,ebx
       mov       rcx,[rsp+20]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       mov       rcx,[rsi+8]
       mov       r8d,edi
       mov       rdx,rbx
       call      System.Array.Copy(System.Array, System.Array, Int32)
       mov       rax,rbx
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 170
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.AddFirst[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rbx,r8
       mov       rbp,[rdi+10]
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L00
       mov       rax,2129FF23020
       mov       r14,[rax]
       mov       rax,212BFF21200
       mov       r15,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r15
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L00:
       test      rbx,rbx
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L01
       mov       rax,2129FF23020
       mov       r14,[rax]
       mov       rax,2129FF26008
       mov       r15,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r15
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L01:
       mov       r14d,[rsi+8]
       add       r14d,1
       jo        near ptr M03_L05
       cmp       qword ptr [rbp+20],0
       je        short M03_L02
       mov       rcx,[rbp+20]
       jmp       short M03_L03
M03_L02:
       mov       rcx,rdi
       mov       rdx,7FFAAF491A98
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L03:
       movsxd    rdx,r14d
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,rdi
       mov       r8,rbx
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       mov       rcx,[rdi]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       je        short M03_L04
       cmp       ecx,1
       jne       short M03_L06
M03_L04:
       mov       rcx,rsi
       xor       edx,edx
       call      System.Array.GetLowerBound(Int32)
       mov       edx,eax
       mov       ecx,[rsi+8]
       test      ecx,ecx
       jl        short M03_L05
       mov       [rsp+20],ecx
       mov       rcx,rsi
       mov       r8,rdi
       mov       r9d,1
       call      System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       rax,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L05:
       call      CORINFO_HELP_OVERFLOW
M03_L06:
       mov       ecx,7
       call      System.ThrowHelper.ThrowArgumentException(System.ExceptionResource)
       int       3
; Total bytes of code 325
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AddFirst01()
; 			var people = this.GetPersonProperArray().Clone<List<PersonProper>>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.ToArray().AddFirst(this.PersonProper01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rcx,rax
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       mov       rdx,rax
       mov       r8,[rsi+28]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddFirst(!!0[], !!0)
       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddFirst[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 105
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       mov       rax,27612853020
       mov       rbx,[rax]
       mov       rax,276128559D0
       mov       rbp,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,rbp
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFAAF2D0570
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
; Total bytes of code 148
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       edi,[rsi+10]
       test      edi,edi
       je        short M02_L00
       mov       ebx,edi
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+58]
       test      rdx,rdx
       je        short M02_L03
       mov       [rsp+20],rdx
       jmp       short M02_L04
M02_L00:
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+50]
       test      rdx,rdx
       je        short M02_L01
       jmp       short M02_L02
M02_L01:
       mov       rdx,7FFAAF49FDC0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M02_L02:
       mov       rcx,rdx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rdx,7FFAAF49FDD0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rsp+20],rax
M02_L04:
       movsxd    rdx,ebx
       mov       rcx,[rsp+20]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       mov       rcx,[rsi+8]
       mov       r8d,edi
       mov       rdx,rbx
       call      System.Array.Copy(System.Array, System.Array, Int32)
       mov       rax,rbx
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 170
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.AddFirst[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rbx,r8
       mov       rbp,[rdi+10]
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L00
       mov       rax,27612853020
       mov       r14,[rax]
       mov       rax,27612855608
       mov       r15,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r15
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L00:
       test      rbx,rbx
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L01
       mov       rax,27612853020
       mov       r14,[rax]
       mov       rax,27612857838
       mov       r15,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r15
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L01:
       mov       r14d,[rsi+8]
       add       r14d,1
       jo        near ptr M03_L05
       cmp       qword ptr [rbp+20],0
       je        short M03_L02
       mov       rcx,[rbp+20]
       jmp       short M03_L03
M03_L02:
       mov       rcx,rdi
       mov       rdx,7FFAAF491A98
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L03:
       movsxd    rdx,r14d
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,rdi
       mov       r8,rbx
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       mov       rcx,[rdi]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       je        short M03_L04
       cmp       ecx,1
       jne       short M03_L06
M03_L04:
       mov       rcx,rsi
       xor       edx,edx
       call      System.Array.GetLowerBound(Int32)
       mov       edx,eax
       mov       ecx,[rsi+8]
       test      ecx,ecx
       jl        short M03_L05
       mov       [rsp+20],ecx
       mov       rcx,rsi
       mov       r8,rdi
       mov       r9d,1
       call      System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       rax,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L05:
       call      CORINFO_HELP_OVERFLOW
M03_L06:
       mov       ecx,7
       call      System.ThrowHelper.ThrowArgumentException(System.ExceptionResource)
       int       3
; Total bytes of code 325
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AddFirst01()
; 			var people = this.GetPersonProperArray().Clone<List<PersonProper>>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.ToArray().AddFirst(this.PersonProper01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rcx,rax
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       mov       rdx,rax
       mov       r8,[rsi+28]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddFirst(!!0[], !!0)
       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddFirst[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 105
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       mov       rax,1A004BE1028
       mov       rbx,[rax]
       mov       rax,1A004BE39D8
       mov       rbp,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,rbp
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFAAF2E0570
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
; Total bytes of code 148
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       edi,[rsi+10]
       test      edi,edi
       je        short M02_L00
       mov       ebx,edi
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+58]
       test      rdx,rdx
       je        short M02_L03
       mov       [rsp+20],rdx
       jmp       short M02_L04
M02_L00:
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+50]
       test      rdx,rdx
       je        short M02_L01
       jmp       short M02_L02
M02_L01:
       mov       rdx,7FFAAF4AFDD8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M02_L02:
       mov       rcx,rdx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rdx,7FFAAF4AFDE8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rsp+20],rax
M02_L04:
       movsxd    rdx,ebx
       mov       rcx,[rsp+20]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       mov       rcx,[rsi+8]
       mov       r8d,edi
       mov       rdx,rbx
       call      System.Array.Copy(System.Array, System.Array, Int32)
       mov       rax,rbx
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 170
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.AddFirst[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rbx,r8
       mov       rbp,[rdi+10]
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L00
       mov       rax,1A004BE1028
       mov       r14,[rax]
       mov       rax,1A004BE3610
       mov       r15,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r15
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L00:
       test      rbx,rbx
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L01
       mov       rax,1A004BE1028
       mov       r14,[rax]
       mov       rax,19FE4BE3BF8
       mov       r15,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r15
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L01:
       mov       r14d,[rsi+8]
       add       r14d,1
       jo        near ptr M03_L05
       cmp       qword ptr [rbp+20],0
       je        short M03_L02
       mov       rcx,[rbp+20]
       jmp       short M03_L03
M03_L02:
       mov       rcx,rdi
       mov       rdx,7FFAAF4A1AB0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L03:
       movsxd    rdx,r14d
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,rdi
       mov       r8,rbx
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       mov       rcx,[rdi]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       je        short M03_L04
       cmp       ecx,1
       jne       short M03_L06
M03_L04:
       mov       rcx,rsi
       xor       edx,edx
       call      System.Array.GetLowerBound(Int32)
       mov       edx,eax
       mov       ecx,[rsi+8]
       test      ecx,ecx
       jl        short M03_L05
       mov       [rsp+20],ecx
       mov       rcx,rsi
       mov       r8,rdi
       mov       r9d,1
       call      System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       rax,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L05:
       call      CORINFO_HELP_OVERFLOW
M03_L06:
       mov       ecx,7
       call      System.ThrowHelper.ThrowArgumentException(System.ExceptionResource)
       int       3
; Total bytes of code 325
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AddFirst01()
; 			var people = this.GetPersonProperArray().Clone<List<PersonProper>>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.ToArray().AddFirst(this.PersonProper01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rcx,rax
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       mov       rdx,rax
       mov       r8,[rsi+28]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddFirst(!!0[], !!0)
       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddFirst[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 105
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       mov       rax,198E46B3020
       mov       rbx,[rax]
       mov       rax,198E46C1E00
       mov       rbp,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,rbp
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFAAF2C0570
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
; Total bytes of code 148
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       edi,[rsi+10]
       test      edi,edi
       je        short M02_L00
       mov       ebx,edi
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+38]
       test      rdx,rdx
       je        short M02_L03
       mov       [rsp+20],rdx
       jmp       short M02_L04
M02_L00:
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+40]
       test      rdx,rdx
       je        short M02_L01
       jmp       short M02_L02
M02_L01:
       mov       rdx,7FFAAF387D50
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M02_L02:
       mov       rcx,rdx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rdx,7FFAAF387D48
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rsp+20],rax
M02_L04:
       movsxd    rdx,ebx
       mov       rcx,[rsp+20]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       mov       rcx,[rsi+8]
       mov       r8d,edi
       mov       rdx,rbx
       call      System.Array.Copy(System.Array, System.Array, Int32)
       mov       rax,rbx
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 170
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.AddFirst[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rbx,r8
       mov       rbp,[rdi+10]
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L00
       mov       rax,198E46B3020
       mov       r14,[rax]
       mov       rax,198E46C1A38
       mov       r15,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r15
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L00:
       test      rbx,rbx
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L01
       mov       rax,198E46B3020
       mov       r14,[rax]
       mov       rax,198C46B2C18
       mov       r15,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r15
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M03_L01:
       mov       r14d,[rsi+8]
       add       r14d,1
       jo        near ptr M03_L05
       cmp       qword ptr [rbp+20],0
       je        short M03_L02
       mov       rcx,[rbp+20]
       jmp       short M03_L03
M03_L02:
       mov       rcx,rdi
       mov       rdx,7FFAAF4A1AB0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L03:
       movsxd    rdx,r14d
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,rdi
       mov       r8,rbx
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       mov       rcx,[rdi]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       je        short M03_L04
       cmp       ecx,1
       jne       short M03_L06
M03_L04:
       mov       rcx,rsi
       xor       edx,edx
       call      System.Array.GetLowerBound(Int32)
       mov       edx,eax
       mov       ecx,[rsi+8]
       test      ecx,ecx
       jl        short M03_L05
       mov       [rsp+20],ecx
       mov       rcx,rsi
       mov       r8,rdi
       mov       r9d,1
       call      System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       rax,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L05:
       call      CORINFO_HELP_OVERFLOW
M03_L06:
       mov       ecx,7
       call      System.ThrowHelper.ThrowArgumentException(System.ExceptionResource)
       int       3
; Total bytes of code 325
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AddLast01()
; 			var people = base.GetPersonProperArray(collectionSize: CollectionSize.Half);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.AddLast(this.PersonProper01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+118]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       r8,[rsi+28]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast(!!0[], !!0)
       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 77
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       mov       rax,21C83663020
       mov       rbx,[rax]
       mov       rax,21C83671E00
       mov       rbp,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,rbp
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFAAF2F0570
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
; Total bytes of code 148
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rbx,r8
       test      rbx,rbx
       jne       short M02_L00
       mov       rax,rsi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L00:
       mov       rbp,[rdi+10]
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L01
       mov       rax,21C83663020
       mov       r14,[rax]
       mov       rax,21C83671A38
       mov       r15,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r15
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L01:
       mov       r14d,[rsi+8]
       add       r14d,1
       jo        near ptr M02_L05
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rdi
       mov       rdx,7FFAAF4B1820
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L03:
       movsxd    rdx,r14d
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,[rdi]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       je        short M02_L04
       cmp       ecx,1
       jne       short M02_L06
M02_L04:
       mov       rcx,rsi
       xor       edx,edx
       call      System.Array.GetLowerBound(Int32)
       mov       edx,eax
       mov       ecx,[rsi+8]
       test      ecx,ecx
       jl        short M02_L05
       mov       [rsp+20],ecx
       mov       rcx,rsi
       mov       r8,rdi
       xor       r9d,r9d
       call      System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       edx,[rsi+8]
       mov       rcx,rdi
       mov       r8,rbx
       call      CORINFO_HELP_ARRADDR_ST
       mov       rax,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L05:
       call      CORINFO_HELP_OVERFLOW
M02_L06:
       mov       ecx,7
       call      System.ThrowHelper.ThrowArgumentException(System.ExceptionResource)
       int       3
; Total bytes of code 276
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AddLast01()
; 			var people = base.GetPersonProperArray(collectionSize: CollectionSize.Half);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.AddLast(this.PersonProper01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+118]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       r8,[rsi+28]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast(!!0[], !!0)
       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 77
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       mov       rax,266E5D43020
       mov       rbx,[rax]
       mov       rax,26705D415C8
       mov       rbp,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,rbp
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFAAF300570
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
; Total bytes of code 148
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rbx,r8
       test      rbx,rbx
       jne       short M02_L00
       mov       rax,rsi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L00:
       mov       rbp,[rdi+10]
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L01
       mov       rax,266E5D43020
       mov       r14,[rax]
       mov       rax,26705D41200
       mov       r15,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r15
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L01:
       mov       r14d,[rsi+8]
       add       r14d,1
       jo        near ptr M02_L05
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rdi
       mov       rdx,7FFAAF4C17A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L03:
       movsxd    rdx,r14d
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,[rdi]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       je        short M02_L04
       cmp       ecx,1
       jne       short M02_L06
M02_L04:
       mov       rcx,rsi
       xor       edx,edx
       call      System.Array.GetLowerBound(Int32)
       mov       edx,eax
       mov       ecx,[rsi+8]
       test      ecx,ecx
       jl        short M02_L05
       mov       [rsp+20],ecx
       mov       rcx,rsi
       mov       r8,rdi
       xor       r9d,r9d
       call      System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       edx,[rsi+8]
       mov       rcx,rdi
       mov       r8,rbx
       call      CORINFO_HELP_ARRADDR_ST
       mov       rax,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L05:
       call      CORINFO_HELP_OVERFLOW
M02_L06:
       mov       ecx,7
       call      System.ThrowHelper.ThrowArgumentException(System.ExceptionResource)
       int       3
; Total bytes of code 276
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AddLast01()
; 			var people = base.GetPersonProperArray(collectionSize: CollectionSize.Half);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.AddLast(this.PersonProper01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+118]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       r8,[rsi+28]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast(!!0[], !!0)
       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 77
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       mov       rax,1D1E53D3020
       mov       rbx,[rax]
       mov       rax,1D1E53D59D0
       mov       rbp,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,rbp
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFAAF2D0570
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
; Total bytes of code 148
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rbx,r8
       test      rbx,rbx
       jne       short M02_L00
       mov       rax,rsi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L00:
       mov       rbp,[rdi+10]
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L01
       mov       rax,1D1E53D3020
       mov       r14,[rax]
       mov       rax,1D1E53D5608
       mov       r15,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r15
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L01:
       mov       r14d,[rsi+8]
       add       r14d,1
       jo        near ptr M02_L05
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rdi
       mov       rdx,7FFAAF491820
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L03:
       movsxd    rdx,r14d
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,[rdi]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       je        short M02_L04
       cmp       ecx,1
       jne       short M02_L06
M02_L04:
       mov       rcx,rsi
       xor       edx,edx
       call      System.Array.GetLowerBound(Int32)
       mov       edx,eax
       mov       ecx,[rsi+8]
       test      ecx,ecx
       jl        short M02_L05
       mov       [rsp+20],ecx
       mov       rcx,rsi
       mov       r8,rdi
       xor       r9d,r9d
       call      System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       edx,[rsi+8]
       mov       rcx,rdi
       mov       r8,rbx
       call      CORINFO_HELP_ARRADDR_ST
       mov       rax,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L05:
       call      CORINFO_HELP_OVERFLOW
M02_L06:
       mov       ecx,7
       call      System.ThrowHelper.ThrowArgumentException(System.ExceptionResource)
       int       3
; Total bytes of code 276
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AddLast01()
; 			var people = base.GetPersonProperArray(collectionSize: CollectionSize.Half);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.AddLast(this.PersonProper01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+118]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       r8,[rsi+28]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast(!!0[], !!0)
       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 77
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       mov       rax,2EA1A3D3020
       mov       rbx,[rax]
       mov       rax,2EA1A3D59D0
       mov       rbp,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,rbp
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFAAF2F0570
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
; Total bytes of code 148
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rbx,r8
       test      rbx,rbx
       jne       short M02_L00
       mov       rax,rsi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L00:
       mov       rbp,[rdi+10]
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L01
       mov       rax,2EA1A3D3020
       mov       r14,[rax]
       mov       rax,2EA1A3D5608
       mov       r15,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r15
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L01:
       mov       r14d,[rsi+8]
       add       r14d,1
       jo        near ptr M02_L05
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rdi
       mov       rdx,7FFAAF4B17B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L03:
       movsxd    rdx,r14d
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,[rdi]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       je        short M02_L04
       cmp       ecx,1
       jne       short M02_L06
M02_L04:
       mov       rcx,rsi
       xor       edx,edx
       call      System.Array.GetLowerBound(Int32)
       mov       edx,eax
       mov       ecx,[rsi+8]
       test      ecx,ecx
       jl        short M02_L05
       mov       [rsp+20],ecx
       mov       rcx,rsi
       mov       r8,rdi
       xor       r9d,r9d
       call      System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       edx,[rsi+8]
       mov       rcx,rdi
       mov       r8,rbx
       call      CORINFO_HELP_ARRADDR_ST
       mov       rax,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L05:
       call      CORINFO_HELP_OVERFLOW
M02_L06:
       mov       ecx,7
       call      System.ThrowHelper.ThrowArgumentException(System.ExceptionResource)
       int       3
; Total bytes of code 276
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AddLast01()
; 			var people = base.GetPersonProperArray(collectionSize: CollectionSize.Half);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.AddLast(this.PersonProper01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+118]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       r8,[rsi+28]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast(!!0[], !!0)
       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 77
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       mov       rax,1E604F63020
       mov       rbx,[rax]
       mov       rax,1E604F71E00
       mov       rbp,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,rbp
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFAAF2D0570
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
; Total bytes of code 148
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rbx,r8
       test      rbx,rbx
       jne       short M02_L00
       mov       rax,rsi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L00:
       mov       rbp,[rdi+10]
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L01
       mov       rax,1E604F63020
       mov       r14,[rax]
       mov       rax,1E604F71A38
       mov       r15,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r15
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L01:
       mov       r14d,[rsi+8]
       add       r14d,1
       jo        near ptr M02_L05
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rdi
       mov       rdx,7FFAAF4917B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L03:
       movsxd    rdx,r14d
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,[rdi]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       je        short M02_L04
       cmp       ecx,1
       jne       short M02_L06
M02_L04:
       mov       rcx,rsi
       xor       edx,edx
       call      System.Array.GetLowerBound(Int32)
       mov       edx,eax
       mov       ecx,[rsi+8]
       test      ecx,ecx
       jl        short M02_L05
       mov       [rsp+20],ecx
       mov       rcx,rsi
       mov       r8,rdi
       xor       r9d,r9d
       call      System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       edx,[rsi+8]
       mov       rcx,rdi
       mov       r8,rbx
       call      CORINFO_HELP_ARRADDR_ST
       mov       rax,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L05:
       call      CORINFO_HELP_OVERFLOW
M02_L06:
       mov       ecx,7
       call      System.ThrowHelper.ThrowArgumentException(System.ExceptionResource)
       int       3
; Total bytes of code 276
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AddLast01()
; 			var people = base.GetPersonProperArray(collectionSize: CollectionSize.Half);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.AddLast(this.PersonProper01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+118]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       r8,[rsi+28]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast(!!0[], !!0)
       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 77
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       mov       rax,26BD9013020
       mov       rbx,[rax]
       mov       rax,26BF90115C8
       mov       rbp,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,rbp
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFAAF300570
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
; Total bytes of code 148
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rbx,r8
       test      rbx,rbx
       jne       short M02_L00
       mov       rax,rsi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L00:
       mov       rbp,[rdi+10]
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L01
       mov       rax,26BD9013020
       mov       r14,[rax]
       mov       rax,26BF9011200
       mov       r15,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r15
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L01:
       mov       r14d,[rsi+8]
       add       r14d,1
       jo        near ptr M02_L05
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rdi
       mov       rdx,7FFAAF4C1820
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L03:
       movsxd    rdx,r14d
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,[rdi]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       je        short M02_L04
       cmp       ecx,1
       jne       short M02_L06
M02_L04:
       mov       rcx,rsi
       xor       edx,edx
       call      System.Array.GetLowerBound(Int32)
       mov       edx,eax
       mov       ecx,[rsi+8]
       test      ecx,ecx
       jl        short M02_L05
       mov       [rsp+20],ecx
       mov       rcx,rsi
       mov       r8,rdi
       xor       r9d,r9d
       call      System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       edx,[rsi+8]
       mov       rcx,rdi
       mov       r8,rbx
       call      CORINFO_HELP_ARRADDR_ST
       mov       rax,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L05:
       call      CORINFO_HELP_OVERFLOW
M02_L06:
       mov       ecx,7
       call      System.ThrowHelper.ThrowArgumentException(System.ExceptionResource)
       int       3
; Total bytes of code 276
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AddLast01()
; 			var people = base.GetPersonProperArray(collectionSize: CollectionSize.Half);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.AddLast(this.PersonProper01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+118]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       r8,[rsi+28]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast(!!0[], !!0)
       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 77
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       mov       rax,250515B3020
       mov       rbx,[rax]
       mov       rax,250715B15C8
       mov       rbp,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,rbp
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFAAF2E0570
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
; Total bytes of code 148
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rbx,r8
       test      rbx,rbx
       jne       short M02_L00
       mov       rax,rsi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L00:
       mov       rbp,[rdi+10]
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L01
       mov       rax,250515B3020
       mov       r14,[rax]
       mov       rax,250715B1200
       mov       r15,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r15
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L01:
       mov       r14d,[rsi+8]
       add       r14d,1
       jo        near ptr M02_L05
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rdi
       mov       rdx,7FFAAF4A1820
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L03:
       movsxd    rdx,r14d
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,[rdi]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       je        short M02_L04
       cmp       ecx,1
       jne       short M02_L06
M02_L04:
       mov       rcx,rsi
       xor       edx,edx
       call      System.Array.GetLowerBound(Int32)
       mov       edx,eax
       mov       ecx,[rsi+8]
       test      ecx,ecx
       jl        short M02_L05
       mov       [rsp+20],ecx
       mov       rcx,rsi
       mov       r8,rdi
       xor       r9d,r9d
       call      System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       edx,[rsi+8]
       mov       rcx,rdi
       mov       r8,rbx
       call      CORINFO_HELP_ARRADDR_ST
       mov       rax,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L05:
       call      CORINFO_HELP_OVERFLOW
M02_L06:
       mov       ecx,7
       call      System.ThrowHelper.ThrowArgumentException(System.ExceptionResource)
       int       3
; Total bytes of code 276
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AddLast01()
; 			var people = base.GetPersonProperArray(collectionSize: CollectionSize.Half);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.AddLast(this.PersonProper01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+118]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rdx,rax
       mov       r8,[rsi+28]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast(!!0[], !!0)
       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 77
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L00
       mov       rax,29786A61028
       mov       rbx,[rax]
       mov       rax,297A6A635C0
       mov       rbp,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,rbp
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rsi
       mov       rdx,7FFAAF300570
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L02:
       mov       rdx,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
; Total bytes of code 148
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rbx,r8
       test      rbx,rbx
       jne       short M02_L00
       mov       rax,rsi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L00:
       mov       rbp,[rdi+10]
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L01
       mov       rax,29786A61028
       mov       r14,[rax]
       mov       rax,297A6A631F8
       mov       r15,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r15
       mov       rcx,r14
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M02_L01:
       mov       r14d,[rsi+8]
       add       r14d,1
       jo        near ptr M02_L05
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rdi
       mov       rdx,7FFAAF4E17D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L03:
       movsxd    rdx,r14d
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,[rdi]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       je        short M02_L04
       cmp       ecx,1
       jne       short M02_L06
M02_L04:
       mov       rcx,rsi
       xor       edx,edx
       call      System.Array.GetLowerBound(Int32)
       mov       edx,eax
       mov       ecx,[rsi+8]
       test      ecx,ecx
       jl        short M02_L05
       mov       [rsp+20],ecx
       mov       rcx,rsi
       mov       r8,rdi
       xor       r9d,r9d
       call      System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       edx,[rsi+8]
       mov       rcx,rdi
       mov       r8,rbx
       call      CORINFO_HELP_ARRADDR_ST
       mov       rax,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L05:
       call      CORINFO_HELP_OVERFLOW
M02_L06:
       mov       ecx,7
       call      System.ThrowHelper.ThrowArgumentException(System.ExceptionResource)
       int       3
; Total bytes of code 276
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AreEqual01()
; 			var people1 = base.GetPersonProperArray(Tristate.False);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var people2 = base.GetPersonProperArray(Tristate.False, collectionSize: CollectionSize.Half);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people1.AreEqual(people2);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       r8,[rsi+118]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual(!!0[], !!0[])
       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       mov       rdx,[rsi+20]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 50
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+0FFF0],xmm4
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       rcx,[rbp+18]
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.IsNull(System.Object)
       test      eax,eax
       jne       short M01_L00
       mov       rcx,[rbp+20]
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.IsNull(System.Object)
       test      eax,eax
       je        short M01_L01
M01_L00:
       xor       eax,eax
       add       rsp,30
       pop       rbp
       ret
M01_L01:
       mov       rax,[rbp+18]
       mov       eax,[rax+8]
       mov       rcx,[rbp+20]
       cmp       eax,[rcx+8]
       je        short M01_L02
       xor       eax,eax
       add       rsp,30
       pop       rbp
       ret
M01_L02:
       mov       dword ptr [rbp+0FFFC],1
       xor       ecx,ecx
       mov       [rbp+0FFF8],ecx
       jmp       short M01_L04
M01_L03:
       mov       rcx,[rbp+18]
       mov       edx,[rbp+0FFF8]
       cmp       edx,[rcx+8]
       jae       short M01_L05
       mov       eax,edx
       lea       rcx,[rcx+rax*8+10]
       mov       rcx,[rcx]
       mov       [rbp+0FFF0],rcx
       mov       rcx,[rbp+0FFF0]
       mov       rdx,[rbp+20]
       mov       eax,[rbp+0FFF8]
       cmp       eax,[rdx+8]
       jae       short M01_L05
       mov       r8d,eax
       lea       rdx,[rdx+r8*8+10]
       mov       rdx,[rdx]
       mov       rax,[rbp+0FFF0]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       and       eax,[rbp+0FFFC]
       movzx     eax,al
       mov       [rbp+0FFFC],eax
       mov       eax,[rbp+0FFF8]
       add       eax,1
       jo        short M01_L06
       mov       [rbp+0FFF8],eax
M01_L04:
       mov       ecx,[rbp+0FFF8]
       mov       rdx,[rbp+18]
       cmp       ecx,[rdx+8]
       jl        short M01_L03
       mov       eax,[rbp+0FFFC]
       add       rsp,30
       pop       rbp
       ret
M01_L05:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L06:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 222
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AreEqual01()
; 			var people1 = base.GetPersonProperArray(Tristate.False);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var people2 = base.GetPersonProperArray(Tristate.False, collectionSize: CollectionSize.Half);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people1.AreEqual(people2);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       r8,[rsi+118]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual(!!0[], !!0[])
       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       mov       rdx,[rsi+20]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 50
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+0FFF0],xmm4
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       rcx,[rbp+18]
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.IsNull(System.Object)
       test      eax,eax
       jne       short M01_L00
       mov       rcx,[rbp+20]
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.IsNull(System.Object)
       test      eax,eax
       je        short M01_L01
M01_L00:
       xor       eax,eax
       add       rsp,30
       pop       rbp
       ret
M01_L01:
       mov       rax,[rbp+18]
       mov       eax,[rax+8]
       mov       rcx,[rbp+20]
       cmp       eax,[rcx+8]
       je        short M01_L02
       xor       eax,eax
       add       rsp,30
       pop       rbp
       ret
M01_L02:
       mov       dword ptr [rbp+0FFFC],1
       xor       ecx,ecx
       mov       [rbp+0FFF8],ecx
       jmp       short M01_L04
M01_L03:
       mov       rcx,[rbp+18]
       mov       edx,[rbp+0FFF8]
       cmp       edx,[rcx+8]
       jae       short M01_L05
       mov       eax,edx
       lea       rcx,[rcx+rax*8+10]
       mov       rcx,[rcx]
       mov       [rbp+0FFF0],rcx
       mov       rcx,[rbp+0FFF0]
       mov       rdx,[rbp+20]
       mov       eax,[rbp+0FFF8]
       cmp       eax,[rdx+8]
       jae       short M01_L05
       mov       r8d,eax
       lea       rdx,[rdx+r8*8+10]
       mov       rdx,[rdx]
       mov       rax,[rbp+0FFF0]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       and       eax,[rbp+0FFFC]
       movzx     eax,al
       mov       [rbp+0FFFC],eax
       mov       eax,[rbp+0FFF8]
       add       eax,1
       jo        short M01_L06
       mov       [rbp+0FFF8],eax
M01_L04:
       mov       ecx,[rbp+0FFF8]
       mov       rdx,[rbp+18]
       cmp       ecx,[rdx+8]
       jl        short M01_L03
       mov       eax,[rbp+0FFFC]
       add       rsp,30
       pop       rbp
       ret
M01_L05:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L06:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 222
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AreEqual01()
; 			var people1 = base.GetPersonProperArray(Tristate.False);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var people2 = base.GetPersonProperArray(Tristate.False, collectionSize: CollectionSize.Half);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people1.AreEqual(people2);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       r8,[rsi+118]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual(!!0[], !!0[])
       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       mov       rdx,[rsi+20]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 50
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+0FFF0],xmm4
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       rcx,[rbp+18]
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.IsNull(System.Object)
       test      eax,eax
       jne       short M01_L00
       mov       rcx,[rbp+20]
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.IsNull(System.Object)
       test      eax,eax
       je        short M01_L01
M01_L00:
       xor       eax,eax
       add       rsp,30
       pop       rbp
       ret
M01_L01:
       mov       rax,[rbp+18]
       mov       eax,[rax+8]
       mov       rcx,[rbp+20]
       cmp       eax,[rcx+8]
       je        short M01_L02
       xor       eax,eax
       add       rsp,30
       pop       rbp
       ret
M01_L02:
       mov       dword ptr [rbp+0FFFC],1
       xor       ecx,ecx
       mov       [rbp+0FFF8],ecx
       jmp       short M01_L04
M01_L03:
       mov       rcx,[rbp+18]
       mov       edx,[rbp+0FFF8]
       cmp       edx,[rcx+8]
       jae       short M01_L05
       mov       eax,edx
       lea       rcx,[rcx+rax*8+10]
       mov       rcx,[rcx]
       mov       [rbp+0FFF0],rcx
       mov       rcx,[rbp+0FFF0]
       mov       rdx,[rbp+20]
       mov       eax,[rbp+0FFF8]
       cmp       eax,[rdx+8]
       jae       short M01_L05
       mov       r8d,eax
       lea       rdx,[rdx+r8*8+10]
       mov       rdx,[rdx]
       mov       rax,[rbp+0FFF0]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       and       eax,[rbp+0FFFC]
       movzx     eax,al
       mov       [rbp+0FFFC],eax
       mov       eax,[rbp+0FFF8]
       add       eax,1
       jo        short M01_L06
       mov       [rbp+0FFF8],eax
M01_L04:
       mov       ecx,[rbp+0FFF8]
       mov       rdx,[rbp+18]
       cmp       ecx,[rdx+8]
       jl        short M01_L03
       mov       eax,[rbp+0FFFC]
       add       rsp,30
       pop       rbp
       ret
M01_L05:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L06:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 222
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AreEqual01()
; 			var people1 = base.GetPersonProperArray(Tristate.False);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var people2 = base.GetPersonProperArray(Tristate.False, collectionSize: CollectionSize.Half);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people1.AreEqual(people2);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       r8,[rsi+118]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual(!!0[], !!0[])
       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       mov       rdx,[rsi+20]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 50
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+0FFF0],xmm4
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       rcx,[rbp+18]
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.IsNull(System.Object)
       test      eax,eax
       jne       short M01_L00
       mov       rcx,[rbp+20]
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.IsNull(System.Object)
       test      eax,eax
       je        short M01_L01
M01_L00:
       xor       eax,eax
       add       rsp,30
       pop       rbp
       ret
M01_L01:
       mov       rax,[rbp+18]
       mov       eax,[rax+8]
       mov       rcx,[rbp+20]
       cmp       eax,[rcx+8]
       je        short M01_L02
       xor       eax,eax
       add       rsp,30
       pop       rbp
       ret
M01_L02:
       mov       dword ptr [rbp+0FFFC],1
       xor       ecx,ecx
       mov       [rbp+0FFF8],ecx
       jmp       short M01_L04
M01_L03:
       mov       rcx,[rbp+18]
       mov       edx,[rbp+0FFF8]
       cmp       edx,[rcx+8]
       jae       short M01_L05
       mov       eax,edx
       lea       rcx,[rcx+rax*8+10]
       mov       rcx,[rcx]
       mov       [rbp+0FFF0],rcx
       mov       rcx,[rbp+0FFF0]
       mov       rdx,[rbp+20]
       mov       eax,[rbp+0FFF8]
       cmp       eax,[rdx+8]
       jae       short M01_L05
       mov       r8d,eax
       lea       rdx,[rdx+r8*8+10]
       mov       rdx,[rdx]
       mov       rax,[rbp+0FFF0]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       and       eax,[rbp+0FFFC]
       movzx     eax,al
       mov       [rbp+0FFFC],eax
       mov       eax,[rbp+0FFF8]
       add       eax,1
       jo        short M01_L06
       mov       [rbp+0FFF8],eax
M01_L04:
       mov       ecx,[rbp+0FFF8]
       mov       rdx,[rbp+18]
       cmp       ecx,[rdx+8]
       jl        short M01_L03
       mov       eax,[rbp+0FFFC]
       add       rsp,30
       pop       rbp
       ret
M01_L05:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L06:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 222
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AreEqual01()
; 			var people1 = base.GetPersonProperArray(Tristate.False);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var people2 = base.GetPersonProperArray(Tristate.False, collectionSize: CollectionSize.Half);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people1.AreEqual(people2);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       r8,[rsi+118]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual(!!0[], !!0[])
       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       mov       rdx,[rsi+20]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 50
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+0FFF0],xmm4
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       rcx,[rbp+18]
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.IsNull(System.Object)
       test      eax,eax
       jne       short M01_L00
       mov       rcx,[rbp+20]
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.IsNull(System.Object)
       test      eax,eax
       je        short M01_L01
M01_L00:
       xor       eax,eax
       add       rsp,30
       pop       rbp
       ret
M01_L01:
       mov       rax,[rbp+18]
       mov       eax,[rax+8]
       mov       rcx,[rbp+20]
       cmp       eax,[rcx+8]
       je        short M01_L02
       xor       eax,eax
       add       rsp,30
       pop       rbp
       ret
M01_L02:
       mov       dword ptr [rbp+0FFFC],1
       xor       ecx,ecx
       mov       [rbp+0FFF8],ecx
       jmp       short M01_L04
M01_L03:
       mov       rcx,[rbp+18]
       mov       edx,[rbp+0FFF8]
       cmp       edx,[rcx+8]
       jae       short M01_L05
       mov       eax,edx
       lea       rcx,[rcx+rax*8+10]
       mov       rcx,[rcx]
       mov       [rbp+0FFF0],rcx
       mov       rcx,[rbp+0FFF0]
       mov       rdx,[rbp+20]
       mov       eax,[rbp+0FFF8]
       cmp       eax,[rdx+8]
       jae       short M01_L05
       mov       r8d,eax
       lea       rdx,[rdx+r8*8+10]
       mov       rdx,[rdx]
       mov       rax,[rbp+0FFF0]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       and       eax,[rbp+0FFFC]
       movzx     eax,al
       mov       [rbp+0FFFC],eax
       mov       eax,[rbp+0FFF8]
       add       eax,1
       jo        short M01_L06
       mov       [rbp+0FFF8],eax
M01_L04:
       mov       ecx,[rbp+0FFF8]
       mov       rdx,[rbp+18]
       cmp       ecx,[rdx+8]
       jl        short M01_L03
       mov       eax,[rbp+0FFFC]
       add       rsp,30
       pop       rbp
       ret
M01_L05:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L06:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 222
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AreEqual01()
; 			var people1 = base.GetPersonProperArray(Tristate.False);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var people2 = base.GetPersonProperArray(Tristate.False, collectionSize: CollectionSize.Half);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people1.AreEqual(people2);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       r8,[rsi+118]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual(!!0[], !!0[])
       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       mov       rdx,[rsi+20]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 50
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+0FFF0],xmm4
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       rcx,[rbp+18]
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.IsNull(System.Object)
       test      eax,eax
       jne       short M01_L00
       mov       rcx,[rbp+20]
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.IsNull(System.Object)
       test      eax,eax
       je        short M01_L01
M01_L00:
       xor       eax,eax
       add       rsp,30
       pop       rbp
       ret
M01_L01:
       mov       rax,[rbp+18]
       mov       eax,[rax+8]
       mov       rcx,[rbp+20]
       cmp       eax,[rcx+8]
       je        short M01_L02
       xor       eax,eax
       add       rsp,30
       pop       rbp
       ret
M01_L02:
       mov       dword ptr [rbp+0FFFC],1
       xor       ecx,ecx
       mov       [rbp+0FFF8],ecx
       jmp       short M01_L04
M01_L03:
       mov       rcx,[rbp+18]
       mov       edx,[rbp+0FFF8]
       cmp       edx,[rcx+8]
       jae       short M01_L05
       mov       eax,edx
       lea       rcx,[rcx+rax*8+10]
       mov       rcx,[rcx]
       mov       [rbp+0FFF0],rcx
       mov       rcx,[rbp+0FFF0]
       mov       rdx,[rbp+20]
       mov       eax,[rbp+0FFF8]
       cmp       eax,[rdx+8]
       jae       short M01_L05
       mov       r8d,eax
       lea       rdx,[rdx+r8*8+10]
       mov       rdx,[rdx]
       mov       rax,[rbp+0FFF0]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       and       eax,[rbp+0FFFC]
       movzx     eax,al
       mov       [rbp+0FFFC],eax
       mov       eax,[rbp+0FFF8]
       add       eax,1
       jo        short M01_L06
       mov       [rbp+0FFF8],eax
M01_L04:
       mov       ecx,[rbp+0FFF8]
       mov       rdx,[rbp+18]
       cmp       ecx,[rdx+8]
       jl        short M01_L03
       mov       eax,[rbp+0FFFC]
       add       rsp,30
       pop       rbp
       ret
M01_L05:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L06:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 222
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AreEqual01()
; 			var people1 = base.GetPersonProperArray(Tristate.False);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var people2 = base.GetPersonProperArray(Tristate.False, collectionSize: CollectionSize.Half);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people1.AreEqual(people2);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       r8,[rsi+118]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual(!!0[], !!0[])
       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       mov       rdx,[rsi+20]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 50
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+0FFF0],xmm4
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       rcx,[rbp+18]
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.IsNull(System.Object)
       test      eax,eax
       jne       short M01_L00
       mov       rcx,[rbp+20]
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.IsNull(System.Object)
       test      eax,eax
       je        short M01_L01
M01_L00:
       xor       eax,eax
       add       rsp,30
       pop       rbp
       ret
M01_L01:
       mov       rax,[rbp+18]
       mov       eax,[rax+8]
       mov       rcx,[rbp+20]
       cmp       eax,[rcx+8]
       je        short M01_L02
       xor       eax,eax
       add       rsp,30
       pop       rbp
       ret
M01_L02:
       mov       dword ptr [rbp+0FFFC],1
       xor       ecx,ecx
       mov       [rbp+0FFF8],ecx
       jmp       short M01_L04
M01_L03:
       mov       rcx,[rbp+18]
       mov       edx,[rbp+0FFF8]
       cmp       edx,[rcx+8]
       jae       short M01_L05
       mov       eax,edx
       lea       rcx,[rcx+rax*8+10]
       mov       rcx,[rcx]
       mov       [rbp+0FFF0],rcx
       mov       rcx,[rbp+0FFF0]
       mov       rdx,[rbp+20]
       mov       eax,[rbp+0FFF8]
       cmp       eax,[rdx+8]
       jae       short M01_L05
       mov       r8d,eax
       lea       rdx,[rdx+r8*8+10]
       mov       rdx,[rdx]
       mov       rax,[rbp+0FFF0]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       and       eax,[rbp+0FFFC]
       movzx     eax,al
       mov       [rbp+0FFFC],eax
       mov       eax,[rbp+0FFF8]
       add       eax,1
       jo        short M01_L06
       mov       [rbp+0FFF8],eax
M01_L04:
       mov       ecx,[rbp+0FFF8]
       mov       rdx,[rbp+18]
       cmp       ecx,[rdx+8]
       jl        short M01_L03
       mov       eax,[rbp+0FFFC]
       add       rsp,30
       pop       rbp
       ret
M01_L05:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L06:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 222
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AreEqual01()
; 			var people1 = base.GetPersonProperArray(Tristate.False);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var people2 = base.GetPersonProperArray(Tristate.False, collectionSize: CollectionSize.Half);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people1.AreEqual(people2);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       r8,[rsi+118]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual(!!0[], !!0[])
       call      DotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       mov       rdx,[rsi+20]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 50
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+0FFF0],xmm4
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       rcx,[rbp+18]
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.IsNull(System.Object)
       test      eax,eax
       jne       short M01_L00
       mov       rcx,[rbp+20]
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.IsNull(System.Object)
       test      eax,eax
       je        short M01_L01
M01_L00:
       xor       eax,eax
       add       rsp,30
       pop       rbp
       ret
M01_L01:
       mov       rax,[rbp+18]
       mov       eax,[rax+8]
       mov       rcx,[rbp+20]
       cmp       eax,[rcx+8]
       je        short M01_L02
       xor       eax,eax
       add       rsp,30
       pop       rbp
       ret
M01_L02:
       mov       dword ptr [rbp+0FFFC],1
       xor       ecx,ecx
       mov       [rbp+0FFF8],ecx
       jmp       short M01_L04
M01_L03:
       mov       rcx,[rbp+18]
       mov       edx,[rbp+0FFF8]
       cmp       edx,[rcx+8]
       jae       short M01_L05
       mov       eax,edx
       lea       rcx,[rcx+rax*8+10]
       mov       rcx,[rcx]
       mov       [rbp+0FFF0],rcx
       mov       rcx,[rbp+0FFF0]
       mov       rdx,[rbp+20]
       mov       eax,[rbp+0FFF8]
       cmp       eax,[rdx+8]
       jae       short M01_L05
       mov       r8d,eax
       lea       rdx,[rdx+r8*8+10]
       mov       rdx,[rdx]
       mov       rax,[rbp+0FFF0]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       and       eax,[rbp+0FFFC]
       movzx     eax,al
       mov       [rbp+0FFFC],eax
       mov       eax,[rbp+0FFF8]
       add       eax,1
       jo        short M01_L06
       mov       [rbp+0FFF8],eax
M01_L04:
       mov       ecx,[rbp+0FFF8]
       mov       rdx,[rbp+18]
       cmp       ecx,[rdx+8]
       jl        short M01_L03
       mov       eax,[rbp+0FFFC]
       add       rsp,30
       pop       rbp
       ret
M01_L05:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L06:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 222
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.BytesToString01()
; 			var result = base.GetByteArray(1).BytesToString();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       vzeroupper
       mov       rsi,rcx
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       mov       edx,1
       call      System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       test      rax,rax
       jne       short M00_L00
       mov       rdi,[rsi+8]
       vmovsd    xmm0,qword ptr [7FFAAF3EB050]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       mov       r8,rax
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,1
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(Int32, System.__Canon, System.Collections.Generic.InsertionBehavior)
M00_L00:
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       mov       edx,1
       call      System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       test      rax,rax
       je        short M00_L01
       mov       rcx,[rax]
       call      DotNetTips.Spargine.Extensions.ArrayExtensions.BytesToString(Byte[])
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M00_L01:
       mov       ecx,1
       call      System.ThrowHelper.ThrowKeyNotFoundException[[System.Int32, System.Private.CoreLib]](Int32)
       int       3
; Total bytes of code 140
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       edi,edx
       mov       rax,[rsi]
       mov       rax,[rax+30]
       mov       rbx,[rax]
       cmp       qword ptr [rsi+8],0
       jne       short M01_L01
M01_L00:
       cmp       qword ptr [rbx+28],0
       je        near ptr M01_L05
       jmp       near ptr M01_L05
M01_L01:
       mov       rbp,[rsi+18]
       test      rbp,rbp
       jne       near ptr M01_L06
       mov       eax,edi
       mov       rcx,[rsi+8]
       mov       edx,[rcx+8]
       mov       r11d,edx
       mov       r8,[rsi+30]
       mov       r9d,eax
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       r11d,r11d
       imul      r11,r8
       shr       r11,20
       cmp       r11d,edx
       jae       near ptr M01_L11
       movsxd    rdx,r11d
       lea       rcx,[rcx+rdx*4+10]
       mov       ecx,[rcx]
       mov       rdx,[rsi+10]
       xor       r11d,r11d
       dec       ecx
       mov       r8d,[rdx+8]
M01_L02:
       cmp       r8d,ecx
       jbe       short M01_L00
       movsxd    rcx,ecx
       lea       rcx,[rcx+rcx*2]
       lea       r14,[rdx+rcx*8+10]
       cmp       [r14+8],edi
       jne       short M01_L03
       mov       ecx,[r14+10]
       cmp       ecx,eax
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       short M01_L04
M01_L03:
       mov       ecx,[r14+0C]
       inc       r11d
       cmp       r8d,r11d
       jb        near ptr M01_L09
       jmp       short M01_L02
M01_L04:
       mov       rax,r14
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L05:
       xor       r14d,r14d
       jmp       short M01_L04
M01_L06:
       mov       rcx,rbp
       mov       edx,edi
       mov       r11,7FFAAEE30670
       call      qword ptr [7FFAAF3F0670]
       mov       r14d,eax
       mov       rdx,[rsi+8]
       mov       ecx,[rdx+8]
       mov       r8,[rsi+30]
       mov       r11d,r14d
       imul      r8,r11
       shr       r8,20
       inc       r8
       mov       ecx,ecx
       imul      rcx,r8
       shr       rcx,20
       cmp       ecx,[rdx+8]
       jae       short M01_L11
       movsxd    rcx,ecx
       lea       rdx,[rdx+rcx*4+10]
       mov       r15d,[rdx]
       mov       r12,[rsi+10]
       xor       r13d,r13d
       dec       r15d
M01_L07:
       cmp       [r12+8],r15d
       jbe       near ptr M01_L00
       movsxd    rdx,r15d
       lea       rdx,[rdx+rdx*2]
       lea       rdx,[r12+rdx*8+10]
       mov       r15,rdx
       cmp       [r15+8],r14d
       jne       short M01_L08
       mov       edx,[r15+10]
       mov       rcx,rbp
       mov       r8d,edi
       mov       r11,7FFAAEE30678
       call      qword ptr [7FFAAF3F0678]
       test      eax,eax
       jne       short M01_L10
M01_L08:
       mov       r15d,[r15+0C]
       inc       r13d
       cmp       [r12+8],r13d
       jae       short M01_L07
M01_L09:
       call      System.ThrowHelper.ThrowInvalidOperationException_ConcurrentOperationsNotSupported()
       int       3
M01_L10:
       mov       r14,r15
       jmp       near ptr M01_L04
M01_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 408
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       push      rbp
       sub       rsp,0A0
       vzeroupper
       lea       rbp,[rsp+0A0]
       xor       eax,eax
       mov       [rbp+0FF98],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFA0
M02_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M02_L00
       mov       [rbp+0FF88],rsp
       vmovsd    qword ptr [rbp+10],xmm0
       call      System.Globalization.CultureInfo.get_InvariantCulture()
       mov       [rbp+0FFD8],rax
       mov       rcx,offset MT_System.Double
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp+0FFD0],rax
       call      DotNetTips.Spargine.Tester.Properties.Resources.get_SizeMustBeEpsilon()
       mov       [rbp+0FFC8],rax
       mov       r8,[rbp+0FFD0]
       mov       qword ptr [r8+8],1
       mov       r8,[rbp+0FFD0]
       mov       rcx,[rbp+0FFD8]
       mov       rdx,[rbp+0FFC8]
       call      System.String.Format(System.IFormatProvider, System.String, System.Object)
       mov       [rbp+0FFC0],rax
       mov       r9,1B6BEFD6128
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,[rbp+0FFC0]
       vmovsd    xmm2,qword ptr [rbp+10]
       vucomisd  xmm2,qword ptr [7FFAAF1F8A38]
       setae     dl
       movzx     edx,dl
       vxorps    xmm2,xmm2,xmm2
       vmovsd    xmm0,qword ptr [rbp+10]
       call      DotNetTips.Spargine.Core.Validator.ArgumentMeetsCondition[[System.Double, System.Private.CoreLib]](Double, Boolean, Double, System.String, System.String)
       vmovsd    qword ptr [rbp+10],xmm0
       vmovsd    xmm0,qword ptr [rbp+10]
       vmulsd    xmm0,xmm0,qword ptr [7FFAAF1F8A40]
       call      System.Convert.ToInt32(Double)
       movsxd    rdx,eax
       mov       [rbp+0FFB8],rdx
       mov       rdx,[rbp+0FFB8]
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp+0FFB0],rax
       mov       rdx,[rbp+0FFB0]
       lea       rcx,[rbp+0FFF0]
       call      System.Span`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte[])
       mov       rdx,1B6EEFD7448
       mov       rdx,[rdx]
       mov       [rbp+0FFE8],rdx
       xor       edx,edx
       mov       [rbp+0FFE0],edx
       lea       rdx,[rbp+0FFE0]
       mov       rcx,[rbp+0FFE8]
       call      System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,1B6EEFD7450
       mov       rcx,[rcx]
       mov       [rbp+0FF98],rcx
       vmovdqu   xmm0,xmmword ptr [rbp+0FFF0]
       vmovdqu   xmmword ptr [rbp+0FFA0],xmm0
       mov       rcx,[rbp+0FF98]
       lea       rdx,[rbp+0FFA0]
       mov       rax,[rbp+0FF98]
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       jmp       short M02_L01
M02_L01:
       mov       rcx,rsp
       call      M02_L02
       nop
       lea       rcx,[rbp+0FFF0]
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].ToArray()
       nop
       add       rsp,0A0
       pop       rbp
       ret
M02_L02:
       push      rbp
       sub       rsp,30
       vzeroupper
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+0A0]
       mov       ecx,[rbp+0FFE0]
       movzx     ecx,cl
       test      ecx,ecx
       je        short M02_L03
       mov       rcx,[rbp+0FFE8]
       call      System.Threading.Monitor.Exit(System.Object)
M02_L03:
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 425
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(Int32, System.__Canon, System.Collections.Generic.InsertionBehavior)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rsi,rcx
       mov       edi,edx
       mov       rbx,r8
       mov       ebp,r9d
       cmp       qword ptr [rsi+8],0
       jne       short M03_L00
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFB0D975AE0]
M03_L00:
       mov       r14,[rsi+10]
       mov       r15,[rsi+18]
       test      r15,r15
       jne       near ptr M03_L20
       mov       r12d,edi
M03_L01:
       xor       r13d,r13d
       mov       rdx,[rsi+8]
       mov       ecx,[rdx+8]
       mov       eax,ecx
       mov       r8,[rsi+30]
       mov       r9d,r12d
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       eax,eax
       imul      rax,r8
       shr       rax,20
       cmp       eax,ecx
       jae       near ptr M03_L21
       movsxd    rcx,eax
       lea       rax,[rdx+rcx*4+10]
       mov       r8d,[rax]
       dec       r8d
       test      r15,r15
       jne       near ptr M03_L13
M03_L02:
       cmp       [r14+8],r8d
       ja        short M03_L07
M03_L03:
       cmp       dword ptr [rsi+40],0
       jg        near ptr M03_L10
       mov       r15d,[rsi+38]
       cmp       [r14+8],r15d
       je        near ptr M03_L09
M03_L04:
       lea       edx,[r15+1]
       mov       [rsi+38],edx
       mov       r14,[rsi+10]
M03_L05:
       cmp       r15d,[r14+8]
       jae       near ptr M03_L21
       movsxd    rdx,r15d
       lea       rdx,[rdx+rdx*2]
       lea       rcx,[r14+rdx*8+10]
       mov       [rcx+8],r12d
       mov       [rsp+28],rax
       mov       edx,[rax]
       dec       edx
       mov       [rcx+0C],edx
       mov       [rcx+10],edi
       mov       rdx,rbx
       call      qword ptr [7FFB0D970590]
       inc       r15d
       mov       rbx,[rsp+28]
       mov       [rbx],r15d
       inc       dword ptr [rsi+44]
M03_L06:
       mov       eax,1
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L07:
       movsxd    rcx,r8d
       lea       rcx,[rcx+rcx*2]
       lea       r15,[r14+rcx*8+10]
       cmp       [r15+8],r12d
       mov       [rsp+34],r8d
       je        near ptr M03_L11
M03_L08:
       mov       r8d,[r15+0C]
       inc       r13d
       cmp       [r14+8],r13d
       jb        near ptr M03_L19
       jmp       near ptr M03_L02
M03_L09:
       mov       ecx,[rsi+38]
       call      qword ptr [7FFB0D974AE0]
       mov       edx,eax
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFB0D975AF0]
       mov       rax,[rsi+8]
       mov       edx,[rax+8]
       mov       ecx,edx
       mov       r8,[rsi+30]
       mov       r9d,r12d
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       ecx,ecx
       imul      rcx,r8
       shr       rcx,20
       cmp       ecx,edx
       jae       near ptr M03_L21
       movsxd    rdx,ecx
       lea       rax,[rax+rdx*4+10]
       mov       [rsp+28],rax
       mov       rax,[rsp+28]
       jmp       near ptr M03_L04
M03_L10:
       mov       edx,[rsi+3C]
       mov       r15d,edx
       cmp       edx,[r14+8]
       jae       near ptr M03_L21
       movsxd    rdx,edx
       lea       rdx,[rdx+rdx*2]
       mov       edx,[r14+rdx*8+1C]
       neg       edx
       add       edx,0FFFFFFFD
       mov       [rsi+3C],edx
       dec       dword ptr [rsi+40]
       jmp       near ptr M03_L05
M03_L11:
       mov       [rsp+28],rax
       call      qword ptr [7FFB0D971340]
       mov       rdx,[rax]
       mov       ecx,[r15+10]
       cmp       [rdx],edx
       cmp       ecx,edi
       sete      dl
       movzx     edx,dl
       test      edx,edx
       mov       rax,[rsp+28]
       je        near ptr M03_L08
       mov       r8d,[rsp+34]
       cmp       bpl,1
       jne       short M03_L12
       movsxd    rdx,r8d
       lea       rdx,[rdx+rdx*2]
       lea       rcx,[r14+rdx*8+10]
       mov       rdx,rbx
       call      qword ptr [7FFB0D970588]
       jmp       near ptr M03_L06
M03_L12:
       cmp       bpl,2
       jne       near ptr M03_L17
       jmp       near ptr M03_L16
M03_L13:
       cmp       [r14+8],r8d
       jbe       near ptr M03_L03
       movsxd    rdx,r8d
       lea       rdx,[rdx+rdx*2]
       cmp       [r14+rdx*8+18],r12d
       jne       near ptr M03_L18
       mov       [rsp+28],rax
       mov       [rsp+34],r8d
       movsxd    rdx,r8d
       lea       rdx,[rdx+rdx*2]
       mov       edx,[r14+rdx*8+20]
       mov       rcx,r15
       mov       r8d,edi
       lea       r11,[7FFB0D96FDC0]
       call      qword ptr [7FFB0D96FDC0]
       test      al,al
       mov       rax,[rsp+28]
       je        short M03_L14
       cmp       bpl,1
       jne       short M03_L15
       mov       esi,[rsp+34]
       movsxd    rdx,esi
       lea       rdx,[rdx+rdx*2]
       lea       rcx,[r14+rdx*8+10]
       mov       rdx,rbx
       call      qword ptr [7FFB0D970588]
       jmp       near ptr M03_L06
M03_L14:
       mov       r8d,[rsp+34]
       jmp       short M03_L18
M03_L15:
       cmp       bpl,2
       jne       short M03_L17
M03_L16:
       mov       ecx,edi
       call      qword ptr [7FFB0D969248]
       int       3
M03_L17:
       xor       eax,eax
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L18:
       movsxd    r8,r8d
       lea       rdx,[r8+r8*2]
       mov       r8d,[r14+rdx*8+1C]
       inc       r13d
       cmp       [r14+8],r13d
       jae       near ptr M03_L13
M03_L19:
       call      qword ptr [7FFB0D96D150]
       int       3
M03_L20:
       mov       rcx,r15
       mov       edx,edi
       lea       r11,[7FFB0D96FDC8]
       call      qword ptr [7FFB0D96FDC8]
       mov       r12d,eax
       jmp       near ptr M03_L01
M03_L21:
       call      qword ptr [7FFB0D970578]
       int       3
; Total bytes of code 760
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.BytesToString(Byte[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M04_L00
       mov       rax,1B6BEFD3020
       mov       rdi,[rax]
       mov       rax,1B6BEFD5608
       mov       rbx,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M04_L00:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       ebx,[rsi+8]
       mov       edx,ebx
       mov       rcx,rdi
       mov       r8d,7FFFFFFF
       call      System.Text.StringBuilder..ctor(Int32, Int32)
       xor       ebp,ebp
       test      ebx,ebx
       jle       short M04_L02
       mov       rdx,1B6BEFD1568
       mov       r14,[rdx]
       mov       rdx,1B6BEFD6810
       mov       r15,[rdx]
M04_L01:
       movsxd    rdx,ebp
       lea       rdx,[rsi+rdx+10]
       mov       r8,r14
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r15
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|42_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       add       ebp,1
       jo        short M04_L03
       cmp       ebx,ebp
       jg        short M04_L01
M04_L02:
       mov       rcx,rdi
       mov       rax,[7FFAAF3E78C0]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       rax
M04_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 223
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowKeyNotFoundException[[System.Int32, System.Private.CoreLib]](Int32)

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.BytesToString01()
; 			var result = base.GetByteArray(1).BytesToString();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       vzeroupper
       mov       rsi,rcx
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       mov       edx,1
       call      System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       test      rax,rax
       jne       short M00_L00
       mov       rdi,[rsi+8]
       vmovsd    xmm0,qword ptr [7FFAAF3BB050]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       mov       r8,rax
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,1
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(Int32, System.__Canon, System.Collections.Generic.InsertionBehavior)
M00_L00:
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       mov       edx,1
       call      System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       test      rax,rax
       je        short M00_L01
       mov       rcx,[rax]
       call      DotNetTips.Spargine.Extensions.ArrayExtensions.BytesToString(Byte[])
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M00_L01:
       mov       ecx,1
       call      System.ThrowHelper.ThrowKeyNotFoundException[[System.Int32, System.Private.CoreLib]](Int32)
       int       3
; Total bytes of code 140
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       edi,edx
       mov       rax,[rsi]
       mov       rax,[rax+30]
       mov       rbx,[rax]
       cmp       qword ptr [rsi+8],0
       jne       short M01_L01
M01_L00:
       cmp       qword ptr [rbx+28],0
       je        near ptr M01_L05
       jmp       near ptr M01_L05
M01_L01:
       mov       rbp,[rsi+18]
       test      rbp,rbp
       jne       near ptr M01_L06
       mov       eax,edi
       mov       rcx,[rsi+8]
       mov       edx,[rcx+8]
       mov       r11d,edx
       mov       r8,[rsi+30]
       mov       r9d,eax
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       r11d,r11d
       imul      r11,r8
       shr       r11,20
       cmp       r11d,edx
       jae       near ptr M01_L11
       movsxd    rdx,r11d
       lea       rcx,[rcx+rdx*4+10]
       mov       ecx,[rcx]
       mov       rdx,[rsi+10]
       xor       r11d,r11d
       dec       ecx
       mov       r8d,[rdx+8]
M01_L02:
       cmp       r8d,ecx
       jbe       short M01_L00
       movsxd    rcx,ecx
       lea       rcx,[rcx+rcx*2]
       lea       r14,[rdx+rcx*8+10]
       cmp       [r14+8],edi
       jne       short M01_L03
       mov       ecx,[r14+10]
       cmp       ecx,eax
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       short M01_L04
M01_L03:
       mov       ecx,[r14+0C]
       inc       r11d
       cmp       r8d,r11d
       jb        near ptr M01_L09
       jmp       short M01_L02
M01_L04:
       mov       rax,r14
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L05:
       xor       r14d,r14d
       jmp       short M01_L04
M01_L06:
       mov       rcx,rbp
       mov       edx,edi
       mov       r11,7FFAAEE00670
       call      qword ptr [7FFAAF3C0670]
       mov       r14d,eax
       mov       rdx,[rsi+8]
       mov       ecx,[rdx+8]
       mov       r8,[rsi+30]
       mov       r11d,r14d
       imul      r8,r11
       shr       r8,20
       inc       r8
       mov       ecx,ecx
       imul      rcx,r8
       shr       rcx,20
       cmp       ecx,[rdx+8]
       jae       short M01_L11
       movsxd    rcx,ecx
       lea       rdx,[rdx+rcx*4+10]
       mov       r15d,[rdx]
       mov       r12,[rsi+10]
       xor       r13d,r13d
       dec       r15d
M01_L07:
       cmp       [r12+8],r15d
       jbe       near ptr M01_L00
       movsxd    rdx,r15d
       lea       rdx,[rdx+rdx*2]
       lea       rdx,[r12+rdx*8+10]
       mov       r15,rdx
       cmp       [r15+8],r14d
       jne       short M01_L08
       mov       edx,[r15+10]
       mov       rcx,rbp
       mov       r8d,edi
       mov       r11,7FFAAEE00678
       call      qword ptr [7FFAAF3C0678]
       test      eax,eax
       jne       short M01_L10
M01_L08:
       mov       r15d,[r15+0C]
       inc       r13d
       cmp       [r12+8],r13d
       jae       short M01_L07
M01_L09:
       call      System.ThrowHelper.ThrowInvalidOperationException_ConcurrentOperationsNotSupported()
       int       3
M01_L10:
       mov       r14,r15
       jmp       near ptr M01_L04
M01_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 408
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       push      rbp
       sub       rsp,0A0
       vzeroupper
       lea       rbp,[rsp+0A0]
       xor       eax,eax
       mov       [rbp+0FF98],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFA0
M02_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M02_L00
       mov       [rbp+0FF88],rsp
       vmovsd    qword ptr [rbp+10],xmm0
       call      System.Globalization.CultureInfo.get_InvariantCulture()
       mov       [rbp+0FFD8],rax
       mov       rcx,offset MT_System.Double
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp+0FFD0],rax
       call      DotNetTips.Spargine.Tester.Properties.Resources.get_SizeMustBeEpsilon()
       mov       [rbp+0FFC8],rax
       mov       r8,[rbp+0FFD0]
       mov       qword ptr [r8+8],1
       mov       r8,[rbp+0FFD0]
       mov       rcx,[rbp+0FFD8]
       mov       rdx,[rbp+0FFC8]
       call      System.String.Format(System.IFormatProvider, System.String, System.Object)
       mov       [rbp+0FFC0],rax
       mov       r9,1596ADB2D58
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,[rbp+0FFC0]
       vmovsd    xmm2,qword ptr [rbp+10]
       vucomisd  xmm2,qword ptr [7FFAAF1C8A38]
       setae     dl
       movzx     edx,dl
       vxorps    xmm2,xmm2,xmm2
       vmovsd    xmm0,qword ptr [rbp+10]
       call      DotNetTips.Spargine.Core.Validator.ArgumentMeetsCondition[[System.Double, System.Private.CoreLib]](Double, Boolean, Double, System.String, System.String)
       vmovsd    qword ptr [rbp+10],xmm0
       vmovsd    xmm0,qword ptr [rbp+10]
       vmulsd    xmm0,xmm0,qword ptr [7FFAAF1C8A40]
       call      System.Convert.ToInt32(Double)
       movsxd    rdx,eax
       mov       [rbp+0FFB8],rdx
       mov       rdx,[rbp+0FFB8]
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp+0FFB0],rax
       mov       rdx,[rbp+0FFB0]
       lea       rcx,[rbp+0FFF0]
       call      System.Span`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte[])
       mov       rdx,1596ADAB850
       mov       rdx,[rdx]
       mov       [rbp+0FFE8],rdx
       xor       edx,edx
       mov       [rbp+0FFE0],edx
       lea       rdx,[rbp+0FFE0]
       mov       rcx,[rbp+0FFE8]
       call      System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,1596ADAB858
       mov       rcx,[rcx]
       mov       [rbp+0FF98],rcx
       vmovdqu   xmm0,xmmword ptr [rbp+0FFF0]
       vmovdqu   xmmword ptr [rbp+0FFA0],xmm0
       mov       rcx,[rbp+0FF98]
       lea       rdx,[rbp+0FFA0]
       mov       rax,[rbp+0FF98]
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       jmp       short M02_L01
M02_L01:
       mov       rcx,rsp
       call      M02_L02
       nop
       lea       rcx,[rbp+0FFF0]
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].ToArray()
       nop
       add       rsp,0A0
       pop       rbp
       ret
M02_L02:
       push      rbp
       sub       rsp,30
       vzeroupper
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+0A0]
       mov       ecx,[rbp+0FFE0]
       movzx     ecx,cl
       test      ecx,ecx
       je        short M02_L03
       mov       rcx,[rbp+0FFE8]
       call      System.Threading.Monitor.Exit(System.Object)
M02_L03:
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 425
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(Int32, System.__Canon, System.Collections.Generic.InsertionBehavior)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rsi,rcx
       mov       edi,edx
       mov       rbx,r8
       mov       ebp,r9d
       cmp       qword ptr [rsi+8],0
       jne       short M03_L00
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFB0D975AE0]
M03_L00:
       mov       r14,[rsi+10]
       mov       r15,[rsi+18]
       test      r15,r15
       jne       near ptr M03_L20
       mov       r12d,edi
M03_L01:
       xor       r13d,r13d
       mov       rdx,[rsi+8]
       mov       ecx,[rdx+8]
       mov       eax,ecx
       mov       r8,[rsi+30]
       mov       r9d,r12d
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       eax,eax
       imul      rax,r8
       shr       rax,20
       cmp       eax,ecx
       jae       near ptr M03_L21
       movsxd    rcx,eax
       lea       rax,[rdx+rcx*4+10]
       mov       r8d,[rax]
       dec       r8d
       test      r15,r15
       jne       near ptr M03_L13
M03_L02:
       cmp       [r14+8],r8d
       ja        short M03_L07
M03_L03:
       cmp       dword ptr [rsi+40],0
       jg        near ptr M03_L10
       mov       r15d,[rsi+38]
       cmp       [r14+8],r15d
       je        near ptr M03_L09
M03_L04:
       lea       edx,[r15+1]
       mov       [rsi+38],edx
       mov       r14,[rsi+10]
M03_L05:
       cmp       r15d,[r14+8]
       jae       near ptr M03_L21
       movsxd    rdx,r15d
       lea       rdx,[rdx+rdx*2]
       lea       rcx,[r14+rdx*8+10]
       mov       [rcx+8],r12d
       mov       [rsp+28],rax
       mov       edx,[rax]
       dec       edx
       mov       [rcx+0C],edx
       mov       [rcx+10],edi
       mov       rdx,rbx
       call      qword ptr [7FFB0D970590]
       inc       r15d
       mov       rbx,[rsp+28]
       mov       [rbx],r15d
       inc       dword ptr [rsi+44]
M03_L06:
       mov       eax,1
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L07:
       movsxd    rcx,r8d
       lea       rcx,[rcx+rcx*2]
       lea       r15,[r14+rcx*8+10]
       cmp       [r15+8],r12d
       mov       [rsp+34],r8d
       je        near ptr M03_L11
M03_L08:
       mov       r8d,[r15+0C]
       inc       r13d
       cmp       [r14+8],r13d
       jb        near ptr M03_L19
       jmp       near ptr M03_L02
M03_L09:
       mov       ecx,[rsi+38]
       call      qword ptr [7FFB0D974AE0]
       mov       edx,eax
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFB0D975AF0]
       mov       rax,[rsi+8]
       mov       edx,[rax+8]
       mov       ecx,edx
       mov       r8,[rsi+30]
       mov       r9d,r12d
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       ecx,ecx
       imul      rcx,r8
       shr       rcx,20
       cmp       ecx,edx
       jae       near ptr M03_L21
       movsxd    rdx,ecx
       lea       rax,[rax+rdx*4+10]
       mov       [rsp+28],rax
       mov       rax,[rsp+28]
       jmp       near ptr M03_L04
M03_L10:
       mov       edx,[rsi+3C]
       mov       r15d,edx
       cmp       edx,[r14+8]
       jae       near ptr M03_L21
       movsxd    rdx,edx
       lea       rdx,[rdx+rdx*2]
       mov       edx,[r14+rdx*8+1C]
       neg       edx
       add       edx,0FFFFFFFD
       mov       [rsi+3C],edx
       dec       dword ptr [rsi+40]
       jmp       near ptr M03_L05
M03_L11:
       mov       [rsp+28],rax
       call      qword ptr [7FFB0D971340]
       mov       rdx,[rax]
       mov       ecx,[r15+10]
       cmp       [rdx],edx
       cmp       ecx,edi
       sete      dl
       movzx     edx,dl
       test      edx,edx
       mov       rax,[rsp+28]
       je        near ptr M03_L08
       mov       r8d,[rsp+34]
       cmp       bpl,1
       jne       short M03_L12
       movsxd    rdx,r8d
       lea       rdx,[rdx+rdx*2]
       lea       rcx,[r14+rdx*8+10]
       mov       rdx,rbx
       call      qword ptr [7FFB0D970588]
       jmp       near ptr M03_L06
M03_L12:
       cmp       bpl,2
       jne       near ptr M03_L17
       jmp       near ptr M03_L16
M03_L13:
       cmp       [r14+8],r8d
       jbe       near ptr M03_L03
       movsxd    rdx,r8d
       lea       rdx,[rdx+rdx*2]
       cmp       [r14+rdx*8+18],r12d
       jne       near ptr M03_L18
       mov       [rsp+28],rax
       mov       [rsp+34],r8d
       movsxd    rdx,r8d
       lea       rdx,[rdx+rdx*2]
       mov       edx,[r14+rdx*8+20]
       mov       rcx,r15
       mov       r8d,edi
       lea       r11,[7FFB0D96FDC0]
       call      qword ptr [7FFB0D96FDC0]
       test      al,al
       mov       rax,[rsp+28]
       je        short M03_L14
       cmp       bpl,1
       jne       short M03_L15
       mov       esi,[rsp+34]
       movsxd    rdx,esi
       lea       rdx,[rdx+rdx*2]
       lea       rcx,[r14+rdx*8+10]
       mov       rdx,rbx
       call      qword ptr [7FFB0D970588]
       jmp       near ptr M03_L06
M03_L14:
       mov       r8d,[rsp+34]
       jmp       short M03_L18
M03_L15:
       cmp       bpl,2
       jne       short M03_L17
M03_L16:
       mov       ecx,edi
       call      qword ptr [7FFB0D969248]
       int       3
M03_L17:
       xor       eax,eax
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L18:
       movsxd    r8,r8d
       lea       rdx,[r8+r8*2]
       mov       r8d,[r14+rdx*8+1C]
       inc       r13d
       cmp       [r14+8],r13d
       jae       near ptr M03_L13
M03_L19:
       call      qword ptr [7FFB0D96D150]
       int       3
M03_L20:
       mov       rcx,r15
       mov       edx,edi
       lea       r11,[7FFB0D96FDC8]
       call      qword ptr [7FFB0D96FDC8]
       mov       r12d,eax
       jmp       near ptr M03_L01
M03_L21:
       call      qword ptr [7FFB0D970578]
       int       3
; Total bytes of code 760
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.BytesToString(Byte[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M04_L00
       mov       rax,1596ADA3020
       mov       rdi,[rax]
       mov       rax,1598ADA1200
       mov       rbx,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M04_L00:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       ebx,[rsi+8]
       mov       edx,ebx
       mov       rcx,rdi
       mov       r8d,7FFFFFFF
       call      System.Text.StringBuilder..ctor(Int32, Int32)
       xor       ebp,ebp
       test      ebx,ebx
       jle       short M04_L02
       mov       rdx,1596ADA1568
       mov       r14,[rdx]
       mov       rdx,1596ADB3440
       mov       r15,[rdx]
M04_L01:
       movsxd    rdx,ebp
       lea       rdx,[rsi+rdx+10]
       mov       r8,r14
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r15
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|42_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       add       ebp,1
       jo        short M04_L03
       cmp       ebx,ebp
       jg        short M04_L01
M04_L02:
       mov       rcx,rdi
       mov       rax,[7FFAAF3B78C0]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       rax
M04_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 223
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowKeyNotFoundException[[System.Int32, System.Private.CoreLib]](Int32)

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.BytesToString01()
; 			var result = base.GetByteArray(1).BytesToString();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       vzeroupper
       mov       rsi,rcx
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       mov       edx,1
       call      System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       test      rax,rax
       jne       short M00_L00
       mov       rdi,[rsi+8]
       vmovsd    xmm0,qword ptr [7FFAAF3DB050]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       mov       r8,rax
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,1
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(Int32, System.__Canon, System.Collections.Generic.InsertionBehavior)
M00_L00:
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       mov       edx,1
       call      System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       test      rax,rax
       je        short M00_L01
       mov       rcx,[rax]
       call      DotNetTips.Spargine.Extensions.ArrayExtensions.BytesToString(Byte[])
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M00_L01:
       mov       ecx,1
       call      System.ThrowHelper.ThrowKeyNotFoundException[[System.Int32, System.Private.CoreLib]](Int32)
       int       3
; Total bytes of code 140
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       edi,edx
       mov       rax,[rsi]
       mov       rax,[rax+30]
       mov       rbx,[rax]
       cmp       qword ptr [rsi+8],0
       jne       short M01_L01
M01_L00:
       cmp       qword ptr [rbx+28],0
       je        near ptr M01_L05
       jmp       near ptr M01_L05
M01_L01:
       mov       rbp,[rsi+18]
       test      rbp,rbp
       jne       near ptr M01_L06
       mov       eax,edi
       mov       rcx,[rsi+8]
       mov       edx,[rcx+8]
       mov       r11d,edx
       mov       r8,[rsi+30]
       mov       r9d,eax
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       r11d,r11d
       imul      r11,r8
       shr       r11,20
       cmp       r11d,edx
       jae       near ptr M01_L11
       movsxd    rdx,r11d
       lea       rcx,[rcx+rdx*4+10]
       mov       ecx,[rcx]
       mov       rdx,[rsi+10]
       xor       r11d,r11d
       dec       ecx
       mov       r8d,[rdx+8]
M01_L02:
       cmp       r8d,ecx
       jbe       short M01_L00
       movsxd    rcx,ecx
       lea       rcx,[rcx+rcx*2]
       lea       r14,[rdx+rcx*8+10]
       cmp       [r14+8],edi
       jne       short M01_L03
       mov       ecx,[r14+10]
       cmp       ecx,eax
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       short M01_L04
M01_L03:
       mov       ecx,[r14+0C]
       inc       r11d
       cmp       r8d,r11d
       jb        near ptr M01_L09
       jmp       short M01_L02
M01_L04:
       mov       rax,r14
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L05:
       xor       r14d,r14d
       jmp       short M01_L04
M01_L06:
       mov       rcx,rbp
       mov       edx,edi
       mov       r11,7FFAAEE20670
       call      qword ptr [7FFAAF3E0670]
       mov       r14d,eax
       mov       rdx,[rsi+8]
       mov       ecx,[rdx+8]
       mov       r8,[rsi+30]
       mov       r11d,r14d
       imul      r8,r11
       shr       r8,20
       inc       r8
       mov       ecx,ecx
       imul      rcx,r8
       shr       rcx,20
       cmp       ecx,[rdx+8]
       jae       short M01_L11
       movsxd    rcx,ecx
       lea       rdx,[rdx+rcx*4+10]
       mov       r15d,[rdx]
       mov       r12,[rsi+10]
       xor       r13d,r13d
       dec       r15d
M01_L07:
       cmp       [r12+8],r15d
       jbe       near ptr M01_L00
       movsxd    rdx,r15d
       lea       rdx,[rdx+rdx*2]
       lea       rdx,[r12+rdx*8+10]
       mov       r15,rdx
       cmp       [r15+8],r14d
       jne       short M01_L08
       mov       edx,[r15+10]
       mov       rcx,rbp
       mov       r8d,edi
       mov       r11,7FFAAEE20678
       call      qword ptr [7FFAAF3E0678]
       test      eax,eax
       jne       short M01_L10
M01_L08:
       mov       r15d,[r15+0C]
       inc       r13d
       cmp       [r12+8],r13d
       jae       short M01_L07
M01_L09:
       call      System.ThrowHelper.ThrowInvalidOperationException_ConcurrentOperationsNotSupported()
       int       3
M01_L10:
       mov       r14,r15
       jmp       near ptr M01_L04
M01_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 408
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       push      rbp
       sub       rsp,0A0
       vzeroupper
       lea       rbp,[rsp+0A0]
       xor       eax,eax
       mov       [rbp+0FF98],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFA0
M02_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M02_L00
       mov       [rbp+0FF88],rsp
       vmovsd    qword ptr [rbp+10],xmm0
       call      System.Globalization.CultureInfo.get_InvariantCulture()
       mov       [rbp+0FFD8],rax
       mov       rcx,offset MT_System.Double
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp+0FFD0],rax
       call      DotNetTips.Spargine.Tester.Properties.Resources.get_SizeMustBeEpsilon()
       mov       [rbp+0FFC8],rax
       mov       r8,[rbp+0FFD0]
       mov       qword ptr [r8+8],1
       mov       r8,[rbp+0FFD0]
       mov       rcx,[rbp+0FFD8]
       mov       rdx,[rbp+0FFC8]
       call      System.String.Format(System.IFormatProvider, System.String, System.Object)
       mov       [rbp+0FFC0],rax
       mov       r9,2632A182520
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,[rbp+0FFC0]
       vmovsd    xmm2,qword ptr [rbp+10]
       vucomisd  xmm2,qword ptr [7FFAAF1E8A38]
       setae     dl
       movzx     edx,dl
       vxorps    xmm2,xmm2,xmm2
       vmovsd    xmm0,qword ptr [rbp+10]
       call      DotNetTips.Spargine.Core.Validator.ArgumentMeetsCondition[[System.Double, System.Private.CoreLib]](Double, Boolean, Double, System.String, System.String)
       vmovsd    qword ptr [rbp+10],xmm0
       vmovsd    xmm0,qword ptr [rbp+10]
       vmulsd    xmm0,xmm0,qword ptr [7FFAAF1E8A40]
       call      System.Convert.ToInt32(Double)
       movsxd    rdx,eax
       mov       [rbp+0FFB8],rdx
       mov       rdx,[rbp+0FFB8]
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp+0FFB0],rax
       mov       rdx,[rbp+0FFB0]
       lea       rcx,[rbp+0FFF0]
       call      System.Span`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte[])
       mov       rdx,2630A18B850
       mov       rdx,[rdx]
       mov       [rbp+0FFE8],rdx
       xor       edx,edx
       mov       [rbp+0FFE0],edx
       lea       rdx,[rbp+0FFE0]
       mov       rcx,[rbp+0FFE8]
       call      System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,2630A18B858
       mov       rcx,[rcx]
       mov       [rbp+0FF98],rcx
       vmovdqu   xmm0,xmmword ptr [rbp+0FFF0]
       vmovdqu   xmmword ptr [rbp+0FFA0],xmm0
       mov       rcx,[rbp+0FF98]
       lea       rdx,[rbp+0FFA0]
       mov       rax,[rbp+0FF98]
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       jmp       short M02_L01
M02_L01:
       mov       rcx,rsp
       call      M02_L02
       nop
       lea       rcx,[rbp+0FFF0]
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].ToArray()
       nop
       add       rsp,0A0
       pop       rbp
       ret
M02_L02:
       push      rbp
       sub       rsp,30
       vzeroupper
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+0A0]
       mov       ecx,[rbp+0FFE0]
       movzx     ecx,cl
       test      ecx,ecx
       je        short M02_L03
       mov       rcx,[rbp+0FFE8]
       call      System.Threading.Monitor.Exit(System.Object)
M02_L03:
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 425
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(Int32, System.__Canon, System.Collections.Generic.InsertionBehavior)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rsi,rcx
       mov       edi,edx
       mov       rbx,r8
       mov       ebp,r9d
       cmp       qword ptr [rsi+8],0
       jne       short M03_L00
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFB0D975AE0]
M03_L00:
       mov       r14,[rsi+10]
       mov       r15,[rsi+18]
       test      r15,r15
       jne       near ptr M03_L20
       mov       r12d,edi
M03_L01:
       xor       r13d,r13d
       mov       rdx,[rsi+8]
       mov       ecx,[rdx+8]
       mov       eax,ecx
       mov       r8,[rsi+30]
       mov       r9d,r12d
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       eax,eax
       imul      rax,r8
       shr       rax,20
       cmp       eax,ecx
       jae       near ptr M03_L21
       movsxd    rcx,eax
       lea       rax,[rdx+rcx*4+10]
       mov       r8d,[rax]
       dec       r8d
       test      r15,r15
       jne       near ptr M03_L13
M03_L02:
       cmp       [r14+8],r8d
       ja        short M03_L07
M03_L03:
       cmp       dword ptr [rsi+40],0
       jg        near ptr M03_L10
       mov       r15d,[rsi+38]
       cmp       [r14+8],r15d
       je        near ptr M03_L09
M03_L04:
       lea       edx,[r15+1]
       mov       [rsi+38],edx
       mov       r14,[rsi+10]
M03_L05:
       cmp       r15d,[r14+8]
       jae       near ptr M03_L21
       movsxd    rdx,r15d
       lea       rdx,[rdx+rdx*2]
       lea       rcx,[r14+rdx*8+10]
       mov       [rcx+8],r12d
       mov       [rsp+28],rax
       mov       edx,[rax]
       dec       edx
       mov       [rcx+0C],edx
       mov       [rcx+10],edi
       mov       rdx,rbx
       call      qword ptr [7FFB0D970590]
       inc       r15d
       mov       rbx,[rsp+28]
       mov       [rbx],r15d
       inc       dword ptr [rsi+44]
M03_L06:
       mov       eax,1
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L07:
       movsxd    rcx,r8d
       lea       rcx,[rcx+rcx*2]
       lea       r15,[r14+rcx*8+10]
       cmp       [r15+8],r12d
       mov       [rsp+34],r8d
       je        near ptr M03_L11
M03_L08:
       mov       r8d,[r15+0C]
       inc       r13d
       cmp       [r14+8],r13d
       jb        near ptr M03_L19
       jmp       near ptr M03_L02
M03_L09:
       mov       ecx,[rsi+38]
       call      qword ptr [7FFB0D974AE0]
       mov       edx,eax
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFB0D975AF0]
       mov       rax,[rsi+8]
       mov       edx,[rax+8]
       mov       ecx,edx
       mov       r8,[rsi+30]
       mov       r9d,r12d
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       ecx,ecx
       imul      rcx,r8
       shr       rcx,20
       cmp       ecx,edx
       jae       near ptr M03_L21
       movsxd    rdx,ecx
       lea       rax,[rax+rdx*4+10]
       mov       [rsp+28],rax
       mov       rax,[rsp+28]
       jmp       near ptr M03_L04
M03_L10:
       mov       edx,[rsi+3C]
       mov       r15d,edx
       cmp       edx,[r14+8]
       jae       near ptr M03_L21
       movsxd    rdx,edx
       lea       rdx,[rdx+rdx*2]
       mov       edx,[r14+rdx*8+1C]
       neg       edx
       add       edx,0FFFFFFFD
       mov       [rsi+3C],edx
       dec       dword ptr [rsi+40]
       jmp       near ptr M03_L05
M03_L11:
       mov       [rsp+28],rax
       call      qword ptr [7FFB0D971340]
       mov       rdx,[rax]
       mov       ecx,[r15+10]
       cmp       [rdx],edx
       cmp       ecx,edi
       sete      dl
       movzx     edx,dl
       test      edx,edx
       mov       rax,[rsp+28]
       je        near ptr M03_L08
       mov       r8d,[rsp+34]
       cmp       bpl,1
       jne       short M03_L12
       movsxd    rdx,r8d
       lea       rdx,[rdx+rdx*2]
       lea       rcx,[r14+rdx*8+10]
       mov       rdx,rbx
       call      qword ptr [7FFB0D970588]
       jmp       near ptr M03_L06
M03_L12:
       cmp       bpl,2
       jne       near ptr M03_L17
       jmp       near ptr M03_L16
M03_L13:
       cmp       [r14+8],r8d
       jbe       near ptr M03_L03
       movsxd    rdx,r8d
       lea       rdx,[rdx+rdx*2]
       cmp       [r14+rdx*8+18],r12d
       jne       near ptr M03_L18
       mov       [rsp+28],rax
       mov       [rsp+34],r8d
       movsxd    rdx,r8d
       lea       rdx,[rdx+rdx*2]
       mov       edx,[r14+rdx*8+20]
       mov       rcx,r15
       mov       r8d,edi
       lea       r11,[7FFB0D96FDC0]
       call      qword ptr [7FFB0D96FDC0]
       test      al,al
       mov       rax,[rsp+28]
       je        short M03_L14
       cmp       bpl,1
       jne       short M03_L15
       mov       esi,[rsp+34]
       movsxd    rdx,esi
       lea       rdx,[rdx+rdx*2]
       lea       rcx,[r14+rdx*8+10]
       mov       rdx,rbx
       call      qword ptr [7FFB0D970588]
       jmp       near ptr M03_L06
M03_L14:
       mov       r8d,[rsp+34]
       jmp       short M03_L18
M03_L15:
       cmp       bpl,2
       jne       short M03_L17
M03_L16:
       mov       ecx,edi
       call      qword ptr [7FFB0D969248]
       int       3
M03_L17:
       xor       eax,eax
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L18:
       movsxd    r8,r8d
       lea       rdx,[r8+r8*2]
       mov       r8d,[r14+rdx*8+1C]
       inc       r13d
       cmp       [r14+8],r13d
       jae       near ptr M03_L13
M03_L19:
       call      qword ptr [7FFB0D96D150]
       int       3
M03_L20:
       mov       rcx,r15
       mov       edx,edi
       lea       r11,[7FFB0D96FDC8]
       call      qword ptr [7FFB0D96FDC8]
       mov       r12d,eax
       jmp       near ptr M03_L01
M03_L21:
       call      qword ptr [7FFB0D970578]
       int       3
; Total bytes of code 760
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.BytesToString(Byte[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M04_L00
       mov       rax,2630A183020
       mov       rdi,[rax]
       mov       rax,2633A181200
       mov       rbx,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M04_L00:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       ebx,[rsi+8]
       mov       edx,ebx
       mov       rcx,rdi
       mov       r8d,7FFFFFFF
       call      System.Text.StringBuilder..ctor(Int32, Int32)
       xor       ebp,ebp
       test      ebx,ebx
       jle       short M04_L02
       mov       rdx,2630A181568
       mov       r14,[rdx]
       mov       rdx,2632A182C08
       mov       r15,[rdx]
M04_L01:
       movsxd    rdx,ebp
       lea       rdx,[rsi+rdx+10]
       mov       r8,r14
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r15
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|42_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       add       ebp,1
       jo        short M04_L03
       cmp       ebx,ebp
       jg        short M04_L01
M04_L02:
       mov       rcx,rdi
       mov       rax,[7FFAAF3D78C0]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       rax
M04_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 223
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowKeyNotFoundException[[System.Int32, System.Private.CoreLib]](Int32)

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.BytesToString01()
; 			var result = base.GetByteArray(1).BytesToString();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       vzeroupper
       mov       rsi,rcx
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       mov       edx,1
       call      System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       test      rax,rax
       jne       short M00_L00
       mov       rdi,[rsi+8]
       vmovsd    xmm0,qword ptr [7FFAAF3DB140]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       mov       r8,rax
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,1
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(Int32, System.__Canon, System.Collections.Generic.InsertionBehavior)
M00_L00:
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       mov       edx,1
       call      System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       test      rax,rax
       je        short M00_L01
       mov       rcx,[rax]
       call      DotNetTips.Spargine.Extensions.ArrayExtensions.BytesToString(Byte[])
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M00_L01:
       mov       ecx,1
       call      System.ThrowHelper.ThrowKeyNotFoundException[[System.Int32, System.Private.CoreLib]](Int32)
       int       3
; Total bytes of code 140
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       edi,edx
       mov       rax,[rsi]
       mov       rax,[rax+30]
       mov       rbx,[rax]
       cmp       qword ptr [rsi+8],0
       jne       short M01_L01
M01_L00:
       cmp       qword ptr [rbx+28],0
       je        near ptr M01_L05
       jmp       near ptr M01_L05
M01_L01:
       mov       rbp,[rsi+18]
       test      rbp,rbp
       jne       near ptr M01_L06
       mov       eax,edi
       mov       rcx,[rsi+8]
       mov       edx,[rcx+8]
       mov       r11d,edx
       mov       r8,[rsi+30]
       mov       r9d,eax
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       r11d,r11d
       imul      r11,r8
       shr       r11,20
       cmp       r11d,edx
       jae       near ptr M01_L11
       movsxd    rdx,r11d
       lea       rcx,[rcx+rdx*4+10]
       mov       ecx,[rcx]
       mov       rdx,[rsi+10]
       xor       r11d,r11d
       dec       ecx
       mov       r8d,[rdx+8]
M01_L02:
       cmp       r8d,ecx
       jbe       short M01_L00
       movsxd    rcx,ecx
       lea       rcx,[rcx+rcx*2]
       lea       r14,[rdx+rcx*8+10]
       cmp       [r14+8],edi
       jne       short M01_L03
       mov       ecx,[r14+10]
       cmp       ecx,eax
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       short M01_L04
M01_L03:
       mov       ecx,[r14+0C]
       inc       r11d
       cmp       r8d,r11d
       jb        near ptr M01_L09
       jmp       short M01_L02
M01_L04:
       mov       rax,r14
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L05:
       xor       r14d,r14d
       jmp       short M01_L04
M01_L06:
       mov       rcx,rbp
       mov       edx,edi
       mov       r11,7FFAAEE20670
       call      qword ptr [7FFAAF3E0670]
       mov       r14d,eax
       mov       rdx,[rsi+8]
       mov       ecx,[rdx+8]
       mov       r8,[rsi+30]
       mov       r11d,r14d
       imul      r8,r11
       shr       r8,20
       inc       r8
       mov       ecx,ecx
       imul      rcx,r8
       shr       rcx,20
       cmp       ecx,[rdx+8]
       jae       short M01_L11
       movsxd    rcx,ecx
       lea       rdx,[rdx+rcx*4+10]
       mov       r15d,[rdx]
       mov       r12,[rsi+10]
       xor       r13d,r13d
       dec       r15d
M01_L07:
       cmp       [r12+8],r15d
       jbe       near ptr M01_L00
       movsxd    rdx,r15d
       lea       rdx,[rdx+rdx*2]
       lea       rdx,[r12+rdx*8+10]
       mov       r15,rdx
       cmp       [r15+8],r14d
       jne       short M01_L08
       mov       edx,[r15+10]
       mov       rcx,rbp
       mov       r8d,edi
       mov       r11,7FFAAEE20678
       call      qword ptr [7FFAAF3E0678]
       test      eax,eax
       jne       short M01_L10
M01_L08:
       mov       r15d,[r15+0C]
       inc       r13d
       cmp       [r12+8],r13d
       jae       short M01_L07
M01_L09:
       call      System.ThrowHelper.ThrowInvalidOperationException_ConcurrentOperationsNotSupported()
       int       3
M01_L10:
       mov       r14,r15
       jmp       near ptr M01_L04
M01_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 408
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       push      rbp
       sub       rsp,0A0
       vzeroupper
       lea       rbp,[rsp+0A0]
       xor       eax,eax
       mov       [rbp+0FF98],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFA0
M02_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M02_L00
       mov       [rbp+0FF88],rsp
       vmovsd    qword ptr [rbp+10],xmm0
       call      System.Globalization.CultureInfo.get_InvariantCulture()
       mov       [rbp+0FFD8],rax
       mov       rcx,offset MT_System.Double
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp+0FFD0],rax
       call      DotNetTips.Spargine.Tester.Properties.Resources.get_SizeMustBeEpsilon()
       mov       [rbp+0FFC8],rax
       mov       r8,[rbp+0FFD0]
       mov       qword ptr [r8+8],1
       mov       r8,[rbp+0FFD0]
       mov       rcx,[rbp+0FFD8]
       mov       rdx,[rbp+0FFC8]
       call      System.String.Format(System.IFormatProvider, System.String, System.Object)
       mov       [rbp+0FFC0],rax
       mov       r9,1DCA6E75148
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,[rbp+0FFC0]
       vmovsd    xmm2,qword ptr [rbp+10]
       vucomisd  xmm2,qword ptr [7FFAAF1E8A38]
       setae     dl
       movzx     edx,dl
       vxorps    xmm2,xmm2,xmm2
       vmovsd    xmm0,qword ptr [rbp+10]
       call      DotNetTips.Spargine.Core.Validator.ArgumentMeetsCondition[[System.Double, System.Private.CoreLib]](Double, Boolean, Double, System.String, System.String)
       vmovsd    qword ptr [rbp+10],xmm0
       vmovsd    xmm0,qword ptr [rbp+10]
       vmulsd    xmm0,xmm0,qword ptr [7FFAAF1E8A40]
       call      System.Convert.ToInt32(Double)
       movsxd    rdx,eax
       mov       [rbp+0FFB8],rdx
       mov       rdx,[rbp+0FFB8]
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp+0FFB0],rax
       mov       rdx,[rbp+0FFB0]
       lea       rcx,[rbp+0FFF0]
       call      System.Span`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte[])
       mov       rdx,1DCC6E79440
       mov       rdx,[rdx]
       mov       [rbp+0FFE8],rdx
       xor       edx,edx
       mov       [rbp+0FFE0],edx
       lea       rdx,[rbp+0FFE0]
       mov       rcx,[rbp+0FFE8]
       call      System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,1DCC6E79448
       mov       rcx,[rcx]
       mov       [rbp+0FF98],rcx
       vmovdqu   xmm0,xmmword ptr [rbp+0FFF0]
       vmovdqu   xmmword ptr [rbp+0FFA0],xmm0
       mov       rcx,[rbp+0FF98]
       lea       rdx,[rbp+0FFA0]
       mov       rax,[rbp+0FF98]
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       jmp       short M02_L01
M02_L01:
       mov       rcx,rsp
       call      M02_L02
       nop
       lea       rcx,[rbp+0FFF0]
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].ToArray()
       nop
       add       rsp,0A0
       pop       rbp
       ret
M02_L02:
       push      rbp
       sub       rsp,30
       vzeroupper
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+0A0]
       mov       ecx,[rbp+0FFE0]
       movzx     ecx,cl
       test      ecx,ecx
       je        short M02_L03
       mov       rcx,[rbp+0FFE8]
       call      System.Threading.Monitor.Exit(System.Object)
M02_L03:
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 425
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(Int32, System.__Canon, System.Collections.Generic.InsertionBehavior)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rsi,rcx
       mov       edi,edx
       mov       rbx,r8
       mov       ebp,r9d
       cmp       qword ptr [rsi+8],0
       jne       short M03_L00
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFB0D975AE0]
M03_L00:
       mov       r14,[rsi+10]
       mov       r15,[rsi+18]
       test      r15,r15
       jne       near ptr M03_L20
       mov       r12d,edi
M03_L01:
       xor       r13d,r13d
       mov       rdx,[rsi+8]
       mov       ecx,[rdx+8]
       mov       eax,ecx
       mov       r8,[rsi+30]
       mov       r9d,r12d
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       eax,eax
       imul      rax,r8
       shr       rax,20
       cmp       eax,ecx
       jae       near ptr M03_L21
       movsxd    rcx,eax
       lea       rax,[rdx+rcx*4+10]
       mov       r8d,[rax]
       dec       r8d
       test      r15,r15
       jne       near ptr M03_L13
M03_L02:
       cmp       [r14+8],r8d
       ja        short M03_L07
M03_L03:
       cmp       dword ptr [rsi+40],0
       jg        near ptr M03_L10
       mov       r15d,[rsi+38]
       cmp       [r14+8],r15d
       je        near ptr M03_L09
M03_L04:
       lea       edx,[r15+1]
       mov       [rsi+38],edx
       mov       r14,[rsi+10]
M03_L05:
       cmp       r15d,[r14+8]
       jae       near ptr M03_L21
       movsxd    rdx,r15d
       lea       rdx,[rdx+rdx*2]
       lea       rcx,[r14+rdx*8+10]
       mov       [rcx+8],r12d
       mov       [rsp+28],rax
       mov       edx,[rax]
       dec       edx
       mov       [rcx+0C],edx
       mov       [rcx+10],edi
       mov       rdx,rbx
       call      qword ptr [7FFB0D970590]
       inc       r15d
       mov       rbx,[rsp+28]
       mov       [rbx],r15d
       inc       dword ptr [rsi+44]
M03_L06:
       mov       eax,1
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L07:
       movsxd    rcx,r8d
       lea       rcx,[rcx+rcx*2]
       lea       r15,[r14+rcx*8+10]
       cmp       [r15+8],r12d
       mov       [rsp+34],r8d
       je        near ptr M03_L11
M03_L08:
       mov       r8d,[r15+0C]
       inc       r13d
       cmp       [r14+8],r13d
       jb        near ptr M03_L19
       jmp       near ptr M03_L02
M03_L09:
       mov       ecx,[rsi+38]
       call      qword ptr [7FFB0D974AE0]
       mov       edx,eax
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFB0D975AF0]
       mov       rax,[rsi+8]
       mov       edx,[rax+8]
       mov       ecx,edx
       mov       r8,[rsi+30]
       mov       r9d,r12d
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       ecx,ecx
       imul      rcx,r8
       shr       rcx,20
       cmp       ecx,edx
       jae       near ptr M03_L21
       movsxd    rdx,ecx
       lea       rax,[rax+rdx*4+10]
       mov       [rsp+28],rax
       mov       rax,[rsp+28]
       jmp       near ptr M03_L04
M03_L10:
       mov       edx,[rsi+3C]
       mov       r15d,edx
       cmp       edx,[r14+8]
       jae       near ptr M03_L21
       movsxd    rdx,edx
       lea       rdx,[rdx+rdx*2]
       mov       edx,[r14+rdx*8+1C]
       neg       edx
       add       edx,0FFFFFFFD
       mov       [rsi+3C],edx
       dec       dword ptr [rsi+40]
       jmp       near ptr M03_L05
M03_L11:
       mov       [rsp+28],rax
       call      qword ptr [7FFB0D971340]
       mov       rdx,[rax]
       mov       ecx,[r15+10]
       cmp       [rdx],edx
       cmp       ecx,edi
       sete      dl
       movzx     edx,dl
       test      edx,edx
       mov       rax,[rsp+28]
       je        near ptr M03_L08
       mov       r8d,[rsp+34]
       cmp       bpl,1
       jne       short M03_L12
       movsxd    rdx,r8d
       lea       rdx,[rdx+rdx*2]
       lea       rcx,[r14+rdx*8+10]
       mov       rdx,rbx
       call      qword ptr [7FFB0D970588]
       jmp       near ptr M03_L06
M03_L12:
       cmp       bpl,2
       jne       near ptr M03_L17
       jmp       near ptr M03_L16
M03_L13:
       cmp       [r14+8],r8d
       jbe       near ptr M03_L03
       movsxd    rdx,r8d
       lea       rdx,[rdx+rdx*2]
       cmp       [r14+rdx*8+18],r12d
       jne       near ptr M03_L18
       mov       [rsp+28],rax
       mov       [rsp+34],r8d
       movsxd    rdx,r8d
       lea       rdx,[rdx+rdx*2]
       mov       edx,[r14+rdx*8+20]
       mov       rcx,r15
       mov       r8d,edi
       lea       r11,[7FFB0D96FDC0]
       call      qword ptr [7FFB0D96FDC0]
       test      al,al
       mov       rax,[rsp+28]
       je        short M03_L14
       cmp       bpl,1
       jne       short M03_L15
       mov       esi,[rsp+34]
       movsxd    rdx,esi
       lea       rdx,[rdx+rdx*2]
       lea       rcx,[r14+rdx*8+10]
       mov       rdx,rbx
       call      qword ptr [7FFB0D970588]
       jmp       near ptr M03_L06
M03_L14:
       mov       r8d,[rsp+34]
       jmp       short M03_L18
M03_L15:
       cmp       bpl,2
       jne       short M03_L17
M03_L16:
       mov       ecx,edi
       call      qword ptr [7FFB0D969248]
       int       3
M03_L17:
       xor       eax,eax
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L18:
       movsxd    r8,r8d
       lea       rdx,[r8+r8*2]
       mov       r8d,[r14+rdx*8+1C]
       inc       r13d
       cmp       [r14+8],r13d
       jae       near ptr M03_L13
M03_L19:
       call      qword ptr [7FFB0D96D150]
       int       3
M03_L20:
       mov       rcx,r15
       mov       edx,edi
       lea       r11,[7FFB0D96FDC8]
       call      qword ptr [7FFB0D96FDC8]
       mov       r12d,eax
       jmp       near ptr M03_L01
M03_L21:
       call      qword ptr [7FFB0D970578]
       int       3
; Total bytes of code 760
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.BytesToString(Byte[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M04_L00
       mov       rax,1DCA6E73020
       mov       rdi,[rax]
       mov       rax,1DCA6E73610
       mov       rbx,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M04_L00:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       ebx,[rsi+8]
       mov       edx,ebx
       mov       rcx,rdi
       mov       r8d,7FFFFFFF
       call      System.Text.StringBuilder..ctor(Int32, Int32)
       xor       ebp,ebp
       test      ebx,ebx
       jle       short M04_L02
       mov       rdx,1DCA6E71568
       mov       r14,[rdx]
       mov       rdx,1DCA6E75830
       mov       r15,[rdx]
M04_L01:
       movsxd    rdx,ebp
       lea       rdx,[rsi+rdx+10]
       mov       r8,r14
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r15
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|42_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       add       ebp,1
       jo        short M04_L03
       cmp       ebx,ebp
       jg        short M04_L01
M04_L02:
       mov       rcx,rdi
       mov       rax,[7FFAAF3D78C0]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       rax
M04_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 223
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowKeyNotFoundException[[System.Int32, System.Private.CoreLib]](Int32)

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.BytesToString01()
; 			var result = base.GetByteArray(1).BytesToString();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       vzeroupper
       mov       rsi,rcx
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       mov       edx,1
       call      System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       test      rax,rax
       jne       short M00_L00
       mov       rdi,[rsi+8]
       vmovsd    xmm0,qword ptr [7FFAAF3DB140]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       mov       r8,rax
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,1
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(Int32, System.__Canon, System.Collections.Generic.InsertionBehavior)
M00_L00:
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       mov       edx,1
       call      System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       test      rax,rax
       je        short M00_L01
       mov       rcx,[rax]
       call      DotNetTips.Spargine.Extensions.ArrayExtensions.BytesToString(Byte[])
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M00_L01:
       mov       ecx,1
       call      System.ThrowHelper.ThrowKeyNotFoundException[[System.Int32, System.Private.CoreLib]](Int32)
       int       3
; Total bytes of code 140
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       edi,edx
       mov       rax,[rsi]
       mov       rax,[rax+30]
       mov       rbx,[rax]
       cmp       qword ptr [rsi+8],0
       jne       short M01_L01
M01_L00:
       cmp       qword ptr [rbx+28],0
       je        near ptr M01_L05
       jmp       near ptr M01_L05
M01_L01:
       mov       rbp,[rsi+18]
       test      rbp,rbp
       jne       near ptr M01_L06
       mov       eax,edi
       mov       rcx,[rsi+8]
       mov       edx,[rcx+8]
       mov       r11d,edx
       mov       r8,[rsi+30]
       mov       r9d,eax
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       r11d,r11d
       imul      r11,r8
       shr       r11,20
       cmp       r11d,edx
       jae       near ptr M01_L11
       movsxd    rdx,r11d
       lea       rcx,[rcx+rdx*4+10]
       mov       ecx,[rcx]
       mov       rdx,[rsi+10]
       xor       r11d,r11d
       dec       ecx
       mov       r8d,[rdx+8]
M01_L02:
       cmp       r8d,ecx
       jbe       short M01_L00
       movsxd    rcx,ecx
       lea       rcx,[rcx+rcx*2]
       lea       r14,[rdx+rcx*8+10]
       cmp       [r14+8],edi
       jne       short M01_L03
       mov       ecx,[r14+10]
       cmp       ecx,eax
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       short M01_L04
M01_L03:
       mov       ecx,[r14+0C]
       inc       r11d
       cmp       r8d,r11d
       jb        near ptr M01_L09
       jmp       short M01_L02
M01_L04:
       mov       rax,r14
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L05:
       xor       r14d,r14d
       jmp       short M01_L04
M01_L06:
       mov       rcx,rbp
       mov       edx,edi
       mov       r11,7FFAAEE20670
       call      qword ptr [7FFAAF3E0670]
       mov       r14d,eax
       mov       rdx,[rsi+8]
       mov       ecx,[rdx+8]
       mov       r8,[rsi+30]
       mov       r11d,r14d
       imul      r8,r11
       shr       r8,20
       inc       r8
       mov       ecx,ecx
       imul      rcx,r8
       shr       rcx,20
       cmp       ecx,[rdx+8]
       jae       short M01_L11
       movsxd    rcx,ecx
       lea       rdx,[rdx+rcx*4+10]
       mov       r15d,[rdx]
       mov       r12,[rsi+10]
       xor       r13d,r13d
       dec       r15d
M01_L07:
       cmp       [r12+8],r15d
       jbe       near ptr M01_L00
       movsxd    rdx,r15d
       lea       rdx,[rdx+rdx*2]
       lea       rdx,[r12+rdx*8+10]
       mov       r15,rdx
       cmp       [r15+8],r14d
       jne       short M01_L08
       mov       edx,[r15+10]
       mov       rcx,rbp
       mov       r8d,edi
       mov       r11,7FFAAEE20678
       call      qword ptr [7FFAAF3E0678]
       test      eax,eax
       jne       short M01_L10
M01_L08:
       mov       r15d,[r15+0C]
       inc       r13d
       cmp       [r12+8],r13d
       jae       short M01_L07
M01_L09:
       call      System.ThrowHelper.ThrowInvalidOperationException_ConcurrentOperationsNotSupported()
       int       3
M01_L10:
       mov       r14,r15
       jmp       near ptr M01_L04
M01_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 408
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       push      rbp
       sub       rsp,0A0
       vzeroupper
       lea       rbp,[rsp+0A0]
       xor       eax,eax
       mov       [rbp+0FF98],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFA0
M02_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M02_L00
       mov       [rbp+0FF88],rsp
       vmovsd    qword ptr [rbp+10],xmm0
       call      System.Globalization.CultureInfo.get_InvariantCulture()
       mov       [rbp+0FFD8],rax
       mov       rcx,offset MT_System.Double
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp+0FFD0],rax
       call      DotNetTips.Spargine.Tester.Properties.Resources.get_SizeMustBeEpsilon()
       mov       [rbp+0FFC8],rax
       mov       r8,[rbp+0FFD0]
       mov       qword ptr [r8+8],1
       mov       r8,[rbp+0FFD0]
       mov       rcx,[rbp+0FFD8]
       mov       rdx,[rbp+0FFC8]
       call      System.String.Format(System.IFormatProvider, System.String, System.Object)
       mov       [rbp+0FFC0],rax
       mov       r9,232D1593570
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,[rbp+0FFC0]
       vmovsd    xmm2,qword ptr [rbp+10]
       vucomisd  xmm2,qword ptr [7FFAAF1E8A38]
       setae     dl
       movzx     edx,dl
       vxorps    xmm2,xmm2,xmm2
       vmovsd    xmm0,qword ptr [rbp+10]
       call      DotNetTips.Spargine.Core.Validator.ArgumentMeetsCondition[[System.Double, System.Private.CoreLib]](Double, Boolean, Double, System.String, System.String)
       vmovsd    qword ptr [rbp+10],xmm0
       vmovsd    xmm0,qword ptr [rbp+10]
       vmulsd    xmm0,xmm0,qword ptr [7FFAAF1E8A40]
       call      System.Convert.ToInt32(Double)
       movsxd    rdx,eax
       mov       [rbp+0FFB8],rdx
       mov       rdx,[rbp+0FFB8]
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp+0FFB0],rax
       mov       rdx,[rbp+0FFB0]
       lea       rcx,[rbp+0FFF0]
       call      System.Span`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte[])
       mov       rdx,232D158B850
       mov       rdx,[rdx]
       mov       [rbp+0FFE8],rdx
       xor       edx,edx
       mov       [rbp+0FFE0],edx
       lea       rdx,[rbp+0FFE0]
       mov       rcx,[rbp+0FFE8]
       call      System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,232D158B858
       mov       rcx,[rcx]
       mov       [rbp+0FF98],rcx
       vmovdqu   xmm0,xmmword ptr [rbp+0FFF0]
       vmovdqu   xmmword ptr [rbp+0FFA0],xmm0
       mov       rcx,[rbp+0FF98]
       lea       rdx,[rbp+0FFA0]
       mov       rax,[rbp+0FF98]
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       jmp       short M02_L01
M02_L01:
       mov       rcx,rsp
       call      M02_L02
       nop
       lea       rcx,[rbp+0FFF0]
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].ToArray()
       nop
       add       rsp,0A0
       pop       rbp
       ret
M02_L02:
       push      rbp
       sub       rsp,30
       vzeroupper
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+0A0]
       mov       ecx,[rbp+0FFE0]
       movzx     ecx,cl
       test      ecx,ecx
       je        short M02_L03
       mov       rcx,[rbp+0FFE8]
       call      System.Threading.Monitor.Exit(System.Object)
M02_L03:
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 425
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(Int32, System.__Canon, System.Collections.Generic.InsertionBehavior)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rsi,rcx
       mov       edi,edx
       mov       rbx,r8
       mov       ebp,r9d
       cmp       qword ptr [rsi+8],0
       jne       short M03_L00
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFB0D975AE0]
M03_L00:
       mov       r14,[rsi+10]
       mov       r15,[rsi+18]
       test      r15,r15
       jne       near ptr M03_L20
       mov       r12d,edi
M03_L01:
       xor       r13d,r13d
       mov       rdx,[rsi+8]
       mov       ecx,[rdx+8]
       mov       eax,ecx
       mov       r8,[rsi+30]
       mov       r9d,r12d
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       eax,eax
       imul      rax,r8
       shr       rax,20
       cmp       eax,ecx
       jae       near ptr M03_L21
       movsxd    rcx,eax
       lea       rax,[rdx+rcx*4+10]
       mov       r8d,[rax]
       dec       r8d
       test      r15,r15
       jne       near ptr M03_L13
M03_L02:
       cmp       [r14+8],r8d
       ja        short M03_L07
M03_L03:
       cmp       dword ptr [rsi+40],0
       jg        near ptr M03_L10
       mov       r15d,[rsi+38]
       cmp       [r14+8],r15d
       je        near ptr M03_L09
M03_L04:
       lea       edx,[r15+1]
       mov       [rsi+38],edx
       mov       r14,[rsi+10]
M03_L05:
       cmp       r15d,[r14+8]
       jae       near ptr M03_L21
       movsxd    rdx,r15d
       lea       rdx,[rdx+rdx*2]
       lea       rcx,[r14+rdx*8+10]
       mov       [rcx+8],r12d
       mov       [rsp+28],rax
       mov       edx,[rax]
       dec       edx
       mov       [rcx+0C],edx
       mov       [rcx+10],edi
       mov       rdx,rbx
       call      qword ptr [7FFB0D970590]
       inc       r15d
       mov       rbx,[rsp+28]
       mov       [rbx],r15d
       inc       dword ptr [rsi+44]
M03_L06:
       mov       eax,1
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L07:
       movsxd    rcx,r8d
       lea       rcx,[rcx+rcx*2]
       lea       r15,[r14+rcx*8+10]
       cmp       [r15+8],r12d
       mov       [rsp+34],r8d
       je        near ptr M03_L11
M03_L08:
       mov       r8d,[r15+0C]
       inc       r13d
       cmp       [r14+8],r13d
       jb        near ptr M03_L19
       jmp       near ptr M03_L02
M03_L09:
       mov       ecx,[rsi+38]
       call      qword ptr [7FFB0D974AE0]
       mov       edx,eax
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFB0D975AF0]
       mov       rax,[rsi+8]
       mov       edx,[rax+8]
       mov       ecx,edx
       mov       r8,[rsi+30]
       mov       r9d,r12d
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       ecx,ecx
       imul      rcx,r8
       shr       rcx,20
       cmp       ecx,edx
       jae       near ptr M03_L21
       movsxd    rdx,ecx
       lea       rax,[rax+rdx*4+10]
       mov       [rsp+28],rax
       mov       rax,[rsp+28]
       jmp       near ptr M03_L04
M03_L10:
       mov       edx,[rsi+3C]
       mov       r15d,edx
       cmp       edx,[r14+8]
       jae       near ptr M03_L21
       movsxd    rdx,edx
       lea       rdx,[rdx+rdx*2]
       mov       edx,[r14+rdx*8+1C]
       neg       edx
       add       edx,0FFFFFFFD
       mov       [rsi+3C],edx
       dec       dword ptr [rsi+40]
       jmp       near ptr M03_L05
M03_L11:
       mov       [rsp+28],rax
       call      qword ptr [7FFB0D971340]
       mov       rdx,[rax]
       mov       ecx,[r15+10]
       cmp       [rdx],edx
       cmp       ecx,edi
       sete      dl
       movzx     edx,dl
       test      edx,edx
       mov       rax,[rsp+28]
       je        near ptr M03_L08
       mov       r8d,[rsp+34]
       cmp       bpl,1
       jne       short M03_L12
       movsxd    rdx,r8d
       lea       rdx,[rdx+rdx*2]
       lea       rcx,[r14+rdx*8+10]
       mov       rdx,rbx
       call      qword ptr [7FFB0D970588]
       jmp       near ptr M03_L06
M03_L12:
       cmp       bpl,2
       jne       near ptr M03_L17
       jmp       near ptr M03_L16
M03_L13:
       cmp       [r14+8],r8d
       jbe       near ptr M03_L03
       movsxd    rdx,r8d
       lea       rdx,[rdx+rdx*2]
       cmp       [r14+rdx*8+18],r12d
       jne       near ptr M03_L18
       mov       [rsp+28],rax
       mov       [rsp+34],r8d
       movsxd    rdx,r8d
       lea       rdx,[rdx+rdx*2]
       mov       edx,[r14+rdx*8+20]
       mov       rcx,r15
       mov       r8d,edi
       lea       r11,[7FFB0D96FDC0]
       call      qword ptr [7FFB0D96FDC0]
       test      al,al
       mov       rax,[rsp+28]
       je        short M03_L14
       cmp       bpl,1
       jne       short M03_L15
       mov       esi,[rsp+34]
       movsxd    rdx,esi
       lea       rdx,[rdx+rdx*2]
       lea       rcx,[r14+rdx*8+10]
       mov       rdx,rbx
       call      qword ptr [7FFB0D970588]
       jmp       near ptr M03_L06
M03_L14:
       mov       r8d,[rsp+34]
       jmp       short M03_L18
M03_L15:
       cmp       bpl,2
       jne       short M03_L17
M03_L16:
       mov       ecx,edi
       call      qword ptr [7FFB0D969248]
       int       3
M03_L17:
       xor       eax,eax
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L18:
       movsxd    r8,r8d
       lea       rdx,[r8+r8*2]
       mov       r8d,[r14+rdx*8+1C]
       inc       r13d
       cmp       [r14+8],r13d
       jae       near ptr M03_L13
M03_L19:
       call      qword ptr [7FFB0D96D150]
       int       3
M03_L20:
       mov       rcx,r15
       mov       edx,edi
       lea       r11,[7FFB0D96FDC8]
       call      qword ptr [7FFB0D96FDC8]
       mov       r12d,eax
       jmp       near ptr M03_L01
M03_L21:
       call      qword ptr [7FFB0D970578]
       int       3
; Total bytes of code 760
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.BytesToString(Byte[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M04_L00
       mov       rax,232D1583020
       mov       rdi,[rax]
       mov       rax,232D1591A38
       mov       rbx,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M04_L00:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       ebx,[rsi+8]
       mov       edx,ebx
       mov       rcx,rdi
       mov       r8d,7FFFFFFF
       call      System.Text.StringBuilder..ctor(Int32, Int32)
       xor       ebp,ebp
       test      ebx,ebx
       jle       short M04_L02
       mov       rdx,232D1581568
       mov       r14,[rdx]
       mov       rdx,232D1593C58
       mov       r15,[rdx]
M04_L01:
       movsxd    rdx,ebp
       lea       rdx,[rsi+rdx+10]
       mov       r8,r14
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r15
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|42_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       add       ebp,1
       jo        short M04_L03
       cmp       ebx,ebp
       jg        short M04_L01
M04_L02:
       mov       rcx,rdi
       mov       rax,[7FFAAF3D78C0]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       rax
M04_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 223
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowKeyNotFoundException[[System.Int32, System.Private.CoreLib]](Int32)

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.BytesToString01()
; 			var result = base.GetByteArray(1).BytesToString();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       vzeroupper
       mov       rsi,rcx
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       mov       edx,1
       call      System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       test      rax,rax
       jne       short M00_L00
       mov       rdi,[rsi+8]
       vmovsd    xmm0,qword ptr [7FFAAF3DB050]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       mov       r8,rax
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,1
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(Int32, System.__Canon, System.Collections.Generic.InsertionBehavior)
M00_L00:
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       mov       edx,1
       call      System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       test      rax,rax
       je        short M00_L01
       mov       rcx,[rax]
       call      DotNetTips.Spargine.Extensions.ArrayExtensions.BytesToString(Byte[])
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M00_L01:
       mov       ecx,1
       call      System.ThrowHelper.ThrowKeyNotFoundException[[System.Int32, System.Private.CoreLib]](Int32)
       int       3
; Total bytes of code 140
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       edi,edx
       mov       rax,[rsi]
       mov       rax,[rax+30]
       mov       rbx,[rax]
       cmp       qword ptr [rsi+8],0
       jne       short M01_L01
M01_L00:
       cmp       qword ptr [rbx+28],0
       je        near ptr M01_L05
       jmp       near ptr M01_L05
M01_L01:
       mov       rbp,[rsi+18]
       test      rbp,rbp
       jne       near ptr M01_L06
       mov       eax,edi
       mov       rcx,[rsi+8]
       mov       edx,[rcx+8]
       mov       r11d,edx
       mov       r8,[rsi+30]
       mov       r9d,eax
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       r11d,r11d
       imul      r11,r8
       shr       r11,20
       cmp       r11d,edx
       jae       near ptr M01_L11
       movsxd    rdx,r11d
       lea       rcx,[rcx+rdx*4+10]
       mov       ecx,[rcx]
       mov       rdx,[rsi+10]
       xor       r11d,r11d
       dec       ecx
       mov       r8d,[rdx+8]
M01_L02:
       cmp       r8d,ecx
       jbe       short M01_L00
       movsxd    rcx,ecx
       lea       rcx,[rcx+rcx*2]
       lea       r14,[rdx+rcx*8+10]
       cmp       [r14+8],edi
       jne       short M01_L03
       mov       ecx,[r14+10]
       cmp       ecx,eax
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       short M01_L04
M01_L03:
       mov       ecx,[r14+0C]
       inc       r11d
       cmp       r8d,r11d
       jb        near ptr M01_L09
       jmp       short M01_L02
M01_L04:
       mov       rax,r14
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L05:
       xor       r14d,r14d
       jmp       short M01_L04
M01_L06:
       mov       rcx,rbp
       mov       edx,edi
       mov       r11,7FFAAEE20670
       call      qword ptr [7FFAAF3E0670]
       mov       r14d,eax
       mov       rdx,[rsi+8]
       mov       ecx,[rdx+8]
       mov       r8,[rsi+30]
       mov       r11d,r14d
       imul      r8,r11
       shr       r8,20
       inc       r8
       mov       ecx,ecx
       imul      rcx,r8
       shr       rcx,20
       cmp       ecx,[rdx+8]
       jae       short M01_L11
       movsxd    rcx,ecx
       lea       rdx,[rdx+rcx*4+10]
       mov       r15d,[rdx]
       mov       r12,[rsi+10]
       xor       r13d,r13d
       dec       r15d
M01_L07:
       cmp       [r12+8],r15d
       jbe       near ptr M01_L00
       movsxd    rdx,r15d
       lea       rdx,[rdx+rdx*2]
       lea       rdx,[r12+rdx*8+10]
       mov       r15,rdx
       cmp       [r15+8],r14d
       jne       short M01_L08
       mov       edx,[r15+10]
       mov       rcx,rbp
       mov       r8d,edi
       mov       r11,7FFAAEE20678
       call      qword ptr [7FFAAF3E0678]
       test      eax,eax
       jne       short M01_L10
M01_L08:
       mov       r15d,[r15+0C]
       inc       r13d
       cmp       [r12+8],r13d
       jae       short M01_L07
M01_L09:
       call      System.ThrowHelper.ThrowInvalidOperationException_ConcurrentOperationsNotSupported()
       int       3
M01_L10:
       mov       r14,r15
       jmp       near ptr M01_L04
M01_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 408
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       push      rbp
       sub       rsp,0A0
       vzeroupper
       lea       rbp,[rsp+0A0]
       xor       eax,eax
       mov       [rbp+0FF98],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFA0
M02_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M02_L00
       mov       [rbp+0FF88],rsp
       vmovsd    qword ptr [rbp+10],xmm0
       call      System.Globalization.CultureInfo.get_InvariantCulture()
       mov       [rbp+0FFD8],rax
       mov       rcx,offset MT_System.Double
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp+0FFD0],rax
       call      DotNetTips.Spargine.Tester.Properties.Resources.get_SizeMustBeEpsilon()
       mov       [rbp+0FFC8],rax
       mov       r8,[rbp+0FFD0]
       mov       qword ptr [r8+8],1
       mov       r8,[rbp+0FFD0]
       mov       rcx,[rbp+0FFD8]
       mov       rdx,[rbp+0FFC8]
       call      System.String.Format(System.IFormatProvider, System.String, System.Object)
       mov       [rbp+0FFC0],rax
       mov       r9,2477BB56928
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,[rbp+0FFC0]
       vmovsd    xmm2,qword ptr [rbp+10]
       vucomisd  xmm2,qword ptr [7FFAAF1E8A38]
       setae     dl
       movzx     edx,dl
       vxorps    xmm2,xmm2,xmm2
       vmovsd    xmm0,qword ptr [rbp+10]
       call      DotNetTips.Spargine.Core.Validator.ArgumentMeetsCondition[[System.Double, System.Private.CoreLib]](Double, Boolean, Double, System.String, System.String)
       vmovsd    qword ptr [rbp+10],xmm0
       vmovsd    xmm0,qword ptr [rbp+10]
       vmulsd    xmm0,xmm0,qword ptr [7FFAAF1E8A40]
       call      System.Convert.ToInt32(Double)
       movsxd    rdx,eax
       mov       [rbp+0FFB8],rdx
       mov       rdx,[rbp+0FFB8]
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp+0FFB0],rax
       mov       rdx,[rbp+0FFB0]
       lea       rcx,[rbp+0FFF0]
       call      System.Span`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte[])
       mov       rdx,2479BB57448
       mov       rdx,[rdx]
       mov       [rbp+0FFE8],rdx
       xor       edx,edx
       mov       [rbp+0FFE0],edx
       lea       rdx,[rbp+0FFE0]
       mov       rcx,[rbp+0FFE8]
       call      System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,2479BB57450
       mov       rcx,[rcx]
       mov       [rbp+0FF98],rcx
       vmovdqu   xmm0,xmmword ptr [rbp+0FFF0]
       vmovdqu   xmmword ptr [rbp+0FFA0],xmm0
       mov       rcx,[rbp+0FF98]
       lea       rdx,[rbp+0FFA0]
       mov       rax,[rbp+0FF98]
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       jmp       short M02_L01
M02_L01:
       mov       rcx,rsp
       call      M02_L02
       nop
       lea       rcx,[rbp+0FFF0]
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].ToArray()
       nop
       add       rsp,0A0
       pop       rbp
       ret
M02_L02:
       push      rbp
       sub       rsp,30
       vzeroupper
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+0A0]
       mov       ecx,[rbp+0FFE0]
       movzx     ecx,cl
       test      ecx,ecx
       je        short M02_L03
       mov       rcx,[rbp+0FFE8]
       call      System.Threading.Monitor.Exit(System.Object)
M02_L03:
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 425
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(Int32, System.__Canon, System.Collections.Generic.InsertionBehavior)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rsi,rcx
       mov       edi,edx
       mov       rbx,r8
       mov       ebp,r9d
       cmp       qword ptr [rsi+8],0
       jne       short M03_L00
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFB0D975AE0]
M03_L00:
       mov       r14,[rsi+10]
       mov       r15,[rsi+18]
       test      r15,r15
       jne       near ptr M03_L20
       mov       r12d,edi
M03_L01:
       xor       r13d,r13d
       mov       rdx,[rsi+8]
       mov       ecx,[rdx+8]
       mov       eax,ecx
       mov       r8,[rsi+30]
       mov       r9d,r12d
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       eax,eax
       imul      rax,r8
       shr       rax,20
       cmp       eax,ecx
       jae       near ptr M03_L21
       movsxd    rcx,eax
       lea       rax,[rdx+rcx*4+10]
       mov       r8d,[rax]
       dec       r8d
       test      r15,r15
       jne       near ptr M03_L13
M03_L02:
       cmp       [r14+8],r8d
       ja        short M03_L07
M03_L03:
       cmp       dword ptr [rsi+40],0
       jg        near ptr M03_L10
       mov       r15d,[rsi+38]
       cmp       [r14+8],r15d
       je        near ptr M03_L09
M03_L04:
       lea       edx,[r15+1]
       mov       [rsi+38],edx
       mov       r14,[rsi+10]
M03_L05:
       cmp       r15d,[r14+8]
       jae       near ptr M03_L21
       movsxd    rdx,r15d
       lea       rdx,[rdx+rdx*2]
       lea       rcx,[r14+rdx*8+10]
       mov       [rcx+8],r12d
       mov       [rsp+28],rax
       mov       edx,[rax]
       dec       edx
       mov       [rcx+0C],edx
       mov       [rcx+10],edi
       mov       rdx,rbx
       call      qword ptr [7FFB0D970590]
       inc       r15d
       mov       rbx,[rsp+28]
       mov       [rbx],r15d
       inc       dword ptr [rsi+44]
M03_L06:
       mov       eax,1
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L07:
       movsxd    rcx,r8d
       lea       rcx,[rcx+rcx*2]
       lea       r15,[r14+rcx*8+10]
       cmp       [r15+8],r12d
       mov       [rsp+34],r8d
       je        near ptr M03_L11
M03_L08:
       mov       r8d,[r15+0C]
       inc       r13d
       cmp       [r14+8],r13d
       jb        near ptr M03_L19
       jmp       near ptr M03_L02
M03_L09:
       mov       ecx,[rsi+38]
       call      qword ptr [7FFB0D974AE0]
       mov       edx,eax
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFB0D975AF0]
       mov       rax,[rsi+8]
       mov       edx,[rax+8]
       mov       ecx,edx
       mov       r8,[rsi+30]
       mov       r9d,r12d
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       ecx,ecx
       imul      rcx,r8
       shr       rcx,20
       cmp       ecx,edx
       jae       near ptr M03_L21
       movsxd    rdx,ecx
       lea       rax,[rax+rdx*4+10]
       mov       [rsp+28],rax
       mov       rax,[rsp+28]
       jmp       near ptr M03_L04
M03_L10:
       mov       edx,[rsi+3C]
       mov       r15d,edx
       cmp       edx,[r14+8]
       jae       near ptr M03_L21
       movsxd    rdx,edx
       lea       rdx,[rdx+rdx*2]
       mov       edx,[r14+rdx*8+1C]
       neg       edx
       add       edx,0FFFFFFFD
       mov       [rsi+3C],edx
       dec       dword ptr [rsi+40]
       jmp       near ptr M03_L05
M03_L11:
       mov       [rsp+28],rax
       call      qword ptr [7FFB0D971340]
       mov       rdx,[rax]
       mov       ecx,[r15+10]
       cmp       [rdx],edx
       cmp       ecx,edi
       sete      dl
       movzx     edx,dl
       test      edx,edx
       mov       rax,[rsp+28]
       je        near ptr M03_L08
       mov       r8d,[rsp+34]
       cmp       bpl,1
       jne       short M03_L12
       movsxd    rdx,r8d
       lea       rdx,[rdx+rdx*2]
       lea       rcx,[r14+rdx*8+10]
       mov       rdx,rbx
       call      qword ptr [7FFB0D970588]
       jmp       near ptr M03_L06
M03_L12:
       cmp       bpl,2
       jne       near ptr M03_L17
       jmp       near ptr M03_L16
M03_L13:
       cmp       [r14+8],r8d
       jbe       near ptr M03_L03
       movsxd    rdx,r8d
       lea       rdx,[rdx+rdx*2]
       cmp       [r14+rdx*8+18],r12d
       jne       near ptr M03_L18
       mov       [rsp+28],rax
       mov       [rsp+34],r8d
       movsxd    rdx,r8d
       lea       rdx,[rdx+rdx*2]
       mov       edx,[r14+rdx*8+20]
       mov       rcx,r15
       mov       r8d,edi
       lea       r11,[7FFB0D96FDC0]
       call      qword ptr [7FFB0D96FDC0]
       test      al,al
       mov       rax,[rsp+28]
       je        short M03_L14
       cmp       bpl,1
       jne       short M03_L15
       mov       esi,[rsp+34]
       movsxd    rdx,esi
       lea       rdx,[rdx+rdx*2]
       lea       rcx,[r14+rdx*8+10]
       mov       rdx,rbx
       call      qword ptr [7FFB0D970588]
       jmp       near ptr M03_L06
M03_L14:
       mov       r8d,[rsp+34]
       jmp       short M03_L18
M03_L15:
       cmp       bpl,2
       jne       short M03_L17
M03_L16:
       mov       ecx,edi
       call      qword ptr [7FFB0D969248]
       int       3
M03_L17:
       xor       eax,eax
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L18:
       movsxd    r8,r8d
       lea       rdx,[r8+r8*2]
       mov       r8d,[r14+rdx*8+1C]
       inc       r13d
       cmp       [r14+8],r13d
       jae       near ptr M03_L13
M03_L19:
       call      qword ptr [7FFB0D96D150]
       int       3
M03_L20:
       mov       rcx,r15
       mov       edx,edi
       lea       r11,[7FFB0D96FDC8]
       call      qword ptr [7FFB0D96FDC8]
       mov       r12d,eax
       jmp       near ptr M03_L01
M03_L21:
       call      qword ptr [7FFB0D970578]
       int       3
; Total bytes of code 760
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.BytesToString(Byte[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M04_L00
       mov       rax,2477BB53020
       mov       rdi,[rax]
       mov       rax,2479BB5D630
       mov       rbx,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M04_L00:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       ebx,[rsi+8]
       mov       edx,ebx
       mov       rcx,rdi
       mov       r8d,7FFFFFFF
       call      System.Text.StringBuilder..ctor(Int32, Int32)
       xor       ebp,ebp
       test      ebx,ebx
       jle       short M04_L02
       mov       rdx,2477BB51568
       mov       r14,[rdx]
       mov       rdx,2477BB57010
       mov       r15,[rdx]
M04_L01:
       movsxd    rdx,ebp
       lea       rdx,[rsi+rdx+10]
       mov       r8,r14
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r15
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|42_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       add       ebp,1
       jo        short M04_L03
       cmp       ebx,ebp
       jg        short M04_L01
M04_L02:
       mov       rcx,rdi
       mov       rax,[7FFAAF3D78C0]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       rax
M04_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 223
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowKeyNotFoundException[[System.Int32, System.Private.CoreLib]](Int32)

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.BytesToString01()
; 			var result = base.GetByteArray(1).BytesToString();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       vzeroupper
       mov       rsi,rcx
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       mov       edx,1
       call      System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       test      rax,rax
       jne       short M00_L00
       mov       rdi,[rsi+8]
       vmovsd    xmm0,qword ptr [7FFAAF3DB050]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       mov       r8,rax
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,1
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(Int32, System.__Canon, System.Collections.Generic.InsertionBehavior)
M00_L00:
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       mov       edx,1
       call      System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       test      rax,rax
       je        short M00_L01
       mov       rcx,[rax]
       call      DotNetTips.Spargine.Extensions.ArrayExtensions.BytesToString(Byte[])
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M00_L01:
       mov       ecx,1
       call      System.ThrowHelper.ThrowKeyNotFoundException[[System.Int32, System.Private.CoreLib]](Int32)
       int       3
; Total bytes of code 140
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       edi,edx
       mov       rax,[rsi]
       mov       rax,[rax+30]
       mov       rbx,[rax]
       cmp       qword ptr [rsi+8],0
       jne       short M01_L01
M01_L00:
       cmp       qword ptr [rbx+28],0
       je        near ptr M01_L05
       jmp       near ptr M01_L05
M01_L01:
       mov       rbp,[rsi+18]
       test      rbp,rbp
       jne       near ptr M01_L06
       mov       eax,edi
       mov       rcx,[rsi+8]
       mov       edx,[rcx+8]
       mov       r11d,edx
       mov       r8,[rsi+30]
       mov       r9d,eax
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       r11d,r11d
       imul      r11,r8
       shr       r11,20
       cmp       r11d,edx
       jae       near ptr M01_L11
       movsxd    rdx,r11d
       lea       rcx,[rcx+rdx*4+10]
       mov       ecx,[rcx]
       mov       rdx,[rsi+10]
       xor       r11d,r11d
       dec       ecx
       mov       r8d,[rdx+8]
M01_L02:
       cmp       r8d,ecx
       jbe       short M01_L00
       movsxd    rcx,ecx
       lea       rcx,[rcx+rcx*2]
       lea       r14,[rdx+rcx*8+10]
       cmp       [r14+8],edi
       jne       short M01_L03
       mov       ecx,[r14+10]
       cmp       ecx,eax
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       short M01_L04
M01_L03:
       mov       ecx,[r14+0C]
       inc       r11d
       cmp       r8d,r11d
       jb        near ptr M01_L09
       jmp       short M01_L02
M01_L04:
       mov       rax,r14
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L05:
       xor       r14d,r14d
       jmp       short M01_L04
M01_L06:
       mov       rcx,rbp
       mov       edx,edi
       mov       r11,7FFAAEE20670
       call      qword ptr [7FFAAF3E0670]
       mov       r14d,eax
       mov       rdx,[rsi+8]
       mov       ecx,[rdx+8]
       mov       r8,[rsi+30]
       mov       r11d,r14d
       imul      r8,r11
       shr       r8,20
       inc       r8
       mov       ecx,ecx
       imul      rcx,r8
       shr       rcx,20
       cmp       ecx,[rdx+8]
       jae       short M01_L11
       movsxd    rcx,ecx
       lea       rdx,[rdx+rcx*4+10]
       mov       r15d,[rdx]
       mov       r12,[rsi+10]
       xor       r13d,r13d
       dec       r15d
M01_L07:
       cmp       [r12+8],r15d
       jbe       near ptr M01_L00
       movsxd    rdx,r15d
       lea       rdx,[rdx+rdx*2]
       lea       rdx,[r12+rdx*8+10]
       mov       r15,rdx
       cmp       [r15+8],r14d
       jne       short M01_L08
       mov       edx,[r15+10]
       mov       rcx,rbp
       mov       r8d,edi
       mov       r11,7FFAAEE20678
       call      qword ptr [7FFAAF3E0678]
       test      eax,eax
       jne       short M01_L10
M01_L08:
       mov       r15d,[r15+0C]
       inc       r13d
       cmp       [r12+8],r13d
       jae       short M01_L07
M01_L09:
       call      System.ThrowHelper.ThrowInvalidOperationException_ConcurrentOperationsNotSupported()
       int       3
M01_L10:
       mov       r14,r15
       jmp       near ptr M01_L04
M01_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 408
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       push      rbp
       sub       rsp,0A0
       vzeroupper
       lea       rbp,[rsp+0A0]
       xor       eax,eax
       mov       [rbp+0FF98],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFA0
M02_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M02_L00
       mov       [rbp+0FF88],rsp
       vmovsd    qword ptr [rbp+10],xmm0
       call      System.Globalization.CultureInfo.get_InvariantCulture()
       mov       [rbp+0FFD8],rax
       mov       rcx,offset MT_System.Double
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp+0FFD0],rax
       call      DotNetTips.Spargine.Tester.Properties.Resources.get_SizeMustBeEpsilon()
       mov       [rbp+0FFC8],rax
       mov       r8,[rbp+0FFD0]
       mov       qword ptr [r8+8],1
       mov       r8,[rbp+0FFD0]
       mov       rcx,[rbp+0FFD8]
       mov       rdx,[rbp+0FFC8]
       call      System.String.Format(System.IFormatProvider, System.String, System.Object)
       mov       [rbp+0FFC0],rax
       mov       r9,24CE99B1D40
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,[rbp+0FFC0]
       vmovsd    xmm2,qword ptr [rbp+10]
       vucomisd  xmm2,qword ptr [7FFAAF1E8A38]
       setae     dl
       movzx     edx,dl
       vxorps    xmm2,xmm2,xmm2
       vmovsd    xmm0,qword ptr [rbp+10]
       call      DotNetTips.Spargine.Core.Validator.ArgumentMeetsCondition[[System.Double, System.Private.CoreLib]](Double, Boolean, Double, System.String, System.String)
       vmovsd    qword ptr [rbp+10],xmm0
       vmovsd    xmm0,qword ptr [rbp+10]
       vmulsd    xmm0,xmm0,qword ptr [7FFAAF1E8A40]
       call      System.Convert.ToInt32(Double)
       movsxd    rdx,eax
       mov       [rbp+0FFB8],rdx
       mov       rdx,[rbp+0FFB8]
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp+0FFB0],rax
       mov       rdx,[rbp+0FFB0]
       lea       rcx,[rbp+0FFF0]
       call      System.Span`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte[])
       mov       rdx,24CE99AB850
       mov       rdx,[rdx]
       mov       [rbp+0FFE8],rdx
       xor       edx,edx
       mov       [rbp+0FFE0],edx
       lea       rdx,[rbp+0FFE0]
       mov       rcx,[rbp+0FFE8]
       call      System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,24CE99AB858
       mov       rcx,[rcx]
       mov       [rbp+0FF98],rcx
       vmovdqu   xmm0,xmmword ptr [rbp+0FFF0]
       vmovdqu   xmmword ptr [rbp+0FFA0],xmm0
       mov       rcx,[rbp+0FF98]
       lea       rdx,[rbp+0FFA0]
       mov       rax,[rbp+0FF98]
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       jmp       short M02_L01
M02_L01:
       mov       rcx,rsp
       call      M02_L02
       nop
       lea       rcx,[rbp+0FFF0]
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].ToArray()
       nop
       add       rsp,0A0
       pop       rbp
       ret
M02_L02:
       push      rbp
       sub       rsp,30
       vzeroupper
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+0A0]
       mov       ecx,[rbp+0FFE0]
       movzx     ecx,cl
       test      ecx,ecx
       je        short M02_L03
       mov       rcx,[rbp+0FFE8]
       call      System.Threading.Monitor.Exit(System.Object)
M02_L03:
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 425
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(Int32, System.__Canon, System.Collections.Generic.InsertionBehavior)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rsi,rcx
       mov       edi,edx
       mov       rbx,r8
       mov       ebp,r9d
       cmp       qword ptr [rsi+8],0
       jne       short M03_L00
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFB0D975AE0]
M03_L00:
       mov       r14,[rsi+10]
       mov       r15,[rsi+18]
       test      r15,r15
       jne       near ptr M03_L20
       mov       r12d,edi
M03_L01:
       xor       r13d,r13d
       mov       rdx,[rsi+8]
       mov       ecx,[rdx+8]
       mov       eax,ecx
       mov       r8,[rsi+30]
       mov       r9d,r12d
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       eax,eax
       imul      rax,r8
       shr       rax,20
       cmp       eax,ecx
       jae       near ptr M03_L21
       movsxd    rcx,eax
       lea       rax,[rdx+rcx*4+10]
       mov       r8d,[rax]
       dec       r8d
       test      r15,r15
       jne       near ptr M03_L13
M03_L02:
       cmp       [r14+8],r8d
       ja        short M03_L07
M03_L03:
       cmp       dword ptr [rsi+40],0
       jg        near ptr M03_L10
       mov       r15d,[rsi+38]
       cmp       [r14+8],r15d
       je        near ptr M03_L09
M03_L04:
       lea       edx,[r15+1]
       mov       [rsi+38],edx
       mov       r14,[rsi+10]
M03_L05:
       cmp       r15d,[r14+8]
       jae       near ptr M03_L21
       movsxd    rdx,r15d
       lea       rdx,[rdx+rdx*2]
       lea       rcx,[r14+rdx*8+10]
       mov       [rcx+8],r12d
       mov       [rsp+28],rax
       mov       edx,[rax]
       dec       edx
       mov       [rcx+0C],edx
       mov       [rcx+10],edi
       mov       rdx,rbx
       call      qword ptr [7FFB0D970590]
       inc       r15d
       mov       rbx,[rsp+28]
       mov       [rbx],r15d
       inc       dword ptr [rsi+44]
M03_L06:
       mov       eax,1
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L07:
       movsxd    rcx,r8d
       lea       rcx,[rcx+rcx*2]
       lea       r15,[r14+rcx*8+10]
       cmp       [r15+8],r12d
       mov       [rsp+34],r8d
       je        near ptr M03_L11
M03_L08:
       mov       r8d,[r15+0C]
       inc       r13d
       cmp       [r14+8],r13d
       jb        near ptr M03_L19
       jmp       near ptr M03_L02
M03_L09:
       mov       ecx,[rsi+38]
       call      qword ptr [7FFB0D974AE0]
       mov       edx,eax
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFB0D975AF0]
       mov       rax,[rsi+8]
       mov       edx,[rax+8]
       mov       ecx,edx
       mov       r8,[rsi+30]
       mov       r9d,r12d
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       ecx,ecx
       imul      rcx,r8
       shr       rcx,20
       cmp       ecx,edx
       jae       near ptr M03_L21
       movsxd    rdx,ecx
       lea       rax,[rax+rdx*4+10]
       mov       [rsp+28],rax
       mov       rax,[rsp+28]
       jmp       near ptr M03_L04
M03_L10:
       mov       edx,[rsi+3C]
       mov       r15d,edx
       cmp       edx,[r14+8]
       jae       near ptr M03_L21
       movsxd    rdx,edx
       lea       rdx,[rdx+rdx*2]
       mov       edx,[r14+rdx*8+1C]
       neg       edx
       add       edx,0FFFFFFFD
       mov       [rsi+3C],edx
       dec       dword ptr [rsi+40]
       jmp       near ptr M03_L05
M03_L11:
       mov       [rsp+28],rax
       call      qword ptr [7FFB0D971340]
       mov       rdx,[rax]
       mov       ecx,[r15+10]
       cmp       [rdx],edx
       cmp       ecx,edi
       sete      dl
       movzx     edx,dl
       test      edx,edx
       mov       rax,[rsp+28]
       je        near ptr M03_L08
       mov       r8d,[rsp+34]
       cmp       bpl,1
       jne       short M03_L12
       movsxd    rdx,r8d
       lea       rdx,[rdx+rdx*2]
       lea       rcx,[r14+rdx*8+10]
       mov       rdx,rbx
       call      qword ptr [7FFB0D970588]
       jmp       near ptr M03_L06
M03_L12:
       cmp       bpl,2
       jne       near ptr M03_L17
       jmp       near ptr M03_L16
M03_L13:
       cmp       [r14+8],r8d
       jbe       near ptr M03_L03
       movsxd    rdx,r8d
       lea       rdx,[rdx+rdx*2]
       cmp       [r14+rdx*8+18],r12d
       jne       near ptr M03_L18
       mov       [rsp+28],rax
       mov       [rsp+34],r8d
       movsxd    rdx,r8d
       lea       rdx,[rdx+rdx*2]
       mov       edx,[r14+rdx*8+20]
       mov       rcx,r15
       mov       r8d,edi
       lea       r11,[7FFB0D96FDC0]
       call      qword ptr [7FFB0D96FDC0]
       test      al,al
       mov       rax,[rsp+28]
       je        short M03_L14
       cmp       bpl,1
       jne       short M03_L15
       mov       esi,[rsp+34]
       movsxd    rdx,esi
       lea       rdx,[rdx+rdx*2]
       lea       rcx,[r14+rdx*8+10]
       mov       rdx,rbx
       call      qword ptr [7FFB0D970588]
       jmp       near ptr M03_L06
M03_L14:
       mov       r8d,[rsp+34]
       jmp       short M03_L18
M03_L15:
       cmp       bpl,2
       jne       short M03_L17
M03_L16:
       mov       ecx,edi
       call      qword ptr [7FFB0D969248]
       int       3
M03_L17:
       xor       eax,eax
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L18:
       movsxd    r8,r8d
       lea       rdx,[r8+r8*2]
       mov       r8d,[r14+rdx*8+1C]
       inc       r13d
       cmp       [r14+8],r13d
       jae       near ptr M03_L13
M03_L19:
       call      qword ptr [7FFB0D96D150]
       int       3
M03_L20:
       mov       rcx,r15
       mov       edx,edi
       lea       r11,[7FFB0D96FDC8]
       call      qword ptr [7FFB0D96FDC8]
       mov       r12d,eax
       jmp       near ptr M03_L01
M03_L21:
       call      qword ptr [7FFB0D970578]
       int       3
; Total bytes of code 760
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.BytesToString(Byte[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M04_L00
       mov       rax,24CE99A3020
       mov       rdi,[rax]
       mov       rax,24D099A1200
       mov       rbx,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M04_L00:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       ebx,[rsi+8]
       mov       edx,ebx
       mov       rcx,rdi
       mov       r8d,7FFFFFFF
       call      System.Text.StringBuilder..ctor(Int32, Int32)
       xor       ebp,ebp
       test      ebx,ebx
       jle       short M04_L02
       mov       rdx,24CE99A1568
       mov       r14,[rdx]
       mov       rdx,24CE99B2428
       mov       r15,[rdx]
M04_L01:
       movsxd    rdx,ebp
       lea       rdx,[rsi+rdx+10]
       mov       r8,r14
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r15
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|42_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       add       ebp,1
       jo        short M04_L03
       cmp       ebx,ebp
       jg        short M04_L01
M04_L02:
       mov       rcx,rdi
       mov       rax,[7FFAAF3D78C0]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       rax
M04_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 223
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowKeyNotFoundException[[System.Int32, System.Private.CoreLib]](Int32)

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.BytesToString01()
; 			var result = base.GetByteArray(1).BytesToString();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       vzeroupper
       mov       rsi,rcx
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       mov       edx,1
       call      System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       test      rax,rax
       jne       short M00_L00
       mov       rdi,[rsi+8]
       vmovsd    xmm0,qword ptr [7FFAAF3F8300]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       mov       r8,rax
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,1
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(Int32, System.__Canon, System.Collections.Generic.InsertionBehavior)
M00_L00:
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       mov       edx,1
       call      System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       test      rax,rax
       je        short M00_L01
       mov       rcx,[rax]
       call      DotNetTips.Spargine.Extensions.ArrayExtensions.BytesToString(Byte[])
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M00_L01:
       mov       ecx,1
       call      System.ThrowHelper.ThrowKeyNotFoundException[[System.Int32, System.Private.CoreLib]](Int32)
       int       3
; Total bytes of code 140
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(Int32)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       edi,edx
       mov       rax,[rsi]
       mov       rax,[rax+30]
       mov       rbx,[rax]
       cmp       qword ptr [rsi+8],0
       jne       short M01_L01
M01_L00:
       cmp       qword ptr [rbx+28],0
       je        near ptr M01_L05
       jmp       near ptr M01_L05
M01_L01:
       mov       rbp,[rsi+18]
       test      rbp,rbp
       jne       near ptr M01_L06
       mov       eax,edi
       mov       rcx,[rsi+8]
       mov       edx,[rcx+8]
       mov       r11d,edx
       mov       r8,[rsi+30]
       mov       r9d,eax
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       r11d,r11d
       imul      r11,r8
       shr       r11,20
       cmp       r11d,edx
       jae       near ptr M01_L11
       movsxd    rdx,r11d
       lea       rcx,[rcx+rdx*4+10]
       mov       ecx,[rcx]
       mov       rdx,[rsi+10]
       xor       r11d,r11d
       dec       ecx
       mov       r8d,[rdx+8]
M01_L02:
       cmp       r8d,ecx
       jbe       short M01_L00
       movsxd    rcx,ecx
       lea       rcx,[rcx+rcx*2]
       lea       r14,[rdx+rcx*8+10]
       cmp       [r14+8],edi
       jne       short M01_L03
       mov       ecx,[r14+10]
       cmp       ecx,eax
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       short M01_L04
M01_L03:
       mov       ecx,[r14+0C]
       inc       r11d
       cmp       r8d,r11d
       jb        near ptr M01_L09
       jmp       short M01_L02
M01_L04:
       mov       rax,r14
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L05:
       xor       r14d,r14d
       jmp       short M01_L04
M01_L06:
       mov       rcx,rbp
       mov       edx,edi
       mov       r11,7FFAAEE206E0
       call      qword ptr [7FFAAF4006E0]
       mov       r14d,eax
       mov       rdx,[rsi+8]
       mov       ecx,[rdx+8]
       mov       r8,[rsi+30]
       mov       r11d,r14d
       imul      r8,r11
       shr       r8,20
       inc       r8
       mov       ecx,ecx
       imul      rcx,r8
       shr       rcx,20
       cmp       ecx,[rdx+8]
       jae       short M01_L11
       movsxd    rcx,ecx
       lea       rdx,[rdx+rcx*4+10]
       mov       r15d,[rdx]
       mov       r12,[rsi+10]
       xor       r13d,r13d
       dec       r15d
M01_L07:
       cmp       [r12+8],r15d
       jbe       near ptr M01_L00
       movsxd    rdx,r15d
       lea       rdx,[rdx+rdx*2]
       lea       rdx,[r12+rdx*8+10]
       mov       r15,rdx
       cmp       [r15+8],r14d
       jne       short M01_L08
       mov       edx,[r15+10]
       mov       rcx,rbp
       mov       r8d,edi
       mov       r11,7FFAAEE206E8
       call      qword ptr [7FFAAF4006E8]
       test      eax,eax
       jne       short M01_L10
M01_L08:
       mov       r15d,[r15+0C]
       inc       r13d
       cmp       [r12+8],r13d
       jae       short M01_L07
M01_L09:
       call      System.ThrowHelper.ThrowInvalidOperationException_ConcurrentOperationsNotSupported()
       int       3
M01_L10:
       mov       r14,r15
       jmp       near ptr M01_L04
M01_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 408
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateByteArray(Double)
       push      rbp
       sub       rsp,0A0
       vzeroupper
       lea       rbp,[rsp+0A0]
       xor       eax,eax
       mov       [rbp+0FF98],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFA0
M02_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M02_L00
       mov       [rbp+0FF88],rsp
       vmovsd    qword ptr [rbp+10],xmm0
       call      System.Globalization.CultureInfo.get_InvariantCulture()
       mov       [rbp+0FFD8],rax
       mov       rcx,offset MT_System.Double
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp+0FFD0],rax
       call      DotNetTips.Spargine.Tester.Properties.Resources.get_SizeMustBeEpsilon()
       mov       [rbp+0FFC8],rax
       mov       r8,[rbp+0FFD0]
       mov       qword ptr [r8+8],1
       mov       r8,[rbp+0FFD0]
       mov       rcx,[rbp+0FFD8]
       mov       rdx,[rbp+0FFC8]
       call      System.String.Format(System.IFormatProvider, System.String, System.Object)
       mov       [rbp+0FFC0],rax
       mov       r9,24E67129CB8
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,[rbp+0FFC0]
       vmovsd    xmm2,qword ptr [rbp+10]
       vucomisd  xmm2,qword ptr [7FFAAF1E8A38]
       setae     dl
       movzx     edx,dl
       vxorps    xmm2,xmm2,xmm2
       vmovsd    xmm0,qword ptr [rbp+10]
       call      DotNetTips.Spargine.Core.Validator.ArgumentMeetsCondition[[System.Double, System.Private.CoreLib]](Double, Boolean, Double, System.String, System.String)
       vmovsd    qword ptr [rbp+10],xmm0
       vmovsd    xmm0,qword ptr [rbp+10]
       vmulsd    xmm0,xmm0,qword ptr [7FFAAF1E8A40]
       call      System.Convert.ToInt32(Double)
       movsxd    rdx,eax
       mov       [rbp+0FFB8],rdx
       mov       rdx,[rbp+0FFB8]
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp+0FFB0],rax
       mov       rdx,[rbp+0FFB0]
       lea       rcx,[rbp+0FFF0]
       call      System.Span`1[[System.Byte, System.Private.CoreLib]]..ctor(Byte[])
       mov       rdx,24E67122FB0
       mov       rdx,[rdx]
       mov       [rbp+0FFE8],rdx
       xor       edx,edx
       mov       [rbp+0FFE0],edx
       lea       rdx,[rbp+0FFE0]
       mov       rcx,[rbp+0FFE8]
       call      System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,24E67122FB8
       mov       rcx,[rcx]
       mov       [rbp+0FF98],rcx
       vmovdqu   xmm0,xmmword ptr [rbp+0FFF0]
       vmovdqu   xmmword ptr [rbp+0FFA0],xmm0
       mov       rcx,[rbp+0FF98]
       lea       rdx,[rbp+0FFA0]
       mov       rax,[rbp+0FF98]
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       jmp       short M02_L01
M02_L01:
       mov       rcx,rsp
       call      M02_L02
       nop
       lea       rcx,[rbp+0FFF0]
       call      System.Span`1[[System.Byte, System.Private.CoreLib]].ToArray()
       nop
       add       rsp,0A0
       pop       rbp
       ret
M02_L02:
       push      rbp
       sub       rsp,30
       vzeroupper
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+0A0]
       mov       ecx,[rbp+0FFE0]
       movzx     ecx,cl
       test      ecx,ecx
       je        short M02_L03
       mov       rcx,[rbp+0FFE8]
       call      System.Threading.Monitor.Exit(System.Object)
M02_L03:
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 425
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.Int32, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(Int32, System.__Canon, System.Collections.Generic.InsertionBehavior)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rsi,rcx
       mov       edi,edx
       mov       rbx,r8
       mov       ebp,r9d
       cmp       qword ptr [rsi+8],0
       jne       short M03_L00
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFB0D975AE0]
M03_L00:
       mov       r14,[rsi+10]
       mov       r15,[rsi+18]
       test      r15,r15
       jne       near ptr M03_L20
       mov       r12d,edi
M03_L01:
       xor       r13d,r13d
       mov       rdx,[rsi+8]
       mov       ecx,[rdx+8]
       mov       eax,ecx
       mov       r8,[rsi+30]
       mov       r9d,r12d
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       eax,eax
       imul      rax,r8
       shr       rax,20
       cmp       eax,ecx
       jae       near ptr M03_L21
       movsxd    rcx,eax
       lea       rax,[rdx+rcx*4+10]
       mov       r8d,[rax]
       dec       r8d
       test      r15,r15
       jne       near ptr M03_L13
M03_L02:
       cmp       [r14+8],r8d
       ja        short M03_L07
M03_L03:
       cmp       dword ptr [rsi+40],0
       jg        near ptr M03_L10
       mov       r15d,[rsi+38]
       cmp       [r14+8],r15d
       je        near ptr M03_L09
M03_L04:
       lea       edx,[r15+1]
       mov       [rsi+38],edx
       mov       r14,[rsi+10]
M03_L05:
       cmp       r15d,[r14+8]
       jae       near ptr M03_L21
       movsxd    rdx,r15d
       lea       rdx,[rdx+rdx*2]
       lea       rcx,[r14+rdx*8+10]
       mov       [rcx+8],r12d
       mov       [rsp+28],rax
       mov       edx,[rax]
       dec       edx
       mov       [rcx+0C],edx
       mov       [rcx+10],edi
       mov       rdx,rbx
       call      qword ptr [7FFB0D970590]
       inc       r15d
       mov       rbx,[rsp+28]
       mov       [rbx],r15d
       inc       dword ptr [rsi+44]
M03_L06:
       mov       eax,1
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L07:
       movsxd    rcx,r8d
       lea       rcx,[rcx+rcx*2]
       lea       r15,[r14+rcx*8+10]
       cmp       [r15+8],r12d
       mov       [rsp+34],r8d
       je        near ptr M03_L11
M03_L08:
       mov       r8d,[r15+0C]
       inc       r13d
       cmp       [r14+8],r13d
       jb        near ptr M03_L19
       jmp       near ptr M03_L02
M03_L09:
       mov       ecx,[rsi+38]
       call      qword ptr [7FFB0D974AE0]
       mov       edx,eax
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFB0D975AF0]
       mov       rax,[rsi+8]
       mov       edx,[rax+8]
       mov       ecx,edx
       mov       r8,[rsi+30]
       mov       r9d,r12d
       imul      r8,r9
       shr       r8,20
       inc       r8
       mov       ecx,ecx
       imul      rcx,r8
       shr       rcx,20
       cmp       ecx,edx
       jae       near ptr M03_L21
       movsxd    rdx,ecx
       lea       rax,[rax+rdx*4+10]
       mov       [rsp+28],rax
       mov       rax,[rsp+28]
       jmp       near ptr M03_L04
M03_L10:
       mov       edx,[rsi+3C]
       mov       r15d,edx
       cmp       edx,[r14+8]
       jae       near ptr M03_L21
       movsxd    rdx,edx
       lea       rdx,[rdx+rdx*2]
       mov       edx,[r14+rdx*8+1C]
       neg       edx
       add       edx,0FFFFFFFD
       mov       [rsi+3C],edx
       dec       dword ptr [rsi+40]
       jmp       near ptr M03_L05
M03_L11:
       mov       [rsp+28],rax
       call      qword ptr [7FFB0D971340]
       mov       rdx,[rax]
       mov       ecx,[r15+10]
       cmp       [rdx],edx
       cmp       ecx,edi
       sete      dl
       movzx     edx,dl
       test      edx,edx
       mov       rax,[rsp+28]
       je        near ptr M03_L08
       mov       r8d,[rsp+34]
       cmp       bpl,1
       jne       short M03_L12
       movsxd    rdx,r8d
       lea       rdx,[rdx+rdx*2]
       lea       rcx,[r14+rdx*8+10]
       mov       rdx,rbx
       call      qword ptr [7FFB0D970588]
       jmp       near ptr M03_L06
M03_L12:
       cmp       bpl,2
       jne       near ptr M03_L17
       jmp       near ptr M03_L16
M03_L13:
       cmp       [r14+8],r8d
       jbe       near ptr M03_L03
       movsxd    rdx,r8d
       lea       rdx,[rdx+rdx*2]
       cmp       [r14+rdx*8+18],r12d
       jne       near ptr M03_L18
       mov       [rsp+28],rax
       mov       [rsp+34],r8d
       movsxd    rdx,r8d
       lea       rdx,[rdx+rdx*2]
       mov       edx,[r14+rdx*8+20]
       mov       rcx,r15
       mov       r8d,edi
       lea       r11,[7FFB0D96FDC0]
       call      qword ptr [7FFB0D96FDC0]
       test      al,al
       mov       rax,[rsp+28]
       je        short M03_L14
       cmp       bpl,1
       jne       short M03_L15
       mov       esi,[rsp+34]
       movsxd    rdx,esi
       lea       rdx,[rdx+rdx*2]
       lea       rcx,[r14+rdx*8+10]
       mov       rdx,rbx
       call      qword ptr [7FFB0D970588]
       jmp       near ptr M03_L06
M03_L14:
       mov       r8d,[rsp+34]
       jmp       short M03_L18
M03_L15:
       cmp       bpl,2
       jne       short M03_L17
M03_L16:
       mov       ecx,edi
       call      qword ptr [7FFB0D969248]
       int       3
M03_L17:
       xor       eax,eax
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L18:
       movsxd    r8,r8d
       lea       rdx,[r8+r8*2]
       mov       r8d,[r14+rdx*8+1C]
       inc       r13d
       cmp       [r14+8],r13d
       jae       near ptr M03_L13
M03_L19:
       call      qword ptr [7FFB0D96D150]
       int       3
M03_L20:
       mov       rcx,r15
       mov       edx,edi
       lea       r11,[7FFB0D96FDC8]
       call      qword ptr [7FFB0D96FDC8]
       mov       r12d,eax
       jmp       near ptr M03_L01
M03_L21:
       call      qword ptr [7FFB0D970578]
       int       3
; Total bytes of code 760
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.BytesToString(Byte[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M04_L00
       mov       rax,24E47123020
       mov       rdi,[rax]
       mov       rax,24E67129198
       mov       rbx,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M04_L00:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       ebx,[rsi+8]
       mov       edx,ebx
       mov       rcx,rdi
       mov       r8d,7FFFFFFF
       call      System.Text.StringBuilder..ctor(Int32, Int32)
       xor       ebp,ebp
       test      ebx,ebx
       jle       short M04_L02
       mov       rdx,24E47121568
       mov       r14,[rdx]
       mov       rdx,24E6712A3A0
       mov       r15,[rdx]
M04_L01:
       movsxd    rdx,ebp
       lea       rdx,[rsi+rdx+10]
       mov       r8,r14
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r15
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|42_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       add       ebp,1
       jo        short M04_L03
       cmp       ebx,ebp
       jg        short M04_L01
M04_L02:
       mov       rcx,rdi
       mov       rax,[7FFAAF3F78C0]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       rax
M04_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 223
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowKeyNotFoundException[[System.Int32, System.Private.CoreLib]](Int32)

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.ContainsAny01()
; 			var result = base.GetPersonProperArray(Tristate.False).ContainsAny(base.GetPersonProperArray(Tristate.False, collectionSize: CollectionSize.Half));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       r8,[rsi+118]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.ContainsAny(!!0[], !!0[])
       call      DotNetTips.Spargine.Extensions.ArrayExtensions.ContainsAny[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       mov       rdx,[rsi+20]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 50
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.ContainsAny[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,r8
       mov       rbp,[rsi+10]
       cmp       qword ptr [rbp+10],0
       je        short M01_L00
       mov       rcx,[rbp+10]
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFAAF445C60
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       test      rbx,rbx
       jne       short M01_L02
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M01_L02:
       mov       rax,rdi
       test      rax,rax
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L03
       mov       rax,1C0813D3020
       mov       r15,[rax]
       mov       rax,1C0813D6A80
       mov       r12,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,r15
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L03:
       mov       rcx,[rbp+20]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FFAAF445EE0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L05:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       test      rax,rax
       jne       short M01_L06
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M01_L06:
       mov       rcx,[rbp+28]
       test      rcx,rcx
       je        short M01_L07
       jmp       short M01_L08
M01_L07:
       mov       rcx,rsi
       mov       rdx,7FFAAF446610
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L08:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       lea       rcx,[r14+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[r14+8]
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
       test      eax,eax
       je        near ptr M01_L15
       mov       rcx,[rbp+28]
       test      rcx,rcx
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FFAAF446610
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L10:
       mov       rdi,[rsi+10]
       mov       rdx,rbx
       call      DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       mov       rbx,rax
       cmp       qword ptr [rdi+8],30
       jle       short M01_L11
       mov       rcx,[rdi+30]
       test      rcx,rcx
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rsi
       mov       rdx,7FFAAF446C30
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L12:
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ArrayExtensions+<>c__DisplayClass10_0`1[[System.__Canon, System.Private.CoreLib]].<ContainsAny>b__0(System.__Canon)
       mov       [rdi+18],rcx
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       short M01_L13
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M01_L13
       jmp       short M01_L14
M01_L13:
       mov       rcx,rsi
       mov       rdx,7FFAAF446C70
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L14:
       mov       rdx,rbx
       mov       r8,rdi
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       jmp       near ptr System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
M01_L15:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
; Total bytes of code 501
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.ContainsAny01()
; 			var result = base.GetPersonProperArray(Tristate.False).ContainsAny(base.GetPersonProperArray(Tristate.False, collectionSize: CollectionSize.Half));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       r8,[rsi+118]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.ContainsAny(!!0[], !!0[])
       call      DotNetTips.Spargine.Extensions.ArrayExtensions.ContainsAny[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       mov       rdx,[rsi+20]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 50
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.ContainsAny[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,r8
       mov       rbp,[rsi+10]
       cmp       qword ptr [rbp+10],0
       je        short M01_L00
       mov       rcx,[rbp+10]
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFAAF465C60
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       test      rbx,rbx
       jne       short M01_L02
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M01_L02:
       mov       rax,rdi
       test      rax,rax
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L03
       mov       rax,14E42E73020
       mov       r15,[rax]
       mov       rax,14E42E76A80
       mov       r12,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,r15
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L03:
       mov       rcx,[rbp+20]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FFAAF465EE0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L05:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       test      rax,rax
       jne       short M01_L06
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M01_L06:
       mov       rcx,[rbp+28]
       test      rcx,rcx
       je        short M01_L07
       jmp       short M01_L08
M01_L07:
       mov       rcx,rsi
       mov       rdx,7FFAAF466610
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L08:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       lea       rcx,[r14+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[r14+8]
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
       test      eax,eax
       je        near ptr M01_L15
       mov       rcx,[rbp+28]
       test      rcx,rcx
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FFAAF466610
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L10:
       mov       rdi,[rsi+10]
       mov       rdx,rbx
       call      DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       mov       rbx,rax
       cmp       qword ptr [rdi+8],30
       jle       short M01_L11
       mov       rcx,[rdi+30]
       test      rcx,rcx
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rsi
       mov       rdx,7FFAAF466C30
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L12:
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ArrayExtensions+<>c__DisplayClass10_0`1[[System.__Canon, System.Private.CoreLib]].<ContainsAny>b__0(System.__Canon)
       mov       [rdi+18],rcx
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       short M01_L13
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M01_L13
       jmp       short M01_L14
M01_L13:
       mov       rcx,rsi
       mov       rdx,7FFAAF466C70
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L14:
       mov       rdx,rbx
       mov       r8,rdi
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       jmp       near ptr System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
M01_L15:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
; Total bytes of code 501
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.ContainsAny01()
; 			var result = base.GetPersonProperArray(Tristate.False).ContainsAny(base.GetPersonProperArray(Tristate.False, collectionSize: CollectionSize.Half));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       r8,[rsi+118]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.ContainsAny(!!0[], !!0[])
       call      DotNetTips.Spargine.Extensions.ArrayExtensions.ContainsAny[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       mov       rdx,[rsi+20]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 50
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.ContainsAny[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,r8
       mov       rbp,[rsi+10]
       cmp       qword ptr [rbp+10],0
       je        short M01_L00
       mov       rcx,[rbp+10]
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFAAF445C60
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       test      rbx,rbx
       jne       short M01_L02
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M01_L02:
       mov       rax,rdi
       test      rax,rax
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L03
       mov       rax,21EDE683020
       mov       r15,[rax]
       mov       rax,21EDE685A68
       mov       r12,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,r15
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L03:
       mov       rcx,[rbp+20]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FFAAF445EE0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L05:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       test      rax,rax
       jne       short M01_L06
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M01_L06:
       mov       rcx,[rbp+28]
       test      rcx,rcx
       je        short M01_L07
       jmp       short M01_L08
M01_L07:
       mov       rcx,rsi
       mov       rdx,7FFAAF446610
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L08:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       lea       rcx,[r14+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[r14+8]
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
       test      eax,eax
       je        near ptr M01_L15
       mov       rcx,[rbp+28]
       test      rcx,rcx
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FFAAF446610
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L10:
       mov       rdi,[rsi+10]
       mov       rdx,rbx
       call      DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       mov       rbx,rax
       cmp       qword ptr [rdi+8],30
       jle       short M01_L11
       mov       rcx,[rdi+30]
       test      rcx,rcx
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rsi
       mov       rdx,7FFAAF446C30
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L12:
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ArrayExtensions+<>c__DisplayClass10_0`1[[System.__Canon, System.Private.CoreLib]].<ContainsAny>b__0(System.__Canon)
       mov       [rdi+18],rcx
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       short M01_L13
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M01_L13
       jmp       short M01_L14
M01_L13:
       mov       rcx,rsi
       mov       rdx,7FFAAF446C70
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L14:
       mov       rdx,rbx
       mov       r8,rdi
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       jmp       near ptr System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
M01_L15:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
; Total bytes of code 501
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.ContainsAny01()
; 			var result = base.GetPersonProperArray(Tristate.False).ContainsAny(base.GetPersonProperArray(Tristate.False, collectionSize: CollectionSize.Half));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       r8,[rsi+118]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.ContainsAny(!!0[], !!0[])
       call      DotNetTips.Spargine.Extensions.ArrayExtensions.ContainsAny[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       mov       rdx,[rsi+20]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 50
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.ContainsAny[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,r8
       mov       rbp,[rsi+10]
       cmp       qword ptr [rbp+10],0
       je        short M01_L00
       mov       rcx,[rbp+10]
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFAAF455C60
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       test      rbx,rbx
       jne       short M01_L02
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M01_L02:
       mov       rax,rdi
       test      rax,rax
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L03
       mov       rax,2BCE9BE3020
       mov       r15,[rax]
       mov       rax,2BCE9BF2EB0
       mov       r12,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,r15
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L03:
       mov       rcx,[rbp+20]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FFAAF455EE0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L05:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       test      rax,rax
       jne       short M01_L06
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M01_L06:
       mov       rcx,[rbp+28]
       test      rcx,rcx
       je        short M01_L07
       jmp       short M01_L08
M01_L07:
       mov       rcx,rsi
       mov       rdx,7FFAAF456610
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L08:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       lea       rcx,[r14+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[r14+8]
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
       test      eax,eax
       je        near ptr M01_L15
       mov       rcx,[rbp+28]
       test      rcx,rcx
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FFAAF456610
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L10:
       mov       rdi,[rsi+10]
       mov       rdx,rbx
       call      DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       mov       rbx,rax
       cmp       qword ptr [rdi+8],30
       jle       short M01_L11
       mov       rcx,[rdi+30]
       test      rcx,rcx
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rsi
       mov       rdx,7FFAAF456C30
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L12:
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ArrayExtensions+<>c__DisplayClass10_0`1[[System.__Canon, System.Private.CoreLib]].<ContainsAny>b__0(System.__Canon)
       mov       [rdi+18],rcx
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       short M01_L13
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M01_L13
       jmp       short M01_L14
M01_L13:
       mov       rcx,rsi
       mov       rdx,7FFAAF456C70
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L14:
       mov       rdx,rbx
       mov       r8,rdi
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       jmp       near ptr System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
M01_L15:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
; Total bytes of code 501
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.ContainsAny01()
; 			var result = base.GetPersonProperArray(Tristate.False).ContainsAny(base.GetPersonProperArray(Tristate.False, collectionSize: CollectionSize.Half));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       r8,[rsi+118]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.ContainsAny(!!0[], !!0[])
       call      DotNetTips.Spargine.Extensions.ArrayExtensions.ContainsAny[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       mov       rdx,[rsi+20]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 50
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.ContainsAny[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,r8
       mov       rbp,[rsi+10]
       cmp       qword ptr [rbp+10],0
       je        short M01_L00
       mov       rcx,[rbp+10]
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFAAF445C60
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       test      rbx,rbx
       jne       short M01_L02
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M01_L02:
       mov       rax,rdi
       test      rax,rax
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L03
       mov       rax,243E6911028
       mov       r15,[rax]
       mov       rax,243E6914A88
       mov       r12,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,r15
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L03:
       mov       rcx,[rbp+20]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FFAAF445EE0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L05:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       test      rax,rax
       jne       short M01_L06
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M01_L06:
       mov       rcx,[rbp+28]
       test      rcx,rcx
       je        short M01_L07
       jmp       short M01_L08
M01_L07:
       mov       rcx,rsi
       mov       rdx,7FFAAF446610
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L08:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       lea       rcx,[r14+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[r14+8]
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
       test      eax,eax
       je        near ptr M01_L15
       mov       rcx,[rbp+28]
       test      rcx,rcx
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FFAAF446610
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L10:
       mov       rdi,[rsi+10]
       mov       rdx,rbx
       call      DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       mov       rbx,rax
       cmp       qword ptr [rdi+8],30
       jle       short M01_L11
       mov       rcx,[rdi+30]
       test      rcx,rcx
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rsi
       mov       rdx,7FFAAF446C30
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L12:
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ArrayExtensions+<>c__DisplayClass10_0`1[[System.__Canon, System.Private.CoreLib]].<ContainsAny>b__0(System.__Canon)
       mov       [rdi+18],rcx
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       short M01_L13
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M01_L13
       jmp       short M01_L14
M01_L13:
       mov       rcx,rsi
       mov       rdx,7FFAAF446C70
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L14:
       mov       rdx,rbx
       mov       r8,rdi
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       jmp       near ptr System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
M01_L15:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
; Total bytes of code 501
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.ContainsAny01()
; 			var result = base.GetPersonProperArray(Tristate.False).ContainsAny(base.GetPersonProperArray(Tristate.False, collectionSize: CollectionSize.Half));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       r8,[rsi+118]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.ContainsAny(!!0[], !!0[])
       call      DotNetTips.Spargine.Extensions.ArrayExtensions.ContainsAny[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       mov       rdx,[rsi+20]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 50
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.ContainsAny[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,r8
       mov       rbp,[rsi+10]
       cmp       qword ptr [rbp+10],0
       je        short M01_L00
       mov       rcx,[rbp+10]
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFAAF455C18
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       test      rbx,rbx
       jne       short M01_L02
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M01_L02:
       mov       rax,rdi
       test      rax,rax
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L03
       mov       rax,1250B8B3020
       mov       r15,[rax]
       mov       rax,1253B8B1660
       mov       r12,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,r15
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L03:
       mov       rcx,[rbp+20]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FFAAF455E98
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L05:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       test      rax,rax
       jne       short M01_L06
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M01_L06:
       mov       rcx,[rbp+28]
       test      rcx,rcx
       je        short M01_L07
       jmp       short M01_L08
M01_L07:
       mov       rcx,rsi
       mov       rdx,7FFAAF4565C8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L08:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       lea       rcx,[r14+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[r14+8]
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
       test      eax,eax
       je        near ptr M01_L15
       mov       rcx,[rbp+28]
       test      rcx,rcx
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FFAAF4565C8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L10:
       mov       rdi,[rsi+10]
       mov       rdx,rbx
       call      DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       mov       rbx,rax
       cmp       qword ptr [rdi+8],30
       jle       short M01_L11
       mov       rcx,[rdi+30]
       test      rcx,rcx
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rsi
       mov       rdx,7FFAAF456BE8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L12:
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ArrayExtensions+<>c__DisplayClass10_0`1[[System.__Canon, System.Private.CoreLib]].<ContainsAny>b__0(System.__Canon)
       mov       [rdi+18],rcx
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       short M01_L13
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M01_L13
       jmp       short M01_L14
M01_L13:
       mov       rcx,rsi
       mov       rdx,7FFAAF456C28
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L14:
       mov       rdx,rbx
       mov       r8,rdi
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       jmp       near ptr System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
M01_L15:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
; Total bytes of code 501
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.ContainsAny01()
; 			var result = base.GetPersonProperArray(Tristate.False).ContainsAny(base.GetPersonProperArray(Tristate.False, collectionSize: CollectionSize.Half));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       r8,[rsi+118]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.ContainsAny(!!0[], !!0[])
       call      DotNetTips.Spargine.Extensions.ArrayExtensions.ContainsAny[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       mov       rdx,[rsi+20]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 50
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.ContainsAny[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,r8
       mov       rbp,[rsi+10]
       cmp       qword ptr [rbp+10],0
       je        short M01_L00
       mov       rcx,[rbp+10]
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFAAF455C18
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       test      rbx,rbx
       jne       short M01_L02
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M01_L02:
       mov       rax,rdi
       test      rax,rax
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L03
       mov       rax,202943C3020
       mov       r15,[rax]
       mov       rax,202A43C1660
       mov       r12,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,r15
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L03:
       mov       rcx,[rbp+20]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FFAAF455E98
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L05:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       test      rax,rax
       jne       short M01_L06
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M01_L06:
       mov       rcx,[rbp+28]
       test      rcx,rcx
       je        short M01_L07
       jmp       short M01_L08
M01_L07:
       mov       rcx,rsi
       mov       rdx,7FFAAF4565C8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L08:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       lea       rcx,[r14+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[r14+8]
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
       test      eax,eax
       je        near ptr M01_L15
       mov       rcx,[rbp+28]
       test      rcx,rcx
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FFAAF4565C8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L10:
       mov       rdi,[rsi+10]
       mov       rdx,rbx
       call      DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       mov       rbx,rax
       cmp       qword ptr [rdi+8],30
       jle       short M01_L11
       mov       rcx,[rdi+30]
       test      rcx,rcx
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rsi
       mov       rdx,7FFAAF456BE8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L12:
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ArrayExtensions+<>c__DisplayClass10_0`1[[System.__Canon, System.Private.CoreLib]].<ContainsAny>b__0(System.__Canon)
       mov       [rdi+18],rcx
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       short M01_L13
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M01_L13
       jmp       short M01_L14
M01_L13:
       mov       rcx,rsi
       mov       rdx,7FFAAF456C28
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L14:
       mov       rdx,rbx
       mov       r8,rdi
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       jmp       near ptr System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
M01_L15:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
; Total bytes of code 501
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.ContainsAny01()
; 			var result = base.GetPersonProperArray(Tristate.False).ContainsAny(base.GetPersonProperArray(Tristate.False, collectionSize: CollectionSize.Half));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+110]
       mov       r8,[rsi+118]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ArrayExtensions.ContainsAny(!!0[], !!0[])
       call      DotNetTips.Spargine.Extensions.ArrayExtensions.ContainsAny[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       mov       rdx,[rsi+20]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 50
```
```assembly
; DotNetTips.Spargine.Extensions.ArrayExtensions.ContainsAny[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,r8
       mov       rbp,[rsi+10]
       cmp       qword ptr [rbp+10],0
       je        short M01_L00
       mov       rcx,[rbp+10]
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFAAF459750
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       test      rbx,rbx
       jne       short M01_L02
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M01_L02:
       mov       rax,rdi
       test      rax,rax
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L03
       mov       rax,2254BB93020
       mov       r15,[rax]
       mov       rax,2254BBA36C8
       mov       r12,[rax]
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,r15
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L03:
       mov       rcx,[rbp+20]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FFAAF4599D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L05:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       test      rax,rax
       jne       short M01_L06
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M01_L06:
       mov       rcx,[rbp+28]
       test      rcx,rcx
       je        short M01_L07
       jmp       short M01_L08
M01_L07:
       mov       rcx,rsi
       mov       rdx,7FFAAF45A100
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L08:
       mov       rdx,rdi
       call      DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       lea       rcx,[r14+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[r14+8]
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
       test      eax,eax
       je        near ptr M01_L15
       mov       rcx,[rbp+28]
       test      rcx,rcx
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FFAAF45A100
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L10:
       mov       rdi,[rsi+10]
       mov       rdx,rbx
       call      DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       mov       rbx,rax
       cmp       qword ptr [rdi+8],30
       jle       short M01_L11
       mov       rcx,[rdi+30]
       test      rcx,rcx
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rsi
       mov       rdx,7FFAAF45A720
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L12:
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ArrayExtensions+<>c__DisplayClass10_0`1[[System.__Canon, System.Private.CoreLib]].<ContainsAny>b__0(System.__Canon)
       mov       [rdi+18],rcx
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       short M01_L13
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M01_L13
       jmp       short M01_L14
M01_L13:
       mov       rcx,rsi
       mov       rdx,7FFAAF45A760
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L14:
       mov       rdx,rbx
       mov       r8,rdi
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       jmp       near ptr System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
M01_L15:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
; Total bytes of code 501
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.ArrayHashCode01()
; 			var result = base.GetPersonProperArray(Tristate.False, collectionSize: CollectionSize.Half);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result.GetHashCode());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rax,[rcx+118]
       mov       rsi,[rcx+20]
       cmp       [rax],eax
       mov       rcx,rax
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsi+40],eax
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 35
```
**Extern method**
System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.ArrayHashCode01()
; 			var result = base.GetPersonProperArray(Tristate.False, collectionSize: CollectionSize.Half);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result.GetHashCode());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rax,[rcx+118]
       mov       rsi,[rcx+20]
       cmp       [rax],eax
       mov       rcx,rax
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsi+40],eax
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 35
```
**Extern method**
System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.ArrayHashCode01()
; 			var result = base.GetPersonProperArray(Tristate.False, collectionSize: CollectionSize.Half);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result.GetHashCode());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rax,[rcx+118]
       mov       rsi,[rcx+20]
       cmp       [rax],eax
       mov       rcx,rax
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsi+40],eax
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 35
```
**Extern method**
System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.ArrayHashCode01()
; 			var result = base.GetPersonProperArray(Tristate.False, collectionSize: CollectionSize.Half);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result.GetHashCode());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rax,[rcx+118]
       mov       rsi,[rcx+20]
       cmp       [rax],eax
       mov       rcx,rax
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsi+40],eax
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 35
```
**Extern method**
System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.ArrayHashCode01()
; 			var result = base.GetPersonProperArray(Tristate.False, collectionSize: CollectionSize.Half);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result.GetHashCode());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rax,[rcx+118]
       mov       rsi,[rcx+20]
       cmp       [rax],eax
       mov       rcx,rax
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsi+40],eax
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 35
```
**Extern method**
System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.ArrayHashCode01()
; 			var result = base.GetPersonProperArray(Tristate.False, collectionSize: CollectionSize.Half);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result.GetHashCode());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rax,[rcx+118]
       mov       rsi,[rcx+20]
       cmp       [rax],eax
       mov       rcx,rax
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsi+40],eax
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 35
```
**Extern method**
System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.ArrayHashCode01()
; 			var result = base.GetPersonProperArray(Tristate.False, collectionSize: CollectionSize.Half);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result.GetHashCode());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rax,[rcx+118]
       mov       rsi,[rcx+20]
       cmp       [rax],eax
       mov       rcx,rax
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsi+40],eax
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 35
```
**Extern method**
System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.ArrayHashCode01()
; 			var result = base.GetPersonProperArray(Tristate.False, collectionSize: CollectionSize.Half);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result.GetHashCode());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rax,[rcx+118]
       mov       rsi,[rcx+20]
       cmp       [rax],eax
       mov       rcx,rax
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsi+40],eax
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 35
```
**Extern method**
System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
