<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TrustedDomains
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
        trustedDomains_lst = New ListBox()
        domainControls = New GroupBox()
        save_btn = New Button()
        removeSelectedDomain_btn = New Button()
        addDomain_txtBox = New TextBox()
        addDomain_btn = New Button()
        domainControls.SuspendLayout()
        SuspendLayout()
        ' 
        ' trustedDomains_lst
        ' 
        trustedDomains_lst.FormattingEnabled = True
        trustedDomains_lst.ItemHeight = 15
        trustedDomains_lst.Location = New Point(12, 12)
        trustedDomains_lst.Name = "trustedDomains_lst"
        trustedDomains_lst.Size = New Size(318, 199)
        trustedDomains_lst.TabIndex = 0
        ' 
        ' domainControls
        ' 
        domainControls.Controls.Add(save_btn)
        domainControls.Controls.Add(removeSelectedDomain_btn)
        domainControls.Controls.Add(addDomain_txtBox)
        domainControls.Controls.Add(addDomain_btn)
        domainControls.Location = New Point(12, 217)
        domainControls.Name = "domainControls"
        domainControls.Size = New Size(318, 81)
        domainControls.TabIndex = 1
        domainControls.TabStop = False
        domainControls.Text = "Trusted Domain Controls"
        ' 
        ' save_btn
        ' 
        save_btn.Location = New Point(237, 51)
        save_btn.Name = "save_btn"
        save_btn.Size = New Size(75, 23)
        save_btn.TabIndex = 3
        save_btn.Text = "Save"
        save_btn.UseVisualStyleBackColor = True
        ' 
        ' removeSelectedDomain_btn
        ' 
        removeSelectedDomain_btn.Location = New Point(6, 51)
        removeSelectedDomain_btn.Name = "removeSelectedDomain_btn"
        removeSelectedDomain_btn.Size = New Size(112, 23)
        removeSelectedDomain_btn.TabIndex = 2
        removeSelectedDomain_btn.Text = "Remove Selected"
        removeSelectedDomain_btn.UseVisualStyleBackColor = True
        ' 
        ' addDomain_txtBox
        ' 
        addDomain_txtBox.Location = New Point(6, 22)
        addDomain_txtBox.Name = "addDomain_txtBox"
        addDomain_txtBox.PlaceholderText = "google.com"
        addDomain_txtBox.Size = New Size(258, 23)
        addDomain_txtBox.TabIndex = 1
        ' 
        ' addDomain_btn
        ' 
        addDomain_btn.Location = New Point(270, 22)
        addDomain_btn.Name = "addDomain_btn"
        addDomain_btn.Size = New Size(42, 23)
        addDomain_btn.TabIndex = 0
        addDomain_btn.Text = "Add"
        addDomain_btn.UseVisualStyleBackColor = True
        ' 
        ' TrustedDomains
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(342, 308)
        Controls.Add(domainControls)
        Controls.Add(trustedDomains_lst)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        MinimizeBox = False
        Name = "TrustedDomains"
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "TrustedDomains"
        domainControls.ResumeLayout(False)
        domainControls.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents trustedDomains_lst As ListBox
    Friend WithEvents domainControls As GroupBox
    Friend WithEvents addDomain_txtBox As TextBox
    Friend WithEvents addDomain_btn As Button
    Friend WithEvents save_btn As Button
    Friend WithEvents removeSelectedDomain_btn As Button
End Class
