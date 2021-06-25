Imports System.Drawing.Text
Public Class Form1

    Private Sub ShowDatabaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowDatabaseToolStripMenuItem.Click
        addmodify.Show()
        addmodify.BringToFront()
    End Sub

    Private Sub DictengBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.DictengBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TempDataSet)

    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        loading.Close()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TempDataSet.Dicteng' table. You can move, or remove it, as needed.

        Try
            Me.DictengTableAdapter.Fill(Me.TempDataSet.Dicteng)
        Catch ex As Exception
            Dim R As Integer
            R = MsgBox("This system does not have database Drivers. Please installing it by clicking ok button And restart the application.", MsgBoxStyle.Information)
            If MsgBoxResult.Ok = R Then
                Try
                    Process.Start("database.exe")
                Catch exx As Exception
                    Exit Sub
                End Try
            End If
        End Try
        '''''
        Try
            Me.DictengTableAdapter.Fill(Me.TempDataSet.Dicteng)

            English_wordListBox.DataSource = DataGridView1.DataSource
            English_wordListBox.DisplayMember = "English_word"
            English_wordListBox.ValueMember = "English_word"
            ComboBox1.DataSource = DataGridView1.DataSource
            ComboBox1.DisplayMember = "English_word"
            ComboBox1.ValueMember = "English_word"
        Catch ex As Exception
            MsgBox("Does not meet the requirements. click Ok to install it offline and restart again.", vbOKOnly, "Sant-E2H-Dictionary-App")
            Process.Start("AccessDatabaseEngine.exe")
            ' loading.Close()
        End Try

        Try
            Dim pfc As PrivateFontCollection = New PrivateFontCollection
            'pfc.AddFontFile("HINN.TTF")
            pfc.AddFontFile("Fonts\K010.TTF")
            'TextBox9.Font = New Font(pfc.Families(0), 16, FontStyle.Regular)
            Hindi_wordTextBox.Font = New Font(pfc.Families(0), 18, FontStyle.Bold)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub OptionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OptionToolStripMenuItem.Click

    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs)
        'Label1.Text = ".....Processing....."
        Form2.Show()
        'Label1.Text = "Welcome To Sant-E2H-Dictionary_App"
        Me.Hide()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        'AboutBox1.Show()
    End Sub

    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem1.Click
        Me.Close()
        services.Close()
        donate.Close()
        aboutdeveloper.Close()
        loading.Close()
        addmodify.Close()

    End Sub

    Private Sub English_wordListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles English_wordListBox.SelectedIndexChanged

    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        MsgBox("Enter your text to search in textbox and press Enter key to search the word . If Meaning is not shown, means that word is not in database. ", vbOKOnly, "Sant-E2H-app")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Try
            DictengBindingSource.AddNew()
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try
    End Sub

    Private Sub HideDatabaseToolStripMenuItem_Click(sender As Object, e As EventArgs)
        modify.Show()
        modify.BringToFront()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

    End Sub

    Private Sub DonateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DonateToolStripMenuItem.Click
        donate.Show()
        donate.BringToFront()

    End Sub

    Private Sub ServicesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ServicesToolStripMenuItem.Click
        services.Show()
        services.BringToFront()
    End Sub

    Private Sub HireMeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HireMeToolStripMenuItem.Click
        aboutdeveloper.Show()
        aboutdeveloper.BringToFront()

    End Sub

    
    Private Sub Hindi_wordTextBox_TextChanged(sender As Object, e As EventArgs) Handles Hindi_wordTextBox.TextChanged

    End Sub
End Class
