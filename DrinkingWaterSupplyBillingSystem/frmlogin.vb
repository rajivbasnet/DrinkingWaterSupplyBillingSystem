'***************************************************
'Centre Number: NP717   Candidate Name: Rajiv Basnet
'Form Creation Date: 2014/10/14 
'Purpose of Form: To log into the software
'***************************************************


Imports System.Data.OleDb
Public Class frmlogin
    Private Sub btnlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogin.Click
        DWSCon.connect()
        Dim loginDs As New DataSet
        Dim loginDa As OleDb.OleDbDataAdapter
        Dim loginDisp As String
        loginDisp = "Select * from login where UName='" & txtusername.Text & "' and Password='" & txtpassword.Text & "'"

        'select the usename and password from the table in order to match them

        loginDa = New OleDb.OleDbDataAdapter(loginDisp, DWSCon.cnn)
        loginDs = New DataSet
        loginDa.Fill(loginDs, "login")
        If loginDs.Tables(0).Rows.Count < 1 Then

            'check out the username and password from same row in the dataset of the table

            MessageBox.Show("Incorrect User Name or Password")
            txtusername.Clear()
            txtpassword.Clear()
            txtusername.Focus()
        Else
            frmmain.Show()
            Me.Close()
            txtusername.Clear()
            txtpassword.Clear()
        End If

    End Sub
    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub

    Private Sub frmlogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class