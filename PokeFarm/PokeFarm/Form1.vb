Imports Microsoft.Web.WebView2.Core

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'To Do: Turn of context menus
        'webView.CoreWebView2.Settings.AreDefaultContextMenusEnabled = False
    End Sub

    Private Sub webView_NavigationCompleted(sender As Object, e As CoreWebView2NavigationCompletedEventArgs) Handles webView.NavigationCompleted
        ' Run Check to check if we are on pokefarm
        pageCheck.Check()

        ' Display title
        Me.Text = webView.CoreWebView2.DocumentTitle
    End Sub

    Private Sub webView_NavigationStarting(sender As Object, e As CoreWebView2NavigationStartingEventArgs) Handles webView.NavigationStarting
        Me.Text = "Loading..."
    End Sub


#Region "ToolStrip"

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        about.Show()
    End Sub

    Private Sub FarmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FarmToolStripMenuItem.Click
        nav.web(nav.sc("farm"))
    End Sub

    Private Sub FarmToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles FarmToolStripMenuItem1.Click
        nav.web(nav.sc("farm"))
    End Sub

    Private Sub LabToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LabToolStripMenuItem.Click
        nav.web(nav.sc("lab"))
    End Sub

    Private Sub PartyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PartyToolStripMenuItem.Click
        nav.web(nav.sc("party"))
    End Sub

    Private Sub ShelterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShelterToolStripMenuItem.Click
        nav.web(nav.sc("shelter"))
    End Sub

    Private Sub MarketToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MarketToolStripMenuItem.Click
        nav.web(nav.sc("market"))
    End Sub

    Private Sub DaycareToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DaycareToolStripMenuItem.Click
        nav.web(nav.sc("daycare"))
    End Sub

    Private Sub PokedexToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PokedexToolStripMenuItem.Click
        nav.web(nav.sc("pokedex"))
    End Sub

    Private Sub FarmNewsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FarmNewsToolStripMenuItem.Click
        nav.web(nav.sc("farm#tab=1"))
    End Sub

    Private Sub InventoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InventoryToolStripMenuItem.Click
        nav.web(nav.sc("farm#tab=2"))
    End Sub

#End Region


End Class
