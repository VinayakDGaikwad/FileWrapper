<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExtractDialog
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
        Me.Exctract_BT = New System.Windows.Forms.Button()
        Me.Cancel_BT = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FileAddress = New System.Windows.Forms.TextBox()
        Me.Password_TB = New System.Windows.Forms.TextBox()
        Me.Browrse_BT = New System.Windows.Forms.Button()
        Me.Extractor = New System.ComponentModel.BackgroundWorker()
        Me.DeleteFile_CB = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Exctract_BT
        '
        Me.Exctract_BT.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Exctract_BT.Location = New System.Drawing.Point(227, 78)
        Me.Exctract_BT.Name = "Exctract_BT"
        Me.Exctract_BT.Size = New System.Drawing.Size(96, 23)
        Me.Exctract_BT.TabIndex = 0
        Me.Exctract_BT.Text = "Extract"
        Me.Exctract_BT.UseVisualStyleBackColor = True
        '
        'Cancel_BT
        '
        Me.Cancel_BT.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Cancel_BT.Location = New System.Drawing.Point(329, 78)
        Me.Cancel_BT.Name = "Cancel_BT"
        Me.Cancel_BT.Size = New System.Drawing.Size(75, 23)
        Me.Cancel_BT.TabIndex = 1
        Me.Cancel_BT.Text = "Cancel"
        Me.Cancel_BT.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Wrapped File/Folder:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Password:"
        '
        'FileAddress
        '
        Me.FileAddress.Location = New System.Drawing.Point(135, 20)
        Me.FileAddress.Name = "FileAddress"
        Me.FileAddress.Size = New System.Drawing.Size(192, 20)
        Me.FileAddress.TabIndex = 4
        '
        'Password_TB
        '
        Me.Password_TB.Location = New System.Drawing.Point(135, 46)
        Me.Password_TB.Name = "Password_TB"
        Me.Password_TB.Size = New System.Drawing.Size(100, 20)
        Me.Password_TB.TabIndex = 5
        Me.Password_TB.UseSystemPasswordChar = True
        '
        'Browrse_BT
        '
        Me.Browrse_BT.Location = New System.Drawing.Point(333, 18)
        Me.Browrse_BT.Name = "Browrse_BT"
        Me.Browrse_BT.Size = New System.Drawing.Size(72, 23)
        Me.Browrse_BT.TabIndex = 6
        Me.Browrse_BT.Text = "Browse.."
        Me.Browrse_BT.UseVisualStyleBackColor = True
        '
        'Extractor
        '
        Me.Extractor.WorkerReportsProgress = True
        '
        'DeleteFile_CB
        '
        Me.DeleteFile_CB.AutoSize = True
        Me.DeleteFile_CB.Location = New System.Drawing.Point(241, 48)
        Me.DeleteFile_CB.Name = "DeleteFile_CB"
        Me.DeleteFile_CB.Size = New System.Drawing.Size(95, 17)
        Me.DeleteFile_CB.TabIndex = 7
        Me.DeleteFile_CB.Text = "Delete Original"
        Me.DeleteFile_CB.UseVisualStyleBackColor = True
        '
        'ExtractDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(416, 113)
        Me.Controls.Add(Me.DeleteFile_CB)
        Me.Controls.Add(Me.Browrse_BT)
        Me.Controls.Add(Me.Password_TB)
        Me.Controls.Add(Me.FileAddress)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Cancel_BT)
        Me.Controls.Add(Me.Exctract_BT)
        Me.Name = "ExtractDialog"
        Me.Text = "ExtractDialog"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Exctract_BT As System.Windows.Forms.Button
    Friend WithEvents Cancel_BT As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents FileAddress As System.Windows.Forms.TextBox
    Friend WithEvents Password_TB As System.Windows.Forms.TextBox
    Friend WithEvents Browrse_BT As System.Windows.Forms.Button
    Friend WithEvents Extractor As System.ComponentModel.BackgroundWorker
    Friend WithEvents DeleteFile_CB As System.Windows.Forms.CheckBox
End Class
