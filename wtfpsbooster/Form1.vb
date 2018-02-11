Imports System.Threading
Public Class Form1

    Dim corecount As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        corecount = 0

        'Sider Counter
        'fss.Maximum = System.Environment.ProcessorCount.ToString - 1
        '------------------


        'Checkbox SingleCore List
        'For Each proc In Process.GetProcesses
        '    If Not scpl.Items.Contains(proc.ProcessName) Then
        '        scpl.Items.Add(proc.ProcessName)
        '    End If

        '    On Error Resume Next
        'Next
        '------------------


        'Corecounter multicore checked list
        While corecount <= System.Environment.ProcessorCount.ToString - 1
            corecount = corecount + 1
            cs.Items.Add(corecount - 1)
        End While

        TabControl1.TabPages.Remove(TabPage2)
        '------------------



    End Sub

    Private Sub ForceSingleSlider_ValueChanged(sender As Object, e As EventArgs)
        'singlecoreval.Text = "Core Selected: " & fss.Value
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim total As Integer
        total = 0

        'For Each item In cs.CheckedItems
        '    total = (2 ^ item.ToString) + total
        'Next

        'set each process to first core
        For Each proc In Process.GetProcesses
            proc.ProcessorAffinity = New IntPtr(1)

            On Error Resume Next
        Next


        'set aces to use all the other cores
        Dim cores As Integer
        Dim n As Integer
        cores = System.Environment.ProcessorCount.ToString
        n = 2 ^ cores - 1
        For Each proc In Process.GetProcesses
            If proc.ToString.Contains("aces") Then
                proc.ProcessorAffinity = New IntPtr(n - 1)
            End If
            If proc.ToString.Contains("discord") Then
                proc.ProcessorAffinity = New IntPtr(n - 1)
            End If
            If proc.ToString.Contains("ts3client_win64") Then
                proc.ProcessorAffinity = New IntPtr(n - 1)
            End If
            On Error Resume Next
        Next

        'Dim sc As Integer
        'sc = 2 ^ fss.Value

        'If fss.Value = 0 Then
        '    For Each proc In Process.GetProcesses
        '        proc.ProcessorAffinity = New IntPtr(1)

        '        On Error Resume Next
        '    Next
        'Else
        '    For Each proc In Process.GetProcesses
        '        proc.ProcessorAffinity = New IntPtr(sc)

        '        On Error Resume Next
        '    Next
        'End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim cores As Integer
        Dim n As Integer
        cores = System.Environment.ProcessorCount.ToString
        n = 2 ^ cores - 1
        For Each proc In Process.GetProcesses
            proc.ProcessorAffinity = New IntPtr(n)

            On Error Resume Next
        Next

    End Sub

    Private Sub rfpl1_Click(sender As Object, e As EventArgs)
        'scpl.Items.Clear()
        'For Each proc In Process.GetProcesses
        '    If Not scpl.Items.Contains(proc.ProcessName) Then
        '        scpl.Items.Add(proc.ProcessName)
        '    End If

        '    On Error Resume Next
        'Next
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles rfspcl.Click
        pclist.Items.Clear()
        For Each proc In Process.GetProcesses
            If Not pclist.Items.Contains(proc.ProcessName) Then
                pclist.Items.Add(proc.ProcessName)
            End If

            On Error Resume Next
        Next
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles fcp2.Click
        Dim total As Integer
        total = 0

        For Each item In cs.CheckedItems
            total = (2 ^ item.ToString) + total
        Next

        For Each item In pclist.CheckedItems
            For Each proc In Process.GetProcesses
                If proc.ToString.Contains(item) Then
                    proc.ProcessorAffinity = New IntPtr(total)
                End If
                On Error Resume Next
            Next
            On Error Resume Next
        Next

    End Sub

    Dim launcher1() As Process
    Dim aces1() As Process

    Private Sub tauto_Tick(sender As Object, e As EventArgs) Handles tauto.Tick

        launcher1 = Process.GetProcessesByName("launcher")
        aces1 = Process.GetProcessesByName("aces")
        If launcher1.Count > 0 Then
            wtstatus.Text = "Launcher Running"
            wtstatus.ForeColor = Color.Yellow
        ElseIf aces1.Count > 0 Then
            wtstatus.Text = "War Thunder Running"
            wtstatus.ForeColor = Color.Green
        Else
            wtstatus.Text = "Not Running"
            wtstatus.ForeColor = Color.Red
        End If
    End Sub
End Class
