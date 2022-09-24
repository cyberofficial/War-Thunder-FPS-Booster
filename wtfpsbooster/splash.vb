Public Class splash
    Private Sub splash_Load(sender As Object, e As EventArgs) Handles Me.Load
        If My.User.IsInRole(ApplicationServices.BuiltInRole.Administrator) = True Then
            isadmin_box.Checked = True
            isadmin_box.Text = "Is Admin: Yes"
        Else
            isadmin_box.Checked = False
            isadmin_box.Text = "Is Admin: No"
        End If
    End Sub

    Private Sub start_app_Click(sender As Object, e As EventArgs) Handles start_app.Click
        If My.User.IsInRole(ApplicationServices.BuiltInRole.Administrator) = False Then
            Dim unused1 = MessageBox.Show("Please run as admin!")
        ElseIf iagree_box.Checked = True Then
            Close()
        ElseIf iagree_box.Checked = False Then
            Dim unused = MessageBox.Show("Please agree.")
        End If

    End Sub

    Private Sub exit_app_Click(sender As Object, e As EventArgs) Handles exit_app.Click
        Close()
        Application.Exit()
    End Sub
End Class