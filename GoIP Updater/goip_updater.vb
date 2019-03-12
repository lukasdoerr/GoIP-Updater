Imports System.Net
Imports System.IO

Public Class goip_updater
    Public Function try_connection()

        'Deklaration für Web Aufruf
        Dim inStream As StreamReader
        Dim webRequest As WebRequest
        Dim webresponse As WebResponse

        Try
            'Versuche eine Verbindung zu RZDEV.DE herzustellen
            webRequest = WebRequest.Create("https://rzdev.de/")
            webresponse = webRequest.GetResponse()
            inStream = New StreamReader(webresponse.GetResponseStream())

            'Falls es erfolgreich war
            Return True
        Catch ex As Exception
            'Falls nicht..
            Return False
        End Try
    End Function


    Public Function try_login(benutzername, passwort, subdomain)
        'Deklaration für Web Aufruf

        Dim inStream As StreamReader
        Dim webRequest As WebRequest
        Dim webresponse As WebResponse
        Dim url As String = "https://www.goip.de/setip?username=" & benutzername & "&password=" & passwort & "&subdomain=" & subdomain & "&shortResponse=true"

        Try
            'Load Data from URL
            webRequest = WebRequest.Create(url)
            webresponse = webRequest.GetResponse()
            inStream = New StreamReader(webresponse.GetResponseStream())
            Dim WebAnswer As String = inStream.ReadToEnd().ToString()
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function set_autostart(ByVal AutostartEnable As Boolean)
        Dim key As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Run", True)
        If AutostartEnable = True Then
            key.SetValue(My.Application.Info.AssemblyName, System.Reflection.Assembly.GetEntryAssembly.Location)
        Else
            key.DeleteValue(My.Application.Info.AssemblyName, False)
        End If
        key.Close()
        Return AutostartEnable
    End Function

    Public Function get_version()
        Return "1.13"
    End Function

End Class
