Imports System.Configuration
Imports System.IO
Imports System.Text

Public Class vipUsers
    Private Sub vipUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Check if VIP List file exists
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

    Private Sub exportList_btn_Click(sender As Object, e As EventArgs) Handles exportList_btn.Click
        ' Check if VIP List file exists
        ' Run this just so it doesn't conflit with anything.
        pageCheck.VIPUsersCheck()

        ' Get Save File Dialog
        SaveFileDialog1.Filter = "Text File (*.txt)|*.txt"
        Dim DiaResult As DialogResult = SaveFileDialog1.ShowDialog()

        If DiaResult = DialogResult.OK Then
            Try
                File.Copy(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\TheCrafters001\PFQDA\vip-list.txt"), SaveFileDialog1.FileName)
                MessageBox.Show("Export Successful!", "Export List", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("There was a problem exporting your VIP List!" & vbCrLf & vbCrLf & ex.Message)
            End Try
        End If

    End Sub

    Private Sub importList_btn_Click(sender As Object, e As EventArgs) Handles importList_btn.Click
        ' Get Open File Dialog
        OpenFileDialog1.Filter = "Text File (*.txt)|*.txt"
        Dim DiaResult As DialogResult = OpenFileDialog1.ShowDialog()

        If DiaResult = DialogResult.OK Then
            ' Because we are importing, make sure you ask for overwrite,
            ' as I do not actually read the file, just copies it.
            ' This may get changed later.
            Dim overwriteWarning As DialogResult = MessageBox.Show("Are you sure you want to import the list? It will overwrite your existing list.", "Import List", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
            If overwriteWarning = DialogResult.Yes Then
                Try
                    File.Copy(OpenFileDialog1.FileName, Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\TheCrafters001\PFQDA\vip-list.txt"), True)
                    MessageBox.Show("Import Successful!", "Import List", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                Catch ex As Exception
                    MessageBox.Show("There was a problem importing your VIP List!" & vbCrLf & vbCrLf & ex.Message)
                End Try

            End If
        End If
    End Sub
End Class