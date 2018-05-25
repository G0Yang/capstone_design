<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기에서는 수정하지 마세요.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.정보ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.프로그램정보ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.최소화ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.최대화ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.프로그램종료ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.변경삭제ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.프로그램목록새로고침ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.프로그램목록텍스트로저장ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.선택된프로그램변경삭제ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.설치ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.폴더선택ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.설치가능목록불러오기ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.선택된프로그램설치ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.도움말ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.도움말ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(96, 345)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(83, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "save exe"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(96, 374)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(83, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "show exe"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.정보ToolStripMenuItem, Me.변경삭제ToolStripMenuItem, Me.설치ToolStripMenuItem, Me.도움말ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        '정보ToolStripMenuItem
        '
        Me.정보ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.프로그램정보ToolStripMenuItem, Me.ToolStripSeparator1, Me.최소화ToolStripMenuItem, Me.최대화ToolStripMenuItem, Me.프로그램종료ToolStripMenuItem})
        Me.정보ToolStripMenuItem.Name = "정보ToolStripMenuItem"
        Me.정보ToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.정보ToolStripMenuItem.Text = "정보"
        '
        '프로그램정보ToolStripMenuItem
        '
        Me.프로그램정보ToolStripMenuItem.Name = "프로그램정보ToolStripMenuItem"
        Me.프로그램정보ToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.프로그램정보ToolStripMenuItem.Text = "프로그램 정보"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(147, 6)
        '
        '최소화ToolStripMenuItem
        '
        Me.최소화ToolStripMenuItem.Name = "최소화ToolStripMenuItem"
        Me.최소화ToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.최소화ToolStripMenuItem.Text = "최소화"
        '
        '최대화ToolStripMenuItem
        '
        Me.최대화ToolStripMenuItem.Name = "최대화ToolStripMenuItem"
        Me.최대화ToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.최대화ToolStripMenuItem.Text = "최대화"
        '
        '프로그램종료ToolStripMenuItem
        '
        Me.프로그램종료ToolStripMenuItem.Name = "프로그램종료ToolStripMenuItem"
        Me.프로그램종료ToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.프로그램종료ToolStripMenuItem.Text = "프로그램 종료"
        '
        '변경삭제ToolStripMenuItem
        '
        Me.변경삭제ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.프로그램목록새로고침ToolStripMenuItem, Me.프로그램목록텍스트로저장ToolStripMenuItem, Me.선택된프로그램변경삭제ToolStripMenuItem})
        Me.변경삭제ToolStripMenuItem.Name = "변경삭제ToolStripMenuItem"
        Me.변경삭제ToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.변경삭제ToolStripMenuItem.Text = "변경/삭제"
        '
        '프로그램목록새로고침ToolStripMenuItem
        '
        Me.프로그램목록새로고침ToolStripMenuItem.Name = "프로그램목록새로고침ToolStripMenuItem"
        Me.프로그램목록새로고침ToolStripMenuItem.Size = New System.Drawing.Size(230, 22)
        Me.프로그램목록새로고침ToolStripMenuItem.Text = "프로그램 목록 새로고침"
        '
        '프로그램목록텍스트로저장ToolStripMenuItem
        '
        Me.프로그램목록텍스트로저장ToolStripMenuItem.Name = "프로그램목록텍스트로저장ToolStripMenuItem"
        Me.프로그램목록텍스트로저장ToolStripMenuItem.Size = New System.Drawing.Size(230, 22)
        Me.프로그램목록텍스트로저장ToolStripMenuItem.Text = "프로그램 목록 텍스트로 저장"
        '
        '선택된프로그램변경삭제ToolStripMenuItem
        '
        Me.선택된프로그램변경삭제ToolStripMenuItem.Name = "선택된프로그램변경삭제ToolStripMenuItem"
        Me.선택된프로그램변경삭제ToolStripMenuItem.Size = New System.Drawing.Size(230, 22)
        Me.선택된프로그램변경삭제ToolStripMenuItem.Text = "선택된 프로그램 변경/삭제"
        '
        '설치ToolStripMenuItem
        '
        Me.설치ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.폴더선택ToolStripMenuItem, Me.설치가능목록불러오기ToolStripMenuItem, Me.선택된프로그램설치ToolStripMenuItem})
        Me.설치ToolStripMenuItem.Name = "설치ToolStripMenuItem"
        Me.설치ToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.설치ToolStripMenuItem.Text = "설치"
        '
        '폴더선택ToolStripMenuItem
        '
        Me.폴더선택ToolStripMenuItem.Name = "폴더선택ToolStripMenuItem"
        Me.폴더선택ToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.폴더선택ToolStripMenuItem.Text = "폴더 선택"
        '
        '설치가능목록불러오기ToolStripMenuItem
        '
        Me.설치가능목록불러오기ToolStripMenuItem.Name = "설치가능목록불러오기ToolStripMenuItem"
        Me.설치가능목록불러오기ToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.설치가능목록불러오기ToolStripMenuItem.Text = "설치 가능 목록 불러오기"
        '
        '선택된프로그램설치ToolStripMenuItem
        '
        Me.선택된프로그램설치ToolStripMenuItem.Name = "선택된프로그램설치ToolStripMenuItem"
        Me.선택된프로그램설치ToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.선택된프로그램설치ToolStripMenuItem.Text = "선택된 프로그램 설치"
        '
        '도움말ToolStripMenuItem
        '
        Me.도움말ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.도움말ToolStripMenuItem1})
        Me.도움말ToolStripMenuItem.Name = "도움말ToolStripMenuItem"
        Me.도움말ToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.도움말ToolStripMenuItem.Text = "도움말"
        '
        '도움말ToolStripMenuItem1
        '
        Me.도움말ToolStripMenuItem1.Name = "도움말ToolStripMenuItem1"
        Me.도움말ToolStripMenuItem1.Size = New System.Drawing.Size(110, 22)
        Me.도움말ToolStripMenuItem1.Text = "도움말"
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.Location = New System.Drawing.Point(12, 55)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(537, 276)
        Me.CheckedListBox1.TabIndex = 3
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(96, 403)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(83, 23)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "del exe"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(12, 345)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(78, 23)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "save list"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(15, 374)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 6
        Me.Button5.Text = "show lsit"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(12, 429)
        Me.ProgressBar1.Margin = New System.Windows.Forms.Padding(2)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(765, 10)
        Me.ProgressBar1.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 12)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Label1"
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(15, 403)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 9
        Me.Button6.Text = "del list"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(186, 345)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(75, 23)
        Me.Button7.TabIndex = 10
        Me.Button7.Text = "save reg"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(186, 374)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(75, 23)
        Me.Button8.TabIndex = 11
        Me.Button8.Text = "show reg"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(186, 403)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(75, 23)
        Me.Button9.TabIndex = 12
        Me.Button9.Text = "del reg"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.CheckedListBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents 정보ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 프로그램정보ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents 최소화ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 최대화ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 프로그램종료ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 변경삭제ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 프로그램목록새로고침ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 프로그램목록텍스트로저장ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 선택된프로그램변경삭제ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 설치ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 폴더선택ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 설치가능목록불러오기ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 선택된프로그램설치ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 도움말ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 도움말ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CheckedListBox1 As CheckedListBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Label1 As Label
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
End Class
