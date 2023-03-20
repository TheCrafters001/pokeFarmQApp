Imports System.ComponentModel
Imports Microsoft.Web.WebView2.Core

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ' This will eventually get moved to its own class
            navProgress_status.Text = ""

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
        navProgress_status.Text = webView.CoreWebView2.Source
    End Sub

    Private Sub webView_NavigationStarting(sender As Object, e As CoreWebView2NavigationStartingEventArgs) Handles webView.NavigationStarting
        Me.Text = "Loading..."
        navProgress_status.Text = "Loading..."
    End Sub

#Region "ToolStrip"

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles About_tsmi.Click
        about.Show()
    End Sub

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        Settings.Show()
    End Sub

    Private Sub MessagesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Messages_tsm.Click
        nav.web(nav.sc("pm"))
    End Sub

#Region "Users"
    Private Sub userSearch_tsmi_Click(sender As Object, e As EventArgs) Handles userSearch_tsmi.Click
        nav.web(nav.sc("user"))
    End Sub

    Private Sub myUserProfle_tsmi_Click(sender As Object, e As EventArgs) Handles myUserProfle_tsmi.Click
        nav.web(nav.profile(True, False))
    End Sub

    Private Sub pokerus_tsmi_Click(sender As Object, e As EventArgs) Handles pokerus_tsmi.Click
        nav.web(nav.profile(False, True))
    End Sub

#End Region

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


    Private Sub Wishforge_tsm_Click(sender As Object, e As EventArgs) Handles Wishforge_tsm.Click
        nav.web(nav.sc("forge"))
    End Sub


#Region "Basic"
    Private Sub Lab_tsmi_Click(sender As Object, e As EventArgs) Handles Lab_tsmi.Click
        nav.web(nav.sc("lab"))
    End Sub

    Private Sub Party_tsmi_Click(sender As Object, e As EventArgs) Handles Party_tsmi.Click
        nav.web(nav.sc("party"))
    End Sub

    Private Sub Shelter_tsmi_Click(sender As Object, e As EventArgs) Handles Shelter_tsmi.Click
        nav.web(nav.sc("shelter"))
    End Sub

    Private Sub Marketboard_tsmi_Click(sender As Object, e As EventArgs) Handles Marketboard_tsmi.Click
        nav.web(nav.sc("marketboard"))
    End Sub

    Private Sub daycare_tsmi_Click(sender As Object, e As EventArgs) Handles daycare_tsmi.Click
        nav.web(nav.sc("daycare"))
    End Sub

    Private Sub Pokedex_tsmi_Click(sender As Object, e As EventArgs) Handles Pokedex_tsmi.Click
        nav.web(nav.sc("dex"))
    End Sub

#End Region

#Region "farm"

    Private Sub FarmNews_tsmi_Click(sender As Object, e As EventArgs) Handles FarmNews_tsmi.Click
        nav.web(nav.sc("farm#tab=1"))
    End Sub

    Private Sub Inventory_tsmi_Click(sender As Object, e As EventArgs) Handles Inventory_tsmi.Click
        nav.web(nav.sc("farm#tab=2"))
    End Sub

    Private Sub OtherLinks_tsmi_Click(sender As Object, e As EventArgs) Handles OtherLinks_tsmi.Click
        nav.web(nav.sc("farm#tab=4"))
    End Sub

#Region "Options"
    Private Sub optionDisplay_tsmi_Click(sender As Object, e As EventArgs) Handles optionDisplay_tsmi.Click
        nav.web(nav.sc("farm#tab=5.1"))
    End Sub

    Private Sub optionNotif_tsmi_Click(sender As Object, e As EventArgs) Handles optionNotif_tsmi.Click
        nav.web(nav.sc("farm#tab=5.2"))
    End Sub

    Private Sub optionBookmar_tsmi_Click(sender As Object, e As EventArgs) Handles optionBookmar_tsmi.Click
        nav.web(nav.sc("farm#tab=5.3"))
    End Sub

    Private Sub optionTimer_tsmi_Click(sender As Object, e As EventArgs) Handles optionTimer_tsmi.Click
        nav.web(nav.sc("farm#tab=5.4"))
    End Sub

    Private Sub optionFroum_tsmi_Click(sender As Object, e As EventArgs) Handles optionFroum_tsmi.Click
        nav.web(nav.sc("farm#tab=5.5"))
    End Sub

    Private Sub optionUserScri_tsmi_Click(sender As Object, e As EventArgs) Handles optionUserScri_tsmi.Click
        nav.web(nav.sc("farm#tab=5.6"))
    End Sub

    Private Sub optionOthers_tsmi_Click(sender As Object, e As EventArgs) Handles optionOthers_tsmi.Click
        nav.web(nav.sc("farm#tab=5.7"))
    End Sub

#End Region

    Private Sub Notepad_tsmi_Click(sender As Object, e As EventArgs) Handles Notepad_tsmi.Click
        nav.web(nav.sc("farm#tab=6"))
    End Sub

    Private Sub Interactions_tsmi_Click(sender As Object, e As EventArgs) Handles Interactions_tsmi.Click
        nav.web(nav.sc("farm#tab=7"))
    End Sub

#End Region

    Private Sub Fields_tsm_Click(sender As Object, e As EventArgs) Handles Fields_tsm.Click
        nav.web(nav.sc("fields"))
    End Sub

    Private Sub Scour_tsm_Click(sender As Object, e As EventArgs) Handles Scour_tsm.Click
        nav.web(nav.sc("scour"))
    End Sub

    Private Sub SummonsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Summons_tsm.Click
        nav.web(nav.sc("summons"))
    End Sub

#Region "Currency"
    Private Sub Boxes_tsm_Click(sender As Object, e As EventArgs) Handles Boxes_tsm.Click
        nav.web(nav.sc("boxes"))
    End Sub

    Private Sub Credits_tsmu_Click(sender As Object, e As EventArgs) Handles Credits_tsmu.Click
        nav.web(nav.sc("cr"))
    End Sub

    Private Sub Gold_tsmu_Click(sender As Object, e As EventArgs) Handles Gold_tsmu.Click
        nav.web(nav.sc("gp"))
    End Sub

    Private Sub Zophan_tsmu_Click(sender As Object, e As EventArgs) Handles Zophan_tsmu.Click
        nav.web(nav.sc("zc"))
    End Sub

#End Region

#End Region

#Region "Nearby Places"
    Private Sub berry_tsmi_Click(sender As Object, e As EventArgs) Handles berry_tsmi.Click
        nav.web(nav.sc("garden"))
    End Sub

    Private Sub fish_tsmi_Click(sender As Object, e As EventArgs) Handles fish_tsmi.Click
        nav.web(nav.sc("fishing"))
    End Sub

    Private Sub trade_tsmi_Click(sender As Object, e As EventArgs) Handles trade_tsmi.Click
        nav.web(nav.sc("trade"))
    End Sub

    Private Sub egg_tsmi_Click(sender As Object, e As EventArgs) Handles egg_tsmi.Click
        nav.web(nav.sc("supplier"))
    End Sub

    Private Sub contest_tsmi_Click(sender As Object, e As EventArgs) Handles contest_tsmi.Click
        nav.web(nav.sc("contest"))
    End Sub

    Private Sub dojo_tsmi_Click(sender As Object, e As EventArgs) Handles dojo_tsmi.Click
        nav.web(nav.sc("dojo"))
    End Sub

    Private Sub colress_tsmi_Click(sender As Object, e As EventArgs) Handles colress_tsmi.Click
        nav.web(nav.sc("colress"))
    End Sub

    Private Sub pGrove_tsmi_Click(sender As Object, e As EventArgs) Handles pGrove_tsmi.Click
        nav.web(nav.sc("pledgegrove"))
    End Sub

    Private Sub aether_tsmi_Click(sender As Object, e As EventArgs) Handles aether_tsmi.Click
        nav.web(nav.sc("aether"))
    End Sub

    Private Sub research_tsmi_Click(sender As Object, e As EventArgs) Handles research_tsmi.Click
        nav.web(nav.sc("deltahunt"))
    End Sub

    Private Sub cele_tsmi_Click(sender As Object, e As EventArgs) Handles cele_tsmi.Click
        nav.web(nav.sc("cs-shop"))
    End Sub
#End Region

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

    Private Sub Wiki_tsmi_Click(sender As Object, e As EventArgs) Handles Wiki_tsmi.Click
        nav.web("https://pokefarm.wiki/")
    End Sub

#Region "Special"

#Region "MassClick"
    Private Sub WebsiteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MCAWeb_tsmi.Click
        nav.web("https://pfq.eltafez.com/mca")
    End Sub

    Private Sub ForumToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MCAForum_tsmi.Click
        nav.web("https://pfq.link/~LZbR")
    End Sub

    Private Sub ForumToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles SCAForum_tsmi.Click
        nav.web("https://pfq.link/~pb8t")
    End Sub

#End Region

#End Region

#Region "Status"

    Private Sub navProgress_status_Click(sender As Object, e As EventArgs) Handles navProgress_status.Click
        Clipboard.SetText(navProgress_status.Text)

        MessageBox.Show("Copied URL to clipboard", "", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ' show page link
        navProgress_status.Text = webView.CoreWebView2.Source
    End Sub
#End Region

End Class
