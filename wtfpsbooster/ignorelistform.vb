Public Class ignorelistform
    Private Sub closebtn_Click(sender As Object, e As EventArgs) Handles closebtn.Click
        Me.Close()
        ignorelistbox.Items.Clear()
        For Each item In My.Settings.ignore_list
            Dim unused4 = ignorelistbox.Items.Add(item)
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles find_program_btn.Click
        Try
            Dim unused1 = OpenFileBox.ShowDialog()
            If ignorelistbox.Items.Contains(System.IO.Path.GetFileNameWithoutExtension(OpenFileBox.FileName)) = False And OpenFileBox.FileName.ToString = "" = False Then
                Dim unused = ignorelistbox.Items.Add(System.IO.Path.GetFileNameWithoutExtension(OpenFileBox.FileName))
            End If
        Catch ex As Exception

        End Try

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
        Try
            ignorelistbox.Items.Remove(ignorelistbox.SelectedItem)
        Catch ex As Exception

        End Try

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

    Private Sub save_ignore_btn_Click(sender As Object, e As EventArgs) Handles save_ignore_btn.Click
        Try
            If My.Settings.ignore_list Is Nothing Then
                My.Settings.ignore_list = New System.Collections.Specialized.StringCollection()
            End If

            My.Settings.ignore_list.Clear()
            For Each item In ignorelistbox.Items
                Dim unused = My.Settings.ignore_list.Add(item)
            Next
            My.Settings.Save()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub add_common_items_Click(sender As Object, e As EventArgs) Handles add_common_items.Click
        Dim commonnames() As String = {"ts3client_win64", "GameOverlayUI", "Steam", "SteamService", "steamwebhelper", "Dxtory", "Dxtory64", "nvcontainer", "NVDisplay.Container", "NVIDIA RTX Voice", "NVIDIA Share", "NVIDIA Web Helper", "nvsphelper64", "voicemeter", "voicemeter8", "conhost"}
        Try
            For Each item In commonnames.ToArray
                If ignorelistbox.Items.Contains(item) = False Then
                    Dim unused = ignorelistbox.Items.Add(item)
                End If
            Next
            ignorelistbox.Sorted = True

        Catch ex As Exception

        End Try

    End Sub
End Class