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
        Me.Basic_tsm = New System.Windows.Forms.ToolStripMenuItem()
        Me.Lab_tsmi = New System.Windows.Forms.ToolStripMenuItem()
        Me.Party_tsmi = New System.Windows.Forms.ToolStripMenuItem()
        Me.Farm_tsmi = New System.Windows.Forms.ToolStripMenuItem()
        Me.Shelter_tsmi = New System.Windows.Forms.ToolStripMenuItem()
        Me.Marketboard_tsmi = New System.Windows.Forms.ToolStripMenuItem()
        Me.daycare_tsmi = New System.Windows.Forms.ToolStripMenuItem()
        Me.Pokedex_tsmi = New System.Windows.Forms.ToolStripMenuItem()
        Me.Farm_tsm = New System.Windows.Forms.ToolStripMenuItem()
        Me.FarmNews_tsmi = New System.Windows.Forms.ToolStripMenuItem()
        Me.Inventory_tsmi = New System.Windows.Forms.ToolStripMenuItem()
        Me.NearbyPlaces_tsmi = New System.Windows.Forms.ToolStripMenuItem()
        Me.OtherLinks_tsmi = New System.Windows.Forms.ToolStripMenuItem()
        Me.Options_tsmi = New System.Windows.Forms.ToolStripMenuItem()
        Me.optionDisplay_tsmi = New System.Windows.Forms.ToolStripMenuItem()
        Me.optionNotif_tsmi = New System.Windows.Forms.ToolStripMenuItem()
        Me.optionBookmar_tsmi = New System.Windows.Forms.ToolStripMenuItem()
        Me.optionTimer_tsmi = New System.Windows.Forms.ToolStripMenuItem()
        Me.optionFroum_tsmi = New System.Windows.Forms.ToolStripMenuItem()
        Me.optionUserScri_tsmi = New System.Windows.Forms.ToolStripMenuItem()
        Me.optionOthers_tsmi = New System.Windows.Forms.ToolStripMenuItem()
        Me.Notepad_tsmi = New System.Windows.Forms.ToolStripMenuItem()
        Me.Interactions_tsmi = New System.Windows.Forms.ToolStripMenuItem()
        Me.Fields_tsm = New System.Windows.Forms.ToolStripMenuItem()
        Me.Scour_tsm = New System.Windows.Forms.ToolStripMenuItem()
        Me.Wishforge_tsm = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuickTools_tsm = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InteractionsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TournamentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EggTimerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HyperModeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShinyHuntingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UberCharmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlbinoHuntingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LuckyEggToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Messages_tsm = New System.Windows.Forms.ToolStripMenuItem()
        Me.Forum_tsm = New System.Windows.Forms.ToolStripMenuItem()
        Me.VisitForumToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ForumSubscriptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Help_tsm = New System.Windows.Forms.ToolStripMenuItem()
        Me.About_tsmi = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Basic_tsm, Me.Farm_tsm, Me.Fields_tsm, Me.Scour_tsm, Me.Wishforge_tsm, Me.QuickTools_tsm, Me.Messages_tsm, Me.Forum_tsm, Me.Help_tsm})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1264, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Basic_tsm
        '
        Me.Basic_tsm.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Lab_tsmi, Me.Party_tsmi, Me.Farm_tsmi, Me.Shelter_tsmi, Me.Marketboard_tsmi, Me.daycare_tsmi, Me.Pokedex_tsmi})
        Me.Basic_tsm.Image = Global.PokeFarm.My.Resources.Resources.lab
        Me.Basic_tsm.Name = "Basic_tsm"
        Me.Basic_tsm.Size = New System.Drawing.Size(62, 20)
        Me.Basic_tsm.Text = "Basic"
        '
        'Lab_tsmi
        '
        Me.Lab_tsmi.Image = Global.PokeFarm.My.Resources.Resources.lab
        Me.Lab_tsmi.Name = "Lab_tsmi"
        Me.Lab_tsmi.Size = New System.Drawing.Size(119, 22)
        Me.Lab_tsmi.Text = "Lab"
        '
        'Party_tsmi
        '
        Me.Party_tsmi.Image = Global.PokeFarm.My.Resources.Resources.pokeball
        Me.Party_tsmi.Name = "Party_tsmi"
        Me.Party_tsmi.Size = New System.Drawing.Size(119, 22)
        Me.Party_tsmi.Text = "Party"
        '
        'Farm_tsmi
        '
        Me.Farm_tsmi.Image = Global.PokeFarm.My.Resources.Resources.farm
        Me.Farm_tsmi.Name = "Farm_tsmi"
        Me.Farm_tsmi.Size = New System.Drawing.Size(119, 22)
        Me.Farm_tsmi.Text = "Farm"
        '
        'Shelter_tsmi
        '
        Me.Shelter_tsmi.Image = Global.PokeFarm.My.Resources.Resources.shelter
        Me.Shelter_tsmi.Name = "Shelter_tsmi"
        Me.Shelter_tsmi.Size = New System.Drawing.Size(119, 22)
        Me.Shelter_tsmi.Text = "Shelter"
        '
        'Marketboard_tsmi
        '
        Me.Marketboard_tsmi.Image = Global.PokeFarm.My.Resources.Resources.shop
        Me.Marketboard_tsmi.Name = "Marketboard_tsmi"
        Me.Marketboard_tsmi.Size = New System.Drawing.Size(119, 22)
        Me.Marketboard_tsmi.Text = "Market"
        '
        'daycare_tsmi
        '
        Me.daycare_tsmi.Image = Global.PokeFarm.My.Resources.Resources.daycare
        Me.daycare_tsmi.Name = "daycare_tsmi"
        Me.daycare_tsmi.Size = New System.Drawing.Size(119, 22)
        Me.daycare_tsmi.Text = "Daycare"
        '
        'Pokedex_tsmi
        '
        Me.Pokedex_tsmi.Image = Global.PokeFarm.My.Resources.Resources.dex
        Me.Pokedex_tsmi.Name = "Pokedex_tsmi"
        Me.Pokedex_tsmi.Size = New System.Drawing.Size(119, 22)
        Me.Pokedex_tsmi.Text = "Pokédex"
        '
        'Farm_tsm
        '
        Me.Farm_tsm.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FarmNews_tsmi, Me.Inventory_tsmi, Me.NearbyPlaces_tsmi, Me.OtherLinks_tsmi, Me.Options_tsmi, Me.Notepad_tsmi, Me.Interactions_tsmi})
        Me.Farm_tsm.Image = Global.PokeFarm.My.Resources.Resources.farm
        Me.Farm_tsm.Name = "Farm_tsm"
        Me.Farm_tsm.Size = New System.Drawing.Size(62, 20)
        Me.Farm_tsm.Text = "Farm"
        '
        'FarmNews_tsmi
        '
        Me.FarmNews_tsmi.Image = Global.PokeFarm.My.Resources.Resources.farm_news
        Me.FarmNews_tsmi.Name = "FarmNews_tsmi"
        Me.FarmNews_tsmi.Size = New System.Drawing.Size(180, 22)
        Me.FarmNews_tsmi.Text = "Farm News"
        '
        'Inventory_tsmi
        '
        Me.Inventory_tsmi.Image = Global.PokeFarm.My.Resources.Resources.inventory
        Me.Inventory_tsmi.Name = "Inventory_tsmi"
        Me.Inventory_tsmi.Size = New System.Drawing.Size(180, 22)
        Me.Inventory_tsmi.Text = "Inventory"
        '
        'NearbyPlaces_tsmi
        '
        Me.NearbyPlaces_tsmi.Image = Global.PokeFarm.My.Resources.Resources.places
        Me.NearbyPlaces_tsmi.Name = "NearbyPlaces_tsmi"
        Me.NearbyPlaces_tsmi.Size = New System.Drawing.Size(180, 22)
        Me.NearbyPlaces_tsmi.Text = "Nearby Places"
        '
        'OtherLinks_tsmi
        '
        Me.OtherLinks_tsmi.Image = Global.PokeFarm.My.Resources.Resources.links
        Me.OtherLinks_tsmi.Name = "OtherLinks_tsmi"
        Me.OtherLinks_tsmi.Size = New System.Drawing.Size(180, 22)
        Me.OtherLinks_tsmi.Text = "Other Links"
        '
        'Options_tsmi
        '
        Me.Options_tsmi.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.optionDisplay_tsmi, Me.optionNotif_tsmi, Me.optionBookmar_tsmi, Me.optionTimer_tsmi, Me.optionFroum_tsmi, Me.optionUserScri_tsmi, Me.optionOthers_tsmi})
        Me.Options_tsmi.Image = Global.PokeFarm.My.Resources.Resources.tools_options
        Me.Options_tsmi.Name = "Options_tsmi"
        Me.Options_tsmi.Size = New System.Drawing.Size(180, 22)
        Me.Options_tsmi.Text = "Options"
        '
        'optionDisplay_tsmi
        '
        Me.optionDisplay_tsmi.Image = Global.PokeFarm.My.Resources.Resources.tools_options
        Me.optionDisplay_tsmi.Name = "optionDisplay_tsmi"
        Me.optionDisplay_tsmi.Size = New System.Drawing.Size(180, 22)
        Me.optionDisplay_tsmi.Text = "Display"
        '
        'optionNotif_tsmi
        '
        Me.optionNotif_tsmi.Image = Global.PokeFarm.My.Resources.Resources.tools_options
        Me.optionNotif_tsmi.Name = "optionNotif_tsmi"
        Me.optionNotif_tsmi.Size = New System.Drawing.Size(180, 22)
        Me.optionNotif_tsmi.Text = "Notifications"
        '
        'optionBookmar_tsmi
        '
        Me.optionBookmar_tsmi.Image = Global.PokeFarm.My.Resources.Resources.tools_options
        Me.optionBookmar_tsmi.Name = "optionBookmar_tsmi"
        Me.optionBookmar_tsmi.Size = New System.Drawing.Size(180, 22)
        Me.optionBookmar_tsmi.Text = "Bookmarks"
        '
        'optionTimer_tsmi
        '
        Me.optionTimer_tsmi.Image = Global.PokeFarm.My.Resources.Resources.tools_options
        Me.optionTimer_tsmi.Name = "optionTimer_tsmi"
        Me.optionTimer_tsmi.Size = New System.Drawing.Size(180, 22)
        Me.optionTimer_tsmi.Text = "Timers Bar"
        '
        'optionFroum_tsmi
        '
        Me.optionFroum_tsmi.Image = Global.PokeFarm.My.Resources.Resources.tools_options
        Me.optionFroum_tsmi.Name = "optionFroum_tsmi"
        Me.optionFroum_tsmi.Size = New System.Drawing.Size(180, 22)
        Me.optionFroum_tsmi.Text = "Forum"
        '
        'optionUserScri_tsmi
        '
        Me.optionUserScri_tsmi.Image = Global.PokeFarm.My.Resources.Resources.tools_options
        Me.optionUserScri_tsmi.Name = "optionUserScri_tsmi"
        Me.optionUserScri_tsmi.Size = New System.Drawing.Size(180, 22)
        Me.optionUserScri_tsmi.Text = "User Scripts"
        '
        'optionOthers_tsmi
        '
        Me.optionOthers_tsmi.Image = Global.PokeFarm.My.Resources.Resources.tools_options
        Me.optionOthers_tsmi.Name = "optionOthers_tsmi"
        Me.optionOthers_tsmi.Size = New System.Drawing.Size(180, 22)
        Me.optionOthers_tsmi.Text = "Others"
        '
        'Notepad_tsmi
        '
        Me.Notepad_tsmi.Image = Global.PokeFarm.My.Resources.Resources.notepad
        Me.Notepad_tsmi.Name = "Notepad_tsmi"
        Me.Notepad_tsmi.Size = New System.Drawing.Size(180, 22)
        Me.Notepad_tsmi.Text = "Notepad"
        '
        'Interactions_tsmi
        '
        Me.Interactions_tsmi.Image = Global.PokeFarm.My.Resources.Resources.interactions
        Me.Interactions_tsmi.Name = "Interactions_tsmi"
        Me.Interactions_tsmi.Size = New System.Drawing.Size(180, 22)
        Me.Interactions_tsmi.Text = "Interactions"
        '
        'Fields_tsm
        '
        Me.Fields_tsm.Image = Global.PokeFarm.My.Resources.Resources.places
        Me.Fields_tsm.Name = "Fields_tsm"
        Me.Fields_tsm.Size = New System.Drawing.Size(65, 20)
        Me.Fields_tsm.Text = "Fields"
        '
        'Scour_tsm
        '
        Me.Scour_tsm.Image = Global.PokeFarm.My.Resources.Resources.places
        Me.Scour_tsm.Name = "Scour_tsm"
        Me.Scour_tsm.Size = New System.Drawing.Size(114, 20)
        Me.Scour_tsm.Text = "Scour Missions"
        '
        'Wishforge_tsm
        '
        Me.Wishforge_tsm.Image = Global.PokeFarm.My.Resources.Resources.gem_normal
        Me.Wishforge_tsm.Name = "Wishforge_tsm"
        Me.Wishforge_tsm.Size = New System.Drawing.Size(89, 20)
        Me.Wishforge_tsm.Text = "Wishforge"
        '
        'QuickTools_tsm
        '
        Me.QuickTools_tsm.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewsToolStripMenuItem, Me.InteractionsToolStripMenuItem1, Me.TournamentToolStripMenuItem, Me.EggTimerToolStripMenuItem, Me.HyperModeToolStripMenuItem, Me.ShinyHuntingToolStripMenuItem, Me.UberCharmToolStripMenuItem, Me.AlbinoHuntingToolStripMenuItem, Me.LuckyEggToolStripMenuItem})
        Me.QuickTools_tsm.Name = "QuickTools_tsm"
        Me.QuickTools_tsm.Size = New System.Drawing.Size(84, 20)
        Me.QuickTools_tsm.Text = "Quick Menu"
        '
        'NewsToolStripMenuItem
        '
        Me.NewsToolStripMenuItem.Image = Global.PokeFarm.My.Resources.Resources.farm_news
        Me.NewsToolStripMenuItem.Name = "NewsToolStripMenuItem"
        Me.NewsToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.NewsToolStripMenuItem.Text = "News"
        '
        'InteractionsToolStripMenuItem1
        '
        Me.InteractionsToolStripMenuItem1.Image = Global.PokeFarm.My.Resources.Resources.interactions
        Me.InteractionsToolStripMenuItem1.Name = "InteractionsToolStripMenuItem1"
        Me.InteractionsToolStripMenuItem1.Size = New System.Drawing.Size(156, 22)
        Me.InteractionsToolStripMenuItem1.Text = "Interactions"
        '
        'TournamentToolStripMenuItem
        '
        Me.TournamentToolStripMenuItem.Image = Global.PokeFarm.My.Resources.Resources.links
        Me.TournamentToolStripMenuItem.Name = "TournamentToolStripMenuItem"
        Me.TournamentToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.TournamentToolStripMenuItem.Text = "Tournament"
        '
        'EggTimerToolStripMenuItem
        '
        Me.EggTimerToolStripMenuItem.Image = Global.PokeFarm.My.Resources.Resources.lab
        Me.EggTimerToolStripMenuItem.Name = "EggTimerToolStripMenuItem"
        Me.EggTimerToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.EggTimerToolStripMenuItem.Text = "Egg Timer"
        '
        'HyperModeToolStripMenuItem
        '
        Me.HyperModeToolStripMenuItem.Image = Global.PokeFarm.My.Resources.Resources.hypermode_24
        Me.HyperModeToolStripMenuItem.Name = "HyperModeToolStripMenuItem"
        Me.HyperModeToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.HyperModeToolStripMenuItem.Text = "Hyper Mode"
        '
        'ShinyHuntingToolStripMenuItem
        '
        Me.ShinyHuntingToolStripMenuItem.Name = "ShinyHuntingToolStripMenuItem"
        Me.ShinyHuntingToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.ShinyHuntingToolStripMenuItem.Text = "Shiny Hunting"
        '
        'UberCharmToolStripMenuItem
        '
        Me.UberCharmToolStripMenuItem.Name = "UberCharmToolStripMenuItem"
        Me.UberCharmToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.UberCharmToolStripMenuItem.Text = "Uber Charm"
        '
        'AlbinoHuntingToolStripMenuItem
        '
        Me.AlbinoHuntingToolStripMenuItem.Name = "AlbinoHuntingToolStripMenuItem"
        Me.AlbinoHuntingToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.AlbinoHuntingToolStripMenuItem.Text = "Albino Hunting"
        '
        'LuckyEggToolStripMenuItem
        '
        Me.LuckyEggToolStripMenuItem.Image = Global.PokeFarm.My.Resources.Resources.lab
        Me.LuckyEggToolStripMenuItem.Name = "LuckyEggToolStripMenuItem"
        Me.LuckyEggToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.LuckyEggToolStripMenuItem.Text = "Lucky Egg"
        '
        'Messages_tsm
        '
        Me.Messages_tsm.Name = "Messages_tsm"
        Me.Messages_tsm.Size = New System.Drawing.Size(70, 20)
        Me.Messages_tsm.Text = "Messages"
        '
        'Forum_tsm
        '
        Me.Forum_tsm.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VisitForumToolStripMenuItem, Me.ForumSubscriptionsToolStripMenuItem})
        Me.Forum_tsm.Name = "Forum_tsm"
        Me.Forum_tsm.Size = New System.Drawing.Size(54, 20)
        Me.Forum_tsm.Text = "Forum"
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
        'Help_tsm
        '
        Me.Help_tsm.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.About_tsmi})
        Me.Help_tsm.Image = Global.PokeFarm.My.Resources.Resources.qmark
        Me.Help_tsm.Name = "Help_tsm"
        Me.Help_tsm.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Help_tsm.Size = New System.Drawing.Size(60, 20)
        Me.Help_tsm.Text = "Help"
        '
        'About_tsmi
        '
        Me.About_tsmi.Name = "About_tsmi"
        Me.About_tsmi.Size = New System.Drawing.Size(107, 22)
        Me.About_tsmi.Text = "About"
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
    Friend WithEvents Help_tsm As ToolStripMenuItem
    Friend WithEvents About_tsmi As ToolStripMenuItem
    Friend WithEvents Messages_tsm As ToolStripMenuItem
    Friend WithEvents Forum_tsm As ToolStripMenuItem
    Friend WithEvents VisitForumToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ForumSubscriptionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuickTools_tsm As ToolStripMenuItem
    Friend WithEvents NewsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InteractionsToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents TournamentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EggTimerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HyperModeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ShinyHuntingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AlbinoHuntingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LuckyEggToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UberCharmToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Basic_tsm As ToolStripMenuItem
    Friend WithEvents Lab_tsmi As ToolStripMenuItem
    Friend WithEvents Party_tsmi As ToolStripMenuItem
    Friend WithEvents Farm_tsmi As ToolStripMenuItem
    Friend WithEvents Shelter_tsmi As ToolStripMenuItem
    Friend WithEvents Marketboard_tsmi As ToolStripMenuItem
    Friend WithEvents daycare_tsmi As ToolStripMenuItem
    Friend WithEvents Pokedex_tsmi As ToolStripMenuItem
    Friend WithEvents Farm_tsm As ToolStripMenuItem
    Friend WithEvents Fields_tsm As ToolStripMenuItem
    Friend WithEvents Scour_tsm As ToolStripMenuItem
    Friend WithEvents Wishforge_tsm As ToolStripMenuItem
    Friend WithEvents FarmNewsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InventoryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NearbyPlacesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OtherLinksToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DisplayToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NotificationsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BookmarksToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TimersBarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ForumToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents UserscriptsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OthersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NotepadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InteractionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FarmNews_tsmi As ToolStripMenuItem
    Friend WithEvents Inventory_tsmi As ToolStripMenuItem
    Friend WithEvents NearbyPlaces_tsmi As ToolStripMenuItem
    Friend WithEvents OtherLinks_tsmi As ToolStripMenuItem
    Friend WithEvents Options_tsmi As ToolStripMenuItem
    Friend WithEvents optionDisplay_tsmi As ToolStripMenuItem
    Friend WithEvents optionNotif_tsmi As ToolStripMenuItem
    Friend WithEvents optionBookmar_tsmi As ToolStripMenuItem
    Friend WithEvents optionTimer_tsmi As ToolStripMenuItem
    Friend WithEvents optionFroum_tsmi As ToolStripMenuItem
    Friend WithEvents optionUserScri_tsmi As ToolStripMenuItem
    Friend WithEvents optionOthers_tsmi As ToolStripMenuItem
    Friend WithEvents Notepad_tsmi As ToolStripMenuItem
    Friend WithEvents Interactions_tsmi As ToolStripMenuItem
End Class
