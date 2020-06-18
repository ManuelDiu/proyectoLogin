Imports MySql.Data.MySqlClient

' CÓDIGO DE MANUEL DIU 3º BF.

Public Class frmLogin
    Dim conexion As New MySqlConnection("server=localhost; database=usuariosroles; Uid=root; Pwd=; ")
    Dim adaptador As New MySqlDataAdapter
    Dim datos As New DataSet
    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            conexion.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Evento click al botón login
    Public Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click

        Dim consulta As String
        Dim resultados As String
        If (tbxUser.Text <> "" And tbxPass.Text <> "") Then
            consulta = "SELECT * FROM usuarios WHERE nombre='" & tbxUser.Text & "' AND pass='" & tbxPass.Text & "'"
            adaptador = New MySqlDataAdapter(consulta, conexion)
            datos = New DataSet
            adaptador.Fill(datos, "usuarios")
            resultados = datos.Tables("usuarios").Rows.Count
            ModuloVariables.nombre = tbxUser.Text
        Else
            MsgBox("Complete los campos vacíos por favor.")
        End If

        If (resultados <> 0) Then
            frmMain.Show()
            Me.Close()
        Else
            MsgBox("User/Pass incorrectos.")
        End If

    End Sub

    'Boton registrar nuevo user
    Private Sub btnRegister_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegister.Click
        frmRegistro.Show()
        Me.Hide()
    End Sub

    Public Function esAdmin() As Boolean
        Dim cmd As New MySqlCommand
        Dim adaptadpor As New MySqlDataAdapter
        Dim tabla As New DataTable()
        datos = New DataSet
        cmd = conexion.CreateCommand
        cmd.CommandText = "SELECT * FROM usuarios WHERE nombre = @nombre AND idRol > 1 ;"
        cmd.Prepare()
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("@nombre", tbxUser.Text)

        adaptadpor.SelectCommand = cmd
        adaptadpor.Fill(tabla)
        If (tabla.Rows.Count <> 0) Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Function activo() As Boolean
        Dim cmd As New MySqlCommand
        Dim adaptadpor As New MySqlDataAdapter
        Dim tabla As New DataTable()
        datos = New DataSet
        cmd = conexion.CreateCommand
        cmd.CommandText = "SELECT * FROM usuarios WHERE nombre = @nombre AND activo = true;"
        cmd.Prepare()
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("@nombre", tbxUser.Text)

        adaptadpor.SelectCommand = cmd
        adaptadpor.Fill(tabla)
        If (tabla.Rows.Count <> 0) Then
            Return True
        Else
            Return False
        End If
    End Function
End Class