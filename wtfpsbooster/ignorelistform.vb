Public Class ignorelistform
    Private Sub closebtn_Click(sender As Object, e As EventArgs) Handles closebtn.Click
        Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles find_program_btn.Click
        Dim unused1 = OpenFileBox.ShowDialog()
        If ignorelistbox.Items.Contains(System.IO.Path.GetFileNameWithoutExtension(OpenFileBox.FileName)) = False And OpenFileBox.FileName.ToString = "" = False Then
            'ignorelistbox.Items.Add(OpenFileBox.SafeFileName.Substring(0, OpenFileBox.SafeFileName.Length - 4))
            Dim unused = ignorelistbox.Items.Add(System.IO.Path.GetFileNameWithoutExtension(OpenFileBox.FileName))
        End If
    End Sub

    Private Sub add_running_btn_Click(sender As Object, e As EventArgs) Handles add_running_btn.Click
        If ignorelistbox.Items.Contains(running_listbox.Text) = False Then
            Dim unused1 = ignorelistbox.Items.Add(running_listbox.Text)
        End If
        running_listbox.Items.Clear()
        For Each p As Process In Process.GetProcesses()
            If running_listbox.Items.Contains(p.ProcessName) = False And ignorelistbox.Items.Contains(p.ProcessName) = False Then
                Dim unused = running_listbox.Items.Add(p.ProcessName)
            End If
        Next
    End Sub

    Private Sub removebtn_Click(sender As Object, e As EventArgs) Handles removebtn.Click

        ignorelistbox.Items.Remove(ignorelistbox.SelectedItem)

    End Sub

    Private Sub RefreshProc_Click(sender As Object, e As EventArgs) Handles RefreshProc.Click
        add_running_btn.Enabled = 1
        running_listbox.Items.Clear()
        For Each p As Process In Process.GetProcesses()
            If running_listbox.Items.Contains(p.ProcessName) = False And ignorelistbox.Items.Contains(p.ProcessName) = False Then
                Dim unused = running_listbox.Items.Add(p.ProcessName)
            End If
        Next
    End Sub
End Class