<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmtotals
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lbltotalmonthly = New System.Windows.Forms.Label()
        Me.txttotalmonthly = New System.Windows.Forms.TextBox()
        Me.lbltotalextracharge = New System.Windows.Forms.Label()
        Me.txttotalextracharge = New System.Windows.Forms.TextBox()
        Me.lbltotaldc = New System.Windows.Forms.Label()
        Me.txttotaldelaycharge = New System.Windows.Forms.TextBox()
        Me.lbltotalamount = New System.Windows.Forms.Label()
        Me.txttotalamount = New System.Windows.Forms.TextBox()
        Me.lbltotalpaid = New System.Windows.Forms.Label()
        Me.lblbalance = New System.Windows.Forms.Label()
        Me.txttotalpaid = New System.Windows.Forms.TextBox()
        Me.txtbalance = New System.Windows.Forms.TextBox()
        Me.btndone = New System.Windows.Forms.Button()
        Me.lblpreviousbalance = New System.Windows.Forms.Label()
        Me.txtpreviousbalance = New System.Windows.Forms.TextBox()
        Me.btncalculatettla = New System.Windows.Forms.Button()
        Me.btncalculatebal = New System.Windows.Forms.Button()
        Me.lblinputregno = New System.Windows.Forms.Label()
        Me.txtinputregno = New System.Windows.Forms.TextBox()
        Me.txtbillno = New System.Windows.Forms.TextBox()
        Me.lblbillno = New System.Windows.Forms.Label()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbltotalmonthly
        '
        Me.lbltotalmonthly.AutoSize = True
        Me.lbltotalmonthly.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotalmonthly.Location = New System.Drawing.Point(28, 179)
        Me.lbltotalmonthly.Name = "lbltotalmonthly"
        Me.lbltotalmonthly.Size = New System.Drawing.Size(309, 24)
        Me.lbltotalmonthly.TabIndex = 25
        Me.lbltotalmonthly.Text = "Total Monthly Payment To Be Made"
        '
        'txttotalmonthly
        '
        Me.txttotalmonthly.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttotalmonthly.Location = New System.Drawing.Point(343, 179)
        Me.txttotalmonthly.Name = "txttotalmonthly"
        Me.txttotalmonthly.Size = New System.Drawing.Size(227, 26)
        Me.txttotalmonthly.TabIndex = 30
        '
        'lbltotalextracharge
        '
        Me.lbltotalextracharge.AutoSize = True
        Me.lbltotalextracharge.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotalextracharge.Location = New System.Drawing.Point(28, 220)
        Me.lbltotalextracharge.Name = "lbltotalextracharge"
        Me.lbltotalextracharge.Size = New System.Drawing.Size(238, 24)
        Me.lbltotalextracharge.TabIndex = 34
        Me.lbltotalextracharge.Text = "Total Extra Delivery Charge"
        '
        'txttotalextracharge
        '
        Me.txttotalextracharge.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttotalextracharge.Location = New System.Drawing.Point(343, 220)
        Me.txttotalextracharge.Name = "txttotalextracharge"
        Me.txttotalextracharge.Size = New System.Drawing.Size(227, 26)
        Me.txttotalextracharge.TabIndex = 36
        '
        'lbltotaldc
        '
        Me.lbltotaldc.AutoSize = True
        Me.lbltotaldc.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotaldc.Location = New System.Drawing.Point(28, 263)
        Me.lbltotaldc.Name = "lbltotaldc"
        Me.lbltotaldc.Size = New System.Drawing.Size(170, 24)
        Me.lbltotaldc.TabIndex = 37
        Me.lbltotaldc.Text = "Total Delay Charge"
        '
        'txttotaldelaycharge
        '
        Me.txttotaldelaycharge.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttotaldelaycharge.Location = New System.Drawing.Point(343, 263)
        Me.txttotaldelaycharge.Name = "txttotaldelaycharge"
        Me.txttotaldelaycharge.Size = New System.Drawing.Size(227, 26)
        Me.txttotaldelaycharge.TabIndex = 40
        '
        'lbltotalamount
        '
        Me.lbltotalamount.AutoSize = True
        Me.lbltotalamount.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotalamount.Location = New System.Drawing.Point(28, 340)
        Me.lbltotalamount.Name = "lbltotalamount"
        Me.lbltotalamount.Size = New System.Drawing.Size(220, 24)
        Me.lbltotalamount.TabIndex = 42
        Me.lbltotalamount.Text = "Total Amount To Be Paid"
        '
        'txttotalamount
        '
        Me.txttotalamount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttotalamount.Location = New System.Drawing.Point(343, 340)
        Me.txttotalamount.Name = "txttotalamount"
        Me.txttotalamount.Size = New System.Drawing.Size(139, 26)
        Me.txttotalamount.TabIndex = 43
        '
        'lbltotalpaid
        '
        Me.lbltotalpaid.AutoSize = True
        Me.lbltotalpaid.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotalpaid.Location = New System.Drawing.Point(28, 382)
        Me.lbltotalpaid.Name = "lbltotalpaid"
        Me.lbltotalpaid.Size = New System.Drawing.Size(182, 24)
        Me.lbltotalpaid.TabIndex = 44
        Me.lbltotalpaid.Text = "Total Payment Made"
        '
        'lblbalance
        '
        Me.lblbalance.AutoSize = True
        Me.lblbalance.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbalance.Location = New System.Drawing.Point(28, 420)
        Me.lblbalance.Name = "lblbalance"
        Me.lblbalance.Size = New System.Drawing.Size(78, 24)
        Me.lblbalance.TabIndex = 45
        Me.lblbalance.Text = "Balance"
        '
        'txttotalpaid
        '
        Me.txttotalpaid.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttotalpaid.Location = New System.Drawing.Point(343, 382)
        Me.txttotalpaid.Name = "txttotalpaid"
        Me.txttotalpaid.Size = New System.Drawing.Size(227, 26)
        Me.txttotalpaid.TabIndex = 46
        '
        'txtbalance
        '
        Me.txtbalance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbalance.Location = New System.Drawing.Point(343, 420)
        Me.txtbalance.Name = "txtbalance"
        Me.txtbalance.Size = New System.Drawing.Size(139, 26)
        Me.txtbalance.TabIndex = 47
        '
        'btndone
        '
        Me.btndone.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btndone.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btndone.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndone.Location = New System.Drawing.Point(420, 459)
        Me.btndone.Name = "btndone"
        Me.btndone.Size = New System.Drawing.Size(150, 43)
        Me.btndone.TabIndex = 48
        Me.btndone.Text = "Done"
        Me.btndone.UseVisualStyleBackColor = False
        '
        'lblpreviousbalance
        '
        Me.lblpreviousbalance.AutoSize = True
        Me.lblpreviousbalance.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpreviousbalance.Location = New System.Drawing.Point(28, 302)
        Me.lblpreviousbalance.Name = "lblpreviousbalance"
        Me.lblpreviousbalance.Size = New System.Drawing.Size(161, 24)
        Me.lblpreviousbalance.TabIndex = 49
        Me.lblpreviousbalance.Text = "Previous Balance "
        '
        'txtpreviousbalance
        '
        Me.txtpreviousbalance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpreviousbalance.Location = New System.Drawing.Point(343, 302)
        Me.txtpreviousbalance.Name = "txtpreviousbalance"
        Me.txtpreviousbalance.Size = New System.Drawing.Size(227, 26)
        Me.txtpreviousbalance.TabIndex = 50
        '
        'btncalculatettla
        '
        Me.btncalculatettla.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btncalculatettla.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncalculatettla.Location = New System.Drawing.Point(480, 334)
        Me.btncalculatettla.Name = "btncalculatettla"
        Me.btncalculatettla.Size = New System.Drawing.Size(90, 39)
        Me.btncalculatettla.TabIndex = 52
        Me.btncalculatettla.Text = "Calculate"
        Me.btncalculatettla.UseVisualStyleBackColor = False
        '
        'btncalculatebal
        '
        Me.btncalculatebal.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btncalculatebal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncalculatebal.Location = New System.Drawing.Point(480, 414)
        Me.btncalculatebal.Name = "btncalculatebal"
        Me.btncalculatebal.Size = New System.Drawing.Size(90, 39)
        Me.btncalculatebal.TabIndex = 53
        Me.btncalculatebal.Text = "Calculate"
        Me.btncalculatebal.UseVisualStyleBackColor = False
        '
        'lblinputregno
        '
        Me.lblinputregno.AutoSize = True
        Me.lblinputregno.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblinputregno.Location = New System.Drawing.Point(130, 78)
        Me.lblinputregno.Name = "lblinputregno"
        Me.lblinputregno.Size = New System.Drawing.Size(187, 24)
        Me.lblinputregno.TabIndex = 54
        Me.lblinputregno.Text = "Registration Number "
        '
        'txtinputregno
        '
        Me.txtinputregno.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtinputregno.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtinputregno.Location = New System.Drawing.Point(312, 78)
        Me.txtinputregno.Name = "txtinputregno"
        Me.txtinputregno.Size = New System.Drawing.Size(163, 26)
        Me.txtinputregno.TabIndex = 55
        '
        'txtbillno
        '
        Me.txtbillno.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtbillno.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbillno.Location = New System.Drawing.Point(312, 113)
        Me.txtbillno.Name = "txtbillno"
        Me.txtbillno.Size = New System.Drawing.Size(163, 26)
        Me.txtbillno.TabIndex = 56
        '
        'lblbillno
        '
        Me.lblbillno.AutoSize = True
        Me.lblbillno.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbillno.Location = New System.Drawing.Point(158, 113)
        Me.lblbillno.Name = "lblbillno"
        Me.lblbillno.Size = New System.Drawing.Size(108, 24)
        Me.lblbillno.TabIndex = 57
        Me.lblbillno.Text = "Bill Number"
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.BackColor = System.Drawing.Color.Silver
        Me.lbltotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotal.Location = New System.Drawing.Point(-3, 19)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(614, 25)
        Me.lbltotal.TabIndex = 58
        Me.lbltotal.Text = "Bill Info And Total Amounts As Calculated Are As Follows"
        '
        'frmtotals
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(607, 514)
        Me.Controls.Add(Me.lbltotal)
        Me.Controls.Add(Me.lblbillno)
        Me.Controls.Add(Me.txtbillno)
        Me.Controls.Add(Me.txtinputregno)
        Me.Controls.Add(Me.lblinputregno)
        Me.Controls.Add(Me.btncalculatebal)
        Me.Controls.Add(Me.btncalculatettla)
        Me.Controls.Add(Me.txtpreviousbalance)
        Me.Controls.Add(Me.lblpreviousbalance)
        Me.Controls.Add(Me.btndone)
        Me.Controls.Add(Me.txtbalance)
        Me.Controls.Add(Me.txttotalpaid)
        Me.Controls.Add(Me.lblbalance)
        Me.Controls.Add(Me.lbltotalpaid)
        Me.Controls.Add(Me.txttotalamount)
        Me.Controls.Add(Me.lbltotalamount)
        Me.Controls.Add(Me.txttotaldelaycharge)
        Me.Controls.Add(Me.lbltotaldc)
        Me.Controls.Add(Me.txttotalextracharge)
        Me.Controls.Add(Me.lbltotalextracharge)
        Me.Controls.Add(Me.txttotalmonthly)
        Me.Controls.Add(Me.lbltotalmonthly)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "frmtotals"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Totals"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbltotalmonthly As System.Windows.Forms.Label
    Friend WithEvents txttotalmonthly As System.Windows.Forms.TextBox
    Friend WithEvents lbltotalextracharge As System.Windows.Forms.Label
    Friend WithEvents txttotalextracharge As System.Windows.Forms.TextBox
    Friend WithEvents lbltotaldc As System.Windows.Forms.Label
    Friend WithEvents txttotaldelaycharge As System.Windows.Forms.TextBox
    Friend WithEvents lbltotalamount As System.Windows.Forms.Label
    Friend WithEvents txttotalamount As System.Windows.Forms.TextBox
    Friend WithEvents lbltotalpaid As System.Windows.Forms.Label
    Friend WithEvents lblbalance As System.Windows.Forms.Label
    Friend WithEvents txttotalpaid As System.Windows.Forms.TextBox
    Friend WithEvents txtbalance As System.Windows.Forms.TextBox
    Friend WithEvents btndone As System.Windows.Forms.Button
    Friend WithEvents lblpreviousbalance As System.Windows.Forms.Label
    Friend WithEvents txtpreviousbalance As System.Windows.Forms.TextBox
    Friend WithEvents btncalculatettla As System.Windows.Forms.Button
    Friend WithEvents btncalculatebal As System.Windows.Forms.Button
    Friend WithEvents lblinputregno As System.Windows.Forms.Label
    Friend WithEvents txtinputregno As System.Windows.Forms.TextBox
    Friend WithEvents txtbillno As System.Windows.Forms.TextBox
    Friend WithEvents lblbillno As System.Windows.Forms.Label
    Friend WithEvents lbltotal As System.Windows.Forms.Label
End Class
