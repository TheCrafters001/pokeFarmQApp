Imports System.IO
Imports AutoUpdaterDotNET
Imports Microsoft.Web.WebView2.Core

Public Class startup

    'To Do: Turn of context menus
    'webView.CoreWebView2.Settings.AreDefaultContextMenusEnabled = False

    Public Shared Sub updateCheck()
        'This will only run if updates are enabled
        If My.Settings.autoUpdates = True Then
            AutoUpdater.ReportErrors = False
            AutoUpdater.LetUserSelectRemindLater = True
            AutoUpdater.Synchronous = True
            AutoUpdater.DownloadPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\Temp\pokefarm\"
            AutoUpdater.Start("https://github.com/TheCrafters001/pokeFarmQApp/releases/latest/download/update.xml")
        End If
    End Sub

    Public Shared Sub menuBar(ByVal pos As Integer)
        If pos = 0 Then
            Form1.MenuStrip1.Dock = DockStyle.Top
        ElseIf pos = 1 Then
            Form1.MenuStrip1.Dock = DockStyle.Left
        ElseIf pos = 2 Then
            Form1.MenuStrip1.Dock = DockStyle.Right
        ElseIf pos = 3 Then
            Form1.MenuStrip1.Dock = DockStyle.Bottom
        Else ' Fallback
            Form1.MenuStrip1.Dock = DockStyle.Top
        End If
    End Sub

    Public Shared Async Sub preInit()
        'Solution https://stackoverflow.com/a/71699939
        ' by user09938
        Debug.WriteLine("MS Edge Version: " & CoreWebView2Environment.GetAvailableBrowserVersionString())
        Await nav.InitializeCoreWebView2Async(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\TheCrafters001\PFQDA\", System.Reflection.Assembly.GetExecutingAssembly().GetName().Name))

        ' Check for Status Bar Setting
        If My.Settings.statusBarStatus = False Then
            Form1.StatusStrip1.Dispose()
        End If

    End Sub

    Public Shared Sub postInit()
        Form1.webView.Source = New Uri("https://pokefarm.com")
    End Sub


End Class
