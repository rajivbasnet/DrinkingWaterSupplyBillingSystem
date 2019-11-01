'***************************************************
'Centre Number: NP717   Candidate Name: Rajiv Basnet
'Form Creation Date: 2014/10/28 
'Purpose of Form: To calculate total payment record into the software
'********************************************************************


Imports System.Data.OleDb
Class frmtotals

    Private Function GetPreviousBalance(ByVal sregno As String) As Decimal

        'Get the value of previous balance and show it in the textbox

        Dim strseebal As String
        Dim cmdseebal As New OleDbCommand
        strseebal = "SELECT Balance FROM billingrecord where Regnum= " & txtinputregno.Text & ""
        cmdseebal = New OleDbCommand(strseebal, DWSCon.cnn)
        Dim cmddatareader As OleDbDataReader
        cmddatareader = cmdseebal.ExecuteReader
        Dim hasrows As Boolean = cmddatareader.Read
        Dim nbal As Decimal = 0
        If hasrows = True Then
            nbal = cmddatareader.Item(0)
        Else
            nbal = 0
        End If
        Return nbal
    End Function

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
        frmproducebill.Close()
        frmextradelivery.Close()
        frmdelaycharge.Close()
    End Sub

    Private Sub btndone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndone.Click
        DWSCon.connect()
        Try
            Dim billformonth As String
            Dim paymentdate As String
            billformonth = frmproducebill.cbobillformonth.Text
            paymentdate = frmproducebill.pickdateofpayment.Text

            Dim strupdatebillinfo As String
            Dim cmdupdatebillinfo As New OleDbCommand
            strupdatebillinfo = " Update billingrecord set Billno=  " & txtbillno.Text & " , Billformonth=  ' " & billformonth & " ', PaymentDate= '" & paymentdate & "', TotalMP= " & txttotalmonthly.Text & ", TotalEC=" & txttotalextracharge.Text & ",TotalDC = " & txttotaldelaycharge.Text & ", PreviousB =" & txtpreviousbalance.Text & ",TotalAmounttoP=" & txttotalamount.Text & ", TotalPaymentM= " & txttotalpaid.Text & ", Balance=" & txtbalance.Text & " where Regnum= " & txtinputregno.Text & ""

            'Update the last Total Billing Record

            cmdupdatebillinfo = New OleDbCommand(strupdatebillinfo, DWSCon.cnn)
            cmdupdatebillinfo.ExecuteNonQuery()

            MessageBox.Show("Data Updated In Billing Record", "Drinking Water Supply Billing System")
            Me.Close()
            frmdelaycharge.Close()
            frmextradelivery.Close()
            frmproducebill.Close()

        Catch ex As Exception
            MessageBox.Show("Invalid Please Update The Records Again", "Drinking Water Supply Billing System")
            Me.Close()
            frmdelaycharge.Close()
            frmextradelivery.Close()
            frmproducebill.txtrate.Clear()
            frmproducebill.txtnoofmonths.Clear()
            frmproducebill.txttotalmonthly.Clear()
            frmproducebill.Show()

        End Try


    End Sub

    Private Sub btncalculatettla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncalculatettla.Click

        Try
            Dim totalm As Integer
            totalm = CInt(txttotalmonthly.Text)
            Dim totalec As Integer
            totalec = CInt(txttotalextracharge.Text)
            Dim totaldc As Integer
            totaldc = CInt(txttotaldelaycharge.Text)
            Dim prebalance As Integer
            prebalance = CInt(txtpreviousbalance.Text)
            txttotalamount.Text = (totalm + totalec + totaldc + prebalance) ' calculation of total amoount to be paid
        Catch ex As Exception
            MessageBox.Show(" Invalid Data", "Drinking Water Supply Billing System")
        End Try

    End Sub

    Private Sub btncalculatebal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncalculatebal.Click

        Try
            Dim totalamount As Integer
            Dim totalpaid As Integer
            totalamount = CInt(txttotalamount.Text)
            totalpaid = CInt(txttotalpaid.Text)
            txtbalance.Text = totalamount - totalpaid 'calculation of balance
        Catch ex As Exception
            MessageBox.Show("Invalid Data", " Drinking Water Supply Billing System")
        End Try

    End Sub

    Private Sub frmtotals_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtpreviousbalance.Text = GetPreviousBalance(txtinputregno.Text)
        txttotalmonthly.ReadOnly = True  'cannot be edited as it can only be readed
        txttotalextracharge.ReadOnly = True
        txttotaldelaycharge.ReadOnly = True
        txtpreviousbalance.ReadOnly = True
        txtinputregno.ReadOnly = True
        txtbillno.ReadOnly = True
        txttotalamount.Focus()
    End Sub
End Class