Module ModuleDES

    Public Function EncryptDes(ByVal SourceStr As String, Optional ByVal myKey As String = "", Optional ByVal myIV As String = "") As String '使用的DES对称加密
        'If String.IsNullOrEmpty(myKey) Then
        '    myKey = Me.JMKey
        'End If
        'If String.IsNullOrEmpty(myIV) Then
        '    myIV = Me.JMIv
        'End If
        Dim des As New System.Security.Cryptography.DESCryptoServiceProvider 'DES算法
        'Dim DES As New System.Security.Cryptography.TripleDESCryptoServiceProvider'TripleDES算法
        Dim inputByteArray As Byte()
        inputByteArray = System.Text.Encoding.Default.GetBytes(SourceStr)
        des.Key = System.Text.Encoding.UTF8.GetBytes(myKey) 'myKey DES用8个字符，TripleDES要24个字符
        des.IV = System.Text.Encoding.UTF8.GetBytes(myIV) 'myIV DES用8个字符，TripleDES要24个字符
        Dim ms As New System.IO.MemoryStream
        Dim cs As New System.Security.Cryptography.CryptoStream(ms, des.CreateEncryptor(), System.Security.Cryptography.CryptoStreamMode.Write)
        Dim sw As New System.IO.StreamWriter(cs)
        sw.Write(SourceStr)
        sw.Flush()
        cs.FlushFinalBlock()
        ms.Flush()
        Return Convert.ToBase64String(ms.GetBuffer(), 0, ms.Length)
    End Function


    Public Function DecryptDes(ByVal SourceStr As String, ByVal myKey As String, ByVal myIV As String) As String    '使用标准DES对称解密
        Dim des As New System.Security.Cryptography.DESCryptoServiceProvider 'DES算法
        'Dim DES As New System.Security.Cryptography.TripleDESCryptoServiceProvider'TripleDES算法
        des.Key = System.Text.Encoding.UTF8.GetBytes(myKey) 'myKey DES用8个字符，TripleDES要24个字符
        des.IV = System.Text.Encoding.UTF8.GetBytes(myIV) 'myIV DES用8个字符，TripleDES要24个字符
        Dim buffer As Byte() = Convert.FromBase64String(SourceStr)
        Dim ms As New System.IO.MemoryStream(buffer)
        Dim cs As New System.Security.Cryptography.CryptoStream(ms, des.CreateDecryptor(), System.Security.Cryptography.CryptoStreamMode.Read)
        Dim sr As New System.IO.StreamReader(cs)
        DecryptDes = sr.ReadToEnd()
    End Function
End Module
