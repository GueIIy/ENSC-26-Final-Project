<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.obsTxt = New System.Windows.Forms.TextBox()
        Me.grpBoxLbl = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.endHourTxt = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.endMinTxt = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.startMinTxt = New System.Windows.Forms.TextBox()
        Me.startHourTxt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.obsCountTxt = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.generateBtn = New System.Windows.Forms.Button()
        Me.grpBoxLbl.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'obsTxt
        '
        Me.obsTxt.Location = New System.Drawing.Point(297, 165)
        Me.obsTxt.Multiline = True
        Me.obsTxt.Name = "obsTxt"
        Me.obsTxt.ReadOnly = True
        Me.obsTxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.obsTxt.Size = New System.Drawing.Size(127, 221)
        Me.obsTxt.TabIndex = 0
        '
        'grpBoxLbl
        '
        Me.grpBoxLbl.Controls.Add(Me.Label1)
        Me.grpBoxLbl.Controls.Add(Me.lblTitle)
        Me.grpBoxLbl.Location = New System.Drawing.Point(12, 12)
        Me.grpBoxLbl.Name = "grpBoxLbl"
        Me.grpBoxLbl.Size = New System.Drawing.Size(262, 147)
        Me.grpBoxLbl.TabIndex = 2
        Me.grpBoxLbl.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(233, 63)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Monitor how you spend your " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "time through work sampling" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "observations."
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Georgia", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(6, 16)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(207, 38)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "StudyTrack"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.endHourTxt)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.endMinTxt)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.startMinTxt)
        Me.GroupBox2.Controls.Add(Me.startHourTxt)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 165)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(262, 124)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        '
        'endHourTxt
        '
        Me.endHourTxt.Location = New System.Drawing.Point(150, 77)
        Me.endHourTxt.Name = "endHourTxt"
        Me.endHourTxt.Size = New System.Drawing.Size(32, 20)
        Me.endHourTxt.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(182, 78)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(11, 16)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = ":" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'endMinTxt
        '
        Me.endMinTxt.Location = New System.Drawing.Point(194, 77)
        Me.endMinTxt.Name = "endMinTxt"
        Me.endMinTxt.Size = New System.Drawing.Size(32, 20)
        Me.endMinTxt.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(62, 78)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(11, 16)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = ":" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'startMinTxt
        '
        Me.startMinTxt.Location = New System.Drawing.Point(74, 77)
        Me.startMinTxt.Name = "startMinTxt"
        Me.startMinTxt.Size = New System.Drawing.Size(32, 20)
        Me.startMinTxt.TabIndex = 5
        '
        'startHourTxt
        '
        Me.startHourTxt.Location = New System.Drawing.Point(29, 77)
        Me.startHourTxt.Name = "startHourTxt"
        Me.startHourTxt.Size = New System.Drawing.Size(32, 20)
        Me.startHourTxt.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(155, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "End Time:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(33, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Start Time:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(62, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 34)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Enter your preferred " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "observation period." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(10, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(167, 17)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Number of observations:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'obsCountTxt
        '
        Me.obsCountTxt.Location = New System.Drawing.Point(27, 41)
        Me.obsCountTxt.Name = "obsCountTxt"
        Me.obsCountTxt.Size = New System.Drawing.Size(124, 20)
        Me.obsCountTxt.TabIndex = 11
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.obsCountTxt)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 304)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(193, 82)
        Me.GroupBox3.TabIndex = 12
        Me.GroupBox3.TabStop = False
        '
        'generateBtn
        '
        Me.generateBtn.Location = New System.Drawing.Point(211, 320)
        Me.generateBtn.Name = "generateBtn"
        Me.generateBtn.Size = New System.Drawing.Size(63, 60)
        Me.generateBtn.TabIndex = 12
        Me.generateBtn.Text = "Generate"
        Me.generateBtn.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(444, 412)
        Me.Controls.Add(Me.generateBtn)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.grpBoxLbl)
        Me.Controls.Add(Me.obsTxt)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.grpBoxLbl.ResumeLayout(False)
        Me.grpBoxLbl.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents obsTxt As TextBox
    Friend WithEvents grpBoxLbl As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents startHourTxt As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents endHourTxt As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents endMinTxt As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents startMinTxt As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents obsCountTxt As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents generateBtn As Button
End Class
