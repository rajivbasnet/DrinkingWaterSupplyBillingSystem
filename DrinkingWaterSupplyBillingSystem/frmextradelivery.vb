'***************************************************
'Centre Number: NP717   Candidate Name: Rajiv Basnet
'Form Creation Date: 2014/10/17 
'Purpose of Form: To input the extradelivery payment record into the software and store it
'*****************************************************************************************


Imports System.Data.OleDb
Public Class frmextradelivery

    Private Sub btnnext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnext.Click
        DWSCon.connect()
        If txtjarrate.Text = "" Or txtnoofjars.Text = "" Then
            MessageBox.Show(" Please Fill Up The Required Information", "Drinking Water Supply Billing System")
        Else
            txttotalextracharge.Text = txtnoofjars.Text * txtjarrate.Text
            Try
                Dim strupdateextra As String
                Dim cmdupdateextra As New OleDbCommand
                strupdateextra = " Update extradeliverycharge set Rateofjar= " & txtjarrate.Text & ",Noofjar= " & txtnoofjars.Text & ",TotalEC= " & txttotalextracharge.Text & " where Regnum= " & txtinputregno.Text & ""

                'Update the last Extra Delivery Record

                cmdupdateextra = New OleDbCommand(strupdateextra, DWSCon.cnn)
                cmdupdateextra.ExecuteNonQuery()

                MessageBox.Show("Data Updated In Extra Delivery Charge Record", "Drinking Water Supply Billing System")

                frmdelaycharge.txtinputregno.Text = Me.txtinputregno.Text
                frmtotals.txttotalextracharge.Text = Me.txttotalextracharge.Text
                frmdelaycharge.Show()

            Catch ex As Exception
                MessageBox.Show("Invalid Data", "Drinking Water Supply Billing System")
                txtjarrate.Clear()
                txtnoofjars.Clear()
                txttotalextracharge.Clear()
            End Try
        End If
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
        frmproducebill.Close()
    End Sub

    Private Sub btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear.Click
        txtjarrate.Clear()
        txtnoofjars.Clear()
        txttotalextracharge.Clear()
        txtjarrate.Focus()
    End Sub

    Private Sub btncalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncalculate.Click
        Try
            txttotalextracharge.Text = CInt(txtnoofjars.Text) * CInt(txtjarrate.Text)
        Catch ex As Exception
            MessageBox.Show("Invalid Data", "Drinking Water Supply Billing System")
        End Try

    End Sub

    Private Sub frmextradelivery_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtinputregno.ReadOnly = True
    End Sub
End Class