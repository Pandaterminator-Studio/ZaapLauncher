Public Class Listening
    Public WithEvents LoginSock As BazSocket
    Dim Main As Object

    Sub New()
        LoginSock = New BazSocket(Zaap)
        LoginSock.AlwaysRaiseClose = True
        LoginSock.AsyncEvent = False
        LoginSock.Listen("127.0.0.1", 26117)
    End Sub

    Private Sub LoginSock_Accepted(ByVal sender As System.Object, ByVal Request As AcceptRequest) Handles LoginSock.Accepted
        Dim NewClient As New Client
        Dim AcceptSock As New BazSocket(Zaap, Request)

        Dim NewIP As String = AcceptSock.RemoteEP.Address.ToString
        NewClient.IP = NewIP
        NewClient.MySock = AcceptSock

        AcceptSock.AlwaysRaiseClose = True
        AcceptSock.AsyncEvent = True
        Utils.List.ListOfClient.Add(NewClient)
        Logger.status("Nouveau client sur le zaap " + NewIP)
    End Sub


    Private Sub LoginSock_Listen(ByVal sender As Object, ByVal e As System.EventArgs) Handles LoginSock.Listening
        Logger.Status("Zaap server Launched !")
    End Sub

    Private Sub LoginSock_ListenFailed(ByVal sender As Object, ByVal ex As System.Exception) Handles LoginSock.ListenFailed
        Logger.Status("Failed to listenning at port 26117")
    End Sub
End Class
