<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegisterForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegisterForm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.CBSection = New System.Windows.Forms.ComboBox()
        Me.CBYear = New System.Windows.Forms.ComboBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.BttnProceed = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TxtBoxMN = New System.Windows.Forms.TextBox()
        Me.TxtBoxFN = New System.Windows.Forms.TextBox()
        Me.TxtBoxLN = New System.Windows.Forms.TextBox()
        Me.TxtBoxPW = New System.Windows.Forms.TextBox()
        Me.TxtBoxVID = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1308, 138)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(11, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(184, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "REGISTER FORM" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(520, 61)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Fill up all the information provided below. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Make sure that all the spelling are" &
    " typed correctly.!"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.CBSection)
        Me.Panel2.Controls.Add(Me.CBYear)
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Controls.Add(Me.BttnProceed)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.TxtBoxMN)
        Me.Panel2.Controls.Add(Me.TxtBoxFN)
        Me.Panel2.Controls.Add(Me.TxtBoxLN)
        Me.Panel2.Controls.Add(Me.TxtBoxPW)
        Me.Panel2.Controls.Add(Me.TxtBoxVID)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(387, 144)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(527, 465)
        Me.Panel2.TabIndex = 2
        '
        'CBSection
        '
        Me.CBSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBSection.FormattingEnabled = True
        Me.CBSection.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        Me.CBSection.Location = New System.Drawing.Point(368, 300)
        Me.CBSection.Name = "CBSection"
        Me.CBSection.Size = New System.Drawing.Size(121, 21)
        Me.CBSection.TabIndex = 5
        '
        'CBYear
        '
        Me.CBYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBYear.FormattingEnabled = True
        Me.CBYear.Items.AddRange(New Object() {"Grade 7", "Grade 8", "Grade 9", "Grade 10", "Grade 11", "Grade 12"})
        Me.CBYear.Location = New System.Drawing.Point(122, 299)
        Me.CBYear.Name = "CBYear"
        Me.CBYear.Size = New System.Drawing.Size(121, 21)
        Me.CBYear.TabIndex = 5
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(163, 437)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(190, 23)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Clear"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'BttnProceed
        '
        Me.BttnProceed.BackgroundImage = CType(resources.GetObject("BttnProceed.BackgroundImage"), System.Drawing.Image)
        Me.BttnProceed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BttnProceed.ForeColor = System.Drawing.Color.White
        Me.BttnProceed.Location = New System.Drawing.Point(163, 406)
        Me.BttnProceed.Name = "BttnProceed"
        Me.BttnProceed.Size = New System.Drawing.Size(190, 25)
        Me.BttnProceed.TabIndex = 3
        Me.BttnProceed.Text = "Proceed"
        Me.BttnProceed.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(303, 354)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(190, 25)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Generate"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TxtBoxMN
        '
        Me.TxtBoxMN.Location = New System.Drawing.Point(342, 215)
        Me.TxtBoxMN.Multiline = True
        Me.TxtBoxMN.Name = "TxtBoxMN"
        Me.TxtBoxMN.Size = New System.Drawing.Size(99, 23)
        Me.TxtBoxMN.TabIndex = 2
        '
        'TxtBoxFN
        '
        Me.TxtBoxFN.Location = New System.Drawing.Point(237, 213)
        Me.TxtBoxFN.Multiline = True
        Me.TxtBoxFN.Name = "TxtBoxFN"
        Me.TxtBoxFN.Size = New System.Drawing.Size(99, 23)
        Me.TxtBoxFN.TabIndex = 2
        '
        'TxtBoxLN
        '
        Me.TxtBoxLN.Location = New System.Drawing.Point(132, 213)
        Me.TxtBoxLN.Multiline = True
        Me.TxtBoxLN.Name = "TxtBoxLN"
        Me.TxtBoxLN.Size = New System.Drawing.Size(99, 23)
        Me.TxtBoxLN.TabIndex = 2
        '
        'TxtBoxPW
        '
        Me.TxtBoxPW.Location = New System.Drawing.Point(132, 357)
        Me.TxtBoxPW.Multiline = True
        Me.TxtBoxPW.Name = "TxtBoxPW"
        Me.TxtBoxPW.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtBoxPW.ReadOnly = True
        Me.TxtBoxPW.Size = New System.Drawing.Size(144, 23)
        Me.TxtBoxPW.TabIndex = 2
        '
        'TxtBoxVID
        '
        Me.TxtBoxVID.Location = New System.Drawing.Point(163, 152)
        Me.TxtBoxVID.Multiline = True
        Me.TxtBoxVID.Name = "TxtBoxVID"
        Me.TxtBoxVID.Size = New System.Drawing.Size(326, 20)
        Me.TxtBoxVID.TabIndex = 2
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(221, 278)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label10.Size = New System.Drawing.Size(168, 61)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Section :"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(-5, 278)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(168, 61)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Year :"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 339)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(168, 61)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Password :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(342, 241)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(99, 26)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Middle Name"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(237, 239)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 26)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "First Name"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(132, 239)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 26)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Last Name"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 193)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(168, 61)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Full Name :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(168, 61)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Voter's ID Number :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RegisterForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1304, 655)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "RegisterForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RegisterForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TxtBoxMN As TextBox
    Friend WithEvents TxtBoxFN As TextBox
    Friend WithEvents TxtBoxLN As TextBox
    Friend WithEvents TxtBoxPW As TextBox
    Friend WithEvents TxtBoxVID As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents BttnProceed As Button
    Friend WithEvents CBSection As ComboBox
    Friend WithEvents CBYear As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
End Class
