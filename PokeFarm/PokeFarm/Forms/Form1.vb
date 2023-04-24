Imports System.ComponentModel
Imports Microsoft.Web.WebView2.Core

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ' nav.updateStatus("")

            startup.updateCheck()
            startup.preInit()
            startup.menuBar(My.Settings.menuBarPos)
            startup.postInit()
        Catch ex As Exception
            eHandle.ex(ex.Message, "Startup Error")
        End Try
    End Sub

    Private Sub webView_NavigationCompleted(sender As Object, e As CoreWebView2NavigationCompletedEventArgs) Handles webView.NavigationCompleted

        ' Run Check to check if we are on pokefarm
        pageCheck.Check()

        ' Solution: https://stackoverflow.com/a/27145407
        ' By Aliaksandr Hmyrak
        webView.CoreWebView2.ExecuteScriptAsync("(function()
                {
                    var hyperlinks = document.getElementsByTagName('a');
                    for(var i = 0; i < hyperlinks.length; i++)
                    {
                        if(hyperlinks[i].getAttribute('target') != null)
                        {
                            hyperlinks[i].setAttribute('target', '_self');
                        }
                    }
                })()")

        ' Display title
        Me.Text = webView.CoreWebView2.DocumentTitle

        ' Also show page link
        nav.updateStatus(webView.CoreWebView2.Source)
    End Sub

    Private Sub webView_NavigationStarting(sender As Object, e As CoreWebView2NavigationStartingEventArgs) Handles webView.NavigationStarting
        Me.Text = "Loading..."
        ' nav.updateStatus("Loading...")
    End Sub


#Region "Tray Icon"

    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        Me.Show()
        Me.WindowState = FormWindowState.Normal
        NotifyIcon1.Visible = False
        Me.TopMost = True
        Me.TopMost = False
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        Me.Show()
        Me.WindowState = FormWindowState.Normal
        NotifyIcon1.Visible = False
        Me.TopMost = True
        Me.TopMost = False
    End Sub

    Private Sub QuitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitToolStripMenuItem.Click
        Application.Exit()
    End Sub

#End Region

    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles MyBase.Closing
        If My.Settings.runInBackground = True Then
            e.Cancel = True
            NotifyIcon1.Visible = True
            Me.Hide()
            NotifyIcon1.BalloonTipText = "Want to re-open? Click the icon in the system try!"
            NotifyIcon1.BalloonTipTitle = "PokéFarm Q Desktop App"
            NotifyIcon1.ShowBalloonTip(500)
        End If
    End Sub

End Class
