Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient


Public Class Cl_conection
    Inherits Cl_conjucion
    Public cls_user As New Cl_conjucion
    Public Function comparar_usuario(ByVal user As String, ByVal clave As String) As String
        Dim msj As String
        msj = cls_user.verificar_usuario(user, clave)
        Return msj
    End Function
    Public Function npermisos(ByVal usu As String) As DataTable
        Return cls_user.lpermisos(usu)
    End Function

End Class
