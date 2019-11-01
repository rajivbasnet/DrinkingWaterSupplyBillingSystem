'***************************************************
'Centre Number: NP717   Candidate Name: Rajiv Basnet
'Form Creation Date: 2014/10/17 
'Purpose of Form: To input required bill information and monthly payment record into the software and store them
'***************************************************************************************************************


Imports System.Data.OleDb
Partial Public Class frmproducebill
    Private Sub btnnext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnext.Click
        DWSCon.connect()
        If txtrate.Text = "" Or txtnoofmonths.Text = "" Or txtbillno.Text = "" Or cbobillformonth.Text = "" Or pickdateofpayment.Text = "" Then
            MessageBox.Show(" Please Fill Up The Required Information ", "Drinking Water Supply Billing System")
        Else
            txttotalmonthly.Text = txtrate.Text * txtnoofmonths.Text
            Try

                Dim strupdatemonth As String
                Dim cmdupdatemonth As New OleDbCommand
                strupdatemonth = " Update monthlybillingrecord set RPPerM= " & txtrate.Text & ",NoofM= " & txtnoofmonths.Text & ",TotalMP= " & txttotalmonthly.Text & " where Regnum= " & txtinputregno.Text & ""

                'Update the last Monthly Payment Record

                cmdupdatemonth = New OleDbCommand(strupdatemonth, DWSCon.cnn)
                cmdupdatemonth.ExecuteNonQuery()

                MessageBox.Show("Data Updated In Monthly Billing Record", "Drinking Water Supply Billing System")

                frmextradelivery.txtinputregno.Text = Me.txtinputregno.Text 'Transfer the value of Regno Table To frmextradelivery
                frmtotals.txttotalmonthly.Text = Me.txttotalmonthly.Text 'Transfer the value of Total Monthly Amount To frmtotals
                frmtotals.txtbillno.Text = Me.txtbillno.Text

                frmextradelivery.Show()
            Catch ex As Exception
                MessageBox.Show("Invalid Data", "Drinking Water Supply Billing System")
                txtrate.Clear()
                txtnoofmonths.Clear()
                txttotalmonthly.Clear()
            End Try
        End If
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear.Click
        txtrate.Clear()
        txtnoofmonths.Clear()
        txttotalmonthly.Clear()
        txtrate.Focus()
    End Sub

    Private Sub btncalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncalculate.Click
        Try
            txttotalmonthly.Text = CInt(txtrate.Text) * CInt(txtnoofmonths.Text)
        Catch ex As Exception
            MessageBox.Show("Invalid Data", "Drinking Water Supply Billing System")
        End Try

    End Sub

    Private Sub txtinputregno_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtinputregno.Leave

        'Check whether the Input Registration number is in the registration record or not

        Try
            Dim strSearch As String = "Select * From registrationrecord Where Regnum=" & txtinputregno.Text & ""
            Dim da As New OleDbDataAdapter(strSearch, DWSCon.cnn)
            Dim ds As New DataSet()
            da.Fill(ds, "Regnum")
            If ds.Tables(0).Rows.Count < 1 Then
                MessageBox.Show("Record Not Available", "Drinking Water Supply Billing System")
                txtinputregno.Clear()
                txtinputregno.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show("Please Check The Entry Of Registration Number", "Drinking Water Supply Billing System")
            txtinputregno.Focus()
        End Try

    End Sub

    Private Sub frmproducebill_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class