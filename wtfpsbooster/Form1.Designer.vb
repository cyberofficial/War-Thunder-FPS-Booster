﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.InfoBox = New System.Windows.Forms.TextBox()
        Me.BoostBtn = New System.Windows.Forms.Button()
        Me.wtstatus = New System.Windows.Forms.Label()
        Me.pcstatus_txt = New System.Windows.Forms.Label()
        Me.RestoreBtn = New System.Windows.Forms.Button()
        Me.MainControlPanel = New System.Windows.Forms.TabControl()
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
        Me.LeftPanel = New System.Windows.Forms.Panel()
        Me.ignorelist_btn = New System.Windows.Forms.Button()
        Me.ExtraBoost = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.WatchDog = New System.Windows.Forms.Timer(Me.components)
        Me.WatchDogTxt = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BoostWorker_New_25 = New System.ComponentModel.BackgroundWorker()
        Me.WatchDogWaiter = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.drop_app_admin = New System.Windows.Forms.Button()
        Me.start_btn = New System.Windows.Forms.Button()
        Me.MainControlPanel.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.LeftPanel.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.SkyBlue
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(4, 4)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(923, 412)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Boost or Restore"
        '
        'InfoBox
        '
        Me.InfoBox.BackColor = System.Drawing.Color.Linen
        Me.InfoBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.InfoBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.InfoBox.Location = New System.Drawing.Point(0, 320)
        Me.InfoBox.Margin = New System.Windows.Forms.Padding(4)
        Me.InfoBox.Multiline = True
        Me.InfoBox.Name = "InfoBox"
        Me.InfoBox.ReadOnly = True
        Me.InfoBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.InfoBox.Size = New System.Drawing.Size(402, 289)
        Me.InfoBox.TabIndex = 9
        Me.InfoBox.Text = resources.GetString("InfoBox.Text")
        '
        'BoostBtn
        '
        Me.BoostBtn.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.BoostBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.BoostBtn.FlatAppearance.BorderColor = System.Drawing.Color.Blue
        Me.BoostBtn.FlatAppearance.BorderSize = 5
        Me.BoostBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BoostBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BoostBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BoostBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.BoostBtn.Location = New System.Drawing.Point(0, 64)
        Me.BoostBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.BoostBtn.Name = "BoostBtn"
        Me.BoostBtn.Size = New System.Drawing.Size(402, 64)
        Me.BoostBtn.TabIndex = 8
        Me.BoostBtn.Text = "Re-Boost"
        Me.BoostBtn.UseVisualStyleBackColor = False
        Me.BoostBtn.Visible = False
        '
        'wtstatus
        '
        Me.wtstatus.AutoSize = True
        Me.wtstatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold)
        Me.wtstatus.ForeColor = System.Drawing.SystemColors.ControlText
        Me.wtstatus.Location = New System.Drawing.Point(410, 552)
        Me.wtstatus.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.wtstatus.Name = "wtstatus"
        Me.wtstatus.Size = New System.Drawing.Size(360, 46)
        Me.wtstatus.TabIndex = 6
        Me.wtstatus.Text = "Application Ready"
        '
        'pcstatus_txt
        '
        Me.pcstatus_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pcstatus_txt.Location = New System.Drawing.Point(410, 11)
        Me.pcstatus_txt.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.pcstatus_txt.Name = "pcstatus_txt"
        Me.pcstatus_txt.Size = New System.Drawing.Size(781, 366)
        Me.pcstatus_txt.TabIndex = 6
        Me.pcstatus_txt.Text = "PC Status: Normal"
        '
        'RestoreBtn
        '
        Me.RestoreBtn.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.RestoreBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.RestoreBtn.FlatAppearance.BorderColor = System.Drawing.Color.Blue
        Me.RestoreBtn.FlatAppearance.BorderSize = 5
        Me.RestoreBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.RestoreBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RestoreBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RestoreBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RestoreBtn.Location = New System.Drawing.Point(0, 192)
        Me.RestoreBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.RestoreBtn.Name = "RestoreBtn"
        Me.RestoreBtn.Size = New System.Drawing.Size(402, 64)
        Me.RestoreBtn.TabIndex = 4
        Me.RestoreBtn.Text = "Remove Boost"
        Me.RestoreBtn.UseVisualStyleBackColor = False
        '
        'MainControlPanel
        '
        Me.MainControlPanel.Controls.Add(Me.TabPage1)
        Me.MainControlPanel.Controls.Add(Me.TabPage2)
        Me.MainControlPanel.Location = New System.Drawing.Point(1216, 689)
        Me.MainControlPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.MainControlPanel.Name = "MainControlPanel"
        Me.MainControlPanel.SelectedIndex = 0
        Me.MainControlPanel.Size = New System.Drawing.Size(939, 449)
        Me.MainControlPanel.TabIndex = 5
        Me.MainControlPanel.Visible = False
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Size = New System.Drawing.Size(931, 420)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Main Settings"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox4)
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Size = New System.Drawing.Size(931, 420)
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
        Me.GroupBox4.Location = New System.Drawing.Point(4, 152)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Size = New System.Drawing.Size(923, 264)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Select Which Programs to force onto the cores chosen."
        '
        'pclist
        '
        Me.pclist.BackColor = System.Drawing.Color.SkyBlue
        Me.pclist.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pclist.FormattingEnabled = True
        Me.pclist.Location = New System.Drawing.Point(4, 19)
        Me.pclist.Margin = New System.Windows.Forms.Padding(4)
        Me.pclist.Name = "pclist"
        Me.pclist.Size = New System.Drawing.Size(915, 212)
        Me.pclist.Sorted = True
        Me.pclist.TabIndex = 0
        '
        'rfspcl
        '
        Me.rfspcl.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.rfspcl.Location = New System.Drawing.Point(4, 231)
        Me.rfspcl.Margin = New System.Windows.Forms.Padding(4)
        Me.rfspcl.Name = "rfspcl"
        Me.rfspcl.Size = New System.Drawing.Size(915, 29)
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
        Me.GroupBox3.Location = New System.Drawing.Point(4, 4)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(923, 148)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Select Cores to Use"
        '
        'cs
        '
        Me.cs.BackColor = System.Drawing.Color.SkyBlue
        Me.cs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cs.FormattingEnabled = True
        Me.cs.Location = New System.Drawing.Point(4, 19)
        Me.cs.Margin = New System.Windows.Forms.Padding(4)
        Me.cs.MultiColumn = True
        Me.cs.Name = "cs"
        Me.cs.Size = New System.Drawing.Size(915, 96)
        Me.cs.TabIndex = 0
        '
        'fcp2
        '
        Me.fcp2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.fcp2.Location = New System.Drawing.Point(4, 115)
        Me.fcp2.Margin = New System.Windows.Forms.Padding(4)
        Me.fcp2.Name = "fcp2"
        Me.fcp2.Size = New System.Drawing.Size(915, 29)
        Me.fcp2.TabIndex = 1
        Me.fcp2.Text = "Force Checked Processes"
        Me.fcp2.UseVisualStyleBackColor = True
        '
        'tauto
        '
        Me.tauto.Interval = 2000
        '
        'BoostWorker
        '
        '
        'RestoreWorker
        '
        Me.RestoreWorker.WorkerReportsProgress = True
        '
        'LeftPanel
        '
        Me.LeftPanel.BackColor = System.Drawing.Color.LightCoral
        Me.LeftPanel.Controls.Add(Me.InfoBox)
        Me.LeftPanel.Controls.Add(Me.ignorelist_btn)
        Me.LeftPanel.Controls.Add(Me.RestoreBtn)
        Me.LeftPanel.Controls.Add(Me.ExtraBoost)
        Me.LeftPanel.Controls.Add(Me.BoostBtn)
        Me.LeftPanel.Controls.Add(Me.start_btn)
        Me.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.LeftPanel.Location = New System.Drawing.Point(0, 0)
        Me.LeftPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.LeftPanel.Name = "LeftPanel"
        Me.LeftPanel.Size = New System.Drawing.Size(402, 609)
        Me.LeftPanel.TabIndex = 6
        '
        'ignorelist_btn
        '
        Me.ignorelist_btn.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ignorelist_btn.Dock = System.Windows.Forms.DockStyle.Top
        Me.ignorelist_btn.FlatAppearance.BorderColor = System.Drawing.Color.Blue
        Me.ignorelist_btn.FlatAppearance.BorderSize = 5
        Me.ignorelist_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ignorelist_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ignorelist_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ignorelist_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ignorelist_btn.Location = New System.Drawing.Point(0, 256)
        Me.ignorelist_btn.Margin = New System.Windows.Forms.Padding(4)
        Me.ignorelist_btn.Name = "ignorelist_btn"
        Me.ignorelist_btn.Size = New System.Drawing.Size(402, 64)
        Me.ignorelist_btn.TabIndex = 11
        Me.ignorelist_btn.Text = "Ignore List"
        Me.ignorelist_btn.UseVisualStyleBackColor = False
        Me.ignorelist_btn.Visible = False
        '
        'ExtraBoost
        '
        Me.ExtraBoost.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ExtraBoost.Dock = System.Windows.Forms.DockStyle.Top
        Me.ExtraBoost.FlatAppearance.BorderColor = System.Drawing.Color.Blue
        Me.ExtraBoost.FlatAppearance.BorderSize = 5
        Me.ExtraBoost.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod
        Me.ExtraBoost.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ExtraBoost.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ExtraBoost.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.ExtraBoost.Location = New System.Drawing.Point(0, 128)
        Me.ExtraBoost.Margin = New System.Windows.Forms.Padding(4)
        Me.ExtraBoost.Name = "ExtraBoost"
        Me.ExtraBoost.Size = New System.Drawing.Size(402, 64)
        Me.ExtraBoost.TabIndex = 10
        Me.ExtraBoost.Text = "Extra Boost"
        Me.ExtraBoost.UseVisualStyleBackColor = False
        Me.ExtraBoost.Visible = False
        '
        'Button3
        '
        Me.Button3.AutoSize = True
        Me.Button3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Button3.BackColor = System.Drawing.Color.Red
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.Button3.FlatAppearance.BorderSize = 2
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Button3.Location = New System.Drawing.Point(1249, 0)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(45, 43)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "X"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button3.UseVisualStyleBackColor = False
        '
        'WatchDog
        '
        Me.WatchDog.Interval = 10000
        '
        'WatchDogTxt
        '
        Me.WatchDogTxt.AutoSize = True
        Me.WatchDogTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold)
        Me.WatchDogTxt.ForeColor = System.Drawing.SystemColors.ControlText
        Me.WatchDogTxt.Location = New System.Drawing.Point(476, 502)
        Me.WatchDogTxt.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.WatchDogTxt.Name = "WatchDogTxt"
        Me.WatchDogTxt.Size = New System.Drawing.Size(266, 46)
        Me.WatchDogTxt.TabIndex = 6
        Me.WatchDogTxt.Text = "Watch Dog: -"
        '
        'Button1
        '
        Me.Button1.AutoSize = True
        Me.Button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Button1.BackColor = System.Drawing.Color.Chartreuse
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Chartreuse
        Me.Button1.FlatAppearance.BorderSize = 2
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Button1.Location = New System.Drawing.Point(1199, 0)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(41, 43)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "_"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.UseVisualStyleBackColor = False
        '
        'BoostWorker_New_25
        '
        '
        'WatchDogWaiter
        '
        Me.WatchDogWaiter.Interval = 1000
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.wtfpsbooster.My.Resources.Resources.gearcog
        Me.PictureBox1.Location = New System.Drawing.Point(419, 502)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 46)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'drop_app_admin
        '
        Me.drop_app_admin.AllowDrop = True
        Me.drop_app_admin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.drop_app_admin.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.drop_app_admin.Location = New System.Drawing.Point(670, 231)
        Me.drop_app_admin.Name = "drop_app_admin"
        Me.drop_app_admin.Size = New System.Drawing.Size(319, 109)
        Me.drop_app_admin.TabIndex = 10
        Me.drop_app_admin.Text = "Drop Steam or War Thunder Launcher Here"
        Me.drop_app_admin.UseVisualStyleBackColor = True
        Me.drop_app_admin.Visible = False
        '
        'start_btn
        '
        Me.start_btn.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.start_btn.Dock = System.Windows.Forms.DockStyle.Top
        Me.start_btn.FlatAppearance.BorderColor = System.Drawing.Color.Blue
        Me.start_btn.FlatAppearance.BorderSize = 5
        Me.start_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.start_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.start_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.start_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.start_btn.Location = New System.Drawing.Point(0, 0)
        Me.start_btn.Margin = New System.Windows.Forms.Padding(4)
        Me.start_btn.Name = "start_btn"
        Me.start_btn.Size = New System.Drawing.Size(402, 64)
        Me.start_btn.TabIndex = 12
        Me.start_btn.Text = "Enable Boosting Tool"
        Me.start_btn.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ClientSize = New System.Drawing.Size(1296, 609)
        Me.Controls.Add(Me.drop_app_admin)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.LeftPanel)
        Me.Controls.Add(Me.WatchDogTxt)
        Me.Controls.Add(Me.wtstatus)
        Me.Controls.Add(Me.MainControlPanel)
        Me.Controls.Add(Me.pcstatus_txt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(956, 421)
        Me.Name = "Form1"
        Me.Opacity = 0.95R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "War Thunder FPS Booster"
        Me.MainControlPanel.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.LeftPanel.ResumeLayout(False)
        Me.LeftPanel.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RestoreBtn As System.Windows.Forms.Button
    Friend WithEvents MainControlPanel As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cs As System.Windows.Forms.CheckedListBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents pclist As System.Windows.Forms.CheckedListBox
    Friend WithEvents rfspcl As System.Windows.Forms.Button
    Friend WithEvents fcp2 As System.Windows.Forms.Button
    Friend WithEvents wtstatus As System.Windows.Forms.Label
    Friend WithEvents pcstatus_txt As System.Windows.Forms.Label
    Friend WithEvents tauto As System.Windows.Forms.Timer
    Friend WithEvents BoostWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents RestoreWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents BoostBtn As Button
    Friend WithEvents InfoBox As TextBox
    Friend WithEvents LeftPanel As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents ExtraBoost As Button
    Friend WithEvents WatchDog As Timer
    Friend WithEvents WatchDogTxt As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BoostWorker_New_25 As System.ComponentModel.BackgroundWorker
    Friend WithEvents WatchDogWaiter As Timer
    Friend WithEvents ignorelist_btn As Button
    Friend WithEvents drop_app_admin As Button
    Friend WithEvents start_btn As Button
End Class
