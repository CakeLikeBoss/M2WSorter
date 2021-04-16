Imports System.IO

Public Class CSVManager
    Public Function getFileName(path As String) As String
        Return path.Substring(path.LastIndexOf("\") + 1)
    End Function

    Public Function getLineQTD(path As String) As Long
        Dim Lines() As String = File.ReadAllLines(path)
        Return Lines.Length - 1
    End Function

    Public Function getQTDDuplicatedLines(path As String) As Integer
        Dim num_rows As Integer
        Dim duplicatedNumber As Long
        Dim x, y As Integer
        Dim strarray(1, 1) As String
        Dim strlines() As String
        Dim strlineX() As String
        Dim strlineY() As String
        Dim tmpstream As StreamReader = File.OpenText(path)

        duplicatedNumber = 0
        strlines = tmpstream.ReadToEnd().Split(Environment.NewLine)
        num_rows = UBound(strlines)

        For x = 0 To num_rows
            strlineX = strlines(x).Split(";")
            For y = x + 1 To num_rows
                strlineY = strlines(y).Split(";")
                If strlineX(1) = strlineY(1) Then
                    duplicatedNumber += 1
                    Exit For
                End If
            Next
        Next
        Return duplicatedNumber

    End Function

    Private Sub consoleDebug(message As String)
        Console.WriteLine("::DEBUG::")
        Console.WriteLine(message)
    End Sub
End Class
