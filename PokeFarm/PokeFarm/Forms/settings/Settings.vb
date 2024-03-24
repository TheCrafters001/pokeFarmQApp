Imports System.IO
Imports AutoUpdaterDotNET
Imports PFQDALog

Public Class Settings
    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Run Settings Check
        ' Check Auto Update Settings
        If My.Settings.autoUpdates = False Then
            disableUpdate_rad.Checked = True
            enableUpdate_rad.Checked = False

        ElseIf My.Settings.autoUpdates = True Then
            disableUpdate_rad.Checked = False
            enableUpdate_rad.Checked = True

        End If

        ' Check run in background settings
        If My.Settings.runInBackground = False Then
            disableRunInBack_rad.Checked = True
            enableRunInBack_rad.Checked = False

        ElseIf My.Settings.runInBackground = True Then
            disableRunInBack_rad.Checked = False
            enableRunInBack_rad.Checked = True

        End If

        ' Check status strip settings
        If My.Settings.statusBarStatus = False Then
            statusBar_Dis_rad.Checked = True
            statusBar_Ena_rad.Checked = False

        ElseIf My.Settings.autoUpdates = True Then
            statusBar_Dis_rad.Checked = False
            statusBar_Ena_rad.Checked = True

        End If

        ' Get MenuBar Pos
        menuBarPos_cmb.SelectedIndex = My.Settings.menuBarPos

        ' Check Branch
        updateBranch_cmb.SelectedIndex = My.Settings.UpdateBranch

        Log.CreateLog("Auto Updates: " & My.Settings.autoUpdates)
        Log.CreateLog("Run in Background: " & My.Settings.runInBackground)
        Log.CreateLog("Status Strip: " & My.Settings.statusBarStatus)
        Log.CreateLog("Menu Bar: " & My.Settings.menuBarPos)
        Log.CreateLog("Update Branch: " & My.Settings.UpdateBranch)

    End Sub

    Private Sub ok_btn_Click(sender As Object, e As EventArgs) Handles ok_btn.Click
        Try
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

            'Save menuBar settings
            My.Settings.menuBarPos = menuBarPos_cmb.SelectedIndex
            My.Settings.Save()

            'Save runInBackground settings
            If statusBar_Dis_rad.Checked = True And statusBar_Ena_rad.Checked = False Then
                My.Settings.statusBarStatus = False
                My.Settings.Save()

            ElseIf statusBar_Dis_rad.Checked = False And statusBar_Ena_rad.Checked = True Then
                My.Settings.statusBarStatus = True
                My.Settings.Save()

            End If

            ' Save Update Branch Settings
            My.Settings.UpdateBranch = updateBranch_cmb.SelectedIndex

            Log.CreateLog("=======================")
            Log.CreateLog("== Settings Updated ===")
            Log.CreateLog("Auto Updates: " & My.Settings.autoUpdates)
            Log.CreateLog("Run in Background: " & My.Settings.runInBackground)
            Log.CreateLog("Status Strip: " & My.Settings.statusBarStatus)
            Log.CreateLog("Menu Bar: " & My.Settings.menuBarPos)
            Log.CreateLog("Update Branch: " & My.Settings.UpdateBranch)
            Log.CreateLog("=======================")

            'Create MessageBox
            Dim DiagResult As DialogResult = MessageBox.Show("If you have changed any settings, you will need to restart the application for them to apply." & vbCrLf & "Would you like to restart the application?", "Settings", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

            'Check MessageBox
            If DiagResult = DialogResult.Yes Then
                Application.Restart()
            ElseIf DiagResult = DialogResult.No Then
                Me.Close()
            End If
        Catch ex As Exception
            ErrorLog.CreateLog(ex.Message)
            MessageBox.Show("There was an error trying to save your settings." & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub cancel_btn_Click(sender As Object, e As EventArgs) Handles cancel_btn.Click
        Me.Close()
    End Sub

    Private Sub updateCheck_btn_Click(sender As Object, e As EventArgs) Handles updateCheck_btn.Click
        startup.updateCheck()
    End Sub

    Private Sub cacheReset_btn_Click(sender As Object, e As EventArgs) Handles cacheReset_btn.Click
        Dim DiagResult As DialogResult = MessageBox.Show("To reset the cache, I need to restart the application." & vbCrLf & "Would you like to restart the application?", "Settings", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

        'Check MessageBox
        If DiagResult = DialogResult.Yes Then
            Try
                Dim cacheReset As New ProcessStartInfo
                cacheReset.FileName = ".\CacheReset.exe"
                cacheReset.Arguments = ""
                cacheReset.UseShellExecute = True
                cacheReset.WindowStyle = ProcessWindowStyle.Normal
                Dim proc As Process = Process.Start(cacheReset)
                Log.CreateLog("==== Cache Reset Process Started ====")
                Application.Exit()
            Catch ex As Exception
                MessageBox.Show("Couldn't launch. Is it installed?", "Error")
                ErrorLog.CreateLog(ex.Message)
            End Try
            Application.Exit()
        ElseIf DiagResult = DialogResult.No Then
            Me.Close()
        End If
    End Sub
End Class