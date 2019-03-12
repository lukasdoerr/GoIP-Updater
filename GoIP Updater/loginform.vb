Imports GoIP_Updater.goip_updater


Public Class loginform

    Dim goip As New goip_updater

    Private Sub loginform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_version.Text = goip.get_version


        'Wir prüfen zuerst, ob eine Verbindung zum Internet vorhanden ist.
        If goip.try_connection() = False Then
            MsgBox("Keine Internetverbindung. Verbinden Sie Ihr Gerät zuerst mit dem Internet.", MsgBoxStyle.Critical, "Keine Verbindung")
            End
        Else
            'Prüfen ob autologin vorhanden.
            If My.Settings.autologin = True Then
                tb_benutzername.Text = My.Settings.username
                tb_passwort.Text = My.Settings.passwort
                tb_subdomain.Text = My.Settings.subdomain
                tb_interval.Text = My.Settings.update_interval

                cb_autologin.Checked = My.Settings.autologin
                cb_autostart.Checked = My.Settings.autostart

                Me.ShowIcon = False
                Me.ShowInTaskbar = False

                'Autologin ist aktiv. Versuchen wir den Login
                If goip.try_login(My.Settings.username, My.Settings.passwort, My.Settings.subdomain) = True Then
                    Me.Hide()
                    Me.Opacity = 0
                    updater.Show()
                    updater.t_update_ip.Interval = (My.Settings.update_interval * 1000) * 60
                Else
                    MsgBox("Die Zugangsdaten sind falsch. Bitte versuchen Sie es erneut.", MsgBoxStyle.Critical, "Login fehlgeschlagen")
                    Me.Show()
                End If
            End If
        End If


    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        Process.Start("https://rzdev.de")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (tb_benutzername.Text <> "" And tb_benutzername.Text <> Nothing) And (tb_passwort.Text <> "" And tb_passwort.Text <> Nothing) And (tb_subdomain.Text <> "" And tb_subdomain.Text <> Nothing) Then
            'Alle Daten verhanden. Probieren wir einen Aufruf.
            If goip.try_login(tb_benutzername.Text, tb_passwort.Text, tb_subdomain.Text) = True Then

                'Der Login war erfolgreich. Jetzt prüfen wir noch die anderen sachen
                If cb_autologin.Checked = True Then
                    My.Settings.autologin = True
                    My.Settings.username = tb_benutzername.Text
                    My.Settings.passwort = tb_passwort.Text
                    My.Settings.subdomain = tb_subdomain.Text
                    My.Settings.update_interval = tb_interval.Text
                    My.Settings.Save()
                Else
                    My.Settings.autologin = False
                    My.Settings.username = ""
                    My.Settings.passwort = ""
                    My.Settings.subdomain = ""
                    My.Settings.update_interval = "120"
                    My.Settings.Save()
                End If

                If cb_autostart.Checked = True Then
                    goip.set_autostart(True)
                    My.Settings.autostart = True
                    My.Settings.Save()
                Else
                    goip.set_autostart(False)
                    My.Settings.autostart = False
                    My.Settings.Save()
                End If

                Me.Hide()
                updater.Show()

                updater.t_update_ip.Interval = (My.Settings.update_interval * 1000) * 60
            Else
                'Der Login war nicht erfolgreich.
                MsgBox("Die Zugangsdaten sind falsch. Bitte versuchen Sie es erneut.", MsgBoxStyle.Critical, "Login fehlgeschlagen")
            End If
        Else
            'Es sind nicht alle Daten angegeben.
            MsgBox("Bitte geben Sie alle Informationen in die Felder ein, bevor Sie sich anmelden.", MsgBoxStyle.Critical, "Login fehlgeschlagen")
        End If
    End Sub
End Class
