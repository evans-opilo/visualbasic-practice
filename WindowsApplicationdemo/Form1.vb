Public Class Form1

    Private Sub Label4_Click(sender As System.Object, e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub btnCompute_Click(sender As System.Object, e As System.EventArgs) Handles btnCompute.Click
        Dim kis As Decimal, eng As Decimal, math As Decimal, total As Decimal, average As Decimal, grade As String
        kis = Val(txtKis.Text)
        eng = Val(txtEng.Text)
        math = Val(txtMath.Text)

        total = kis + eng + math
        average = total / 3

        

        If average >= 70 And average <= 100 Then
            grade = "A"
        ElseIf average >= 60 And average <= 69 Then
            grade = "B"
        ElseIf average >= 40 And average <= 49 Then
            grade = "D"
        ElseIf average >= 0 And average <= 39 Then
            grade = "Fail"
        Else
            grade = "Invalid"
        End If


        lblTotal.Text = total
        lblGrade.Text = grade
        lblAverage.Text = average


    End Sub

    Private Sub lblTtl_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click
        clear()
        txtKis.Focus()
    End Sub

    Private Sub clear()
        txtKis.Clear()
        txtEng.Clear()
        txtMath.Clear()
        lblTotal.Text = ""
        lblAverage.Text = ""
        lblGrade.Text = ""

    End Sub


    Private Sub txtKis_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtKis.TextChanged

    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub rdoRed_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rdoRed.CheckedChanged
        If rdoRed.Checked = True Then
            Me.BackColor = Color.Red
        End If
    End Sub

    Private Sub rdoBlue_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rdoBlue.CheckedChanged
        If rdoBlue.Checked = True Then
            Me.BackColor = Color.Blue
        End If
    End Sub

    Private Sub rdoGreen_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rdoGreen.CheckedChanged
        If rdoGreen.Checked = True Then
            Me.BackColor = Color.Green
        End If
    End Sub

    Private Sub cboColors_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboColors.SelectedIndexChanged
        If cboColors.Text = "RED" Then
            Me.BackColor = Color.Red
        ElseIf cboColors.Text = "BLUE" Then
            Me.BackColor = Color.Blue
        ElseIf cboColors.Text = "GREEN" Then
            Me.BackColor = Color.Green
        End If
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        With cboColors
            .Items.Add("RED")
            .Items.Add("BLUE")
            .Items.Add("GREEN")
        End With
    End Sub
End Class
