<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WrapFile
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
        Me.Wrap_BT = New System.Windows.Forms.Button()
        Me.DeletOrginal_CB = New System.Windows.Forms.CheckBox()
        Me.Conform_TextBox = New System.Windows.Forms.TextBox()
        Me.Password_TextBox = New System.Windows.Forms.TextBox()
        Me.OutputFileName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.FileAddress = New System.Windows.Forms.TextBox()
        Me.SelectFolder_BT = New System.Windows.Forms.Button()
        Me.SelectFile_BT = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Cancel_BT = New System.Windows.Forms.Button()
        Me.FolderBrowser = New System.Windows.Forms.FolderBrowserDialog()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Overwrite_CB = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SelectOutFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Wrap_BT
        '
        Me.Wrap_BT.Location = New System.Drawing.Point(417, 170)
        Me.Wrap_BT.Name = "Wrap_BT"
        Me.Wrap_BT.Size = New System.Drawing.Size(124, 23)
        Me.Wrap_BT.TabIndex = 141
        Me.Wrap_BT.Text = "Wrapp"
        Me.Wrap_BT.UseVisualStyleBackColor = True
        '
        'DeletOrginal_CB
        '
        Me.DeletOrginal_CB.AutoSize = True
        Me.DeletOrginal_CB.Location = New System.Drawing.Point(122, 105)
        Me.DeletOrginal_CB.Name = "DeletOrginal_CB"
        Me.DeletOrginal_CB.Size = New System.Drawing.Size(148, 17)
        Me.DeletOrginal_CB.TabIndex = 140
        Me.DeletOrginal_CB.Text = "Delete Original File\Folder"
        Me.DeletOrginal_CB.UseVisualStyleBackColor = True
        '
        'Conform_TextBox
        '
        Me.Conform_TextBox.Location = New System.Drawing.Point(122, 48)
        Me.Conform_TextBox.MaxLength = 255
        Me.Conform_TextBox.Name = "Conform_TextBox"
        Me.Conform_TextBox.Size = New System.Drawing.Size(165, 20)
        Me.Conform_TextBox.TabIndex = 139
        Me.Conform_TextBox.UseSystemPasswordChar = True
        '
        'Password_TextBox
        '
        Me.Password_TextBox.Location = New System.Drawing.Point(122, 22)
        Me.Password_TextBox.MaxLength = 255
        Me.Password_TextBox.Name = "Password_TextBox"
        Me.Password_TextBox.Size = New System.Drawing.Size(165, 20)
        Me.Password_TextBox.TabIndex = 138
        Me.Password_TextBox.UseSystemPasswordChar = True
        '
        'OutputFileName
        '
        Me.OutputFileName.Location = New System.Drawing.Point(122, 131)
        Me.OutputFileName.Name = "OutputFileName"
        Me.OutputFileName.Size = New System.Drawing.Size(312, 20)
        Me.OutputFileName.TabIndex = 137
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(23, 131)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 13)
        Me.Label5.TabIndex = 136
        Me.Label5.Text = "Select Output File:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 51)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 13)
        Me.Label4.TabIndex = 135
        Me.Label4.Text = "Confirm Password:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 13)
        Me.Label3.TabIndex = 134
        Me.Label3.Text = "Select Passowrd:"
        '
        'FileAddress
        '
        Me.FileAddress.BackColor = System.Drawing.Color.WhiteSmoke
        Me.FileAddress.Location = New System.Drawing.Point(122, 79)
        Me.FileAddress.Name = "FileAddress"
        Me.FileAddress.ReadOnly = True
        Me.FileAddress.Size = New System.Drawing.Size(312, 20)
        Me.FileAddress.TabIndex = 133
        '
        'SelectFolder_BT
        '
        Me.SelectFolder_BT.BackgroundImage = Global.FileWrapper.My.Resources.Resources.Folder_Image
        Me.SelectFolder_BT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.SelectFolder_BT.Location = New System.Drawing.Point(65, 3)
        Me.SelectFolder_BT.Name = "SelectFolder_BT"
        Me.SelectFolder_BT.Size = New System.Drawing.Size(64, 60)
        Me.SelectFolder_BT.TabIndex = 132
        Me.SelectFolder_BT.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.SelectFolder_BT.UseVisualStyleBackColor = True
        '
        'SelectFile_BT
        '
        Me.SelectFile_BT.BackgroundImage = Global.FileWrapper.My.Resources.Resources.File_Image
        Me.SelectFile_BT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.SelectFile_BT.Location = New System.Drawing.Point(3, 3)
        Me.SelectFile_BT.Name = "SelectFile_BT"
        Me.SelectFile_BT.Size = New System.Drawing.Size(56, 60)
        Me.SelectFile_BT.TabIndex = 131
        Me.SelectFile_BT.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.SelectFile_BT.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 13)
        Me.Label2.TabIndex = 130
        Me.Label2.Text = "Select File/Folder:"
        '
        'Cancel_BT
        '
        Me.Cancel_BT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cancel_BT.Location = New System.Drawing.Point(547, 170)
        Me.Cancel_BT.Name = "Cancel_BT"
        Me.Cancel_BT.Size = New System.Drawing.Size(87, 23)
        Me.Cancel_BT.TabIndex = 129
        Me.Cancel_BT.Text = "Cancel"
        Me.Cancel_BT.UseVisualStyleBackColor = True
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        Me.BackgroundWorker1.WorkerSupportsCancellation = True
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.SelectFile_BT)
        Me.FlowLayoutPanel1.Controls.Add(Me.SelectFolder_BT)
        Me.FlowLayoutPanel1.Controls.Add(Me.LinkLabel1)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(440, 48)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(307, 74)
        Me.FlowLayoutPanel1.TabIndex = 142
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(135, 0)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(134, 39)
        Me.LinkLabel1.TabIndex = 133
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Instead create a wrapper..."
        Me.ToolTip1.SetToolTip(Me.LinkLabel1, "Create a new wrapper to add multiple files and " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "folder (even other wrapped files" & _
                ")")
        '
        'ToolTip1
        '
        Me.ToolTip1.AutoPopDelay = 5000
        Me.ToolTip1.InitialDelay = 500
        Me.ToolTip1.ReshowDelay = 100
        Me.ToolTip1.ToolTipTitle = "Wish to add Multiple Folders?"
        '
        'Overwrite_CB
        '
        Me.Overwrite_CB.AutoSize = True
        Me.Overwrite_CB.Location = New System.Drawing.Point(276, 105)
        Me.Overwrite_CB.Name = "Overwrite_CB"
        Me.Overwrite_CB.Size = New System.Drawing.Size(110, 17)
        Me.Overwrite_CB.TabIndex = 143
        Me.Overwrite_CB.Text = "Overwrite Existing"
        Me.Overwrite_CB.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(440, 129)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(44, 23)
        Me.Button1.TabIndex = 144
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'SelectOutFileDialog
        '
        Me.SelectOutFileDialog.DefaultExt = "wppfolder"
        Me.SelectOutFileDialog.SupportMultiDottedExtensions = True
        Me.SelectOutFileDialog.Title = "Save"
        '
        'WrapFile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(646, 205)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Overwrite_CB)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.Wrap_BT)
        Me.Controls.Add(Me.DeletOrginal_CB)
        Me.Controls.Add(Me.Conform_TextBox)
        Me.Controls.Add(Me.Password_TextBox)
        Me.Controls.Add(Me.OutputFileName)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.FileAddress)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Cancel_BT)
        Me.Name = "WrapFile"
        Me.Text = "WrapFile"
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Wrap_BT As System.Windows.Forms.Button
    Friend WithEvents DeletOrginal_CB As System.Windows.Forms.CheckBox
    Friend WithEvents Conform_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Password_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents OutputFileName As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents FileAddress As System.Windows.Forms.TextBox
    Friend WithEvents SelectFolder_BT As System.Windows.Forms.Button
    Friend WithEvents SelectFile_BT As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Cancel_BT As System.Windows.Forms.Button
    Friend WithEvents FolderBrowser As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Overwrite_CB As System.Windows.Forms.CheckBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents SelectOutFileDialog As System.Windows.Forms.SaveFileDialog
End Class
