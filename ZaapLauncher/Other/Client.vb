Imports System.IO
Public Class Client
    Public WithEvents MySock As BazSocket
    Public IP As String

    Private Sub GameClient_Close(ByVal sender As Object, ByVal e As System.EventArgs) Handles MySock.Closed
        Dim Delete As New Client
        For Each DeletedClient As Client In Utils.List.ListOfClient
            If DeletedClient.IP = IP Then
                Delete = DeletedClient
            End If
        Next
        Utils.List.ListOfClient.Remove(Delete)
        Logger.status("Client " + Delete.IP + " deconnecter")
    End Sub

    Private Sub Client_DataArrival(ByVal sender As Object, ByVal data() As Byte) Handles MySock.DataArrival
        Dim packet As String = System.Text.Encoding.Default.GetString(data)
        Logger.Packet(packet)

        SendPacket("ignored")
        ' ZaapParsers.ParseData(packet, MySock)
    End Sub

    Public Sub SendPacket(ByVal Packet As String)
        MySock.Send(Packet)
    End Sub

End Class
