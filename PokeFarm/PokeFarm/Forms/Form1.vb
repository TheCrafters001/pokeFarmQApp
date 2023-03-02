﻿Imports System.ComponentModel
Imports System.IO
Imports AutoUpdaterDotNET
Imports Microsoft.Web.WebView2.Core

Public Class Form1
    Private Async Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'This will only run if updates are enabled
        If My.Settings.autoUpdates = True Then
            AutoUpdater.ReportErrors = False
            AutoUpdater.LetUserSelectRemindLater = True
            AutoUpdater.Synchronous = True
            AutoUpdater.DownloadPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\Temp\pokefarm\"
            AutoUpdater.Start("https://github.com/TheCrafters001/pokeFarmQApp/releases/latest/download/update.xml")
        End If

        'Solution https://stackoverflow.com/a/71699939
        ' by user09938
        Debug.WriteLine("MS Edge Version: " & CoreWebView2Environment.GetAvailableBrowserVersionString())
        Await nav.InitializeCoreWebView2Async(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\TheCrafters001\PFQDA\", System.Reflection.Assembly.GetExecutingAssembly().GetName().Name))

        webView.Source = New Uri("https://pokefarm.com")

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

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles About_tsmi.Click
        about.Show()
    End Sub

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        Settings.Show()
    End Sub

    Private Sub MessagesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Messages_tsm.Click
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

    Private Sub Farm_tsmi_Click(sender As Object, e As EventArgs) Handles Farm_tsmi.Click
        nav.web(nav.sc("farm"))
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

    Private Sub NearbyPlaces_tsmi_Click(sender As Object, e As EventArgs) Handles NearbyPlaces_tsmi.Click
        nav.web(nav.sc("farm#tab=3"))
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

    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
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
End Class
