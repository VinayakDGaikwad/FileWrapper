Imports System.IO
Imports System.Threading
Imports System.Threading.Tasks.Task
Imports System.Security.Cryptography
Imports System.Threading.Tasks
Imports System.IO.Compression
Imports Ionic.Zip

Public Class WrapFile

    Dim strFileToEncrypt As String
    Dim foldertozip As String
    Dim zipfileaddress As String
    Dim strFileToDecrypt As String
    Dim strOutputEncrypt As String
    Dim strOutputDecrypt As String
    Dim fsInput As System.IO.FileStream
    Dim fsOutput As System.IO.FileStream
    Dim MyThread As Thread
    Dim LastSyn As TimeSpan = New TimeSpan(Date.Now.Hour, Date.Now.Minute, Date.Now.Second)
    Dim OutputFile As String
    Dim FileName As String
    Dim Password As String
    Dim bytKey As Array
    Dim bytIV As Array
    Dim NoofFiles As Integer
    Dim NoofFilesProceed As Integer
    Dim Wrap As String = Chr(13) + Chr(10)


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectFolder_BT.Click
        FolderBrowser.Description = ""
        If FolderBrowser.ShowDialog = DialogResult.OK Then
            Try
                Dim Path As String = FolderBrowser.SelectedPath
                FileAddress.Text = Path
                OutputFileName.Text = System.IO.Path.GetDirectoryName(Path) + "\" + IO.Path.GetFileNameWithoutExtension(Path) + ".wppfolder"
            Catch ex As Exception
                MsgBox(ex.Message(), MsgBoxStyle.Critical, "Error...")
            End Try
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectFile_BT.Click
        Dim OpenFile As New OpenFileDialog()
        Try
            With OpenFile
                .FileName = ""
                .Title = "File"
                .Filter = "All Files (*.*)|*.*"
                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    FileAddress.Text = .FileName
                    OutputFileName.Text = System.IO.Path.GetDirectoryName(.FileName) + "\" + .SafeFileName + ".wppfile"
                End If
            End With
        Catch ex As Exception
            MsgBox("Unexpected error occurred:" + vbNewLine + vbNewLine + ex.Message(), MsgBoxStyle.Critical, "FileWrapper")
        End Try
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Wrap_BT.Click
        If Password_TextBox.Text.Length > 0 _
            And Conform_TextBox.Text.Length > 0 _
            And (IO.File.Exists(FileAddress.Text) Or Path.IsPathRooted(FileAddress.Text)) _
            And OutputFileName.Text.Length > 0 Then

            Dim FileAttributes As FileAttribute = System.IO.File.GetAttributes(FileAddress.Text)
            If Not Path.HasExtension(FileAddress.Text) Then
                'For a folder
                foldertozip = FileAddress.Text
                zipfileaddress = OutputFileName.Text + ".temp"
                OutputFile = zipfileaddress.Replace(".temp", Nothing)
                Password = Password_TextBox.Text

                Status.Show()
                Status.Heading_Label.Text = "Wrapping Folder: " + Path.GetFileNameWithoutExtension(FileAddress.Text)
                Status.Status_Label.Text = "Status: Preparing"
                Status.WppingF_Label.Text = "Wrapping Folder: " + foldertozip
                Status.WppedF_Label.Text = "Wrapped File: " + OutputFileName.Text
                Status.BufferSize_Label.Text = "Buffer Size: " + My.Settings.BufferSize.ToString + " Bytes"
                Status.FileSize_Label.Text = "Folder size: " + CStr(CInt(CDbl((FW_Module.GetFolderSize(FileAddress.Text) / 1024 / 1024)))) + " MB"

                bytKey = FW_Module.CreateKey(Password)
                bytIV = FW_Module.CreateIV(Password)

                Dim zipth As Thread = New Thread(AddressOf WrappUp)
                zipth.Start()

            Else
                'For a file
                zipfileaddress = FileAddress.Text
                OutputFile = OutputFileName.Text
                Password = Password_TextBox.Text

                Dim inputfileINfo As New FileInfo(zipfileaddress)

                Status.Show()
                Status.Heading_Label.Text = "Wrapping File: " + Path.GetFileNameWithoutExtension(FileAddress.Text)
                Status.Status_Label.Text = "Status: Preparing"
                Status.WppingF_Label.Text = "Wrapping File: " + foldertozip
                Status.WppedF_Label.Text = "Wrapped File: " + OutputFileName.Text
                Status.BufferSize_Label.Text = "Buffer Size: " + My.Settings.BufferSize.ToString + " Bytes"
                Status.FileSize_Label.Text = "File size: " + CStr(CDbl((inputfileINfo.Length) \ 1024 \ 1024)) & " MB"

                bytKey = FW_Module.CreateKey(Password)
                bytIV = FW_Module.CreateIV(Password)

                BackgroundWorker1.RunWorkerAsync()
            End If
        Else
            Return
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_BT.Click
        Me.Close()
    End Sub

    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Try

            'Setup file streams to handle input and output.
            fsInput = New FileStream(zipfileaddress, FileMode.Open, FileAccess.ReadWrite)
            fsOutput = New System.IO.FileStream(OutputFile, FileMode.OpenOrCreate, FileAccess.Write)
            fsOutput.SetLength(0) 'make sure fsOutput is empty

            'Declare variables for encrypt/decrypt process.
            Dim bytBuffer(4096) As Byte 'holds a block of bytes for processing
            Dim lngBytesProcessed As Long = 0 'running count of bytes processed
            Dim lngFileLength As Long = fsInput.Length 'the input file's length
            Dim intBytesInCurrentBlock As Integer 'current bytes being processed
            Dim csCryptoStream As CryptoStream

            'Declare your CryptoServiceProvider.
            Dim cspRijndael As New System.Security.Cryptography.RijndaelManaged

            'Setup Progress Bar
            Status.ProgressBar1.Value = 0
            Status.ProgressBar1.Maximum = 100

            csCryptoStream = New CryptoStream(fsOutput, _
                     cspRijndael.CreateEncryptor(bytKey, bytIV), _
                     CryptoStreamMode.Write)

            'Use While to loop until all of the file is processed.
            While lngBytesProcessed < lngFileLength
                'Read file with the input filestream.
                intBytesInCurrentBlock = fsInput.Read(bytBuffer, 0, My.Settings.BufferSize)
                'Write output file with the cryptostream.
                csCryptoStream.Write(bytBuffer, 0, intBytesInCurrentBlock)
                'Update lngBytesProcessed
                lngBytesProcessed = lngBytesProcessed + CLng(intBytesInCurrentBlock)
                'Update Progress Bar
                BackgroundWorker1.ReportProgress(CInt((lngBytesProcessed / lngFileLength) * 100))
            End While

            'Flush and Close FileStreams and CryptoStream.
            fsInput.Flush()
            fsOutput.Flush()
            csCryptoStream.Flush()
            csCryptoStream.Close()
            fsInput.Close()
            fsOutput.Close()


            'If encrypting then delete the original unencrypted file.
            If DeletOrginal_CB.Checked = True Then
                Try
                    File.Delete(FileAddress.Text)
                Catch NothingHappend As Exception
                    Directory.Delete(FileAddress.Text)
                End Try
            End If

            Dim tempfile As New FileInfo(zipfileaddress)
            tempfile.Delete()

            'Update the user when the file is done.
            MsgBox("Encryption Complete" + Wrap + Wrap + "Total bytes processed = " + lngBytesProcessed.ToString, _
                    MsgBoxStyle.Information, "Done")

            'Catch file not found error.
        Catch When Err.Number = 53 'if file not found
            MsgBox("Please check to make sure the path and filename" + _
                    "are correct and if the file exists.", _
                     MsgBoxStyle.Exclamation, "Invalid Path or Filename")

        End Try
    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(ByVal sender As System.Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        Status.ProgressBar1.Value = e.ProgressPercentage
        Status.Percent_Label.Text = CStr(e.ProgressPercentage) + " %"
    End Sub

    Public Sub WrappUp()
        Dim zip As ZipFile = New ZipFile
        AddHandler zip.SaveProgress, AddressOf ProgressUpdater

        'Clean if any
        Dim tempfile As New FileInfo(zipfileaddress)
        tempfile.Delete()

        zip.CompressionLevel = Ionic.Zlib.CompressionLevel.BestSpeed
        zip.BufferSize = My.Settings.BufferSize
        zip.AddDirectory(foldertozip)
        zip.Save(zipfileaddress)
       
    End Sub

    Public Sub ProgressUpdater(ByVal sender As Object, ByVal e As SaveProgressEventArgs)
        If InvokeRequired Then
            Me.Invoke(New Action(Of Object, SaveProgressEventArgs)(AddressOf ProgressUpdater), sender, e)
        Else
            If (e.EventType = ZipProgressEventType.Saving_Completed) Then
                BackgroundWorker1.RunWorkerAsync()
                Return
            ElseIf (e.EventType = ZipProgressEventType.Saving_BeforeWriteEntry) Then
                Status.WppingF_Label.Text = e.CurrentEntry.FileName
            ElseIf (e.EventType = ZipProgressEventType.Saving_EntryBytesRead) Then
                Status.Percent_Label.Text = CStr(CInt((e.BytesTransferred / e.TotalBytesToTransfer) * 100)) + "%"
                Status.ProgressBar1.Value = CInt(CInt((e.BytesTransferred / e.TotalBytesToTransfer) * 100))
            End If
        End If
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        SelectOutFileDialog.ShowDialog()
        OutputFileName.Text = SelectOutFileDialog.FileName
    End Sub
End Class
