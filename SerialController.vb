Imports System
Imports System.IO.Ports
Public Class SerialController

    Dim MyCOMPort As SerialPort

    Function ListSerialPorts() As String()
        Dim AvailablePorts() As String = SerialPort.GetPortNames()

        Debug.WriteLine("Available Ports ::")

        Dim Port As String

        For Each Port In AvailablePorts
            Debug.WriteLine(Port)
        Next Port

        Return AvailablePorts
    End Function

    Sub ConfigSerialPort(porta As String)
        MyCOMPort = New SerialPort()

        MyCOMPort.PortName = porta
        MyCOMPort.BaudRate = 9600
        MyCOMPort.Parity = Parity.None
        MyCOMPort.DataBits = 8
        MyCOMPort.StopBits = StopBits.One
        MyCOMPort.ReadTimeout = 5000
        MyCOMPort.WriteTimeout = 5000
    End Sub

    Sub SendSerialData(texto As String)
        MyCOMPort.Open()
        MyCOMPort.Write(texto & vbCrLf)
        MyCOMPort.Close()
    End Sub

    Function ReceiveSerialData() As String
        Dim DataReceived As String

        MyCOMPort.Open()
        DataReceived = MyCOMPort.ReadLine()
        MyCOMPort.Close()

        Return DataReceived
    End Function

    Sub CloseConnection()
        MyCOMPort.Close()
    End Sub

End Class
