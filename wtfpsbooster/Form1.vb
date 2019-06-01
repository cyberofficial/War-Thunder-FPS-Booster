Imports System.Threading
Public Class Form1
    Dim corecount As Integer
    Dim status As String
    Dim total As Integer
    Dim cores As Integer
    Dim n As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        corecount = 0
        While corecount <= System.Environment.ProcessorCount.ToString - 1
            corecount = corecount + 1
            cs.Items.Add(corecount - 1)
        End While
        TabControl1.TabPages.Remove(TabPage2)
    End Sub

    Private Sub BoostWorker_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BoostWorker.DoWork
        total = 0
        For Each proc In Process.GetProcesses
            Try
                proc.ProcessorAffinity = New IntPtr(1)
                BoostWorker.ReportProgress(1, "Stage 1 of 2" & vbNewLine & "Please dont exit the app.")
            Catch ex As Exception

            End Try

        Next
        cores = System.Environment.ProcessorCount.ToString
        n = 2 ^ cores - 1
        For Each proc In Process.GetProcesses
            Try
                BoostWorker.ReportProgress(67, "Stage 2 of 2" & vbNewLine & "Please dont exit the app.")
                Thread.Sleep(15)
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
            Catch ex As Exception

            End Try

        Next

    End Sub

    Private Sub BoostWorker_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BoostWorker.ProgressChanged
        Label1.Text = DirectCast(e.UserState, String)

    End Sub

    Private Sub BoostWorker_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BoostWorker.RunWorkerCompleted
        Label1.Text = "War Thunder Status: Boosted" & vbNewLine & "Restore before closing."
        Me.Enabled = True
    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles bbtn.Click
        Me.Enabled = False
        bbtn.Enabled = 0
        Try
            BoostWorker.WorkerReportsProgress = True
            BoostWorker.RunWorkerAsync()
        Catch ex As Exception

        End Try
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
        Label1.Text = "War Thunder Status: Normal"
        bbtn.Enabled = True
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
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles rfspcl.Click
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
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles fcp2.Click
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
    Dim launcher1() As Process
    Dim aces1() As Process

    Private Sub Tauto_Tick(sender As Object, e As EventArgs) Handles tauto.Tick
        launcher1 = Process.GetProcessesByName("launcher")
        aces1 = Process.GetProcessesByName("aces")
        If launcher1.Count > 0 Then
            wtstatus.Text = "x Launcher"
            wtstatus.ForeColor = Color.Yellow
            'tauto.Interval = 2000
        ElseIf aces1.Count > 0 Then
            wtstatus.Text = "✓ WT is Running"
            wtstatus.ForeColor = Color.Green
            bbtn.Enabled = True
            'tauto.Interval = 10000
        Else
            wtstatus.Text = "x Not Running"
            wtstatus.ForeColor = Color.Red
            bbtn.Enabled = False
            'tauto.Interval = 1000
        End If
    End Sub
End Class
