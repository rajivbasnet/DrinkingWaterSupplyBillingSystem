'***************************************************
'Centre Number: NP717   Candidate Name: Rajiv Basnet
'Form Creation Date: 2014/12/15
'Purpose of Form: To delete a customer's all records
'***************************************************


Imports System.Data.OleDb
Public Class frmdelete
    Private Sub frmdelete_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtregnodelete.Focus()
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click

        'Detete the records of the entered registration number from each and every tables in the database

        DWSCon.connect()

        If txtregnodelete.Text = "" Then
            MessageBox.Show(" Please Enter The Registration Number Of The Record You Want To Delete", "Drinking Water Supply Billing System")
        End If
        Try
            Dim strSearch As String = "Select * From registrationrecord Where Regnum=" & txtregnodelete.Text & ""
            Dim da As New OleDbDataAdapter(strSearch, DWSCon.cnn)
            Dim ds As New DataSet()
            da.Fill(ds, "Regnum")
            If ds.Tables(0).Rows.Count < 1 Then
                MessageBox.Show("Record Not Available", "Drinking Water Supply Billing System")
                txtregnodelete.Clear()
                Exit Try
            Else
                Dim strdeletereg As String
                Dim cmddeletereg As New OleDbCommand
                strdeletereg = " Delete from registrationrecord  where Regnum= " & txtregnodelete.Text & ""
                cmddeletereg = New OleDbCommand(strdeletereg, DWSCon.cnn)
                cmddeletereg.ExecuteNonQuery()

                Dim strdeletembr As String
                Dim cmddeletembr As New OleDbCommand
                strdeletembr = " Delete from monthlybillingrecord  where Regnum= " & txtregnodelete.Text & ""
                cmddeletembr = New OleDbCommand(strdeletembr, DWSCon.cnn)
                cmddeletembr.ExecuteNonQuery()

                Dim strdeleteedc As String
                Dim cmddeleteedc As New OleDbCommand
                strdeleteedc = " Delete from extradeliverycharge  where Regnum= " & txtregnodelete.Text & ""
                cmddeleteedc = New OleDbCommand(strdeleteedc, DWSCon.cnn)
                cmddeleteedc.ExecuteNonQuery()

                Dim strdeletedcr As String
                Dim cmddeletedcr As New OleDbCommand
                strdeletedcr = " Delete from delaychargerecord  where Regnum= " & txtregnodelete.Text & ""
                cmddeletedcr = New OleDbCommand(strdeletedcr, DWSCon.cnn)
                cmddeletedcr.ExecuteNonQuery()

                Dim strdeletebillr As String
                Dim cmddeletebillr As New OleDbCommand
                strdeletebillr = " Delete from billingrecord  where Regnum= " & txtregnodelete.Text & ""
                cmddeletebillr = New OleDbCommand(strdeletebillr, DWSCon.cnn)
                cmddeletebillr.ExecuteNonQuery()

                MessageBox.Show(" Record Deleted From All Tables ", "Drinking Water Supply Billing System")
                txtregnodelete.Clear()
                txtregnodelete.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(" Deletion Failed ", "Drinking Water Supply Billing System")
            txtregnodelete.Clear()
            txtregnodelete.Focus()
        End Try
    End Sub

    Private Sub btnproducebill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnproducebill.Click

        ' If the deletion is to be done after producing the bill then

        If txtregnodelete.Text = "" Then
            MessageBox.Show(" Please Enter The Registration Number ", "Drinking Water Supply Billing System")
        Else
            Dim found As Boolean
            found = False
            Dim strSearch As String = "Select * From registrationrecord Where Regnum=" & txtregnodelete.Text & ""
            Dim da As New OleDbDataAdapter(strSearch, DWSCon.cnn)
            Dim ds As New DataSet()
            da.Fill(ds, "Regnum")
            If ds.Tables(0).Rows.Count < 1 Then
                MessageBox.Show("Record Not Available", "Drinking Water Supply Billing System")
                txtregnodelete.Clear()
                txtregnodelete.Focus()
            Else
                found = True
                frmproducebill.Show()
                frmproducebill.txtinputregno.Text = Me.txtregnodelete.Text
            End If
        End If

    End Sub

End Class