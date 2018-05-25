Public Class Form2
    Private flag As Int32 = 0

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click '확인
        My.Forms.Form1.PATH_List = My.Forms.Form2.DirListBox1.Path & "\"
        'MsgBox(My.Forms.Form1.PATH_List)
        'MsgBox("cmd.exe /c dir " & My.Forms.Form1.installPATH & "\*.exe /B > " & My.Forms.Form1.programPATH & "Install.txt")
        'Shell("cmd.exe /c dir " & My.Forms.Form1.installPATH & "\*.exe /B > " & My.Forms.Form1.programPATH & "Install.txt")
        My.Forms.Form2.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click '취소
        My.Forms.Form2.Close()
    End Sub

    Private Sub DriveListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DriveListBox1.SelectedIndexChanged
        ' 디스크 선택
        'My.Forms.Form2.Label1.Text = My.Forms.Form2.DriveListBox1.Drive
        My.Forms.Form2.DirListBox1.Path = My.Forms.Form2.DriveListBox1.Drive
    End Sub

    Private Sub DirListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DirListBox1.SelectedIndexChanged
        '경로 선택
        If flag <> 0 Then
            My.Forms.Form2.Label1.Text = My.Forms.Form2.DirListBox1.Path
        End If
        flag = 1
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click '테스트 라벨

    End Sub
End Class