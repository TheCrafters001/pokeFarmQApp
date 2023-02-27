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
#Region "Basic"
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
        nav.web(nav.sc("marketboard"))
    End Sub

    Private Sub DaycareToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DaycareToolStripMenuItem.Click
        nav.web(nav.sc("daycare"))
    End Sub

    Private Sub PokedexToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PokedexToolStripMenuItem.Click
        nav.web(nav.sc("pokedex"))
    End Sub
#End Region

#Region "Farm"
    Private Sub FarmNewsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FarmNewsToolStripMenuItem.Click
        nav.web(nav.sc("farm#tab=1"))
    End Sub

    Private Sub InventoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InventoryToolStripMenuItem.Click
        nav.web(nav.sc("farm#tab=2"))
    End Sub

    Private Sub NearbyPlacesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NearbyPlacesToolStripMenuItem.Click
        nav.web(nav.sc("farm#tab=3"))
    End Sub

    Private Sub OtherLinksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OtherLinksToolStripMenuItem.Click
        nav.web(nav.sc("farm#tab=4"))
    End Sub

    Private Sub OptionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OptionsToolStripMenuItem.Click
        nav.web(nav.sc("farm#tab=5"))
    End Sub

#Region "Options"
    Private Sub DisplayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DisplayToolStripMenuItem.Click
        nav.web(nav.sc("farm#tab=5.1"))
    End Sub

    Private Sub NotificationsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NotificationsToolStripMenuItem.Click
        nav.web(nav.sc("farm#tab=5.2"))
    End Sub

    Private Sub BookmarksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BookmarksToolStripMenuItem.Click
        nav.web(nav.sc("farm#tab=5.3"))
    End Sub

    Private Sub TimersBarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TimersBarToolStripMenuItem.Click
        nav.web(nav.sc("farm#tab=5.4"))
    End Sub

    Private Sub ForumToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ForumToolStripMenuItem1.Click
        nav.web(nav.sc("farm#tab=5.5"))
    End Sub

    Private Sub UserscriptsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UserscriptsToolStripMenuItem.Click
        nav.web(nav.sc("farm#tab=5.6"))
    End Sub

    Private Sub OthersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OthersToolStripMenuItem.Click
        nav.web(nav.sc("farm#tab=5.7"))
    End Sub
#End Region

    Private Sub NotepadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NotepadToolStripMenuItem.Click
        nav.web(nav.sc("farm#tab=6"))
    End Sub

    Private Sub InteractionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InteractionsToolStripMenuItem.Click
        nav.web(nav.sc("farm#tab=7"))
    End Sub

#End Region

    Private Sub FieldsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FieldsToolStripMenuItem.Click
        nav.web(nav.sc("fields"))
    End Sub

    Private Sub WishforgeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WishforgeToolStripMenuItem.Click
        nav.web(nav.sc("forge"))
    End Sub

    Private Sub MessagesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MessagesToolStripMenuItem.Click
        nav.web(nav.sc("pm"))
    End Sub

#Region "Forum"
    Private Sub VisitForumToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VisitForumToolStripMenuItem.Click
        nav.web(nav.sc("forum"))
    End Sub

    Private Sub ForumSubscriptionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ForumSubscriptionsToolStripMenuItem.Click
        nav.web(nav.sc("forum/subs"))
    End Sub

#End Region

#Region "Quick Menu"
    Private Sub NewsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewsToolStripMenuItem.Click
        nav.web(nav.sc("news"))
    End Sub

    Private Sub InteractionsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles InteractionsToolStripMenuItem1.Click
        nav.web(nav.sc("interactions"))
    End Sub

    Private Sub TournamentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TournamentToolStripMenuItem.Click
        nav.web(nav.sc("tournament"))
    End Sub

    Private Sub EggTimerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EggTimerToolStripMenuItem.Click
        nav.web(nav.sc("expboost/eggtimer"))
    End Sub

    Private Sub HyperModeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HyperModeToolStripMenuItem.Click
        nav.web(nav.sc("hypermode"))
    End Sub

    Private Sub ShinyHuntingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShinyHuntingToolStripMenuItem.Click
        nav.web(nav.sc("shinyhunt"))
    End Sub


    Private Sub UberCharmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UberCharmToolStripMenuItem.Click
        nav.web(nav.sc("ubercharm"))
    End Sub

    Private Sub AlbinoHuntingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlbinoHuntingToolStripMenuItem.Click
        nav.web(nav.sc("albinohunt"))
    End Sub

    Private Sub LuckyEggToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LuckyEggToolStripMenuItem.Click
        nav.web(nav.sc("expboost/luckyegg"))
    End Sub
#End Region

#End Region


End Class
