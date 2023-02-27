<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.webView = New Microsoft.Web.WebView2.WinForms.WebView2()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ShortcutsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BasicToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LabToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PartyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FarmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShelterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MarketToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DaycareToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PokedexToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FarmToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.FarmNewsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InventoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NearbyPlacesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OtherLinksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisplayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NotificationsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BookmarksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TimersBarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ForumToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserscriptsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OthersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NotepadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InteractionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FieldsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WishforgeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuickToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InteractionsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TournamentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EggTimerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HyperModeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShinyHuntingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UberCharmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlbinoHuntingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LuckyEggToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MessagesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ForumToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VisitForumToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ForumSubscriptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.webView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'webView
        '
        Me.webView.AllowExternalDrop = True
        Me.webView.CreationProperties = Nothing
        Me.webView.DefaultBackgroundColor = System.Drawing.Color.Black
        Me.webView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.webView.Location = New System.Drawing.Point(0, 24)
        Me.webView.Name = "webView"
        Me.webView.Size = New System.Drawing.Size(1264, 679)
        Me.webView.Source = New System.Uri("https://pokefarm.com/", System.UriKind.Absolute)
        Me.webView.TabIndex = 0
        Me.webView.ZoomFactor = 1.0R
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShortcutsToolStripMenuItem, Me.QuickToolStripMenuItem, Me.MessagesToolStripMenuItem, Me.ForumToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1264, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ShortcutsToolStripMenuItem
        '
        Me.ShortcutsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BasicToolStripMenuItem, Me.FarmToolStripMenuItem1, Me.FieldsToolStripMenuItem, Me.WishforgeToolStripMenuItem})
        Me.ShortcutsToolStripMenuItem.Image = Global.PokeFarm.My.Resources.Resources.shortcut
        Me.ShortcutsToolStripMenuItem.Name = "ShortcutsToolStripMenuItem"
        Me.ShortcutsToolStripMenuItem.Size = New System.Drawing.Size(85, 20)
        Me.ShortcutsToolStripMenuItem.Text = "Shortcuts"
        '
        'BasicToolStripMenuItem
        '
        Me.BasicToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LabToolStripMenuItem, Me.PartyToolStripMenuItem, Me.FarmToolStripMenuItem, Me.ShelterToolStripMenuItem, Me.MarketToolStripMenuItem, Me.DaycareToolStripMenuItem, Me.PokedexToolStripMenuItem})
        Me.BasicToolStripMenuItem.Image = Global.PokeFarm.My.Resources.Resources.lab
        Me.BasicToolStripMenuItem.Name = "BasicToolStripMenuItem"
        Me.BasicToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.BasicToolStripMenuItem.Text = "Basic"
        '
        'LabToolStripMenuItem
        '
        Me.LabToolStripMenuItem.Image = Global.PokeFarm.My.Resources.Resources.lab
        Me.LabToolStripMenuItem.Name = "LabToolStripMenuItem"
        Me.LabToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.LabToolStripMenuItem.Text = "Lab"
        '
        'PartyToolStripMenuItem
        '
        Me.PartyToolStripMenuItem.Image = Global.PokeFarm.My.Resources.Resources.pokeball
        Me.PartyToolStripMenuItem.Name = "PartyToolStripMenuItem"
        Me.PartyToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.PartyToolStripMenuItem.Text = "Party"
        '
        'FarmToolStripMenuItem
        '
        Me.FarmToolStripMenuItem.Image = Global.PokeFarm.My.Resources.Resources.farm
        Me.FarmToolStripMenuItem.Name = "FarmToolStripMenuItem"
        Me.FarmToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.FarmToolStripMenuItem.Text = "Farm"
        '
        'ShelterToolStripMenuItem
        '
        Me.ShelterToolStripMenuItem.Image = Global.PokeFarm.My.Resources.Resources.shelter
        Me.ShelterToolStripMenuItem.Name = "ShelterToolStripMenuItem"
        Me.ShelterToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.ShelterToolStripMenuItem.Text = "Shelter"
        '
        'MarketToolStripMenuItem
        '
        Me.MarketToolStripMenuItem.Image = Global.PokeFarm.My.Resources.Resources.shop
        Me.MarketToolStripMenuItem.Name = "MarketToolStripMenuItem"
        Me.MarketToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.MarketToolStripMenuItem.Text = "Market"
        '
        'DaycareToolStripMenuItem
        '
        Me.DaycareToolStripMenuItem.Image = Global.PokeFarm.My.Resources.Resources.daycare
        Me.DaycareToolStripMenuItem.Name = "DaycareToolStripMenuItem"
        Me.DaycareToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.DaycareToolStripMenuItem.Text = "Daycare"
        '
        'PokedexToolStripMenuItem
        '
        Me.PokedexToolStripMenuItem.Image = Global.PokeFarm.My.Resources.Resources.dex
        Me.PokedexToolStripMenuItem.Name = "PokedexToolStripMenuItem"
        Me.PokedexToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.PokedexToolStripMenuItem.Text = "Pokédex"
        '
        'FarmToolStripMenuItem1
        '
        Me.FarmToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FarmNewsToolStripMenuItem, Me.InventoryToolStripMenuItem, Me.NearbyPlacesToolStripMenuItem, Me.OtherLinksToolStripMenuItem, Me.OptionsToolStripMenuItem, Me.NotepadToolStripMenuItem, Me.InteractionsToolStripMenuItem})
        Me.FarmToolStripMenuItem1.Image = Global.PokeFarm.My.Resources.Resources.farm
        Me.FarmToolStripMenuItem1.Name = "FarmToolStripMenuItem1"
        Me.FarmToolStripMenuItem1.Size = New System.Drawing.Size(128, 22)
        Me.FarmToolStripMenuItem1.Text = "Farm"
        '
        'FarmNewsToolStripMenuItem
        '
        Me.FarmNewsToolStripMenuItem.Image = Global.PokeFarm.My.Resources.Resources.farm_news
        Me.FarmNewsToolStripMenuItem.Name = "FarmNewsToolStripMenuItem"
        Me.FarmNewsToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.FarmNewsToolStripMenuItem.Text = "Farm News"
        '
        'InventoryToolStripMenuItem
        '
        Me.InventoryToolStripMenuItem.Image = Global.PokeFarm.My.Resources.Resources.inventory
        Me.InventoryToolStripMenuItem.Name = "InventoryToolStripMenuItem"
        Me.InventoryToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.InventoryToolStripMenuItem.Text = "Inventory"
        '
        'NearbyPlacesToolStripMenuItem
        '
        Me.NearbyPlacesToolStripMenuItem.Image = Global.PokeFarm.My.Resources.Resources.places
        Me.NearbyPlacesToolStripMenuItem.Name = "NearbyPlacesToolStripMenuItem"
        Me.NearbyPlacesToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.NearbyPlacesToolStripMenuItem.Text = "Nearby Places"
        '
        'OtherLinksToolStripMenuItem
        '
        Me.OtherLinksToolStripMenuItem.Image = Global.PokeFarm.My.Resources.Resources.links
        Me.OtherLinksToolStripMenuItem.Name = "OtherLinksToolStripMenuItem"
        Me.OtherLinksToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.OtherLinksToolStripMenuItem.Text = "Other Links"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DisplayToolStripMenuItem, Me.NotificationsToolStripMenuItem, Me.BookmarksToolStripMenuItem, Me.TimersBarToolStripMenuItem, Me.ForumToolStripMenuItem1, Me.UserscriptsToolStripMenuItem, Me.OthersToolStripMenuItem})
        Me.OptionsToolStripMenuItem.Image = Global.PokeFarm.My.Resources.Resources.tools_options
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.OptionsToolStripMenuItem.Text = "Options"
        '
        'DisplayToolStripMenuItem
        '
        Me.DisplayToolStripMenuItem.Name = "DisplayToolStripMenuItem"
        Me.DisplayToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.DisplayToolStripMenuItem.Text = "Display"
        '
        'NotificationsToolStripMenuItem
        '
        Me.NotificationsToolStripMenuItem.Name = "NotificationsToolStripMenuItem"
        Me.NotificationsToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.NotificationsToolStripMenuItem.Text = "Notifications"
        '
        'BookmarksToolStripMenuItem
        '
        Me.BookmarksToolStripMenuItem.Name = "BookmarksToolStripMenuItem"
        Me.BookmarksToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.BookmarksToolStripMenuItem.Text = "Bookmarks"
        '
        'TimersBarToolStripMenuItem
        '
        Me.TimersBarToolStripMenuItem.Name = "TimersBarToolStripMenuItem"
        Me.TimersBarToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.TimersBarToolStripMenuItem.Text = "Timers Bar"
        '
        'ForumToolStripMenuItem1
        '
        Me.ForumToolStripMenuItem1.Name = "ForumToolStripMenuItem1"
        Me.ForumToolStripMenuItem1.Size = New System.Drawing.Size(142, 22)
        Me.ForumToolStripMenuItem1.Text = "Forum"
        '
        'UserscriptsToolStripMenuItem
        '
        Me.UserscriptsToolStripMenuItem.Name = "UserscriptsToolStripMenuItem"
        Me.UserscriptsToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.UserscriptsToolStripMenuItem.Text = "Userscripts"
        '
        'OthersToolStripMenuItem
        '
        Me.OthersToolStripMenuItem.Name = "OthersToolStripMenuItem"
        Me.OthersToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.OthersToolStripMenuItem.Text = "Others"
        '
        'NotepadToolStripMenuItem
        '
        Me.NotepadToolStripMenuItem.Image = Global.PokeFarm.My.Resources.Resources.notepad
        Me.NotepadToolStripMenuItem.Name = "NotepadToolStripMenuItem"
        Me.NotepadToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.NotepadToolStripMenuItem.Text = "Notepad"
        '
        'InteractionsToolStripMenuItem
        '
        Me.InteractionsToolStripMenuItem.Image = Global.PokeFarm.My.Resources.Resources.interactions
        Me.InteractionsToolStripMenuItem.Name = "InteractionsToolStripMenuItem"
        Me.InteractionsToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.InteractionsToolStripMenuItem.Text = "Interactions"
        '
        'FieldsToolStripMenuItem
        '
        Me.FieldsToolStripMenuItem.Image = Global.PokeFarm.My.Resources.Resources.places
        Me.FieldsToolStripMenuItem.Name = "FieldsToolStripMenuItem"
        Me.FieldsToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.FieldsToolStripMenuItem.Text = "Fields"
        '
        'WishforgeToolStripMenuItem
        '
        Me.WishforgeToolStripMenuItem.Image = Global.PokeFarm.My.Resources.Resources.shortcut
        Me.WishforgeToolStripMenuItem.Name = "WishforgeToolStripMenuItem"
        Me.WishforgeToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.WishforgeToolStripMenuItem.Text = "Wishforge"
        '
        'QuickToolStripMenuItem
        '
        Me.QuickToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewsToolStripMenuItem, Me.InteractionsToolStripMenuItem1, Me.TournamentToolStripMenuItem, Me.EggTimerToolStripMenuItem, Me.HyperModeToolStripMenuItem, Me.ShinyHuntingToolStripMenuItem, Me.UberCharmToolStripMenuItem, Me.AlbinoHuntingToolStripMenuItem, Me.LuckyEggToolStripMenuItem})
        Me.QuickToolStripMenuItem.Name = "QuickToolStripMenuItem"
        Me.QuickToolStripMenuItem.Size = New System.Drawing.Size(84, 20)
        Me.QuickToolStripMenuItem.Text = "Quick Menu"
        '
        'NewsToolStripMenuItem
        '
        Me.NewsToolStripMenuItem.Image = Global.PokeFarm.My.Resources.Resources.farm_news
        Me.NewsToolStripMenuItem.Name = "NewsToolStripMenuItem"
        Me.NewsToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.NewsToolStripMenuItem.Text = "News"
        '
        'InteractionsToolStripMenuItem1
        '
        Me.InteractionsToolStripMenuItem1.Image = Global.PokeFarm.My.Resources.Resources.interactions
        Me.InteractionsToolStripMenuItem1.Name = "InteractionsToolStripMenuItem1"
        Me.InteractionsToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.InteractionsToolStripMenuItem1.Text = "Interactions"
        '
        'TournamentToolStripMenuItem
        '
        Me.TournamentToolStripMenuItem.Image = Global.PokeFarm.My.Resources.Resources.links
        Me.TournamentToolStripMenuItem.Name = "TournamentToolStripMenuItem"
        Me.TournamentToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.TournamentToolStripMenuItem.Text = "Tournament"
        '
        'EggTimerToolStripMenuItem
        '
        Me.EggTimerToolStripMenuItem.Image = Global.PokeFarm.My.Resources.Resources.lab
        Me.EggTimerToolStripMenuItem.Name = "EggTimerToolStripMenuItem"
        Me.EggTimerToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.EggTimerToolStripMenuItem.Text = "Egg Timer"
        '
        'HyperModeToolStripMenuItem
        '
        Me.HyperModeToolStripMenuItem.Image = Global.PokeFarm.My.Resources.Resources.hypermode_24
        Me.HyperModeToolStripMenuItem.Name = "HyperModeToolStripMenuItem"
        Me.HyperModeToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.HyperModeToolStripMenuItem.Text = "Hyper Mode"
        '
        'ShinyHuntingToolStripMenuItem
        '
        Me.ShinyHuntingToolStripMenuItem.Name = "ShinyHuntingToolStripMenuItem"
        Me.ShinyHuntingToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ShinyHuntingToolStripMenuItem.Text = "Shiny Hunting"
        '
        'UberCharmToolStripMenuItem
        '
        Me.UberCharmToolStripMenuItem.Name = "UberCharmToolStripMenuItem"
        Me.UberCharmToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.UberCharmToolStripMenuItem.Text = "Uber Charm"
        '
        'AlbinoHuntingToolStripMenuItem
        '
        Me.AlbinoHuntingToolStripMenuItem.Name = "AlbinoHuntingToolStripMenuItem"
        Me.AlbinoHuntingToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AlbinoHuntingToolStripMenuItem.Text = "Albino Hunting"
        '
        'LuckyEggToolStripMenuItem
        '
        Me.LuckyEggToolStripMenuItem.Image = Global.PokeFarm.My.Resources.Resources.lab
        Me.LuckyEggToolStripMenuItem.Name = "LuckyEggToolStripMenuItem"
        Me.LuckyEggToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.LuckyEggToolStripMenuItem.Text = "Lucky Egg"
        '
        'MessagesToolStripMenuItem
        '
        Me.MessagesToolStripMenuItem.Name = "MessagesToolStripMenuItem"
        Me.MessagesToolStripMenuItem.Size = New System.Drawing.Size(70, 20)
        Me.MessagesToolStripMenuItem.Text = "Messages"
        '
        'ForumToolStripMenuItem
        '
        Me.ForumToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VisitForumToolStripMenuItem, Me.ForumSubscriptionsToolStripMenuItem})
        Me.ForumToolStripMenuItem.Name = "ForumToolStripMenuItem"
        Me.ForumToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.ForumToolStripMenuItem.Text = "Forum"
        '
        'VisitForumToolStripMenuItem
        '
        Me.VisitForumToolStripMenuItem.Name = "VisitForumToolStripMenuItem"
        Me.VisitForumToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.VisitForumToolStripMenuItem.Text = "Visit Forum"
        '
        'ForumSubscriptionsToolStripMenuItem
        '
        Me.ForumSubscriptionsToolStripMenuItem.Name = "ForumSubscriptionsToolStripMenuItem"
        Me.ForumSubscriptionsToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.ForumSubscriptionsToolStripMenuItem.Text = "Forum Subscriptions"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Image = Global.PokeFarm.My.Resources.Resources.qmark
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1264, 703)
        Me.Controls.Add(Me.webView)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PokeFarm Q"
        CType(Me.webView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents webView As Microsoft.Web.WebView2.WinForms.WebView2
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ShortcutsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BasicToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LabToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PartyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FarmToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ShelterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MarketToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DaycareToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PokedexToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FarmToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents FarmNewsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InventoryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NearbyPlacesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OtherLinksToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NotepadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InteractionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FieldsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WishforgeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MessagesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ForumToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VisitForumToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ForumSubscriptionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DisplayToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NotificationsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BookmarksToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TimersBarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ForumToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents UserscriptsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OthersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuickToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InteractionsToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents TournamentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EggTimerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HyperModeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ShinyHuntingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AlbinoHuntingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LuckyEggToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UberCharmToolStripMenuItem As ToolStripMenuItem
End Class
