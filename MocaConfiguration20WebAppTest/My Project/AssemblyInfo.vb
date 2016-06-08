Imports System
Imports System.Reflection
Imports System.Runtime.InteropServices

' アセンブリに関する一般情報は、以下の属性セットによって 
' 制御されます。アセンブリに関連付けられている情報を変更するには、
' これらの属性値を変更します。

' アセンブリの属性値を確認します
<Assembly: AssemblyTitle("MocaConfiguration20WebAppTest")>
<Assembly: AssemblyDescription("")>
<Assembly: AssemblyCompany("")>
<Assembly: AssemblyProduct("MocaConfiguration20WebAppTest")>
<Assembly: AssemblyCopyright("Copyright (C)  2016")>
<Assembly: AssemblyTrademark("")>

<Assembly: ComVisible(False)>

'このプロジェクトが COM に公開される場合、次の GUID がタイプ ライブラリの ID になります。
<Assembly: Guid("dda6d98d-63e8-43d4-82fb-6f888009ac47")>

' アセンブリのバージョン情報は、以下の 4 つの値で構成されています:
'
'      メジャー バージョン
'      マイナー バージョン 
'      ビルド番号
'      リビジョン
'
' すべての値を指定するか、下のように '*' を使ってビルドおよびリビジョン番号を 
' 既定値にすることができます:
' <Assembly: AssemblyVersion("1.0.*")> 

<Assembly: AssemblyVersion("1.0.0.0")>
<Assembly: AssemblyFileVersion("1.0.0.0")>


<Assembly: Moca.Configuration.SectionProtection(Moca.Configuration.ProtectionProviderType.DPAPI, "connectionStrings")>
