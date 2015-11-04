# MocaConfiguration


Configuration file Section Protection.

How to get
==========

URL:https://www.nuget.org/packages/Moca.NETConfiguration/
```
PM> Install-Package Moca.NETConfiguration
```


App.config Section Protection setting
==========

C#:Properties\AppConfigTransformAssemblyInfo.cs file Please cancel comment.
```
[Assembly: Moca.Configuration.SectionProtection(Moca.Configuration.ProtectionProviderType.DPAPI, "Section Name")]
```

VB:My Project\AppConfigTransformAssemblyInfo.vb file Please cancel comment.
```
'<Assembly: Moca.Configuration.SectionProtection(Moca.Configuration.ProtectionProviderType.DPAPI, "Section Name")> 
```

Protection Provider Type DPAPI or RSA.

Program Startup execute method.
```
Moca.Configuration.SectionProtector.Protect()
```


License
=======

Microsoft Public License (MS-PL)

http://opensource.org/licenses/MS-PL
