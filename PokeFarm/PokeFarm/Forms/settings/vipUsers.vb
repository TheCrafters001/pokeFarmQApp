Imports System.Configuration
Imports System.IO
Imports System.Text

Public Class vipUsers
    Private Sub vipUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Check if trusted domain file exists
        pageCheck.VIPUsersCheck()

        ' Create an array with all files from %APPDATA%\TheCrafters001\PFQDA\trusted-domains.txt
        Dim users As Array = File.ReadAllLines(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\TheCrafters001\PFQDA\vip-list.txt"), Encoding.UTF8)

        For Each i As String In users
            vipUsers_lst.Items.Add(i)
        Next
    End Sub

    Private Sub addUser_btn_Click(sender As Object, e As EventArgs) Handles addUser_btn.Click
        If vipUsers_lst.Items.Count = 50 Then
            MessageBox.Show("You cannot add more than 50 users.", "VIP Users", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            vipUsers_lst.Items.Add(addUser_txtBox.Text)
        End If
    End Sub

    Private Sub removeSelectedUser_btn_Click(sender As Object, e As EventArgs) Handles removeSelectedUser_btn.Click
        If vipUsers_lst.SelectedItem = "" Then
            MessageBox.Show("Cannot remove item: No Item Selected")
        ElseIf vipUsers_lst.SelectedItem = "" And vipUsers_lst.SelectedIndex = 0 Then
            vipUsers_lst.Items.Remove(vipUsers_lst.SelectedItem)
        Else
            vipUsers_lst.Items.Remove(vipUsers_lst.SelectedItem)
        End If
    End Sub

    Private Sub vipUserSaveList_btn_Click(sender As Object, e As EventArgs) Handles vipUserSaveList_btn.Click
        Dim users() As String = vipUsers_lst.Items.OfType(Of String).ToArray

        File.WriteAllLines(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\TheCrafters001\PFQDA\vip-list.txt"), users, Encoding.UTF8)

        MessageBox.Show("VIP List Saved!", "VIP Users", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub vipUserQuickClick_btn_Click(sender As Object, e As EventArgs) Handles vipUserQuickClick_btn.Click

        If vipUsers_lst.Items.Count = 0 Then
            MessageBox.Show("You have not added (or saved) anyone to the VIP Users list.", "VIP Users", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim VIPUsers As String = ""

            For Each User In vipUsers_lst.Items
                VIPUsers &= User.ToString.ToLower & ","
            Next

            VIPUsers = VIPUsers.Substring(0, VIPUsers.Length - 1)

            nav.web(nav.sc("users/" & VIPUsers))

            Me.Close()
        End If
    End Sub
End Class