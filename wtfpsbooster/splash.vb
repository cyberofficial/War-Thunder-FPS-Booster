Public Class splash
    Private Sub splash_Load(sender As Object, e As EventArgs) Handles Me.Load
        If My.User.IsInRole(ApplicationServices.BuiltInRole.Administrator) = True Then
            isadmin_box.Checked = True
            isadmin_box.Text = "Is Admin: Yes"
        Else
            isadmin_box.Checked = False
            isadmin_box.Text = "Is Admin: No"
            req_admin4_btn.Visible = True
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

    Private Sub req_admin4_btn_Click(sender As Object, e As EventArgs) Handles req_admin4_btn.Click
        'Dim proc As New ProcessStartInfo()

        'proc.UseShellExecute = True
        'proc.WorkingDirectory = Environment.CurrentDirectory
        'proc.FileName = Application.ExecutablePath
        'proc.Verb = "runas"

        'Try
        '    'MessageBox.Show(Environment.CurrentDirectory + "\runas_admin.cmd")
        '    Process.Start(Environment.CurrentDirectory + "\runas_admin.cmd")
        'Catch
        '    Exit Sub
        'End Try
        Try
            'MessageBox.Show(Environment.CurrentDirectory + "\runas_admin.cmd")
            'File.Create(Environment.CurrentDirectory + "\runas_admin.cmd").Dispose()
            Dim FILE_NAME As String = Environment.CurrentDirectory + "\runas_admin.vbs"
            Dim i As Integer
            Dim aryText(7) As String

            aryText(1) = "set shell=CreateObject(""Shell.Application"")"
            aryText(2) = "shell.ShellExecute ""wtfpsbooster.exe"",,""" + Environment.CurrentDirectory + """, ""runas"", 0"

            Dim objWriter As New System.IO.StreamWriter(FILE_NAME)

            For i = 0 To 7

                objWriter.WriteLine(aryText(i))

            Next

            objWriter.Close()

            Dim unused = Process.Start(Environment.CurrentDirectory + "\runas_admin.vbs")
            Application.Exit()

        Catch ex As Exception

        End Try

        'Application.Exit() ' Kill the old process
    End Sub
End Class