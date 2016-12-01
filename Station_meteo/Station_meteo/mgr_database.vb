Imports MySql.Data.MySqlClient

Public Class mgr_database

    Shared m_CmdConnection As String = "server=130.79.206.15; database=Meteo; user=fip; password=fip;"
    Shared m_BaseSql As MySqlConnection
    Shared m_DataAdaptMySql As MySqlDataAdapter
    Shared m_CmdBuilderMySql As MySqlCommandBuilder
    Shared m_BaseIsConnected As Boolean = False

    Public ReadOnly Property isConnected As Boolean
        Get
            Return m_BaseIsConnected
        End Get
    End Property

    Sub New()
        Me.connect()

    End Sub

    Public Sub connect()
        Try
            ' Connexion à la base de données
            m_BaseSql = New MySqlConnection(m_CmdConnection)
            m_BaseSql.Open()
            m_BaseIsConnected = True
        Catch
            MessageBox.Show("Une erreur est survenue durant la connexion à la base")
            m_BaseIsConnected = False
        End Try
    End Sub

    Public Function getData(ByRef donnees As data)

        Dim indicatif As String = ""
        Dim Requete As String = ""
        Dim DataTab As DataTable
        Dim DateMesure As String = ""
        Dim DirVent As Integer = 0
        Dim CodeSYNOP As Integer = 0
        Dim Jour As DateTime
        Dim JourString As String = ""

        If m_BaseIsConnected = False Then
            MessageBox.Show("Vous n'êtes pas connecté à la base")
            Return Nothing
        End If

        Requete = "SELECT indicatif FROM Station WHERE nom LIKE " & """" & donnees.ville & """"
        m_DataAdaptMySql = New MySqlDataAdapter(Requete, m_BaseSql)
        m_CmdBuilderMySql = New MySqlCommandBuilder(m_DataAdaptMySql)
        DataTab = New DataTable
        m_DataAdaptMySql.Fill(DataTab)
        For Each ligne As DataRow In DataTab.Rows
            indicatif = ligne("indicatif")
        Next

        Jour = New DateTime(donnees.jour.Substring(0, 4), donnees.jour.Substring(5, 2), donnees.jour.Substring(8, 2), donnees.heure, 0, 0)
        JourString = Jour.ToString("yyyy-MM-dd hh:mm")

        Requete = "SELECT temperature, pression, directionVent, forceVent, codeSYNOP FROM Releve WHERE indicatif = " & indicatif & " AND echeance = """ & JourString & """"
        m_DataAdaptMySql = New MySqlDataAdapter(Requete, m_BaseSql)
        m_CmdBuilderMySql = New MySqlCommandBuilder(m_DataAdaptMySql)
        DataTab = New DataTable
        m_DataAdaptMySql.Fill(DataTab)
        For Each ligne As DataRow In DataTab.Rows
            donnees.temperature = ligne("temperature") / 10
            donnees.pression = ligne("pression")
            donnees.forceVent = ligne("forceVent") / 10
            DirVent = ligne("directionVent")
            CodeSYNOP = ligne("codeSYNOP")
        Next

        Requete = "SELECT acronyme FROM RoseVent WHERE direction = " & DirVent
        m_DataAdaptMySql = New MySqlDataAdapter(Requete, m_BaseSql)
        m_CmdBuilderMySql = New MySqlCommandBuilder(m_DataAdaptMySql)
        DataTab = New DataTable
        m_DataAdaptMySql.Fill(DataTab)
        For Each ligne As DataRow In DataTab.Rows
            donnees.dirVent = ligne("acronyme")
        Next

        Requete = "SELECT traduction FROM SYNOP WHERE code = " & CodeSYNOP
        m_DataAdaptMySql = New MySqlDataAdapter(Requete, m_BaseSql)
        m_CmdBuilderMySql = New MySqlCommandBuilder(m_DataAdaptMySql)
        DataTab = New DataTable
        m_DataAdaptMySql.Fill(DataTab)
        For Each ligne As DataRow In DataTab.Rows
            donnees.descriptionTemps = ligne("traduction")
        Next

        Return donnees

    End Function

    Public Function getAllVilles()
        Dim villes As List(Of String) = New List(Of String)
        Dim Requete As String = ""
        Dim DataTab As DataTable

        If m_BaseIsConnected = False Then
            MessageBox.Show("Vous n'êtes pas connecté à la base")
            Return Nothing
        End If

        Requete = "SELECT nom FROM Station"
        m_DataAdaptMySql = New MySqlDataAdapter(Requete, m_BaseSql)
        m_CmdBuilderMySql = New MySqlCommandBuilder(m_DataAdaptMySql)
        DataTab = New DataTable
        m_DataAdaptMySql.Fill(DataTab)
        For Each ligne As DataRow In DataTab.Rows
            villes.Add(ligne("nom"))
        Next

        Return villes

    End Function

    Protected Overrides Sub Finalize()
        ' Fermeture de la connexion
        m_BaseSql.Close()
        MyBase.Finalize()
    End Sub

End Class
