'***************************************************
'Centre Number: NP717   Candidate Name: Rajiv Basnet
'Form Creation Date: 2014/10/14
'Purpose of Form: To specify the start of the program
'****************************************************


Public Class frmstart
    Private Sub btnstart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnstart.Click
        Dim frmL As New frmlogin
        frmL.Show()
        Me.Hide()
    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        End
    End Sub
End Class
