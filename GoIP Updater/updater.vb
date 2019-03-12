Imports GoIP_Updater.goip_updater

Public Class updater

    Dim goip As New goip_updater

    Private Sub t_update_ip_Tick(sender As Object, e As EventArgs) Handles t_update_ip.Tick
        If goip.try_login(My.Settings.username, My.Settings.passwort, My.Settings.subdomain) = False Then
            t_update_ip.Enabled = False
            t_update_ip.Stop()
            MsgBox("Es ist ein Fehler beim Aktualisieren der IP Adresse aufgetreten." & vbNewLine & vbNewLine & "Prüfen Sie Ihre Zugangsdaten, Ihre Internetverbindung und starten Sie das Programm neu.", MsgBoxStyle.Critical, "Verbindungsfehler")
            End
        End If
    End Sub

    Private Sub updater_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_version.Text = goip.get_version
        Me.Location = New Point(Screen.PrimaryScreen.WorkingArea.Width - Me.Width, Screen.PrimaryScreen.WorkingArea.Height - Me.Height)
        loginform.Hide()
        NotifyIcon1.Visible = True
        NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info
        NotifyIcon1.BalloonTipTitle = "GoIP Updater"
        NotifyIcon1.BalloonTipText = "GoIP Updater läuft im Hintergrund" & vbNewLine & "Der Login war erfolgreich."
        NotifyIcon1.ShowBalloonTip(3000)
        Me.Hide()
        ShowInTaskbar = False
        ShowIcon = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        loginform.Show()
        loginform.Opacity = 100
        loginform.ShowIcon = True
        loginform.ShowInTaskbar = True
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        Process.Start("https://rzdev.de/")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If MessageBox.Show("Sind Sie sicher, dass Sie GoIP Updater beenden möchten?", "Beenden", MessageBoxButtons.YesNo) _
              = Windows.Forms.DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        NotifyIcon1.Visible = True
        NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info
        NotifyIcon1.BalloonTipTitle = "GoIP Updater"
        NotifyIcon1.BalloonTipText = "GoIP Updater läuft im Hintergrund" & vbNewLine & "Der Login war erfolgreich."
        NotifyIcon1.ShowBalloonTip(3000)
        Me.Hide()
        ShowInTaskbar = False
        ShowIcon = False
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        Me.Show()
        ShowInTaskbar = True
        ShowIcon = True
        Me.WindowState = FormWindowState.Normal
        Me.Location = New Point(Screen.PrimaryScreen.WorkingArea.Width - Me.Width, Screen.PrimaryScreen.WorkingArea.Height - Me.Height)
        Me.Opacity = 100
    End Sub
End Class