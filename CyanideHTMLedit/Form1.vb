Public Class Form1

    Private Sub ToolStripContainer1_ContentPanel_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged
        WebBrowser1.DocumentText = RichTextBox1.Text
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim OFD As New OpenFileDialog
        With OFD
            .FileName = "*.html"
            .Title = "Open file ..."
            .Filter = "HTML Files (*.html)|*.html"
            .InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                Dim readr As New System.IO.StreamReader(OFD.FileName)
                RichTextBox1.Text = readr.ReadToEnd
                readr.Close()

            End If
        End With
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim SFD As New SaveFileDialog
        With SFD
            .FileName = "*.html"
            .Title = "Open file ..."
            .Filter = "HTML Files (*.html)|*.html"
            .InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                Dim writrr As New System.IO.StreamWriter(SFD.FileName)
                writrr.Write(RichTextBox1.Text)
                writrr.Close()
                MsgBox("Saved")
            End If
        End With
    End Sub
End Class
