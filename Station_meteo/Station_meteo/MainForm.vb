Imports System.IO

Public Structure data

    Public ville As String
    Public jour As String   ' aaaa/mm/jj
    Public heure As Integer ' 0-23

    Public temperature As Double
    Public pression As Integer
    Public dirVent As String
    Public forceVent As Double
    Public descriptionTemps As String

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

    Sub updateData(Optional ByVal ville As String = Nothing)

        If Me.database IsNot Nothing Then

            Dim donnees As data = New data()

            If ville <> Nothing Then
                donnees.ville = ville
            ElseIf Me.cbStation.SelectedText = "" Then
                donnees.ville = "Strasbourg-Entzheim"
            Else
                donnees.ville = Me.cbStation.SelectedText
            End If

            donnees.jour = Me.calendrier.SelectionRange.Start.ToString("yyyy-MM-dd")
            donnees.heure = Me.numHeure.Value

            Me.database.getData(donnees)

            Me.tbTemp.Text = (donnees.temperature).ToString() & " °C"
            Me.tbPression.Text = (donnees.pression / 100).ToString() & " hpa"
            Me.tbDirVent.Text = donnees.dirVent
            Me.tbForceVent.Text = (donnees.forceVent).ToString() & " m/s"

            Console.WriteLine(donnees.ville)
            Me.cbStation.SelectedItem = donnees.ville
        End If

    End Sub

    Private Sub calendrier_DateChanged(sender As Object, e As DateRangeEventArgs) Handles calendrier.DateChanged

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
    End Sub

    Private Sub numHeure_ValueChanged(sender As Object, e As EventArgs) Handles numHeure.ValueChanged
        Me.updateData()
    End Sub

    Private Sub cbStation_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbStation.SelectedIndexChanged
        Me.updateData()
    End Sub

    Private Sub btClearLog_Click(sender As Object, e As EventArgs) Handles btClearLog.Click
        Me.lsbLog.Items.Clear()
    End Sub

    Private Sub lbStrasbourg_Click(sender As Object, e As EventArgs) Handles lbStrasbourg.Click
        Me.updateData("Strasbourg-Entzheim")
    End Sub

    Private Sub lbOrly_Click(sender As Object, e As EventArgs) Handles lbOrly.Click
        Me.updateData("Orly")
    End Sub

    Private Sub lbNancy_Click(sender As Object, e As EventArgs) Handles lbNancy.Click
        Me.updateData("Nancy-Ochey")
    End Sub

    Private Sub lbLyon_Click(sender As Object, e As EventArgs) Handles lbLyon.Click
        Me.updateData("Lyon-Saint Exupery")
    End Sub

    Private Sub lbMontpellier_Click(sender As Object, e As EventArgs) Handles lbMontpellier.Click
        Me.updateData("Montpellier")
    End Sub

    Private Sub lbClermont_Click(sender As Object, e As EventArgs) Handles lbClermont.Click
        Me.updateData("Clermont-Ferrand")
    End Sub

    Private Sub lbToulouse_Click(sender As Object, e As EventArgs) Handles lbToulouse.Click
        Me.updateData("Toulouse-Blagnac")
    End Sub

    Private Sub lbBordeaux_Click(sender As Object, e As EventArgs) Handles lbBordeaux.Click
        Me.updateData("Bordeaux-Merignac")
    End Sub

    Private Sub lbTours_Click(sender As Object, e As EventArgs) Handles lbTours.Click
        Me.updateData("Tours")
    End Sub

    Private Sub lbRennes_Click(sender As Object, e As EventArgs) Handles lbRennes.Click
        Me.updateData("Rennes-Saint Jacques")
    End Sub

    Private Sub lbCaen_Click(sender As Object, e As EventArgs) Handles lbCaen.Click
        Me.updateData("Caen-Carpiquet")
    End Sub

    Private Sub lbLille_Click(sender As Object, e As EventArgs) Handles lbLille.Click
        Me.updateData("Lille-Lesquin")
    End Sub

    Private Sub lbTroyes_Click(sender As Object, e As EventArgs) Handles lbTroyes.Click
        Me.updateData("Troyes-Barberey")
    End Sub
End Class
