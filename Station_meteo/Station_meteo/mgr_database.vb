﻿Imports MySql.Data.MySqlClient

Public Class mgr_database

    Shared m_CmdConnection As String = "server=130.79.206.15; database=Meteo; user=fip; password=fip;"
    Shared m_BaseSql As MySqlConnection
    Shared m_DataAdaptMySql As MySqlDataAdapter
    Shared m_CmdBuilderMySql As MySqlCommandBuilder

    Sub New()
        Me.connect()

    End Sub

    Public Sub connect()
        ' Connexion à la base de données
        m_BaseSql = New MySqlConnection(m_CmdConnection)
        m_BaseSql.Open()

    End Sub

    Public Function getData(ByRef donnees As data)

        Dim indicatif As String = ""
        Dim Requete As String = ""
        Dim DataTab As DataTable
        Dim DateMesure As String = ""

        Requete = "SELECT indicatif FROM Station WHERE nom LIKE " & donnees.station
        m_DataAdaptMySql = New MySqlDataAdapter(Requete, m_BaseSql)
        m_CmdBuilderMySql = New MySqlCommandBuilder(m_DataAdaptMySql)
        DataTab = New DataTable
        m_DataAdaptMySql.Fill(DataTab)
        For Each ligne As DataRow In DataTab.Rows
            indicatif = ligne("indicatif")
        Next

        Requete = "SELECT echeance FROM Releve WHERE echeance = MAX(echeance)"
        m_DataAdaptMySql = New MySqlDataAdapter(Requete, m_BaseSql)
        m_CmdBuilderMySql = New MySqlCommandBuilder(m_DataAdaptMySql)
        DataTab = New DataTable
        m_DataAdaptMySql.Fill(DataTab)
        For Each ligne As DataRow In DataTab.Rows
            DateMesure = ligne("echeance")
        Next

        Return donnees

    End Function

    Public Function getAllVilles()
        Dim villes As List(Of String) = New List(Of String)
        Dim Requete As String = ""
        Dim DataTab As DataTable

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
