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
    Private Sub Buttonmash_Click(sender As Object, e As EventArgs) Handles Button1.Click, Button2.Click, Button3.Click, Button4.Click, Button5.Click, Button6.Click, Button7.Click, Button8.Click, Button9.Click
        Label1.Text = money
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If a2 Or a3 = 1 Then
            a1 = 1
            a2 = 0
            a3 = 0
        End If
        PictureBox1.Image = Button1.BackgroundImage
        money = money + 30
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If a2 = 0 Then
            PictureBox1.Image = Button2.BackgroundImage
            money = money + 100
            a1 = 1
        End If
        If a1 Or a3 = 1 Then
            a2 = 1
            a2 = 0
            a3 = 0
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If a1 Or a2 = 1 Then
            a1 = 0
            a2 = 0
            a3 = 1
        End If
        PictureBox1.Image = Button3.BackgroundImage
        money = money + 50
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If a2 Or a3 = 1 Then
            a1 = 1
            a2 = 0
            a3 = 0
            PictureBox2.Image = Button4.BackgroundImage
            money = money + 30
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If a2 Or a3 = 1 Then
            a1 = 1
            a2 = 0
            a3 = 0
            PictureBox2.Image = Button5.BackgroundImage
            money = money + 30
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If a2 Or a3 = 1 Then
            a1 = 1
            a2 = 0
            a3 = 0
            PictureBox2.Image = Button6.BackgroundImage
            money = money + 30
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If a2 Or a3 = 1 Then
            a1 = 1
            a2 = 0
            a3 = 0
            PictureBox3.Image = Button7.BackgroundImage
            money = money + 70
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If a2 Or a3 = 1 Then
            a1 = 1
            a2 = 0
            a3 = 0
            PictureBox3.Image = Button8.BackgroundImage
            money = money + 60
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If a7 Or a8 = 1 Then
            a7 = 0
            a8 = 0
            a9 = 1
            PictureBox3.Image = Button9.BackgroundImage
            money = money + 80
        End If
    End Sub
End Class