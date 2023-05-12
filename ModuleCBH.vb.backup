Imports System.Net

Module ModuleCBH

    Public WebDAV_URL As String
    Public WebDAV_User As String
    Public WebDAV_Password As String
    Public DES_Key As String

    Private WebDAV_Request As HttpWebRequest

    Public Function WebDAVGetRequest(method As String) As HttpWebRequest
        Try
            Dim url As String = WebDAV_URL

            Dim request As HttpWebRequest = DirectCast(System.Net.HttpWebRequest.Create(url), HttpWebRequest)
            request.Credentials = New NetworkCredential(WebDAV_User, WebDAV_Password)

            Select Case method
                Case "put"
                    request.Method = WebRequestMethods.Http.Put
                    request.AllowWriteStreamBuffering = True
                Case "get"
                    request.Method = WebRequestMethods.Http.Get
            End Select

            'request.SendChunked = True
            request.Headers.Add("Translate: f")

            Return request

        Catch ex As Exception
            Throw ex
        End Try


    End Function

    Public Function WebDAV_Dispose()
        WebDAV_Request = Nothing
    End Function

    ' https://www.codeproject.com/articles/36444/how-to-upload-a-file-to-a-webdav-server-in-vb-net
    ' https://www.codeproject.com/Articles/36261/How-to-Download-a-File-from-a-WebDAV-Server-in-VB
    Public Function CBH_Get() As String
        'Try
        WebDAV_Request = WebDAVGetRequest("get")

            Dim response As HttpWebResponse = DirectCast(WebDAV_Request.GetResponse(), HttpWebResponse)

            'Create the buffer for storing the bytes read from the server
            Dim byteTransferRate As Integer = 4096 '4096 bytes = 4 KB
            Dim bytes(byteTransferRate - 1) As Byte
            Dim bytesRead As Integer = 0 'Indicates how many bytes were read 
            Dim totalBytesRead As Long = 0 'Indicates how many total bytes were read
            Dim contentLength As Long = 0 'Indicates the length of the file being downloaded

        'Read the content length
        'contentLength = CLng(response.GetResponseHeader("Content-Length"))

        Dim Result As String

            'Get the stream from the server
            Dim s As IO.Stream = response.GetResponseStream()

            Do
                'Read from the stream
                bytesRead = s.Read(bytes, 0, bytes.Length)

                If bytesRead > 0 Then

                    totalBytesRead += bytesRead
                    Result = Result & bytes.ToString
                    'Write to file
                    'fs.Write(bytes, 0, bytesRead)

                End If

            Loop While bytesRead > 0


            'Close streams
            s.Close()
            s.Dispose()
            s = Nothing


            'Close the response
            response.Close()
            response = Nothing

            Return Result

        'Catch ex As Exception
        '    Throw ex
        'End Try
    End Function
End Module
