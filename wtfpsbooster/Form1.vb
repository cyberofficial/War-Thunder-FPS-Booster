Imports System.Runtime.InteropServices
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
    Dim IsWtRunning As Boolean
    Dim IsLRunning As Boolean
    Dim DidWtClose As Boolean
    Dim ExBoost As Boolean
    Dim WatchDogTimer As Integer
    Dim wdtimer_counter As Integer

    Public Const WM_NCLBUTTONDOWN As Integer = &HA1
    Public Const HT_CAPTION As Integer = &H2

    <DllImportAttribute("user32.dll")>
    Public Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
    End Function

    <DllImportAttribute("user32.dll")>
    Public Shared Function ReleaseCapture() As Boolean
    End Function

    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown, LeftPanel.MouseDown, pcstatus_txt.MouseDown, wtstatus.MouseDown, WatchDogTxt.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
    End Sub

    ' ----------------------------------
    '   Not needed any more.
    ' ----------------------------------

    'Private Sub FrmCustomerDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    '    ' When the form loads, the KeyPreview property is set to True.
    '    ' This lets the form capture keyboard events before
    '    ' any other element in the form.
    '    Me.KeyPreview = True
    'End Sub


    ' ----------------------------------
    '   Use this form loading for code
    ' ----------------------------------
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.KeyPreview = True

        corecount = 0
        While corecount <= System.Environment.ProcessorCount.ToString - 1
            corecount += 1
            cs.Items.Add(corecount - 1)
        End While
        MainControlPanel.TabPages.Remove(TabPage2)


        ' ------------------------------------------------
        '   Watch Dog Timer settings and waiter settings
        ' ------------------------------------------------
        WatchDog_Settings.WDS_Num.Value = My.Settings.watchdog_timer.ToString
        WatchDog.Interval = My.Settings.watchdog_timer


        ' ---------------------------------------------------------------
        '   Lazy Check for file name tampering, prevents code breaking
        ' ---------------------------------------------------------------

        If Application.ExecutablePath.Contains("wtfpsbooster.exe") = False Then
            MessageBox.Show("It seems like the file name was changed, please rename back to: wtfpsbooster.exe" & vbNewLine & "The name is hard coded to the filename and this helps makes things easier, You can always make a shortcut though :)")
            Application.Exit()
        End If
    End Sub

    ' this obs didnt work, will try and remake this.
    'Private Sub frmCustomerDetails_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
    '    If (e.Alt AndAlso (e.KeyCode = Keys.K) AndAlso (e.KeyCode = Keys.L)) Then
    '        ' When Alt + P is pressed, the Click event for the print
    '        ' button is raised.
    '        Try
    '            cores = System.Environment.ProcessorCount.ToString
    '            n = 2 ^ cores - 1
    '            RestoreWorker.RunWorkerAsync()

    '        Catch ex As Exception

    '        End Try
    '    End If
    'End Sub

    Private Sub Reboost_Click(sender As Object, e As EventArgs) Handles BoostBtn.Click
        Try
            BoostWorker_New_25.WorkerReportsProgress = True
            BoostWorker_New_25.RunWorkerAsync()

            'BoostWorker.WorkerReportsProgress = True
            'BoostWorker.RunWorkerAsync()
        Catch ex As Exception

        End Try
    End Sub

    ' ------------- New Boost worker - rewritten ------------------ `
    Private Sub BackGroundWorker_New_25_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BoostWorker_New_25.DoWork
        ' Setting Values first
        total = 0
        EAC_on = True
        cores = System.Environment.ProcessorCount.ToString
        n = 2 ^ cores - 1

        ' Prepare all applications by setting a value to the lowest first.

        ' For every process in this point of time, we set their core count to core 0 ( 1st core)
        For Each proc In Process.GetProcesses
            Try
                proc.ProcessorAffinity = New IntPtr(1)
                BoostWorker_New_25.ReportProgress(1, "Preparing Stage" & vbNewLine & "Please don't exit the app.")
            Catch ex As Exception

            End Try
        Next



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
                'If proc.ToString.Contains("aces" Or "launcher" Or "explorer" Or "wtfpsbooster" Or "EasyAntiCheat" Or "audiodg" Or "eac_launcher") Then
                '    proc.ProcessorAffinity = New IntPtr(n - 1)
                'End If
                ' Compress into one line.
                If proc.ToString.Contains("aces") Then
                    proc.ProcessorAffinity = New IntPtr(n - 1)
                End If
                If proc.ToString.Contains("launcher") Then
                    proc.ProcessorAffinity = New IntPtr(n - 1)
                End If
                If proc.ToString.Contains("explorer") Then
                    proc.ProcessorAffinity = New IntPtr(n - 1)
                End If
                If proc.ToString.Contains("wtfpsbooster") Then
                    proc.ProcessorAffinity = New IntPtr(n - 1)
                End If
                If proc.ToString.Contains("EasyAntiCheat") Then
                    proc.ProcessorAffinity = New IntPtr(n - 1)
                End If
                If proc.ToString.Contains("audiodg") Then
                    proc.ProcessorAffinity = New IntPtr(n - 1)
                End If
                If ExBoost = False Then
                    'If proc.ToString.Contains("Discord" Or "ts3client_win64" Or "GameOverlayUI" Or "Steam" Or "SteamService" Or "steamwebhelper" Or "Dxtory" Or "Dxtory64" Or "nvcontainer" Or "NVDisplay.Container" Or "NVIDIA RTX Voice" Or "NVIDIA Share" Or "nvsphelper64" Or "voicemeter" Or "voicemeter8" Or "conhost") Then
                    '    proc.ProcessorAffinity = New IntPtr(n - 1)
                    'End If
                    '' compress into one line
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
                    If proc.ToString.Contains("conhost") Then
                        proc.ProcessorAffinity = New IntPtr(n - 1)
                    End If

                End If
            Catch ex As Exception
            End Try
        Next
    End Sub
    Private Sub BoostWorker_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BoostWorker.ProgressChanged
        pcstatus_txt.Text = DirectCast(e.UserState, String)

    End Sub
    Private Sub BoostWorker_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BoostWorker.RunWorkerCompleted
        If ExBoost = False Then
            pcstatus_txt.Text = "War Thunder Status: Boosted" & vbNewLine & "PC Status: Most resources are dedicated to War Thunder"
        Else
            pcstatus_txt.Text = "War Thunder Status: Extra Boosted" & vbNewLine & "PC Status: Almost everything is slowed for War Thunder"
        End If
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
        pcstatus_txt.Text = e.UserState.ToString
    End Sub
    Private Sub RestoreWorker_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles RestoreWorker.RunWorkerCompleted
        pcstatus_txt.Text = "PC Status: Normal"
        Me.Enabled = True
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles RestoreBtn.Click
        Me.Enabled = False
        Try
            cores = System.Environment.ProcessorCount.ToString
            n = 2 ^ cores - 1
            RestoreWorker.RunWorkerAsync()

        Catch ex As Exception

        End Try
    End Sub
    Private Sub Rfspcl_Click(sender As Object, e As EventArgs) Handles rfspcl.Click
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
    Private Sub Fcp2_Click(sender As Object, e As EventArgs) Handles fcp2.Click
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
        Try
            launcher1 = Process.GetProcessesByName("launcher")
            aces1 = Process.GetProcessesByName("aces")
            eac = Process.GetProcessesByName("EasyAntiCheat")
            If launcher1.Count > 0 Then
                EAC_on = False
                wtstatus.Text = "✓ Launcher"
                wtstatus.ForeColor = Color.Yellow
                BoostBtn.Visible = True
                ExtraBoost.Visible = True
                IsLRunning = True
            ElseIf aces1.Count > 0 Then
                wtstatus.Text = "✓ WT is Running"
                wtstatus.ForeColor = Color.Green
                IsWtRunning = True
                DidWtClose = False
                BoostBtn.Visible = True
                ExtraBoost.Visible = True
                WatchDog.Enabled = True
                If eac.Count > 0 Then
                    If EAC_on = False Then
                        Try
                            wtstatus.Text = "✓ EAC Module Loaded"
                            wtstatus.ForeColor = Color.DarkSlateBlue
                            BoostWorker.WorkerReportsProgress = True
                            BoostWorker.RunWorkerAsync()
                        Catch ex As Exception
                        End Try
                    End If
                End If
            ElseIf aces1.Count < 1 Then
                If IsWtRunning = True Then
                    IsWtRunning = False
                    DidWtClose = True
                    WatchDog.Enabled = False
                    BoostBtn.Visible = False
                    ExtraBoost.Visible = False
                    WatchDogTxt.Text = "Watch Dog: Offline"
                    Try
                        cores = System.Environment.ProcessorCount.ToString
                        n = 2 ^ cores - 1
                        RestoreWorker.RunWorkerAsync()
                    Catch ex As Exception
                    End Try
                End If
            Else
                wtstatus.Text = "x Not Running"
                wtstatus.ForeColor = Color.Red
            End If
            If launcher1.Count < 1 Then
                If IsLRunning = True Then
                    If IsWtRunning = False Then
                        If DidWtClose = False Then
                            wtstatus.Text = "x Launcher was lost."
                            wtstatus.ForeColor = Color.Red
                            WatchDogTxt.Text = "Watch Dog: Offline"
                            BoostBtn.Visible = False
                            ExtraBoost.Visible = False
                        End If
                        If DidWtClose = True Then
                            wtstatus.Text = "x Game was Closed, PC Restored..."
                            WatchDogTxt.Text = "Watch Dog: Offline"
                            wtstatus.ForeColor = Color.Yellow
                            BoostBtn.Visible = False
                            ExtraBoost.Visible = False
                        End If

                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Application.Exit()
    End Sub

    Private Sub ExtraBoost_Click(sender As Object, e As EventArgs) Handles ExtraBoost.Click
        If ExBoost = True Then
            ExtraBoost.BackColor = Color.FromName("MenuHighlight")
            ExBoost = False
        Else
            Dim ask As MsgBoxResult = MsgBox("!!! WARNING !!!" & vbNewLine & "By Using this mode, this will dedicate ALL resouces to only War Thunder. If you intended to tab out and do other things as you play, this mode is not for you. If you are not going to tab out, then click yes. When you are done playing, close out war thunder and the computer will be restored. If you are really sure you arent gonna tab out, then click yes, otherwise, back out and click no, then click the other boost button.", MsgBoxStyle.YesNo,)
            If ask = MsgBoxResult.Yes Then
                ExtraBoost.BackColor = Color.Goldenrod
                ExBoost = True
            Else
                ExtraBoost.BackColor = Color.FromName("MenuHighlight")
                ExBoost = False
            End If
        End If


    End Sub

    Private Sub WatchDog_Tick(sender As Object, e As EventArgs) Handles WatchDog.Tick
        Try
            WatchDogTimer += 1
            WatchDogTxt.Text = "Watch Dog: Online | Ticks: " & WatchDogTimer.ToString
        Catch ex As Exception

        End Try
        For Each proc As Process In System.Diagnostics.Process.GetProcesses
            If proc.ProcessName = "aces" Then
                If proc.Responding = False Then
                    ' attempt to kill the process

                    'proc.Kill()

                    If ExBoost = True Then
                        MessageBox.Show("Seems like War Thunder had a Panic Attack, I forced it closed. It also seems like the extra boost isnt working out for your pc, please disable.")
                    Else
                        MessageBox.Show("Seems like War Thunder had a Panic Attack, I forced it closed.")
                    End If
                End If
            End If
        Next
    End Sub
    Private Sub WatchDogWaiter_Tick(sender As Object, e As EventArgs) Handles WatchDogWaiter.Tick

        WatchDogTxt.Text = "Watch Dog: Frozen | Waiting before panic attac: " & wdtimer_counter.ToString
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        WatchDog_Settings.ShowDialog()
    End Sub

End Class
