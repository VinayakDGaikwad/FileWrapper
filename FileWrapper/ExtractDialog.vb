Imports System.IO
Imports System.Security.Cryptography
Imports Ionic.Zip
Imports System.Threading.Tasks
Imports Ionic

Public Class ExtractDialog

    Dim strFileToEncrypt As String
    Dim foldertozip As String
    Dim zipfileaddress As String
    Dim strTempFile As String
    Dim strInputFile As String
    Dim fsInput As System.IO.FileStream
    Dim fsOutput As System.IO.FileStream
    Dim LastSyn As TimeSpan = New TimeSpan(Date.Now.Hour, Date.Now.Minute, Date.Now.Second)
    Dim FileName As String
    Dim Password As String
    Dim bytKey As Array
    Dim bytIV As Array
    Dim NoofFiles As Integer
    Dim NoofFilesProceed As Integer


    Private Sub Browrse_BT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Browrse_BT.Click
        Dim OpenFile As New OpenFileDialog()
        Try
            With OpenFile
                .FileName = ""
                .Title = "Select Wrapped File"
                .Filter = "Wrapped Folder|*.wppfolder|Wrapped File|*.wppfile"
                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    FileAddress.Text = .FileName
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message(), MsgBoxStyle.Critical, "Error...")
        End Try
    End Sub

    Private Sub Cancel_BT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_BT.Click
        Me.Close()
    End Sub

    Private Sub Exctract_BT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Exctract_BT.Click
        If Password_TB.Text.Length > 0 _
                   And (IO.File.Exists(FileAddress.Text)) Then

            Dim FileInfo As FileInfo = New System.IO.FileInfo(FileAddress.Text)
            If Path.GetExtension(FileAddress.Text) = ".wppfolder" Then
                'Folder
                Me.Hide()
                Status.Show()
                Status.Heading_Label.Text = "UnWrapping File: " + Path.GetFileNameWithoutExtension(FileAddress.Text)
                Status.Status_Label.Text = "Status: Preparing"
                Status.WppingF_Label.Text = "UnWrapping File: " + FileAddress.Text
                Status.WppedF_Label.Text = "UnWrapped File: " + Path.GetFileNameWithoutExtension(FileAddress.Text)
                Status.BufferSize_Label.Text = "Buffer Size: " + My.Settings.BufferSize.ToString + " Bytes"
                Status.FileSize_Label.Text = "File size: " + CStr(CInt((FileInfo.Length) \ 1024 \ 1024)) & " MB"

                strInputFile = FileAddress.Text
                strTempFile = Path.GetDirectoryName(FileAddress.Text) + Path.GetFileNameWithoutExtension(FileAddress.Text) + ".temp"
                Password = Password_TB.Text

                bytKey = FW_Module.CreateKey(Password)
                bytIV = FW_Module.CreateIV(Password)

                Extractor.RunWorkerAsync()

            ElseIf Path.GetExtension(FileAddress.Text) = ".wppfile" Then
                'File
                Me.Hide()
                Status.Show()
                Status.Heading_Label.Text = "UnWrapping File: " + Path.GetFileNameWithoutExtension(FileAddress.Text)
                Status.Status_Label.Text = "Status: Preparing"
                Status.WppingF_Label.Text = "UnWrapping File: " + FileAddress.Text
                Status.WppedF_Label.Text = "UnWrapped File: " + Path.GetFileNameWithoutExtension(FileAddress.Text)
                Status.BufferSize_Label.Text = "Buffer Size: " + My.Settings.BufferSize.ToString + " Bytes"
                Status.FileSize_Label.Text = "File size: " + CStr(CInt((FileInfo.Length) \ 1024 \ 1024)) & " MB"

                strInputFile = FileAddress.Text
                strTempFile = Path.GetDirectoryName(FileAddress.Text) + Path.GetFileNameWithoutExtension(FileAddress.Text)
                Password = Password_TB.Text

                bytKey = FW_Module.CreateKey(Password)
                bytIV = FW_Module.CreateIV(Password)

                Extractor.RunWorkerAsync()

            Else
                MsgBox("Ensure that the selected file is a Wapped File and wheater it exists.", MsgBoxStyle.Critical)
            End If
        Else
            Return
        End If
    End Sub

    Private Sub Extractor_ProgressChanged(ByVal sender As System.Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles Extractor.ProgressChanged
        Status.ProgressBar1.Value = CInt(e.ProgressPercentage)
        Status.Percent_Label.Text = CStr(CInt(e.ProgressPercentage)) + "%"
        Status.WppingF_Label.Text = e.UserState
    End Sub

    Private Sub Extractor_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles Extractor.DoWork
        Try 'In case of errors.

            'Setup file streams to handle input and output.
            fsInput = New System.IO.FileStream(strInputFile, FileMode.Open, _
                                               FileAccess.Read)
            fsOutput = New System.IO.FileStream(strTempFile, FileMode.OpenOrCreate, _
                                                FileAccess.Write)
            fsOutput.SetLength(0) 'make sure fsOutput is empty

            'Declare variables for encrypt/decrypt process.
            Dim bytBuffer(4096) As Byte 'holds a block of bytes for processing
            Dim lngBytesProcessed As Long = 0 'running count of bytes processed
            Dim lngFileLength As Long = fsInput.Length 'the input file's length
            Dim intBytesInCurrentBlock As Integer 'current bytes being processed
            Dim csCryptoStream As CryptoStream
            'Declare your CryptoServiceProvider.
            Dim cspRijndael As New System.Security.Cryptography.RijndaelManaged

            'Determine if ecryption or decryption and setup CryptoStream.
            csCryptoStream = New CryptoStream(fsOutput, _
                    cspRijndael.CreateDecryptor(bytKey, bytIV), _
                    CryptoStreamMode.Write)


            'Use While to loop until all of the file is processed.
            While lngBytesProcessed < lngFileLength
                'Read file with the input filestream.
                intBytesInCurrentBlock = fsInput.Read(bytBuffer, 0, 4096)
                'Write output file with the cryptostream.
                csCryptoStream.Write(bytBuffer, 0, intBytesInCurrentBlock)
                'Update lngBytesProcessed
                lngBytesProcessed = lngBytesProcessed + CLng(intBytesInCurrentBlock)
                'Update Progress Bar
                Extractor.ReportProgress(CInt((lngBytesProcessed / lngFileLength) * 100), "UnWrapping File:")
            End While

            'Close FileStreams and CryptoStream.
            fsInput.Close()
            fsOutput.Close()

            'If decrypting then delete the encrypted file.
            If DeleteFile_CB.Checked = True Then
                Dim fileEncrypted As New FileInfo(strInputFile)
                fileEncrypted.Delete()
            End If

            If Path.GetExtension(strInputFile) = ".wppfile" Then
                Exit Sub
            End If

            'Only for a folder
            Dim ExtractDir As String = Path.GetDirectoryName(strTempFile) + Path.GetFileNameWithoutExtension(strTempFile)
            Dim Redo As Integer = 1
            Dim MyZipInputStream As ZipInputStream
            MyZipInputStream = New ZipInputStream(New FileStream(strTempFile, FileMode.Open, FileAccess.Read))
            Dim MyFileStream As FileStream
            Dim MyZipEntry As ZipEntry = MyZipInputStream.GetNextEntry
            Dim count As Integer
            Dim buffer(4096) As Byte

            Directory.CreateDirectory(ExtractDir)

            While Not MyZipEntry Is Nothing
                If (MyZipEntry.IsDirectory) Then
                    Directory.CreateDirectory(ExtractDir & "\" & MyZipEntry.FileName)
                Else
                    If Not Directory.Exists(ExtractDir & "\" & _
                    Path.GetDirectoryName(MyZipEntry.FileName)) Then
                        Directory.CreateDirectory(ExtractDir & "\" & _
                        Path.GetDirectoryName(MyZipEntry.FileName))
                    End If
                    MyFileStream = New FileStream(ExtractDir & "\" & MyZipEntry.FileName, FileMode.OpenOrCreate, FileAccess.Write)
                    count = MyZipInputStream.Read(buffer, 0, 4096)

                    While count > 0
                        MyFileStream.Write(buffer, 0, count)
                        count = MyZipInputStream.Read(buffer, 0, 4096)
                        Extractor.ReportProgress(CInt((MyFileStream.Position / MyZipEntry.UncompressedSize) * 100))
                    End While

                    MyFileStream.Close()
                End If
                Try
                    MyZipEntry = MyZipInputStream.GetNextEntry
                    Extractor.ReportProgress(0, MyZipEntry.FileName)
                Catch ex As Exception
                    MyZipEntry = Nothing
                End Try
            End While

            If Not (MyZipInputStream Is Nothing) Then MyZipInputStream.Close()
            If Not (MyFileStream Is Nothing) Then MyFileStream.Close()

            File.Delete(strTempFile)
            MsgBox("Task Complete")

        Catch IOEx As IOException
            MsgBox("There was a error reading the file: " + vbNewLine + vbNewLine + IOEx.Message, MsgBoxStyle.Exclamation, "FileWapper")
            Return
        Catch ex As Exception
            MsgBox("Unexpected error occurred: " + vbNewLine + vbNewLine + ex.Message, MsgBoxStyle.Exclamation, "FileWapper")
            Return
        End Try

    End Sub
End Class