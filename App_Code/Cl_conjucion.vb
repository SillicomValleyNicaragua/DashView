Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OleDb
Public Class Cl_conjucion
    Inherits CLSCONEXION
    Public Function verificar_usuario(ByVal user As String, ByVal clave As String) As String
        Dim msj As String
        Dim ver As New SqlCommand("verificar_usuario", MyBase.sqlconn)
        ver.CommandType = CommandType.StoredProcedure
        ver.Parameters.Add("@user", SqlDbType.VarChar).Value = user
        ver.Parameters.Add("@password", SqlDbType.VarChar).Value = clave
        ver.Parameters.Add("@msj", SqlDbType.VarChar, 60).Direction = 2
        MyBase.sqlconn.Open()
        ver.ExecuteNonQuery()
        msj = ver.Parameters("@msj").Value.ToString
        MyBase.sqlconn.Close()
        Return msj
    End Function
    Public Function lpermisos(ByVal usu As String) As DataTable
        Dim conn As New SqlCommand("ls_permisos", MyBase.sqlconn)
        Dim answer As SqlDataReader
        Dim table As New DataTable
        conn.CommandType = CommandType.StoredProcedure
        conn.Parameters.Add("@usu", SqlDbType.VarChar).Value = usu
        MyBase.sqlconn.Open()
        answer = conn.ExecuteReader()
        table.Load(answer)
        MyBase.sqlconn.Close()
        Return table

    End Function

End Class
