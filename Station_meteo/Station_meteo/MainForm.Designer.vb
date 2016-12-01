<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.grpStation = New System.Windows.Forms.GroupBox()
        Me.cbStation = New System.Windows.Forms.ComboBox()
        Me.grpData = New System.Windows.Forms.GroupBox()
        Me.tbTemp = New System.Windows.Forms.TextBox()
        Me.lbTemp = New System.Windows.Forms.Label()
        Me.tbForceVent = New System.Windows.Forms.TextBox()
        Me.lbPression = New System.Windows.Forms.Label()
        Me.lbForceVent = New System.Windows.Forms.Label()
        Me.tbPression = New System.Windows.Forms.TextBox()
        Me.tbDirVent = New System.Windows.Forms.TextBox()
        Me.lbDirVent = New System.Windows.Forms.Label()
        Me.grpDateTime = New System.Windows.Forms.GroupBox()
        Me.calendrier = New System.Windows.Forms.MonthCalendar()
        Me.lbHeure = New System.Windows.Forms.Label()
        Me.numHeure = New System.Windows.Forms.NumericUpDown()
        Me.img_Carte = New System.Windows.Forms.PictureBox()
        Me.lbStrasbourg = New System.Windows.Forms.Label()
        Me.ttMap = New System.Windows.Forms.ToolTip(Me.components)
        Me.lbOrly = New System.Windows.Forms.Label()
        Me.lbRennes = New System.Windows.Forms.Label()
        Me.lbNancy = New System.Windows.Forms.Label()
        Me.lbMontpellier = New System.Windows.Forms.Label()
        Me.lbLille = New System.Windows.Forms.Label()
        Me.lbCaen = New System.Windows.Forms.Label()
        Me.lbBordeaux = New System.Windows.Forms.Label()
        Me.lbToulouse = New System.Windows.Forms.Label()
        Me.lbLyon = New System.Windows.Forms.Label()
        Me.lbTroyes = New System.Windows.Forms.Label()
        Me.lbTours = New System.Windows.Forms.Label()
        Me.lbClermont = New System.Windows.Forms.Label()
        Me.grpStation.SuspendLayout()
        Me.grpData.SuspendLayout()
        Me.grpDateTime.SuspendLayout()
        CType(Me.numHeure, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img_Carte, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpStation
        '
        Me.grpStation.BackColor = System.Drawing.Color.White
        Me.grpStation.Controls.Add(Me.cbStation)
        Me.grpStation.Controls.Add(Me.grpData)
        Me.grpStation.Controls.Add(Me.grpDateTime)
        Me.grpStation.Location = New System.Drawing.Point(765, 12)
        Me.grpStation.MaximumSize = New System.Drawing.Size(275, 0)
        Me.grpStation.MinimumSize = New System.Drawing.Size(275, 427)
        Me.grpStation.Name = "grpStation"
        Me.grpStation.Size = New System.Drawing.Size(275, 427)
        Me.grpStation.TabIndex = 4
        Me.grpStation.TabStop = False
        Me.grpStation.Text = "Station"
        '
        'cbStation
        '
        Me.cbStation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbStation.Location = New System.Drawing.Point(12, 19)
        Me.cbStation.Name = "cbStation"
        Me.cbStation.Size = New System.Drawing.Size(251, 21)
        Me.cbStation.TabIndex = 15
        '
        'grpData
        '
        Me.grpData.AutoSize = True
        Me.grpData.Controls.Add(Me.tbTemp)
        Me.grpData.Controls.Add(Me.lbTemp)
        Me.grpData.Controls.Add(Me.tbForceVent)
        Me.grpData.Controls.Add(Me.lbPression)
        Me.grpData.Controls.Add(Me.lbForceVent)
        Me.grpData.Controls.Add(Me.tbPression)
        Me.grpData.Controls.Add(Me.tbDirVent)
        Me.grpData.Controls.Add(Me.lbDirVent)
        Me.grpData.Location = New System.Drawing.Point(12, 46)
        Me.grpData.Name = "grpData"
        Me.grpData.Padding = New System.Windows.Forms.Padding(3, 9, 3, 3)
        Me.grpData.Size = New System.Drawing.Size(251, 136)
        Me.grpData.TabIndex = 14
        Me.grpData.TabStop = False
        Me.grpData.Text = "Données"
        '
        'tbTemp
        '
        Me.tbTemp.Location = New System.Drawing.Point(110, 19)
        Me.tbTemp.Name = "tbTemp"
        Me.tbTemp.ReadOnly = True
        Me.tbTemp.Size = New System.Drawing.Size(135, 20)
        Me.tbTemp.TabIndex = 3
        Me.tbTemp.Text = "xx.x °C"
        Me.tbTemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbTemp
        '
        Me.lbTemp.AutoSize = True
        Me.lbTemp.Location = New System.Drawing.Point(6, 22)
        Me.lbTemp.Name = "lbTemp"
        Me.lbTemp.Size = New System.Drawing.Size(67, 13)
        Me.lbTemp.TabIndex = 2
        Me.lbTemp.Text = "Température"
        '
        'tbForceVent
        '
        Me.tbForceVent.Location = New System.Drawing.Point(110, 97)
        Me.tbForceVent.Name = "tbForceVent"
        Me.tbForceVent.ReadOnly = True
        Me.tbForceVent.Size = New System.Drawing.Size(135, 20)
        Me.tbForceVent.TabIndex = 9
        Me.tbForceVent.Text = "xx.x m/s"
        Me.tbForceVent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbPression
        '
        Me.lbPression.AutoSize = True
        Me.lbPression.Location = New System.Drawing.Point(6, 48)
        Me.lbPression.Name = "lbPression"
        Me.lbPression.Size = New System.Drawing.Size(47, 13)
        Me.lbPression.TabIndex = 4
        Me.lbPression.Text = "Pression"
        '
        'lbForceVent
        '
        Me.lbForceVent.AutoSize = True
        Me.lbForceVent.Location = New System.Drawing.Point(6, 100)
        Me.lbForceVent.Name = "lbForceVent"
        Me.lbForceVent.Size = New System.Drawing.Size(73, 13)
        Me.lbForceVent.TabIndex = 8
        Me.lbForceVent.Text = "Force du vent"
        '
        'tbPression
        '
        Me.tbPression.Location = New System.Drawing.Point(110, 45)
        Me.tbPression.Name = "tbPression"
        Me.tbPression.ReadOnly = True
        Me.tbPression.Size = New System.Drawing.Size(135, 20)
        Me.tbPression.TabIndex = 5
        Me.tbPression.Text = "xxxx.x hpa"
        Me.tbPression.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbDirVent
        '
        Me.tbDirVent.Location = New System.Drawing.Point(110, 71)
        Me.tbDirVent.Name = "tbDirVent"
        Me.tbDirVent.ReadOnly = True
        Me.tbDirVent.Size = New System.Drawing.Size(135, 20)
        Me.tbDirVent.TabIndex = 7
        Me.tbDirVent.Text = "xxx"
        Me.tbDirVent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbDirVent
        '
        Me.lbDirVent.AutoSize = True
        Me.lbDirVent.Location = New System.Drawing.Point(6, 74)
        Me.lbDirVent.Name = "lbDirVent"
        Me.lbDirVent.Size = New System.Drawing.Size(88, 13)
        Me.lbDirVent.TabIndex = 6
        Me.lbDirVent.Text = "Direction du vent"
        '
        'grpDateTime
        '
        Me.grpDateTime.Controls.Add(Me.calendrier)
        Me.grpDateTime.Controls.Add(Me.lbHeure)
        Me.grpDateTime.Controls.Add(Me.numHeure)
        Me.grpDateTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.grpDateTime.Location = New System.Drawing.Point(12, 188)
        Me.grpDateTime.Name = "grpDateTime"
        Me.grpDateTime.Size = New System.Drawing.Size(251, 232)
        Me.grpDateTime.TabIndex = 13
        Me.grpDateTime.TabStop = False
        Me.grpDateTime.Text = "Date et heure"
        '
        'calendrier
        '
        Me.calendrier.BackColor = System.Drawing.SystemColors.Control
        Me.calendrier.Location = New System.Drawing.Point(12, 25)
        Me.calendrier.MaxDate = New Date(2012, 11, 12, 0, 0, 0, 0)
        Me.calendrier.MaxSelectionCount = 1
        Me.calendrier.MinDate = New Date(2012, 10, 19, 0, 0, 0, 0)
        Me.calendrier.Name = "calendrier"
        Me.calendrier.ShowToday = False
        Me.calendrier.TabIndex = 10
        '
        'lbHeure
        '
        Me.lbHeure.AutoSize = True
        Me.lbHeure.Location = New System.Drawing.Point(17, 196)
        Me.lbHeure.Name = "lbHeure"
        Me.lbHeure.Size = New System.Drawing.Size(36, 13)
        Me.lbHeure.TabIndex = 0
        Me.lbHeure.Text = "Heure"
        '
        'numHeure
        '
        Me.numHeure.Increment = New Decimal(New Integer() {6, 0, 0, 0})
        Me.numHeure.Location = New System.Drawing.Point(160, 194)
        Me.numHeure.Maximum = New Decimal(New Integer() {6, 0, 0, 0})
        Me.numHeure.Name = "numHeure"
        Me.numHeure.ReadOnly = True
        Me.numHeure.Size = New System.Drawing.Size(79, 20)
        Me.numHeure.TabIndex = 11
        Me.numHeure.Value = New Decimal(New Integer() {6, 0, 0, 0})
        '
        'img_Carte
        '
        Me.img_Carte.BackColor = System.Drawing.SystemColors.Info
        Me.img_Carte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.img_Carte.Image = CType(resources.GetObject("img_Carte.Image"), System.Drawing.Image)
        Me.img_Carte.Location = New System.Drawing.Point(12, 12)
        Me.img_Carte.Name = "img_Carte"
        Me.img_Carte.Size = New System.Drawing.Size(747, 747)
        Me.img_Carte.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.img_Carte.TabIndex = 6
        Me.img_Carte.TabStop = False
        Me.ttMap.SetToolTip(Me.img_Carte, "Pour choisir une ville cliquez sur celle-ci, ou selectionnez la directement dans " &
        "la liste déroulante")
        '
        'lbStrasbourg
        '
        Me.lbStrasbourg.AutoSize = True
        Me.lbStrasbourg.BackColor = System.Drawing.SystemColors.Info
        Me.lbStrasbourg.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbStrasbourg.Location = New System.Drawing.Point(638, 225)
        Me.lbStrasbourg.Name = "lbStrasbourg"
        Me.lbStrasbourg.Size = New System.Drawing.Size(81, 18)
        Me.lbStrasbourg.TabIndex = 7
        Me.lbStrasbourg.Text = "Strasbourg"
        '
        'ttMap
        '
        Me.ttMap.ToolTipTitle = "Gestion de la carte"
        '
        'lbOrly
        '
        Me.lbOrly.AutoSize = True
        Me.lbOrly.BackColor = System.Drawing.SystemColors.Info
        Me.lbOrly.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbOrly.Location = New System.Drawing.Point(422, 250)
        Me.lbOrly.Name = "lbOrly"
        Me.lbOrly.Size = New System.Drawing.Size(35, 18)
        Me.lbOrly.TabIndex = 9
        Me.lbOrly.Text = "Orly"
        '
        'lbRennes
        '
        Me.lbRennes.AutoSize = True
        Me.lbRennes.BackColor = System.Drawing.SystemColors.Info
        Me.lbRennes.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbRennes.Location = New System.Drawing.Point(178, 294)
        Me.lbRennes.Name = "lbRennes"
        Me.lbRennes.Size = New System.Drawing.Size(59, 18)
        Me.lbRennes.TabIndex = 10
        Me.lbRennes.Text = "Rennes"
        '
        'lbNancy
        '
        Me.lbNancy.AutoSize = True
        Me.lbNancy.BackColor = System.Drawing.SystemColors.Info
        Me.lbNancy.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNancy.Location = New System.Drawing.Point(573, 240)
        Me.lbNancy.Name = "lbNancy"
        Me.lbNancy.Size = New System.Drawing.Size(50, 18)
        Me.lbNancy.TabIndex = 11
        Me.lbNancy.Text = "Nancy"
        '
        'lbMontpellier
        '
        Me.lbMontpellier.AutoSize = True
        Me.lbMontpellier.BackColor = System.Drawing.SystemColors.Info
        Me.lbMontpellier.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbMontpellier.Location = New System.Drawing.Point(474, 583)
        Me.lbMontpellier.Name = "lbMontpellier"
        Me.lbMontpellier.Size = New System.Drawing.Size(80, 18)
        Me.lbMontpellier.TabIndex = 12
        Me.lbMontpellier.Text = "Montpellier"
        '
        'lbLille
        '
        Me.lbLille.AutoSize = True
        Me.lbLille.BackColor = System.Drawing.SystemColors.Info
        Me.lbLille.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbLille.Location = New System.Drawing.Point(431, 116)
        Me.lbLille.Name = "lbLille"
        Me.lbLille.Size = New System.Drawing.Size(33, 18)
        Me.lbLille.TabIndex = 13
        Me.lbLille.Text = "Lille"
        '
        'lbCaen
        '
        Me.lbCaen.AutoSize = True
        Me.lbCaen.BackColor = System.Drawing.SystemColors.Info
        Me.lbCaen.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCaen.Location = New System.Drawing.Point(265, 215)
        Me.lbCaen.Name = "lbCaen"
        Me.lbCaen.Size = New System.Drawing.Size(43, 18)
        Me.lbCaen.TabIndex = 14
        Me.lbCaen.Text = "Caen"
        '
        'lbBordeaux
        '
        Me.lbBordeaux.AutoSize = True
        Me.lbBordeaux.BackColor = System.Drawing.SystemColors.Info
        Me.lbBordeaux.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbBordeaux.Location = New System.Drawing.Point(249, 524)
        Me.lbBordeaux.Name = "lbBordeaux"
        Me.lbBordeaux.Size = New System.Drawing.Size(71, 18)
        Me.lbBordeaux.TabIndex = 15
        Me.lbBordeaux.Text = "Bordeaux"
        '
        'lbToulouse
        '
        Me.lbToulouse.AutoSize = True
        Me.lbToulouse.BackColor = System.Drawing.SystemColors.Info
        Me.lbToulouse.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbToulouse.Location = New System.Drawing.Point(338, 607)
        Me.lbToulouse.Name = "lbToulouse"
        Me.lbToulouse.Size = New System.Drawing.Size(70, 18)
        Me.lbToulouse.TabIndex = 16
        Me.lbToulouse.Text = "Toulouse"
        '
        'lbLyon
        '
        Me.lbLyon.AutoSize = True
        Me.lbLyon.BackColor = System.Drawing.SystemColors.Info
        Me.lbLyon.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbLyon.Location = New System.Drawing.Point(562, 451)
        Me.lbLyon.Name = "lbLyon"
        Me.lbLyon.Size = New System.Drawing.Size(40, 18)
        Me.lbLyon.TabIndex = 17
        Me.lbLyon.Text = "Lyon"
        '
        'lbTroyes
        '
        Me.lbTroyes.AutoSize = True
        Me.lbTroyes.BackColor = System.Drawing.SystemColors.Info
        Me.lbTroyes.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTroyes.Location = New System.Drawing.Point(545, 294)
        Me.lbTroyes.Name = "lbTroyes"
        Me.lbTroyes.Size = New System.Drawing.Size(54, 18)
        Me.lbTroyes.TabIndex = 18
        Me.lbTroyes.Text = "Troyes"
        '
        'lbTours
        '
        Me.lbTours.AutoSize = True
        Me.lbTours.BackColor = System.Drawing.SystemColors.Info
        Me.lbTours.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTours.Location = New System.Drawing.Point(304, 348)
        Me.lbTours.Name = "lbTours"
        Me.lbTours.Size = New System.Drawing.Size(47, 18)
        Me.lbTours.TabIndex = 19
        Me.lbTours.Text = "Tours"
        '
        'lbClermont
        '
        Me.lbClermont.AutoSize = True
        Me.lbClermont.BackColor = System.Drawing.SystemColors.Info
        Me.lbClermont.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbClermont.Location = New System.Drawing.Point(404, 451)
        Me.lbClermont.Name = "lbClermont"
        Me.lbClermont.Size = New System.Drawing.Size(125, 18)
        Me.lbClermont.TabIndex = 20
        Me.lbClermont.Text = "Clermont-Ferrand"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1050, 771)
        Me.Controls.Add(Me.lbClermont)
        Me.Controls.Add(Me.lbTours)
        Me.Controls.Add(Me.lbTroyes)
        Me.Controls.Add(Me.lbLyon)
        Me.Controls.Add(Me.lbToulouse)
        Me.Controls.Add(Me.lbBordeaux)
        Me.Controls.Add(Me.lbCaen)
        Me.Controls.Add(Me.lbLille)
        Me.Controls.Add(Me.lbMontpellier)
        Me.Controls.Add(Me.lbNancy)
        Me.Controls.Add(Me.lbRennes)
        Me.Controls.Add(Me.lbOrly)
        Me.Controls.Add(Me.lbStrasbourg)
        Me.Controls.Add(Me.img_Carte)
        Me.Controls.Add(Me.grpStation)
        Me.MaximumSize = New System.Drawing.Size(1066, 810)
        Me.MinimumSize = New System.Drawing.Size(1066, 810)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Station Météo"
        Me.grpStation.ResumeLayout(False)
        Me.grpStation.PerformLayout()
        Me.grpData.ResumeLayout(False)
        Me.grpData.PerformLayout()
        Me.grpDateTime.ResumeLayout(False)
        Me.grpDateTime.PerformLayout()
        CType(Me.numHeure, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img_Carte, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpStation As GroupBox
    Friend WithEvents grpData As GroupBox
    Friend WithEvents tbTemp As TextBox
    Friend WithEvents lbTemp As Label
    Friend WithEvents tbForceVent As TextBox
    Friend WithEvents lbPression As Label
    Friend WithEvents lbForceVent As Label
    Friend WithEvents tbPression As TextBox
    Friend WithEvents tbDirVent As TextBox
    Friend WithEvents lbDirVent As Label
    Friend WithEvents grpDateTime As GroupBox
    Friend WithEvents calendrier As MonthCalendar
    Friend WithEvents lbHeure As Label
    Friend WithEvents numHeure As NumericUpDown
    Friend WithEvents img_Carte As PictureBox
    Friend WithEvents cbStation As ComboBox
    Friend WithEvents lbStrasbourg As Label
    Friend WithEvents ttMap As ToolTip
    Friend WithEvents lbOrly As Label
    Friend WithEvents lbRennes As Label
    Friend WithEvents lbNancy As Label
    Friend WithEvents lbMontpellier As Label
    Friend WithEvents lbLille As Label
    Friend WithEvents lbCaen As Label
    Friend WithEvents lbBordeaux As Label
    Friend WithEvents lbToulouse As Label
    Friend WithEvents lbLyon As Label
    Friend WithEvents lbTroyes As Label
    Friend WithEvents lbTours As Label
    Friend WithEvents lbClermont As Label
End Class
