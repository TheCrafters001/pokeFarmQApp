Imports System.IO
Imports System.Text

Public Class pageCheck

    Public Shared Sub Check()

        Dim url As String = Form1.webView.CoreWebView2.Source

        If url = "about:blank" Then

        Else

            ' Split URL
            Dim uri As New Uri(url)

            ' Get the host for the URL
            Dim host As String = uri.Host

            ' Check if trusted domain file exists
            TrustedDomainCheck()

            ' Create an array with all files from %APPDATA%\TheCrafters001\PFQDA\trusted-domains.txt
            Dim domains As Array = File.ReadAllLines(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\TheCrafters001\PFQDA\trusted-domains.txt"), Encoding.UTF8)

            ' Create Boolean
            Dim isAlreadyTrusted As Boolean = False

            ' Trusted Domain Check
            For Each i As String In domains

                If i = host Then
                    Debug.WriteLine("Trusted: " & i & " matches: " & host)

                    If isAlreadyTrusted = True Then
                        ' Do Nothing 
                    Else
                        isAlreadyTrusted = True
                    End If

                Else
                    Debug.WriteLine("Not Trusted: " & i & " doesnt match: " & host)

                    If isAlreadyTrusted = True Then
                        ' Do Nothing 
                    Else
                        isAlreadyTrusted = False
                    End If

                End If
            Next

            If isAlreadyTrusted = True Then

                ' Do Nothing.

            ElseIf isAlreadyTrusted = False Then
                nav.web("about:blank")

                Dim diagResult As DialogResult
                diagResult = MessageBox.Show("You are trying to visit a page that is not from PokéFarm. Open in Browser?" &
                                             vbCrLf & vbCrLf &
                                             "URL: " & url,
                                             "Hold it!", MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Warning)

                If diagResult = DialogResult.Yes Then
                    Try
                        Dim NewProcess As Diagnostics.ProcessStartInfo =
                            New Diagnostics.ProcessStartInfo(url)

                        NewProcess.UseShellExecute = True

                        Process.Start(NewProcess)
                    Catch ex As Exception
                        eHandle.ex(ex.Message)
                    End Try

                    nav.web("https://pokefarm.com/")
                ElseIf diagResult = DialogResult.No Then
                    nav.web("https://pokefarm.com/")
                End If
            End If

        End If
    End Sub

    Public Shared Sub TrustedDomainCheck()
        Try

            Dim filePath As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\TheCrafters001\PFQDA\trusted-domains.txt")

            If File.Exists(filePath) = True Then
                Debug.WriteLine("Trusted Doamins List Exists")
            Else
                Dim pokeFarmTrusted() As String = {"pokefarm.com", "pokefarm.wiki", "pfq.link", "checkout.stripe.com", "stripe.com", "pfq.eltafez.com", "about:blank"}

                Debug.WriteLine("Creating Trusted Domain List")

                File.WriteAllLines(filePath, pokeFarmTrusted, Encoding.UTF8)
                TrustedDomainCheck()
            End If
        Catch ex As Exception
            eHandle.ex(ex.Message, "Trusted Domain Error")
        End Try
    End Sub

End Class
