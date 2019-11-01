'***************************************************
'Centre Number: NP717   Candidate Name: Rajiv Basnet
'Form Creation Date: 2015/01/09 
'Purpose of Form: To allow the user change his username
'******************************************************


Imports System.Data.OleDb
Public Class frmchangeun
    Private Sub frmchangeunpw_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtnewun.Focus()
    End Sub

    Private Sub btndone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndone.Click
        ' Update the username

        DWSCon.connect()
        If txtnewun.Text = "" Or txtoldun.Text = "" Or txtpw.Text = "" Then
            MessageBox.Show(" Please Fill Up The Required Information")
        Else
            Try
                Dim strupdate As String
                Dim cmdupdate As New OleDbCommand
                strupdate = "Update login SET login.UName = '" & txtnewun.Text & "' WHERE UName= '" & txtoldun.Text & "' AND Password = '" & txtpw.Text & "'"

                'Update the username in the table

                cmdupdate = New OleDbCommand(strupdate, DWSCon.cnn)
                cmdupdate.ExecuteNonQuery()
                MessageBox.Show("Username Changed Successfully", "Drinking Water Supply Billing System")
                frmmain.Show()
                Me.Close()
            Catch ex As Exception
                MessageBox.Show("Incorrect Old UserName or Password", "Drinking Water Supply Billing System")
                txtoldun.Clear()
                txtnewun.Clear()
                txtpw.Clear()
                txtoldun.Focus()
            End Try
        End If
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub

    Private Sub txtpw_leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpw.Leave
        'Check whether the old username password matched or not

        Dim loginDs As New DataSet
        Dim loginDa As OleDb.OleDbDataAdapter
        Dim loginDisp As String
        loginDisp = "Select * from login where UName='" & txtoldun.Text & "' and Password='" & txtpw.Text & "'"
        loginDa = New OleDb.OleDbDataAdapter(loginDisp, DWSCon.cnn)
        loginDs = New DataSet
        loginDa.Fill(loginDs, "login")
        If loginDs.Tables(0).Rows.Count < 1 Then
            MessageBox.Show("Incorrect Old UserName or Password", "Drinking Water Supply Billing System")
            txtnewun.Clear()
            txtpw.Clear()
            txtoldun.Clear()
            txtoldun.Focus()
        End If
    End Sub
End Class