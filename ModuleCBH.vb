Imports System.Net
Imports WebDav

Module ModuleCBH

    Public WebDAV_URL As String
    Public WebDAV_User As String
    Public WebDAV_Password As String
    Public DES_Key As String
    Public Settings_AllowEmptyKey As Boolean

    Private WebDAVObject As IWebDavClient

    Public Function Init()

        'MainForm.Hide()
        Dim Params As WebDavClientParams = New WebDavClientParams
        With Params
            .Credentials = New NetworkCredential(WebDAV_User, WebDAV_Password)

        End With

        WebDAVObject = New WebDavClient(Params)

    End Function


    Public Function WebDAVGetRequest(method As String) As HttpWebRequest


    End Function

    Public Function WebDAV_Dispose()
        Try
            WebDAVObject.Dispose()
            WebDAVObject = Nothing
        Catch ex As Exception

        End Try

    End Function

    Public Function CBH_Ping() As Boolean
        'MainForm.Hide()
        Try
            Init()
            Dim Result As Boolean = WebDAVObject.Propfind(WebDAV_URL).Result.IsSuccessful
            WebDAV_Dispose()
            Return Result
        Catch ex As Exception
            Return False
        End Try


    End Function

    ' https://www.codeproject.com/articles/36444/how-to-upload-a-file-to-a-webdav-server-in-vb-net
    ' https://www.codeproject.com/Articles/36261/How-to-Download-a-File-from-a-WebDAV-Server-in-VB

    'https://github.com/skazantsev/WebDavClient
    Public Function CBH_Get() As String

        Init()

        Dim stream As IO.Stream = WebDAVObject.GetRawFile(WebDAV_URL).Result.Stream
        Dim streamreader As IO.StreamReader = New IO.StreamReader(stream)
        Dim Result As String = streamreader.ReadToEnd

        WebDAV_Dispose()
        Return Result
    End Function

    Public Function CBH_Put(Content As String) As Boolean
        Init()

        Dim Result As Boolean = WebDAVObject.PutFile(WebDAV_URL, StringToStream(Content, System.Text.Encoding.Default)).Result.IsSuccessful

        WebDAV_Dispose()
        Return Result
    End Function

End Module
