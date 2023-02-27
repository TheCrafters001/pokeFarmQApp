Imports Microsoft.Web.WebView2.Core

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub webView_NavigationCompleted(sender As Object, e As CoreWebView2NavigationCompletedEventArgs) Handles webView.NavigationCompleted
        pageCheck.Check()


        Me.Text = webView.CoreWebView2.DocumentTitle
    End Sub

    Private Sub webView_NavigationStarting(sender As Object, e As CoreWebView2NavigationStartingEventArgs) Handles webView.NavigationStarting
        Me.Text = "Loading..."

    End Sub
End Class
