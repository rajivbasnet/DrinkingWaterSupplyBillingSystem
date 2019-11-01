'***************************************************
'Centre Number: NP717   Candidate Name: Rajiv Basnet
'Form Creation Date: 2014/10/14
'Purpose of Form: To get access to other input and output designs/forms in the software
'**************************************************************************************


Public Class frmmain
    Private Sub btnregister_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnregister.Click
        frmregister.Show()
    End Sub

    Private Sub btnviewrecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnviewrecord.Click
        frmviewrecords.Show()
    End Sub

    Private Sub btnproducebill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnproducebill.Click
        frmproducebill.Show()
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        frmdelete.Show()
    End Sub

    Private Sub mnuregister_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuregister.Click
        frmregister.Show()

    End Sub

    Private Sub mnuviewrecords_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuviewrecords.Click
        frmviewrecords.Show()
    End Sub

    Private Sub mnuproducebill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuproducebill.Click
        frmproducebill.Show()
    End Sub

    Private Sub mnudelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnudelete.Click
        frmdelete.Show()
    End Sub

    Private Sub mnuexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuexit.Click
        Me.Close()

    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub
    Private Sub ChangeUsernameToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangeUsernameToolStripMenuItem.Click
        frmchangeun.Show()
    End Sub

    Private Sub ChangePasswordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangePasswordToolStripMenuItem.Click
        frmchangepw.Show()
    End Sub

    Private Sub mnuusingapp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuusingapp.Click
        MessageBox.Show(" Please Follow The User Guide", "Drinking Water Supply Billing System")
    End Sub

    Private Sub VersionInfoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VersionInfoToolStripMenuItem.Click
        frmversioninfo.Show()
    End Sub
End Class