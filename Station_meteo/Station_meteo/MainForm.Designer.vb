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
        Me.Menu = New System.Windows.Forms.MenuStrip()
        Me.FichierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.img_Carte = New System.Windows.Forms.PictureBox()
        Me.grpStation = New System.Windows.Forms.GroupBox()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.tbForceVent = New System.Windows.Forms.TextBox()
        Me.lbForceVent = New System.Windows.Forms.Label()
        Me.tbDirVent = New System.Windows.Forms.TextBox()
        Me.lbDirVent = New System.Windows.Forms.Label()
        Me.tbPression = New System.Windows.Forms.TextBox()
        Me.lbPression = New System.Windows.Forms.Label()
        Me.tbTemp = New System.Windows.Forms.TextBox()
        Me.lbTemp = New System.Windows.Forms.Label()
        Me.tbDate = New System.Windows.Forms.TextBox()
        Me.lbDate = New System.Windows.Forms.Label()
        Me.Menu.SuspendLayout()
        CType(Me.img_Carte, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpStation.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Menu
        '
        Me.Menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FichierToolStripMenuItem})
        Me.Menu.Location = New System.Drawing.Point(0, 0)
        Me.Menu.Name = "Menu"
        Me.Menu.Size = New System.Drawing.Size(1204, 24)
        Me.Menu.TabIndex = 0
        Me.Menu.Text = "MenuStrip1"
        '
        'FichierToolStripMenuItem
        '
        Me.FichierToolStripMenuItem.Name = "FichierToolStripMenuItem"
        Me.FichierToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.FichierToolStripMenuItem.Text = "Fichier"
        '
        'img_Carte
        '
        Me.img_Carte.Image = CType(resources.GetObject("img_Carte.Image"), System.Drawing.Image)
        Me.img_Carte.Location = New System.Drawing.Point(12, 27)
        Me.img_Carte.Name = "img_Carte"
        Me.img_Carte.Size = New System.Drawing.Size(745, 745)
        Me.img_Carte.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.img_Carte.TabIndex = 1
        Me.img_Carte.TabStop = False
        '
        'grpStation
        '
        Me.grpStation.Controls.Add(Me.NumericUpDown1)
        Me.grpStation.Controls.Add(Me.MonthCalendar1)
        Me.grpStation.Controls.Add(Me.tbForceVent)
        Me.grpStation.Controls.Add(Me.lbForceVent)
        Me.grpStation.Controls.Add(Me.tbDirVent)
        Me.grpStation.Controls.Add(Me.lbDirVent)
        Me.grpStation.Controls.Add(Me.tbPression)
        Me.grpStation.Controls.Add(Me.lbPression)
        Me.grpStation.Controls.Add(Me.tbTemp)
        Me.grpStation.Controls.Add(Me.lbTemp)
        Me.grpStation.Controls.Add(Me.tbDate)
        Me.grpStation.Controls.Add(Me.lbDate)
        Me.grpStation.Dock = System.Windows.Forms.DockStyle.Right
        Me.grpStation.Location = New System.Drawing.Point(953, 24)
        Me.grpStation.Name = "grpStation"
        Me.grpStation.Size = New System.Drawing.Size(251, 759)
        Me.grpStation.TabIndex = 2
        Me.grpStation.TabStop = False
        Me.grpStation.Text = "Station"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(185, 195)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(53, 20)
        Me.NumericUpDown1.TabIndex = 11
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(12, 227)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 10
        '
        'tbForceVent
        '
        Me.tbForceVent.Location = New System.Drawing.Point(117, 121)
        Me.tbForceVent.Name = "tbForceVent"
        Me.tbForceVent.Size = New System.Drawing.Size(79, 20)
        Me.tbForceVent.TabIndex = 9
        Me.tbForceVent.Text = "xx.x m/s"
        Me.tbForceVent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbForceVent
        '
        Me.lbForceVent.AutoSize = True
        Me.lbForceVent.Location = New System.Drawing.Point(7, 124)
        Me.lbForceVent.Name = "lbForceVent"
        Me.lbForceVent.Size = New System.Drawing.Size(73, 13)
        Me.lbForceVent.TabIndex = 8
        Me.lbForceVent.Text = "Force du vent"
        '
        'tbDirVent
        '
        Me.tbDirVent.Location = New System.Drawing.Point(117, 95)
        Me.tbDirVent.Name = "tbDirVent"
        Me.tbDirVent.Size = New System.Drawing.Size(79, 20)
        Me.tbDirVent.TabIndex = 7
        Me.tbDirVent.Text = "xxxx.x hpa"
        Me.tbDirVent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbDirVent
        '
        Me.lbDirVent.AutoSize = True
        Me.lbDirVent.Location = New System.Drawing.Point(7, 98)
        Me.lbDirVent.Name = "lbDirVent"
        Me.lbDirVent.Size = New System.Drawing.Size(88, 13)
        Me.lbDirVent.TabIndex = 6
        Me.lbDirVent.Text = "Direction du vent"
        '
        'tbPression
        '
        Me.tbPression.Location = New System.Drawing.Point(117, 69)
        Me.tbPression.Name = "tbPression"
        Me.tbPression.Size = New System.Drawing.Size(79, 20)
        Me.tbPression.TabIndex = 5
        Me.tbPression.Text = "xxxx.x hpa"
        Me.tbPression.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbPression
        '
        Me.lbPression.AutoSize = True
        Me.lbPression.Location = New System.Drawing.Point(7, 72)
        Me.lbPression.Name = "lbPression"
        Me.lbPression.Size = New System.Drawing.Size(47, 13)
        Me.lbPression.TabIndex = 4
        Me.lbPression.Text = "Pression"
        '
        'tbTemp
        '
        Me.tbTemp.Location = New System.Drawing.Point(117, 43)
        Me.tbTemp.Name = "tbTemp"
        Me.tbTemp.Size = New System.Drawing.Size(79, 20)
        Me.tbTemp.TabIndex = 3
        Me.tbTemp.Text = "xx.x °C"
        Me.tbTemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbTemp
        '
        Me.lbTemp.AutoSize = True
        Me.lbTemp.Location = New System.Drawing.Point(7, 46)
        Me.lbTemp.Name = "lbTemp"
        Me.lbTemp.Size = New System.Drawing.Size(67, 13)
        Me.lbTemp.TabIndex = 2
        Me.lbTemp.Text = "Température"
        '
        'tbDate
        '
        Me.tbDate.Location = New System.Drawing.Point(117, 17)
        Me.tbDate.Name = "tbDate"
        Me.tbDate.Size = New System.Drawing.Size(152, 20)
        Me.tbDate.TabIndex = 1
        Me.tbDate.Text = "xx/xx/20xx - hh:mm:ss"
        Me.tbDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbDate
        '
        Me.lbDate.AutoSize = True
        Me.lbDate.Location = New System.Drawing.Point(7, 20)
        Me.lbDate.Name = "lbDate"
        Me.lbDate.Size = New System.Drawing.Size(68, 13)
        Me.lbDate.TabIndex = 0
        Me.lbDate.Text = "Date - Heure"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1204, 783)
        Me.Controls.Add(Me.grpStation)
        Me.Controls.Add(Me.img_Carte)
        Me.Controls.Add(Me.Menu)
        Me.MainMenuStrip = Me.Menu
        Me.MaximumSize = New System.Drawing.Size(1220, 822)
        Me.MinimumSize = New System.Drawing.Size(1220, 822)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Station Météo"
        Me.TopMost = True
        Me.Menu.ResumeLayout(False)
        Me.Menu.PerformLayout()
        CType(Me.img_Carte, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpStation.ResumeLayout(False)
        Me.grpStation.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Menu As MenuStrip
    Friend WithEvents FichierToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents img_Carte As PictureBox
    Friend WithEvents grpStation As GroupBox
    Friend WithEvents tbPression As TextBox
    Friend WithEvents lbPression As Label
    Friend WithEvents tbTemp As TextBox
    Friend WithEvents lbTemp As Label
    Friend WithEvents tbDate As TextBox
    Friend WithEvents lbDate As Label
    Friend WithEvents tbForceVent As TextBox
    Friend WithEvents lbForceVent As Label
    Friend WithEvents tbDirVent As TextBox
    Friend WithEvents lbDirVent As Label
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents NumericUpDown1 As NumericUpDown
End Class
