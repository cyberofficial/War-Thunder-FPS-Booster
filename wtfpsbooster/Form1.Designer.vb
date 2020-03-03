<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.wtstatus = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.aboost = New System.Windows.Forms.CheckBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.bbtn = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.pclist = New System.Windows.Forms.CheckedListBox()
        Me.rfspcl = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cs = New System.Windows.Forms.CheckedListBox()
        Me.fcp2 = New System.Windows.Forms.Button()
        Me.tauto = New System.Windows.Forms.Timer(Me.components)
        Me.BoostWorker = New System.ComponentModel.BackgroundWorker()
        Me.RestoreWorker = New System.ComponentModel.BackgroundWorker()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.SkyBlue
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.wtstatus)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.aboost)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.bbtn)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(546, 258)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Boost or Restore"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(8, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(484, 80)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = resources.GetString("Label2.Text")
        '
        'wtstatus
        '
        Me.wtstatus.AutoSize = True
        Me.wtstatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.wtstatus.ForeColor = System.Drawing.Color.BlueViolet
        Me.wtstatus.Location = New System.Drawing.Point(162, 15)
        Me.wtstatus.Name = "wtstatus"
        Me.wtstatus.Size = New System.Drawing.Size(191, 26)
        Me.wtstatus.TabIndex = 6
        Me.wtstatus.Text = "Checking for WT..."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.Label1.Location = New System.Drawing.Point(3, 136)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(316, 29)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "War Thunder Status: Normal"
        '
        'aboost
        '
        Me.aboost.AutoSize = True
        Me.aboost.Location = New System.Drawing.Point(224, 235)
        Me.aboost.Name = "aboost"
        Me.aboost.Size = New System.Drawing.Size(84, 17)
        Me.aboost.TabIndex = 5
        Me.aboost.Text = "Auto Control"
        Me.aboost.UseVisualStyleBackColor = True
        Me.aboost.Visible = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(87, 19)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Restore CPU"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'bbtn
        '
        Me.bbtn.Enabled = False
        Me.bbtn.Location = New System.Drawing.Point(6, 19)
        Me.bbtn.Name = "bbtn"
        Me.bbtn.Size = New System.Drawing.Size(75, 23)
        Me.bbtn.TabIndex = 3
        Me.bbtn.Text = "Boost"
        Me.bbtn.UseVisualStyleBackColor = True
        Me.bbtn.Visible = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(560, 290)
        Me.TabControl1.TabIndex = 5
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(552, 264)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Main Settings"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox4)
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(552, 209)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Advanced Settings"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.SkyBlue
        Me.GroupBox4.Controls.Add(Me.pclist)
        Me.GroupBox4.Controls.Add(Me.rfspcl)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox4.Location = New System.Drawing.Point(3, 118)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(546, 88)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Select Which Programs to force onto the cores chosen."
        '
        'pclist
        '
        Me.pclist.BackColor = System.Drawing.Color.SkyBlue
        Me.pclist.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pclist.FormattingEnabled = True
        Me.pclist.Location = New System.Drawing.Point(3, 16)
        Me.pclist.Name = "pclist"
        Me.pclist.Size = New System.Drawing.Size(540, 46)
        Me.pclist.Sorted = True
        Me.pclist.TabIndex = 0
        '
        'rfspcl
        '
        Me.rfspcl.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.rfspcl.Location = New System.Drawing.Point(3, 62)
        Me.rfspcl.Name = "rfspcl"
        Me.rfspcl.Size = New System.Drawing.Size(540, 23)
        Me.rfspcl.TabIndex = 1
        Me.rfspcl.Text = "Refresh Process List"
        Me.rfspcl.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.SkyBlue
        Me.GroupBox3.Controls.Add(Me.cs)
        Me.GroupBox3.Controls.Add(Me.fcp2)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox3.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(546, 115)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Select Cores to Use"
        '
        'cs
        '
        Me.cs.BackColor = System.Drawing.Color.SkyBlue
        Me.cs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cs.FormattingEnabled = True
        Me.cs.Location = New System.Drawing.Point(3, 16)
        Me.cs.MultiColumn = True
        Me.cs.Name = "cs"
        Me.cs.Size = New System.Drawing.Size(540, 73)
        Me.cs.TabIndex = 0
        '
        'fcp2
        '
        Me.fcp2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.fcp2.Location = New System.Drawing.Point(3, 89)
        Me.fcp2.Name = "fcp2"
        Me.fcp2.Size = New System.Drawing.Size(540, 23)
        Me.fcp2.TabIndex = 1
        Me.fcp2.Text = "Force Checked Processes"
        Me.fcp2.UseVisualStyleBackColor = True
        '
        'tauto
        '
        Me.tauto.Enabled = True
        Me.tauto.Interval = 4000
        '
        'BoostWorker
        '
        '
        'RestoreWorker
        '
        Me.RestoreWorker.WorkerReportsProgress = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ClientSize = New System.Drawing.Size(560, 290)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(342, 183)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "War Thunder FPS Booster"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents bbtn As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cs As System.Windows.Forms.CheckedListBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents pclist As System.Windows.Forms.CheckedListBox
    Friend WithEvents rfspcl As System.Windows.Forms.Button
    Friend WithEvents fcp2 As System.Windows.Forms.Button
    Friend WithEvents wtstatus As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents aboost As System.Windows.Forms.CheckBox
    Friend WithEvents tauto As System.Windows.Forms.Timer
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BoostWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents RestoreWorker As System.ComponentModel.BackgroundWorker

End Class
