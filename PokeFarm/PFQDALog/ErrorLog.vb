Imports System.IO
Imports System.Reflection.PortableExecutable
Imports System.Text

Public Class ErrorLog

    Private Shared LogFile As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\TheCrafters001\PFQDA\logs\" & Date.Now.Year & "-" & Date.Now.Month & "-" & Date.Now.Day & "-Log.txt")

    Public Shared Sub CreateLog(ByVal Text As String)

        Dim logText = {DateAndTime.Now & " - [ERROR] - " & Text}

        File.AppendAllLines(LogFile, logText, Encoding.UTF8)

    End Sub

End Class
