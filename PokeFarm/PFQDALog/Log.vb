Imports System.IO
Imports System.Reflection.PortableExecutable
Imports System.Text

Public Class Log

    Private Shared LogFile As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\TheCrafters001\PFQDA\logs\" & Date.Now.Year & "-" & Date.Now.Month & "-" & Date.Now.Day & "-Log.txt")
    Private Shared LogFolder As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\TheCrafters001\PFQDA\logs\")             ' Regular Logs
    Private Shared DebugLogFolder As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\TheCrafters001\PFQDA\logs\debug\")  ' Debug Logs

    Public Shared Sub StartNew()

        Dim ifFolderNotExist As Boolean = False

        If Directory.Exists(LogFolder) = False Then
            Directory.CreateDirectory(LogFolder)

            ifFolderNotExist = True
        End If

        ' If the program is in debug mode, it should have its own seperate files.
        ' For my sanity.
#If DEBUG = True Then
        Dim ifDebugFolderNotExist As Boolean = False

        If Directory.Exists(DebugLogFolder) = False Then
            Directory.CreateDirectory(DebugLogFolder)

            ifDebugFolderNotExist = True
        End If
#End If

        Dim LogHeader = {
            "=============================",
            "== PokeFarm Q Desktop App  ==",
            "== " & Date.Now & "   ==",
            "============================="}


        File.AppendAllLines(LogFile, LogHeader, Encoding.UTF8)

        If ifFolderNotExist = True Then
            CreateLog("Created Log Folder")
        End If


        ' Debug Lines.
        ' Again, for my sanity.
#If DEBUG = True Then
        If ifDebugFolderNotExist = True Then
            CreateLog("Created Log Folder")
        End If

        DebugLog.CreateLog("Running in Debug Mode.")
        DebugLog.CreateLog("Expect More Noise.")
#End If

    End Sub


    Public Shared Sub CreateLog(ByVal Text As String)

        Dim logText = {DateAndTime.Now & " - " & Text}

        File.AppendAllLines(LogFile, logText, Encoding.UTF8)

    End Sub

End Class
