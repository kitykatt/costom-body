Public Class Form1
    Dim money As Integer
    Dim a1 As Integer
    Dim a2 As Integer
    Dim a3 As Integer
    Dim a4 As Integer
    Dim a5 As Integer
    Dim a6 As Integer
    Dim a7 As Integer
    Dim a8 As Integer
    Dim a9 As Integer
    Dim b1 As Integer
    Dim b2 As Integer
    Dim b3 As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        b1 = 30
        PictureBox1.Image = Button1.BackgroundImage
        money = b1 + b2 + b3
        Label1.Text = money
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        b1 = 100
        PictureBox1.Image = Button2.BackgroundImage
        money = b1 + b2 + b3
        Label1.Text = money
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        b1 = 15
        PictureBox1.Image = Button3.BackgroundImage
        money = b1 + b2 + b3
        Label1.Text = money
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        b2 = 14
        PictureBox2.Image = Button4.BackgroundImage
        money = b1 + b2 + b3
        Label1.Text = money
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        b2 = 25
        PictureBox2.Image = Button5.BackgroundImage
        money = b1 + b2 + b3
        Label1.Text = money
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        b2 = 7
        PictureBox2.Image = Button6.BackgroundImage
        money = b1 + b2 + b3
        Label1.Text = money
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        b3 = 70
        PictureBox3.Image = Button7.BackgroundImage
        money = b1 + b2 + b3
        Label1.Text = money
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        b3 = 60
        PictureBox3.Image = Button8.BackgroundImage
        money = b1 + b2 + b3
        Label1.Text = money
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        b3 = 90
        PictureBox3.Image = Button9.BackgroundImage
        money = b1 + b2 + b3
        Label1.Text = money
    End Sub
End Class