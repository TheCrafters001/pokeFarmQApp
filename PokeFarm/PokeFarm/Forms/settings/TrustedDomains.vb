Imports System.IO
Imports System.Text

Public Class TrustedDomains
    Private Sub TrustedDomains_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Check if trusted domain file exists
        pageCheck.TrustedDomainCheck()

        ' Create an array with all files from %APPDATA%\TheCrafters001\PFQDA\trusted-domains.txt
        Dim domains As Array = File.ReadAllLines(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\TheCrafters001\PFQDA\trusted-domains.txt"), Encoding.UTF8)

        For Each i As String In domains
            trustedDomains_lst.Items.Add(i)
        Next
    End Sub

    Private Sub addDomain_btn_Click(sender As Object, e As EventArgs) Handles addDomain_btn.Click
        trustedDomains_lst.Items.Add(addDomain_txtBox.Text)
    End Sub

    Private Sub removeSelectedDomain_btn_Click(sender As Object, e As EventArgs) Handles removeSelectedDomain_btn.Click
        If trustedDomains_lst.SelectedItem = "" Then
            MessageBox.Show("Cannot remove item: No Item Selected")
        Else
            trustedDomains_lst.Items.Remove(trustedDomains_lst.SelectedItem)
        End If
    End Sub

    Private Sub save_btn_Click(sender As Object, e As EventArgs) Handles save_btn.Click
        Dim domains() As String = trustedDomains_lst.Items.OfType(Of String).ToArray

        File.WriteAllLines(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\TheCrafters001\PFQDA\trusted-domains.txt"), domains, Encoding.UTF8)

        Me.Close()

    End Sub
End Class