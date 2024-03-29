Public Class ObjectDemonstrations
    Private Sub reset()
        TextBox1.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.ForeColor = Color.Black
    End Sub
    Private Sub ObjectDemonstrations_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        reset()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        TextBox1.ForeColor = Color.Green
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        TextBox1.ForeColor = Color.Blue
    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged
        TextBox1.ForeColor = Color.Red
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        Dim font = New Font(TextBox1.Font, FontStyle.Italic)
        TextBox1.Font = font
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        Dim font = New Font(TextBox1.Font, FontStyle.Bold)
        TextBox1.Font = font
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        Dim font = New Font(TextBox1.Font, FontStyle.Bold Or FontStyle.Italic)
        TextBox1.Font = font
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PictureBox1.Image = My.Resources.scarlett_johansson_infinity_vision_hulk_wallpaper_preview

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        TextBox1.Font = New Font("Garamond", 10, FontStyle.Regular)

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        TextBox1.Font = New Font("Magneto", 10, FontStyle.Regular)
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        TextBox1.Font = New Font("Tahoma", 10, FontStyle.Regular)
    End Sub
End Class