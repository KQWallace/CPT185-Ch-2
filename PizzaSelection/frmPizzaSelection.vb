' Program Name: Pizza Selection
' Programmer: Kevin Wallace
' Date Written: January 30, 2018
' Purpose: Allow use to select pizza type

Public Class frmPizzaSelection
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub btnDeepDish_Click(sender As Object, e As EventArgs) Handles btnDeepDish.Click
        'Diplays the deep dish picture,hides thin crust picture & enables select pizza button
        picDeepDish.Visible = True
        PicThinCrust.Visible = False
        btnSelectPizza.Enabled = True
    End Sub

    Private Sub btnThinCrust_Click(sender As Object, e As EventArgs) Handles btnThinCrust.Click
        'Diplays the thin crust picture,hides deep dish picture & enables select pizza button
        picDeepDish.Visible = False
        PicThinCrust.Visible = True
        btnSelectPizza.Enabled = True
    End Sub

    Private Sub btnSelectPizza_Click(sender As Object, e As EventArgs) Handles btnSelectPizza.Click
        btnDeepDish.Enabled = False
        btnThinCrust.Enabled = False
        btnSelectPizza.Enabled = False
        btnExit.Enabled = True
        lblInstructions.Visible = False
        lblConfirmation.Visible = True
    End Sub
End Class
