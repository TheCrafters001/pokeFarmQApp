Imports System.IO
Imports System.Text
Imports PFQDALog

Public Class TrustedDomains
    Private Sub TrustedDomains_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Check if trusted domain file exists
        pageCheck.TrustedDomainCheck()

        ' Create an array with all files from %APPDATA%\TheCrafters001\PFQDA\trusted-domains.txt
        Dim domains As Array = File.ReadAllLines(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\TheCrafters001\PFQDA\trusted-domains.txt"), Encoding.UTF8)

        For Each i As String In domains
            trustedDomains_lst.Items.Add(i)
            Log.CreateLog("Trusted Domain: " & i)
        Next
    End Sub

    Private Sub addDomain_btn_Click(sender As Object, e As EventArgs) Handles addDomain_btn.Click
        trustedDomains_lst.Items.Add(addDomain_txtBox.Text)
    End Sub

    Private Sub removeSelectedDomain_btn_Click(sender As Object, e As EventArgs) Handles removeSelectedDomain_btn.Click
        If trustedDomains_lst.SelectedItem = "" Then
            MessageBox.Show("Cannot remove item: No Item Selected")
        Else
            If trustedDomains_lst.SelectedItem = "pokefarm.com" Or
                trustedDomains_lst.SelectedItem = "pokefarm.wiki" Or
                trustedDomains_lst.SelectedItem = "pokefarm.wiki" Or
                trustedDomains_lst.SelectedItem = "about:blank" Or
                trustedDomains_lst.SelectedItem = "checkout.stripe.com" Then

                Dim diagResult As DialogResult = MessageBox.Show("The selected domain cannot be removed, because it is essential for this app to work.", "Hold it!", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Else
                Log.CreateLog("Trusted Domain Removed: " & trustedDomains_lst.SelectedItem)
                trustedDomains_lst.Items.Remove(trustedDomains_lst.SelectedItem)
            End If
        End If
    End Sub

    Private Sub save_btn_Click(sender As Object, e As EventArgs) Handles save_btn.Click
        Dim domains() As String = trustedDomains_lst.Items.OfType(Of String).ToArray

        File.WriteAllLines(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\TheCrafters001\PFQDA\trusted-domains.txt"), domains, Encoding.UTF8)

        Me.Close()

    End Sub
End Class