
Namespace Configuration

	''' <summary>
	''' 暗号化プロバイダータイプ
	''' </summary>
	''' <remarks></remarks>
	Public Enum ProtectionProviderType As Integer
		DPAPI
		RSA
	End Enum

	''' <summary>
	''' 構成ファイルの暗号化するセクションを指定する属性
	''' </summary>
	''' <remarks></remarks>
	<AttributeUsage(AttributeTargets.Assembly, AllowMultiple:=True)>
	<Serializable()>
	Public Class SectionProtectionAttribute
		Inherits Attribute

		''' <summary>セクション名</summary>
		Private _sectionName As String
		''' <summary>セクション名</summary>
		Public Property SectionName() As String
			Get
				Return _sectionName
			End Get
			Set(ByVal value As String)
				_sectionName = value
			End Set
		End Property

		''' <summary>使用する暗号化プロパイダータイプ</summary>
		Private _provider As ProtectionProviderType
		''' <summary>使用する暗号化プロパイダータイプ</summary>
		Public Property Provider() As ProtectionProviderType
			Get
				Return _provider
			End Get
			Set(ByVal value As ProtectionProviderType)
				_provider = value
			End Set
		End Property

		''' <summary>
		''' コンストラクタ
		''' </summary>
		''' <param name="provider">使用する暗号化プロパイダータイプ</param>
		''' <param name="sectionName">セクション名</param>
		''' <remarks></remarks>
		Public Sub New(ByVal provider As ProtectionProviderType, ByVal sectionName As String)
			Me.Provider = provider
			Me.SectionName = sectionName
		End Sub

	End Class

End Namespace
