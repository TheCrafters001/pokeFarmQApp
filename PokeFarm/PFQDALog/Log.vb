Imports System.IO
Imports System.Reflection.PortableExecutable
Imports System.Text

Public Class Log

    Private Shared LogFile As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\TheCrafters001\PFQDA\logs\" & Date.Now.Day & "-" & Date.Now.Month & "-" & Date.Now.Year & "-Log.txt")
    Private Shared LogFolder As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\TheCrafters001\PFQDA\logs\")

    Public Shared Sub StartNew()

        Dim ifFolderNotExist As Boolean = False

        If Not Directory.Exists(LogFolder) Then
            Directory.CreateDirectory(LogFolder)

            ifFolderNotExist = True
        End If

        Dim LogHeader = {
            "=============================",
            "== PokeFarm Q Desktop App  ==",
            "== " & Date.Now & "   ==",
            "============================="}


        File.AppendAllLines(LogFile, LogHeader, Encoding.UTF8)

        If ifFolderNotExist = True Then
            CreateLog("Created Log Folder")
        End If

#If DEBUG = True Then
        DebugLog.CreateLog("Running in Debug Mode.")
        DebugLog.CreateLog("Expect More Noise.")
#End If

    End Sub


    Public Shared Sub CreateLog(ByVal Text As String)

        Dim logText = {DateAndTime.Now & " - " & Text}

        File.AppendAllLines(LogFile, logText, Encoding.UTF8)

    End Sub

End Class
