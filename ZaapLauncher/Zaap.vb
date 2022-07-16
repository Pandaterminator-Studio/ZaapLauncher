Imports System.Net
Imports System.Net.Sockets
Imports System.Text

Public Class Zaap

    Private ip As IPAddress = IPAddress.Parse("127.0.0.1")
    Private port As Integer = 26117
    Public IsLaunch As Boolean = False
    Private LoginSocket As Listening

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = False
        Try
            If Not IsLaunch = True Then
                IsLaunch = True
                LoginSocket = New Listening ' New Socket
                Logger.status("Zaap Server is started.")
            End If

        Catch ex As Exception
            Logger.status(ex.Message & vbCrLf)
        End Try

    End Sub


End Class
