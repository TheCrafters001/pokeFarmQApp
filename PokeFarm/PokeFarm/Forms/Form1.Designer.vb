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
        CType(webView, ComponentModel.ISupportInitialize).BeginInit()
        trayIconStrip.SuspendLayout()
        SuspendLayout()
        ' 
        ' webView
        ' 
        webView.AllowExternalDrop = True
        webView.CreationProperties = Nothing
        webView.DefaultBackgroundColor = Color.Black
        webView.Dock = DockStyle.Fill
        webView.Location = New Point(0, 0)
        webView.Name = "webView"
        webView.Size = New Size(1264, 703)
        webView.TabIndex = 0
        webView.ZoomFactor = 1R
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
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        ClientSize = New Size(1264, 703)
        Controls.Add(webView)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "PokéFarm Q"
        CType(webView, ComponentModel.ISupportInitialize).EndInit()
        trayIconStrip.ResumeLayout(False)
        ResumeLayout(False)
    End Sub
    Friend WithEvents webView As Microsoft.Web.WebView2.WinForms.WebView2
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
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents trayIconStrip As ContextMenuStrip
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents QuitToolStripMenuItem As ToolStripMenuItem
End Class
