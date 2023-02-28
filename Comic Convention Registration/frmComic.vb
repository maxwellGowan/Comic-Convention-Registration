Public Class frmComic
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles rbCSE.CheckedChanged

    End Sub

    Private Sub frmComic_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblCalcCost.Text = ""
        rbConvention.Checked = True
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim intGroup As Integer = 0
        Dim decRegistration As Decimal
        Dim decTotalCost As Decimal
        Dim decSuperHero As Decimal = 380D
        Dim decAutographs As Decimal = 275D
        Dim decConvention As Decimal = 209D

        If IsNumeric(txtGroup.Text) Then
            intGroup = Convert.ToInt32(txtGroup.Text)
            If intGroup > 0 And intGroup < 20 Then
                If rbCSE.Checked Then
                    decRegistration = decSuperHero
                ElseIf rbCA.Checked Then
                    decRegistration = decAutographs
                ElseIf rbConvention.Checked Then
                    decRegistration = decConvention
                End If
                decTotalCost = (intGroup * decRegistration)
                lblCalcCost.Text = decTotalCost.ToString("C")
            Else
                MsgBox("Enter A positive number between 1 and 20",, "Invalid Number Error")

            End If
        Else
            MsgBox("Enter a reasonable number between 1 and 20",, "Invalid Entry Error")
        End If
    End Sub

    Private Sub rbCA_CheckedChanged(sender As Object, e As EventArgs) Handles rbCA.CheckedChanged

    End Sub

    Private Sub rbConvention_CheckedChanged(sender As Object, e As EventArgs) Handles rbConvention.CheckedChanged

    End Sub

    Private Sub grpBadge_Enter(sender As Object, e As EventArgs) Handles grpBadge.Enter

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtGroup.Clear()
        lblCalcCost.Text = ""
        rbCSE.Checked = True
        rbCA.Checked = False
        rbConvention.Checked = False
        txtGroup.Focus()
    End Sub

    Private Sub txtGroup_TextChanged(sender As Object, e As EventArgs) Handles txtGroup.TextChanged

    End Sub

    Private Sub lblHeader_Click(sender As Object, e As EventArgs) Handles lblHeader.Click

    End Sub

    Private Sub lblGroup_Click(sender As Object, e As EventArgs) Handles lblGroup.Click

    End Sub
End Class
