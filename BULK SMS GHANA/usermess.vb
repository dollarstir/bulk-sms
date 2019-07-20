Imports System.IO
Imports System.Net
Imports System.Data
Imports System.Web

Public Class usermess

    Private Sub Usermess_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim WebRequest As Net.WebRequest 'object for WebRequest 
        Dim WebResonse As Net.WebResponse 'object for WebResponse
        Dim Server As String = "rslr.connectbind.com"
        Dim Port As String = "8080"
        Dim UserName As String = "txg-purples"
        Dim Password As String = "purples"
        Dim type As Integer = 0
        Dim Message As String = RichTextBox1.Text
        Message = HttpUtility.UrlEncode(Message)



        Dim DLR As Integer = 1
        Dim Source As String = TextBox1.Text
        Dim Destination As String = TextBox2.Text
        Dim WebResponseString As String = ""
        Dim URL As String = "http://" & Server & ":" & Port & "/bulksms/bulksms?username=" & UserName & "&password=" & Password & "&type=" & type & "&dlr=" & DLR & "&destination=" & Destination & "&source=" & Source & "&message=" & Message & ""
        WebRequest = Net.HttpWebRequest.Create(URL) 'Hit URL Link
        WebRequest.Timeout = 25000
        Try
            WebResonse = WebRequest.GetResponse 'Get Response 
            Dim reader As IO.StreamReader = New IO.StreamReader(WebResonse.GetResponseStream)
            'Read Response and store in variable 
            WebResponseString = reader.ReadToEnd()
            WebResonse.Close()
            'Response.Write(WebResponseString) 'Display Response. 
            lblmessage.Text = WebResponseString
        Catch ex As Exception
            WebResponseString = "Request Timeout" 'If any exception occur.
            'Response.Write(WebResponseString)
            lblmessage.Text = WebResponseString
        End Try


    End Sub




    Public Function ConvertToUnicode(ByVal str As String) As String

        Dim ArrayOFBytes() As Byte = System.Text.Encoding.Unicode.GetBytes(str)
        Dim UnicodeString As String = ""
        Dim v As Integer

        For v = 0 To ArrayOFBytes.Length - 1
            If v Mod 2 = 0 Then
                Dim t As Integer = ArrayOFBytes(v)

                ArrayOFBytes(v) = ArrayOFBytes(v + 1)
                ArrayOFBytes(v + 1) = t
            End If
        Next
        For v = 0 To ArrayOFBytes.Length - 1
            Dim c As String = Hex$(ArrayOFBytes(v))
            If c.Length = 1 Then
                c = "0" & c
            End If
            UnicodeString = UnicodeString & c
        Next
        Return UnicodeString


    End Function

End Class
