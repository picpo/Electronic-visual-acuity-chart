Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As Double
        Dim b As Double
        a = 1 / TextBox1.Text
        b = 2.5 * a * 2.908 * 31.49 * 0.1
        PictureBox1.Height = b
        PictureBox1.Width = b
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
End Class
