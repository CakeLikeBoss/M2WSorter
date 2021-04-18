Imports System.IO
Imports System.Xml.Serialization

Public Class ConfigurationData

    Private fileName As String
    Private fileLocation As String
    Private filePath As String
    Public fileData As ConfigurationFileLayout

    Public Class ConfigurationFileLayout
        Public Class ConfigurationNode
            Public Class UserNode
                Public name As String
                Public code As String
            End Class
            Public Class ColetaNode
                Public path As String
                Public useLF As Boolean
                Public useCF As Boolean
            End Class
            Public Class SolenoideNode
                Public code As String
                Public useLF As Boolean
                Public useCF As Boolean
            End Class
            Public Class NoReadNode
                Public code As String
                Public useLF As Boolean
                Public useCF As Boolean
            End Class

            Public users() As UserNode
            Public definedUser As UserNode
            Public coleta As ColetaNode
            Public solenoide As SolenoideNode
            Public noread As NoReadNode
            Public porta As String

            Public Sub New()
                Dim user = New UserNode()
                user.name = "TESTE"
                user.code = "TST"
                users = {user}
                definedUser = New UserNode()
                definedUser.name = "TESTE"
                definedUser.code = "TST"
                coleta = New ColetaNode()
                coleta.path = "./"
                coleta.useLF = True
                coleta.useCF = True
                solenoide = New SolenoideNode()
                solenoide.code = "S12"
                solenoide.useLF = True
                solenoide.useCF = True
                noread = New NoReadNode()
                noread.code = "No read"
                noread.useLF = True
                noread.useCF = True
                porta = ""
            End Sub
        End Class

        Public configuration As ConfigurationNode

        Public Sub New()
            configuration = New ConfigurationNode()
        End Sub
    End Class

    Public Sub New()
        fileName = "configurations.xml"
        fileLocation = "./"
        filePath = fileLocation + fileName
        fileData = New ConfigurationFileLayout()
        VerifyFileExistence()
    End Sub

    Private Function VerifyFileExistence() As Boolean
        Dim returnValue As Boolean

        If My.Computer.FileSystem.FileExists(filePath) Then
            LoadConfigurations()
        Else
            DefaultFactorConfiguration()
        End If

        Return returnValue
    End Function

    Public Sub DefaultFactorConfiguration()
        fileData = New ConfigurationFileLayout()
        Dim serializer As New XmlSerializer(GetType(ConfigurationFileLayout))
        Dim writer As New StreamWriter(filePath)
        serializer.Serialize(writer, fileData)
        writer.Close()
    End Sub

    Public Sub SaveConfigurations()
        Dim serializer As New XmlSerializer(GetType(ConfigurationFileLayout))
        Dim writer As New StreamWriter(filePath)
        serializer.Serialize(writer, fileData)
        writer.Close()
    End Sub

    Public Sub LoadConfigurations()
        Dim serializer As New XmlSerializer(GetType(ConfigurationFileLayout))
        Dim reader As New IO.StreamReader(filePath)
        fileData = serializer.Deserialize(reader)
        reader.Close()
        reader.Dispose()
    End Sub

    Private Function VerifyUser(code As String) As Integer
        '######    RETURN    ######
        '-1 NO EXISTS
        'N INDEX OF USER
        Dim i As Integer
        For i = 0 To fileData.configuration.users.Length - 1
            If fileData.configuration.users(i).code = code Then
                Return i
            End If
        Next
        Return -1
    End Function

    Public Function AddUser(code As String, name As String) As Integer
        'Return Index User if exists
        Dim userIndex As Integer
        Dim userslength As Integer
        Dim newUser As ConfigurationFileLayout.ConfigurationNode.UserNode
        newUser = New ConfigurationFileLayout.ConfigurationNode.UserNode()
        newUser.name = name
        newUser.code = code

        userIndex = VerifyUser(code)
        If userIndex = -1 Then
            userslength = fileData.configuration.users.Length
            ReDim Preserve fileData.configuration.users(userslength)
            fileData.configuration.users(userslength) = newUser
            SaveConfigurations()
        End If

        Return userIndex
    End Function

    Public Function DelUser(code As String) As Integer
        'Return Index User if exists
        Dim userslength As Integer
        Dim userIndex As Integer
        Dim i As Integer
        Dim j As Integer
        userslength = fileData.configuration.users.Length
        Dim newUsersList(userslength - 2) As ConfigurationFileLayout.ConfigurationNode.UserNode

        userIndex = VerifyUser(code)
        If userIndex <> -1 Then
            j = 0
            For i = 0 To userslength - 1
                If fileData.configuration.users(i).code <> code Then
                    Dim newUser As ConfigurationFileLayout.ConfigurationNode.UserNode
                    newUser = New ConfigurationFileLayout.ConfigurationNode.UserNode()
                    newUser.code = fileData.configuration.users(i).code
                    newUser.name = fileData.configuration.users(i).name
                    newUsersList(j) = newUser
                    j += 1
                End If
            Next
            ReDim Preserve fileData.configuration.users(userslength - 2)
            fileData.configuration.users = newUsersList
            SaveConfigurations()
        End If

        Return userIndex
    End Function

    Public Sub SetColeta(path As String, useLF As Boolean, useCF As Boolean)
        fileData.configuration.coleta.path = path
        fileData.configuration.coleta.useLF = useLF
        fileData.configuration.coleta.useCF = useCF
    End Sub

    Public Sub SetSolenoide(code As String, useLF As Boolean, useCF As Boolean)
        fileData.configuration.solenoide.code = code
        fileData.configuration.solenoide.useLF = useLF
        fileData.configuration.solenoide.useCF = useCF
    End Sub

    Public Sub SetNoRead(code As String, useLF As Boolean, useCF As Boolean)
        fileData.configuration.noread.code = code
        fileData.configuration.noread.useLF = useLF
        fileData.configuration.noread.useCF = useCF
    End Sub

    Public Sub SetDefinedUser(code As String, name As String)
        fileData.configuration.definedUser.code = code
        fileData.configuration.definedUser.name = name
    End Sub

    Public Sub SetPorta(porta As String)
        fileData.configuration.porta = porta
        SaveConfigurations()
    End Sub

End Class
