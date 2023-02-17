## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.BenchmarkTests.IO.DirectoryHelperBenchmark.AppDataFolder01()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       call      DotNetTips.Spargine.IO.DirectoryHelper.AppDataFolder()
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 38
```
```assembly
; DotNetTips.Spargine.IO.DirectoryHelper.AppDataFolder()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       lea       rbp,[rsp+0C0]
       xor       ecx,ecx
       mov       [rbp+0FFC0],rcx
       mov       [rbp+0FFB8],rcx
       lea       rcx,[rbp+0FF70]
       mov       rdx,r10
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rax,rsp
       mov       [rbp+0FF90],rax
       mov       rax,rbp
       mov       [rbp+0FFA0],rax
       call      System.Runtime.InteropServices.OSPlatform.get_Windows()
       mov       rcx,rax
       call      System.OperatingSystem.IsOSPlatform(System.String)
       test      al,al
       jne       short M01_L00
       mov       rcx,22CF00A5B68
       mov       rcx,[rcx]
       jmp       short M01_L01
M01_L00:
       mov       rcx,22CF00A5B70
       mov       rcx,[rcx]
M01_L01:
       call      System.Environment.GetEnvironmentVariable(System.String)
       mov       [rbp+0FFB0],rax
       cmp       byte ptr [7FFED0B353B9],0
       jne       near ptr M01_L05
       xor       ecx,ecx
       mov       [rbp+0FFC0],rcx
       lea       rcx,[rbp+0FFC0]
       mov       rax,offset MD_System.Reflection.Assembly.GetEntryAssemblyNative(System.Runtime.CompilerServices.ObjectHandleOnStack)
       mov       [rbp+0FF80],rax
       lea       rax,[M01_L02]
       mov       [rbp+0FF98],rax
       lea       rax,[rbp+0FF70]
       mov       [rsi+10],rax
       mov       byte ptr [rsi+0C],0
       call      qword ptr [7FFED0B31118]
M01_L02:
       mov       byte ptr [rsi+0C],1
       cmp       dword ptr [7FFED0B34A34],0
       je        short M01_L03
       call      qword ptr [7FFED0B36398]
M01_L03:
       mov       rcx,[rbp+0FF78]
       mov       [rsi+10],rcx
       mov       rsi,[rbp+0FFC0]
       xor       ecx,ecx
       mov       [rbp+0FFC0],rcx
M01_L04:
       mov       rcx,offset MT_System.Reflection.AssemblyCompanyAttribute
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rdx,rax
       mov       rcx,rsi
       mov       r8d,1
       call      System.Attribute.GetCustomAttributes(System.Reflection.Assembly, System.Type, Boolean)
       mov       rdx,rax
       mov       rcx,offset MT_System.Collections.Generic.IEnumerable`1[[System.Reflection.AssemblyCompanyAttribute, System.Private.CoreLib]]
       call      CORINFO_HELP_CHKCASTARRAY
       mov       rdx,rax
       lea       r8,[rbp+0FFB8]
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetFirst(System.Collections.Generic.IEnumerable`1<!!0>, Boolean ByRef)
       call      System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       mov       rcx,[rax+8]
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdx,rax
       mov       rcx,[rbp+0FFB0]
       call      System.IO.Path.Combine(System.String, System.String)
       nop
       add       rsp,88
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L05:
       xor       esi,esi
       jmp       short M01_L04
; Total bytes of code 357
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.BenchmarkTests.IO.DirectoryHelperBenchmark.LoadOneDriveFolders01()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       call      DotNetTips.Spargine.IO.DirectoryHelper.LoadOneDriveFolders()
       mov       [rsp+28],rax
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.ValueTypesConsumer(!!0 ByRef)
       call      BenchmarkDotNet.Engines.Consumer.ValueTypesConsumer[[System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]](System.Collections.Immutable.ImmutableArray`1<System.__Canon> ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 58
```
```assembly
; DotNetTips.Spargine.IO.DirectoryHelper.LoadOneDriveFolders()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp+0FFD0],rax
       mov       [rbp+0FFC8],rax
       mov       [rbp+0FFB8],rsp
       call      System.Runtime.InteropServices.OSPlatform.get_Windows()
       mov       rcx,rax
       call      System.OperatingSystem.IsOSPlatform(System.String)
       test      al,al
       je        near ptr M01_L15
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.IO.OneDriveFolder, dotNetTips.Spargine.6]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,7FFED0884928
       mov       edx,28
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rdx,27B86682FF8
       mov       rdx,[rdx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,27B8668AF88
       mov       rcx,[rcx]
       mov       edx,80000001
       call      DotNetTips.Spargine.Win32.RegistryHelper.GetRegistryKey(System.String, Microsoft.Win32.RegistryHive)
       mov       [rbp+0FFD0],rax
       test      rax,rax
       je        near ptr M01_L13
       mov       rdx,27B8668AF90
       mov       rdx,[rdx]
       mov       rcx,rax
       call      DotNetTips.Spargine.Extensions.RegistryExtensions.GetSubKey(Microsoft.Win32.RegistryKey, System.String)
       mov       rcx,rax
       mov       [rbp+0FFC8],rcx
       test      rcx,rcx
       je        near ptr M01_L12
       call      Microsoft.Win32.RegistryKey.EnsureNotDisposed()
       mov       rcx,[rbp+0FFC8]
       call      Microsoft.Win32.RegistryKey.InternalSubKeyCountCore()
       test      eax,eax
       jle       near ptr M01_L12
       xor       edi,edi
       jmp       near ptr M01_L10
M01_L00:
       mov       rcx,[rbp+0FFC8]
       call      Microsoft.Win32.RegistryKey.GetSubKeyNames()
       cmp       edi,[rax+8]
       jae       near ptr M01_L07
       movsxd    rcx,edi
       mov       rbx,[rax+rcx*8+10]
       mov       rcx,rbx
       call      Microsoft.Win32.RegistryKey.ValidateKeyName(System.String)
       mov       rcx,[rbp+0FFC8]
       call      Microsoft.Win32.RegistryKey.EnsureNotDisposed()
       mov       rcx,rbx
       call      Microsoft.Win32.RegistryKey.FixupName(System.String)
       mov       rdx,rax
       mov       rcx,[rbp+0FFC8]
       xor       r8d,r8d
       call      Microsoft.Win32.RegistryKey.InternalOpenSubKeyCore(System.String, Boolean)
       mov       [rbp+0FFC0],rax
       mov       rcx,offset MT_DotNetTips.Spargine.IO.OneDriveFolder
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      DotNetTips.Spargine.Extensions.ObjectExtensions.InitializeFields(System.Object)
       mov       r8,27B8668AF98
       mov       r8,[r8]
       mov       rdx,[rbp+0FFC0]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.RegistryExtensions.GetValue(Microsoft.Win32.RegistryKey, System.String)
       call      DotNetTips.Spargine.Extensions.RegistryExtensions.GetValue[[System.__Canon, System.Private.CoreLib]](Microsoft.Win32.RegistryKey, System.String)
       mov       r14,rax
       mov       rcx,r14
       call      DotNetTips.Spargine.Extensions.StringExtensions.HasValue(System.String)
       test      eax,eax
       je        near ptr M01_L08
       mov       rcx,offset MT_System.IO.DirectoryInfo
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       dword ptr [r15+28],0FFFFFFFF
       mov       rcx,r14
       call      System.IO.Path.GetFullPath(System.String)
       mov       r8,rax
       mov       dword ptr [rsp+20],1
       mov       rdx,r14
       mov       rcx,r15
       xor       r9d,r9d
       call      System.IO.DirectoryInfo.Init(System.String, System.String, System.String, Boolean)
       lea       rcx,[rbx+10]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,27B8668AFA0
       mov       r8,[r8]
       mov       rdx,[rbp+0FFC0]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.RegistryExtensions.GetValue(Microsoft.Win32.RegistryKey, System.String)
       call      DotNetTips.Spargine.Extensions.RegistryExtensions.GetValue[[System.__Canon, System.Private.CoreLib]](Microsoft.Win32.RegistryKey, System.String)
       test      rax,rax
       je        short M01_L01
       lea       rcx,[rbx+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M01_L01:
       mov       r8,27B8668AFA8
       mov       r8,[r8]
       mov       rdx,[rbp+0FFC0]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.RegistryExtensions.GetValue(Microsoft.Win32.RegistryKey, System.String)
       call      DotNetTips.Spargine.Extensions.RegistryExtensions.GetValue[[System.__Canon, System.Private.CoreLib]](Microsoft.Win32.RegistryKey, System.String)
       mov       r14,rax
       mov       rcx,r14
       call      DotNetTips.Spargine.Extensions.StringExtensions.HasValue(System.String)
       test      eax,eax
       je        short M01_L02
       mov       dword ptr [rbx+20],1
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M01_L04
M01_L02:
       mov       rcx,27B86683020
       mov       r14,[rcx]
       mov       rcx,[rbp+0FFC0]
       cmp       [rcx],ecx
       mov       rcx,[rbp+0FFC0]
       call      Microsoft.Win32.RegistryKey.EnsureNotDisposed()
       mov       rcx,[rbp+0FFC0]
       mov       rdx,r14
       xor       r8d,r8d
       xor       r9d,r9d
       call      Microsoft.Win32.RegistryKey.InternalGetValueCore(System.String, System.Object, Boolean)
       mov       rdx,rax
       test      rdx,rdx
       je        short M01_L03
       mov       rcx,offset MT_System.String
       cmp       [rdx],rcx
       jne       short M01_L05
M01_L03:
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
M01_L04:
       mov       rcx,[rbx+8]
       call      DotNetTips.Spargine.Extensions.StringExtensions.HasValue(System.String)
       test      eax,eax
       je        short M01_L08
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M01_L08
       inc       dword ptr [rsi+14]
       mov       rcx,[rsi+8]
       mov       edx,[rsi+10]
       cmp       [rcx+8],edx
       jbe       short M01_L06
       lea       r8d,[rdx+1]
       mov       [rsi+10],r8d
       mov       r8,rbx
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L08
M01_L05:
       mov       rdx,rax
       call      CORINFO_HELP_CHKCASTCLASS_SPECIAL
       int       3
M01_L06:
       mov       rcx,rsi
       mov       rdx,rbx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M01_L08
M01_L07:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L08:
       cmp       qword ptr [rbp+0FFC0],0
       je        short M01_L09
       mov       rcx,[rbp+0FFC0]
       call      qword ptr [7FFED0B00CF8]
M01_L09:
       add       edi,1
       jo        short M01_L11
M01_L10:
       mov       rcx,[rbp+0FFC8]
       call      Microsoft.Win32.RegistryKey.GetSubKeyNames()
       cmp       [rax+8],edi
       jg        near ptr M01_L00
       jmp       short M01_L12
M01_L11:
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L12:
       mov       rcx,[rbp+0FFC8]
       test      rcx,rcx
       je        short M01_L13
       call      qword ptr [7FFED0B00CF8]
M01_L13:
       mov       rdx,rsi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToImmutableArray(System.Collections.Generic.IList`1<!!0>)
       call      DotNetTips.Spargine.Extensions.ListExtensions.ToImmutableArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       mov       rsi,rax
       mov       rax,[rbp+0FFD0]
       test      rax,rax
       je        short M01_L14
       mov       rcx,rax
       call      qword ptr [7FFED0B00CF8]
M01_L14:
       mov       rax,rsi
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L15:
       mov       rcx,offset MT_System.PlatformNotSupportedException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      System.PlatformNotSupportedException..ctor()
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp+0FFC0],0
       je        short M01_L16
       mov       rcx,[rbp+0FFC0]
       call      qword ptr [7FFED0B00CF8]
M01_L16:
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp+0FFC8],0
       je        short M01_L17
       mov       rcx,[rbp+0FFC8]
       call      qword ptr [7FFED0B00CF8]
M01_L17:
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp+0FFD0],0
       je        short M01_L18
       mov       rcx,[rbp+0FFD0]
       call      qword ptr [7FFED0B00CF8]
M01_L18:
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1030
```
```assembly
; BenchmarkDotNet.Engines.Consumer.ValueTypesConsumer[[System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]](System.Collections.Immutable.ImmutableArray`1<System.__Canon> ByRef)
       ret
; Total bytes of code 1
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.BenchmarkTests.IO.DirectoryHelperBenchmark.SafeDirectorySearch01()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+0B8]
       mov       rdx,1E7A9001B90
       mov       rdx,[rdx]
       xor       r8d,r8d
       call      DotNetTips.Spargine.IO.DirectoryHelper.SafeDirectorySearch(System.IO.DirectoryInfo, System.String, System.IO.SearchOption)
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 61
```
```assembly
; DotNetTips.Spargine.IO.DirectoryHelper.SafeDirectorySearch(System.IO.DirectoryInfo, System.String, System.IO.SearchOption)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,50
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp+0FFD8],rax
       mov       [rbp+0FFC0],rsp
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8d
       mov       r8,1E7C9003020
       mov       r8,[r8]
       mov       r9,1E7D90014F0
       mov       r9,[r9]
       mov       rcx,[rbp+10]
       xor       edx,edx
       call      DotNetTips.Spargine.Core.Validator.ArgumentExists(System.IO.DirectoryInfo, System.IO.DirectoryInfo, System.String, System.String)
       mov       [rbp+10],rax
       mov       rsi,[rbp+18]
       cmp       qword ptr [rbp+18],0
       je        short M01_L00
       cmp       dword ptr [rsi+8],0
       je        short M01_L00
       xor       eax,eax
       jmp       short M01_L01
M01_L00:
       mov       eax,1
M01_L01:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       mov       rdx,1E7A9001B98
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M01_L02:
       cmp       [rsi],esi
       mov       rcx,rsi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       [rbp+18],rax
       mov       esi,[rbp+20]
       mov       rcx,offset MT_System.IO.SearchOption
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,offset MT_System.IO.SearchOption
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rcx,rax
       mov       edx,[rbp+20]
       mov       [rdi+8],edx
       mov       rdx,rdi
       call      System.Enum.IsDefined(System.Type, System.Object)
       test      eax,eax
       jne       short M01_L03
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       rcx,rax
       mov       rdx,1E7A9001BA0
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M01_L03:
       mov       [rbp+20],esi
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.IO.DirectoryInfo, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp+0FFD0],rax
       mov       rcx,7FFED0874928
       mov       edx,28
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rdx,1E7C9002FF8
       mov       rdx,[rdx]
       mov       rax,[rbp+0FFD0]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp+0FFD0]
       inc       dword ptr [rax+14]
       mov       rcx,[rax+8]
       mov       edx,[rax+10]
       cmp       [rcx+8],edx
       jbe       short M01_L04
       lea       r8d,[rdx+1]
       mov       [rbp+0FFD0],rax
       mov       [rax+10],r8d
       mov       r8,[rbp+10]
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L05
M01_L04:
       mov       [rbp+0FFD0],rax
       mov       rcx,rax
       mov       rdx,[rbp+10]
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L05:
       mov       rax,[rbp+0FFD0]
       mov       [rbp+0FFE0],rax
       xor       ecx,ecx
       mov       [rbp+0FFEC],ecx
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       mov       ecx,[rbp+20]
       call      System.IO.EnumerationOptions.FromSearchOption(System.IO.SearchOption)
       mov       r8,rax
       mov       rdx,[rbp+18]
       mov       rcx,[rbp+10]
       call      System.IO.DirectoryInfo.GetDirectories(System.String, System.IO.EnumerationOptions)
       cmp       dword ptr [rax+8],0
       jle       near ptr M01_L10
M01_L06:
       mov       ecx,[rbp+20]
       call      System.IO.EnumerationOptions.FromSearchOption(System.IO.SearchOption)
       mov       r8,rax
       mov       rdx,[rbp+18]
       mov       rcx,[rbp+10]
       call      System.IO.DirectoryInfo.GetDirectories(System.String, System.IO.EnumerationOptions)
       mov       ecx,[rax+8]
       cmp       [rbp+0FFEC],ecx
       jae       short M01_L07
       mov       ecx,[rbp+0FFEC]
       movsxd    rcx,ecx
       mov       rcx,[rax+rcx*8+10]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       call      DotNetTips.Spargine.IO.DirectoryHelper.SafeDirectorySearch(System.IO.DirectoryInfo, System.String, System.IO.SearchOption)
       mov       rsi,rax
       test      rsi,rsi
       je        short M01_L09
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setg      r8b
       movzx     r8d,r8b
       jmp       short M01_L08
M01_L07:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L08:
       test      r8d,r8d
       je        short M01_L09
       mov       r8,rsi
       mov       rdx,[rbp+0FFE0]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange(System.Collections.Generic.ICollection`1<!!0>, System.Collections.Generic.IEnumerable`1<!!0>, DotNetTips.Spargine.Core.Tristate)
       mov       r9d,0FFFFFFFF
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       nop
M01_L09:
       mov       ecx,[rbp+0FFEC]
       add       ecx,1
       jo        short M01_L11
       mov       [rbp+0FFEC],ecx
       mov       ecx,[rbp+20]
       call      System.IO.EnumerationOptions.FromSearchOption(System.IO.SearchOption)
       mov       r8,rax
       mov       rdx,[rbp+18]
       mov       rcx,[rbp+10]
       call      System.IO.DirectoryInfo.GetDirectories(System.String, System.IO.EnumerationOptions)
       mov       eax,[rax+8]
       cmp       eax,[rbp+0FFEC]
       jg        near ptr M01_L06
M01_L10:
       mov       rax,[rbp+0FFE0]
       add       rsp,50
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L11:
       call      CORINFO_HELP_OVERFLOW
       int       3
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rcx,offset MT_System.Exception
       call      CORINFO_HELP_ISINSTANCEOFCLASS
       mov       rdx,rax
       test      rdx,rdx
       jne       short M01_L12
       xor       eax,eax
       jmp       short M01_L15
M01_L12:
       mov       [rbp+0FFD8],rdx
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_ISINSTANCEOFCLASS
       test      rax,rax
       jne       short M01_L13
       mov       rdx,[rbp+0FFD8]
       mov       rcx,offset MT_System.IO.DirectoryNotFoundException
       call      CORINFO_HELP_ISINSTANCEOFCLASS
       test      rax,rax
       jne       short M01_L13
       mov       rdx,[rbp+0FFD8]
       mov       rcx,offset MT_System.UnauthorizedAccessException
       call      CORINFO_HELP_ISINSTANCEOFCLASS
       test      rax,rax
       setne     al
       movzx     eax,al
       jmp       short M01_L14
M01_L13:
       mov       eax,1
M01_L14:
       test      eax,eax
       setne     al
       movzx     eax,al
M01_L15:
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rcx,[rbp+0FFD8]
       mov       rax,[rbp+0FFD8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       call      System.Diagnostics.Trace.WriteLine(System.String)
       lea       rax,[7FFED0AFDE7E]
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 814
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.BenchmarkTests.IO.DirectoryHelperBenchmark.SafeFileSearch01()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+0B8]
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.IO.DirectoryInfo, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1CA97EE2FF8
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rbx+14]
       mov       rcx,[rbx+8]
       mov       edx,[rbx+10]
       cmp       [rcx+8],edx
       jbe       short M00_L00
       lea       r8d,[rdx+1]
       mov       [rbx+10],r8d
       mov       r8,rdi
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M00_L01
M00_L00:
       mov       rcx,rbx
       mov       rdx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M00_L01:
       mov       rdx,1CA87EE2BA8
       mov       rdx,[rdx]
       mov       rcx,rbx
       xor       r8d,r8d
       call      DotNetTips.Spargine.IO.DirectoryHelper.SafeFileSearch(System.Collections.Generic.IEnumerable`1<System.IO.DirectoryInfo>, System.String, System.IO.SearchOption)
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 152
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,rdx
       mov       ebx,[rsi+10]
       lea       ebp,[rbx+1]
       mov       edx,ebp
       mov       rcx,rsi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Grow(Int32)
       mov       [rsi+10],ebp
       mov       rcx,[rsi+8]
       mov       edx,ebx
       mov       r8,rdi
       call      CORINFO_HELP_ARRADDR_ST
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 57
```
```assembly
; DotNetTips.Spargine.IO.DirectoryHelper.SafeFileSearch(System.Collections.Generic.IEnumerable`1<System.IO.DirectoryInfo>, System.String, System.IO.SearchOption)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,rdx
       mov       ebx,r8d
       mov       rcx,offset MT_DotNetTips.Spargine.IO.DirectoryHelper+<>c__DisplayClass9_0
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp+18],ebx
       mov       r9,1CA87EE2BB0
       mov       r9,[r9]
       mov       r8,1CA97EE3020
       mov       r8,[r8]
       mov       rdx,rsi
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentItemsExists(System.Collections.Generic.IEnumerable`1<!!0>, System.String, System.String)
       call      DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.String, System.String)
       mov       rsi,rax
       mov       rdi,[rbp+8]
       test      rdi,rdi
       je        near ptr M02_L03
       cmp       dword ptr [rdi+8],0
       je        near ptr M02_L03
       xor       eax,eax
M02_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       mov       rdx,1CA87EE2BB8
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M02_L01:
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       lea       rcx,[rbp+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       edi,[rbp+18]
       mov       rcx,offset MT_System.IO.SearchOption
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,offset MT_System.IO.SearchOption
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rcx,rax
       mov       [rbx+8],edi
       mov       rdx,rbx
       call      System.Enum.IsDefined(System.Type, System.Object)
       test      eax,eax
       jne       short M02_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       rcx,rax
       mov       rdx,1CA87EE2BC0
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M02_L02:
       mov       [rbp+18],edi
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.IO.FileInfo, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,1CA97EE3000
       mov       rdx,[rdx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbp+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Action`1[[System.IO.DirectoryInfo, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,rsi
       mov       rcx,offset MD_System.Linq.Enumerable.ToList(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rsi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.IO.DirectoryHelper+<>c__DisplayClass9_0.<SafeFileSearch>b__0(System.IO.DirectoryInfo)
       mov       [rdi+18],rcx
       mov       rcx,rsi
       mov       rdx,rdi
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
       mov       rax,[rbp+10]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       eax,1
       jmp       near ptr M02_L00
; Total bytes of code 423
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.BenchmarkTests.IO.DirectoryHelperBenchmark.SetFileAttributesToNormal01()
       mov       rcx,[rcx+0B8]
       jmp       near ptr DotNetTips.Spargine.IO.DirectoryHelper.SetFileAttributesToNormal(System.IO.DirectoryInfo)
; Total bytes of code 12
```
```assembly
; DotNetTips.Spargine.IO.DirectoryHelper.SetFileAttributesToNormal(System.IO.DirectoryInfo)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       r8,1968F541028
       mov       r8,[r8]
       mov       r9,1967F5434E8
       mov       r9,[r9]
       mov       rcx,rsi
       xor       edx,edx
       call      DotNetTips.Spargine.Core.Validator.ArgumentExists(System.IO.DirectoryInfo, System.IO.DirectoryInfo, System.String, System.String)
       mov       rsi,rax
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      System.IO.DirectoryInfo.GetDirectories()
       mov       rdi,rax
       xor       ebx,ebx
       mov       rcx,rsi
       call      System.IO.DirectoryInfo.GetDirectories()
       cmp       dword ptr [rax+8],0
       jle       short M01_L01
       mov       r14d,[rdi+8]
M01_L00:
       cmp       ebx,r14d
       jae       short M01_L05
       movsxd    rcx,ebx
       mov       rcx,[rdi+rcx*8+10]
       call      DotNetTips.Spargine.IO.DirectoryHelper.SetFileAttributesToNormal(System.IO.DirectoryInfo)
       add       ebx,1
       jo        short M01_L04
       mov       rcx,rsi
       call      System.IO.DirectoryInfo.GetDirectories()
       cmp       [rax+8],ebx
       jg        short M01_L00
M01_L01:
       xor       ebp,ebp
       mov       rcx,rsi
       call      System.IO.DirectoryInfo.GetDirectories()
       cmp       dword ptr [rax+8],0
       jle       short M01_L03
       mov       r14d,[rdi+8]
M01_L02:
       cmp       ebp,r14d
       jae       short M01_L05
       movsxd    rcx,ebp
       mov       rcx,[rdi+rcx*8+10]
       mov       rcx,[rcx+8]
       call      System.IO.Path.GetFullPath(System.String)
       mov       rcx,rax
       mov       edx,80
       call      System.IO.FileSystem.SetAttributes(System.String, System.IO.FileAttributes)
       add       ebp,1
       jo        short M01_L04
       mov       rcx,rsi
       call      System.IO.DirectoryInfo.GetDirectories()
       cmp       [rax+8],ebp
       jg        short M01_L02
M01_L03:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L04:
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 217
```
