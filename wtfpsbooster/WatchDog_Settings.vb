Public Class WatchDog_Settings
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Settings.watchdog_timer = WDS_Num.Value
        My.Settings.Save()
        My.Settings.Reload()
        Form1.WatchDog.Interval = WDS_Num.Value
        Hide()
    End Sub

    Private Sub WatchDog_Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WDS_Num.Value = My.Settings.watchdog_timer.ToString
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles wdgod_settings_exit_btn.Click
        Close()
        WDS_Num.Value = My.Settings.watchdog_timer
    End Sub
End Class