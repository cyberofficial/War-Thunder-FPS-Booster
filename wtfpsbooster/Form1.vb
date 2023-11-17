Imports System.Runtime.InteropServices
Public Class Form1
    Private corecount As Integer
    Private ReadOnly status As String
    Private total As Integer
    Private cores As Integer
    Private n As Integer
    Private EAC_on As Boolean = False
    Private launcher1() As Process
    Private aces1() As Process
    Private eac() As Process
    Private IsWtRunning As Boolean
    Private IsLRunning As Boolean
    Private DidWtClose As Boolean
    Private ReadOnly ExBoost As Boolean
    Private WatchDogTimer As Integer
    Private ReadOnly wdtimer_counter As Integer

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
            Dim unused1 = ReleaseCapture()
            Dim unused = SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
    End Sub

    ' ----------------------------------
    '   Use this form loading for code
    ' ----------------------------------
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KeyPreview = True
        Dim unused3 = splash.ShowDialog()

        If My.User.IsInRole(ApplicationServices.BuiltInRole.Administrator) = False Then
            Dim unused2 = MessageBox.Show("Tried to sneaky huh? Well that doesn't work. Please run as admin.")
            Application.Exit()
        End If

        Try
            ignorelistform.ignorelistbox.Items.Clear()
            For Each item In My.Settings.ignore_list
                Dim unused4 = ignorelistform.ignorelistbox.Items.Add(item)
            Next
        Catch ex As Exception

        End Try


        corecount = 0
        While corecount <= System.Environment.ProcessorCount.ToString - 1
            corecount += 1
            Dim unused1 = cs.Items.Add(corecount - 1)
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
            Dim unused = MessageBox.Show("It seems like the file name was changed, please rename back to: wtfpsbooster.exe" & vbNewLine & "The name is hard coded to the filename and this helps makes things easier, You can always make a shortcut though :)")
            Application.Exit()
        End If
    End Sub

    Private Sub Reboost_Click(sender As Object, e As EventArgs) Handles BoostBtn.Click
        Try
            BoostWorker.WorkerReportsProgress = True
            BoostWorker.RunWorkerAsync()
        Catch ex As Exception

        End Try
    End Sub

    ' ------------- New Boost worker - rewritten ------------------ `
    Private Sub BackGroundWorker_New_25_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BoostWorker_New_25.DoWork
        ' Setting Values first
        total = 0
        EAC_on = True
        ' count how many cores the pc has
        cores = System.Environment.ProcessorCount.ToString
        n = (2 ^ cores) - 1

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

    Private Sub BoostWorker_New_25_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BoostWorker_New_25.DoWork
        ' Setting Values first
        total = 0
        EAC_on = True

        ' Count how many cores the PC has and calculate the bitmask
        Dim cores As Integer = Environment.ProcessorCount
        Dim affinityMask As Long = 0
        For i As Integer = 0 To cores - 1
            affinityMask = affinityMask Or (1L << i)
        Next

        ' Prepare all applications by setting a value to the lowest first.
        ' For every process in this point of time, we set their core count to core 0 (1st core)
        For Each proc In Process.GetProcesses
            Try
                proc.ProcessorAffinity = New IntPtr(1)
                BoostWorker_New_25.ReportProgress(1, "Preparing Stage" & vbNewLine & "Please don't exit the app.")
            Catch ex As Exception
                ' Handle exceptions if needed
            End Try
        Next

        ' Additional logic for setting specific affinities goes here...
        ' Use affinityMask as needed for setting ProcessorAffinity
    End Sub

    Private Sub BoostWorker_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BoostWorker.DoWork
        total = 0
        EAC_on = True

        ' Count how many cores the PC has and calculate the bitmask
        Dim cores As Integer = Environment.ProcessorCount
        Dim affinityMask As Long = 0
        For i As Integer = 0 To cores - 1
            affinityMask = affinityMask Or (1L << i)
        Next

        For Each proc In Process.GetProcesses
            Try
                proc.ProcessorAffinity = New IntPtr(1)
                BoostWorker.ReportProgress(1, "Preparing Stage" & vbNewLine & "Please don't exit the app.")

            Catch ex As Exception
                ' Handle exceptions if needed
            End Try
        Next

        ' Additional logic for setting specific affinities based on conditions
        For Each proc In Process.GetProcesses
            Try
                ' Exclusion List
                BoostWorker.ReportProgress(67, "Modifying System" & vbNewLine & "Please don't exit the app.")

                Dim processName As String = proc.ProcessName.ToLower()
                Dim isIgnored As Boolean = My.Settings.ignore_list.Cast(Of String)().Any(Function(item) processName.Contains(item.ToLower()))

                If Not isIgnored Then
                    ' Critical Process that will need much CPU resources
                    If processName.Contains("aces") OrElse processName.Contains("launcher") OrElse processName.Contains("explorer") OrElse processName.Contains("wtfpsbooster") OrElse processName.Contains("easyanticheat") OrElse processName.Contains("audiodg") Then
                        proc.ProcessorAffinity = New IntPtr(affinityMask)
                    End If
                End If
            Catch ex As Exception
                ' Handle exceptions if needed
            End Try
        Next
    End Sub

    Private Sub BoostWorker_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BoostWorker.ProgressChanged
        pcstatus_txt.Text = DirectCast(e.UserState, String)

    End Sub
    Private Sub BoostWorker_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BoostWorker.RunWorkerCompleted
        pcstatus_txt.Text = "War Thunder Status: Boosted" & vbNewLine & "PC Status: Most resources are dedicated to War Thunder"
        Enabled = True
    End Sub

    Private Sub CheckGameProcess()
        If Not Process.GetProcessesByName("aces").Any() Then
            ' If the game is no longer running and RestoreWorker is busy, request to stop it
            If RestoreWorker.IsBusy Then
                RestoreWorker.CancelAsync()
            End If
        End If
    End Sub

    Private Sub RestoreWorker_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles RestoreWorker.DoWork
        If RestoreWorker.CancellationPending Then
            e.Cancel = True
            Return
        End If
        Dim affinityMask As Long = CalculateAffinityMask()
        Dim allProcesses = Process.GetProcesses()
        Dim totalProcesses As Integer = allProcesses.Length
        Dim processedCount As Integer = 0

        For Each proc In allProcesses
            Try
                proc.ProcessorAffinity = New IntPtr(affinityMask)
                processedCount += 1
                Dim progressText As String = $"{processedCount} of {totalProcesses}" + vbNewLine + $"Restoring: {proc.ProcessName}..." + vbNewLine + $"Progress: {CInt((processedCount / totalProcesses) * 100)}%"
                RestoreWorker.ReportProgress(CInt((processedCount / totalProcesses) * 100), progressText)
            Catch ex As Exception
                ' Handle exceptions if needed
            End Try
        Next
    End Sub

    Private Sub RestoreWorker_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles RestoreWorker.ProgressChanged
        pcstatus_txt.Text = e.UserState.ToString
    End Sub

    Private Function CalculateAffinityMask() As Long
        Dim cores As Integer = Environment.ProcessorCount
        Dim affinityMask As Long = 0
        For i As Integer = 0 To cores - 1
            affinityMask = affinityMask Or (1L << i)
        Next
        Return affinityMask
    End Function

    Private Sub RestoreWorker_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles RestoreWorker.RunWorkerCompleted
        pcstatus_txt.Text = "PC Status: Normal"
        UpdateStatusText("x Not Running", Color.Red)
        Enabled = True
        tauto.Enabled = False
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles RestoreBtn.Click
        Enabled = True
        Try
            Dim cores As Integer = System.Environment.ProcessorCount
            Dim n As Long = (2 ^ cores) - 1
            RestoreWorker.RunWorkerAsync()

        Catch ex As Exception
            MessageBox.Show("Error Restoring" + vbNewLine + ex.Message)
        End Try
    End Sub
    Private Sub Rfspcl_Click(sender As Object, e As EventArgs) Handles rfspcl.Click
        pclist.Items.Clear()
        For Each proc In Process.GetProcesses
            Try
                If Not pclist.Items.Contains(proc.ProcessName) Then
                    Dim unused = pclist.Items.Add(proc.ProcessName)
                End If
            Catch ex As Exception

            End Try
        Next
    End Sub
    Private Sub Fcp2_Click(sender As Object, e As EventArgs) Handles fcp2.Click
        Dim totalAffinityMask As Long = 0
        For Each item In cs.CheckedItems
            Try
                totalAffinityMask = totalAffinityMask Or (1L << CInt(item))
            Catch ex As Exception
                ' Handle exceptions if needed
            End Try
        Next

        For Each item In pclist.CheckedItems
            Try
                For Each proc In Process.GetProcesses
                    Try
                        If proc.ProcessName.Contains(item.ToString) Then
                            proc.ProcessorAffinity = New IntPtr(totalAffinityMask)
                        End If
                    Catch ex As Exception
                        ' Handle exceptions if needed
                    End Try
                Next
            Catch ex As Exception
                ' Handle exceptions if needed
            End Try
        Next
    End Sub


    Private Sub Tauto_Tick(sender As Object, e As EventArgs) Handles tauto.Tick
        Try
            UpdateProcessStatus()
        Catch ex As Exception
            ' Log the exception or handle it appropriately
        End Try
    End Sub

    Private Sub UpdateProcessStatus()
        Dim launcherProcesses = Process.GetProcessesByName("launcher")
        Dim gameProcesses = Process.GetProcessesByName("aces")
        Dim eacProcesses = Process.GetProcessesByName("EasyAntiCheat")

        If launcherProcesses.Any() Then
            HandleLauncherRunning()
        ElseIf gameProcesses.Any() Then
            HandleGameRunning(eacProcesses)
        Else
            HandleGameNotRunning()
        End If

        If Not launcherProcesses.Any() Then
            HandleLauncherNotRunning(gameProcesses)
        End If
    End Sub

    Private Sub HandleLauncherRunning()
        EAC_on = False
        UpdateStatusText("✓ Launcher", Color.Yellow)
        BoostBtn.Visible = True
        IsLRunning = True
    End Sub

    Private Sub HandleGameRunning(eacProcesses As Process())
        UpdateStatusText("✓ WT is Running", Color.Green)
        IsWtRunning = True
        DidWtClose = False
        BoostBtn.Visible = True
        WatchDog.Enabled = True

        If eacProcesses.Any() AndAlso Not EAC_on Then
            Try
                UpdateStatusText("✓ EAC Module Loaded", Color.DarkSlateBlue)
                StartBoostWorker()
            Catch ex As Exception
                ' Handle exceptions if needed
            End Try
        End If
    End Sub

    Private Sub HandleGameNotRunning()
        If IsWtRunning Then
            IsWtRunning = False
            DidWtClose = True
            WatchDog.Enabled = False
            BoostBtn.Visible = False
            WatchDogTxt.Text = "Watch Dog: Offline"
            Try
                RestoreCpuAffinity()
            Catch ex As Exception
                ' Handle exceptions if needed
            End Try
        Else
            UpdateStatusText("x Not Running", Color.Red)
        End If
    End Sub

    Private Sub HandleLauncherNotRunning(gameProcesses As Process())
        If IsLRunning AndAlso Not IsWtRunning Then
            If DidWtClose Then
                UpdateStatusText("x Game was Closed, PC will be Restored...", Color.Yellow)
                Try
                    RestoreCpuAffinity()
                Catch ex As Exception
                    ' Handle exceptions if needed
                End Try
            Else
                UpdateStatusText("x Launcher was lost.", Color.Red)
            End If
            WatchDogTxt.Text = "Watch Dog: Offline"
            BoostBtn.Visible = False
        End If
    End Sub

    Private Sub UpdateStatusText(text As String, color As Color)
        wtstatus.Text = text
        wtstatus.ForeColor = color
    End Sub

    Private Sub StartBoostWorker()
        BoostWorker.WorkerReportsProgress = True
        BoostWorker.RunWorkerAsync()
    End Sub

    Private Sub RestoreCpuAffinity()
        Dim cores As Integer = Environment.ProcessorCount
        Dim affinityMask As Long = CalculateAffinityMask(cores)
        RestoreWorker.RunWorkerAsync(affinityMask)
    End Sub

    Private Function CalculateAffinityMask(cores As Integer) As Long
        Dim affinityMask As Long = 0
        For i As Integer = 0 To cores - 1
            affinityMask = affinityMask Or (1L << i)
        Next
        Return affinityMask
    End Function

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Application.Exit()
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
                    proc.Kill()
                    Dim cores As Integer = System.Environment.ProcessorCount
                    Dim n As Long = (2 ^ cores) - 1
                    RestoreWorker.RunWorkerAsync()
                    Dim unused = MessageBox.Show("Seems like War Thunder had a Panic Attack, I forced it closed. Possible fix: Try increasing the watch dog timer. IF problem still exists please contact me on reddit [user/cyb3rofficial] or github [github.com/cyberofficial]. Possible fix: Try increasing the watch dog timer.")
                End If
            End If
        Next
    End Sub
    Private Sub WatchDogWaiter_Tick(sender As Object, e As EventArgs) Handles WatchDogWaiter.Tick
        WatchDogTxt.Text = "Watch Dog: Frozen | Waiting before panic attack: " & wdtimer_counter.ToString
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        WindowState = System.Windows.Forms.FormWindowState.Minimized
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim unused = WatchDog_Settings.ShowDialog()
    End Sub

    Private Sub ignorelist_btn_Click(sender As Object, e As EventArgs) Handles ignorelist_btn.Click
        Dim unused = ignorelistform.ShowDialog()
        ignorelistform.ignorelistbox.Items.Clear()
        For Each item In My.Settings.ignore_list
            Dim unused1 = ignorelistform.ignorelistbox.Items.Add(item)
        Next
    End Sub

    Private Sub start_btn_Click(sender As Object, e As EventArgs) Handles start_btn.Click
        Dim unused = MessageBox.Show("Please make sure to close out war thunder first before closing this program. Other wise, things will be super slow and a restart of the pc will be required.")
        wtstatus.Text = "Waiting for Launcher..."
        tauto.Enabled = True
        start_btn.Visible = False
    End Sub

    Private Sub howtouse_btn_Click(sender As Object, e As EventArgs) Handles howtouse_btn.Click
        Dim unused = MessageBox.Show("Please note, results may vary depending on the system.
How to use the program:
Step 1: Make sure War Thunder + the Launcher are closed, if they are open, close them now and relaunch this program.
Step 2: Launch War Thunder’s Launcher
Step 3: Wait for the Text to verify the launcher is running
Step 4: Click the Gear cog next to the text watch dog, enter a reasonable number.
Step 5: You are all set, click Launch on your Launcher and the game should boost automatically.
")
    End Sub

    Private Sub chang_log_Click(sender As Object, e As EventArgs) Handles chang_log.Click
        Dim unused = MessageBox.Show("Changes for 2.31.1.39:
* ✅ Tested with EAC and still safe to use
* Fixed an issue where restore would not work for some pcs with a higher cpu core count of 8
* Better watch dog handling
* Updater was fixed
* Updater will check for updates before the app starts and will let you know if there is an update or not
* Not so red preface warning text.
")
    End Sub

    Private Sub githublogo_Click(sender As Object, e As EventArgs) Handles githublogo.Click
        Dim unused = Process.Start("https://github.com/cyberofficial/War-Thunder-FPS-Booster/issues")
    End Sub

    Private Sub redditlogo_Click(sender As Object, e As EventArgs) Handles redditlogo.Click
        Dim unused = Process.Start("https://www.reddit.com/user/cyb3rofficial")
    End Sub

    Private Sub paypallogo_Click(sender As Object, e As EventArgs) Handles paypallogo.Click
        Dim unused = Process.Start("https://www.paypal.com/paypalme/cyberdrive")
    End Sub
End Class
