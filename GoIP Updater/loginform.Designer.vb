<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class loginform
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(loginform))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tb_benutzername = New System.Windows.Forms.TextBox()
        Me.tb_passwort = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tb_subdomain = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbl_version = New System.Windows.Forms.Label()
        Me.cb_autologin = New System.Windows.Forms.CheckBox()
        Me.cb_autostart = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tb_interval = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Benutzername"
        '
        'tb_benutzername
        '
        Me.tb_benutzername.Location = New System.Drawing.Point(12, 102)
        Me.tb_benutzername.Name = "tb_benutzername"
        Me.tb_benutzername.Size = New System.Drawing.Size(214, 25)
        Me.tb_benutzername.TabIndex = 1
        '
        'tb_passwort
        '
        Me.tb_passwort.Location = New System.Drawing.Point(12, 169)
        Me.tb_passwort.Name = "tb_passwort"
        Me.tb_passwort.Size = New System.Drawing.Size(214, 25)
        Me.tb_passwort.TabIndex = 3
        Me.tb_passwort.UseSystemPasswordChar = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 147)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Passwort"
        '
        'tb_subdomain
        '
        Me.tb_subdomain.Location = New System.Drawing.Point(12, 236)
        Me.tb_subdomain.Name = "tb_subdomain"
        Me.tb_subdomain.Size = New System.Drawing.Size(214, 25)
        Me.tb_subdomain.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 214)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 19)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Subdomain"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(24, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(180, 35)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "GoIP Updater"
        '
        'lbl_version
        '
        Me.lbl_version.AutoSize = True
        Me.lbl_version.Location = New System.Drawing.Point(189, 17)
        Me.lbl_version.Name = "lbl_version"
        Me.lbl_version.Size = New System.Drawing.Size(29, 19)
        Me.lbl_version.TabIndex = 9
        Me.lbl_version.Text = "1.14"
        '
        'cb_autologin
        '
        Me.cb_autologin.AutoSize = True
        Me.cb_autologin.Location = New System.Drawing.Point(12, 278)
        Me.cb_autologin.Name = "cb_autologin"
        Me.cb_autologin.Size = New System.Drawing.Size(175, 23)
        Me.cb_autologin.TabIndex = 10
        Me.cb_autologin.Text = "Zugangsdaten speichern"
        Me.cb_autologin.UseVisualStyleBackColor = True
        '
        'cb_autostart
        '
        Me.cb_autostart.AutoSize = True
        Me.cb_autostart.Location = New System.Drawing.Point(12, 307)
        Me.cb_autostart.Name = "cb_autostart"
        Me.cb_autostart.Size = New System.Drawing.Size(150, 23)
        Me.cb_autostart.TabIndex = 11
        Me.cb_autostart.Text = "Mit Windows starten"
        Me.cb_autostart.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 426)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(214, 36)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Speichern und Anmelden"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 19)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Alle"
        '
        'tb_interval
        '
        Me.tb_interval.Location = New System.Drawing.Point(43, 29)
        Me.tb_interval.Name = "tb_interval"
        Me.tb_interval.Size = New System.Drawing.Size(100, 25)
        Me.tb_interval.TabIndex = 14
        Me.tb_interval.Text = "120"
        Me.tb_interval.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(149, 32)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 19)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Minuten"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.tb_interval)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 342)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(214, 69)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Intervall"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(19, 472)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(191, 19)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "© 2021 Lukas Dörr - RZDEV.DE"
        '
        'loginform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(238, 500)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cb_autostart)
        Me.Controls.Add(Me.cb_autologin)
        Me.Controls.Add(Me.lbl_version)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tb_subdomain)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tb_passwort)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tb_benutzername)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "loginform"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents tb_benutzername As TextBox
    Friend WithEvents tb_passwort As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tb_subdomain As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lbl_version As Label
    Friend WithEvents cb_autologin As CheckBox
    Friend WithEvents cb_autostart As CheckBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents tb_interval As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label8 As Label
End Class
