
Imports System.Reflection

Namespace Configuration

	''' <summary>
	''' 構成ファイルのセクションを暗号化・複合化する
	''' </summary>
	''' <remarks></remarks>
	Public Class SectionProtector

		''' <summary>オブジェクト参照に評価される式</summary>
		Private Shared _lock As New Object

		''' <summary>
		''' 暗号化する
		''' </summary>
		''' <remarks></remarks>
		Public Shared Sub Protect()
			SyncLock _lock
				Dim attributes() As SectionProtectionAttribute
                attributes = _getAttributes()

                For Each attr As SectionProtectionAttribute In attributes
					Dim protection As ProtectionConfiguration = _getProtectionConfiguration(attr)
					If protection Is Nothing Then
						Continue For
					End If
					protection.ProtectSection(attr.SectionName)
				Next
			End SyncLock
		End Sub

		''' <summary>
		''' 複合化する
		''' </summary>
		''' <remarks></remarks>
		Public Shared Sub UnProtect()
			SyncLock _lock
				Dim attributes() As SectionProtectionAttribute
                attributes = _getAttributes()

                For Each attr As SectionProtectionAttribute In attributes
					Dim protection As ProtectionConfiguration = _getProtectionConfiguration(attr)
					If protection Is Nothing Then
						Continue For
					End If
					protection.UnProtectSection(attr.SectionName)
				Next
			End SyncLock
		End Sub

        Private Shared Function _getAttributes() As SectionProtectionAttribute()
            Dim lst As New List(Of SectionProtectionAttribute)
            For Each assm As Assembly In AppDomain.CurrentDomain.GetAssemblies()
                lst.AddRange(_getAttributes(assm))
            Next
            Return lst.ToArray
        End Function

        ''' <summary>
        ''' 呼び元アセンブリの <see cref="SectionProtectionAttribute"></see> 属性を取得する
        ''' </summary>
        ''' <param name="callingAssembly"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Private Shared Function _getAttributes(ByVal callingAssembly As Assembly) As SectionProtectionAttribute()
			Return callingAssembly.GetCustomAttributes(GetType(SectionProtectionAttribute), True)
		End Function

		''' <summary>
		''' 属性で指定された暗号化プロパイダーを取得する
		''' </summary>
		''' <param name="attr"></param>
		''' <returns></returns>
		''' <remarks></remarks>
		Private Shared Function _getProtectionConfiguration(ByVal attr As SectionProtectionAttribute) As ProtectionConfiguration
			Select Case attr.Provider
				Case ProtectionProviderType.DPAPI
					Return New DPAPIProtectionConfiguration()
				Case ProtectionProviderType.RSA
					Return New RSAProtectionConfiguration()
				Case Else
					Return Nothing
			End Select
		End Function

	End Class

End Namespace
