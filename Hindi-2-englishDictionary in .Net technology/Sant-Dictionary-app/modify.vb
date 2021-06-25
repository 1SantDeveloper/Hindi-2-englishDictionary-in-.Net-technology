Imports System.Data.OleDb
Imports System.Drawing.Text

Public Class modify

    Private Sub modify_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TempDataSet.Dicteng' table. You can move, or remove it, as needed.
        Me.DictengTableAdapter.Fill(Me.TempDataSet.Dicteng)

        Try
            Dim pfc As PrivateFontCollection = New PrivateFontCollection
            'pfc.AddFontFile("HINN.TTF")
            pfc.AddFontFile("Fonts\K010.TTF")
            'TextBox9.Font = New Font(pfc.Families(0), 16, FontStyle.Regular)
            TextBox2.Font = New Font(pfc.Families(0), 18, FontStyle.Bold)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            'Validate()
            '  DictengBindingSource.EndEdit()
            DictengTableAdapter.Update(TempDataSet.Dicteng)
            MsgBox("Saved successfully to search this updated word restart is required. ", vbOKOnly, "Sant-E2H-Dictionary-app")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            'Validate()
            DictengBindingSource.EndEdit()

            DictengTableAdapter.Update(TempDataSet.Dicteng)
            MsgBox("Update successfully to search this updated word restart is required. ", vbOKOnly, "Sant-E2H-Dictionary-app")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        DictengBindingSource.RemoveFilter()
        Me.Refresh()
        Dim search As String = TextBox3.Text
        DictengBindingSource.Filter = "(English_word LIKE '" & TextBox3.Text & "')"


        If DictengBindingSource.Count <> 0 Then
            With Form1.DataGridView1
                .DataSource = DictengBindingSource
                ' MsgBox("Data Matched :: " & search)

            End With
        Else
            MsgBox("Not find  :: " & search)
            Me.DictengTableAdapter.Fill(Me.TempDataSet.Dicteng)
            Exit Sub

        End If

    End Sub
End Class