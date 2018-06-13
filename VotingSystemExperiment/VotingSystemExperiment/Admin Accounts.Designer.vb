<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminViewer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminViewer))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TextBoxPW = New System.Windows.Forms.TextBox()
        Me.TextBoxMN = New System.Windows.Forms.TextBox()
        Me.TextBoxFN = New System.Windows.Forms.TextBox()
        Me.TextBoxLN = New System.Windows.Forms.TextBox()
        Me.TextBoxUS = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.ModifyBttn = New System.Windows.Forms.Button()
        Me.RegisterBttn = New System.Windows.Forms.Button()
        Me.BttnDelete = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(422, 127)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(315, 281)
        Me.DataGridView1.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.TextBoxPW)
        Me.Panel1.Controls.Add(Me.TextBoxMN)
        Me.Panel1.Controls.Add(Me.TextBoxFN)
        Me.Panel1.Controls.Add(Me.TextBoxLN)
        Me.Panel1.Controls.Add(Me.TextBoxUS)
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Controls.Add(Me.ModifyBttn)
        Me.Panel1.Controls.Add(Me.RegisterBttn)
        Me.Panel1.Controls.Add(Me.BttnDelete)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Location = New System.Drawing.Point(12, 126)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(404, 282)
        Me.Panel1.TabIndex = 2
        '
        'TextBoxPW
        '
        Me.TextBoxPW.Location = New System.Drawing.Point(92, 194)
        Me.TextBoxPW.Multiline = True
        Me.TextBoxPW.Name = "TextBoxPW"
        Me.TextBoxPW.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxPW.Size = New System.Drawing.Size(192, 23)
        Me.TextBoxPW.TabIndex = 11
        '
        'TextBoxMN
        '
        Me.TextBoxMN.Location = New System.Drawing.Point(288, 110)
        Me.TextBoxMN.Multiline = True
        Me.TextBoxMN.Name = "TextBoxMN"
        Me.TextBoxMN.Size = New System.Drawing.Size(106, 23)
        Me.TextBoxMN.TabIndex = 11
        '
        'TextBoxFN
        '
        Me.TextBoxFN.Location = New System.Drawing.Point(190, 110)
        Me.TextBoxFN.Multiline = True
        Me.TextBoxFN.Name = "TextBoxFN"
        Me.TextBoxFN.Size = New System.Drawing.Size(94, 23)
        Me.TextBoxFN.TabIndex = 11
        '
        'TextBoxLN
        '
        Me.TextBoxLN.Location = New System.Drawing.Point(92, 110)
        Me.TextBoxLN.Multiline = True
        Me.TextBoxLN.Name = "TextBoxLN"
        Me.TextBoxLN.Size = New System.Drawing.Size(95, 23)
        Me.TextBoxLN.TabIndex = 11
        '
        'TextBoxUS
        '
        Me.TextBoxUS.Location = New System.Drawing.Point(92, 165)
        Me.TextBoxUS.Multiline = True
        Me.TextBoxUS.Name = "TextBoxUS"
        Me.TextBoxUS.Size = New System.Drawing.Size(192, 23)
        Me.TextBoxUS.TabIndex = 11
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Administrator", "Voter"})
        Me.ComboBox1.Location = New System.Drawing.Point(110, 72)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(192, 21)
        Me.ComboBox1.TabIndex = 10
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(305, 136)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 13)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = " Middle Name "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(207, 136)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 13)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "First Name"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(107, 136)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Last Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 113)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "FULL NAME :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 197)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "PASSWORD :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 165)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "USER NAME :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "ACCOUNT TYPE :"
        '
        'Button2
        '
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Location = New System.Drawing.Point(357, 238)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(40, 40)
        Me.Button2.TabIndex = 7
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(12, 300)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(80, 20)
        Me.TextBox2.TabIndex = 6
        '
        'ModifyBttn
        '
        Me.ModifyBttn.BackgroundImage = CType(resources.GetObject("ModifyBttn.BackgroundImage"), System.Drawing.Image)
        Me.ModifyBttn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ModifyBttn.Location = New System.Drawing.Point(128, 237)
        Me.ModifyBttn.Name = "ModifyBttn"
        Me.ModifyBttn.Size = New System.Drawing.Size(117, 40)
        Me.ModifyBttn.TabIndex = 2
        Me.ModifyBttn.Text = "Modify        "
        Me.ModifyBttn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ModifyBttn.UseVisualStyleBackColor = True
        '
        'RegisterBttn
        '
        Me.RegisterBttn.BackgroundImage = CType(resources.GetObject("RegisterBttn.BackgroundImage"), System.Drawing.Image)
        Me.RegisterBttn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RegisterBttn.Location = New System.Drawing.Point(3, 237)
        Me.RegisterBttn.Name = "RegisterBttn"
        Me.RegisterBttn.Size = New System.Drawing.Size(119, 40)
        Me.RegisterBttn.TabIndex = 2
        Me.RegisterBttn.Text = "Add            "
        Me.RegisterBttn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.RegisterBttn.UseVisualStyleBackColor = True
        '
        'BttnDelete
        '
        Me.BttnDelete.BackgroundImage = CType(resources.GetObject("BttnDelete.BackgroundImage"), System.Drawing.Image)
        Me.BttnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BttnDelete.Location = New System.Drawing.Point(251, 237)
        Me.BttnDelete.Name = "BttnDelete"
        Me.BttnDelete.Size = New System.Drawing.Size(100, 40)
        Me.BttnDelete.TabIndex = 2
        Me.BttnDelete.Text = "Delete        "
        Me.BttnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BttnDelete.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackgroundImage = CType(resources.GetObject("Panel3.BackgroundImage"), System.Drawing.Image)
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(403, 56)
        Me.Panel3.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label3.Location = New System.Drawing.Point(126, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(158, 19)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "ACCOUNT DETAILS"
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(0, -1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(745, 108)
        Me.Panel2.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(22, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(275, 41)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Manage Users"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AdminViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(744, 450)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "AdminViewer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Accounts"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents ModifyBttn As Button
    Friend WithEvents RegisterBttn As Button
    Friend WithEvents BttnDelete As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxPW As TextBox
    Friend WithEvents TextBoxLN As TextBox
    Friend WithEvents TextBoxUS As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBoxMN As TextBox
    Friend WithEvents TextBoxFN As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
End Class
