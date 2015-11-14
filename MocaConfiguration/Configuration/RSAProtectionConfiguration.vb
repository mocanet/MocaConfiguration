
Namespace Configuration

	''' <summary>
	''' RsaProtectedConfigurationProvider を使った暗号化・複合化をする。
	''' </summary>
	''' <remarks></remarks>
    Public Class RSAProtectionConfiguration
        Inherits ProtectionConfiguration

        ''' <summary>使用するプロパイダー</summary>
        Protected Const C_PROVIDER As String = "RsaProtectedConfigurationProvider"

        Public Overrides ReadOnly Property Provider As String
            Get
                Return C_PROVIDER
            End Get
        End Property
    End Class

End Namespace
