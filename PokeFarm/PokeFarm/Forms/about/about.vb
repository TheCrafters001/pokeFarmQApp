Imports Microsoft.Web.WebView2.Core

Public Class about
    Private Sub thirdPartyLicenses_lnk_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles thirdPartyLicenses_lnk.LinkClicked
        thirdParty.Show()
    End Sub

    Private Sub about_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        msEdge_lbl.Text = "MS Edge Version: " & CoreWebView2Environment.GetAvailableBrowserVersionString()
    End Sub
End Class