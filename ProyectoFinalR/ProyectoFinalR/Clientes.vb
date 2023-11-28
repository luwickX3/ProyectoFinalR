Imports System.Collections.ObjectModel
Imports System.Data.SqlClient
Imports Microsoft.VisualBasic.ApplicationServices

Public Class Clientes
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim IDCliente = Convert.ToInt32(TextBox1.Text)
        Dim NombreCliente = TextBox2.Text
        Dim Contra = TextBox3.Text
        Dim Conexion = New SqlConnection("Data Source=DESKTOP-LFT3TIB\INSTANCEEXPRESS1;Initial Catalog = ProyectoFinalR; Integrated Security = True")
        Conexion.Open()
        Dim Sql As String = "EXEC InsertaCliente @IDCliente = '" & IDCliente & "' ,@NombreCliente = '" & NombreCliente & "' ,@ContraCliente = '" & Contra & "';"
        Dim cmd = New SqlCommand(Sql, Conexion)
        cmd.ExecuteNonQuery()
        Conexion.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub
End Class