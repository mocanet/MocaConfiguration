Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<Assembly: Moca.Configuration.SectionProtection(Moca.Configuration.ProtectionProviderType.DPAPI, "connectionStrings")>
<Assembly: Moca.Configuration.SectionProtection(Moca.Configuration.ProtectionProviderType.DPAPI, "appSettings")>
<Assembly: Moca.Configuration.SectionProtection(Moca.Configuration.ProtectionProviderType.DPAPI, "userSettings")>
<Assembly: Moca.Configuration.SectionProtection(Moca.Configuration.ProtectionProviderType.DPAPI, "MocaConfigurationTest.My.MySettings")>

<TestClass()> Public Class UnitTest1

    <TestMethod()> Public Sub TestMethod1()
        My.Settings.Save()

        Moca.Configuration.SectionProtector.Protect()
    End Sub

    <TestMethod()> Public Sub TestMethod2()
        Moca.Configuration.SectionProtector.UnProtect()
    End Sub

End Class
