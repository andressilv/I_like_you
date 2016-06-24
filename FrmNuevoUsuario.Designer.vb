<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNuevoUsuario
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TBNombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CBSexo = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TBEmail = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TBPalabra = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CHMujeres = New System.Windows.Forms.CheckBox()
        Me.CHHombres = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TBFoto = New System.Windows.Forms.TextBox()
        Me.BPuntitos = New System.Windows.Forms.Button()
        Me.BAceptar = New System.Windows.Forms.Button()
        Me.CHVer = New System.Windows.Forms.CheckBox()
        Me.OFD = New System.Windows.Forms.OpenFileDialog()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        '
        'TBNombre
        '
        Me.TBNombre.Location = New System.Drawing.Point(136, 34)
        Me.TBNombre.Name = "TBNombre"
        Me.TBNombre.Size = New System.Drawing.Size(328, 20)
        Me.TBNombre.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Sexo"
        '
        'CBSexo
        '
        Me.CBSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBSexo.FormattingEnabled = True
        Me.CBSexo.Items.AddRange(New Object() {"FEMENINO", "MASCULINO"})
        Me.CBSexo.Location = New System.Drawing.Point(136, 78)
        Me.CBSexo.Name = "CBSexo"
        Me.CBSexo.Size = New System.Drawing.Size(163, 21)
        Me.CBSexo.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "e-mail"
        '
        'TBEmail
        '
        Me.TBEmail.Location = New System.Drawing.Point(136, 127)
        Me.TBEmail.Name = "TBEmail"
        Me.TBEmail.Size = New System.Drawing.Size(328, 20)
        Me.TBEmail.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(33, 179)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Contraseña"
        '
        'TBPalabra
        '
        Me.TBPalabra.Location = New System.Drawing.Point(136, 176)
        Me.TBPalabra.MaxLength = 50
        Me.TBPalabra.Name = "TBPalabra"
        Me.TBPalabra.Size = New System.Drawing.Size(265, 20)
        Me.TBPalabra.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(33, 227)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Preferencias"
        '
        'CHMujeres
        '
        Me.CHMujeres.AutoSize = True
        Me.CHMujeres.Location = New System.Drawing.Point(136, 226)
        Me.CHMujeres.Name = "CHMujeres"
        Me.CHMujeres.Size = New System.Drawing.Size(63, 17)
        Me.CHMujeres.TabIndex = 9
        Me.CHMujeres.Text = "Mujeres"
        Me.CHMujeres.UseVisualStyleBackColor = True
        '
        'CHHombres
        '
        Me.CHHombres.AutoSize = True
        Me.CHHombres.Location = New System.Drawing.Point(231, 226)
        Me.CHHombres.Name = "CHHombres"
        Me.CHHombres.Size = New System.Drawing.Size(68, 17)
        Me.CHHombres.TabIndex = 10
        Me.CHHombres.Text = "Hombres"
        Me.CHHombres.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(33, 274)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(28, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Foto"
        '
        'TBFoto
        '
        Me.TBFoto.Enabled = False
        Me.TBFoto.Location = New System.Drawing.Point(136, 271)
        Me.TBFoto.MaxLength = 50
        Me.TBFoto.Name = "TBFoto"
        Me.TBFoto.Size = New System.Drawing.Size(265, 20)
        Me.TBFoto.TabIndex = 12
        '
        'BPuntitos
        '
        Me.BPuntitos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BPuntitos.Location = New System.Drawing.Point(422, 268)
        Me.BPuntitos.Name = "BPuntitos"
        Me.BPuntitos.Size = New System.Drawing.Size(42, 23)
        Me.BPuntitos.TabIndex = 14
        Me.BPuntitos.Text = "..."
        Me.BPuntitos.UseVisualStyleBackColor = True
        '
        'BAceptar
        '
        Me.BAceptar.Location = New System.Drawing.Point(364, 320)
        Me.BAceptar.Name = "BAceptar"
        Me.BAceptar.Size = New System.Drawing.Size(100, 50)
        Me.BAceptar.TabIndex = 16
        Me.BAceptar.Text = "Aceptar"
        Me.BAceptar.UseVisualStyleBackColor = True
        '
        'CHVer
        '
        Me.CHVer.AutoSize = True
        Me.CHVer.Location = New System.Drawing.Point(422, 178)
        Me.CHVer.Name = "CHVer"
        Me.CHVer.Size = New System.Drawing.Size(42, 17)
        Me.CHVer.TabIndex = 17
        Me.CHVer.Text = "Ver"
        Me.CHVer.UseVisualStyleBackColor = True
        '
        'OFD
        '
        Me.OFD.FileName = "OpenFileDialog1"
        '
        'FrmNuevoUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gold
        Me.ClientSize = New System.Drawing.Size(502, 403)
        Me.Controls.Add(Me.CHVer)
        Me.Controls.Add(Me.BAceptar)
        Me.Controls.Add(Me.BPuntitos)
        Me.Controls.Add(Me.TBFoto)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.CHHombres)
        Me.Controls.Add(Me.CHMujeres)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TBPalabra)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TBEmail)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CBSexo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TBNombre)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmNuevoUsuario"
        Me.Text = "I LIKE YOU - NUEVO USUARIO"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TBNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CBSexo As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TBEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TBPalabra As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CHMujeres As System.Windows.Forms.CheckBox
    Friend WithEvents CHHombres As System.Windows.Forms.CheckBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TBFoto As System.Windows.Forms.TextBox
    Friend WithEvents BPuntitos As System.Windows.Forms.Button
    Friend WithEvents BAceptar As System.Windows.Forms.Button
    Friend WithEvents CHVer As System.Windows.Forms.CheckBox
    Friend WithEvents OFD As System.Windows.Forms.OpenFileDialog
End Class
