Imports System.Threading
Public Class loading

    Private Sub loading_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
       
    End Sub

    Private Sub loading_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        'Dim r As Integer
        'r = MsgBox("Do you want to Exit ? ", vbYesNo, "Sant-E2H-Dictionary-App")
        'If (r = MsgBoxResult.Yes) Then
        '    e.Cancel = False
        '    '   Me.Close()
        'ElseIf (r = MsgBoxResult.No) Then
        '    e.Cancel = True

        'End If
    End Sub

    Private Sub loading_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        ProgressBar1.Hide()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Value = ProgressBar1.Value
        'Label6.Text = ProgressBar1.Value & " %"
        '  If (ProgressBar1.Value = ProgressBar1.Maximum Or ProgressBar1.Value = 100) Then
        If (ProgressBar1.Value = 0) Then
            Timer1.Enabled = False
            ' Label4.Text = "Loading Completed"
            ' Thread.Sleep(200)
            Form1.Show()
            'Thread.Sleep(200)
            Me.Hide()
        End If
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub
End Class