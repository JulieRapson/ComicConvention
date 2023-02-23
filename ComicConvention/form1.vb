'Author: Julie Rapson
'Date: 2/22/2023
'Program name: Comic Convention calc / Weekly Assignment 5
'Program Description: This program lets you calculate the cost of convention tickets based on which tier you select.
'It will only allow you to enter a number 1-20 for this cost calculation.
Public Class form1
    'No const variables per the assignment instructions
    Private Sub frmComicConvention_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Convention only option is pre-selected, the label with the calculations is cleared and the group number
        'is cleared.  Focus is set on the text box.
        radCon.Checked = True
        lblRegCostCalc.Text = ""
        txtGroupAmt.Text = ""
        txtGroupAmt.Focus()

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'The clear button acts like the form load.  Pre-selects convention radio button, clears any calculations, focuses the 
        'text box and clears the group number entered.
        lblRegCostCalc.Text = ""
        txtGroupAmt.Text = ""
        txtGroupAmt.Focus()
        radCon.Checked = True
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        'Variables holding the amount were put here per the instructions of the assignment. These were made into decimals. 
        'There are 2 different if statements.  The first one checks if an invalid entry is made into the group size text
        'box.  The second if statement checks to see which level of ticket you are looking to calculate and does the 
        'calculation as well. After completed, the amount is printed out into the Total Calculation area.
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
