Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<Assembly: Moca.Configuration.SectionProtection(Moca.Configuration.ProtectionProviderType.DPAPI, "ConnectionStrings")> 
<Assembly: Moca.Configuration.SectionProtection(Moca.Configuration.ProtectionProviderType.DPAPI, "appSettings")> 

<TestClass()> Public Class UnitTest1

    <TestMethod()> Public Sub TestMethod1()
		Moca.Configuration.SectionProtector.Protect()
    End Sub

End Class
