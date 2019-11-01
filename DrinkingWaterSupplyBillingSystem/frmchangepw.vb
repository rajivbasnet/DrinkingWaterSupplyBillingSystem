'***************************************************
'Centre Number: NP717   Candidate Name: Rajiv Basnet
'Form Creation Date: 2015/01/12
'Purpose of Form: To allow the user change his password
'******************************************************


Imports System.Data.OleDb
Public Class frmchangepw
    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub

    Private Sub btndone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndone.Click
        DWSCon.connect()
        If txtnewpw.Text = "" Or txtusername.Text = "" Or txtnewpwretype.Text = "" Or txtoldpw.Text = "" Then
            MessageBox.Show(" Please Fill Up The Required Information ")
        Else

            Try
                Dim strupdate As String
                Dim cmdupdate As New OleDbCommand
                strupdate = "Update login SET login.Password = '" & txtnewpw.Text & "' WHERE UName= '" & txtusername.Text & "' "

                'Update the password in the table

                cmdupdate = New OleDbCommand(strupdate, DWSCon.cnn)
                cmdupdate.ExecuteNonQuery()
                MessageBox.Show("Password Changed Successfully", "Drinking Water Supply Billing System")
                frmmain.Show()
                Me.Close()
            Catch ex As Exception
                MessageBox.Show("Invalid Username Or Password", "Drinking Water Supply Billing System")
                txtusername.Clear()
                txtnewpw.Clear()
                txtnewpwretype.Clear()
                txtusername.Focus()
            End Try
        End If
    End Sub

    Private Sub txtnewpwretype_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnewpwretype.Leave
        Try
            If txtnewpw.Text.Trim() <> txtnewpwretype.Text.Trim() Then
                MessageBox.Show("Both Passoword Must be Matched", "Drinking Water Supply Billing System")
                txtnewpwretype.Clear()
                txtnewpw.Clear()
                txtnewpw.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show("Password Not Matched", "Drinking Water Supply Billing System")
        End Try
    End Sub

    Private Sub txtoldpw_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtoldpw.Leave

        'Check whether old username and old password matched or not

        DWSCon.connect()
        Dim loginDs As New DataSet
        Dim loginDa As OleDb.OleDbDataAdapter
        Dim loginDisp As String
        loginDisp = "Select * from login where UName='" & txtusername.Text & "' and Password='" & txtoldpw.Text & "'"
        loginDa = New OleDb.OleDbDataAdapter(loginDisp, DWSCon.cnn)
        loginDs = New DataSet
        loginDa.Fill(loginDs, "login")
        If loginDs.Tables(0).Rows.Count < 1 Then
            MessageBox.Show("Incorrect User Name or Password", "Drinking Water Supply Billing System")
            txtoldpw.Clear()
            txtusername.Clear()
            txtusername.Focus()
        End If

    End Sub

    Private Sub frmchangepw_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtusername.Focus()
    End Sub
End Class