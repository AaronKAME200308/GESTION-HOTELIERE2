<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormListeDesChambres
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.NumeroDeChambre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Etat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Prix = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumeroDeChambre, Me.Etat, Me.Prix})
        Me.DataGridView1.Location = New System.Drawing.Point(-1, 40)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(341, 299)
        Me.DataGridView1.TabIndex = 0
        '
        'NumeroDeChambre
        '
        Me.NumeroDeChambre.HeaderText = "N° De Chambre"
        Me.NumeroDeChambre.Name = "NumeroDeChambre"
        '
        'Etat
        '
        Me.Etat.HeaderText = "Etat"
        Me.Etat.Name = "Etat"
        '
        'Prix
        '
        Me.Prix.HeaderText = "Prix"
        Me.Prix.Name = "Prix"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(118, 403)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(87, 45)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Valider"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(241, 403)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(87, 45)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Annuler"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'FormListeDesChambres
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Turquoise
        Me.ClientSize = New System.Drawing.Size(340, 480)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Font = New System.Drawing.Font("Tempus Sans ITC", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "FormListeDesChambres"
        Me.Text = "FormListeDesChambres"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents NumeroDeChambre As DataGridViewTextBoxColumn
    Friend WithEvents Etat As DataGridViewTextBoxColumn
    Friend WithEvents Prix As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
