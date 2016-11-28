Imports System.IO

Public Structure data

    Public station As String
    Public jour As String
    Public heure As Integer

    Public temperature As Double
    Public pression As Integer
    Public dirVent As String
    Public forceVent As Double

End Structure

Public Class MainForm

    Dim database As mgr_database

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        ' Instanciation du CONTROLLER
        Me.database = New mgr_database()


        ' Mise à jour de la liste des villes disponibles
        For Each ville In Me.database.getAllVilles()
            Me.cbStation.Items.Add(ville)
        Next ville

    End Sub

    Sub updateData()

        If Me.database IsNot Nothing Then

            Dim donnees As data = New data()

            donnees.station = Me.cbStation.SelectedItem
            donnees.jour = Me.calendrier.SelectionRange.Start.ToShortDateString()
            donnees.heure = Me.numHeure.Value

            Me.database.getData(donnees)

            Me.tbTemp.Text = (donnees.temperature).ToString() & " °C"
            Me.tbPression.Text = (donnees.pression / 100).ToString() & " hpa"
            Me.tbDirVent.Text = donnees.dirVent
            Me.tbForceVent.Text = (donnees.forceVent).ToString() & " m/s"

        End If


    End Sub


    Private Sub calendrier_DateChanged(sender As Object, e As DateRangeEventArgs) Handles calendrier.DateChanged
        ' code à intéger pour gérer l'événement changement de date
        ' -> doit mettre à jour les données

        If Me.calendrier.SelectionRange.Start.ToShortDateString() = "12/11/2012" Then
            Me.numHeure.Maximum = 6
            Me.numHeure.Minimum = 0
            Me.numHeure.Value = 6

        ElseIf Me.calendrier.SelectionRange.Start.ToShortDateString() = "19/10/2012" Then
            Me.numHeure.Maximum = 23
            Me.numHeure.Minimum = 12
            Me.numHeure.Value = 12

        Else
            Me.numHeure.Maximum = 23
            Me.numHeure.Minimum = 0
            Me.numHeure.Value = 12

        End If

        Me.updateData()

        Me.lsbLog.Items.Add("Changement de date")
    End Sub

    Private Sub lbStrasbourg_Click(sender As Object, e As EventArgs) Handles lbStrasbourg.Click
        ' code à intéger pour gérer l'événement click sur une ville
        ' -> doit mettre à jour les données

        Me.updateData()

        Me.lsbLog.Items.Add("Chargement des données de Strasbourg")
    End Sub

    Private Sub numHeure_ValueChanged(sender As Object, e As EventArgs) Handles numHeure.ValueChanged
        ' code à intéger pour gérer l'événement changement d'heure
        ' -> doit mettre à jour les données

        Me.updateData()

        Me.lsbLog.Items.Add("Changement de l'heure")
    End Sub

    Private Sub cbStation_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbStation.SelectedIndexChanged
        ' code à intéger pour gérer l'événement selection ville
        ' -> doit mettre à jour les données

        Me.updateData()

        Me.lsbLog.Items.Add("Changement de ville")
    End Sub

    Private Sub btClearLog_Click(sender As Object, e As EventArgs) Handles btClearLog.Click
        Me.lsbLog.Items.Clear()
    End Sub
End Class
