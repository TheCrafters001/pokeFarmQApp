
Imports System.IO
Imports Microsoft.Web.WebView2.Core
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

    ''' <summary>
    ''' Navigate to a profile.
    ''' </summary>
    ''' <param name="isMe">Navigate to user profile</param>
    ''' <param name="isPkrs">Navigate to user with pokerus</param>
    ''' <param name="name">Navigate to user, if not specified, functions like isMe.</param>
    ''' <returns></returns>
    Public Shared Function profile(ByVal isMe As Boolean, ByVal isPkrs As Boolean, Optional ByVal name As String = "~me")
        Dim output As String

        If isMe = True Then
            output = "https://pokefarm.com/user/~me"
        ElseIf isPkrs = True Then
            output = "https://pokefarm.com/user/~pkrs"
        Else
            output = "https://pokefarm.com/user/" & name
        End If

        Return output
    End Function


    Public Shared Async Function InitializeCoreWebView2Async(Optional userDataFolder As String = "") As Task

        'Solution https://stackoverflow.com/a/71699939
        ' by user09938

        Dim options As CoreWebView2EnvironmentOptions = Nothing
        Dim cwv2Environment As CoreWebView2Environment = Nothing

        'it's recommended to create the userDataFolder in the same location
        'that your other application data is stored (ie: in a folder in %APPDATA%)
        'if not specified, we'll create a folder in %TEMP%
        If String.IsNullOrEmpty(userDataFolder) Then
            userDataFolder = Path.Combine(Path.GetTempPath(), System.Reflection.Assembly.GetExecutingAssembly().GetName().Name)
        End If

        'create WebView2 Environment using the installed or specified WebView2 Runtime version.
        'cwv2Environment = Await CoreWebView2Environment.CreateAsync("C:\Program Files (x86)\Microsoft\Edge Dev\Application\1.0.1054.31", userDataFolder, options)
        cwv2Environment = Await CoreWebView2Environment.CreateAsync(Nothing, userDataFolder, options)

        'initialize
        Await Form1.webView.EnsureCoreWebView2Async(cwv2Environment)
    End Function
End Class
