Public Module GlobalVariables
    Public sign1 As String
    Public num1 As Integer
    Public num2 As Integer
    Public num3 As Integer
End Module
Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = Val(TextBox1.Text) & 1
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = Val(TextBox1.Text) & 2
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = Val(TextBox1.Text) & 3
    End Sub


    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Text = Val(TextBox1.Text) & 4
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TextBox1.Text = Val(TextBox1.Text) & 5
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        TextBox1.Text = Val(TextBox1.Text) & 6
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        TextBox1.Text = Val(TextBox1.Text) & 7
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        TextBox1.Text = Val(TextBox1.Text) & 8
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        TextBox1.Text = Val(TextBox1.Text) & 9
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        TextBox1.Text = Val(TextBox1.Text) & 0
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        If MsgBox("Are You Sure You Want To Exit", MsgBoxStyle.YesNo, "EXIT") = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        num1 = Val(TextBox1.Text)
        TextBox1.Text = ""
        sign1 = "+"
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        num2 = Val(TextBox1.Text)
        If sign1 = "+" Then
            num3 = num1 + num2
        End If
        If sign1 = "-" Then
            num3 = num1 - num2
        End If
        If sign1 = "*" Then
            num3 = num1 * num2
        End If
        If sign1 = "/" Then
            num3 = num1 / num2
        End If
        TextBox1.Text = num3
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        num1 = Val(TextBox1.Text)
        TextBox1.Text = ""
        sign1 = "-"
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        num1 = Val(TextBox1.Text)
        TextBox1.Text = ""
        sign1 = "*"
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        num1 = Val(TextBox1.Text)
        TextBox1.Text = ""
        sign1 = "/"
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        TextBox1.Clear()
    End Sub
End Class
