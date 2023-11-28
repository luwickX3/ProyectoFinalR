Imports System.Data.SqlClient
Imports System.Diagnostics.Contracts

Public Class Login

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim NombreCliente = TextBox1.Text
        Dim ContraCliente = TextBox2.Text
        Dim Conexion = New SqlConnection("Data Source=DESKTOP-LFT3TIB\INSTANCEEXPRESS1;Initial Catalog = ProyectoFinalR; Integrated Security = True")
        Conexion.Open()
        Dim Sql As String = "SELECT IDCliente FROM Cliente WHERE NombreCliente = '" & NombreCliente &"' AND ContraCliente = '"& ContraCliente &"'"
        Dim cmd = New SqlCommand(Sql, Conexion)
        Dim Leer As SqlDataReader
        Leer = cmd.ExecuteReader()
        If (Leer.Read()) Then
            Conexion.Close()
            MenuPrincipal.Show()
            Me.Close()
        End If
    End Sub
End Class