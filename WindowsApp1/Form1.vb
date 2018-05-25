Public Class Form1
    Public PATH_Exe As String = ""   ' exe파일 탐색 경로
    Public PATH_List As String = ""   ' 프로그램 절대 경로
    Public ComputerName As String = ""  ' 컴퓨터 이름



    Private Sub Form1_Load() Handles MyBase.Load '<- 프로그램 초기 설정을 위한 호출
        PATH_List = Trim(Application.StartupPath) & "\" ' & vbCrLf
        If My.Computer.FileSystem.FileExists(PATH_List & "list.txt") Then
            ShowList()
        End If
        ComputerName = My.Computer.Name

    End Sub

    ' --------------------------------------------------------------------------  exe 관련 부분

    ' 완료
    Private Sub SaveExe() ' exe 파일 경로 리스트 저장
        Shell("cmd.exe /c dir /b " & PATH_Exe & " > " & PATH_List & "exe.txt", vbNormalFocus)
        MsgBox("창이 사라질 때까지 기다려 주세요.")
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

    Private Sub DelExe()
        If My.Computer.FileSystem.FileExists(PATH_List & "exe.txt") Then
            Shell("cmd.exe /c del " & PATH_List & "list.txt")
            MsgBox("파일 있음")
        End If

        If My.Computer.FileSystem.FileExists(PATH_List & "exe.txt") Then
        Else
            MsgBox("파일 없음")
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
            MsgBox("파일 있음")
        End If

        If My.Computer.FileSystem.FileExists(PATH_List & "list.txt") Then
        Else
            MsgBox("파일 없음")
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




    ' --------------------------------------------------------------------------  버튼 온클릭 관련 부분

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click ' 리스트 저장
        SaveList()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click ' 리스트 보기
        ShowList()
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

    Private Sub CheckedListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckedListBox1.SelectedIndexChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click ' 리스트박스에 표시
        DelList()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click '체크 항목 표시
        SaveList() ' 불러오기 + 저장
        ShowList() ' 읽기 + 출력
        DelList() ' 삭제
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click '테스트 버튼
        'Dim x64_programs As String = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\MonitorManage_is1", "Name", "Nothing")
        'Dim x82_programs As String = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall", "MonitorManage_is1", "Nothing")
        'x82_programs = "ddd"
        'MsgBox(x64_programs & Chr(13) & x82_programs)
        'MsgBox(peogramPATH)
        'Shell("cmd.exe /c wmic product get name > " & PATH_List & "list.txt", vbNormalNoFocus)
        'ShowListToCheckedlist()
        'Shell("cmd.exe /c del " & PATH_List & "list.txt")

        'Dim iVaule As Int32 = My.Computer.Registry.GetValue("경로", "값 이름", "기본값")
        'Dim sValue As String = My.Computer.Registry.GetValue("경로", "값 이름", "기본값")
        'MsgBox(iVaule & Chr(13) & sValue)

        'MsgBox(ComputerName & "\HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall")
        'My.Computer.Registry.CurrentUser.CreateSubKey("HKEY_CURRENT_USER\testKEY")
        'My.Computer.Registry.SetValue("HKEY_CURRENT_USER\testKEY", "testNAME", "testString")
        'Dim RegPATH = "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\ThemeManager"
        'MsgBox(My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\ThemeManager", "LMVersion", "Nothing!!"))

        'MsgBox(My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\{09215AC7-B15F-A151-B90A-6B432EAD80A8}", "DisplayName", "Nothing!!").ToString())

        SaveExe()
    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class