<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class about
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(about))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.title_lbl = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.thirdPartyLicenses_lnk = New System.Windows.Forms.LinkLabel()
        Me.msEdge_lbl = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PokeFarm.My.Resources.Resources.index_2
        Me.PictureBox1.Location = New System.Drawing.Point(499, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(45, 45)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'title_lbl
        '
        Me.title_lbl.AutoSize = True
        Me.title_lbl.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.title_lbl.Location = New System.Drawing.Point(12, 9)
        Me.title_lbl.Name = "title_lbl"
        Me.title_lbl.Size = New System.Drawing.Size(305, 32)
        Me.title_lbl.TabIndex = 1
        Me.title_lbl.Text = "PokéFarm Q Desktop App"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(12, 44)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(481, 204)
        Me.RichTextBox1.TabIndex = 2
        Me.RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        '
        'thirdPartyLicenses_lnk
        '
        Me.thirdPartyLicenses_lnk.AutoSize = True
        Me.thirdPartyLicenses_lnk.Location = New System.Drawing.Point(12, 251)
        Me.thirdPartyLicenses_lnk.Name = "thirdPartyLicenses_lnk"
        Me.thirdPartyLicenses_lnk.Size = New System.Drawing.Size(111, 15)
        Me.thirdPartyLicenses_lnk.TabIndex = 3
        Me.thirdPartyLicenses_lnk.TabStop = True
        Me.thirdPartyLicenses_lnk.Text = "Third Party Licenses"
        '
        'msEdge_lbl
        '
        Me.msEdge_lbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.msEdge_lbl.Location = New System.Drawing.Point(129, 251)
        Me.msEdge_lbl.Name = "msEdge_lbl"
        Me.msEdge_lbl.Size = New System.Drawing.Size(415, 23)
        Me.msEdge_lbl.TabIndex = 4
        Me.msEdge_lbl.Text = "MS Edge Version: some.really.long.number"
        Me.msEdge_lbl.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'about
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(556, 274)
        Me.Controls.Add(Me.msEdge_lbl)
        Me.Controls.Add(Me.thirdPartyLicenses_lnk)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.title_lbl)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "about"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "About"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents title_lbl As Label
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents thirdPartyLicenses_lnk As LinkLabel
    Friend WithEvents msEdge_lbl As Label
End Class
