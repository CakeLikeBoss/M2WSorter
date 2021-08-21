Imports System.IO

Public Class CSVManager

    Public colSeq() As String
        Public colCodigo() As String
        Public colQtd() As String
        Public colError() As String
        Public colOperadorName() As String
        Public colOperadorCode() As String
        Public colDate() As String


        Public Function getFileName(path As String) As String
        Return path.Substring(path.LastIndexOf("\") + 1)
    End Function

    Public Function getLineQTD(path As String) As Long
        Dim Lines() As String = File.ReadAllLines(path)
        Return Lines.Length - 1
    End Function

    Public Sub setFileToRead(path As String)
        Dim num_rows As Integer

        Dim strlines() As String
        Dim values() As String
        Dim tmpstream As StreamReader = File.OpenText(path)
        strlines = tmpstream.ReadToEnd().Split(Environment.NewLine)
        num_rows = UBound(strlines)
        ReDim colSeq(num_rows)
        ReDim colCodigo(num_rows)
        ReDim colQtd(num_rows)
        ReDim colError(num_rows)
        ReDim colOperadorName(num_rows)
        ReDim colOperadorCode(num_rows)
        ReDim colDate(num_rows)
        For x = 0 To num_rows
            values = strlines(x).Split(";")
            If (values.Length > 1) Then
                colSeq(x) = values(0).Replace("""", "")
                colCodigo(x) = values(1).Replace("""", "")
                colQtd(x) = ""
                colError(x) = ""
                colOperadorName(x) = ""
                colOperadorCode(x) = ""
                colDate(x) = ""
            End If
        Next

    End Sub

    Public Function searchFileToRead(Key As String, Name As String, Code As String) As Integer
        Dim Index As Integer

        Index = Array.IndexOf(colCodigo, Key.Replace(vbCr, "").Replace(vbLf, ""))

        If Index <> -1 Then
            If colError(Index) = "" Then
                colError(Index) = "AUTOMATICO"
                colOperadorName(Index) = Name
                colOperadorCode(Index) = Code
                colDate(Index) = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
                FormInicio.totalRealizado += 1
            Else
                Index = -2
            End If
        End If

        Return Index
    End Function

    Public Function searchFileToManualRead(Key As String, Name As String, Code As String) As Integer
        Dim Index As Integer
        Index = Array.IndexOf(colCodigo, Key.Replace(vbCr, "").Replace(vbLf, ""))
        If Index <> -1 Then
            If colError(Index) = "" Then
                colError(Index) = "MANUAL"
                colOperadorName(Index) = Name
                colOperadorCode(Index) = Code
                colDate(Index) = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
                FormInicio.totalRealizado += 1
            Else
                Index = -2
            End If
        End If

        Return Index
    End Function



    Public Function searchFileToCopy(values() As String)
        Dim Index As Integer
        If (values(3) <> "PENDENTE") Then
            Index = Array.IndexOf(colCodigo, values(1).Replace(vbCr, "").Replace(vbLf, ""))
            If Index <> -1 Then
                colSeq(Index) = values(0)
                colCodigo(Index) = values(1)
                colQtd(Index) = values(2)
                colError(Index) = values(3)
                colOperadorName(Index) = values(4)
                colOperadorCode(Index) = values(5)
                colDate(Index) = values(6)
                FormInicio.totalRealizado += 1
            End If
        End If

        Return Index
    End Function

    Public Sub finishFileToRead(Name As String, Code As String, path As String)
        Dim Index As Integer
        Dim file As String = path
        Dim out As IO.StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(file, False)
        Dim line As String
        For Index = 0 To colSeq.Length - 1
            If colError(Index) = "" Then
                colError(Index) = "PENDENTE"
                colOperadorName(Index) = Name
                colOperadorCode(Index) = Code
                colDate(Index) = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
            ElseIf colSeq(Index).ToUpper() = "SEQ" Then
                colError(Index) = "Info"
                colOperadorName(Index) = "Name"
                colOperadorCode(Index) = "Code"
                colDate(Index) = "Date"
            End If

            line = colSeq(Index) + ";" + colCodigo(Index) + ";" + colQtd(Index) + ";" + colError(Index) + ";" + colOperadorName(Index) + ";" + colOperadorCode(Index) + ";" + colDate(Index)
            Debug.WriteLine(line)
            out.WriteLine(line)
        Next
        out.Close()
    End Sub



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

    Public Sub verificarOperacaoAnterior(path As String)
        If My.Computer.FileSystem.FileExists(path) Then
            Dim num_rows As Integer
            Dim strlines() As String
            Dim values() As String
            ''MessageBox.Show(path)
            Dim tmpstream As StreamReader = File.OpenText(path)
            strlines = tmpstream.ReadToEnd().Split(Environment.NewLine)
            num_rows = UBound(strlines)
            ''MessageBox.Show(strlines(0))
            For x = 0 To num_rows
                values = strlines(x).Split(";")
                If (values.Length > 1) Then
                    searchFileToCopy(values)
                End If
            Next
            tmpstream.Close()
        End If
    End Sub
    Private Sub consoleDebug(message As String)
            Console.WriteLine("::DEBUG::")
            Console.WriteLine(message)
        End Sub
    End Class
