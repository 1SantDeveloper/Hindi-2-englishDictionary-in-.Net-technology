Imports System.Drawing.Text

Public Class Form2

    Private Sub Form2_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Form1.Close()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TempDataSet.Hindi' table. You can move, or remove it, as needed.
        Me.HindiTableAdapter.Fill(Me.TempDataSet.Hindi)
        Try
            Dim pfc As PrivateFontCollection = New PrivateFontCollection
            'pfc.AddFontFile("HINN.TTF")
            pfc.AddFontFile("Fonts\K010.TTF")
            'TextBox9.Font = New Font(pfc.Families(0), 16, FontStyle.Regular)
            Hindi_wordListBox.Font = New Font(pfc.Families(0), 18, FontStyle.Bold)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub OptionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OptionToolStripMenuItem.Click

    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem1.Click
        Form1.Close()
        Me.Close()
    End Sub

    Private Sub English_wordTextBox_TextChanged(sender As Object, e As EventArgs) Handles English_wordTextBox.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Hindi_wordListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Hindi_wordListBox.SelectedIndexChanged

    End Sub

    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click

    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        ' AboutBox1.Show()
    End Sub

    Private Sub ShowDatabaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowDatabaseToolStripMenuItem.Click
        addh.Show()
        addh.BringToFront()

    End Sub

    Private Sub HideDatabaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HideDatabaseToolStripMenuItem.Click
        modifyh.Show()
        modifyh.BringToFront()

    End Sub

    Private Sub TempDataSetBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles TempDataSetBindingSource.CurrentChanged

    End Sub
End Class