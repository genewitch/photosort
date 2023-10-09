Imports System.Threading.Tasks

Module SlideShow
    Public Async Function ChangeDisplayAsync(path As String, imagefile As String, prompt As String(), Optional mode As String = "normal", Optional delaytime As Integer = 2000) As Task
        Dim inputImage As String
        Dim description As String

        If imagefile.Last() = ","c Then
            inputImage = imagefile.TrimEnd(","c)
        Else
            inputImage = imagefile
        End If
        description = String.Join(", ", prompt)

        ' Dispose the previous image if it exists
        If PrimaryWindow.CurDisplay.Image IsNot Nothing Then
            PrimaryWindow.CurDisplay.Image.Dispose()
            PrimaryWindow.CurDisplay.Image = Nothing
        End If

        ' Load and display the new image
        PrimaryWindow.CurDisplay.Image = Image.FromFile(System.IO.Path.Combine(path, inputImage))
        PrimaryWindow.CurDisplay.Refresh()

        ' Clear and update the CSV TextBox
        PrimaryWindow.csvTextbox.Clear()
        PrimaryWindow.csvTextbox.Text = description
        PrimaryWindow.csvTextbox.Refresh()

        If mode = "normal" Then
            ' Introduce a delay without blocking the UI thread
            Await Task.Delay(delaytime)
            ' need to also handle button presses if in this mode
            ' eg if button pressed then 
            ' MoveImageTo(path, inputImage, newDirectory)

        ElseIf mode = "lora" Then
            ' Handle 'lora' mode
            'WriteSingleFileDescription(path, imagefile, description)
        Else
            Stop
        End If
    End Function



    Public Sub MoveImageTo(path As String, imagefile As String, folderName As String)
        ' do stuff
    End Sub
    Private Sub WriteSingleFileDescription(path As String, imagefile As String, prompt As String())
        Dim newFilePath As String = System.IO.Path.Combine(path, imagefile & ".txt")
        Dim description As String = imagefile & "," & String.Join(",", prompt)
        System.IO.File.WriteAllText(newFilePath, description)

    End Sub

End Module
