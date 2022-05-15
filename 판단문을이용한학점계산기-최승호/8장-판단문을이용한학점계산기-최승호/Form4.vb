Public Class Form4
    Dim ttextbox_input(9) As TextBox
    Dim ttextbox_output(9) As TextBox
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ttextbox_input(0) = TextBox1
        ttextbox_input(1) = TextBox2
        ttextbox_input(2) = TextBox3
        ttextbox_input(3) = TextBox4
        ttextbox_input(4) = TextBox5
        ttextbox_input(5) = TextBox6
        ttextbox_input(6) = TextBox7
        ttextbox_input(7) = TextBox8
        ttextbox_input(8) = TextBox9

        ttextbox_output(0) = TextBox10
        ttextbox_output(1) = TextBox11
        ttextbox_output(2) = TextBox12
        ttextbox_output(3) = TextBox13
        ttextbox_output(4) = TextBox14
        ttextbox_output(5) = TextBox15
        ttextbox_output(6) = TextBox16
        ttextbox_output(7) = TextBox17
        ttextbox_output(8) = TextBox18
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For i = 0 To 8
            If ttextbox_input(i).Text = "" Then
                MessageBox.Show("textbox" & i + 1 & ".text에 점수를 입력하세요", "경고 1-" & i + 1)
            End If
        Next
        Dim ijumsu(9) As Integer
        Dim shakjum(9) As String

        For i = 0 To 8
            ijumsu(i) = Val(ttextbox_input(i).text)
        Next

        For i = 0 To 8
            If ijumsu(i) > 100 Or ijumsu(i) < 0 Then
                MessageBox.Show("textbox" & i + 1 & "에 0부터 100사이의 값을 입력하세요", "경고 2-" & i + 1)
                ttextbox_input(i).Focus()
                Exit Sub
            End If
        Next

        For i = 0 To 8
            Select Case ijumsu(i)
                Case Is >= 96
                    shakjum(i) = "A+"
                Case Is >= 91
                    shakjum(i) = "A0"
                Case Is >= 86
                    shakjum(i) = "B+"
                Case Is >= 81
                    shakjum(i) = "B0"
                Case Is >= 76
                    shakjum(i) = "C+"
                Case Is >= 71
                    shakjum(i) = "C0"
                Case Is >= 66
                    shakjum(i) = "D+"
                Case Is >= 60
                    shakjum(i) = "D0"
                Case Else
                    shakjum(i) = "F! 재수강 ㅠㅠ"
            End Select
        Next
        For i = 0 To 8
            ttextbox_output(i).Text = shakjum(i)

        Next
    End Sub
End Class