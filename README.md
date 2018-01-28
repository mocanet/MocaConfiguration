# MocaConfiguration

[![Build status](https://ci.appveyor.com/api/projects/status/hukxim3f78gobba1?svg=true)](https://ci.appveyor.com/project/miyabis/mocaconfiguration)
[![NuGet](https://img.shields.io/nuget/v/Moca.NETConfiguration.svg)](https://www.nuget.org/packages/Moca.NETConfiguration/)
[![NuGet Pre Release](https://img.shields.io/nuget/vpre/Moca.NETConfiguration.svg)](https://www.nuget.org/packages/Moca.NETConfiguration/)


Configuration file Section Protection.

How to get
==========

URL:https://www.nuget.org/packages/Moca.NETConfiguration/
```
PM> Install-Package Moca.NETConfiguration
```


App.config Section Protection setting
==========

C#:add Assembly property.
```
[Assembly: Moca.Configuration.SectionProtection(Moca.Configuration.ProtectionProviderType.DPAPI, "Section Name")]
```

VB:add Assembly property.
```
<Assembly: Moca.Configuration.SectionProtection(Moca.Configuration.ProtectionProviderType.DPAPI, "Section Name")> 
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
