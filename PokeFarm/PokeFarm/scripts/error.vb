Public Class eHandle
    Public Shared Sub ex(ByVal Message As String, Optional ByVal title As String = "Error!")
        ErrorForm.Show()
        ErrorForm.RichTextBox1.Text = Message
        ErrorForm.Text = title
    End Sub
End Class
