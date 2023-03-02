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
        Me.ok_btn = New System.Windows.Forms.Button()
        Me.cancel_btn = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.updateCheck_btn = New System.Windows.Forms.Button()
        Me.disableUpdate_rad = New System.Windows.Forms.RadioButton()
        Me.enableUpdate_rad = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.disableRunInBack_rad = New System.Windows.Forms.RadioButton()
        Me.enableRunInBack_rad = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.migrateFolder = New System.Windows.Forms.FolderBrowserDialog()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ok_btn
        '
        Me.ok_btn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ok_btn.Location = New System.Drawing.Point(284, 217)
        Me.ok_btn.Name = "ok_btn"
        Me.ok_btn.Size = New System.Drawing.Size(75, 23)
        Me.ok_btn.TabIndex = 0
        Me.ok_btn.Text = "&OK"
        Me.ok_btn.UseVisualStyleBackColor = True
        '
        'cancel_btn
        '
        Me.cancel_btn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cancel_btn.Location = New System.Drawing.Point(12, 217)
        Me.cancel_btn.Name = "cancel_btn"
        Me.cancel_btn.Size = New System.Drawing.Size(75, 23)
        Me.cancel_btn.TabIndex = 1
        Me.cancel_btn.Text = "&Cancel"
        Me.cancel_btn.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.updateCheck_btn)
        Me.GroupBox1.Controls.Add(Me.disableUpdate_rad)
        Me.GroupBox1.Controls.Add(Me.enableUpdate_rad)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(347, 96)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Automatic Updates"
        '
        'updateCheck_btn
        '
        Me.updateCheck_btn.Location = New System.Drawing.Point(177, 37)
        Me.updateCheck_btn.Name = "updateCheck_btn"
        Me.updateCheck_btn.Size = New System.Drawing.Size(164, 23)
        Me.updateCheck_btn.TabIndex = 3
        Me.updateCheck_btn.Text = "Check For Updates"
        Me.updateCheck_btn.UseVisualStyleBackColor = True
        '
        'disableUpdate_rad
        '
        Me.disableUpdate_rad.AutoSize = True
        Me.disableUpdate_rad.Checked = True
        Me.disableUpdate_rad.Location = New System.Drawing.Point(6, 62)
        Me.disableUpdate_rad.Name = "disableUpdate_rad"
        Me.disableUpdate_rad.Size = New System.Drawing.Size(168, 19)
        Me.disableUpdate_rad.TabIndex = 2
        Me.disableUpdate_rad.TabStop = True
        Me.disableUpdate_rad.Text = "Disable Automatic Updates"
        Me.disableUpdate_rad.UseVisualStyleBackColor = True
        '
        'enableUpdate_rad
        '
        Me.enableUpdate_rad.AutoSize = True
        Me.enableUpdate_rad.Location = New System.Drawing.Point(6, 37)
        Me.enableUpdate_rad.Name = "enableUpdate_rad"
        Me.enableUpdate_rad.Size = New System.Drawing.Size(165, 19)
        Me.enableUpdate_rad.TabIndex = 1
        Me.enableUpdate_rad.Text = "Enable Automatic Updates"
        Me.enableUpdate_rad.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(267, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Do you want to check for updates Automatically?"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.disableRunInBack_rad)
        Me.GroupBox2.Controls.Add(Me.enableRunInBack_rad)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 114)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(347, 96)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Minimize to System Tray"
        '
        'disableRunInBack_rad
        '
        Me.disableRunInBack_rad.AutoSize = True
        Me.disableRunInBack_rad.Checked = True
        Me.disableRunInBack_rad.Location = New System.Drawing.Point(6, 62)
        Me.disableRunInBack_rad.Name = "disableRunInBack_rad"
        Me.disableRunInBack_rad.Size = New System.Drawing.Size(79, 19)
        Me.disableRunInBack_rad.TabIndex = 2
        Me.disableRunInBack_rad.TabStop = True
        Me.disableRunInBack_rad.Text = "Close App"
        Me.disableRunInBack_rad.UseVisualStyleBackColor = True
        '
        'enableRunInBack_rad
        '
        Me.enableRunInBack_rad.AutoSize = True
        Me.enableRunInBack_rad.Location = New System.Drawing.Point(6, 37)
        Me.enableRunInBack_rad.Name = "enableRunInBack_rad"
        Me.enableRunInBack_rad.Size = New System.Drawing.Size(153, 19)
        Me.enableRunInBack_rad.TabIndex = 1
        Me.enableRunInBack_rad.Text = "Minimize to System Tray"
        Me.enableRunInBack_rad.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(289, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Do you want to minimize the app rather than close it?"
        '
        'migrateFolder
        '
        Me.migrateFolder.Description = "You will need to migrate your data. To do this, go to where PokeFarm Q Desktop Ap" &
    "p was installed, then look for a folder called PokeFarm.exe.WebView2"
        Me.migrateFolder.UseDescriptionForTitle = True
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(371, 252)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cancel_btn)
        Me.Controls.Add(Me.ok_btn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Settings"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Settings"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

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
End Class
