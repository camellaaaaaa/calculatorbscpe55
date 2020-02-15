Public Class Calculator

    Dim Firstnum As Decimal
    Dim secondnum As Decimal
    Dim Operations As Integer
    Dim Operator_Selector As Boolean = False


    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles ButtonNum0.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "0"
        Else
            TextBox1.Text = "0"

        End If
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click

    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles ButtonNum1.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "1"
        Else
            TextBox1.Text = "1"

        End If
    End Sub

    Private Sub RectangleShape1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ButtonNum2_Click(sender As Object, e As EventArgs) Handles ButtonNum2.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "2"
        Else
            TextBox1.Text = "2"

        End If
    End Sub

    Private Sub ButtonNum3_Click(sender As Object, e As EventArgs) Handles ButtonNum3.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "3"
        Else
            TextBox1.Text = "3"

        End If
    End Sub

    Private Sub ButtonNum4_Click(sender As Object, e As EventArgs) Handles ButtonNum4.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "4"
        Else
            TextBox1.Text = "4"

        End If
    End Sub

    Private Sub ButtonNum5_Click(sender As Object, e As EventArgs) Handles ButtonNum5.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "5"
        Else
            TextBox1.Text = "5"

        End If
    End Sub

    Private Sub ButtonNum6_Click(sender As Object, e As EventArgs) Handles ButtonNum6.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "6"
        Else
            TextBox1.Text = "6"

        End If
    End Sub

    Private Sub ButtonNum7_Click(sender As Object, e As EventArgs) Handles ButtonNum7.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "7"
        Else
            TextBox1.Text = "7"

        End If
    End Sub

    Private Sub ButtonNum8_Click(sender As Object, e As EventArgs) Handles ButtonNum8.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "8"
        Else
            TextBox1.Text = "8"

        End If
    End Sub

    Private Sub ButtonNum9_Click(sender As Object, e As EventArgs) Handles ButtonNum9.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "9"
        Else
            TextBox1.Text = "9"

        End If
    End Sub
End Class
