<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmproducebill
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
        Me.lblinputregno = New System.Windows.Forms.Label()
        Me.txtinputregno = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblbillno = New System.Windows.Forms.Label()
        Me.lblrate = New System.Windows.Forms.Label()
        Me.lblbillformonth = New System.Windows.Forms.Label()
        Me.lblnoofmonths = New System.Windows.Forms.Label()
        Me.lbltotalmonthly = New System.Windows.Forms.Label()
        Me.lblmonthlypayment = New System.Windows.Forms.Label()
        Me.txtrate = New System.Windows.Forms.TextBox()
        Me.txtnoofmonths = New System.Windows.Forms.TextBox()
        Me.txttotalmonthly = New System.Windows.Forms.TextBox()
        Me.txtbillno = New System.Windows.Forms.TextBox()
        Me.btnnext = New System.Windows.Forms.Button()
        Me.lbldate = New System.Windows.Forms.Label()
        Me.pickdateofpayment = New System.Windows.Forms.DateTimePicker()
        Me.cbobillformonth = New System.Windows.Forms.ComboBox()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.btncalculate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblinputregno
        '
        Me.lblinputregno.AutoSize = True
        Me.lblinputregno.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblinputregno.Location = New System.Drawing.Point(5, 52)
        Me.lblinputregno.Name = "lblinputregno"
        Me.lblinputregno.Size = New System.Drawing.Size(233, 24)
        Me.lblinputregno.TabIndex = 3
        Me.lblinputregno.Text = "Input Registration Number "
        '
        'txtinputregno
        '
        Me.txtinputregno.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtinputregno.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtinputregno.Location = New System.Drawing.Point(301, 52)
        Me.txtinputregno.Name = "txtinputregno"
        Me.txtinputregno.Size = New System.Drawing.Size(258, 26)
        Me.txtinputregno.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Silver
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(201, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 25)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Produce Bill"
        '
        'lblbillno
        '
        Me.lblbillno.AutoSize = True
        Me.lblbillno.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbillno.Location = New System.Drawing.Point(5, 84)
        Me.lblbillno.Name = "lblbillno"
        Me.lblbillno.Size = New System.Drawing.Size(108, 24)
        Me.lblbillno.TabIndex = 19
        Me.lblbillno.Text = "Bill Number"
        '
        'lblrate
        '
        Me.lblrate.AutoSize = True
        Me.lblrate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrate.Location = New System.Drawing.Point(5, 293)
        Me.lblrate.Name = "lblrate"
        Me.lblrate.Size = New System.Drawing.Size(237, 24)
        Me.lblrate.TabIndex = 21
        Me.lblrate.Text = "Rate of Payment per month"
        '
        'lblbillformonth
        '
        Me.lblbillformonth.AutoSize = True
        Me.lblbillformonth.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbillformonth.Location = New System.Drawing.Point(5, 115)
        Me.lblbillformonth.Name = "lblbillformonth"
        Me.lblbillformonth.Size = New System.Drawing.Size(131, 24)
        Me.lblbillformonth.TabIndex = 22
        Me.lblbillformonth.Text = "Bill For Month "
        '
        'lblnoofmonths
        '
        Me.lblnoofmonths.AutoSize = True
        Me.lblnoofmonths.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnoofmonths.Location = New System.Drawing.Point(5, 340)
        Me.lblnoofmonths.Name = "lblnoofmonths"
        Me.lblnoofmonths.Size = New System.Drawing.Size(155, 24)
        Me.lblnoofmonths.TabIndex = 23
        Me.lblnoofmonths.Text = "Numer of months"
        '
        'lbltotalmonthly
        '
        Me.lbltotalmonthly.AutoSize = True
        Me.lbltotalmonthly.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotalmonthly.Location = New System.Drawing.Point(5, 383)
        Me.lbltotalmonthly.Name = "lbltotalmonthly"
        Me.lbltotalmonthly.Size = New System.Drawing.Size(309, 24)
        Me.lbltotalmonthly.TabIndex = 24
        Me.lbltotalmonthly.Text = "Total Monthly Payment To Be Made"
        '
        'lblmonthlypayment
        '
        Me.lblmonthlypayment.AutoSize = True
        Me.lblmonthlypayment.BackColor = System.Drawing.Color.Silver
        Me.lblmonthlypayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmonthlypayment.Location = New System.Drawing.Point(192, 230)
        Me.lblmonthlypayment.Name = "lblmonthlypayment"
        Me.lblmonthlypayment.Size = New System.Drawing.Size(193, 25)
        Me.lblmonthlypayment.TabIndex = 25
        Me.lblmonthlypayment.Text = "Monthly Payment"
        '
        'txtrate
        '
        Me.txtrate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrate.Location = New System.Drawing.Point(320, 293)
        Me.txtrate.Name = "txtrate"
        Me.txtrate.Size = New System.Drawing.Size(238, 26)
        Me.txtrate.TabIndex = 26
        '
        'txtnoofmonths
        '
        Me.txtnoofmonths.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnoofmonths.Location = New System.Drawing.Point(320, 340)
        Me.txtnoofmonths.Name = "txtnoofmonths"
        Me.txtnoofmonths.Size = New System.Drawing.Size(238, 26)
        Me.txtnoofmonths.TabIndex = 28
        '
        'txttotalmonthly
        '
        Me.txttotalmonthly.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttotalmonthly.Location = New System.Drawing.Point(320, 383)
        Me.txttotalmonthly.Name = "txttotalmonthly"
        Me.txttotalmonthly.Size = New System.Drawing.Size(154, 26)
        Me.txttotalmonthly.TabIndex = 29
        '
        'txtbillno
        '
        Me.txtbillno.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbillno.Location = New System.Drawing.Point(301, 84)
        Me.txtbillno.Name = "txtbillno"
        Me.txtbillno.Size = New System.Drawing.Size(258, 26)
        Me.txtbillno.TabIndex = 32
        '
        'btnnext
        '
        Me.btnnext.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnnext.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnnext.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnext.Location = New System.Drawing.Point(433, 421)
        Me.btnnext.Name = "btnnext"
        Me.btnnext.Size = New System.Drawing.Size(127, 48)
        Me.btnnext.TabIndex = 33
        Me.btnnext.Text = "Next"
        Me.btnnext.UseVisualStyleBackColor = False
        '
        'lbldate
        '
        Me.lbldate.AutoSize = True
        Me.lbldate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldate.Location = New System.Drawing.Point(5, 152)
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(150, 24)
        Me.lbldate.TabIndex = 34
        Me.lbldate.Text = "Date Of Payment"
        '
        'pickdateofpayment
        '
        Me.pickdateofpayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pickdateofpayment.Location = New System.Drawing.Point(301, 150)
        Me.pickdateofpayment.Name = "pickdateofpayment"
        Me.pickdateofpayment.Size = New System.Drawing.Size(258, 26)
        Me.pickdateofpayment.TabIndex = 35
        Me.pickdateofpayment.Value = New Date(2015, 2, 9, 0, 0, 0, 0)
        '
        'cbobillformonth
        '
        Me.cbobillformonth.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbobillformonth.FormattingEnabled = True
        Me.cbobillformonth.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.cbobillformonth.Location = New System.Drawing.Point(300, 116)
        Me.cbobillformonth.Name = "cbobillformonth"
        Me.cbobillformonth.Size = New System.Drawing.Size(258, 26)
        Me.cbobillformonth.TabIndex = 36
        '
        'btnclear
        '
        Me.btnclear.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnclear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnclear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclear.Location = New System.Drawing.Point(300, 421)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(127, 48)
        Me.btnclear.TabIndex = 38
        Me.btnclear.Text = "Clear"
        Me.btnclear.UseVisualStyleBackColor = False
        '
        'btncalculate
        '
        Me.btncalculate.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btncalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncalculate.Location = New System.Drawing.Point(471, 377)
        Me.btncalculate.Name = "btncalculate"
        Me.btncalculate.Size = New System.Drawing.Size(90, 38)
        Me.btncalculate.TabIndex = 39
        Me.btncalculate.Text = "Calculate"
        Me.btncalculate.UseVisualStyleBackColor = False
        '
        'frmproducebill
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(585, 481)
        Me.Controls.Add(Me.btncalculate)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.cbobillformonth)
        Me.Controls.Add(Me.pickdateofpayment)
        Me.Controls.Add(Me.lbldate)
        Me.Controls.Add(Me.btnnext)
        Me.Controls.Add(Me.txtbillno)
        Me.Controls.Add(Me.txttotalmonthly)
        Me.Controls.Add(Me.txtnoofmonths)
        Me.Controls.Add(Me.txtrate)
        Me.Controls.Add(Me.lblmonthlypayment)
        Me.Controls.Add(Me.lbltotalmonthly)
        Me.Controls.Add(Me.lblnoofmonths)
        Me.Controls.Add(Me.lblbillformonth)
        Me.Controls.Add(Me.lblrate)
        Me.Controls.Add(Me.lblbillno)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtinputregno)
        Me.Controls.Add(Me.lblinputregno)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "frmproducebill"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Produce Bill"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblinputregno As System.Windows.Forms.Label
    Friend WithEvents txtinputregno As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblbillno As System.Windows.Forms.Label
    Friend WithEvents lblrate As System.Windows.Forms.Label
    Friend WithEvents lblbillformonth As System.Windows.Forms.Label
    Friend WithEvents lblnoofmonths As System.Windows.Forms.Label
    Friend WithEvents lbltotalmonthly As System.Windows.Forms.Label
    Friend WithEvents lblmonthlypayment As System.Windows.Forms.Label
    Friend WithEvents txtrate As System.Windows.Forms.TextBox
    Friend WithEvents txtnoofmonths As System.Windows.Forms.TextBox
    Friend WithEvents txttotalmonthly As System.Windows.Forms.TextBox
    Friend WithEvents txtbillno As System.Windows.Forms.TextBox
    Friend WithEvents btnnext As System.Windows.Forms.Button
    Friend WithEvents lbldate As System.Windows.Forms.Label
    Friend WithEvents pickdateofpayment As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbobillformonth As System.Windows.Forms.ComboBox
    Friend WithEvents btnclear As System.Windows.Forms.Button
    Friend WithEvents btncalculate As System.Windows.Forms.Button
End Class
