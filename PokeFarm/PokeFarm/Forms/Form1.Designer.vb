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
        components = New ComponentModel.Container()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        webView = New Microsoft.Web.WebView2.WinForms.WebView2()
        MenuStrip1 = New MenuStrip()
        Lab_tsm = New ToolStripMenuItem()
        Party_tsm = New ToolStripMenuItem()
        Shelter_tsm = New ToolStripMenuItem()
        Market_tsm = New ToolStripMenuItem()
        Daycare_tsm = New ToolStripMenuItem()
        Dex_tsm = New ToolStripMenuItem()
        Farm_tsm = New ToolStripMenuItem()
        FarmNews_tsmi = New ToolStripMenuItem()
        Inventory_tsmi = New ToolStripMenuItem()
        OtherLinks_tsmi = New ToolStripMenuItem()
        Options_tsmi = New ToolStripMenuItem()
        optionDisplay_tsmi = New ToolStripMenuItem()
        optionNotif_tsmi = New ToolStripMenuItem()
        optionBookmar_tsmi = New ToolStripMenuItem()
        optionTimer_tsmi = New ToolStripMenuItem()
        optionFroum_tsmi = New ToolStripMenuItem()
        optionUserScri_tsmi = New ToolStripMenuItem()
        optionOthers_tsmi = New ToolStripMenuItem()
        Notepad_tsmi = New ToolStripMenuItem()
        Interactions_tsmi = New ToolStripMenuItem()
        NearbyPlaces_tsm = New ToolStripMenuItem()
        berry_tsmi = New ToolStripMenuItem()
        fish_tsmi = New ToolStripMenuItem()
        trade_tsmi = New ToolStripMenuItem()
        egg_tsmi = New ToolStripMenuItem()
        contest_tsmi = New ToolStripMenuItem()
        dojo_tsmi = New ToolStripMenuItem()
        colress_tsmi = New ToolStripMenuItem()
        pGrove_tsmi = New ToolStripMenuItem()
        aether_tsmi = New ToolStripMenuItem()
        research_tsmi = New ToolStripMenuItem()
        cele_tsmi = New ToolStripMenuItem()
        Currencies_tsm = New ToolStripMenuItem()
        Credits_tsmu = New ToolStripMenuItem()
        Gold_tsmu = New ToolStripMenuItem()
        Zophan_tsmu = New ToolStripMenuItem()
        Fields_tsm = New ToolStripMenuItem()
        Scour_tsm = New ToolStripMenuItem()
        Wishforge_tsm = New ToolStripMenuItem()
        Boxes_tsm = New ToolStripMenuItem()
        Summons_tsm = New ToolStripMenuItem()
        Users_tmu = New ToolStripMenuItem()
        myUserProfle_tsmi = New ToolStripMenuItem()
        usersSep1_tsmi = New ToolStripSeparator()
        userSearch_tsmi = New ToolStripMenuItem()
        pokerus_tsmi = New ToolStripMenuItem()
        QuickTools_tsm = New ToolStripMenuItem()
        NewsToolStripMenuItem = New ToolStripMenuItem()
        InteractionsToolStripMenuItem1 = New ToolStripMenuItem()
        TournamentToolStripMenuItem = New ToolStripMenuItem()
        EggTimerToolStripMenuItem = New ToolStripMenuItem()
        HyperModeToolStripMenuItem = New ToolStripMenuItem()
        ShinyHuntingToolStripMenuItem = New ToolStripMenuItem()
        UberCharmToolStripMenuItem = New ToolStripMenuItem()
        AlbinoHuntingToolStripMenuItem = New ToolStripMenuItem()
        LuckyEggToolStripMenuItem = New ToolStripMenuItem()
        Messages_tsm = New ToolStripMenuItem()
        Forum_tsm = New ToolStripMenuItem()
        VisitForumToolStripMenuItem = New ToolStripMenuItem()
        ForumSubscriptionsToolStripMenuItem = New ToolStripMenuItem()
        Special_tsm = New ToolStripMenuItem()
        MCA_tsmi = New ToolStripMenuItem()
        MCAWeb_tsmi = New ToolStripMenuItem()
        MCAForum_tsmi = New ToolStripMenuItem()
        SCA_tsmi = New ToolStripMenuItem()
        SCAForum_tsmi = New ToolStripMenuItem()
        Help_tsm = New ToolStripMenuItem()
        SettingsToolStripMenuItem = New ToolStripMenuItem()
        TrustedDomainsToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator1 = New ToolStripSeparator()
        Wiki_tsmi = New ToolStripMenuItem()
        About_tsmi = New ToolStripMenuItem()
        FarmNewsToolStripMenuItem = New ToolStripMenuItem()
        InventoryToolStripMenuItem = New ToolStripMenuItem()
        NearbyPlacesToolStripMenuItem = New ToolStripMenuItem()
        OtherLinksToolStripMenuItem = New ToolStripMenuItem()
        OptionsToolStripMenuItem = New ToolStripMenuItem()
        DisplayToolStripMenuItem = New ToolStripMenuItem()
        NotificationsToolStripMenuItem = New ToolStripMenuItem()
        BookmarksToolStripMenuItem = New ToolStripMenuItem()
        TimersBarToolStripMenuItem = New ToolStripMenuItem()
        ForumToolStripMenuItem1 = New ToolStripMenuItem()
        UserscriptsToolStripMenuItem = New ToolStripMenuItem()
        OthersToolStripMenuItem = New ToolStripMenuItem()
        NotepadToolStripMenuItem = New ToolStripMenuItem()
        InteractionsToolStripMenuItem = New ToolStripMenuItem()
        NotifyIcon1 = New NotifyIcon(components)
        trayIconStrip = New ContextMenuStrip(components)
        OpenToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator2 = New ToolStripSeparator()
        QuitToolStripMenuItem = New ToolStripMenuItem()
        StatusStrip1 = New StatusStrip()
        navProgress_status = New ToolStripStatusLabel()
        CType(webView, ComponentModel.ISupportInitialize).BeginInit()
        MenuStrip1.SuspendLayout()
        trayIconStrip.SuspendLayout()
        StatusStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' webView
        ' 
        webView.AllowExternalDrop = True
        webView.CreationProperties = Nothing
        webView.DefaultBackgroundColor = Color.Black
        webView.Dock = DockStyle.Fill
        webView.Location = New Point(126, 0)
        webView.Name = "webView"
        webView.Size = New Size(1138, 681)
        webView.TabIndex = 0
        webView.ZoomFactor = 1R
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Dock = DockStyle.Left
        MenuStrip1.Items.AddRange(New ToolStripItem() {Lab_tsm, Party_tsm, Shelter_tsm, Market_tsm, Daycare_tsm, Dex_tsm, Farm_tsm, NearbyPlaces_tsm, Currencies_tsm, Fields_tsm, Scour_tsm, Wishforge_tsm, Boxes_tsm, Summons_tsm, Users_tmu, QuickTools_tsm, Messages_tsm, Forum_tsm, Special_tsm, Help_tsm})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(126, 703)
        MenuStrip1.TabIndex = 1
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' Lab_tsm
        ' 
        Lab_tsm.Image = My.Resources.Resources.lab
        Lab_tsm.Name = "Lab_tsm"
        Lab_tsm.Size = New Size(113, 20)
        Lab_tsm.Text = "Lab"
        ' 
        ' Party_tsm
        ' 
        Party_tsm.Image = My.Resources.Resources.pokeball
        Party_tsm.Name = "Party_tsm"
        Party_tsm.Size = New Size(113, 20)
        Party_tsm.Text = "Party"
        ' 
        ' Shelter_tsm
        ' 
        Shelter_tsm.Image = My.Resources.Resources.shelter
        Shelter_tsm.Name = "Shelter_tsm"
        Shelter_tsm.Size = New Size(113, 20)
        Shelter_tsm.Text = "Shelter"
        ' 
        ' Market_tsm
        ' 
        Market_tsm.Image = My.Resources.Resources.shop
        Market_tsm.Name = "Market_tsm"
        Market_tsm.Size = New Size(113, 20)
        Market_tsm.Text = "Market"
        ' 
        ' Daycare_tsm
        ' 
        Daycare_tsm.Image = My.Resources.Resources.daycare
        Daycare_tsm.Name = "Daycare_tsm"
        Daycare_tsm.Size = New Size(113, 20)
        Daycare_tsm.Text = "Daycare"
        ' 
        ' Dex_tsm
        ' 
        Dex_tsm.Image = My.Resources.Resources.dex
        Dex_tsm.Name = "Dex_tsm"
        Dex_tsm.Size = New Size(113, 20)
        Dex_tsm.Text = "Pokédex"
        ' 
        ' Farm_tsm
        ' 
        Farm_tsm.DropDownItems.AddRange(New ToolStripItem() {FarmNews_tsmi, Inventory_tsmi, OtherLinks_tsmi, Options_tsmi, Notepad_tsmi, Interactions_tsmi})
        Farm_tsm.Image = My.Resources.Resources.farm
        Farm_tsm.Name = "Farm_tsm"
        Farm_tsm.Size = New Size(113, 20)
        Farm_tsm.Text = "Farm"
        ' 
        ' FarmNews_tsmi
        ' 
        FarmNews_tsmi.Image = My.Resources.Resources.farm_news
        FarmNews_tsmi.Name = "FarmNews_tsmi"
        FarmNews_tsmi.Size = New Size(136, 22)
        FarmNews_tsmi.Text = "Farm News"
        ' 
        ' Inventory_tsmi
        ' 
        Inventory_tsmi.Image = My.Resources.Resources.inventory
        Inventory_tsmi.Name = "Inventory_tsmi"
        Inventory_tsmi.Size = New Size(136, 22)
        Inventory_tsmi.Text = "Inventory"
        ' 
        ' OtherLinks_tsmi
        ' 
        OtherLinks_tsmi.Image = My.Resources.Resources.links
        OtherLinks_tsmi.Name = "OtherLinks_tsmi"
        OtherLinks_tsmi.Size = New Size(136, 22)
        OtherLinks_tsmi.Text = "Other Links"
        ' 
        ' Options_tsmi
        ' 
        Options_tsmi.DropDownItems.AddRange(New ToolStripItem() {optionDisplay_tsmi, optionNotif_tsmi, optionBookmar_tsmi, optionTimer_tsmi, optionFroum_tsmi, optionUserScri_tsmi, optionOthers_tsmi})
        Options_tsmi.Image = My.Resources.Resources.tools_options
        Options_tsmi.Name = "Options_tsmi"
        Options_tsmi.Size = New Size(136, 22)
        Options_tsmi.Text = "Options"
        ' 
        ' optionDisplay_tsmi
        ' 
        optionDisplay_tsmi.Image = My.Resources.Resources.tools_options
        optionDisplay_tsmi.Name = "optionDisplay_tsmi"
        optionDisplay_tsmi.Size = New Size(142, 22)
        optionDisplay_tsmi.Text = "Display"
        ' 
        ' optionNotif_tsmi
        ' 
        optionNotif_tsmi.Image = My.Resources.Resources.tools_options
        optionNotif_tsmi.Name = "optionNotif_tsmi"
        optionNotif_tsmi.Size = New Size(142, 22)
        optionNotif_tsmi.Text = "Notifications"
        ' 
        ' optionBookmar_tsmi
        ' 
        optionBookmar_tsmi.Image = My.Resources.Resources.tools_options
        optionBookmar_tsmi.Name = "optionBookmar_tsmi"
        optionBookmar_tsmi.Size = New Size(142, 22)
        optionBookmar_tsmi.Text = "Bookmarks"
        ' 
        ' optionTimer_tsmi
        ' 
        optionTimer_tsmi.Image = My.Resources.Resources.tools_options
        optionTimer_tsmi.Name = "optionTimer_tsmi"
        optionTimer_tsmi.Size = New Size(142, 22)
        optionTimer_tsmi.Text = "Timers Bar"
        ' 
        ' optionFroum_tsmi
        ' 
        optionFroum_tsmi.Image = My.Resources.Resources.tools_options
        optionFroum_tsmi.Name = "optionFroum_tsmi"
        optionFroum_tsmi.Size = New Size(142, 22)
        optionFroum_tsmi.Text = "Forum"
        ' 
        ' optionUserScri_tsmi
        ' 
        optionUserScri_tsmi.Image = My.Resources.Resources.tools_options
        optionUserScri_tsmi.Name = "optionUserScri_tsmi"
        optionUserScri_tsmi.Size = New Size(142, 22)
        optionUserScri_tsmi.Text = "User Scripts"
        ' 
        ' optionOthers_tsmi
        ' 
        optionOthers_tsmi.Image = My.Resources.Resources.tools_options
        optionOthers_tsmi.Name = "optionOthers_tsmi"
        optionOthers_tsmi.Size = New Size(142, 22)
        optionOthers_tsmi.Text = "Others"
        ' 
        ' Notepad_tsmi
        ' 
        Notepad_tsmi.Image = My.Resources.Resources.notepad
        Notepad_tsmi.Name = "Notepad_tsmi"
        Notepad_tsmi.Size = New Size(136, 22)
        Notepad_tsmi.Text = "Notepad"
        ' 
        ' Interactions_tsmi
        ' 
        Interactions_tsmi.Image = My.Resources.Resources.interactions
        Interactions_tsmi.Name = "Interactions_tsmi"
        Interactions_tsmi.Size = New Size(136, 22)
        Interactions_tsmi.Text = "Interactions"
        ' 
        ' NearbyPlaces_tsm
        ' 
        NearbyPlaces_tsm.DropDownItems.AddRange(New ToolStripItem() {berry_tsmi, fish_tsmi, trade_tsmi, egg_tsmi, contest_tsmi, dojo_tsmi, colress_tsmi, pGrove_tsmi, aether_tsmi, research_tsmi, cele_tsmi})
        NearbyPlaces_tsm.Image = My.Resources.Resources.places
        NearbyPlaces_tsm.Name = "NearbyPlaces_tsm"
        NearbyPlaces_tsm.Size = New Size(113, 20)
        NearbyPlaces_tsm.Text = "Nearby Places"
        ' 
        ' berry_tsmi
        ' 
        berry_tsmi.Name = "berry_tsmi"
        berry_tsmi.Size = New Size(191, 22)
        berry_tsmi.Text = "Berry Garden"
        ' 
        ' fish_tsmi
        ' 
        fish_tsmi.Name = "fish_tsmi"
        fish_tsmi.Size = New Size(191, 22)
        fish_tsmi.Text = "Fishing Hut"
        ' 
        ' trade_tsmi
        ' 
        trade_tsmi.Name = "trade_tsmi"
        trade_tsmi.Size = New Size(191, 22)
        trade_tsmi.Text = "Trade Centre"
        ' 
        ' egg_tsmi
        ' 
        egg_tsmi.Name = "egg_tsmi"
        egg_tsmi.Size = New Size(191, 22)
        egg_tsmi.Text = "Egg Supplier"
        ' 
        ' contest_tsmi
        ' 
        contest_tsmi.Name = "contest_tsmi"
        contest_tsmi.Size = New Size(191, 22)
        contest_tsmi.Text = "Contest Hall"
        ' 
        ' dojo_tsmi
        ' 
        dojo_tsmi.Name = "dojo_tsmi"
        dojo_tsmi.Size = New Size(191, 22)
        dojo_tsmi.Text = "Pokémon Dojo"
        ' 
        ' colress_tsmi
        ' 
        colress_tsmi.Name = "colress_tsmi"
        colress_tsmi.Size = New Size(191, 22)
        colress_tsmi.Text = "Colress' Shack"
        ' 
        ' pGrove_tsmi
        ' 
        pGrove_tsmi.Name = "pGrove_tsmi"
        pGrove_tsmi.Size = New Size(191, 22)
        pGrove_tsmi.Text = "Pledge Grove"
        ' 
        ' aether_tsmi
        ' 
        aether_tsmi.Name = "aether_tsmi"
        aether_tsmi.Size = New Size(191, 22)
        aether_tsmi.Text = "Aether House"
        ' 
        ' research_tsmi
        ' 
        research_tsmi.Name = "research_tsmi"
        research_tsmi.Size = New Size(191, 22)
        research_tsmi.Text = "Holon Research Tower"
        ' 
        ' cele_tsmi
        ' 
        cele_tsmi.Name = "cele_tsmi"
        cele_tsmi.Size = New Size(191, 22)
        cele_tsmi.Text = "Cele's Centre"
        ' 
        ' Currencies_tsm
        ' 
        Currencies_tsm.DropDownItems.AddRange(New ToolStripItem() {Credits_tsmu, Gold_tsmu, Zophan_tsmu})
        Currencies_tsm.Image = My.Resources.Resources.gold
        Currencies_tsm.Name = "Currencies_tsm"
        Currencies_tsm.Size = New Size(113, 20)
        Currencies_tsm.Text = "Currencies"
        ' 
        ' Credits_tsmu
        ' 
        Credits_tsmu.Image = My.Resources.Resources.credits
        Credits_tsmu.Name = "Credits_tsmu"
        Credits_tsmu.Size = New Size(166, 22)
        Credits_tsmu.Text = "Credits"
        ' 
        ' Gold_tsmu
        ' 
        Gold_tsmu.Image = My.Resources.Resources.gold
        Gold_tsmu.Name = "Gold_tsmu"
        Gold_tsmu.Size = New Size(166, 22)
        Gold_tsmu.Text = "Gold Poké"
        ' 
        ' Zophan_tsmu
        ' 
        Zophan_tsmu.Image = My.Resources.Resources.zophan
        Zophan_tsmu.Name = "Zophan_tsmu"
        Zophan_tsmu.Size = New Size(166, 22)
        Zophan_tsmu.Text = "Zophan Canisters"
        ' 
        ' Fields_tsm
        ' 
        Fields_tsm.Image = My.Resources.Resources.places
        Fields_tsm.Name = "Fields_tsm"
        Fields_tsm.Size = New Size(113, 20)
        Fields_tsm.Text = "Fields"
        ' 
        ' Scour_tsm
        ' 
        Scour_tsm.Image = My.Resources.Resources.places
        Scour_tsm.Name = "Scour_tsm"
        Scour_tsm.Size = New Size(113, 20)
        Scour_tsm.Text = "Scour Missions"
        ' 
        ' Wishforge_tsm
        ' 
        Wishforge_tsm.Image = My.Resources.Resources.gem_normal
        Wishforge_tsm.Name = "Wishforge_tsm"
        Wishforge_tsm.Size = New Size(113, 20)
        Wishforge_tsm.Text = "Wishforge"
        ' 
        ' Boxes_tsm
        ' 
        Boxes_tsm.Image = My.Resources.Resources.boxboxboxbox
        Boxes_tsm.Name = "Boxes_tsm"
        Boxes_tsm.Size = New Size(113, 20)
        Boxes_tsm.Text = "Treasure Boxes"
        ' 
        ' Summons_tsm
        ' 
        Summons_tsm.Image = My.Resources.Resources.links
        Summons_tsm.Name = "Summons_tsm"
        Summons_tsm.Size = New Size(113, 20)
        Summons_tsm.Text = "Summons"
        ' 
        ' Users_tmu
        ' 
        Users_tmu.DropDownItems.AddRange(New ToolStripItem() {myUserProfle_tsmi, usersSep1_tsmi, userSearch_tsmi, pokerus_tsmi})
        Users_tmu.Name = "Users_tmu"
        Users_tmu.Size = New Size(113, 19)
        Users_tmu.Text = "Users"
        ' 
        ' myUserProfle_tsmi
        ' 
        myUserProfle_tsmi.Name = "myUserProfle_tsmi"
        myUserProfle_tsmi.Size = New Size(173, 22)
        myUserProfle_tsmi.Text = "My Profile"
        ' 
        ' usersSep1_tsmi
        ' 
        usersSep1_tsmi.Name = "usersSep1_tsmi"
        usersSep1_tsmi.Size = New Size(170, 6)
        ' 
        ' userSearch_tsmi
        ' 
        userSearch_tsmi.Name = "userSearch_tsmi"
        userSearch_tsmi.Size = New Size(173, 22)
        userSearch_tsmi.Text = "Search for a Profile"
        ' 
        ' pokerus_tsmi
        ' 
        pokerus_tsmi.Name = "pokerus_tsmi"
        pokerus_tsmi.Size = New Size(173, 22)
        pokerus_tsmi.Text = "Pokérus"
        ' 
        ' QuickTools_tsm
        ' 
        QuickTools_tsm.DropDownItems.AddRange(New ToolStripItem() {NewsToolStripMenuItem, InteractionsToolStripMenuItem1, TournamentToolStripMenuItem, EggTimerToolStripMenuItem, HyperModeToolStripMenuItem, ShinyHuntingToolStripMenuItem, UberCharmToolStripMenuItem, AlbinoHuntingToolStripMenuItem, LuckyEggToolStripMenuItem})
        QuickTools_tsm.Name = "QuickTools_tsm"
        QuickTools_tsm.Size = New Size(113, 19)
        QuickTools_tsm.Text = "Quick Menu"
        ' 
        ' NewsToolStripMenuItem
        ' 
        NewsToolStripMenuItem.Image = My.Resources.Resources.farm_news
        NewsToolStripMenuItem.Name = "NewsToolStripMenuItem"
        NewsToolStripMenuItem.Size = New Size(156, 22)
        NewsToolStripMenuItem.Text = "News"
        ' 
        ' InteractionsToolStripMenuItem1
        ' 
        InteractionsToolStripMenuItem1.Image = My.Resources.Resources.interactions
        InteractionsToolStripMenuItem1.Name = "InteractionsToolStripMenuItem1"
        InteractionsToolStripMenuItem1.Size = New Size(156, 22)
        InteractionsToolStripMenuItem1.Text = "Interactions"
        ' 
        ' TournamentToolStripMenuItem
        ' 
        TournamentToolStripMenuItem.Image = My.Resources.Resources.links
        TournamentToolStripMenuItem.Name = "TournamentToolStripMenuItem"
        TournamentToolStripMenuItem.Size = New Size(156, 22)
        TournamentToolStripMenuItem.Text = "Tournament"
        ' 
        ' EggTimerToolStripMenuItem
        ' 
        EggTimerToolStripMenuItem.Image = My.Resources.Resources.incubator
        EggTimerToolStripMenuItem.Name = "EggTimerToolStripMenuItem"
        EggTimerToolStripMenuItem.Size = New Size(156, 22)
        EggTimerToolStripMenuItem.Text = "Egg Timer"
        ' 
        ' HyperModeToolStripMenuItem
        ' 
        HyperModeToolStripMenuItem.Image = My.Resources.Resources.hypermode_24
        HyperModeToolStripMenuItem.Name = "HyperModeToolStripMenuItem"
        HyperModeToolStripMenuItem.Size = New Size(156, 22)
        HyperModeToolStripMenuItem.Text = "Hyper Mode"
        ' 
        ' ShinyHuntingToolStripMenuItem
        ' 
        ShinyHuntingToolStripMenuItem.Image = My.Resources.Resources.shinycharm
        ShinyHuntingToolStripMenuItem.Name = "ShinyHuntingToolStripMenuItem"
        ShinyHuntingToolStripMenuItem.Size = New Size(156, 22)
        ShinyHuntingToolStripMenuItem.Text = "Shiny Hunting"
        ' 
        ' UberCharmToolStripMenuItem
        ' 
        UberCharmToolStripMenuItem.Image = My.Resources.Resources.ubercharm
        UberCharmToolStripMenuItem.Name = "UberCharmToolStripMenuItem"
        UberCharmToolStripMenuItem.Size = New Size(156, 22)
        UberCharmToolStripMenuItem.Text = "Uber Charm"
        ' 
        ' AlbinoHuntingToolStripMenuItem
        ' 
        AlbinoHuntingToolStripMenuItem.Image = My.Resources.Resources.albinoradar
        AlbinoHuntingToolStripMenuItem.Name = "AlbinoHuntingToolStripMenuItem"
        AlbinoHuntingToolStripMenuItem.Size = New Size(156, 22)
        AlbinoHuntingToolStripMenuItem.Text = "Albino Hunting"
        ' 
        ' LuckyEggToolStripMenuItem
        ' 
        LuckyEggToolStripMenuItem.Image = My.Resources.Resources.luckyegg
        LuckyEggToolStripMenuItem.Name = "LuckyEggToolStripMenuItem"
        LuckyEggToolStripMenuItem.Size = New Size(156, 22)
        LuckyEggToolStripMenuItem.Text = "Lucky Egg"
        ' 
        ' Messages_tsm
        ' 
        Messages_tsm.Name = "Messages_tsm"
        Messages_tsm.Size = New Size(113, 19)
        Messages_tsm.Text = "Messages"
        ' 
        ' Forum_tsm
        ' 
        Forum_tsm.DropDownItems.AddRange(New ToolStripItem() {VisitForumToolStripMenuItem, ForumSubscriptionsToolStripMenuItem})
        Forum_tsm.Name = "Forum_tsm"
        Forum_tsm.Size = New Size(113, 19)
        Forum_tsm.Text = "Forum"
        ' 
        ' VisitForumToolStripMenuItem
        ' 
        VisitForumToolStripMenuItem.Name = "VisitForumToolStripMenuItem"
        VisitForumToolStripMenuItem.Size = New Size(183, 22)
        VisitForumToolStripMenuItem.Text = "Visit Forum"
        ' 
        ' ForumSubscriptionsToolStripMenuItem
        ' 
        ForumSubscriptionsToolStripMenuItem.Name = "ForumSubscriptionsToolStripMenuItem"
        ForumSubscriptionsToolStripMenuItem.Size = New Size(183, 22)
        ForumSubscriptionsToolStripMenuItem.Text = "Forum Subscriptions"
        ' 
        ' Special_tsm
        ' 
        Special_tsm.DropDownItems.AddRange(New ToolStripItem() {MCA_tsmi, SCA_tsmi})
        Special_tsm.Name = "Special_tsm"
        Special_tsm.Size = New Size(113, 19)
        Special_tsm.Text = "Special"
        ' 
        ' MCA_tsmi
        ' 
        MCA_tsmi.DropDownItems.AddRange(New ToolStripItem() {MCAWeb_tsmi, MCAForum_tsmi})
        MCA_tsmi.Name = "MCA_tsmi"
        MCA_tsmi.Size = New Size(101, 22)
        MCA_tsmi.Text = "MCA"
        ' 
        ' MCAWeb_tsmi
        ' 
        MCAWeb_tsmi.Name = "MCAWeb_tsmi"
        MCAWeb_tsmi.Size = New Size(116, 22)
        MCAWeb_tsmi.Text = "Website"
        ' 
        ' MCAForum_tsmi
        ' 
        MCAForum_tsmi.Name = "MCAForum_tsmi"
        MCAForum_tsmi.Size = New Size(116, 22)
        MCAForum_tsmi.Text = "Forum"
        ' 
        ' SCA_tsmi
        ' 
        SCA_tsmi.DropDownItems.AddRange(New ToolStripItem() {SCAForum_tsmi})
        SCA_tsmi.Name = "SCA_tsmi"
        SCA_tsmi.Size = New Size(101, 22)
        SCA_tsmi.Text = "SCA"
        ' 
        ' SCAForum_tsmi
        ' 
        SCAForum_tsmi.Name = "SCAForum_tsmi"
        SCAForum_tsmi.Size = New Size(109, 22)
        SCAForum_tsmi.Text = "Forum"
        ' 
        ' Help_tsm
        ' 
        Help_tsm.DropDownItems.AddRange(New ToolStripItem() {SettingsToolStripMenuItem, TrustedDomainsToolStripMenuItem, ToolStripSeparator1, Wiki_tsmi, About_tsmi})
        Help_tsm.Image = My.Resources.Resources.qmark
        Help_tsm.Name = "Help_tsm"
        Help_tsm.RightToLeft = RightToLeft.No
        Help_tsm.Size = New Size(113, 20)
        Help_tsm.Text = "Help"
        ' 
        ' SettingsToolStripMenuItem
        ' 
        SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        SettingsToolStripMenuItem.Size = New Size(162, 22)
        SettingsToolStripMenuItem.Text = "Settings"
        ' 
        ' TrustedDomainsToolStripMenuItem
        ' 
        TrustedDomainsToolStripMenuItem.Name = "TrustedDomainsToolStripMenuItem"
        TrustedDomainsToolStripMenuItem.Size = New Size(162, 22)
        TrustedDomainsToolStripMenuItem.Text = "Trusted Domains"
        ' 
        ' ToolStripSeparator1
        ' 
        ToolStripSeparator1.Name = "ToolStripSeparator1"
        ToolStripSeparator1.Size = New Size(159, 6)
        ' 
        ' Wiki_tsmi
        ' 
        Wiki_tsmi.Name = "Wiki_tsmi"
        Wiki_tsmi.Size = New Size(162, 22)
        Wiki_tsmi.Text = "Wiki"
        ' 
        ' About_tsmi
        ' 
        About_tsmi.Name = "About_tsmi"
        About_tsmi.Size = New Size(162, 22)
        About_tsmi.Text = "About"
        ' 
        ' FarmNewsToolStripMenuItem
        ' 
        FarmNewsToolStripMenuItem.Image = My.Resources.Resources.farm_news
        FarmNewsToolStripMenuItem.Name = "FarmNewsToolStripMenuItem"
        FarmNewsToolStripMenuItem.Size = New Size(148, 22)
        FarmNewsToolStripMenuItem.Text = "Farm News"
        ' 
        ' InventoryToolStripMenuItem
        ' 
        InventoryToolStripMenuItem.Image = My.Resources.Resources.inventory
        InventoryToolStripMenuItem.Name = "InventoryToolStripMenuItem"
        InventoryToolStripMenuItem.Size = New Size(148, 22)
        InventoryToolStripMenuItem.Text = "Inventory"
        ' 
        ' NearbyPlacesToolStripMenuItem
        ' 
        NearbyPlacesToolStripMenuItem.Image = My.Resources.Resources.places
        NearbyPlacesToolStripMenuItem.Name = "NearbyPlacesToolStripMenuItem"
        NearbyPlacesToolStripMenuItem.Size = New Size(148, 22)
        NearbyPlacesToolStripMenuItem.Text = "Nearby Places"
        ' 
        ' OtherLinksToolStripMenuItem
        ' 
        OtherLinksToolStripMenuItem.Image = My.Resources.Resources.links
        OtherLinksToolStripMenuItem.Name = "OtherLinksToolStripMenuItem"
        OtherLinksToolStripMenuItem.Size = New Size(148, 22)
        OtherLinksToolStripMenuItem.Text = "Other Links"
        ' 
        ' OptionsToolStripMenuItem
        ' 
        OptionsToolStripMenuItem.Image = My.Resources.Resources.tools_options
        OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        OptionsToolStripMenuItem.Size = New Size(148, 22)
        OptionsToolStripMenuItem.Text = "Options"
        ' 
        ' DisplayToolStripMenuItem
        ' 
        DisplayToolStripMenuItem.Name = "DisplayToolStripMenuItem"
        DisplayToolStripMenuItem.Size = New Size(142, 22)
        DisplayToolStripMenuItem.Text = "Display"
        ' 
        ' NotificationsToolStripMenuItem
        ' 
        NotificationsToolStripMenuItem.Name = "NotificationsToolStripMenuItem"
        NotificationsToolStripMenuItem.Size = New Size(142, 22)
        NotificationsToolStripMenuItem.Text = "Notifications"
        ' 
        ' BookmarksToolStripMenuItem
        ' 
        BookmarksToolStripMenuItem.Name = "BookmarksToolStripMenuItem"
        BookmarksToolStripMenuItem.Size = New Size(142, 22)
        BookmarksToolStripMenuItem.Text = "Bookmarks"
        ' 
        ' TimersBarToolStripMenuItem
        ' 
        TimersBarToolStripMenuItem.Name = "TimersBarToolStripMenuItem"
        TimersBarToolStripMenuItem.Size = New Size(142, 22)
        TimersBarToolStripMenuItem.Text = "Timers Bar"
        ' 
        ' ForumToolStripMenuItem1
        ' 
        ForumToolStripMenuItem1.Name = "ForumToolStripMenuItem1"
        ForumToolStripMenuItem1.Size = New Size(142, 22)
        ForumToolStripMenuItem1.Text = "Forum"
        ' 
        ' UserscriptsToolStripMenuItem
        ' 
        UserscriptsToolStripMenuItem.Name = "UserscriptsToolStripMenuItem"
        UserscriptsToolStripMenuItem.Size = New Size(142, 22)
        UserscriptsToolStripMenuItem.Text = "Userscripts"
        ' 
        ' OthersToolStripMenuItem
        ' 
        OthersToolStripMenuItem.Name = "OthersToolStripMenuItem"
        OthersToolStripMenuItem.Size = New Size(142, 22)
        OthersToolStripMenuItem.Text = "Others"
        ' 
        ' NotepadToolStripMenuItem
        ' 
        NotepadToolStripMenuItem.Image = My.Resources.Resources.notepad
        NotepadToolStripMenuItem.Name = "NotepadToolStripMenuItem"
        NotepadToolStripMenuItem.Size = New Size(148, 22)
        NotepadToolStripMenuItem.Text = "Notepad"
        ' 
        ' InteractionsToolStripMenuItem
        ' 
        InteractionsToolStripMenuItem.Image = My.Resources.Resources.interactions
        InteractionsToolStripMenuItem.Name = "InteractionsToolStripMenuItem"
        InteractionsToolStripMenuItem.Size = New Size(148, 22)
        InteractionsToolStripMenuItem.Text = "Interactions"
        ' 
        ' NotifyIcon1
        ' 
        NotifyIcon1.ContextMenuStrip = trayIconStrip
        NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), Icon)
        NotifyIcon1.Text = "PokéFarm Q Desktop App"
        ' 
        ' trayIconStrip
        ' 
        trayIconStrip.Items.AddRange(New ToolStripItem() {OpenToolStripMenuItem, ToolStripSeparator2, QuitToolStripMenuItem})
        trayIconStrip.Name = "trayIconStrip"
        trayIconStrip.Size = New Size(104, 54)
        ' 
        ' OpenToolStripMenuItem
        ' 
        OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        OpenToolStripMenuItem.Size = New Size(103, 22)
        OpenToolStripMenuItem.Text = "Open"
        ' 
        ' ToolStripSeparator2
        ' 
        ToolStripSeparator2.Name = "ToolStripSeparator2"
        ToolStripSeparator2.Size = New Size(100, 6)
        ' 
        ' QuitToolStripMenuItem
        ' 
        QuitToolStripMenuItem.Name = "QuitToolStripMenuItem"
        QuitToolStripMenuItem.Size = New Size(103, 22)
        QuitToolStripMenuItem.Text = "Quit"
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.Items.AddRange(New ToolStripItem() {navProgress_status})
        StatusStrip1.Location = New Point(126, 681)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Size = New Size(1138, 22)
        StatusStrip1.TabIndex = 2
        StatusStrip1.Text = "StatusStrip1"
        ' 
        ' navProgress_status
        ' 
        navProgress_status.BackColor = SystemColors.Control
        navProgress_status.ForeColor = SystemColors.ControlText
        navProgress_status.Name = "navProgress_status"
        navProgress_status.Size = New Size(71, 17)
        navProgress_status.Text = "navProgress"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        ClientSize = New Size(1264, 703)
        Controls.Add(webView)
        Controls.Add(StatusStrip1)
        Controls.Add(MenuStrip1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "PokéFarm Q"
        CType(webView, ComponentModel.ISupportInitialize).EndInit()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        trayIconStrip.ResumeLayout(False)
        StatusStrip1.ResumeLayout(False)
        StatusStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
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
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents trayIconStrip As ContextMenuStrip
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents QuitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Summons_tsm As ToolStripMenuItem
    Friend WithEvents Wiki_tsmi As ToolStripMenuItem
    Friend WithEvents Currencies_tsm As ToolStripMenuItem
    Friend WithEvents Credits_tsmu As ToolStripMenuItem
    Friend WithEvents Gold_tsmu As ToolStripMenuItem
    Friend WithEvents Zophan_tsmu As ToolStripMenuItem
    Friend WithEvents Boxes_tsm As ToolStripMenuItem
    Friend WithEvents Special_tsm As ToolStripMenuItem
    Friend WithEvents MCA_tsmi As ToolStripMenuItem
    Friend WithEvents MCAWeb_tsmi As ToolStripMenuItem
    Friend WithEvents MCAForum_tsmi As ToolStripMenuItem
    Friend WithEvents SCA_tsmi As ToolStripMenuItem
    Friend WithEvents SCAForum_tsmi As ToolStripMenuItem
    Friend WithEvents NearbyPlaces_tsm As ToolStripMenuItem
    Friend WithEvents berry_tsmi As ToolStripMenuItem
    Friend WithEvents fish_tsmi As ToolStripMenuItem
    Friend WithEvents trade_tsmi As ToolStripMenuItem
    Friend WithEvents egg_tsmi As ToolStripMenuItem
    Friend WithEvents contest_tsmi As ToolStripMenuItem
    Friend WithEvents dojo_tsmi As ToolStripMenuItem
    Friend WithEvents colress_tsmi As ToolStripMenuItem
    Friend WithEvents pGrove_tsmi As ToolStripMenuItem
    Friend WithEvents aether_tsmi As ToolStripMenuItem
    Friend WithEvents research_tsmi As ToolStripMenuItem
    Friend WithEvents cele_tsmi As ToolStripMenuItem
    Friend WithEvents Users_tmu As ToolStripMenuItem
    Friend WithEvents myUserProfle_tsmi As ToolStripMenuItem
    Friend WithEvents usersSep1_tsmi As ToolStripSeparator
    Friend WithEvents userSearch_tsmi As ToolStripMenuItem
    Friend WithEvents pokerus_tsmi As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents navProgress_status As ToolStripStatusLabel
    Friend WithEvents TrustedDomainsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Lab_tsm As ToolStripMenuItem
    Friend WithEvents Party_tsm As ToolStripMenuItem
    Friend WithEvents Shelter_tsm As ToolStripMenuItem
    Friend WithEvents Market_tsm As ToolStripMenuItem
    Friend WithEvents Daycare_tsm As ToolStripMenuItem
    Friend WithEvents Dex_tsm As ToolStripMenuItem
End Class
