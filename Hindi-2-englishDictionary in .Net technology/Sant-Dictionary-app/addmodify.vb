Imports System.Data.OleDb
Imports System.Drawing.Text

Public Class addmodify

    Private Sub addmodify_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TempDataSet.Dicteng' table. You can move, or remove it, as needed.


        'Me.DictengTableAdapter.Fill(Me.TempDataSet.Dicteng)
        Me.Text = "ADD New Word"
        Try
            DictengBindingSource.AddNew()
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try
        Try
            Dim pfc As PrivateFontCollection = New PrivateFontCollection
            'pfc.AddFontFile("HINN.TTF")
            pfc.AddFontFile("Fonts\K010.TTF")
            'TextBox9.Font = New Font(pfc.Families(0), 16, FontStyle.Regular)
            TextBox2.Font = New Font(pfc.Families(0), 16, FontStyle.Bold)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Validate()
            DictengBindingSource.EndEdit()
            DictengTableAdapter.Update(TempDataSet.Dicteng)
            MsgBox("New word added successfully to search this new word restart is required. ", vbOKOnly, "Sant-E2H-Dictionary-app")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class