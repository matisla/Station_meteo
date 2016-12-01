Imports System.IO

Public Structure data

    Public ville As String
    Public jour As String   ' yyyy-mm-dd
    Public heure As Integer ' 0-23

    Public temperature As Double
    Public pression As Integer
    Public dirVent As String
    Public forceVent As Double
    Public descriptionTemps As String

End Structure

Public Class MainForm

    Dim database As mgr_database
    Dim c_ville As String = Nothing

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        ' Instanciation du CONTROLLER
        Me.database = New mgr_database()


        ' Mise à jour de la liste des villes disponibles

        Me.setDefaultValue()

        If Me.database.isConnected = True Then

            For Each ville In Me.database.getAllVilles()
                Me.cbStation.Items.Add(ville)
            Next ville

            Me.cbStation.Items.Add("")

        End If

    End Sub

    Sub updateData()

        If Me.database IsNot Nothing Then

            If Me.database.isConnected = True Then

                Dim donnees As data = New data()

                If c_ville <> Nothing And
                   c_ville <> "" Then
                    donnees.ville = Me.c_ville
                Else
                    donnees.ville = "Strasbourg-Entzheim"
                End If

                donnees.jour = Me.calendrier.SelectionRange.Start.ToString("yyyy-MM-dd")
                donnees.heure = Me.numHeure.Value

                Me.database.getData(donnees)

                If donnees.pression < 10 Then

                    Me.setDefaultValue()

                Else

                    Me.tbTemp.Text = (donnees.temperature).ToString() & " °C"
                    Me.tbPression.Text = (donnees.pression / 100).ToString() & " hpa"
                    Me.tbDirVent.Text = donnees.dirVent
                    Me.tbForceVent.Text = (donnees.forceVent).ToString() & " m/s"

                End If

                Me.grpStation.Text = "Station - " & donnees.ville
                Me.cbStation.SelectedItem = ""
            End If
        End If
    End Sub

    Private Sub setDefaultValue()
        Me.tbTemp.Text = "- °C"
        Me.tbPression.Text = "- hpa"
        Me.tbDirVent.Text = " - "
        Me.tbForceVent.Text = "- m/s"
    End Sub

    Private Sub calendrier_DateChanged(sender As Object, e As DateRangeEventArgs) Handles calendrier.DateChanged

        If Me.calendrier.SelectionRange.Start.ToShortDateString() = "12/11/2012" Then
            Me.numHeure.Maximum = 6
            Me.numHeure.Minimum = 0
            Me.numHeure.Value = 6

        ElseIf Me.calendrier.SelectionRange.Start.ToShortDateString() = "19/10/2012" Then
            Me.numHeure.Maximum = 18
            Me.numHeure.Minimum = 12
            Me.numHeure.Value = 12

        Else
            Me.numHeure.Maximum = 18
            Me.numHeure.Minimum = 0
            Me.numHeure.Value = 12

        End If

        Me.updateData()

    End Sub

    Private Sub numHeure_ValueChanged(sender As Object, e As EventArgs) Handles numHeure.ValueChanged
        Me.updateData()

    End Sub

    Private Sub cbStation_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbStation.SelectedIndexChanged
        If Me.cbStation.SelectedItem <> "" Then
            Me.c_ville = Me.cbStation.SelectedItem
            Me.updateData()
        End If

    End Sub


    Private Sub lbStrasbourg_Click(sender As Object, e As EventArgs) Handles lbStrasbourg.Click
        Me.c_ville = "Strasbourg-Entzheim"
        Me.updateData()
    End Sub

    Private Sub lbOrly_Click(sender As Object, e As EventArgs) Handles lbOrly.Click
        Me.c_ville = "Orly"
        Me.updateData()
    End Sub

    Private Sub lbNancy_Click(sender As Object, e As EventArgs) Handles lbNancy.Click
        Me.c_ville = "Nancy-Ochey"
        Me.updateData()
    End Sub

    Private Sub lbLyon_Click(sender As Object, e As EventArgs) Handles lbLyon.Click
        Me.c_ville = "Lyon-Saint Exupery"
        Me.updateData()
    End Sub

    Private Sub lbMontpellier_Click(sender As Object, e As EventArgs) Handles lbMontpellier.Click
        Me.c_ville = "Montpellier"
        Me.updateData()
    End Sub

    Private Sub lbClermont_Click(sender As Object, e As EventArgs) Handles lbClermont.Click
        Me.c_ville = "Clermont-Ferrand"
        Me.updateData()
    End Sub

    Private Sub lbToulouse_Click(sender As Object, e As EventArgs) Handles lbToulouse.Click
        Me.c_ville = "Toulouse-Blagnac"
        Me.updateData()
    End Sub

    Private Sub lbBordeaux_Click(sender As Object, e As EventArgs) Handles lbBordeaux.Click
        Me.c_ville = "Bordeaux-Merignac"
        Me.updateData()
    End Sub

    Private Sub lbTours_Click(sender As Object, e As EventArgs) Handles lbTours.Click
        Me.c_ville = "Tours"
        Me.updateData()
    End Sub

    Private Sub lbRennes_Click(sender As Object, e As EventArgs) Handles lbRennes.Click
        Me.c_ville = "Rennes-Saint Jacques"
        Me.updateData()
    End Sub

    Private Sub lbCaen_Click(sender As Object, e As EventArgs) Handles lbCaen.Click
        Me.c_ville = "Caen-Carpiquet"
        Me.updateData()
    End Sub

    Private Sub lbLille_Click(sender As Object, e As EventArgs) Handles lbLille.Click
        Me.c_ville = "Lille-Lesquin"
        Me.updateData()
    End Sub

    Private Sub lbTroyes_Click(sender As Object, e As EventArgs) Handles lbTroyes.Click
        Me.c_ville = "Troyes-Barberey"
        Me.updateData()
    End Sub
End Class
