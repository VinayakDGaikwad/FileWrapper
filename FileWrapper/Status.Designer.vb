<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Status
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
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.WppingF_Label = New System.Windows.Forms.Label()
        Me.Percent_Label = New System.Windows.Forms.Label()
        Me.WppedF_Label = New System.Windows.Forms.Label()
        Me.SH_Button = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ElaspedTime_Label = New System.Windows.Forms.Label()
        Me.FileSize_Label = New System.Windows.Forms.Label()
        Me.BufferSize_Label = New System.Windows.Forms.Label()
        Me.Heading_Label = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Status_Label = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(12, 63)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(509, 23)
        Me.ProgressBar1.TabIndex = 0
        '
        'WppingF_Label
        '
        Me.WppingF_Label.AutoSize = True
        Me.WppingF_Label.Location = New System.Drawing.Point(7, 0)
        Me.WppingF_Label.Name = "WppingF_Label"
        Me.WppingF_Label.Size = New System.Drawing.Size(72, 13)
        Me.WppingF_Label.TabIndex = 1
        Me.WppingF_Label.Text = "Wraping File: "
        '
        'Percent_Label
        '
        Me.Percent_Label.AutoSize = True
        Me.Percent_Label.Location = New System.Drawing.Point(489, 47)
        Me.Percent_Label.Name = "Percent_Label"
        Me.Percent_Label.Size = New System.Drawing.Size(30, 13)
        Me.Percent_Label.TabIndex = 2
        Me.Percent_Label.Text = "00 %"
        '
        'WppedF_Label
        '
        Me.WppedF_Label.AutoSize = True
        Me.WppedF_Label.Location = New System.Drawing.Point(7, 23)
        Me.WppedF_Label.Name = "WppedF_Label"
        Me.WppedF_Label.Size = New System.Drawing.Size(73, 13)
        Me.WppedF_Label.TabIndex = 3
        Me.WppedF_Label.Text = "Wrapped File:"
        '
        'SH_Button
        '
        Me.SH_Button.Font = New System.Drawing.Font("Wingdings 3", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.SH_Button.Location = New System.Drawing.Point(493, 92)
        Me.SH_Button.Name = "SH_Button"
        Me.SH_Button.Size = New System.Drawing.Size(28, 23)
        Me.SH_Button.TabIndex = 4
        Me.SH_Button.Text = "q"
        Me.SH_Button.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ElaspedTime_Label)
        Me.Panel1.Controls.Add(Me.FileSize_Label)
        Me.Panel1.Controls.Add(Me.BufferSize_Label)
        Me.Panel1.Controls.Add(Me.WppingF_Label)
        Me.Panel1.Controls.Add(Me.WppedF_Label)
        Me.Panel1.Location = New System.Drawing.Point(4, 121)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(515, 70)
        Me.Panel1.TabIndex = 5
        '
        'ElaspedTime_Label
        '
        Me.ElaspedTime_Label.AutoSize = True
        Me.ElaspedTime_Label.Location = New System.Drawing.Point(354, 46)
        Me.ElaspedTime_Label.Name = "ElaspedTime_Label"
        Me.ElaspedTime_Label.Size = New System.Drawing.Size(79, 13)
        Me.ElaspedTime_Label.TabIndex = 6
        Me.ElaspedTime_Label.Text = "Elaspsed Time:"
        '
        'FileSize_Label
        '
        Me.FileSize_Label.AutoSize = True
        Me.FileSize_Label.Location = New System.Drawing.Point(189, 46)
        Me.FileSize_Label.Name = "FileSize_Label"
        Me.FileSize_Label.Size = New System.Drawing.Size(52, 13)
        Me.FileSize_Label.TabIndex = 5
        Me.FileSize_Label.Text = "File Size :"
        '
        'BufferSize_Label
        '
        Me.BufferSize_Label.AutoSize = True
        Me.BufferSize_Label.Location = New System.Drawing.Point(7, 46)
        Me.BufferSize_Label.Name = "BufferSize_Label"
        Me.BufferSize_Label.Size = New System.Drawing.Size(61, 13)
        Me.BufferSize_Label.TabIndex = 4
        Me.BufferSize_Label.Text = "Buffer Size:"
        '
        'Heading_Label
        '
        Me.Heading_Label.AutoSize = True
        Me.Heading_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Heading_Label.Location = New System.Drawing.Point(9, 9)
        Me.Heading_Label.Name = "Heading_Label"
        Me.Heading_Label.Size = New System.Drawing.Size(322, 29)
        Me.Heading_Label.TabIndex = 6
        Me.Heading_Label.Text = "Wrapping File <SampleFile>"
        '
        'Timer1
        '
        '
        'Status_Label
        '
        Me.Status_Label.AutoSize = True
        Me.Status_Label.Location = New System.Drawing.Point(12, 47)
        Me.Status_Label.Name = "Status_Label"
        Me.Status_Label.Size = New System.Drawing.Size(38, 13)
        Me.Status_Label.TabIndex = 7
        Me.Status_Label.Text = "About "
        '
        'Status
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(525, 121)
        Me.Controls.Add(Me.Status_Label)
        Me.Controls.Add(Me.Heading_Label)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.SH_Button)
        Me.Controls.Add(Me.Percent_Label)
        Me.Controls.Add(Me.ProgressBar1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(531, 219)
        Me.MinimumSize = New System.Drawing.Size(531, 149)
        Me.Name = "Status"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Status"
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents WppingF_Label As System.Windows.Forms.Label
    Friend WithEvents Percent_Label As System.Windows.Forms.Label
    Friend WithEvents WppedF_Label As System.Windows.Forms.Label
    Friend WithEvents SH_Button As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents FileSize_Label As System.Windows.Forms.Label
    Friend WithEvents BufferSize_Label As System.Windows.Forms.Label
    Friend WithEvents Heading_Label As System.Windows.Forms.Label
    Friend WithEvents ElaspedTime_Label As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Status_Label As System.Windows.Forms.Label
End Class
