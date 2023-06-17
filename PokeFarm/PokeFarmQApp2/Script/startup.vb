﻿Imports System.IO
Imports AutoUpdaterDotNET
Imports Microsoft.Web.WebView2.Core

Public Class startup
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

    Public Shared Async Sub preInit()
        'Solution https://stackoverflow.com/a/71699939
        ' by user09938
        Debug.WriteLine("MS Edge Version: " & CoreWebView2Environment.GetAvailableBrowserVersionString())
        Await nav.InitializeCoreWebView2Async(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\TheCrafters001\PFQDA\", System.Reflection.Assembly.GetExecutingAssembly().GetName().Name))
    End Sub
End Class