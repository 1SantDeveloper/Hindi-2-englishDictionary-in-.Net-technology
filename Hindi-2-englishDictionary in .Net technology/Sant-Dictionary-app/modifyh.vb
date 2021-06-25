Imports System.Drawing.Text

Public Class modifyh

    Private Sub modifyh_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TempDataSet.Hindi' table. You can move, or remove it, as needed.
        Me.HindiTableAdapter.Fill(Me.TempDataSet.Hindi)
        Try
            Dim pfc As PrivateFontCollection = New PrivateFontCollection
            'pfc.AddFontFile("HINN.TTF")
            pfc.AddFontFile("Fonts\K010.TTF")
            'TextBox9.Font = New Font(pfc.Families(0), 16, FontStyle.Regular)
            TextBox2.Font = New Font(pfc.Families(0), 18, FontStyle.Bold)
            TextBox3.Font = New Font(pfc.Families(0), 18, FontStyle.Bold)

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Validate()
            '   HindiBindingSource.EndEdit()
            HindiTableAdapter.Update(tempDataSet.Hindi)
            MsgBox("New word added successfully to search this new word restart is required. ", vbOKOnly, "Sant-H2E-Dictionary-app")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Validate()
            '   HindiBindingSource.EndEdit()
            HindiTableAdapter.Update(TempDataSet.Hindi)
            MsgBox("New word added successfully to search this new word restart is required. ", vbOKOnly, "Sant-H2E-Dictionary-app")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class