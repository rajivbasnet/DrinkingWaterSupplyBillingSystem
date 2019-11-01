'***************************************************
'Centre Number: NP717   Candidate Name: Rajiv Basnet
'Form Creation Date: 2014/11/15
'Purpose of Form: To view the registration record and last billing record
'************************************************************************


Imports System.Data.OleDb
Public Class frmviewrecords

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub

    Private Sub btnsearchreg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsearchreg.Click
        'check whether the record is available in the registrationrecord or not

        DWSCon.connect()
        Try
            Dim strSearch As String = "Select * From registrationrecord Where Regnum=" & txtinputregno.Text & ""
            Dim da As New OleDbDataAdapter(strSearch, DWSCon.cnn)
            Dim ds As New DataSet()
            da.Fill(ds, "Regnum")
            If ds.Tables(0).Rows.Count < 1 Then
                MessageBox.Show("Record Not Available", "Drinking Water Supply Billing System")
                txtinputregno.Focus()
            Else
                DataGridView.DataSource = ds.Tables(0)
                DataGridView.ReadOnly = True
            End If

        Catch ex As Exception
            MessageBox.Show("Please Check The Entry Of Registration Number", "Drinking Water Supply Billing System")
        End Try
    End Sub

    Private Sub btnsearchbill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsearchbill.Click
        'check whether the record is available in the billingrecord or not

        DWSCon.connect()
        Try
            Dim strSearch As String = "Select * From billingrecord Where Regnum=" & txtinputregno.Text & ""
            Dim da As New OleDbDataAdapter(strSearch, DWSCon.cnn)
            Dim ds As New DataSet()
            da.Fill(ds, "Regnum")
            If ds.Tables(0).Rows.Count < 1 Then
                MessageBox.Show("Record Not Available", "Drinking Water Supply Billing System")
                txtinputregno.Focus()
            Else
                DataGridView.DataSource = ds.Tables(0)
                DataGridView.ReadOnly = True
            End If

        Catch ex As Exception
            MessageBox.Show("Please Check The Entry Of Registration Number", "Drinking Water Supply Billing System")
        End Try
    End Sub

    Private Sub btnproducebill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnproducebill.Click
        DWSCon.connect()
        If txtinputregno.Text = "" Then
            MessageBox.Show(" Please Enter The Registration Number ", "Drinking Water Supply Billing System")
        Else
            Dim found As Boolean
            found = False
            Dim strSearch As String = "Select * From registrationrecord Where Regnum=" & txtinputregno.Text & ""
            Dim da As New OleDbDataAdapter(strSearch, DWSCon.cnn)
            Dim ds As New DataSet()
            da.Fill(ds, "Regnum")
            If ds.Tables(0).Rows.Count < 1 Then   'check whether the record is available in the registration record or not
                MessageBox.Show("Record Not Available", "Drinking Water Supply Billing System")
                txtinputregno.Focus()
            Else
                found = True
                frmproducebill.Show()
                frmproducebill.txtinputregno.Text = Me.txtinputregno.Text
            End If
        End If


    End Sub

    Private Sub btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear.Click
        txtinputregno.Clear()
        txtinputregno.Focus()
    End Sub
End Class