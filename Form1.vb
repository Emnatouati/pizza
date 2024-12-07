Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub lst_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn.Click
        Dim taille = lst.SelectedItem.ToString()
        Dim ingredient As String = ""
        If RDproposition1.Checked Then
            ingredient = "croute fine"
        ElseIf RDproposition2.Checked Then
            ingredient = "croute classique"
        ElseIf RDproposition3.Checked Then
            ingredient = "croute epaisse"
        End If
        Dim ingrsupp As String = ""
        If chkprop1.Checked Then
            ingrsupp = ingrsupp + "champignion"
        ElseIf chkprop2.Checked Then
            ingrsupp = ingrsupp + "olives"
        ElseIf chkprop3.Checked Then
            ingrsupp = ingrsupp + "poivrins"
        ElseIf chkprop4.Checked Then
            ingrsupp = ingrsupp + "fromage supplémentaire"
        End If
        Dim msg As String = "taille" + taille + "type de croute" + ingredient + "ingredient supplémentaires"
        MessageBox.Show(msg)
    End Sub

    Private Sub chkprop4_CheckedChanged(sender As Object, e As EventArgs) Handles chkprop4.CheckedChanged

    End Sub
End Class
