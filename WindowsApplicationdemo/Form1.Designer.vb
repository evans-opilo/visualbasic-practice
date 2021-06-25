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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtKis = New System.Windows.Forms.TextBox()
        Me.txtEng = New System.Windows.Forms.TextBox()
        Me.txtMath = New System.Windows.Forms.TextBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblAverage = New System.Windows.Forms.Label()
        Me.btnCompute = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblGrade = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdoRed = New System.Windows.Forms.RadioButton()
        Me.rdoBlue = New System.Windows.Forms.RadioButton()
        Me.rdoGreen = New System.Windows.Forms.RadioButton()
        Me.cboColors = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(24, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "KIS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ENG"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "MATH"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(268, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "TOTAL"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(274, 90)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "AVERAGE"
        '
        'txtKis
        '
        Me.txtKis.AccessibleDescription = ""
        Me.txtKis.Location = New System.Drawing.Point(79, 42)
        Me.txtKis.MaxLength = 2
        Me.txtKis.Name = "txtKis"
        Me.txtKis.Size = New System.Drawing.Size(100, 20)
        Me.txtKis.TabIndex = 6
        '
        'txtEng
        '
        Me.txtEng.Location = New System.Drawing.Point(79, 90)
        Me.txtEng.MaxLength = 2
        Me.txtEng.Name = "txtEng"
        Me.txtEng.Size = New System.Drawing.Size(100, 20)
        Me.txtEng.TabIndex = 7
        '
        'txtMath
        '
        Me.txtMath.Location = New System.Drawing.Point(79, 137)
        Me.txtMath.MaxLength = 2
        Me.txtMath.Name = "txtMath"
        Me.txtMath.Size = New System.Drawing.Size(100, 20)
        Me.txtMath.TabIndex = 9
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotal.Location = New System.Drawing.Point(277, 54)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(104, 20)
        Me.lblTotal.TabIndex = 10
        '
        'lblAverage
        '
        Me.lblAverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAverage.Location = New System.Drawing.Point(277, 112)
        Me.lblAverage.Name = "lblAverage"
        Me.lblAverage.Size = New System.Drawing.Size(104, 20)
        Me.lblAverage.TabIndex = 11
        '
        'btnCompute
        '
        Me.btnCompute.Location = New System.Drawing.Point(45, 257)
        Me.btnCompute.Name = "btnCompute"
        Me.btnCompute.Size = New System.Drawing.Size(96, 45)
        Me.btnCompute.TabIndex = 13
        Me.btnCompute.Text = "Compute"
        Me.btnCompute.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(190, 257)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(96, 45)
        Me.btnClear.TabIndex = 14
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(274, 144)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "GRADE"
        '
        'lblGrade
        '
        Me.lblGrade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGrade.Location = New System.Drawing.Point(277, 167)
        Me.lblGrade.Name = "lblGrade"
        Me.lblGrade.Size = New System.Drawing.Size(104, 20)
        Me.lblGrade.TabIndex = 16
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(333, 260)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(70, 41)
        Me.btnClose.TabIndex = 17
        Me.btnClose.Text = "Exit"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboColors)
        Me.GroupBox1.Controls.Add(Me.rdoGreen)
        Me.GroupBox1.Controls.Add(Me.rdoBlue)
        Me.GroupBox1.Controls.Add(Me.rdoRed)
        Me.GroupBox1.Location = New System.Drawing.Point(551, 45)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(217, 188)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Themes"
        '
        'rdoRed
        '
        Me.rdoRed.AutoSize = True
        Me.rdoRed.Location = New System.Drawing.Point(19, 40)
        Me.rdoRed.Name = "rdoRed"
        Me.rdoRed.Size = New System.Drawing.Size(48, 17)
        Me.rdoRed.TabIndex = 0
        Me.rdoRed.TabStop = True
        Me.rdoRed.Text = "RED"
        Me.rdoRed.UseVisualStyleBackColor = True
        '
        'rdoBlue
        '
        Me.rdoBlue.AutoSize = True
        Me.rdoBlue.Location = New System.Drawing.Point(19, 76)
        Me.rdoBlue.Name = "rdoBlue"
        Me.rdoBlue.Size = New System.Drawing.Size(49, 17)
        Me.rdoBlue.TabIndex = 1
        Me.rdoBlue.TabStop = True
        Me.rdoBlue.Text = "BlUE"
        Me.rdoBlue.UseVisualStyleBackColor = True
        '
        'rdoGreen
        '
        Me.rdoGreen.AutoSize = True
        Me.rdoGreen.Location = New System.Drawing.Point(19, 121)
        Me.rdoGreen.Name = "rdoGreen"
        Me.rdoGreen.Size = New System.Drawing.Size(63, 17)
        Me.rdoGreen.TabIndex = 2
        Me.rdoGreen.TabStop = True
        Me.rdoGreen.Text = "GREEN"
        Me.rdoGreen.UseVisualStyleBackColor = True
        '
        'cboColors
        '
        Me.cboColors.FormattingEnabled = True
        Me.cboColors.Location = New System.Drawing.Point(24, 153)
        Me.cboColors.Name = "cboColors"
        Me.cboColors.Size = New System.Drawing.Size(157, 21)
        Me.cboColors.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(816, 354)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lblGrade)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCompute)
        Me.Controls.Add(Me.lblAverage)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.txtMath)
        Me.Controls.Add(Me.txtEng)
        Me.Controls.Add(Me.txtKis)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtKis As System.Windows.Forms.TextBox
    Friend WithEvents txtEng As System.Windows.Forms.TextBox
    Friend WithEvents txtMath As System.Windows.Forms.TextBox
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents lblAverage As System.Windows.Forms.Label
    Friend WithEvents btnCompute As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblGrade As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rdoGreen As System.Windows.Forms.RadioButton
    Friend WithEvents rdoBlue As System.Windows.Forms.RadioButton
    Friend WithEvents rdoRed As System.Windows.Forms.RadioButton
    Friend WithEvents cboColors As System.Windows.Forms.ComboBox

End Class
