Module ZaapParsers
    Public Sub ParseData(ByVal data As String, ByVal MySock As BazSocket)
        Dim subdata() As String = data.Split(" ")
        'Select Case subdata(0)
        '    Case "connect"
        '        Select Case subdata(1)
        '            Case "retro"
        '                Select Case subdata(2)
        '                    Case "main"
        '                        Try
        '                            Logger.Status("Sending data to client")
        '                            MySock.Send("connected")
        '                            Logger.Packet("==>> connected send to dofus client")
        '                            MySock.Send("connect XXX")
        '                            Logger.Packet("==>> conect XXX send to dofus client")
        '                            Logger.Status("Data send")
        '                        Catch ex As Exception
        '                            Logger.Err(ex.Message)
        '                        End Try

        '                    Case Else
        '                        Logger.unPacket(subdata(2))
        '                End Select
        '            Case Else
        '                Logger.unPacket(subdata(1))
        '        End Select
        '    Case Else
        '        Logger.unPacket(subdata(0))
        'End Select
    End Sub
End Module
