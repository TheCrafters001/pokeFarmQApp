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
        Me.disableUpdate_rad = New System.Windows.Forms.RadioButton()
        Me.enableUpdate_rad = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.updateCheck_btn = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ok_btn
        '
        Me.ok_btn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ok_btn.Location = New System.Drawing.Point(284, 187)
        Me.ok_btn.Name = "ok_btn"
        Me.ok_btn.Size = New System.Drawing.Size(75, 23)
        Me.ok_btn.TabIndex = 0
        Me.ok_btn.Text = "&OK"
        Me.ok_btn.UseVisualStyleBackColor = True
        '
        'cancel_btn
        '
        Me.cancel_btn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cancel_btn.Location = New System.Drawing.Point(12, 187)
        Me.cancel_btn.Name = "cancel_btn"
        Me.cancel_btn.Size = New System.Drawing.Size(75, 23)
        Me.cancel_btn.TabIndex = 1
        Me.cancel_btn.Text = "&Cancel"
        Me.cancel_btn.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        'updateCheck_btn
        '
        Me.updateCheck_btn.Location = New System.Drawing.Point(177, 37)
        Me.updateCheck_btn.Name = "updateCheck_btn"
        Me.updateCheck_btn.Size = New System.Drawing.Size(164, 23)
        Me.updateCheck_btn.TabIndex = 3
        Me.updateCheck_btn.Text = "Check For Updates"
        Me.updateCheck_btn.UseVisualStyleBackColor = True
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(371, 222)
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
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ok_btn As Button
    Friend WithEvents cancel_btn As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents disableUpdate_rad As RadioButton
    Friend WithEvents enableUpdate_rad As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents updateCheck_btn As Button
End Class
