<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class updater
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(updater))
        Me.t_update_ip = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lbl_version = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.SuspendLayout()
        '
        't_update_ip
        '
        Me.t_update_ip.Enabled = True
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(2, 125)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(197, 41)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Einstellungen"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(2, 165)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(197, 41)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Beenden"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(11, 213)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(180, 17)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "© 2019 Lukas Dörr - RZDEV.DE"
        '
        'lbl_version
        '
        Me.lbl_version.AutoSize = True
        Me.lbl_version.Location = New System.Drawing.Point(170, 68)
        Me.lbl_version.Name = "lbl_version"
        Me.lbl_version.Size = New System.Drawing.Size(28, 17)
        Me.lbl_version.TabIndex = 20
        Me.lbl_version.Text = "1.12"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(5, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(180, 35)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "GoIP Updater"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(119, 9)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(69, 17)
        Me.LinkLabel1.TabIndex = 21
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Verstecken"
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "GoIP Updater"
        Me.NotifyIcon1.Visible = True
        '
        'updater
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(200, 237)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.lbl_version)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Font = New System.Drawing.Font("Microsoft YaHei Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "updater"
        Me.Opacity = 0R
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "updater"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents t_update_ip As Timer
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents lbl_version As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents NotifyIcon1 As NotifyIcon
End Class
