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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.mainMenu = New System.Windows.Forms.MenuStrip()
        Me.FichierMenu = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.grpLog = New System.Windows.Forms.GroupBox()
        Me.lsbLog = New System.Windows.Forms.ListBox()
        Me.btClearLog = New System.Windows.Forms.Button()
        Me.mainMenu.SuspendLayout()
        Me.grpStation.SuspendLayout()
        Me.grpData.SuspendLayout()
        Me.grpDateTime.SuspendLayout()
        CType(Me.numHeure, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img_Carte, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpLog.SuspendLayout()
        Me.SuspendLayout()
        '
        'mainMenu
        '
        Me.mainMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FichierMenu})
        Me.mainMenu.Location = New System.Drawing.Point(0, 0)
        Me.mainMenu.Name = "mainMenu"
        Me.mainMenu.Size = New System.Drawing.Size(1050, 24)
        Me.mainMenu.TabIndex = 0
        Me.mainMenu.Text = "MenuStrip1"
        '
        'FichierMenu
        '
        Me.FichierMenu.Name = "FichierMenu"
        Me.FichierMenu.Size = New System.Drawing.Size(54, 20)
        Me.FichierMenu.Text = "Fichier"
        '
        'grpStation
        '
        Me.grpStation.Controls.Add(Me.cbStation)
        Me.grpStation.Controls.Add(Me.grpData)
        Me.grpStation.Controls.Add(Me.grpDateTime)
        Me.grpStation.Location = New System.Drawing.Point(763, 27)
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
        Me.tbDirVent.Text = "xxxx.x hpa"
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
        Me.grpDateTime.Location = New System.Drawing.Point(12, 188)
        Me.grpDateTime.Name = "grpDateTime"
        Me.grpDateTime.Size = New System.Drawing.Size(251, 232)
        Me.grpDateTime.TabIndex = 13
        Me.grpDateTime.TabStop = False
        Me.grpDateTime.Text = "Date et heure"
        '
        'calendrier
        '
        Me.calendrier.Location = New System.Drawing.Point(12, 25)
        Me.calendrier.MaxDate = New Date(2012, 11, 12, 0, 0, 0, 0)
        Me.calendrier.MinDate = New Date(2012, 10, 19, 0, 0, 0, 0)
        Me.calendrier.Name = "calendrier"
        Me.calendrier.TabIndex = 10
        '
        'lbHeure
        '
        Me.lbHeure.AutoSize = True
        Me.lbHeure.Location = New System.Drawing.Point(6, 196)
        Me.lbHeure.Name = "lbHeure"
        Me.lbHeure.Size = New System.Drawing.Size(36, 13)
        Me.lbHeure.TabIndex = 0
        Me.lbHeure.Text = "Heure"
        '
        'numHeure
        '
        Me.numHeure.Location = New System.Drawing.Point(160, 194)
        Me.numHeure.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.numHeure.Name = "numHeure"
        Me.numHeure.Size = New System.Drawing.Size(79, 20)
        Me.numHeure.TabIndex = 11
        '
        'img_Carte
        '
        Me.img_Carte.Image = CType(resources.GetObject("img_Carte.Image"), System.Drawing.Image)
        Me.img_Carte.Location = New System.Drawing.Point(12, 27)
        Me.img_Carte.Name = "img_Carte"
        Me.img_Carte.Size = New System.Drawing.Size(745, 745)
        Me.img_Carte.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.img_Carte.TabIndex = 6
        Me.img_Carte.TabStop = False
        '
        'lbStrasbourg
        '
        Me.lbStrasbourg.AutoSize = True
        Me.lbStrasbourg.BackColor = System.Drawing.SystemColors.Highlight
        Me.lbStrasbourg.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbStrasbourg.Location = New System.Drawing.Point(629, 250)
        Me.lbStrasbourg.Name = "lbStrasbourg"
        Me.lbStrasbourg.Size = New System.Drawing.Size(81, 18)
        Me.lbStrasbourg.TabIndex = 7
        Me.lbStrasbourg.Text = "Strasbourg"
        '
        'grpLog
        '
        Me.grpLog.Controls.Add(Me.btClearLog)
        Me.grpLog.Controls.Add(Me.lsbLog)
        Me.grpLog.Location = New System.Drawing.Point(763, 461)
        Me.grpLog.Name = "grpLog"
        Me.grpLog.Size = New System.Drawing.Size(275, 311)
        Me.grpLog.TabIndex = 8
        Me.grpLog.TabStop = False
        Me.grpLog.Text = "Messages"
        '
        'lsbLog
        '
        Me.lsbLog.Dock = System.Windows.Forms.DockStyle.Top
        Me.lsbLog.FormattingEnabled = True
        Me.lsbLog.Location = New System.Drawing.Point(3, 16)
        Me.lsbLog.Name = "lsbLog"
        Me.lsbLog.Size = New System.Drawing.Size(269, 290)
        Me.lsbLog.TabIndex = 0
        '
        'btClearLog
        '
        Me.btClearLog.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btClearLog.Location = New System.Drawing.Point(3, 285)
        Me.btClearLog.Name = "btClearLog"
        Me.btClearLog.Size = New System.Drawing.Size(269, 23)
        Me.btClearLog.TabIndex = 1
        Me.btClearLog.Text = "vider"
        Me.btClearLog.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1050, 783)
        Me.Controls.Add(Me.grpLog)
        Me.Controls.Add(Me.lbStrasbourg)
        Me.Controls.Add(Me.img_Carte)
        Me.Controls.Add(Me.grpStation)
        Me.Controls.Add(Me.mainMenu)
        Me.MainMenuStrip = Me.mainMenu
        Me.MaximumSize = New System.Drawing.Size(1066, 822)
        Me.MinimumSize = New System.Drawing.Size(1066, 822)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Station Météo"
        Me.TopMost = True
        Me.mainMenu.ResumeLayout(False)
        Me.mainMenu.PerformLayout()
        Me.grpStation.ResumeLayout(False)
        Me.grpStation.PerformLayout()
        Me.grpData.ResumeLayout(False)
        Me.grpData.PerformLayout()
        Me.grpDateTime.ResumeLayout(False)
        Me.grpDateTime.PerformLayout()
        CType(Me.numHeure, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img_Carte, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpLog.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mainMenu As MenuStrip
    Friend WithEvents FichierMenu As ToolStripMenuItem
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
    Friend WithEvents grpLog As GroupBox
    Friend WithEvents btClearLog As Button
    Friend WithEvents lsbLog As ListBox
End Class
