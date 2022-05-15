Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ijumsu As Integer : Dim shakjum As String
        If TextBox1.Text = "" Then
            MessageBox.Show("점수를 입력하세요", "경고 1")
            GoTo talcul
        End If
        ijumsu = Val(TextBox1.Text)
        If ijumsu > 100 Or ijumsu < 0 Then
            MessageBox.Show("0부터 100사이의 값을 입력하세요", "경고 2")
            GoTo talcul
        End If
        Select Case ijumsu
            Case 96 To 100
                shakjum = "A+"
            Case 91 To 95
                shakjum = "A0"
            Case 86 To 90
                shakjum = "B+"
            Case 81 To 85
                shakjum = "B0"
            Case 76 To 80
                shakjum = "C+"
            Case 71 To 75
                shakjum = "C0"
            Case 66 To 70
                shakjum = "D+"
            Case 60 To 65
                shakjum = "D0"
            Case Else
                shakjum = "F! 재수강 ㅠㅠ"
        End Select
        TextBox2.Text = shakjum
talcul: TextBox1.Focus()
    End Sub
End Class