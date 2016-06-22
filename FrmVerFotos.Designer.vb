<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVerFotos
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmVerFotos))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PBFoto = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LNombre = New System.Windows.Forms.Label()
        Me.BAvanzar = New System.Windows.Forms.Button()
        Me.BRetroceder = New System.Windows.Forms.Button()
        Me.BMeGustaSiNo = New System.Windows.Forms.Button()
        Me.IL = New System.Windows.Forms.ImageList(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TBComentario = New System.Windows.Forms.TextBox()
        Me.SS = New System.Windows.Forms.StatusStrip()
        CType(Me.PBFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(38, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Foto del usuario"
        '
        'PBFoto
        '
        Me.PBFoto.BackColor = System.Drawing.Color.White
        Me.PBFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PBFoto.Location = New System.Drawing.Point(41, 53)
        Me.PBFoto.Name = "PBFoto"
        Me.PBFoto.Size = New System.Drawing.Size(400, 400)
        Me.PBFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PBFoto.TabIndex = 1
        Me.PBFoto.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(488, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre del usuario"
        '
        'LNombre
        '
        Me.LNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LNombre.Location = New System.Drawing.Point(491, 53)
        Me.LNombre.Name = "LNombre"
        Me.LNombre.Size = New System.Drawing.Size(400, 41)
        Me.LNombre.TabIndex = 3
        '
        'BAvanzar
        '
        Me.BAvanzar.Location = New System.Drawing.Point(600, 117)
        Me.BAvanzar.Name = "BAvanzar"
        Me.BAvanzar.Size = New System.Drawing.Size(128, 50)
        Me.BAvanzar.TabIndex = 4
        Me.BAvanzar.Text = "Avanzar"
        Me.BAvanzar.UseVisualStyleBackColor = True
        '
        'BRetroceder
        '
        Me.BRetroceder.Location = New System.Drawing.Point(763, 117)
        Me.BRetroceder.Name = "BRetroceder"
        Me.BRetroceder.Size = New System.Drawing.Size(128, 50)
        Me.BRetroceder.TabIndex = 5
        Me.BRetroceder.Text = "Retroceder"
        Me.BRetroceder.UseVisualStyleBackColor = True
        '
        'BMeGustaSiNo
        '
        Me.BMeGustaSiNo.ImageList = Me.IL
        Me.BMeGustaSiNo.Location = New System.Drawing.Point(763, 325)
        Me.BMeGustaSiNo.Name = "BMeGustaSiNo"
        Me.BMeGustaSiNo.Size = New System.Drawing.Size(128, 128)
        Me.BMeGustaSiNo.TabIndex = 6
        Me.BMeGustaSiNo.UseVisualStyleBackColor = True
        '
        'IL
        '
        Me.IL.ImageStream = CType(resources.GetObject("IL.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.IL.TransparentColor = System.Drawing.Color.Transparent
        Me.IL.Images.SetKeyName(0, "CORAZON_ROJO.png")
        Me.IL.Images.SetKeyName(1, "CORAZON_GRIS.png")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(488, 192)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Tu comentario"
        '
        'TBComentario
        '
        Me.TBComentario.Location = New System.Drawing.Point(491, 208)
        Me.TBComentario.Multiline = True
        Me.TBComentario.Name = "TBComentario"
        Me.TBComentario.Size = New System.Drawing.Size(400, 92)
        Me.TBComentario.TabIndex = 8
        '
        'SS
        '
        Me.SS.Location = New System.Drawing.Point(0, 488)
        Me.SS.Name = "SS"
        Me.SS.Size = New System.Drawing.Size(932, 22)
        Me.SS.TabIndex = 10
        Me.SS.Text = "StatusStrip1"
        '
        'FrmVerFotos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gold
        Me.ClientSize = New System.Drawing.Size(932, 510)
        Me.Controls.Add(Me.SS)
        Me.Controls.Add(Me.TBComentario)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BMeGustaSiNo)
        Me.Controls.Add(Me.BRetroceder)
        Me.Controls.Add(Me.BAvanzar)
        Me.Controls.Add(Me.LNombre)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PBFoto)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmVerFotos"
        Me.Text = "I LIKE YOU - VER FOTOS"
        CType(Me.PBFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PBFoto As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LNombre As System.Windows.Forms.Label
    Friend WithEvents BAvanzar As System.Windows.Forms.Button
    Friend WithEvents BRetroceder As System.Windows.Forms.Button
    Friend WithEvents BMeGustaSiNo As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TBComentario As System.Windows.Forms.TextBox
    Friend WithEvents SS As System.Windows.Forms.StatusStrip
    Friend WithEvents IL As System.Windows.Forms.ImageList

End Class
