Public Class donate

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label1_MouseEnter(sender As Object, e As EventArgs) Handles Label1.MouseEnter
        Label1.Text = "Thankyou for your support and keep learning and keep growing.Your support is vaulable for SantDeveloper."
    End Sub

    Private Sub Label1_MouseLeave(sender As Object, e As EventArgs) Handles Label1.MouseLeave
        Label1.Text = "We are at initial stage , we need your help to growUp.We need small amount of Donation run SantDeveloper .org . SantDeveloper is not a community just only single computer student."
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("SantDeveloperSite.bat")
    End Sub
End Class