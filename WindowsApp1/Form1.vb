Public Class Form1
    Public PATH_Exe As String = ""      ' exe파일 탐색 경로
    Public PATH_List As String = ""     ' 프로그램 절대 경로
    Public PATH_Reg As String = "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall"      ' Reg 절대경로
    Public ComputerName As String = ""  ' 컴퓨터 이름

    Private Sub shellEnd(ByVal ProcessPath As String) ' 프로그램 종료까지 기다리기
        Dim objProcess As System.Diagnostics.Process
        Try
            objProcess = New System.Diagnostics.Process()
            objProcess.StartInfo.FileName = ProcessPath
            objProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
            objProcess.StartInfo.Arguments = PATH_Exe
            MsgBox(PATH_Exe)
            objProcess.Start()

            'Wait until the process passes back an exit code 
            objProcess.WaitForExit()

            'Free resources associated with this process
            objProcess.Close()
        Catch
            MessageBox.Show("Could not start process " & ProcessPath, "Error")
        End Try
    End Sub

    Private Sub Form1_Load() Handles MyBase.Load '<- 프로그램 초기 설정을 위한 호출
        PATH_List = Trim(Application.StartupPath) & "\" ' & vbCrLf
        If My.Computer.FileSystem.FileExists(PATH_List & "list.txt") Then
            ShowList()
        End If
        ComputerName = My.Computer.Name
        Label1.Text = "ProProgram"
    End Sub

    ' --------------------------------------------------------------------------  exe 관련 부분

    ' 완료
    Private Sub SaveExe() ' exe 파일 경로 리스트 저장
        Shell("cmd.exe /c dir /b " & PATH_Exe & " > " & PATH_List & "exe.txt", vbNormalFocus)
    End Sub

    ' 완료
    Private Sub ShowExe() ' 체크드 리스트 박스에 txt 파일을 읽어서 보여줌 - exe 파일
        Label1.Text = "exe 파일 리스트"
        If My.Computer.FileSystem.FileExists(PATH_List & "exe.txt") Then
            My.Forms.Form1.CheckedListBox1.Items.Clear()
            Dim test As System.IO.StreamReader
            Dim str As String = ""
            test = My.Computer.FileSystem.OpenTextFileReader(PATH_List & "exe.txt")
            str = test.ReadLine()
            Do
                If str = "" Then
                    Exit Do
                End If
                If str.First.Equals(Chr(32)) Then
                    str = test.ReadLine()
                End If
                Dim a = My.Forms.Form1.CheckedListBox1.Items.Add(Trim(str))
                str = test.ReadLine()
            Loop While str <> ""
        Else
            MsgBox("저장된 파일이 없습니다!!!")
        End If
        CheckedListBox1.Sorted = True
    End Sub

    ' 완료
    Private Sub DelExe()
        If My.Computer.FileSystem.FileExists(PATH_List & "exe.txt") Then
            Shell("cmd.exe /c del " & PATH_List & "exe.txt")
        End If
    End Sub

    ' --------------------------------------------------------------------------  wmic 관련 부분

    ' 완료
    Private Sub SaveList() ' 프로그램 리스트 저장
        Shell("cmd.exe /c wmic product get name > " & PATH_List & "list.txt", vbNormalFocus)
        MsgBox("창이 사라질 때까지 기다려 주세요.")
    End Sub

    ' 완료
    Private Sub DelList() ' 저장한 txt 파일을 지움
        If My.Computer.FileSystem.FileExists(PATH_List & "list.txt") Then
            Shell("cmd.exe /c del " & PATH_List & "list.txt")
        End If
    End Sub

    ' 완료
    Private Sub ShowList() ' 체크드 리스트 박스에 txt 파일을 읽어서 보여줌 - 설치된 프로그램
        Label1.Text = "설치된 프로그램 리스트"
        If (My.Computer.FileSystem.FileExists(PATH_List & "list.txt")) Then
            My.Forms.Form1.CheckedListBox1.Items.Clear()
            Dim test As System.IO.StreamReader
            Dim str As String = ""
            test = My.Computer.FileSystem.OpenTextFileReader(PATH_List & "list.txt")
            str = test.ReadLine()
            Do While str <> ""
                str = test.ReadLine()
                If str = "" Then
                    Exit Do
                End If
                If str.First.Equals(Chr(32)) Then
                    str = test.ReadLine()
                End If
                Dim a = My.Forms.Form1.CheckedListBox1.Items.Add(Trim(str))
            Loop
        Else
            MsgBox("저장된 파일이 없습니다!!!")
        End If
        CheckedListBox1.Sorted = True
    End Sub

    ' --------------------------------------------------------------------------  reg 관련 부분

    Private Sub SaveReg()
        Shell("cmd.exe /c reg query " & PATH_Reg & " > " & PATH_List & "reg.txt", vbNormalFocus)
        ' FOR /F "tokens=*" %g IN ('reg query HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall') do (SET VAR=%g)
    End Sub

    Private Sub ShowReg()
        Label1.Text = "reg 파일 리스트"
        If My.Computer.FileSystem.FileExists(PATH_List & "reg.txt") Then
            My.Forms.Form1.CheckedListBox1.Items.Clear()
            Dim test As System.IO.StreamReader
            Dim str As String = ""
            test = My.Computer.FileSystem.OpenTextFileReader(PATH_List & "reg.txt")
            str = test.ReadLine()
            str = Mid(test.ReadLine(), 72)
            Do While str <> ""
                If str = "" Then
                    Exit Do
                End If
                If str.First.Equals(Chr(32)) Then
                    str = Mid(test.ReadLine(), 72)
                End If
                Dim a = My.Forms.Form1.CheckedListBox1.Items.Add(Trim(str))
                str = Mid(test.ReadLine(), 72)
            Loop
        Else
            MsgBox("저장된 파일이 없습니다!!!")
        End If
        CheckedListBox1.Sorted = True
    End Sub

    Private Sub DelReg()
        If My.Computer.FileSystem.FileExists(PATH_List & "reg.txt") Then
            Shell("cmd.exe /c del " & PATH_List & "reg.txt")
        End If
    End Sub

    ' --------------------------------------------------------------------------  버튼 온클릭 관련 부분

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SaveExe()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ShowExe()
    End Sub

    Private Sub 최소화ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 최소화ToolStripMenuItem.Click
        My.Forms.Form1.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub 최대화ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 최대화ToolStripMenuItem.Click
        My.Forms.Form1.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub 프로그램종료ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 프로그램종료ToolStripMenuItem.Click
        My.Forms.Form1.Close()
    End Sub

    Private Sub 프로그램목록새로고침ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 프로그램목록새로고침ToolStripMenuItem.Click
        ShowList()
    End Sub

    Private Sub 프로그램목록텍스트로저장ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 프로그램목록텍스트로저장ToolStripMenuItem.Click
        SaveList()
    End Sub

    Private Sub 선택된프로그램변경삭제ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 선택된프로그램변경삭제ToolStripMenuItem.Click ' 관리자 권한으로 제거 해야 함 - 미완성
        For Each selectedItem In My.Forms.Form1.CheckedListBox1.CheckedItems()
            MsgBox("cme.exe /c wmic /node:" & Chr(34) & ComputerName & Chr(34) & " product where name=" & Chr(34) & selectedItem & Chr(34) & " call uninstall")
        Next
    End Sub

    Private Sub 폴더선택ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 폴더선택ToolStripMenuItem.Click
        My.Forms.Form2.Show()
    End Sub

    Private Sub 설치가능목록불러오기ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 설치가능목록불러오기ToolStripMenuItem.Click

    End Sub

    Private Sub 선택된프로그램설치ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 선택된프로그램설치ToolStripMenuItem.Click

    End Sub

    Private Sub 도움말ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles 도움말ToolStripMenuItem1.Click
        MsgBox("")
    End Sub

    Private Sub 프로그램정보ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 프로그램정보ToolStripMenuItem.Click
        MsgBox("이 프로그램은 군산대 컴퓨터 정보 공학과 DNP연구실에서 만든 프로그램입니다." & Chr(13) & "불법 프로그램 수정이나 배포는 형사처벌을 받을 수 있습니다." & Chr(13) & "다중 프로그램 설치/제거가 가능한 프로그램입니다.",, "Proprogram")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        DelExe()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        SaveList()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ShowList()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        DelList()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        SaveReg()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        ShowReg()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        DelReg()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        MsgBox("exe : " & PATH_Exe & Chr(13) & "list : " & PATH_List & Chr(13) & "reg : " & PATH_Reg)
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        For Each selectedItem In My.Forms.Form1.CheckedListBox1.CheckedItems()

        Next
    End Sub
End Class