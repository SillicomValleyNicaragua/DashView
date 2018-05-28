Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlDbType
Partial Class Login
    Inherits System.Web.UI.Page



    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub
    Protected Sub BootstrapButton1_Click(sender As Object, e As EventArgs) Handles BootstrapButton1.Click
        Dim sengoku As New Integer
        Dim dv_sql As DataView = DirectCast(SqlDataSource1.Select(DataSourceSelectArguments.Empty), DataView)
        If dv_sql.Count > 0 Then
            sengoku = 1
        Else
            MsgBox("Por favor ingrese sus credenciales")
        End If

        If sengoku = 1 Then
            Session("Usuario") = dv_sql(0).Item(0)
            Response.Redirect("default.aspx")
        End If


    End Sub




    Protected Sub SqlDataSource1_Selecting(sender As Object, e As SqlDataSourceSelectingEventArgs) Handles SqlDataSource1.Selecting

    End Sub
End Class
