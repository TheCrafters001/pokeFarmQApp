Imports System.IO

Public Class Form1
    Private Sub resetCache_btn_Click(sender As Object, e As EventArgs) Handles resetCache_btn.Click
        Dim DiagResult As DialogResult = MessageBox.Show("Are you sure you want to reset the cache?" & vbCrLf & "This cannot be undone.", "Settings", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

        'Check MessageBox
        If DiagResult = DialogResult.Yes Then
            CacheClear(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\TheCrafters001\PFQDA\", System.Reflection.Assembly.GetExecutingAssembly().GetName().Name))

            Try
                Dim cacheReset As New ProcessStartInfo
                cacheReset.FileName = ".\Pokefarm.exe"
                cacheReset.Arguments = ""
                cacheReset.UseShellExecute = True
                cacheReset.WindowStyle = ProcessWindowStyle.Normal
                Dim proc As Process = Process.Start(cacheReset)
                Application.Exit()
            Catch ex As Exception
                MessageBox.Show("Couldn't launch.", "Error")
            End Try
            Application.Exit()
        ElseIf DiagResult = DialogResult.No Then
            ' Do Nothing.
        End If
    End Sub

    Private Sub CacheClear(filePath As String)

        ' Delete Files In Cache
        For Each File As String In Directory.GetFiles(filePath)
            System.IO.File.Delete(File)
            Debug.WriteLine("Deleted: " & filePath)
        Next

        ' Delete all Sub Directories
        For Each Folder In Directory.GetDirectories(filePath)
            CacheClear(Folder)
        Next

        ' Delete Parent
        Directory.Delete(filePath)

    End Sub
End Class
