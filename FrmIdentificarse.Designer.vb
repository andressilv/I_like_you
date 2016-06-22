<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmIdentificarse
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmIdentificarse))
        Me.TBEmail = New System.Windows.Forms.TextBox()
        Me.TBPalabra = New System.Windows.Forms.TextBox()
        Me.BIniciarSesion = New System.Windows.Forms.Button()
        Me.LinkNuevoUsuario = New System.Windows.Forms.LinkLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PBLogo = New System.Windows.Forms.PictureBox()
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TBEmail
        '
        Me.TBEmail.Location = New System.Drawing.Point(78, 178)
        Me.TBEmail.MaxLength = 50
        Me.TBEmail.Name = "TBEmail"
        Me.TBEmail.Size = New System.Drawing.Size(250, 20)
        Me.TBEmail.TabIndex = 2
        Me.TBEmail.Text = "Correo electrónico"
        '
        'TBPalabra
        '
        Me.TBPalabra.Location = New System.Drawing.Point(78, 221)
        Me.TBPalabra.MaxLength = 30
        Me.TBPalabra.Name = "TBPalabra"
        Me.TBPalabra.Size = New System.Drawing.Size(250, 20)
        Me.TBPalabra.TabIndex = 3
        Me.TBPalabra.Text = "Contraseña"
        '
        'BIniciarSesion
        '
        Me.BIniciarSesion.Location = New System.Drawing.Point(78, 265)
        Me.BIniciarSesion.Name = "BIniciarSesion"
        Me.BIniciarSesion.Size = New System.Drawing.Size(250, 50)
        Me.BIniciarSesion.TabIndex = 4
        Me.BIniciarSesion.Text = "Iniciar sesión"
        Me.BIniciarSesion.UseVisualStyleBackColor = True
        '
        'LinkNuevoUsuario
        '
        Me.LinkNuevoUsuario.AutoSize = True
        Me.LinkNuevoUsuario.Location = New System.Drawing.Point(149, 357)
        Me.LinkNuevoUsuario.Name = "LinkNuevoUsuario"
        Me.LinkNuevoUsuario.Size = New System.Drawing.Size(110, 13)
        Me.LinkNuevoUsuario.TabIndex = 5
        Me.LinkNuevoUsuario.TabStop = True
        Me.LinkNuevoUsuario.Text = "Soy un usuario nuevo"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(78, 116)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(250, 32)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Iniciar sesión"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PBLogo
        '
        Me.PBLogo.Image = CType(resources.GetObject("PBLogo.Image"), System.Drawing.Image)
        Me.PBLogo.Location = New System.Drawing.Point(172, 41)
        Me.PBLogo.Name = "PBLogo"
        Me.PBLogo.Size = New System.Drawing.Size(56, 72)
        Me.PBLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBLogo.TabIndex = 7
        Me.PBLogo.TabStop = False
        '
        'FrmIdentificarse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gold
        Me.ClientSize = New System.Drawing.Size(409, 411)
        Me.Controls.Add(Me.PBLogo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LinkNuevoUsuario)
        Me.Controls.Add(Me.BIniciarSesion)
        Me.Controls.Add(Me.TBPalabra)
        Me.Controls.Add(Me.TBEmail)
        Me.Name = "FrmIdentificarse"
        Me.Text = "I LIKE YOU - IDENTIFICARSE"
        CType(Me.PBLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TBEmail As System.Windows.Forms.TextBox
    Friend WithEvents TBPalabra As System.Windows.Forms.TextBox
    Friend WithEvents BIniciarSesion As System.Windows.Forms.Button
    Friend WithEvents LinkNuevoUsuario As System.Windows.Forms.LinkLabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PBLogo As System.Windows.Forms.PictureBox
End Class
