Imports System.Threading
Public Class Form1
    Dim corecount As Integer
    Dim status As String
    Dim total As Integer
    Dim cores As Integer
    Dim n As Integer
    Dim EAC_on As Boolean = False
    Dim launcher1() As Process
    Dim aces1() As Process
    Dim eac() As Process
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        corecount = 0
        While corecount <= System.Environment.ProcessorCount.ToString - 1
            corecount += 1
            cs.Items.Add(corecount - 1)
        End While
        TabControl1.TabPages.Remove(TabPage2)
    End Sub
    Private Sub BoostWorker_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BoostWorker.DoWork
        total = 0
        EAC_on = True
        For Each proc In Process.GetProcesses
            Try
                proc.ProcessorAffinity = New IntPtr(1)
                BoostWorker.ReportProgress(1, "Preparing Stage" & vbNewLine & "Please don't exit the app.")
            Catch ex As Exception

            End Try
        Next
        cores = System.Environment.ProcessorCount.ToString
        n = 2 ^ cores - 1
        For Each proc In Process.GetProcesses
            Try
                ' Exclusion List
                BoostWorker.ReportProgress(67, "Modifying System" & vbNewLine & "Please don't exit the app.")
                If proc.ToString.Contains("aces") Then
                    proc.ProcessorAffinity = New IntPtr(n - 1)
                End If
                If proc.ToString.Contains("Discord") Then
                    proc.ProcessorAffinity = New IntPtr(n - 1)
                End If
                If proc.ToString.Contains("ts3client_win64") Then
                    proc.ProcessorAffinity = New IntPtr(n - 1)
                End If
                If proc.ToString.Contains("GameOverlayUI") Then
                    proc.ProcessorAffinity = New IntPtr(n - 1)
                End If
                If proc.ToString.Contains("Steam") Then
                    proc.ProcessorAffinity = New IntPtr(n - 1)
                End If
                If proc.ToString.Contains("SteamService") Then
                    proc.ProcessorAffinity = New IntPtr(n - 1)
                End If
                If proc.ToString.Contains("steamwebhelper") Then
                    proc.ProcessorAffinity = New IntPtr(n - 1)
                End If
                If proc.ToString.Contains("Dxtory") Then
                    proc.ProcessorAffinity = New IntPtr(n - 1)
                End If
                If proc.ToString.Contains("Dxtory64") Then
                    proc.ProcessorAffinity = New IntPtr(n - 1)
                End If
                If proc.ToString.Contains("launcher") Then
                    proc.ProcessorAffinity = New IntPtr(n - 1)
                End If
                If proc.ToString.Contains("EasyAntiCheat") Then
                    proc.ProcessorAffinity = New IntPtr(n - 1)
                End If
                If proc.ToString.Contains("wtfpsbooster") Then
                    proc.ProcessorAffinity = New IntPtr(n - 1)
                End If
                If proc.ToString.Contains("nvcontainer") Then
                    proc.ProcessorAffinity = New IntPtr(n - 1)
                End If
                If proc.ToString.Contains("NVDisplay.Container") Then
                    proc.ProcessorAffinity = New IntPtr(n - 1)
                End If
                If proc.ToString.Contains("NVIDIA RTX Voice") Then
                    proc.ProcessorAffinity = New IntPtr(n - 1)
                End If
                If proc.ToString.Contains("NVIDIA Share") Then
                    proc.ProcessorAffinity = New IntPtr(n - 1)
                End If
                If proc.ToString.Contains("NVIDIA Web Helper") Then
                    proc.ProcessorAffinity = New IntPtr(n - 1)
                End If
                If proc.ToString.Contains("nvsphelper64") Then
                    proc.ProcessorAffinity = New IntPtr(n - 1)
                End If
                If proc.ToString.Contains("voicemeter") Then
                    proc.ProcessorAffinity = New IntPtr(n - 1)
                End If
                If proc.ToString.Contains("voicemeter8") Then
                    proc.ProcessorAffinity = New IntPtr(n - 1)
                End If
            Catch ex As Exception
            End Try
        Next
    End Sub
    Private Sub BoostWorker_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BoostWorker.ProgressChanged
        Label1.Text = DirectCast(e.UserState, String)

    End Sub
    Private Sub BoostWorker_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BoostWorker.RunWorkerCompleted
        Label1.Text = "War Thunder Status: Boosted" & vbNewLine & "PC Status: Most resources are dedicated to War Thunder" & vbNewLine & "Restore before closing."
        Me.Enabled = True
    End Sub
    Private Sub RestoreWorker_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles RestoreWorker.DoWork
        For Each proc In Process.GetProcesses
            Try
                proc.ProcessorAffinity = New IntPtr(n)
                RestoreWorker.ReportProgress(1, "Restoring Processes to Normal...")
            Catch ex As Exception

            End Try
        Next
    End Sub
    Private Sub RestoreWorker_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles RestoreWorker.ProgressChanged
        Label1.Text = e.UserState.ToString
    End Sub
    Private Sub RestoreWorker_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles RestoreWorker.RunWorkerCompleted
        Label1.Text = "PC Status: Normal"
        Me.Enabled = True
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Enabled = False
        Try
            cores = System.Environment.ProcessorCount.ToString
            n = 2 ^ cores - 1
            RestoreWorker.RunWorkerAsync()

        Catch ex As Exception

        End Try
    End Sub
    Private Sub rfspcl_Click(sender As Object, e As EventArgs) Handles rfspcl.Click
        pclist.Items.Clear()
        For Each proc In Process.GetProcesses
            Try
                If Not pclist.Items.Contains(proc.ProcessName) Then
                    pclist.Items.Add(proc.ProcessName)
                End If
            Catch ex As Exception

            End Try
        Next
    End Sub
    Private Sub fcp2_Click(sender As Object, e As EventArgs) Handles fcp2.Click
        Dim total As Integer
        total = 0
        For Each item In cs.CheckedItems
            Try
                total = (2 ^ item.ToString) + total
            Catch ex As Exception

            End Try

        Next
        For Each item In pclist.CheckedItems
            Try
                For Each proc In Process.GetProcesses
                    Try
                        If proc.ToString.Contains(item) Then
                            proc.ProcessorAffinity = New IntPtr(total)
                        End If
                    Catch ex As Exception

                    End Try
                Next
            Catch ex As Exception

            End Try
        Next
    End Sub
    Private Sub Tauto_Tick(sender As Object, e As EventArgs) Handles tauto.Tick
        launcher1 = Process.GetProcessesByName("launcher")
        aces1 = Process.GetProcessesByName("aces")
        eac = Process.GetProcessesByName("EasyAntiCheat")
        If launcher1.Count > 0 Then
            EAC_on = False
            wtstatus.Text = "✓ Launcher"
            wtstatus.ForeColor = Color.Green
        ElseIf aces1.Count > 0 Then
            wtstatus.Text = "🧸 WT is Running"
            wtstatus.ForeColor = Color.Red
            If eac.Count > 0 Then
                If EAC_on = False Then
                    Try
                        wtstatus.Text = "🧸 EAC Module Loaded"
                        wtstatus.ForeColor = Color.DarkSlateBlue
                        BoostWorker.WorkerReportsProgress = True
                        BoostWorker.RunWorkerAsync()
                    Catch ex As Exception

                    End Try
                End If
            End If
        Else
            wtstatus.Text = "x Not Running"
            wtstatus.ForeColor = Color.Red
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try
            BoostWorker.WorkerReportsProgress = True
            BoostWorker.RunWorkerAsync()
        Catch ex As Exception

        End Try
    End Sub
End Class
