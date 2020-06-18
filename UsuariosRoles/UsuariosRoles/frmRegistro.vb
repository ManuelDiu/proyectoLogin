Imports MySql.Data.MySqlClient

' CÓDIGO DE MANUEL DIU 3º BF.

Public Class frmRegistro
    Dim conexion As New MySqlConnection("server=localhost; database=usuariosroles; Uid=root; Pwd=; ")
    Dim adaptador As New MySqlDataAdapter
    Dim datos As New DataSet

    Private Sub frmRegistro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            conexion.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'REGISTRAR USUARIO
    Private Sub btnAccept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAccept.Click
        Dim cmd As New MySqlCommand

        If usuarioExiste() = True Then
            MsgBox("El usuario ya existe, por favor elija otro.")

            'VERIFICAR PASSWORD
        ElseIf Not String.Equals(tbxPass.Text, tbxConfirmPass.Text) Then
            MsgBox("Las contraseñas no coinciden. Inténtelo de nuevo.")

        ElseIf Not (tbxNombre.Text <> "" And tbxPass.Text <> "" And tbxConfirmPass.Text <> "") Then
            MsgBox("Rellene los campos vacíos por favor.")
        Else
            Try
                cmd = conexion.CreateCommand
                cmd.CommandText = "INSERT INTO usuarios(idUsuario, nombre, pass, idRol, activo) VALUES('', @nombre, @pass, 3, 0);"
                cmd.Prepare()
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@nombre", tbxNombre.Text)
                cmd.Parameters.AddWithValue("@pass", tbxPass.Text)
                cmd.ExecuteNonQuery()
                conexion.Close()
                frmLogin.Show()
                Me.Close()
                MsgBox("¡Gracias por su registro! Espere a que un administrador apruebe su usuario.")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    'CANCELAR
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        frmLogin.Show()
        Me.Close()
    End Sub

    'VERIFICAR USUARIO EXISTENTE
    Public Function usuarioExiste() As Boolean
        Dim cmd As New MySqlCommand
        Dim adaptadpor As New MySqlDataAdapter
        Dim tabla As New DataTable()
        datos = New DataSet
        cmd = conexion.CreateCommand
        cmd.CommandText = "SELECT * FROM usuarios WHERE nombre = @nombre;"
        cmd.Prepare()
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("@nombre", tbxNombre.Text)

        adaptadpor.SelectCommand = cmd
        adaptadpor.Fill(tabla)
        If (tabla.Rows.Count <> 0) Then
            Return True
        Else
            Return False
        End If

    End Function
End Class