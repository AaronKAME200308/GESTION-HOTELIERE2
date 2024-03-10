<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
<<<<<<< HEAD
        Me.Reservation_Button = New System.Windows.Forms.Button()
=======
        Me.Button1 = New System.Windows.Forms.Button()
>>>>>>> 221302cfff02583bb14459b8061855e9fdf4b45b
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tempus Sans ITC", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.Indigo
        Me.Label1.Location = New System.Drawing.Point(266, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(276, 62)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "KOR LAND" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tempus Sans ITC", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.Indigo
        Me.Label2.Location = New System.Drawing.Point(287, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(217, 62)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "⭐⭐⭐⭐⭐" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
<<<<<<< HEAD
        'Reservation_Button
        '
        Me.Reservation_Button.Font = New System.Drawing.Font("Tempus Sans ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Reservation_Button.ForeColor = System.Drawing.Color.Indigo
        Me.Reservation_Button.Location = New System.Drawing.Point(167, 266)
        Me.Reservation_Button.Name = "Reservation_Button"
        Me.Reservation_Button.Size = New System.Drawing.Size(144, 59)
        Me.Reservation_Button.TabIndex = 2
        Me.Reservation_Button.Text = "RESERVATION"
        Me.Reservation_Button.UseVisualStyleBackColor = True
=======
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Tempus Sans ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button1.ForeColor = System.Drawing.Color.Indigo
        Me.Button1.Location = New System.Drawing.Point(167, 266)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(144, 59)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "RESERVATION"
        Me.Button1.UseVisualStyleBackColor = True
>>>>>>> 221302cfff02583bb14459b8061855e9fdf4b45b
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Tempus Sans ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button2.ForeColor = System.Drawing.Color.Indigo
        Me.Button2.Location = New System.Drawing.Point(487, 266)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(187, 59)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "RESTAURATION ET TOURISME"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Turquoise
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button2)
<<<<<<< HEAD
        Me.Controls.Add(Me.Reservation_Button)
=======
        Me.Controls.Add(Me.Button1)
>>>>>>> 221302cfff02583bb14459b8061855e9fdf4b45b
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
<<<<<<< HEAD
    Friend WithEvents Reservation_Button As Button
=======
    Friend WithEvents Button1 As Button
>>>>>>> 221302cfff02583bb14459b8061855e9fdf4b45b
    Friend WithEvents Button2 As Button
End Class
