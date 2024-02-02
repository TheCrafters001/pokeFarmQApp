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
        Label1 = New Label()
        Label2 = New Label()
        resetCache_btn = New Button()
        cancel_btn = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(124, 25)
        Label1.TabIndex = 0
        Label1.Text = "Reset Cache?"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label2.Location = New Point(12, 34)
        Label2.Name = "Label2"
        Label2.Size = New Size(252, 80)
        Label2.TabIndex = 1
        Label2.Text = resources.GetString("Label2.Text")
        ' 
        ' resetCache_btn
        ' 
        resetCache_btn.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        resetCache_btn.Location = New Point(12, 121)
        resetCache_btn.Name = "resetCache_btn"
        resetCache_btn.Size = New Size(84, 23)
        resetCache_btn.TabIndex = 2
        resetCache_btn.Text = "Reset Cache"
        resetCache_btn.UseVisualStyleBackColor = True
        ' 
        ' cancel_btn
        ' 
        cancel_btn.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        cancel_btn.Location = New Point(189, 121)
        cancel_btn.Name = "cancel_btn"
        cancel_btn.Size = New Size(75, 23)
        cancel_btn.TabIndex = 3
        cancel_btn.Text = "Cancel"
        cancel_btn.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        CancelButton = cancel_btn
        ClientSize = New Size(276, 156)
        Controls.Add(cancel_btn)
        Controls.Add(resetCache_btn)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "PokéFarm Q"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents resetCache_btn As Button
    Friend WithEvents cancel_btn As Button
End Class
