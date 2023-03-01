Public Class pageCheck

    Public Shared Sub Check()

        Dim url As String = Form1.webView.CoreWebView2.Source

        If url = "about:blank" Or url = "https://pokefarm.wiki/" Then

        Else
            ' Split URL
            Dim uri As New Uri(url)

            ' Get the host for the URL
            Dim host As String = uri.Host

            ' Check to see if the page is from PokeFarm.
            If host = "pokefarm.com" Then
                ' Do not do anything

            ElseIf host = "" And url = "about:blank" Then
                ' Do not do anything

            Else
                nav.web("about:blank")

                Dim diagResult As DialogResult
                diagResult = MessageBox.Show("You are trying to visit a page that is not from PokéFarm. Open in Browser?" & vbCrLf & vbCrLf & "URL: " & url, "Hold it!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

                If diagResult = DialogResult.Yes Then

                    Dim NewProcess As Diagnostics.ProcessStartInfo = New Diagnostics.ProcessStartInfo(url)
                    NewProcess.UseShellExecute = True
                    Process.Start(NewProcess)

                    Form1.webView.CoreWebView2.NavigateToString("https://pokefarm.com/")
                ElseIf diagResult = DialogResult.No Then
                    Form1.webView.CoreWebView2.Navigate("https://pokefarm.com/")
                End If

            End If
        End If
    End Sub

End Class
