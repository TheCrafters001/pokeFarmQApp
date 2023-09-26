Imports System.IO
Imports System.Text

Public Class vipUsers
    Private Sub vipUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Check if trusted domain file exists
        pageCheck.TrustedDomainCheck()

        ' Create an array with all files from %APPDATA%\TheCrafters001\PFQDA\trusted-domains.txt
        Dim domains As Array = File.ReadAllLines(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\TheCrafters001\PFQDA\trusted-domains.txt"), Encoding.UTF8)

        For Each i As String In domains
            vipUsers_lst.Items.Add(i)
        Next
    End Sub

    Private Sub addUser_btn_Click(sender As Object, e As EventArgs) Handles addUser_btn.Click
        vipUsers_lst.Items.Add(addUser_txtBox.Text)
    End Sub

    Private Sub removeSelectedDomain_btn_Click(sender As Object, e As EventArgs) Handles removeSelectedUser_btn.Click
        If vipUsers_lst.SelectedItem = "" Then
            MessageBox.Show("Cannot remove item: No Item Selected")
        Else
            If vipUsers_lst.SelectedItem = "pokefarm.com" Or
                vipUsers_lst.SelectedItem = "pokefarm.wiki" Or
                vipUsers_lst.SelectedItem = "pokefarm.wiki" Or
                vipUsers_lst.SelectedItem = "about:blank" Or
                vipUsers_lst.SelectedItem = "checkout.stripe.com" Then

                Dim diagResult As DialogResult = MessageBox.Show("The selected domain cannot be removed, because it is essential for this app to work.", "Hold it!", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Else
                vipUsers_lst.Items.Remove(vipUsers_lst.SelectedItem)
            End If
        End If
    End Sub

    Private Sub save_btn_Click(sender As Object, e As EventArgs) Handles save_btn.Click
        Dim domains() As String = vipUsers_lst.Items.OfType(Of String).ToArray

        File.WriteAllLines(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\TheCrafters001\PFQDA\vip-list.txt"), domains, Encoding.UTF8)

        Me.Close()

    End Sub
End Class