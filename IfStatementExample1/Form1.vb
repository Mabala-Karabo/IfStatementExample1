Public Class Form1
    Private Sub btnGreetings_Click(sender As Object, e As EventArgs) Handles btnGreetings.Click
        Dim Country As String
        Country = txtCountry.Text.ToLower
        If Country = "south africa" Then
            MsgBox("Dumela")
        ElseIf Country = "france" Then
            MsgBox("Bojo")
        ElseIf Country = "spanish" Then
            MsgBox("Ola")
        ElseIf Country = "japannese" Then
            MsgBox("Kon'nichiwa")
        ElseIf Country = "korean" Then
            MsgBox("annyeonghaseyo")
        Else
            MsgBox("Hello")
        End If
        MsgBox("---THE END---")
    End Sub

    Private Sub txtCountry_TextChanged(sender As Object, e As EventArgs) Handles txtCountry.TextChanged

    End Sub
End Class
