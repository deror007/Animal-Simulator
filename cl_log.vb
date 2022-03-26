Imports System.IO
Public Class cl_log
    Dim wfile As StreamWriter
    Public Sub New()
        wfile = New StreamWriter("LogFile.txt", False)
        wfile.Close()


    End Sub

    Public Sub write(ByVal text As String)
        wfile = New StreamWriter("LogFile.txt", True)
        wfile.WriteLine(text)
        wfile.Close()

    End Sub

    
End Class
