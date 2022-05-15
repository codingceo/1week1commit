Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MessageBox.Show("textbox1.text에 점수를 입력하시오 ", "경고 1")
            TextBox1.Focus()
            Exit Sub
        End If

        If TextBox2.Text = "" Then
            MessageBox.Show("textbox2.text에 점수를 입력하시오 ", "경고 2")
            TextBox2.Focus()
            Exit Sub
        End If

        If TextBox3.Text = "" Then
            MessageBox.Show("textbox3.text에 점수를 입력하시오 ", "경고 3")
            TextBox3.Focus()
            Exit Sub
        End If

        If TextBox4.Text = "" Then
            MessageBox.Show("textbox4.text에 점수를 입력하시오 ", "경고 4")
            TextBox4.Focus()
            Exit Sub
        End If

        If TextBox5.Text = "" Then
            MessageBox.Show("textbox5.text에 점수를 입력하시오 ", "경고 5")
            TextBox5.Focus()
            Exit Sub
        End If

        If TextBox6.Text = "" Then
            MessageBox.Show("textbox6.text에 점수를 입력하시오 ", "경고 6")
            TextBox6.Focus()
            Exit Sub
        End If

        If TextBox7.Text = "" Then
            MessageBox.Show("textbox7.text에 점수를 입력하시오 ", "경고 7")
            TextBox7.Focus()
            Exit Sub
        End If

        If TextBox8.Text = "" Then
            MessageBox.Show("textbox8.text에 점수를 입력하시오 ", "경고 8")
            TextBox8.Focus()
            Exit Sub
        End If

        If TextBox9.Text = "" Then
            MessageBox.Show("textbox9.text에 점수를 입력하시오 ", "경고 9")
            TextBox9.Focus()
            Exit Sub
        End If

        Dim ijumsu(9) As Integer '배열변수 ijumsu(0), ijumsu(1)...ijumsu(8)를 선언
        Dim shakjum(9) As String '배열변수 shakjum(0), .....shakjum(8)를 선언

        ijumsu(1) = Val(TextBox1.Text)
        ijumsu(2) = Val(TextBox2.Text)
        ijumsu(3) = Val(TextBox3.Text)
        ijumsu(4) = Val(TextBox4.Text)
        ijumsu(5) = Val(TextBox5.Text)
        ijumsu(6) = Val(TextBox6.Text)
        ijumsu(7) = Val(TextBox7.Text)
        ijumsu(8) = Val(TextBox8.Text)

        For j = 0 To 8
            If ijumsu(j) > 100 Or ijumsu(j) < 0 Then
                MessageBox.Show("textbox" & j + 1 & "에 0부터 100사이의 값을 입력하세요", "경고 10")
                Exit Sub
            End If
        Next

        For j = 0 To 8
            If ijumsu(j) >= 96 Then
                shakjum(j) = "A+"
            ElseIf ijumsu(j) >= 91 Then
                shakjum(j) = "A0"
            ElseIf ijumsu(j) >= 86 Then
                shakjum(j) = "B+"
            ElseIf ijumsu(j) >= 81 Then
                shakjum(j) = "B0"
            ElseIf ijumsu(j) >= 76 Then
                shakjum(j) = "C+"
            ElseIf ijumsu(j) >= 71 Then
                shakjum(j) = "C0"
            ElseIf ijumsu(j) >= 66 Then
                shakjum(j) = "D+"
            ElseIf ijumsu(j) >= 60 Then
                shakjum(j) = "D0"
            Else
                shakjum(j) = "F! 재수강 ㅠㅠ"
            End If
        Next
        TextBox10.Text = shakjum(0)
        TextBox11.Text = shakjum(1)
        TextBox12.Text = shakjum(2)
        TextBox13.Text = shakjum(3)
        TextBox14.Text = shakjum(4)
        TextBox15.Text = shakjum(5)
        TextBox16.Text = shakjum(6)
        TextBox17.Text = shakjum(7)
        TextBox18.Text = shakjum(8)

    End Sub
End Class