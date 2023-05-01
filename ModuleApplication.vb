Imports System.IO
Imports System.Resources
Imports System.Text

Module ModuleApplication
    'Public Function HideMainForm()
    '    MainForm.Hide()
    'End Function

    Public Function StringToStream(input As String, enc As Encoding) As Stream
        Dim memoryStream = New MemoryStream()
        Dim streamWriter = New StreamWriter(memoryStream, enc)
        streamWriter.Write(input)
        streamWriter.Flush()
        memoryStream.Position = 0
        Return memoryStream
    End Function

    Public Function isEmpty(content As String) As Boolean
        Return content = ""
    End Function

    Public Function WriteTextToFile(path As String, content As String)
        My.Computer.FileSystem.WriteAllText(path, content, False)
    End Function

    Public Function ReadTextFromFile(path As String) As String
        'Dim file As New System.IO.StreamReader(path)
        'Dim words As String = file.ReadToEnd()
        'file.Close()
        'Return words

        Return My.Computer.FileSystem.ReadAllText(path)

    End Function

    Public Function AppendTextToFile(path As String, content As String) As String
        Dim file As New System.IO.StreamWriter(path, True)
        file.WriteLine("Here is another line.")
        file.Close()
    End Function

    Public Function ReadTextLinesFromFile(path As String, content As String) As String
        Dim file As New System.IO.StreamReader(path)
        Dim oneLine As String
        oneLine = file.ReadLine()
        While (oneLine <> "")
            Console.WriteLine(oneLine)
            oneLine = file.ReadLine()
        End While
        file.Close()
    End Function

End Module
