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
        Me.webView = New Microsoft.Web.WebView2.WinForms.WebView2()
        CType(Me.webView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'webView
        '
        Me.webView.AllowExternalDrop = True
        Me.webView.CreationProperties = Nothing
        Me.webView.DefaultBackgroundColor = System.Drawing.Color.Black
        Me.webView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.webView.Location = New System.Drawing.Point(0, 0)
        Me.webView.Name = "webView"
        Me.webView.Size = New System.Drawing.Size(1264, 681)
        Me.webView.Source = New System.Uri("https://pokefarm.com/", System.UriKind.Absolute)
        Me.webView.TabIndex = 0
        Me.webView.ZoomFactor = 1.0R
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.webView)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PokeFarm Q"
        CType(Me.webView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents webView As Microsoft.Web.WebView2.WinForms.WebView2
End Class
