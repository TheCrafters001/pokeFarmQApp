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
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShortcutsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1264, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ShortcutsToolStripMenuItem
        '
        Me.ShortcutsToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ShortcutsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BasicToolStripMenuItem})
        Me.ShortcutsToolStripMenuItem.Name = "ShortcutsToolStripMenuItem"
        Me.ShortcutsToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.ShortcutsToolStripMenuItem.Text = "Shortcuts"
        '
        'BasicToolStripMenuItem
        '
        Me.BasicToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LabToolStripMenuItem, Me.PartyToolStripMenuItem, Me.FarmToolStripMenuItem, Me.ShelterToolStripMenuItem, Me.MarketToolStripMenuItem, Me.DaycareToolStripMenuItem, Me.PokedexToolStripMenuItem})
        Me.BasicToolStripMenuItem.Name = "BasicToolStripMenuItem"
        Me.BasicToolStripMenuItem.Size = New System.Drawing.Size(101, 22)
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
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
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
End Class
