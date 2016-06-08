
Imports System.Configuration

Namespace Configuration

    ''' <summary>
	''' 構成ファイルを暗号化する為の抽象クラス
    ''' </summary>
    ''' <remarks></remarks>
    Public MustInherit Class ProtectionConfiguration

		''' <summary>使用する暗号化プロバイダー</summary>
        Public MustOverride ReadOnly Property Provider As String

        ''' <summary>使用するapp.configファイル</summary>
        Protected config As System.Configuration.Configuration

#Region " Constructor/DeConstructor "

        ''' <summary>
        ''' デフォルトコンストラクタ
        ''' </summary>
        ''' <remarks>
        ''' 起動中アプリケーションの構成ファイルに対して処理します。
        ''' </remarks>
        Public Sub New()
            Try
                config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)
            Catch ex As ArgumentException
                config = ConfigurationManager.OpenExeConfiguration(String.Empty)
            End Try
        End Sub

        ''' <summary>
        ''' コンストラクタ
        ''' </summary>
        ''' <param name="config">使用するapp.configファイル</param>
        ''' <remarks>app.configファイルを指定する時に使用する。</remarks>
        Public Sub New(ByVal config As System.Configuration.Configuration)
            Me.config = config
        End Sub

#End Region

#Region " ConnectionStrings "

        ''' <summary>
        ''' 接続文字列を暗号化します。
        ''' </summary>
        ''' <remarks>
        ''' アプリケーション構成ファイルの接続文字列セクションに対して暗号化を行います。<br/>
        ''' ただし、下記の場合は暗号化は行いません。<br/>
        ''' ・接続文字列が無い時<br/>
        ''' ・既に暗号化されている時<br/>
        ''' ・ロックされている時<br/>
        ''' </remarks>
        Public Sub ProtectConnectionStrings()
            Dim section As ConfigurationSection = config.ConnectionStrings
            _protectSection(section)
        End Sub

        ''' <summary>
        ''' 接続文字列を複合化します。
        ''' </summary>
        ''' <remarks>
        ''' アプリケーション構成ファイルの接続文字列セクションに対して複合化を行います。<br/>
        ''' ただし、下記の場合は複合化は行いません。<br/>
        ''' ・接続文字列が無い時<br/>
        ''' ・既に暗号化されている時<br/>
        ''' ・ロックされている時<br/>
        ''' </remarks>
        Public Sub UnProtectConnectionStrings()
            Dim section As ConfigurationSection = config.ConnectionStrings
            _unProtectSection(section)
        End Sub

#End Region
#Region " AppSettings "

        ''' <summary>
        ''' AppSettingsを暗号化します。
        ''' </summary>
        ''' <remarks>
        ''' アプリケーション構成ファイルのAppSettingsセクションに対して暗号化を行います。<br/>
        ''' ただし、下記の場合は暗号化は行いません。<br/>
        ''' ・接続文字列が無い時<br/>
        ''' ・既に暗号化されている時<br/>
        ''' ・ロックされている時<br/>
        ''' </remarks>
        Public Sub ProtectAppSettings()
            Dim section As ConfigurationSection = config.AppSettings
            _protectSection(section)
        End Sub

        ''' <summary>
        ''' AppSettingsを複合化します。
        ''' </summary>
        ''' <remarks>
        ''' アプリケーション構成ファイルのAppSettingsセクションに対して複合化を行います。<br/>
        ''' ただし、下記の場合は複合化は行いません。<br/>
        ''' ・接続文字列が無い時<br/>
        ''' ・既に暗号化されている時<br/>
        ''' ・ロックされている時<br/>
        ''' </remarks>
        Public Sub UnProtectAppSettings()
            Dim section As ConfigurationSection = config.AppSettings
            _unProtectSection(section)
        End Sub

#End Region
#Region " 指定したセクション "

        ''' <summary>
        ''' 指定したセクションを暗号化します。
        ''' </summary>
        ''' <remarks>
        ''' アプリケーション構成ファイルの指定したセクションに対して暗号化を行います。<br/>
        ''' ただし、下記の場合は暗号化は行いません。<br/>
        ''' ・接続文字列が無い時<br/>
        ''' ・既に暗号化されている時<br/>
        ''' ・ロックされている時<br/>
        ''' </remarks>
        Public Sub ProtectSection(ByVal sectionName As String)
            Dim section As ConfigurationSection = config.GetSection(sectionName)
            ' 接続文字列が無い時は無視
            If section Is Nothing Then
				Trace.TraceWarning("Can't get the section {0}", sectionName)
                Exit Sub
            End If
            _protectSection(section)
        End Sub

        ''' <summary>
        ''' 指定したセクションを複合化します。
        ''' </summary>
        ''' <remarks>
        ''' アプリケーション構成ファイルの指定したセクションに対して複合化を行います。<br/>
        ''' ただし、下記の場合は複合化は行いません。<br/>
        ''' ・接続文字列が無い時<br/>
        ''' ・既に暗号化されている時<br/>
        ''' ・ロックされている時<br/>
        ''' </remarks>
        Public Sub UnProtectSection(ByVal sectionName As String)
            Dim section As ConfigurationSection = config.GetSection(sectionName)
            ' 接続文字列が無い時は無視
            If section Is Nothing Then
				Trace.TraceWarning("Can't get the section {0}", sectionName)
				Exit Sub
            End If
            _unProtectSection(section)
        End Sub

#End Region

#Region " Methods "

        ''' <summary>
        ''' 暗号化
        ''' </summary>
        ''' <param name="section"></param>
        ''' <remarks></remarks>
        Private Sub _protectSection(ByVal section As ConfigurationSection)
            ' 接続文字列が無い時は無視
            If section Is Nothing Then
                Exit Sub
            End If

            ' 既に暗号化されている時は無視
            If section.SectionInformation.IsProtected Then
				Trace.TraceInformation("Section {0} is already protected by {1}", section.SectionInformation.Name, section.SectionInformation.ProtectionProvider.Name)
				Exit Sub
            End If

            ' ロックされている時は無視
            If section.ElementInformation.IsLocked Then
				Trace.TraceInformation("Can't protect, section {0} is locked", section.SectionInformation.Name)
                Exit Sub
            End If

            ' 暗号化！
            section.SectionInformation.ProtectSection(Me.Provider)
            section.SectionInformation.ForceSave = True
			config.Save(ConfigurationSaveMode.Modified)

			Trace.TraceInformation("Section {0} is now protected by {1}", section.SectionInformation.Name, section.SectionInformation.ProtectionProvider.Name)
        End Sub

        ''' <summary>
        ''' 複合化
        ''' </summary>
        ''' <param name="section"></param>
        ''' <remarks></remarks>
        Private Sub _unProtectSection(ByVal section As ConfigurationSection)
            ' 接続文字列が無い時は無視
            If section Is Nothing Then
				Trace.TraceInformation("Can't get the section {0}", section.SectionInformation.Name)
                Exit Sub
            End If

            ' 既に複合化されている時は無視
            If Not section.SectionInformation.IsProtected Then
				Trace.TraceInformation("Section {0} is already unprotected.", section.SectionInformation.Name)
                Exit Sub
            End If

            ' ロックされている時は無視
            If section.ElementInformation.IsLocked Then
				Trace.TraceInformation("Can't unprotect, section {0} is locked", section.SectionInformation.Name)
                Exit Sub
            End If

            ' 複合化！
            section.SectionInformation.UnprotectSection()
            section.SectionInformation.ForceSave = True
			config.Save(ConfigurationSaveMode.Modified)

			Trace.TraceInformation("Section {0} is now unprotected.", section.SectionInformation.Name)
        End Sub

#End Region

    End Class

End Namespace
