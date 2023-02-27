
''' <summary>
''' Navigation Class
''' </summary>
Public Class nav

    ''' <summary>
    ''' Navigate the web!
    ''' </summary>
    ''' <param name="nav">The URL Goes here.</param>
    Public Shared Sub web(ByVal nav As String)
        Form1.webView.CoreWebView2.Navigate(nav)
    End Sub


    ''' <summary>
    ''' A shortcode function. Will navidate to whatever code is.
    ''' </summary>
    ''' <param name="code">The shortcode.</param>
    ''' <returns></returns>
    Public Shared Function sc(ByVal code As String)
        Dim output As String = "https://pokefarm.com/" & code

        Return output
    End Function
End Class
