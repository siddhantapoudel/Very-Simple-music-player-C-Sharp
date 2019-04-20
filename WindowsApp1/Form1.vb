Public Class Form1

    Dim currentTrack As Integer


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Tracklist.Items.Clear()
        If Not TextBox1.Text = "" Then
            For Each file As String In My.Computer.FileSystem.GetFiles(TextBox1.Text, Microsoft.VisualBasic.FileIO.SearchOption.SearchTopLevelOnly, "*.mp3")
                Tracklist.Items.Add(file)
            Next
        End If

    End Sub

    Private Sub Close_Click(sender As Object, e As EventArgs) Handles Close.Click
        Me.Visible = False

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click

    End Sub

    Private Sub selectbox_Click(sender As Object, e As EventArgs) Handles selectbox.Click
        If FolderBrowserDialog.ShowDialog() = DialogResult.OK Then
            TextBox1.Text = FolderBrowserDialog.SelectedPath.ToString
        End If
    End Sub

    Private Sub NotifyIcon_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon.MouseDoubleClick
        Me.Visible = True
    End Sub

    Private Sub SuffleONToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SuffleONToolStripMenuItem.Click

    End Sub

    Private Sub Tracklist_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Tracklist.SelectedIndexChanged
        AxWindowsMediaPlayer1.URL = Tracklist.SelectedItem.ToString
        currentTrack = Tracklist.SelectedIndex

    End Sub

    Private Sub SelectTrackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectTrackToolStripMenuItem.Click
        Me.Visible = True
    End Sub
End Class
