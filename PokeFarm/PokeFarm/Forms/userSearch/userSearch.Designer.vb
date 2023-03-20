<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class userSearch
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
        userName_lbl = New Label()
        userName_txtBox = New TextBox()
        search_btn = New Button()
        cancel_btn = New Button()
        SuspendLayout()
        ' 
        ' userName_lbl
        ' 
        userName_lbl.AutoSize = True
        userName_lbl.Location = New Point(12, 9)
        userName_lbl.Name = "userName_lbl"
        userName_lbl.Size = New Size(60, 15)
        userName_lbl.TabIndex = 0
        userName_lbl.Text = "Username"' 
        ' userName_txtBox
        ' 
        userName_txtBox.Location = New Point(12, 27)
        userName_txtBox.Name = "userName_txtBox"
        userName_txtBox.PlaceholderText = "Niet"
        userName_txtBox.Size = New Size(319, 23)
        userName_txtBox.TabIndex = 1
        ' 
        ' search_btn
        ' 
        search_btn.Location = New Point(256, 57)
        search_btn.Name = "search_btn"
        search_btn.Size = New Size(75, 23)
        search_btn.TabIndex = 2
        search_btn.Text = "Search"
        search_btn.UseVisualStyleBackColor = True
        ' 
        ' cancel_btn
        ' 
        cancel_btn.Location = New Point(12, 57)
        cancel_btn.Name = "cancel_btn"
        cancel_btn.Size = New Size(75, 23)
        cancel_btn.TabIndex = 3
        cancel_btn.Text = "Cancel"
        cancel_btn.UseVisualStyleBackColor = True
        ' 
        ' userSearch
        ' 
        AcceptButton = search_btn
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        CancelButton = cancel_btn
        ClientSize = New Size(343, 92)
        ControlBox = False
        Controls.Add(cancel_btn)
        Controls.Add(search_btn)
        Controls.Add(userName_txtBox)
        Controls.Add(userName_lbl)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "userSearch"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "Search Profile"
        TopMost = True
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents userName_lbl As Label
    Friend WithEvents userName_txtBox As TextBox
    Friend WithEvents search_btn As Button
    Friend WithEvents cancel_btn As Button
End Class
