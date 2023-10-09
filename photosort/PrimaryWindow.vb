'Imports System.Diagnostics.Eventing
Imports System.IO

Public Class PrimaryWindow
    Private selectedFilePath As String
    Private WithEvents delayTimer As New Timer()
    Private Sub PrimaryWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PlaceButtons()
        StartDisplay()

    End Sub

    Private Sub PlaceButtons()

    End Sub

    Private Sub StartDisplay()

    End Sub

    Private Sub ButtonCSVload_Click(sender As Object, e As EventArgs) Handles ButtonCSVload.Click
        Dim fileDialog = New OpenFileDialog()
        If fileDialog.ShowDialog() = DialogResult.OK Then
            Dim selectedFilePath As String = fileDialog.FileName 'this is the full path eg "c:\users\foo\photos\blah.jpg"
            LoadCSV(selectedFilePath)
        End If
    End Sub

    Private Async Sub LoadCSV(ByVal fp)
        Me.ButtonCSVload.Visible = False
        Dim directory As String
        Dim filename As String
        directory = Path.GetDirectoryName(fp)
        filename = Path.GetFileName(fp)
        Dim rawcsv = New FileStream(fp, FileMode.Open, FileAccess.Read)


        Using reader As New StreamReader(rawcsv)
            Try

                ' Read and discard the header line if needed
                Dim headerLine As String = reader.ReadLine()
                While Not reader.EndOfStream
                    Dim line As String = reader.ReadLine()

                    ' Split the line based on the quote marks
                    Dim quoteSplit As String() = line.Split(""""c)

                    If quoteSplit.Length >= 2 Then
                        Dim ifile As String = quoteSplit(0).Trim()
                        csvTextbox.AppendText("Image: " & ifile)


                        Dim prompt As String = quoteSplit(1).Trim()

                        ' Split the "prompt" part by commas to get individual values
                        Dim promptValues As String() = prompt.Split(",")

                        Await SlideShow.ChangeDisplayAsync(directory, ifile, promptValues)

                    End If
                End While

            Catch ex As Exception

            End Try
        End Using


    End Sub
End Class
