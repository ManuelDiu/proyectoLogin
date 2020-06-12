<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegistro
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbxNombre = New System.Windows.Forms.TextBox()
        Me.tbxPass = New System.Windows.Forms.TextBox()
        Me.tbxConfirmPass = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnAccept = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(48, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Contraseña:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Repetir Contr."
        '
        'tbxNombre
        '
        Me.tbxNombre.Location = New System.Drawing.Point(101, 34)
        Me.tbxNombre.Name = "tbxNombre"
        Me.tbxNombre.Size = New System.Drawing.Size(132, 20)
        Me.tbxNombre.TabIndex = 3
        '
        'tbxPass
        '
        Me.tbxPass.Location = New System.Drawing.Point(101, 72)
        Me.tbxPass.Name = "tbxPass"
        Me.tbxPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbxPass.Size = New System.Drawing.Size(132, 20)
        Me.tbxPass.TabIndex = 4
        '
        'tbxConfirmPass
        '
        Me.tbxConfirmPass.Location = New System.Drawing.Point(101, 107)
        Me.tbxConfirmPass.Name = "tbxConfirmPass"
        Me.tbxConfirmPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbxConfirmPass.Size = New System.Drawing.Size(132, 20)
        Me.tbxConfirmPass.TabIndex = 5
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(51, 154)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 6
        Me.btnCancel.Text = "Cancelar"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnAccept
        '
        Me.btnAccept.Location = New System.Drawing.Point(158, 154)
        Me.btnAccept.Name = "btnAccept"
        Me.btnAccept.Size = New System.Drawing.Size(75, 23)
        Me.btnAccept.TabIndex = 7
        Me.btnAccept.Text = "Aceptar"
        Me.btnAccept.UseVisualStyleBackColor = True
        '
        'frmRegistro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 205)
        Me.Controls.Add(Me.btnAccept)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.tbxConfirmPass)
        Me.Controls.Add(Me.tbxPass)
        Me.Controls.Add(Me.tbxNombre)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmRegistro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tbxNombre As System.Windows.Forms.TextBox
    Friend WithEvents tbxPass As System.Windows.Forms.TextBox
    Friend WithEvents tbxConfirmPass As System.Windows.Forms.TextBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnAccept As System.Windows.Forms.Button
End Class
