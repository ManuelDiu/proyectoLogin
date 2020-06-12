<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.grdUsers = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnHabilitar = New System.Windows.Forms.Button()
        Me.btnInhabilitar = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbxId = New System.Windows.Forms.TextBox()
        Me.btnVolver = New System.Windows.Forms.Button()
        CType(Me.grdUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdUsers
        '
        Me.grdUsers.AllowUserToAddRows = False
        Me.grdUsers.AllowUserToDeleteRows = False
        Me.grdUsers.AllowUserToResizeColumns = False
        Me.grdUsers.AllowUserToResizeRows = False
        Me.grdUsers.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdUsers.Location = New System.Drawing.Point(30, 87)
        Me.grdUsers.Name = "grdUsers"
        Me.grdUsers.ReadOnly = True
        Me.grdUsers.Size = New System.Drawing.Size(367, 144)
        Me.grdUsers.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(129, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "¡Bienvenido ...!"
        '
        'btnHabilitar
        '
        Me.btnHabilitar.Location = New System.Drawing.Point(19, 248)
        Me.btnHabilitar.Name = "btnHabilitar"
        Me.btnHabilitar.Size = New System.Drawing.Size(115, 31)
        Me.btnHabilitar.TabIndex = 2
        Me.btnHabilitar.Text = "Habilitar"
        Me.btnHabilitar.UseVisualStyleBackColor = True
        '
        'btnInhabilitar
        '
        Me.btnInhabilitar.Location = New System.Drawing.Point(158, 248)
        Me.btnInhabilitar.Name = "btnInhabilitar"
        Me.btnInhabilitar.Size = New System.Drawing.Size(115, 31)
        Me.btnInhabilitar.TabIndex = 3
        Me.btnInhabilitar.Text = "Inhabilitar"
        Me.btnInhabilitar.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(292, 248)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(115, 31)
        Me.btnReset.TabIndex = 4
        Me.btnReset.Text = "Cambiar contraseña"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(21, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "ID:"
        '
        'tbxId
        '
        Me.tbxId.Enabled = False
        Me.tbxId.Location = New System.Drawing.Point(48, 59)
        Me.tbxId.Name = "tbxId"
        Me.tbxId.Size = New System.Drawing.Size(40, 20)
        Me.tbxId.TabIndex = 6
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(307, 52)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(90, 23)
        Me.btnVolver.TabIndex = 7
        Me.btnVolver.Text = "Volver al Login"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(430, 299)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.tbxId)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnInhabilitar)
        Me.Controls.Add(Me.btnHabilitar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grdUsers)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmMain"
        CType(Me.grdUsers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grdUsers As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnHabilitar As Button
    Friend WithEvents btnInhabilitar As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents tbxId As TextBox
    Friend WithEvents btnVolver As Button
End Class
