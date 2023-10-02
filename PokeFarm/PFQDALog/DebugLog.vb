Imports System.IO
Imports System.Text

Public Class DebugLog


    Private Shared LogFile As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\TheCrafters001\PFQDA\logs\" & Date.Now.Day & "-" & Date.Now.Month & "-" & Date.Now.Year & "-Log.txt")

    Public Shared Sub CreateLog(ByVal Text As String)

        Dim logText = {DateAndTime.Now & " - [DEBUG] - " & Text}

        File.AppendAllLines(LogFile, logText, Encoding.UTF8)

    End Sub

End Class
