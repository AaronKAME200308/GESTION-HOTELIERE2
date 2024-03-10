Public Class FormReservation
<<<<<<< HEAD

    Dim ListeClient As New List(Of Client)()
    Dim ListeReservation As New List(Of Reservation)()



    Private Sub Enregistrement_Button_Click(sender As Object, e As EventArgs) Handles Enregistrement_Button.Click

        Dim Client As New Client()

        Client.Nom1 = TextBoxNom.Text
        Client.Prenom1 = TextBoxPrenom.Text
        Client.Sexe1 = TextBoxSexe.Text
        Client.CNI1 = TextBoxCNI.Text
        Client.Telephone1 = TextBoxTelephone.Text

        ListeClient.Add(Client)

        Dim Reservation As New Reservation()

        ListeReservation.Add(Reservation)

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        FormListeDesChambres.Show()

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        FormListeDesChambres.Show()
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        FormListeDesChambres.Show()
    End Sub

    Private Sub GroupBox5_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBoxNom_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
=======
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub
>>>>>>> 221302cfff02583bb14459b8061855e9fdf4b45b
End Class