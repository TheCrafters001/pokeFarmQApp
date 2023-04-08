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
        domainControls.Location = New Point(12, 217)
        domainControls.Name = "domainControls"
        domainControls.Size = New Size(318, 90)
        domainControls.TabIndex = 1
        domainControls.TabStop = False
        domainControls.Text = "Trusted Domain Controls"
        ' 
        ' TrustedDomains
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(342, 319)
        Controls.Add(domainControls)
        Controls.Add(trustedDomains_lst)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        MinimizeBox = False
        Name = "TrustedDomains"
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "TrustedDomains"
        ResumeLayout(False)
    End Sub

    Friend WithEvents trustedDomains_lst As ListBox
    Friend WithEvents domainControls As GroupBox
End Class
