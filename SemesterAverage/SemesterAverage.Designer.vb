<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSemesterAverage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.txtCourse1UserEntry = New System.Windows.Forms.TextBox()
        Me.ToolTips = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtCourse2UserEntry = New System.Windows.Forms.TextBox()
        Me.txtCourse3UserEntry = New System.Windows.Forms.TextBox()
        Me.txtCourse4UserEntry = New System.Windows.Forms.TextBox()
        Me.txtCourse5UserEntry = New System.Windows.Forms.TextBox()
        Me.txtCourse6UserEntry = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblCourse1 = New System.Windows.Forms.Label()
        Me.lblCourse2 = New System.Windows.Forms.Label()
        Me.lblCourse3 = New System.Windows.Forms.Label()
        Me.lblCourse4 = New System.Windows.Forms.Label()
        Me.lblCourse5 = New System.Windows.Forms.Label()
        Me.lblCourse6 = New System.Windows.Forms.Label()
        Me.lblCourse1Grade = New System.Windows.Forms.Label()
        Me.lblCourse2Grade = New System.Windows.Forms.Label()
        Me.lblCourse3Grade = New System.Windows.Forms.Label()
        Me.lblCourse4Grade = New System.Windows.Forms.Label()
        Me.lblCourse5Grade = New System.Windows.Forms.Label()
        Me.lblCourse6Grade = New System.Windows.Forms.Label()
        Me.lblSemester = New System.Windows.Forms.Label()
        Me.lblSemsterAverage = New System.Windows.Forms.Label()
        Me.lblFinalGrade = New System.Windows.Forms.Label()
        Me.lblErrorList = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtCourse1UserEntry
        '
        Me.txtCourse1UserEntry.BackColor = System.Drawing.SystemColors.Window
        Me.txtCourse1UserEntry.Location = New System.Drawing.Point(86, 16)
        Me.txtCourse1UserEntry.Name = "txtCourse1UserEntry"
        Me.txtCourse1UserEntry.Size = New System.Drawing.Size(83, 20)
        Me.txtCourse1UserEntry.TabIndex = 0
        Me.txtCourse1UserEntry.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTips.SetToolTip(Me.txtCourse1UserEntry, "Course 1 Textbox")
        '
        'txtCourse2UserEntry
        '
        Me.txtCourse2UserEntry.Location = New System.Drawing.Point(86, 43)
        Me.txtCourse2UserEntry.Name = "txtCourse2UserEntry"
        Me.txtCourse2UserEntry.Size = New System.Drawing.Size(83, 20)
        Me.txtCourse2UserEntry.TabIndex = 1
        Me.txtCourse2UserEntry.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTips.SetToolTip(Me.txtCourse2UserEntry, "Course 2 Textbox")
        '
        'txtCourse3UserEntry
        '
        Me.txtCourse3UserEntry.Location = New System.Drawing.Point(86, 72)
        Me.txtCourse3UserEntry.Name = "txtCourse3UserEntry"
        Me.txtCourse3UserEntry.Size = New System.Drawing.Size(83, 20)
        Me.txtCourse3UserEntry.TabIndex = 2
        Me.txtCourse3UserEntry.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTips.SetToolTip(Me.txtCourse3UserEntry, "Course 3 Textbox")
        '
        'txtCourse4UserEntry
        '
        Me.txtCourse4UserEntry.Location = New System.Drawing.Point(86, 101)
        Me.txtCourse4UserEntry.Name = "txtCourse4UserEntry"
        Me.txtCourse4UserEntry.Size = New System.Drawing.Size(83, 20)
        Me.txtCourse4UserEntry.TabIndex = 3
        Me.txtCourse4UserEntry.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTips.SetToolTip(Me.txtCourse4UserEntry, "Course 4 Textbox")
        '
        'txtCourse5UserEntry
        '
        Me.txtCourse5UserEntry.Location = New System.Drawing.Point(86, 129)
        Me.txtCourse5UserEntry.Name = "txtCourse5UserEntry"
        Me.txtCourse5UserEntry.Size = New System.Drawing.Size(83, 20)
        Me.txtCourse5UserEntry.TabIndex = 4
        Me.txtCourse5UserEntry.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTips.SetToolTip(Me.txtCourse5UserEntry, "Course 5 Textbox")
        '
        'txtCourse6UserEntry
        '
        Me.txtCourse6UserEntry.Location = New System.Drawing.Point(86, 157)
        Me.txtCourse6UserEntry.Name = "txtCourse6UserEntry"
        Me.txtCourse6UserEntry.Size = New System.Drawing.Size(83, 20)
        Me.txtCourse6UserEntry.TabIndex = 5
        Me.txtCourse6UserEntry.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTips.SetToolTip(Me.txtCourse6UserEntry, "Course 5 Textbox")
        '
        'btnCalculate
        '
        Me.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCalculate.Location = New System.Drawing.Point(45, 378)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(66, 23)
        Me.btnCalculate.TabIndex = 6
        Me.btnCalculate.Text = "&Calculate"
        Me.ToolTips.SetToolTip(Me.btnCalculate, "Calculate button that calculates your average grade")
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnReset.Location = New System.Drawing.Point(117, 378)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(66, 23)
        Me.btnReset.TabIndex = 7
        Me.btnReset.Text = "&Reset"
        Me.ToolTips.SetToolTip(Me.btnReset, "Resets the application")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExit.Location = New System.Drawing.Point(189, 378)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(66, 23)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "&Exit"
        Me.ToolTips.SetToolTip(Me.btnExit, "Exits The application")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblCourse1
        '
        Me.lblCourse1.Location = New System.Drawing.Point(23, 16)
        Me.lblCourse1.Name = "lblCourse1"
        Me.lblCourse1.Size = New System.Drawing.Size(52, 20)
        Me.lblCourse1.TabIndex = 9
        Me.lblCourse1.Text = "Course &1:"
        Me.lblCourse1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTips.SetToolTip(Me.lblCourse1, "Course 1 Label")
        '
        'lblCourse2
        '
        Me.lblCourse2.Location = New System.Drawing.Point(23, 43)
        Me.lblCourse2.Name = "lblCourse2"
        Me.lblCourse2.Size = New System.Drawing.Size(52, 20)
        Me.lblCourse2.TabIndex = 10
        Me.lblCourse2.Text = "Course &2:"
        Me.lblCourse2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTips.SetToolTip(Me.lblCourse2, "Course 2 Label")
        '
        'lblCourse3
        '
        Me.lblCourse3.Location = New System.Drawing.Point(23, 71)
        Me.lblCourse3.Name = "lblCourse3"
        Me.lblCourse3.Size = New System.Drawing.Size(52, 20)
        Me.lblCourse3.TabIndex = 11
        Me.lblCourse3.Text = "Course &3:"
        Me.lblCourse3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTips.SetToolTip(Me.lblCourse3, "Course 3 Label")
        '
        'lblCourse4
        '
        Me.lblCourse4.Location = New System.Drawing.Point(23, 101)
        Me.lblCourse4.Name = "lblCourse4"
        Me.lblCourse4.Size = New System.Drawing.Size(52, 20)
        Me.lblCourse4.TabIndex = 12
        Me.lblCourse4.Text = "Course &4:"
        Me.lblCourse4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTips.SetToolTip(Me.lblCourse4, "Course 4 Label")
        '
        'lblCourse5
        '
        Me.lblCourse5.Location = New System.Drawing.Point(23, 129)
        Me.lblCourse5.Name = "lblCourse5"
        Me.lblCourse5.Size = New System.Drawing.Size(52, 20)
        Me.lblCourse5.TabIndex = 13
        Me.lblCourse5.Text = "Course &5:"
        Me.lblCourse5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTips.SetToolTip(Me.lblCourse5, "Course 5 Label")
        '
        'lblCourse6
        '
        Me.lblCourse6.Location = New System.Drawing.Point(23, 157)
        Me.lblCourse6.Name = "lblCourse6"
        Me.lblCourse6.Size = New System.Drawing.Size(52, 20)
        Me.lblCourse6.TabIndex = 14
        Me.lblCourse6.Text = "Course &6:"
        Me.lblCourse6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTips.SetToolTip(Me.lblCourse6, "Course 6 Label")
        '
        'lblCourse1Grade
        '
        Me.lblCourse1Grade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCourse1Grade.Location = New System.Drawing.Point(177, 16)
        Me.lblCourse1Grade.Name = "lblCourse1Grade"
        Me.lblCourse1Grade.Size = New System.Drawing.Size(80, 20)
        Me.lblCourse1Grade.TabIndex = 15
        Me.lblCourse1Grade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTips.SetToolTip(Me.lblCourse1Grade, "Course 1 Grade label")
        '
        'lblCourse2Grade
        '
        Me.lblCourse2Grade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCourse2Grade.Location = New System.Drawing.Point(177, 44)
        Me.lblCourse2Grade.Name = "lblCourse2Grade"
        Me.lblCourse2Grade.Size = New System.Drawing.Size(80, 20)
        Me.lblCourse2Grade.TabIndex = 16
        Me.lblCourse2Grade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTips.SetToolTip(Me.lblCourse2Grade, "Course 2 Grade label")
        '
        'lblCourse3Grade
        '
        Me.lblCourse3Grade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCourse3Grade.Location = New System.Drawing.Point(177, 72)
        Me.lblCourse3Grade.Name = "lblCourse3Grade"
        Me.lblCourse3Grade.Size = New System.Drawing.Size(80, 20)
        Me.lblCourse3Grade.TabIndex = 17
        Me.lblCourse3Grade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTips.SetToolTip(Me.lblCourse3Grade, "Course 3 Grade label")
        '
        'lblCourse4Grade
        '
        Me.lblCourse4Grade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCourse4Grade.Location = New System.Drawing.Point(177, 102)
        Me.lblCourse4Grade.Name = "lblCourse4Grade"
        Me.lblCourse4Grade.Size = New System.Drawing.Size(80, 20)
        Me.lblCourse4Grade.TabIndex = 18
        Me.lblCourse4Grade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTips.SetToolTip(Me.lblCourse4Grade, "Course 4 Grade label")
        '
        'lblCourse5Grade
        '
        Me.lblCourse5Grade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCourse5Grade.Location = New System.Drawing.Point(177, 130)
        Me.lblCourse5Grade.Name = "lblCourse5Grade"
        Me.lblCourse5Grade.Size = New System.Drawing.Size(80, 20)
        Me.lblCourse5Grade.TabIndex = 19
        Me.lblCourse5Grade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTips.SetToolTip(Me.lblCourse5Grade, "Course 5 Grade label")
        '
        'lblCourse6Grade
        '
        Me.lblCourse6Grade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCourse6Grade.Location = New System.Drawing.Point(176, 158)
        Me.lblCourse6Grade.Name = "lblCourse6Grade"
        Me.lblCourse6Grade.Size = New System.Drawing.Size(80, 20)
        Me.lblCourse6Grade.TabIndex = 20
        Me.lblCourse6Grade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTips.SetToolTip(Me.lblCourse6Grade, "Course 1 Grade label6")
        '
        'lblSemester
        '
        Me.lblSemester.Location = New System.Drawing.Point(12, 181)
        Me.lblSemester.Name = "lblSemester"
        Me.lblSemester.Size = New System.Drawing.Size(63, 20)
        Me.lblSemester.TabIndex = 21
        Me.lblSemester.Text = "&Semester:"
        Me.lblSemester.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTips.SetToolTip(Me.lblSemester, "Semester Name label")
        '
        'lblSemsterAverage
        '
        Me.lblSemsterAverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSemsterAverage.Location = New System.Drawing.Point(86, 183)
        Me.lblSemsterAverage.Name = "lblSemsterAverage"
        Me.lblSemsterAverage.Size = New System.Drawing.Size(83, 20)
        Me.lblSemsterAverage.TabIndex = 22
        Me.lblSemsterAverage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTips.SetToolTip(Me.lblSemsterAverage, "Final Average Label")
        '
        'lblFinalGrade
        '
        Me.lblFinalGrade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFinalGrade.Location = New System.Drawing.Point(176, 183)
        Me.lblFinalGrade.Name = "lblFinalGrade"
        Me.lblFinalGrade.Size = New System.Drawing.Size(80, 20)
        Me.lblFinalGrade.TabIndex = 23
        Me.lblFinalGrade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTips.SetToolTip(Me.lblFinalGrade, "Final Average Grade Letter Label")
        '
        'lblErrorList
        '
        Me.lblErrorList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblErrorList.Location = New System.Drawing.Point(12, 205)
        Me.lblErrorList.Name = "lblErrorList"
        Me.lblErrorList.Size = New System.Drawing.Size(244, 170)
        Me.lblErrorList.TabIndex = 24
        Me.ToolTips.SetToolTip(Me.lblErrorList, "Error Message label")
        '
        'frmSemesterAverage
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(266, 406)
        Me.Controls.Add(Me.lblErrorList)
        Me.Controls.Add(Me.lblFinalGrade)
        Me.Controls.Add(Me.lblSemsterAverage)
        Me.Controls.Add(Me.lblSemester)
        Me.Controls.Add(Me.lblCourse6Grade)
        Me.Controls.Add(Me.lblCourse5Grade)
        Me.Controls.Add(Me.lblCourse4Grade)
        Me.Controls.Add(Me.lblCourse3Grade)
        Me.Controls.Add(Me.lblCourse2Grade)
        Me.Controls.Add(Me.lblCourse1Grade)
        Me.Controls.Add(Me.lblCourse6)
        Me.Controls.Add(Me.lblCourse5)
        Me.Controls.Add(Me.lblCourse4)
        Me.Controls.Add(Me.lblCourse3)
        Me.Controls.Add(Me.lblCourse2)
        Me.Controls.Add(Me.lblCourse1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtCourse6UserEntry)
        Me.Controls.Add(Me.txtCourse5UserEntry)
        Me.Controls.Add(Me.txtCourse4UserEntry)
        Me.Controls.Add(Me.txtCourse3UserEntry)
        Me.Controls.Add(Me.txtCourse2UserEntry)
        Me.Controls.Add(Me.txtCourse1UserEntry)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSemesterAverage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Semester Grades "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtCourse1UserEntry As TextBox
    Friend WithEvents ToolTips As ToolTip
    Friend WithEvents txtCourse2UserEntry As TextBox
    Friend WithEvents txtCourse3UserEntry As TextBox
    Friend WithEvents txtCourse4UserEntry As TextBox
    Friend WithEvents txtCourse5UserEntry As TextBox
    Friend WithEvents txtCourse6UserEntry As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblCourse1 As Label
    Friend WithEvents lblCourse2 As Label
    Friend WithEvents lblCourse3 As Label
    Friend WithEvents lblCourse4 As Label
    Friend WithEvents lblCourse5 As Label
    Friend WithEvents lblCourse6 As Label
    Friend WithEvents lblCourse1Grade As Label
    Friend WithEvents lblCourse2Grade As Label
    Friend WithEvents lblCourse3Grade As Label
    Friend WithEvents lblCourse4Grade As Label
    Friend WithEvents lblCourse5Grade As Label
    Friend WithEvents lblCourse6Grade As Label
    Friend WithEvents lblSemester As Label
    Friend WithEvents lblSemsterAverage As Label
    Friend WithEvents lblFinalGrade As Label
    Friend WithEvents lblErrorList As Label
End Class
