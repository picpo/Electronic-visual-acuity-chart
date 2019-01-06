Public Class Form1
    Public con As Double = 2.5
    Public rmb As Integer = 1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As Double
        Dim b As Double
        a = 1 / TextBox1.Text
        b = con * a * 2.908 * 31.49 * 0.1
        PictureBox1.Height = b
        PictureBox1.Width = b
        PictureBox1.Location = New Point(624 - (b / 2), 234 - (b / 2))

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim m_intCurrentConnodity As Integer
        Randomize()
        m_intCurrentConnodity = Int(4 * Rnd() + 1)
        If m_intCurrentConnodity = 1 Then
            PictureBox1.Image = My.Resources.E
        ElseIf m_intCurrentConnodity = 2 Then
            PictureBox1.Image = My.Resources.E_gaitubao_com_rotate__90
        ElseIf m_intCurrentConnodity = 3 Then
            PictureBox1.Image = My.Resources.E_gaitubao_com_rotate_90
        ElseIf m_intCurrentConnodity = 4 Then
            PictureBox1.Image = My.Resources.E_gaitubao_com_rotate_180
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Button3.Text = "5m" Then
            Button3.Text = "30cm"
            con = 0.125
        ElseIf Button3.Text = "30cm" Then
        Button3.Text = "5m"
            con = 2.5
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Label5.Text = ""
        Randomize()
        rmb = Int(6 * Rnd() + 1)
        If rmb = 1 Then
            PictureBox2.Image = My.Resources._1_gaitubao_com_rotate__90
        ElseIf rmb = 2 Then
            PictureBox2.Image = My.Resources._2_gaitubao_com_rotate__90
        ElseIf rmb = 3 Then
            PictureBox2.Image = My.Resources._3_gaitubao_com_rotate__90
        ElseIf rmb = 4 Then
            PictureBox2.Image = My.Resources._4_gaitubao_com_rotate__90
        ElseIf rmb = 5 Then
            PictureBox2.Image = My.Resources._5_gaitubao_com_rotate__90
        ElseIf rmb = 6 Then
            PictureBox2.Image = My.Resources._6_gaitubao_com_rotate__90
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If rmb = 1 Then
            Label5.Text = "马   鹿   马   不能读"
        ElseIf rmb = 2 Then
            Label5.Text = "6475   2719   部分数字   不能读"
        ElseIf rmb = 3 Then
            Label5.Text = "拖拉机   牛   拖拉机   不能读"
        ElseIf rmb = 4 Then
            Label5.Text = "89   52   89   不能读"
        ElseIf rmb = 5 Then
            Label5.Text = "马   兔   马   不能读"
        ElseIf rmb = 6 Then
            Label5.Text = "4234   1327   部分数字  不能读"
        End If
    End Sub
End Class
