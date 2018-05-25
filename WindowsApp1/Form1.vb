Imports System.Runtime.InteropServices

Public Class Form1
    <DllImport("kernel32", CharSet:=CharSet.Auto)>
    Public Shared Function OpenProcess(ByVal Access As Int32, ByVal InheritHandle As Boolean, ByVal ProcessId As Int32) As Long
    End Function

    'Private Declare Function OpenProcess Lib "kernel32" (ByVal dwDesiredAccess As Long, ByVal blnheritHandle As Boolean, ByVal dwAppProcessId As IntPtr) As IntPtr
    'Private Declare Function OpenProcess Lib "kernel32" (ByVal dwDesiredAccess As Long, ByVal bInheritHandle As Long, ByVal dwProcessId As Long) As Long
    '지정한 프로세스 오브젝트 핸들링

    Private Declare Function ShellExecute Lib "shell32.dll" Alias "ShellExecuteA" (
        ByVal hWnd As Long,
        ByVal lpOperation As String,
        ByVal lpFile As String,
        ByVal lpParameters As String,
        ByVal lpDirectory As String,
        ByVal nShowCmd As Long) As Long



    Public Shared Function GetExitCodeProcess(hProcess As Long, lpExitCode As Long) As Long
#Disable Warning BC42353 ' 함수가 일부 코드 경로의 값을 반환하지 않음
    End Function
#Enable Warning BC42353 ' 함수가 일부 코드 경로의 값을 반환하지 않음

    '열러있는 프로세스 오브젝트 핸들링 해제
    Public Shared Function CloseHandle(hObject As Long) As Long
#Disable Warning BC42353 ' 함수가 일부 코드 경로의 값을 반환하지 않음
    End Function
#Enable Warning BC42353 ' 함수가 일부 코드 경로의 값을 반환하지 않음

    Public PROCESS_QUERY_INFORMATION = &H400&
    Public STILL_ACTIVE = &H103&






    Public installPATH As String = ""   ' exe파일 탐색 경로
    Public programPATH As String = ""   ' 프로그램 절대 경로
    Public ComputerName As String = ""  ' 컴퓨터 이름







    Private Sub Form1_Load() Handles MyBase.Load '<- 프로그램 초기 설정을 위한 호출
        programPATH = Trim(Application.StartupPath) & "\" ' & vbCrLf
        If My.Computer.FileSystem.FileExists(programPATH & "list.txt") Then
            ShowListToCheckedlist()
        End If
        ComputerName = My.Computer.Name

    End Sub

    Private Sub SaveEXEList()

    End Sub


    Private Sub SaveList()
        'ShellEnd(
        Shell("cmd.exe /c wmic product get name > " & programPATH & "list.txt", vbNormalFocus)
        ')
        'ShellEnd(Shell("cmd.exe /c attrib +r " & peogramPATH & "list.txt", vbNormalNoFocus))
        'attrib -r - s 폴더경로 /s /d
        'MsgBox("cmd.exe /c wmic product get name > " & programPATH & "list.txt")
        MsgBox("창이 사라질 때까지 기다려 주세요.")
    End Sub

    ' 완료
    Private Function DelList() ' 저장한 txt 파일을 지움
        If My.Computer.FileSystem.FileExists(programPATH & "list.txt") Then
            Shell("cmd.exe /c del " & programPATH & "list.txt")
            MsgBox("파일 있음")
        End If

        If My.Computer.FileSystem.FileExists(programPATH & "list.txt") Then
        Else
            MsgBox("파일 없음")
        End If
        Return 1
    End Function

    ' 완료
    Private Sub ShowListInstall() ' 체크드 리스트 박스에 txt 파일을 읽어서 보여줌 - exe 파일
        Label1.Text = "exe 파일 리스트"
        If My.Computer.FileSystem.FileExists(programPATH & "Install.txt") Then
            My.Forms.Form1.CheckedListBox1.Items.Clear()
            Dim test As System.IO.StreamReader
            Dim str As String = ""
            test = My.Computer.FileSystem.OpenTextFileReader(programPATH & "Install.txt")
            str = test.ReadLine()
            Do While str <> ""
                If str = "" Then
                    Exit Do
                End If
                If str.First.Equals(Chr(32)) Then
                    str = test.ReadLine()
                End If
                Dim a = My.Forms.Form1.CheckedListBox1.Items.Add(Trim(str))
                str = test.ReadLine()
            Loop
        Else
            MsgBox("저장된 파일이 없습니다!!!")
        End If
        CheckedListBox1.Sorted = True
    End Sub

    ' 완료
    Private Function ShowListToCheckedlist() ' 체크드 리스트 박스에 txt 파일을 읽어서 보여줌 - 설치된 프로그램
        Label1.Text = "설치된 프로그램 리스트"
        If (My.Computer.FileSystem.FileExists(programPATH & "list.txt")) Then
            My.Forms.Form1.CheckedListBox1.Items.Clear()
            Dim test As System.IO.StreamReader
            Dim str As String = ""
            test = My.Computer.FileSystem.OpenTextFileReader(programPATH & "list.txt")
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
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click ' 리스트 저장
        SaveList()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click ' 리스트 보기
        ShowListToCheckedlist()
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
        ShowListToCheckedlist()
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
        ShowListToCheckedlist() ' 읽기 + 출력
        DelList() ' 삭제
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click '테스트 버튼
        'Dim x64_programs As String = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\MonitorManage_is1", "Name", "Nothing")
        'Dim x82_programs As String = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall", "MonitorManage_is1", "Nothing")
        'x82_programs = "ddd"
        'MsgBox(x64_programs & Chr(13) & x82_programs)
        'MsgBox(peogramPATH)
        'Shell("cmd.exe /c wmic product get name > " & programPATH & "list.txt", vbNormalNoFocus)
        'ShowListToCheckedlist()
        'Shell("cmd.exe /c del " & programPATH & "list.txt")

        'Dim iVaule As Int32 = My.Computer.Registry.GetValue("경로", "값 이름", "기본값")
        'Dim sValue As String = My.Computer.Registry.GetValue("경로", "값 이름", "기본값")
        'MsgBox(iVaule & Chr(13) & sValue)

        'MsgBox(ComputerName & "\HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall")
        'My.Computer.Registry.CurrentUser.CreateSubKey("HKEY_CURRENT_USER\testKEY")
        'My.Computer.Registry.SetValue("HKEY_CURRENT_USER\testKEY", "testNAME", "testString")
        'Dim RegPATH = "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\ThemeManager"
        'MsgBox(My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\ThemeManager", "LMVersion", "Nothing!!"))

        'MsgBox(My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\{09215AC7-B15F-A151-B90A-6B432EAD80A8}", "DisplayName", "Nothing!!").ToString())


        For Each selectedItem In My.Forms.Form1.CheckedListBox1.CheckedItems()
            MsgBox("cme.exe /c " & installPATH & selectedItem)
        Next
    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class