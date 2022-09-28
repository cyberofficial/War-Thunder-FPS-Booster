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
        n = (2 ^ cores) - 1
        For Each proc In Process.GetProcesses
            Try
                ' Exclusion List
                BoostWorker.ReportProgress(67, "Modifying System" & vbNewLine & "Please don't exit the app.")

                For Each item In My.Settings.ignore_list
                    If proc.ToString.Contains(item) Then
                        proc.ProcessorAffinity = New IntPtr(n - 1)
                    End If

                Next
                ' Cirital Process that will need much cpu resources
                If proc.ToString.Contains("aces") Then
                    proc.ProcessorAffinity = New IntPtr(n - 1)
                End If
                If proc.ToString.Contains("launcher") Then
                    proc.ProcessorAffinity = New IntPtr(n - 1)
                End If
                If proc.ToString.Contains("explorer") Then
                    proc.ProcessorAffinity = New IntPtr(n - 1)
                End If
                ' need to iinclude my program as well for watch dog
                If proc.ToString.Contains("wtfpsbooster") Then
                    proc.ProcessorAffinity = New IntPtr(n - 1)
                End If
                If proc.ToString.Contains("EasyAntiCheat") Then
                    proc.ProcessorAffinity = New IntPtr(n - 1)
                End If
                If proc.ToString.Contains("audiodg") Then
                    proc.ProcessorAffinity = New IntPtr(n - 1)
                End If
            Catch ex As Exception
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
        Enabled = True
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles RestoreBtn.Click
        Enabled = False
        Try
            cores = System.Environment.ProcessorCount.ToString
            n = (2 ^ cores) - 1
            RestoreWorker.RunWorkerAsync()

        Catch ex As Exception

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
                IsLRunning = True
            ElseIf aces1.Count > 0 Then
                wtstatus.Text = "✓ WT is Running"
                wtstatus.ForeColor = Color.Green
                IsWtRunning = True
                DidWtClose = False
                BoostBtn.Visible = True
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
                    WatchDogTxt.Text = "Watch Dog: Offline"
                    Try
                        cores = System.Environment.ProcessorCount.ToString
                        n = (2 ^ cores) - 1
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
                        End If
                        If DidWtClose = True Then
                            wtstatus.Text = "x Game was Closed, PC Restored..."
                            WatchDogTxt.Text = "Watch Dog: Offline"
                            wtstatus.ForeColor = Color.Yellow
                            BoostBtn.Visible = False
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
                    Dim unused = MessageBox.Show("Seems like War Thunder had a Panic Attack, I forced it closed. Possible fix: Try increasing the watch dog timer. IF problem still exists please contact me on reddit [user/cyb3rofficial] or github [github.com/cyberofficial]. Possible fix: Try increasing the watch dog timer.")
                End If
            End If
        Next
    End Sub
    Private Sub WatchDogWaiter_Tick(sender As Object, e As EventArgs) Handles WatchDogWaiter.Tick
        WatchDogTxt.Text = "Watch Dog: Frozen | Waiting before panic attac: " & wdtimer_counter.ToString
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
        Dim unused = MessageBox.Show("Changes for 2.19.0.504:
* Removed Extra Boost. Extra boost was removed and replaced with ignore list.
* Ignore list. With the removale of Extra boost, decided to make the program have extra boost by default. To have the same effect as extra boost being diabled, click on Ignore List, then add Common Names.
* Fixed an issue with Ignore List showing errors with an empty list.
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
