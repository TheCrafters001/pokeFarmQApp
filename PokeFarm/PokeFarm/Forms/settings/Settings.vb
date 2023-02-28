Imports AutoUpdaterDotNET


Public Class Settings
    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Run Settings Check
        If My.Settings.autoUpdates = False Then
            disableUpdate_rad.Checked = True
            enableUpdate_rad.Checked = False

        ElseIf My.Settings.autoUpdates = True Then
            disableUpdate_rad.Checked = False
            enableUpdate_rad.Checked = True

        End If

        If My.Settings.runInBackground = False Then
            disableRunInBack_rad.Checked = True
            enableRunInBack_rad.Checked = False

        ElseIf My.Settings.runInBackground = True Then
            disableRunInBack_rad.Checked = False
            enableRunInBack_rad.Checked = True

        End If
    End Sub

    Private Sub ok_btn_Click(sender As Object, e As EventArgs) Handles ok_btn.Click

        'Save autoUpdate settings
        If disableUpdate_rad.Checked = True And enableUpdate_rad.Checked = False Then
            My.Settings.autoUpdates = False
            My.Settings.Save()

        ElseIf disableUpdate_rad.Checked = False And enableUpdate_rad.Checked = True Then
            My.Settings.autoUpdates = True
            My.Settings.Save()

        End If

        'Save runInBackground settings
        If disableRunInBack_rad.Checked = True And enableRunInBack_rad.Checked = False Then
            My.Settings.runInBackground = False
            My.Settings.Save()

        ElseIf disableRunInBack_rad.Checked = False And enableRunInBack_rad.Checked = True Then
            My.Settings.runInBackground = True
            My.Settings.Save()

        End If

        Me.Close()
    End Sub

    Private Sub cancel_btn_Click(sender As Object, e As EventArgs) Handles cancel_btn.Click
        Me.Close()
    End Sub

    Private Sub updateCheck_btn_Click(sender As Object, e As EventArgs) Handles updateCheck_btn.Click
        AutoUpdater.ReportErrors = True
        AutoUpdater.LetUserSelectRemindLater = False
        AutoUpdater.DownloadPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\Temp\pokefarm\"
        AutoUpdater.Start("https://github.com/TheCrafters001/pokeFarmQApp/releases/latest/download/update.xml")
    End Sub
End Class