<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class vipUsers
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
        domainControls = New GroupBox()
        vipUserSaveList_btn = New Button()
        vipUserQuickClick_btn = New Button()
        removeSelectedUser_btn = New Button()
        addUser_txtBox = New TextBox()
        addUser_btn = New Button()
        vipUsers_lst = New ListBox()
        vipUser_lbl = New Label()
        domainControls.SuspendLayout()
        SuspendLayout()
        ' 
        ' domainControls
        ' 
        domainControls.Controls.Add(vipUserSaveList_btn)
        domainControls.Controls.Add(vipUserQuickClick_btn)
        domainControls.Controls.Add(removeSelectedUser_btn)
        domainControls.Controls.Add(addUser_txtBox)
        domainControls.Controls.Add(addUser_btn)
        domainControls.Location = New Point(12, 217)
        domainControls.Name = "domainControls"
        domainControls.Size = New Size(318, 81)
        domainControls.TabIndex = 3
        domainControls.TabStop = False
        domainControls.Text = "VIP Users Control"
        ' 
        ' vipUserSaveList_btn
        ' 
        vipUserSaveList_btn.Location = New Point(237, 52)
        vipUserSaveList_btn.Name = "vipUserSaveList_btn"
        vipUserSaveList_btn.Size = New Size(75, 23)
        vipUserSaveList_btn.TabIndex = 5
        vipUserSaveList_btn.Text = "Save List"
        vipUserSaveList_btn.UseVisualStyleBackColor = True
        ' 
        ' vipUserQuickClick_btn
        ' 
        vipUserQuickClick_btn.Location = New Point(124, 51)
        vipUserQuickClick_btn.Name = "vipUserQuickClick_btn"
        vipUserQuickClick_btn.Size = New Size(107, 23)
        vipUserQuickClick_btn.TabIndex = 4
        vipUserQuickClick_btn.Text = "Quick Click"
        vipUserQuickClick_btn.UseVisualStyleBackColor = True
        ' 
        ' removeSelectedUser_btn
        ' 
        removeSelectedUser_btn.Location = New Point(6, 51)
        removeSelectedUser_btn.Name = "removeSelectedUser_btn"
        removeSelectedUser_btn.Size = New Size(112, 23)
        removeSelectedUser_btn.TabIndex = 2
        removeSelectedUser_btn.Text = "Remove Selected"
        removeSelectedUser_btn.UseVisualStyleBackColor = True
        ' 
        ' addUser_txtBox
        ' 
        addUser_txtBox.Location = New Point(6, 22)
        addUser_txtBox.Name = "addUser_txtBox"
        addUser_txtBox.PlaceholderText = "Username"
        addUser_txtBox.Size = New Size(258, 23)
        addUser_txtBox.TabIndex = 1
        ' 
        ' addUser_btn
        ' 
        addUser_btn.Location = New Point(270, 22)
        addUser_btn.Name = "addUser_btn"
        addUser_btn.Size = New Size(42, 23)
        addUser_btn.TabIndex = 0
        addUser_btn.Text = "Add"
        addUser_btn.UseVisualStyleBackColor = True
        ' 
        ' vipUsers_lst
        ' 
        vipUsers_lst.FormattingEnabled = True
        vipUsers_lst.ItemHeight = 15
        vipUsers_lst.Location = New Point(12, 12)
        vipUsers_lst.Name = "vipUsers_lst"
        vipUsers_lst.Size = New Size(318, 199)
        vipUsers_lst.TabIndex = 2
        ' 
        ' vipUser_lbl
        ' 
        vipUser_lbl.Location = New Point(12, 301)
        vipUser_lbl.Name = "vipUser_lbl"
        vipUser_lbl.Size = New Size(318, 47)
        vipUser_lbl.TabIndex = 4
        vipUser_lbl.Text = "Click the 'Quick Click' option in order to open everyone's party at once. You can only add 50 users due to a limitation of PokéFarm. This does not pull your VIP list on the site."
        ' 
        ' vipUsers
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(342, 357)
        Controls.Add(vipUser_lbl)
        Controls.Add(domainControls)
        Controls.Add(vipUsers_lst)
        Name = "vipUsers"
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "VIP Users"
        domainControls.ResumeLayout(False)
        domainControls.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents domainControls As GroupBox
    Friend WithEvents save_btn As Button
    Friend WithEvents removeSelectedUser_btn As Button
    Friend WithEvents addUser_txtBox As TextBox
    Friend WithEvents addUser_btn As Button
    Friend WithEvents vipUsers_lst As ListBox
    Friend WithEvents vipUserQuickClick_btn As Button
    Friend WithEvents vipUser_lbl As Label
    Friend WithEvents vipUserSaveList_btn As Button
End Class
