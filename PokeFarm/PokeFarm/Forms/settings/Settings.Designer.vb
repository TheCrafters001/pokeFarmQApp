<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Settings
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
        ok_btn = New Button()
        cancel_btn = New Button()
        GroupBox1 = New GroupBox()
        updateCheck_btn = New Button()
        disableUpdate_rad = New RadioButton()
        enableUpdate_rad = New RadioButton()
        Label1 = New Label()
        GroupBox2 = New GroupBox()
        disableRunInBack_rad = New RadioButton()
        enableRunInBack_rad = New RadioButton()
        Label2 = New Label()
        migrateFolder = New FolderBrowserDialog()
        GroupBox3 = New GroupBox()
        menuBarPos_cmb = New ComboBox()
        menuBarPos_lbl = New Label()
        cacheReset_grp = New GroupBox()
        cacheReset_btn = New Button()
        cacheReset_lbl = New Label()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        cacheReset_grp.SuspendLayout()
        SuspendLayout()
        ' 
        ' ok_btn
        ' 
        ok_btn.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        ok_btn.Location = New Point(507, 297)
        ok_btn.Name = "ok_btn"
        ok_btn.Size = New Size(75, 23)
        ok_btn.TabIndex = 0
        ok_btn.Text = "&OK"
        ok_btn.UseVisualStyleBackColor = True
        ' 
        ' cancel_btn
        ' 
        cancel_btn.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        cancel_btn.Location = New Point(12, 297)
        cancel_btn.Name = "cancel_btn"
        cancel_btn.Size = New Size(75, 23)
        cancel_btn.TabIndex = 1
        cancel_btn.Text = "&Cancel"
        cancel_btn.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(updateCheck_btn)
        GroupBox1.Controls.Add(disableUpdate_rad)
        GroupBox1.Controls.Add(enableUpdate_rad)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Location = New Point(12, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(347, 96)
        GroupBox1.TabIndex = 2
        GroupBox1.TabStop = False
        GroupBox1.Text = "Automatic Updates"
        ' 
        ' updateCheck_btn
        ' 
        updateCheck_btn.Location = New Point(177, 37)
        updateCheck_btn.Name = "updateCheck_btn"
        updateCheck_btn.Size = New Size(164, 23)
        updateCheck_btn.TabIndex = 3
        updateCheck_btn.Text = "Check For Updates"
        updateCheck_btn.UseVisualStyleBackColor = True
        ' 
        ' disableUpdate_rad
        ' 
        disableUpdate_rad.AutoSize = True
        disableUpdate_rad.Checked = True
        disableUpdate_rad.Location = New Point(6, 62)
        disableUpdate_rad.Name = "disableUpdate_rad"
        disableUpdate_rad.Size = New Size(168, 19)
        disableUpdate_rad.TabIndex = 2
        disableUpdate_rad.TabStop = True
        disableUpdate_rad.Text = "Disable Automatic Updates"
        disableUpdate_rad.UseVisualStyleBackColor = True
        ' 
        ' enableUpdate_rad
        ' 
        enableUpdate_rad.AutoSize = True
        enableUpdate_rad.Location = New Point(6, 37)
        enableUpdate_rad.Name = "enableUpdate_rad"
        enableUpdate_rad.Size = New Size(165, 19)
        enableUpdate_rad.TabIndex = 1
        enableUpdate_rad.Text = "Enable Automatic Updates"
        enableUpdate_rad.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(6, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(267, 15)
        Label1.TabIndex = 0
        Label1.Text = "Do you want to check for updates Automatically?"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(disableRunInBack_rad)
        GroupBox2.Controls.Add(enableRunInBack_rad)
        GroupBox2.Controls.Add(Label2)
        GroupBox2.Location = New Point(12, 114)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(347, 96)
        GroupBox2.TabIndex = 4
        GroupBox2.TabStop = False
        GroupBox2.Text = "Minimize to System Tray"
        ' 
        ' disableRunInBack_rad
        ' 
        disableRunInBack_rad.AutoSize = True
        disableRunInBack_rad.Checked = True
        disableRunInBack_rad.Location = New Point(6, 62)
        disableRunInBack_rad.Name = "disableRunInBack_rad"
        disableRunInBack_rad.Size = New Size(79, 19)
        disableRunInBack_rad.TabIndex = 2
        disableRunInBack_rad.TabStop = True
        disableRunInBack_rad.Text = "Close App"
        disableRunInBack_rad.UseVisualStyleBackColor = True
        ' 
        ' enableRunInBack_rad
        ' 
        enableRunInBack_rad.AutoSize = True
        enableRunInBack_rad.Location = New Point(6, 37)
        enableRunInBack_rad.Name = "enableRunInBack_rad"
        enableRunInBack_rad.Size = New Size(153, 19)
        enableRunInBack_rad.TabIndex = 1
        enableRunInBack_rad.Text = "Minimize to System Tray"
        enableRunInBack_rad.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(6, 19)
        Label2.Name = "Label2"
        Label2.Size = New Size(289, 15)
        Label2.TabIndex = 0
        Label2.Text = "Do you want to minimize the app rather than close it?"
        ' 
        ' migrateFolder
        ' 
        migrateFolder.Description = "You will need to migrate your data. To do this, go to where PokeFarm Q Desktop App was installed, then look for a folder called PokeFarm.exe.WebView2"
        migrateFolder.UseDescriptionForTitle = True
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(menuBarPos_cmb)
        GroupBox3.Controls.Add(menuBarPos_lbl)
        GroupBox3.Location = New Point(12, 216)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(347, 74)
        GroupBox3.TabIndex = 5
        GroupBox3.TabStop = False
        GroupBox3.Text = "Menu Bar Position"
        ' 
        ' menuBarPos_cmb
        ' 
        menuBarPos_cmb.DropDownStyle = ComboBoxStyle.DropDownList
        menuBarPos_cmb.FormattingEnabled = True
        menuBarPos_cmb.Items.AddRange(New Object() {"Top", "Left", "Right", "Bottom"})
        menuBarPos_cmb.Location = New Point(6, 37)
        menuBarPos_cmb.Name = "menuBarPos_cmb"
        menuBarPos_cmb.Size = New Size(335, 23)
        menuBarPos_cmb.TabIndex = 1
        ' 
        ' menuBarPos_lbl
        ' 
        menuBarPos_lbl.AutoSize = True
        menuBarPos_lbl.Location = New Point(6, 19)
        menuBarPos_lbl.Name = "menuBarPos_lbl"
        menuBarPos_lbl.Size = New Size(272, 15)
        menuBarPos_lbl.TabIndex = 0
        menuBarPos_lbl.Text = "Please choose a position you want your menu bar."
        ' 
        ' cacheReset_grp
        ' 
        cacheReset_grp.Controls.Add(cacheReset_btn)
        cacheReset_grp.Controls.Add(cacheReset_lbl)
        cacheReset_grp.Location = New Point(365, 12)
        cacheReset_grp.Name = "cacheReset_grp"
        cacheReset_grp.Size = New Size(222, 96)
        cacheReset_grp.TabIndex = 6
        cacheReset_grp.TabStop = False
        cacheReset_grp.Text = "Cache"
        ' 
        ' cacheReset_btn
        ' 
        cacheReset_btn.Location = New Point(6, 60)
        cacheReset_btn.Name = "cacheReset_btn"
        cacheReset_btn.Size = New Size(210, 23)
        cacheReset_btn.TabIndex = 1
        cacheReset_btn.Text = "Reset Cache"
        cacheReset_btn.UseVisualStyleBackColor = True
        ' 
        ' cacheReset_lbl
        ' 
        cacheReset_lbl.Location = New Point(6, 19)
        cacheReset_lbl.Name = "cacheReset_lbl"
        cacheReset_lbl.Size = New Size(210, 38)
        cacheReset_lbl.TabIndex = 0
        cacheReset_lbl.Text = "Reset any cached data? This will log you out and remove any active scripts."
        ' 
        ' Settings
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(594, 332)
        Controls.Add(cacheReset_grp)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(cancel_btn)
        Controls.Add(ok_btn)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        MinimizeBox = False
        Name = "Settings"
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "Settings"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        cacheReset_grp.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents ok_btn As Button
    Friend WithEvents cancel_btn As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents disableUpdate_rad As RadioButton
    Friend WithEvents enableUpdate_rad As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents updateCheck_btn As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents disableRunInBack_rad As RadioButton
    Friend WithEvents enableRunInBack_rad As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents migrateFolder As FolderBrowserDialog
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents menuBarPos_cmb As ComboBox
    Friend WithEvents menuBarPos_lbl As Label
    Friend WithEvents cacheReset_grp As GroupBox
    Friend WithEvents cacheReset_lbl As Label
    Friend WithEvents cacheReset_btn As Button
End Class
