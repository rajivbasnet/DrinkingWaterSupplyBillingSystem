'***************************************************
'Centre Number: NP717   Candidate Name: Rajiv Basnet
'Form Creation Date: 2014/10/15 
'Purpose of Form: To register a new record
'*****************************************


Imports System.Data.OleDb
Public Class frmregister

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        DWSCon.connect()
        If pickdateregdate.Text = "" Or txtregno.Text = "" Or txthouseno.Text = "" Or
            txtownername.Text = "" Or txtaddress.Text = "" Or txtnationality.Text = "" Or
            txtcontactno.Text = "" Or txtauthorizedby.Text = "" Then
            MessageBox.Show(" Please Fill Up The Form Without Missing Anything ")

        Else
            Try
                Dim strSaverr As String
                Dim cmdSaverr As New OleDbCommand
                strSaverr = "Insert INTO registrationrecord values('" & pickdateregdate.Text & "'," & txtregno.Text & "," &
                    txthouseno.Text & ",'" & txtownername.Text & "','" & txtaddress.Text & "','" & txtnationality.Text & "','" &
                    txtcontactno.Text & "','" & txtauthorizedby.Text & "')"

                'To store the information about registration in the table

                cmdSaverr = New OleDbCommand(strSaverr, DWSCon.cnn)
                cmdSaverr.ExecuteNonQuery()

                Dim strSavembr As String
                Dim cmdSavembr As New OleDbCommand
                strSavembr = "Insert INTO monthlybillingrecord (Regnum) values ( '" & txtregno.Text & "')"

                'To store the registration number in the Monthly Billing Record Table

                cmdSavembr = New OleDbCommand(strSavembr, DWSCon.cnn)
                cmdSavembr.ExecuteNonQuery()

                Dim strSaveedc As String
                Dim cmdSaveedc As New OleDbCommand
                strSaveedc = "Insert INTO extradeliverycharge (Regnum) values ( '" & txtregno.Text & "')"

                'To store the registration number in the Extra Delivery Record Table

                cmdSaveedc = New OleDbCommand(strSaveedc, DWSCon.cnn)
                cmdSaveedc.ExecuteNonQuery()

                Dim strSavedcr As String
                Dim cmdSavedcr As New OleDbCommand
                strSavedcr = "Insert INTO delaychargerecord (Regnum) values ( '" & txtregno.Text & "')"

                'To store the registration number in the Delay Charge Record Table

                cmdSavedcr = New OleDbCommand(strSavedcr, DWSCon.cnn)
                cmdSavedcr.ExecuteNonQuery()

                Dim strSavebillrecord As String
                Dim cmdSavebillrecord As New OleDbCommand
                strSavebillrecord = "Insert INTO billingrecord (Regnum , Balance) values ( '" & txtregno.Text & "' , " & 0 & ")"

                'To store the registration number in the Total Billing Record Table

                cmdSavebillrecord = New OleDbCommand(strSavebillrecord, DWSCon.cnn)
                cmdSavebillrecord.ExecuteNonQuery()

                MessageBox.Show("Record Saved", "Drinking Water Supply Billing System")
                Me.Close()
            Catch ex As Exception
                MessageBox.Show("Cannot Insert Dublicate Data", "Drinking Water Supply Billing System")
                txtaddress.Clear()
                txtauthorizedby.Clear()
                txtcontactno.Clear()
                txthouseno.Clear()
                txtnationality.Clear()
                txtownername.Clear()
                txtregno.Clear()
                txtregno.Focus()
            End Try
        End If

    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub

    Private Sub btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear.Click
        txtaddress.Clear()
        txtauthorizedby.Clear()
        txtcontactno.Clear()
        txthouseno.Clear()
        txtnationality.Clear()
        txtownername.Clear()
        txtregno.Clear()
    End Sub

    Private Sub frmregister_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtregno.Focus()
    End Sub
End Class
