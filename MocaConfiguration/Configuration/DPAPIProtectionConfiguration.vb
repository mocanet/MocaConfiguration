
Namespace Configuration

	''' <summary>
	''' DataProtectionConfigurationProvider を使った暗号化・複合化をする。
	''' </summary>
	''' <remarks></remarks>
	Public Class DPAPIProtectionConfiguration
		Inherits ProtectionConfiguration

		''' <summary>使用する暗号化プロバイダー</summary>
		Protected Const C_PROVIDER As String = "DataProtectionConfigurationProvider"

		Public Overrides ReadOnly Property Provider As String
			Get
				Return C_PROVIDER
			End Get
		End Property

	End Class

End Namespace
