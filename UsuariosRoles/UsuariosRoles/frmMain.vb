Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

' CÓDIGO DE MANUEL DIU 3º BF.

Public Class frmMain
    Dim conexion As New MySqlConnection("server=localhost; database=usuariosroles; Uid=root; Pwd=; ")
    Dim adaptador As New MySqlDataAdapter
    Dim ds As New DataSet

    'Refrescar la grid view
    Sub refrescarGrid()
        Dim consulta As String
        consulta = "SELECT `idUsuario`, `nombre`, `activo` FROM `usuarios`"
        adaptador = New MySqlDataAdapter(consulta, conexion)
        ds = New DataSet
        adaptador.Fill(ds, "usuarios")
        grdUsers.DataSource = ds.Tables(0)
    End Sub

    'Carga del formulario + carga del grid
    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label1.Text = "¡Bienvenido, " & ModuloVariables.nombre & "!"
        Try
            conexion.Open()
            Dim consulta As String
            consulta = "SELECT `idUsuario`, `nombre`, `activo` FROM `usuarios`"
            adaptador = New MySqlDataAdapter(consulta, conexion)
            ds = New DataSet
            adaptador.Fill(ds, "usuarios")
            grdUsers.DataSource = ds.Tables(0)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conexion.Close()
    End Sub

    Private Sub grdUsers_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdUsers.CellContentClick
        Dim fila As DataGridViewRow = grdUsers.CurrentRow
        Try
            tbxId.Text = fila.Cells(0).Value.ToString()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub grdUsers_SelectionChanged(sender As Object, e As EventArgs) Handles grdUsers.SelectionChanged
        If (grdUsers.SelectedRows.Count > 0) Then
            tbxId.Text = grdUsers.Item("idUsuario", grdUsers.SelectedRows(0).Index).Value
        End If
    End Sub

    'Habilitar boolean "activo"
    Private Sub btnHabilitar_Click(sender As Object, e As EventArgs) Handles btnHabilitar.Click
        Dim cmd As MySqlCommand
        conexion.Open()
        Try
            cmd = conexion.CreateCommand()
            cmd.CommandText = "UPDATE usuarios SET activo=true WHERE idUsuario=@id"
            cmd.Parameters.AddWithValue("@id", tbxId.Text)
            cmd.ExecuteNonQuery()
            refrescarGrid()
            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Inhabilitar boolean "activo"
    Private Sub btnInhabilitar_Click(sender As Object, e As EventArgs) Handles btnInhabilitar.Click
        Dim cmd As MySqlCommand
        conexion.Open()
        Try
            cmd = conexion.CreateCommand()
            cmd.CommandText = "UPDATE usuarios SET activo=false WHERE idUsuario=@id"
            cmd.Parameters.AddWithValue("@id", tbxId.Text)
            cmd.ExecuteNonQuery()
            refrescarGrid()
            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Resetear contraseña
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Dim cmd As MySqlCommand
        Dim nuevapass As String
        conexion.Open()
        Try
            cmd = conexion.CreateCommand()
            nuevapass = InputBox("Por favor, ingrese la nueva contraseña:")
            cmd.CommandText = "UPDATE usuarios SET pass=@nuevapass WHERE idUsuario=@id"
            cmd.Parameters.AddWithValue("@nuevapass", nuevapass)
            cmd.Parameters.AddWithValue("@id", tbxId.Text)
            cmd.ExecuteNonQuery()
            refrescarGrid()
            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Volver al formulario login
    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        frmLogin.Show()
        Me.Close()
    End Sub
End Class