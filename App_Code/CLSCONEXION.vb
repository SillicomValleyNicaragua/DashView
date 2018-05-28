Imports Microsoft.VisualBasic
Imports System.Data.SqlClient
Imports System.Data
Imports System.Configuration
Public Class CLSCONEXION
    Public sqlconn As SqlConnection

    Public servidor As String
    Public base_datos As String
    Public user As String
    Public password As String
    Public Sub New()
        Me.servidor = "149.56.146.161"
        Me.base_datos = "sisacsadb"
        Me.user = "sa"
        Me.password = "199424.Vergil"

        Me.sqlconn = New SqlConnection("Initial Catalog=" & Me.base_datos &
                                        ";Data Source=" & Me.servidor &
                                        ";User id=" & Me.user &
                                         ";password=" & Me.password & ";")

    End Sub

End Class
