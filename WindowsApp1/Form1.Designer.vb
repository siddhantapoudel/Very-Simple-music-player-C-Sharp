<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.Close = New System.Windows.Forms.Button()
        Me.selectbox = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Tracklist = New System.Windows.Forms.ListBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.NotifyIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlayPauseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NextToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PreviousToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TrackNameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RepeatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RepeatAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SuffleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FolderBrowserDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.SuffleONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OFFToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectTrackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'AxWindowsMediaPlayer1
        '
        Me.AxWindowsMediaPlayer1.Enabled = True
        Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(12, 149)
        Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(259, 46)
        Me.AxWindowsMediaPlayer1.TabIndex = 0
        '
        'Close
        '
        Me.Close.Location = New System.Drawing.Point(13, 227)
        Me.Close.Name = "Close"
        Me.Close.Size = New System.Drawing.Size(258, 23)
        Me.Close.TabIndex = 1
        Me.Close.Text = "Close"
        Me.Close.UseVisualStyleBackColor = True
        '
        'selectbox
        '
        Me.selectbox.Location = New System.Drawing.Point(175, 201)
        Me.selectbox.Name = "selectbox"
        Me.selectbox.Size = New System.Drawing.Size(97, 20)
        Me.selectbox.TabIndex = 2
        Me.selectbox.Text = "Select Folder"
        Me.selectbox.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.AcceptsReturn = True
        Me.TextBox1.Location = New System.Drawing.Point(13, 201)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(154, 20)
        Me.TextBox1.TabIndex = 3
        '
        'Tracklist
        '
        Me.Tracklist.FormattingEnabled = True
        Me.Tracklist.Location = New System.Drawing.Point(13, 22)
        Me.Tracklist.Name = "Tracklist"
        Me.Tracklist.Size = New System.Drawing.Size(257, 121)
        Me.Tracklist.TabIndex = 4
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem, Me.PlayPauseToolStripMenuItem, Me.NextToolStripMenuItem, Me.PreviousToolStripMenuItem, Me.TrackNameToolStripMenuItem, Me.ModeToolStripMenuItem, Me.SuffleONToolStripMenuItem, Me.SelectTrackToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(139, 180)
        '
        'NotifyIcon
        '
        Me.NotifyIcon.ContextMenuStrip = Me.ContextMenuStrip1
        Me.NotifyIcon.Text = "NotifyIcon"
        Me.NotifyIcon.Visible = True
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'PlayPauseToolStripMenuItem
        '
        Me.PlayPauseToolStripMenuItem.Name = "PlayPauseToolStripMenuItem"
        Me.PlayPauseToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.PlayPauseToolStripMenuItem.Text = "Play/Pause"
        '
        'NextToolStripMenuItem
        '
        Me.NextToolStripMenuItem.Name = "NextToolStripMenuItem"
        Me.NextToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.NextToolStripMenuItem.Text = "Next"
        '
        'PreviousToolStripMenuItem
        '
        Me.PreviousToolStripMenuItem.Name = "PreviousToolStripMenuItem"
        Me.PreviousToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.PreviousToolStripMenuItem.Text = "Previous"
        '
        'TrackNameToolStripMenuItem
        '
        Me.TrackNameToolStripMenuItem.Name = "TrackNameToolStripMenuItem"
        Me.TrackNameToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.TrackNameToolStripMenuItem.Text = "Track Name"
        '
        'ModeToolStripMenuItem
        '
        Me.ModeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RepeatToolStripMenuItem, Me.RepeatAllToolStripMenuItem, Me.SuffleToolStripMenuItem})
        Me.ModeToolStripMenuItem.Name = "ModeToolStripMenuItem"
        Me.ModeToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ModeToolStripMenuItem.Text = "Mode"
        '
        'RepeatToolStripMenuItem
        '
        Me.RepeatToolStripMenuItem.Name = "RepeatToolStripMenuItem"
        Me.RepeatToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.RepeatToolStripMenuItem.Text = "Repeat"
        '
        'RepeatAllToolStripMenuItem
        '
        Me.RepeatAllToolStripMenuItem.Name = "RepeatAllToolStripMenuItem"
        Me.RepeatAllToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.RepeatAllToolStripMenuItem.Text = "Repeat All"
        '
        'SuffleToolStripMenuItem
        '
        Me.SuffleToolStripMenuItem.Name = "SuffleToolStripMenuItem"
        Me.SuffleToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SuffleToolStripMenuItem.Text = "Suffle"
        '
        'SuffleONToolStripMenuItem
        '
        Me.SuffleONToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ONToolStripMenuItem, Me.OFFToolStripMenuItem})
        Me.SuffleONToolStripMenuItem.Name = "SuffleONToolStripMenuItem"
        Me.SuffleONToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SuffleONToolStripMenuItem.Text = "Suffle[ON]"
        '
        'ONToolStripMenuItem
        '
        Me.ONToolStripMenuItem.Name = "ONToolStripMenuItem"
        Me.ONToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ONToolStripMenuItem.Text = "ON"
        '
        'OFFToolStripMenuItem
        '
        Me.OFFToolStripMenuItem.Name = "OFFToolStripMenuItem"
        Me.OFFToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.OFFToolStripMenuItem.Text = "OFF"
        '
        'SelectTrackToolStripMenuItem
        '
        Me.SelectTrackToolStripMenuItem.Name = "SelectTrackToolStripMenuItem"
        Me.SelectTrackToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SelectTrackToolStripMenuItem.Text = "Select Track"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(285, 263)
        Me.Controls.Add(Me.Tracklist)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.selectbox)
        Me.Controls.Add(Me.Close)
        Me.Controls.Add(Me.AxWindowsMediaPlayer1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(301, 301)
        Me.MinimumSize = New System.Drawing.Size(301, 301)
        Me.Name = "Form1"
        Me.Text = "Music Player"
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents Close As Button
    Friend WithEvents selectbox As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Tracklist As ListBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents NotifyIcon As NotifyIcon
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PlayPauseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NextToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PreviousToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TrackNameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RepeatToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RepeatAllToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SuffleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FolderBrowserDialog As FolderBrowserDialog
    Friend WithEvents SuffleONToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ONToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OFFToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SelectTrackToolStripMenuItem As ToolStripMenuItem
End Class
