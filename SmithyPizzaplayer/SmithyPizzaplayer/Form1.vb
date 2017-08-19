Imports System.IO

Public Class Form1
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        OpenFileDialog1.Filter = "MP3 files |*.mp3|WAV files|*.wav|M4A Files|*.M4A|MP4 Files|*.mp4|All Files|*.*"
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            HScrollBar1.Enabled = True
            Label1.Enabled = True
        End If
        TextBox1.Text = OpenFileDialog1.FileName
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Enabled = False
        HScrollBar1.Enabled = False

        TextBox1.ReadOnly = True
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If (Path.GetExtension(OpenFileDialog1.FileName).ToLower() <> ".wav") Then
            Label1.Enabled = False
            HScrollBar1.Enabled = False

            Throw New FormatException
        End If
        Return
        'This 
        If (Path.GetExtension(OpenFileDialog1.FileName).ToLower() <> ".mp3") Then



        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        My.Computer.Audio.Play(OpenFileDialog1.FileName,
        AudioPlayMode.Background)
    End Sub
End Class
