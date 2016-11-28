Public Class mgr_database

    Sub New()
        Me.connect()

    End Sub

    Public Sub connect(Optional ByVal ipaddr As String = "130.79.206.15",
                       Optional ByVal login As String = "fip",
                       Optional ByVal password As String = "fip")
        Console.WriteLine("connexion au serveur: " & login & ":" & password & "@" & ipaddr)

    End Sub

    Public Function getData(ByRef donnees As data)

        Console.WriteLine(donnees.station & " le " & donnees.jour & " à " & donnees.heure & "h")

        donnees.temperature = 24.2
        donnees.pression = 102400
        donnees.dirVent = "Nord Est"
        donnees.forceVent = 3.0

        Return donnees

    End Function

    Public Function getAllVilles()
        Dim villes As List(Of String) = New List(Of String)

        villes.Add("Ville 1")
        villes.Add("Ville 2")

        Return villes

    End Function

End Class
