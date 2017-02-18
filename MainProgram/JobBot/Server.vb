Imports System.Xml

Public Class Server
    Public serverError As String        'Server errors

    Public serverVersion As String      'Program version must be equal to server version
    Public serverRefreshRate As String  'How long program waits before searching for new jobs
    Public serverCheckIn As String      'Server checking frequency
    Public serverMaxUsers As String     'How many user can be online (Can be used in the future)
    Public serverOnline As String       'How long can program run continuously
    Public servercleanupTime As String  'How long can program be in standby mode before server account is removed
    Public serverCreation As String     'Server time when user was created (Can be used in the future)
    Public serverCheckOut As String     'Server time when user must log out (Can be used in the future)

    ''' <summary>
    ''' Get variables from XML and server errors.
    ''' Chekin and register funktion. 
    ''' User exists = return 3
    ''' Chekin = return 2
    ''' Register = returne 1
    ''' ERROR = returne 0
    ''' Not valid XML Error = returne -1
    ''' XmlReader Error = returne -2
    ''' </summary>
    ''' <param name="URL">XML adress</param>
    ''' <returns></returns>
    Public Function GetServerData(ByVal URL As String) As Double
        Try
            Dim reader As XmlReader = XmlReader.Create(URL)

            serverError = ""

            reader.ReadToFollowing("Task")
            reader.Read()

            Select Case reader.Value
                Case "Checkin"
                    reader.ReadToFollowing("Status")
                    reader.Read()
                    If reader.Value = "UnSuccessful" Then '
                        reader.ReadToFollowing("error")
                        reader.Read()
                        serverError = reader.Value

                        reader.Close()
                        Return 0
                    Else
                        reader.Close()
                        Return 2
                    End If

                Case "Register"
                    reader.ReadToFollowing("Status")
                    reader.Read()

                    Select Case reader.Value
                        Case "UnSuccessful"
                            reader.ReadToFollowing("error")
                            reader.Read()
                            serverError = reader.Value
                            If reader.Value = "User exists." Then
                                reader.Close()
                                Return 3
                            End If
                            reader.Close()
                            Return 0
                        Case "Successful"
                            ReadSettings(reader)
                            reader.Close()
                            Return 1
                        Case "Semi-Successful"
                            ReadSettings(reader)
                            reader.Close()
                            Return 3
                    End Select
                Case Else
                    serverError = "Task not found!"
                    reader.Close()
                    Return -1
            End Select
        Catch ex As Exception
            Return -1
        End Try
    End Function

    ''' <summary>
    ''' Read all settings from server
    ''' </summary>
    ''' <param name="reader">XmlReader</param>
    Private Sub ReadSettings(ByVal reader As XmlReader)
        Try
            reader.ReadToFollowing("Version")
            reader.Read()
            serverVersion = reader.Value
            reader.ReadToFollowing("RefreshRate")
            reader.Read()
            serverRefreshRate = reader.Value
            reader.ReadToFollowing("CheckIn")
            reader.Read()
            serverCheckIn = reader.Value
            reader.ReadToFollowing("MaxUsers")
            reader.Read()
            serverMaxUsers = reader.Value
            reader.ReadToFollowing("Online")
            reader.Read()
            serverOnline = reader.Value
            reader.ReadToFollowing("cleanupTime")
            reader.Read()
            servercleanupTime = reader.Value
            reader.ReadToFollowing("Creation")
            reader.Read()
            serverCreation = reader.Value
            reader.ReadToFollowing("CheckOut")
            reader.Read()
            serverCheckOut = reader.Value
        Catch ex As Exception

        End Try
    End Sub

    ''' <summary>
    ''' Exit from server. Remove user data from server.
    ''' </summary>
    ''' <param name="userID">Registerd user ID</param>
    Public Sub ExitServer(ByVal userID As String)
        Try
            Dim reader As XmlReader = XmlReader.Create("http://ouroborosrg.16mb.com/Exit.php?user=" + userID)
        Catch ex As Exception

        End Try
    End Sub
End Class
