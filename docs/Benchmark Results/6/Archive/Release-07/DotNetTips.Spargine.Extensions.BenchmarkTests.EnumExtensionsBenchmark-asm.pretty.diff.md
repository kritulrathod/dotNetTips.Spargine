## DotNetTips.Spargine.Extensions.BenchmarkTests.EnumExtensionsBenchmark-20231027-224157
**Diff for GetDescription01 method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumExtensionsBenchmark.GetDescription01()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
        mov       rcx,offset MT_System.StringComparison
        call      CORINFO_HELP_NEWSFAST
        mov       ecx,[rsi+190]
        mov       [rax+8],ecx
        mov       rcx,rax
-       call      DotNetTips.Spargine.Extensions.EnumExtensions.GetDescription(System.Enum)
+       call      qword ptr [7FF9C66EBFA8]; DotNetTips.Spargine.Extensions.EnumExtensions.GetDescription(System.Enum)
        mov       [rsp+28],rax
        mov       rcx,[rsi+18]
        lea       r8,[rsp+28]
        mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FF9C66ED120]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 85
+; Total bytes of code 87
 ; DotNetTips.Spargine.Extensions.EnumExtensions.GetDescription(System.Enum)
        push      rbp
        sub       rsp,0A0
        lea       rbp,[rsp+0A0]
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rbp-70],xmm4
        mov       rax,0FFFFFFFFFFFFFFA0
 M01_L00:
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        vmovdqa   xmmword ptr [rbp+rax+20],xmm4
        add       rax,30
        jne       short M01_L00
        mov       [rbp+10],rcx
-       cmp       dword ptr [7FF9C59981E0],0
+       cmp       dword ptr [7FF9C644CCB8],0
        je        short M01_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L01:
        nop
-       mov       r9,1AD7191B6F8
+       mov       r9,22673410848
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,1AD71913020
+       mov       r9,22673402028
        mov       r9,[r9]
        mov       rdx,[rbp+10]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Enum, System.Private.CoreLib]](System.Enum, System.Enum, System.String, System.String)
        xor       r8d,r8d
-       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      qword ptr [7FF9C64ADE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-20],rax
        mov       rcx,[rbp-20]
        mov       [rbp+10],rcx
        mov       rcx,[rbp+10]
        cmp       [rcx],ecx
        call      System.Object.GetType()
        mov       [rbp-28],rax
        mov       rcx,[rbp+10]
        mov       rax,[rbp+10]
        mov       rax,[rax]
        mov       rax,[rax+40]
        call      qword ptr [rax+8]
        mov       [rbp-30],rax
        mov       rcx,[rbp-28]
        mov       rdx,[rbp-30]
        cmp       [rcx],ecx
-       call      System.Type.GetField(System.String)
+       call      qword ptr [7FF9C5F33930]; System.Type.GetField(System.String)
        mov       [rbp-38],rax
        mov       rcx,[rbp-38]
        mov       [rbp-8],rcx
        mov       rcx,offset MT_System.ComponentModel.DescriptionAttribute
        call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
        mov       [rbp-40],rax
        mov       rcx,[rbp-8]
        mov       [rbp-48],rcx
        mov       rcx,[rbp-40]
-       call      System.Type.GetTypeFromHandle(System.RuntimeTypeHandle)
+       call      qword ptr [7FF9C5F330C0]; System.Type.GetTypeFromHandle(System.RuntimeTypeHandle)
        mov       [rbp-50],rax
        mov       rcx,[rbp-48]
        mov       rdx,[rbp-50]
        xor       r8d,r8d
        mov       rax,[rbp-48]
        mov       rax,[rax]
        mov       rax,[rax+48]
        call      qword ptr [rax+28]
        mov       [rbp-58],rax
        mov       rdx,[rbp-58]
        mov       rcx,offset MT_System.ComponentModel.DescriptionAttribute[]
-       call      CORINFO_HELP_CHKCASTARRAY
+       call      qword ptr [7FF9C5FBB858]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
        mov       [rbp-10],rax
        mov       rcx,[rbp-10]
        cmp       dword ptr [rcx+8],0
        jne       short M01_L02
        mov       rcx,[rbp+10]
        mov       rax,[rbp+10]
        mov       rax,[rax]
        mov       rax,[rax+40]
        call      qword ptr [rax+8]
        mov       [rbp-68],rax
        mov       rcx,[rbp-68]
        mov       [rbp-60],rcx
        jmp       short M01_L04
        mov       edx,eax
        lea       rcx,[rcx+rdx*8+10]
        mov       rcx,[rcx]
        mov       [rbp-70],rcx
        mov       rcx,[rbp-70]
        mov       rax,[rbp-70]
        mov       rax,[rax]
        mov       rax,[rax+40]
        call      qword ptr [rax+38]
        mov       [rbp-60],rax
 M01_L04:
        mov       rax,[rbp-60]
        mov       [rbp-18],rax
        nop
-       jmp       short M01_L05
-M01_L05:
        mov       rax,[rbp-18]
        add       rsp,0A0
        pop       rbp
        ret
-; Total bytes of code 416
+; Total bytes of code 418
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
**Diff for GetItems01 method between:**
.NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
.NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumExtensionsBenchmark.GetItems01()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
        mov       rcx,offset MT_System.StringComparison
        call      CORINFO_HELP_NEWSFAST
        mov       ecx,[rsi+190]
        mov       [rax+8],ecx
        mov       rcx,rax
-       call      DotNetTips.Spargine.Extensions.EnumExtensions.GetItems(System.Enum)
+       call      qword ptr [7FF9C66F9420]; DotNetTips.Spargine.Extensions.EnumExtensions.GetItems(System.Enum)
        mov       [rsp+28],rax
        mov       rcx,[rsi+18]
        lea       r8,[rsp+28]
        mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IList`1[[System.ValueTuple`2[[System.String, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]], System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IList`1<System.ValueTuple`2<System.String,Int32>> ByRef)
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FF9C66F9C90]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 85
+; Total bytes of code 87
 ; DotNetTips.Spargine.Extensions.EnumExtensions.GetItems(System.Enum)
        push      rbp
        sub       rsp,0C0
        vzeroupper
        lea       rbp,[rsp+0C0]
        xor       eax,eax
        mov       [rbp-98],rax
        vxorps    xmm4,xmm4,xmm4
        mov       rax,0FFFFFFFFFFFFFF70
 M01_L00:
        vmovdqa   xmmword ptr [rax+rbp],xmm4
        vmovdqa   xmmword ptr [rbp+rax+10],xmm4
        vmovdqa   xmmword ptr [rbp+rax+20],xmm4
        add       rax,30
        jne       short M01_L00
        mov       [rbp+10],rcx
-       cmp       dword ptr [7FF9C59581E0],0
+       cmp       dword ptr [7FF9C644C920],0
        je        short M01_L01
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L01:
        nop
-       mov       r9,23E518F3808
+       mov       r9,22C7A812840
        mov       r9,[r9]
        mov       [rsp+20],r9
-       mov       r9,23E518E3020
+       mov       r9,22C7A802028
        mov       r9,[r9]
        mov       rdx,[rbp+10]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Enum, System.Private.CoreLib]](System.Enum, System.Enum, System.String, System.String)
        xor       r8d,r8d
-       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
+       call      qword ptr [7FF9C64CBE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
        mov       [rbp-30],rax
        mov       rcx,[rbp-30]
        mov       [rbp+10],rcx
        mov       rcx,offset MT_System.Collections.Generic.List`1[[System.ValueTuple`2[[System.String, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]], System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-38],rax
        mov       rcx,[rbp-38]
-       call      System.Collections.Generic.List`1[[System.ValueTuple`2[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]], System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FF9C66F9480]; System.Collections.Generic.List`1[[System.ValueTuple`2[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]], System.Private.CoreLib]]..ctor()
        mov       rcx,[rbp-38]
        mov       [rbp-8],rcx
        nop
        mov       rcx,[rbp+10]
        cmp       [rcx],ecx
        call      System.Object.GetType()
        mov       [rbp-40],rax
        mov       rcx,[rbp-40]
-       call      System.Enum.GetNames(System.Type)
+       call      qword ptr [7FF9C5F51648]; System.Enum.GetNames(System.Type)
        mov       [rbp-48],rax
        mov       rcx,[rbp-48]
        mov       [rbp-10],rcx
        xor       ecx,ecx
        mov       [rbp-14],ecx
        nop
        jmp       near ptr M01_L04
        mov       rcx,[rbp-10]
        mov       eax,[rbp-14]
        cmp       eax,[rcx+8]
        jb        short M01_L03
        call      CORINFO_HELP_RNGCHKFAIL
 M01_L03:
        mov       edx,eax
        lea       rcx,[rcx+rdx*8+10]
        mov       rcx,[rcx]
        mov       [rbp-20],rcx
        nop
        mov       rcx,[rbp-8]
        mov       [rbp-50],rcx
        mov       rcx,[rbp-20]
        mov       [rbp-58],rcx
        mov       rcx,[rbp+10]
        cmp       [rcx],ecx
        call      System.Object.GetType()
        mov       [rbp-60],rax
        mov       rcx,[rbp-60]
        mov       rdx,[rbp-20]
-       call      System.Enum.Parse(System.Type, System.String)
+       call      qword ptr [7FF9C5F51720]; System.Enum.Parse(System.Type, System.String)
        mov       [rbp-68],rax
        vxorps    xmm0,xmm0,xmm0
        vmovdqu   xmmword ptr [rbp-78],xmm0
        mov       rdx,[rbp-68]
        mov       rcx,offset MT_System.Int32
-       call      CORINFO_HELP_UNBOX
+       call      qword ptr [7FF9C5FDB8D0]; System.Runtime.CompilerServices.CastHelpers.Unbox(Void*, System.Object)
        mov       r9d,[rax]
        mov       [rbp-7C],r9d
        mov       r9d,[rbp-7C]
        lea       rcx,[rbp-78]
        mov       r8,[rbp-58]
        mov       rdx,offset MT_System.ValueTuple`2[[System.String, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]]
-       call      System.ValueTuple`2[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]]..ctor(System.__Canon, Int32)
+       call      qword ptr [7FF9C66F9000]; System.ValueTuple`2[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]]..ctor(System.__Canon, Int32)
        mov       rcx,[rbp-50]
        mov       [rbp-98],rcx
        vmovdqu   xmm0,xmmword ptr [rbp-78]
        vmovdqu   xmmword ptr [rbp-90],xmm0
        mov       rcx,[rbp-98]
        lea       rdx,[rbp-90]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9C5BB7398]; System.Collections.Generic.List`1[[System.ValueTuple`2[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]], System.Private.CoreLib]].Add(System.ValueTuple`2<System.__Canon,Int32>)
+       call      qword ptr [7FF9C67130A8]; System.Collections.Generic.List`1[[System.ValueTuple`2[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]], System.Private.CoreLib]].Add(System.ValueTuple`2<System.__Canon,Int32>)
        nop
        nop
        mov       eax,[rbp-14]
        inc       eax
        mov       [rbp-14],eax
 M01_L04:
        mov       ecx,[rbp-14]
        mov       rax,[rbp-10]
        cmp       ecx,[rax+8]
        jl        near ptr M01_L02
        mov       rax,[rbp-8]
        mov       [rbp-28],rax
        nop
-       jmp       short M01_L05
-M01_L05:
        mov       rax,[rbp-28]
        add       rsp,0C0
        pop       rbp
        ret
-; Total bytes of code 471
+; Total bytes of code 475
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
