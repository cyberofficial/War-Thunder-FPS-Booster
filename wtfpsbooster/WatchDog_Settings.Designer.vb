<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class WatchDog_Settings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WatchDog_Settings))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.WDS_Num = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.wdgod_settings_exit_btn = New System.Windows.Forms.Button()
        CType(Me.WDS_Num, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(-6, -6)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(466, 55)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Watch Dog Settings"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(-2, 54)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(545, 145)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = resources.GetString("Label2.Text")
        '
        'WDS_Num
        '
        Me.WDS_Num.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.WDS_Num.Location = New System.Drawing.Point(216, 237)
        Me.WDS_Num.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.WDS_Num.Maximum = New Decimal(New Integer() {60000, 0, 0, 0})
        Me.WDS_Num.Minimum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.WDS_Num.Name = "WDS_Num"
        Me.WDS_Num.Size = New System.Drawing.Size(170, 44)
        Me.WDS_Num.TabIndex = 2
        Me.WDS_Num.Value = New Decimal(New Integer() {20000, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(18, 237)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(393, 150)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Watch Dog Clock" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "1 Second = 1000" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Min: 10 Seconds | Max 60 Seconds" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Anything over" &
    " 60 is a sign of no return." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Default is 20 Seconds, Older PCs might" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "want to use" &
    " 30/45 Seconds."
        '
        'Button1
        '
        Me.Button1.AutoSize = True
        Me.Button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Button1.BackColor = System.Drawing.Color.Green
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.Button1.FlatAppearance.BorderSize = 2
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.Location = New System.Drawing.Point(0, 436)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(568, 44)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'wdgod_settings_exit_btn
        '
        Me.wdgod_settings_exit_btn.AutoSize = True
        Me.wdgod_settings_exit_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.wdgod_settings_exit_btn.BackColor = System.Drawing.Color.Red
        Me.wdgod_settings_exit_btn.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.wdgod_settings_exit_btn.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.wdgod_settings_exit_btn.FlatAppearance.BorderSize = 2
        Me.wdgod_settings_exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.wdgod_settings_exit_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.wdgod_settings_exit_btn.Location = New System.Drawing.Point(0, 480)
        Me.wdgod_settings_exit_btn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.wdgod_settings_exit_btn.Name = "wdgod_settings_exit_btn"
        Me.wdgod_settings_exit_btn.Size = New System.Drawing.Size(568, 47)
        Me.wdgod_settings_exit_btn.TabIndex = 8
        Me.wdgod_settings_exit_btn.Text = "Close without saving"
        Me.wdgod_settings_exit_btn.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.wdgod_settings_exit_btn.UseVisualStyleBackColor = False
        '
        'WatchDog_Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(144.0!, 144.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(568, 527)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.wdgod_settings_exit_btn)
        Me.Controls.Add(Me.WDS_Num)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "WatchDog_Settings"
        Me.Opacity = 0.9R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "WatchDog_Settings"
        CType(Me.WDS_Num, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents WDS_Num As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents wdgod_settings_exit_btn As Button
End Class
