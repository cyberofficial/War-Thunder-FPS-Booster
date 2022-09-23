<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class splash
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(splash))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.isadmin_box = New System.Windows.Forms.CheckBox()
        Me.iagree_box = New System.Windows.Forms.CheckBox()
        Me.start_app = New System.Windows.Forms.Button()
        Me.exit_app = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label1.Font = New System.Drawing.Font("Detente", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 449)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(436, 60)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "WT FPS Booster"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'isadmin_box
        '
        Me.isadmin_box.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.isadmin_box.AutoSize = True
        Me.isadmin_box.Enabled = False
        Me.isadmin_box.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.isadmin_box.ForeColor = System.Drawing.Color.SeaShell
        Me.isadmin_box.Location = New System.Drawing.Point(226, 381)
        Me.isadmin_box.Name = "isadmin_box"
        Me.isadmin_box.Size = New System.Drawing.Size(79, 26)
        Me.isadmin_box.TabIndex = 3
        Me.isadmin_box.Text = "Admin"
        Me.isadmin_box.UseVisualStyleBackColor = True
        '
        'iagree_box
        '
        Me.iagree_box.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.iagree_box.AutoSize = True
        Me.iagree_box.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.iagree_box.Location = New System.Drawing.Point(50, 381)
        Me.iagree_box.Name = "iagree_box"
        Me.iagree_box.Size = New System.Drawing.Size(89, 26)
        Me.iagree_box.TabIndex = 3
        Me.iagree_box.Text = "I agree."
        Me.iagree_box.UseVisualStyleBackColor = True
        '
        'start_app
        '
        Me.start_app.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.start_app.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.start_app.Location = New System.Drawing.Point(50, 413)
        Me.start_app.Name = "start_app"
        Me.start_app.Size = New System.Drawing.Size(170, 31)
        Me.start_app.TabIndex = 4
        Me.start_app.Text = "Start Application"
        Me.start_app.UseVisualStyleBackColor = True
        '
        'exit_app
        '
        Me.exit_app.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.exit_app.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.exit_app.Location = New System.Drawing.Point(226, 413)
        Me.exit_app.Name = "exit_app"
        Me.exit_app.Size = New System.Drawing.Size(170, 31)
        Me.exit_app.TabIndex = 4
        Me.exit_app.Text = "Exit Application"
        Me.exit_app.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Red
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.TextBox1.Location = New System.Drawing.Point(0, 0)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(436, 293)
        Me.TextBox1.TabIndex = 5
        Me.TextBox1.Text = resources.GetString("TextBox1.Text")
        '
        'splash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Red
        Me.ClientSize = New System.Drawing.Size(436, 509)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.exit_app)
        Me.Controls.Add(Me.start_app)
        Me.Controls.Add(Me.iagree_box)
        Me.Controls.Add(Me.isadmin_box)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "splash"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "INFO WARNING"
        Me.TransparencyKey = System.Drawing.Color.Transparent
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents isadmin_box As CheckBox
    Friend WithEvents iagree_box As CheckBox
    Friend WithEvents start_app As Button
    Friend WithEvents exit_app As Button
    Friend WithEvents TextBox1 As TextBox
End Class
