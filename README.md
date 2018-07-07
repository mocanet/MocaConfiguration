# MocaConfiguration

[![Build status](https://ci.appveyor.com/api/projects/status/hukxim3f78gobba1?svg=true)](https://ci.appveyor.com/project/miyabis/mocaconfiguration)
[![NuGet](https://img.shields.io/nuget/v/Moca.NETConfiguration.svg)](https://www.nuget.org/packages/Moca.NETConfiguration/)
[![NuGet Pre Release](https://img.shields.io/nuget/vpre/Moca.NETConfiguration.svg)](https://www.nuget.org/packages/Moca.NETConfiguration/)
[![NuGet](https://img.shields.io/nuget/dt/Moca.NETConfiguration.svg)](https://www.nuget.org/packages/Moca.NETConfiguration/)
[![license](https://img.shields.io/badge/License-MS--PL-blue.svg)](https://opensource.org/licenses/MS-PL)


## Overview
Configuration file Section Protection.

## Support for multiple frameworks
### Microsoft .NET Framework
* 2.0
* 3.5
* 4.0
* 4.5
* 4.5.2
* 4.6
* 4.6.2
* 4.7

## How to get

URL:https://www.nuget.org/packages/Moca.NETConfiguration/
```
PM> Install-Package Moca.NETConfiguration
```

## App.config Section Protection setting

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


## Other Libraries

[Moca.NET Organization](https://github.com/mocanet)

## Visual Studio Extensions

* [Moca.NET Template Extension](https://marketplace.visualstudio.com/items?itemName=MiYABiS.MocaNETTemplate30)
* [Moca.NET Snippets Extension](https://marketplace.visualstudio.com/items?itemName=MiYABiS.MocaNETCodeSnippet)

## Sample

* Web Form Application  
  * http://miyabis.github.io/Moca.NET-WebAppDemo/  
  * https://code.msdn.microsoft.com/vstudio/MocaNET-Framework-Web-0e8d6dd7

* Windows Form Application  
  * http://miyabis.github.io/Moca.NET-WinAppDemo/  
  * https://code.msdn.microsoft.com/vstudio/MocaNET-Framework-Windows-7174d250

## For Development

* Visual Studio 2017

## License

Microsoft Public License (MS-PL)

http://opensource.org/licenses/MS-PL
