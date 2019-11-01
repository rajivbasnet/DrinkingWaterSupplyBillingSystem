'***************************************************
'Centre Number: NP717   Candidate Name: Rajiv Basnet
'Connection Establishment Date: 2014/10/14
'Purpose: To connect the program with the database
'**************************************************


Imports System.Data.OleDb
Public Class DWSCon
    Public Shared cnn As New OleDb.OleDbConnection
    Public Shared Sub connect()
        Try
            cnn = New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\DWS.accdb")
            cnn.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message())
        End Try


    End Sub
End Class
