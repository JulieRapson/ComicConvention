Public Class form1
    Private Sub frmComicConvention_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Convention only option is pre-selected, the label with the calculations is cleared and the group number
        'is cleared.  Focus is set on the text box.
        radCon.Checked = True
        lblRegCostCalc.Text = ""
        txtGroupAmt.Text = ""
        txtGroupAmt.Focus()

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblRegCostCalc.Text = ""
        txtGroupAmt.Text = ""
        txtGroupAmt.Focus()
        radCon.Checked = True
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim decConAndSuper As Decimal = 380D
        Dim decConAndAuto As Decimal = 275D
        Dim decCon As Decimal = 209D
        Dim grpSize As Integer
        Dim totalCost As Decimal
        Dim checkNum = IsNumeric(txtGroupAmt.Text)
        'grpSize = Convert.ToInt32(lblGroupSz)
        If txtGroupAmt.Text = "" Then
            MsgBox("Please enter a valid number for your group")
        ElseIf checkNum = False Then
            MsgBox("Please enter only a number for your group")
        ElseIf txtGroupAmt.Text < 1 Or txtGroupAmt.Text > 20 Then
            MsgBox("Please enter a number between 1 and 20")
        End If
        grpSize = Convert.ToInt32(txtGroupAmt.Text)
        If radConSuper.Checked = True Then
            totalCost = grpSize * decConAndSuper
        ElseIf radConAutographs.Checked = True Then
            totalCost = grpSize * decConAndAuto
        ElseIf radCon.Checked = True Then
            totalCost = grpSize * decCon
        End If
        lblRegCostCalc.Visible = True
        lblRegCostCalc.Text = totalCost.ToString("C")


    End Sub
End Class
