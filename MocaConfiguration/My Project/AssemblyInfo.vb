Imports System
Imports System.Reflection
Imports System.Runtime.InteropServices

' アセンブリに関する一般情報は以下の属性セットをとおして制御されます。
' アセンブリに関連付けられている情報を変更するには、
' これらの属性値を変更してください。

' アセンブリ属性の値を確認します。

<Assembly: AssemblyDescription("Moca.NET Configuration")>
<Assembly: AssemblyCompany("MiYABiS")>
<Assembly: AssemblyProduct("Moca.NET Framework")>
<Assembly: AssemblyCopyright("© MiYABiS All Rights Reserved.")>
<Assembly: AssemblyTrademark("")>

<Assembly: ComVisible(False)>

'このプロジェクトが COM に公開される場合、次の GUID がタイプ ライブラリの ID になります。
<Assembly: Guid("6d960971-35c0-4b27-ae9a-a7242306b98b")>

' アセンブリのバージョン情報は、以下の 4 つの値で構成されています:
'
'      Major Version
'      Minor Version 
'      Build Number
'      Revision
'
' すべての値を指定するか、下のように '*' を使ってビルドおよびリビジョン番号を 
' 既定値にすることができます:
' <Assembly: AssemblyVersion("1.0.*")> 

' プログラム要素が CLS (Common Language Specification) に準拠しているかどうかを示します
<Assembly: System.CLSCompliant(True)>


<Assembly: AssemblyVersion("5.0.0")>
<Assembly: AssemblyFileVersion("2.0.0")>
<Assembly: AssemblyInformationalVersion("2.0.0")>


#If net20 Then
<Assembly: AssemblyTitle("Moca.NET Configuration .NET 2.0")>
#End If
#If net35 Then
<Assembly: AssemblyTitle("Moca.NET Configuration .NET 3.5")>
#End If
#If net40 Then
<Assembly: AssemblyTitle("Moca.NET Configuration .NET 4.0")>
#End If
#If net45 Then
<Assembly: AssemblyTitle("Moca.NET Configuration .NET 4.5")>
#End If
#If net452 Then
<Assembly: AssemblyTitle("Moca.NET Configuration .NET 4.5.2")>
#End If
#If net46 Then
<Assembly: AssemblyTitle("Moca.NET Configuration .NET 4.6")>
#End If
#If net462 Then
<Assembly: AssemblyTitle("Moca.NET Configuration .NET 4.6.2")>
#End If
#If net47 Then
<Assembly: AssemblyTitle("Moca.NET Configuration .NET 4.7")>
#End If
