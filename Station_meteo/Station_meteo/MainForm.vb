Public Class MainForm

    Private Sub imgCarte_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub calendrier_DateChanged(sender As Object, e As DateRangeEventArgs) Handles calendrier.DateChanged
        ' code à intéger pour gérer l'événement changement de date
        ' -> doit mettre à jour les données
        Me.lsbLog.Items.Add("Changement de date")
    End Sub

    Private Sub lbStrasbourg_Click(sender As Object, e As EventArgs) Handles lbStrasbourg.Click
        ' code à intéger pour gérer l'événement click sur une ville
        ' -> doit mettre à jour les données
        Me.lsbLog.Items.Add("Chargement des données de Strasbourg")
    End Sub

    Private Sub numHeure_ValueChanged(sender As Object, e As EventArgs) Handles numHeure.ValueChanged
        ' code à intéger pour gérer l'événement changement d'heure
        ' -> doit mettre à jour les données
        Me.lsbLog.Items.Add("Changement de l'heure")
    End Sub

    Private Sub cbStation_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbStation.SelectedIndexChanged
        ' code à intéger pour gérer l'événement selection ville
        ' -> doit mettre à jour les données
        Me.lsbLog.Items.Add("Changement de ville")
    End Sub

    Private Sub btClearLog_Click(sender As Object, e As EventArgs) Handles btClearLog.Click
        Me.lsbLog.Items.Clear()
    End Sub
End Class
