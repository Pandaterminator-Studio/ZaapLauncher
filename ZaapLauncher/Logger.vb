Module Logger

    Public Sub Status(ByVal message As String)
        Zaap.RichTextBox1.SelectionStart = Zaap.RichTextBox1.Text.Length
        Dim oldcolor = Zaap.RichTextBox1.SelectionColor
        Zaap.RichTextBox1.SelectionColor = Color.Green
        Zaap.RichTextBox1.AppendText("[STATUS]: " & message.ToString & vbCrLf & vbCrLf)
        Zaap.RichTextBox1.SelectionColor = oldcolor
    End Sub

    Public Sub Err(ByVal message As String)
        Zaap.RichTextBox1.SelectionStart = Zaap.RichTextBox1.Text.Length
        Dim oldcolor = Zaap.RichTextBox1.SelectionColor
        Zaap.RichTextBox1.SelectionColor = Color.Red
        Zaap.RichTextBox1.AppendText("[ERROR]: " & message.ToString & vbCrLf & vbCrLf)
        Zaap.RichTextBox1.SelectionColor = oldcolor
    End Sub

    Public Sub Packet(ByVal mess As String)
        Zaap.RichTextBox1.SelectionStart = Zaap.RichTextBox1.Text.Length
        Dim oldcolor = Zaap.RichTextBox1.SelectionColor
        Zaap.RichTextBox1.SelectionColor = Color.Blue
        Zaap.RichTextBox1.AppendText("[PACKET]: " & mess.ToString & vbCrLf & vbCrLf)
        Zaap.RichTextBox1.SelectionColor = oldcolor
    End Sub

    Public Sub unPacket(ByVal message As String)
        Zaap.RichTextBox1.SelectionStart = Zaap.RichTextBox1.Text.Length
        Dim oldcolor = Zaap.RichTextBox1.SelectionColor
        Zaap.RichTextBox1.SelectionColor = Color.Orange
        Zaap.RichTextBox1.AppendText("[UNKOWN PACKET]: " & message.ToString & vbCrLf & vbCrLf)
        Zaap.RichTextBox1.SelectionColor = oldcolor
    End Sub

End Module
