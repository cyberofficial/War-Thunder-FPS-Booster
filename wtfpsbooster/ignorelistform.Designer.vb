﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ignorelistform
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.find_program_btn = New System.Windows.Forms.Button()
        Me.closebtn = New System.Windows.Forms.Button()
        Me.removebtn = New System.Windows.Forms.Button()
        Me.ignorelistbox = New System.Windows.Forms.ListBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.OpenFileBox = New System.Windows.Forms.OpenFileDialog()
        Me.add_running_btn = New System.Windows.Forms.Button()
        Me.running_listbox = New System.Windows.Forms.ComboBox()
        Me.RefreshProc = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.0!)
        Me.Label1.Location = New System.Drawing.Point(7, 6)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ignore List"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.Label2.Location = New System.Drawing.Point(8, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(498, 66)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Add Programs to the ignore list." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "All applications in this list will not be aff" &
    "ected by this software."
        '
        'find_program_btn
        '
        Me.find_program_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.find_program_btn.Location = New System.Drawing.Point(274, 229)
        Me.find_program_btn.Name = "find_program_btn"
        Me.find_program_btn.Size = New System.Drawing.Size(137, 40)
        Me.find_program_btn.TabIndex = 2
        Me.find_program_btn.Text = "Find Program"
        Me.find_program_btn.UseVisualStyleBackColor = True
        '
        'closebtn
        '
        Me.closebtn.BackColor = System.Drawing.Color.Red
        Me.closebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.closebtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.closebtn.Location = New System.Drawing.Point(643, -4)
        Me.closebtn.Name = "closebtn"
        Me.closebtn.Size = New System.Drawing.Size(40, 40)
        Me.closebtn.TabIndex = 3
        Me.closebtn.Text = "X"
        Me.closebtn.UseVisualStyleBackColor = False
        '
        'removebtn
        '
        Me.removebtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.removebtn.Location = New System.Drawing.Point(274, 275)
        Me.removebtn.Name = "removebtn"
        Me.removebtn.Size = New System.Drawing.Size(205, 40)
        Me.removebtn.TabIndex = 2
        Me.removebtn.Text = "Remove Highlighted"
        Me.removebtn.UseVisualStyleBackColor = True
        '
        'ignorelistbox
        '
        Me.ignorelistbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.ignorelistbox.FormattingEnabled = True
        Me.ignorelistbox.HorizontalScrollbar = True
        Me.ignorelistbox.ItemHeight = 16
        Me.ignorelistbox.Location = New System.Drawing.Point(12, 183)
        Me.ignorelistbox.Name = "ignorelistbox"
        Me.ignorelistbox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.ignorelistbox.Size = New System.Drawing.Size(256, 196)
        Me.ignorelistbox.TabIndex = 4
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Button2.Location = New System.Drawing.Point(574, 339)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(93, 40)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Save List"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'OpenFileBox
        '
        Me.OpenFileBox.Filter = "Executable|*.exe"
        '
        'add_running_btn
        '
        Me.add_running_btn.Enabled = False
        Me.add_running_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.add_running_btn.Location = New System.Drawing.Point(274, 183)
        Me.add_running_btn.Name = "add_running_btn"
        Me.add_running_btn.Size = New System.Drawing.Size(137, 40)
        Me.add_running_btn.TabIndex = 2
        Me.add_running_btn.Text = "Add Running"
        Me.add_running_btn.UseVisualStyleBackColor = True
        '
        'running_listbox
        '
        Me.running_listbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.running_listbox.DropDownWidth = 400
        Me.running_listbox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.running_listbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.running_listbox.FormattingEnabled = True
        Me.running_listbox.Location = New System.Drawing.Point(417, 188)
        Me.running_listbox.Name = "running_listbox"
        Me.running_listbox.Size = New System.Drawing.Size(223, 32)
        Me.running_listbox.Sorted = True
        Me.running_listbox.TabIndex = 6
        '
        'RefreshProc
        '
        Me.RefreshProc.AutoSize = True
        Me.RefreshProc.BackColor = System.Drawing.Color.Transparent
        Me.RefreshProc.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.RefreshProc.Location = New System.Drawing.Point(637, 187)
        Me.RefreshProc.Name = "RefreshProc"
        Me.RefreshProc.Size = New System.Drawing.Size(46, 31)
        Me.RefreshProc.TabIndex = 7
        Me.RefreshProc.Text = "🔃"
        '
        'ignorelistform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(679, 386)
        Me.Controls.Add(Me.running_listbox)
        Me.Controls.Add(Me.RefreshProc)
        Me.Controls.Add(Me.ignorelistbox)
        Me.Controls.Add(Me.closebtn)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.removebtn)
        Me.Controls.Add(Me.add_running_btn)
        Me.Controls.Add(Me.find_program_btn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ignorelistform"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Ignore List"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents find_program_btn As Button
    Friend WithEvents closebtn As Button
    Friend WithEvents removebtn As Button
    Friend WithEvents ignorelistbox As ListBox
    Friend WithEvents Button2 As Button
    Friend WithEvents OpenFileBox As OpenFileDialog
    Friend WithEvents add_running_btn As Button
    Friend WithEvents running_listbox As ComboBox
    Friend WithEvents RefreshProc As Label
End Class
