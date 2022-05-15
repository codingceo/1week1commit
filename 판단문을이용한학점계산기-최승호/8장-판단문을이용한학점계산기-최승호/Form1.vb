Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ijumsu As Integer : Dim shakjum As String
        If TextBox1.Text = "" Then
            MessageBox.Show("점수를 입력하세요", "경고 1")
            TextBox1.Focus()
            Exit Sub

        End If
        ijumsu = Val(TextBox1.Text)
        If ijumsu > 100 Or ijumsu < 0 Then
            MessageBox.Show("0부터 100사이의 값을 입력하세요", "경고 2")
            TextBox1.Focus() : Exit Sub
        End If
        If ijumsu >= 96 And ijumsu <= 100 Then
            shakjum = "A+"
        ElseIf ijumsu >= 91 Then
            shakjum = "A0"
        ElseIf ijumsu >= 86 Then
            shakjum = "B+"
        ElseIf ijumsu >= 81 Then
            shakjum = "B0"
        ElseIf ijumsu >= 76 Then
            shakjum = "C+"
        ElseIf ijumsu >= 71 Then
            shakjum = "C0"
        ElseIf ijumsu >= 66 Then
            shakjum = "D+"
        ElseIf ijumsu >= 60 Then
            shakjum = "D0"
        Else
            shakjum = "f:재수강 당첨"
        End If
        TextBox2.Text = shakjum '변수에 담긴 문자를 textbox2에 출력
    End Sub
End Class
