'***************************************************
'Centre Number: NP717   Candidate Name: Rajiv Basnet
'Form Creation Date: 2014/10/17 
'Purpose of Form: To input required delay charge record into the software and store it
'*************************************************************************************


Imports System.Data.OleDb
Public Class frmdelaycharge

    Private Sub btnnext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnext.Click
        If txtdelayrate.Text = "" Or txtnoofmonths.Text = "" Then
            MessageBox.Show(" Please Fill Up The Required Information ", "Drinking Water Supply Billing System")
        Else
            txttotaldelaycharge.Text = txtdelayrate.Text * txtnoofmonths.Text
            Try
                Dim strupdatedelay As String
                Dim cmdupdatedelay As New OleDbCommand
                strupdatedelay = " Update delaychargerecord set Delayrate= " & txtdelayrate.Text & ",NoOfMdelay= " & txtnoofmonths.Text & ",TotalDC= " & txttotaldelaycharge.Text & "  where Regnum= " & txtinputregno.Text & ""

                'Update the last Delay Charge Record

                cmdupdatedelay = New OleDbCommand(strupdatedelay, DWSCon.cnn)
                cmdupdatedelay.ExecuteNonQuery()

                MessageBox.Show("Data Updated In Delay Charge Record", "Drinking Water Supply Billing System")

                frmtotals.txtinputregno.Text = Me.txtinputregno.Text
                frmtotals.txttotaldelaycharge.Text = Me.txttotaldelaycharge.Text
                frmtotals.Show()
            Catch ex As Exception
                MessageBox.Show("Invalid Data", "Drinking Water Supply Billing System")
                txtdelayrate.Clear()
                txtnoofmonths.Clear()
                txttotaldelaycharge.Clear()
            End Try
        End If

    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
        frmextradelivery.Close()
        frmproducebill.Close()

    End Sub

    Private Sub btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear.Click
        txtdelayrate.Clear()
        txtnoofmonths.Clear()
        txttotaldelaycharge.Clear()
        txtdelayrate.Focus()
    End Sub

    Private Sub btncalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncalculate.Click
        Try
            txttotaldelaycharge.Text = CInt(txtdelayrate.Text) * CInt(txtnoofmonths.Text)
        Catch ex As Exception
            MessageBox.Show("Invalid Data", "Drinking Water Supply Billing System")
        End Try
    End Sub

    Private Sub frmdelaycharge_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtdelayrate.Focus()
        txtinputregno.ReadOnly = True
    End Sub
End Class