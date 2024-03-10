<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormListeReservation
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
        Me.NumeroReservation = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Qualité = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomClient = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Matricule = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateReservation = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DureeSejour = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sexe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CNI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Telephone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumeroReservation, Me.Qualité, Me.NomClient, Me.Matricule, Me.DateReservation, Me.DureeSejour, Me.Sexe, Me.CNI, Me.Telephone})
        Me.DataGridView1.Location = New System.Drawing.Point(30, 41)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(937, 255)
        Me.DataGridView1.TabIndex = 0
        '
        'NumeroReservation
        '
        Me.NumeroReservation.HeaderText = "N° Réservation"
        Me.NumeroReservation.Name = "NumeroReservation"
        '
        'Qualité
        '
        Me.Qualité.HeaderText = "Qualité"
        Me.Qualité.Name = "Qualité"
        '
        'NomClient
        '
        Me.NomClient.HeaderText = "Nom du Client"
        Me.NomClient.Name = "NomClient"
        '
        'Matricule
        '
        Me.Matricule.HeaderText = "Matricule du Client"
        Me.Matricule.Name = "Matricule"
        '
        'DateReservation
        '
        Me.DateReservation.HeaderText = "Date de la réservation"
        Me.DateReservation.Name = "DateReservation"
        '
        'DureeSejour
        '
        Me.DureeSejour.HeaderText = "Duurée du séjour"
        Me.DureeSejour.Name = "DureeSejour"
        '
        'Sexe
        '
        Me.Sexe.HeaderText = "Sexe"
        Me.Sexe.Name = "Sexe"
        '
        'CNI
        '
        Me.CNI.HeaderText = "CNI"
        Me.CNI.Name = "CNI"
        '
        'Telephone
        '
        Me.Telephone.HeaderText = "Telephone"
        Me.Telephone.Name = "Telephone"
        '
        'FormListeReservation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(999, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "FormListeReservation"
        Me.Text = "FormListeReservation"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents NumeroReservation As DataGridViewTextBoxColumn
    Friend WithEvents Qualité As DataGridViewTextBoxColumn
    Friend WithEvents NomClient As DataGridViewTextBoxColumn
    Friend WithEvents Matricule As DataGridViewTextBoxColumn
    Friend WithEvents DateReservation As DataGridViewTextBoxColumn
    Friend WithEvents DureeSejour As DataGridViewTextBoxColumn
    Friend WithEvents Sexe As DataGridViewTextBoxColumn
    Friend WithEvents CNI As DataGridViewTextBoxColumn
    Friend WithEvents Telephone As DataGridViewTextBoxColumn
End Class
