<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmregister
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
        Me.lblregdate = New System.Windows.Forms.Label()
        Me.lblnationality = New System.Windows.Forms.Label()
        Me.lbladdress = New System.Windows.Forms.Label()
        Me.lblownername = New System.Windows.Forms.Label()
        Me.lblhouseno = New System.Windows.Forms.Label()
        Me.lblregno = New System.Windows.Forms.Label()
        Me.lblauthorizedby = New System.Windows.Forms.Label()
        Me.lblcontactno = New System.Windows.Forms.Label()
        Me.txtnationality = New System.Windows.Forms.TextBox()
        Me.txtcontactno = New System.Windows.Forms.TextBox()
        Me.txtauthorizedby = New System.Windows.Forms.TextBox()
        Me.txtaddress = New System.Windows.Forms.TextBox()
        Me.txtownername = New System.Windows.Forms.TextBox()
        Me.txthouseno = New System.Windows.Forms.TextBox()
        Me.txtregno = New System.Windows.Forms.TextBox()
        Me.pickdateregdate = New System.Windows.Forms.DateTimePicker()
        Me.lblfill = New System.Windows.Forms.Label()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblregdate
        '
        Me.lblregdate.AutoSize = True
        Me.lblregdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblregdate.Location = New System.Drawing.Point(36, 89)
        Me.lblregdate.Name = "lblregdate"
        Me.lblregdate.Size = New System.Drawing.Size(175, 24)
        Me.lblregdate.TabIndex = 1
        Me.lblregdate.Text = "Date Of Registration"
        '
        'lblnationality
        '
        Me.lblnationality.AutoSize = True
        Me.lblnationality.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnationality.Location = New System.Drawing.Point(36, 304)
        Me.lblnationality.Name = "lblnationality"
        Me.lblnationality.Size = New System.Drawing.Size(95, 24)
        Me.lblnationality.TabIndex = 2
        Me.lblnationality.Text = "Nationality"
        '
        'lbladdress
        '
        Me.lbladdress.AutoSize = True
        Me.lbladdress.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbladdress.Location = New System.Drawing.Point(36, 261)
        Me.lbladdress.Name = "lbladdress"
        Me.lbladdress.Size = New System.Drawing.Size(80, 24)
        Me.lbladdress.TabIndex = 3
        Me.lbladdress.Text = "Address"
        '
        'lblownername
        '
        Me.lblownername.AutoSize = True
        Me.lblownername.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblownername.Location = New System.Drawing.Point(36, 216)
        Me.lblownername.Name = "lblownername"
        Me.lblownername.Size = New System.Drawing.Size(197, 24)
        Me.lblownername.TabIndex = 4
        Me.lblownername.Text = "House Owner's Name"
        '
        'lblhouseno
        '
        Me.lblhouseno.AutoSize = True
        Me.lblhouseno.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblhouseno.Location = New System.Drawing.Point(36, 170)
        Me.lblhouseno.Name = "lblhouseno"
        Me.lblhouseno.Size = New System.Drawing.Size(140, 24)
        Me.lblhouseno.TabIndex = 5
        Me.lblhouseno.Text = "House Number"
        '
        'lblregno
        '
        Me.lblregno.AutoSize = True
        Me.lblregno.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblregno.Location = New System.Drawing.Point(36, 130)
        Me.lblregno.Name = "lblregno"
        Me.lblregno.Size = New System.Drawing.Size(182, 24)
        Me.lblregno.TabIndex = 6
        Me.lblregno.Text = "Registration Number"
        '
        'lblauthorizedby
        '
        Me.lblauthorizedby.AutoSize = True
        Me.lblauthorizedby.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblauthorizedby.Location = New System.Drawing.Point(36, 394)
        Me.lblauthorizedby.Name = "lblauthorizedby"
        Me.lblauthorizedby.Size = New System.Drawing.Size(127, 24)
        Me.lblauthorizedby.TabIndex = 7
        Me.lblauthorizedby.Text = "Authorized By"
        '
        'lblcontactno
        '
        Me.lblcontactno.AutoSize = True
        Me.lblcontactno.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcontactno.Location = New System.Drawing.Point(36, 348)
        Me.lblcontactno.Name = "lblcontactno"
        Me.lblcontactno.Size = New System.Drawing.Size(147, 24)
        Me.lblcontactno.TabIndex = 8
        Me.lblcontactno.Text = "Contact Number"
        '
        'txtnationality
        '
        Me.txtnationality.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnationality.Location = New System.Drawing.Point(230, 304)
        Me.txtnationality.Name = "txtnationality"
        Me.txtnationality.Size = New System.Drawing.Size(306, 26)
        Me.txtnationality.TabIndex = 9
        '
        'txtcontactno
        '
        Me.txtcontactno.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcontactno.Location = New System.Drawing.Point(230, 348)
        Me.txtcontactno.Name = "txtcontactno"
        Me.txtcontactno.Size = New System.Drawing.Size(306, 26)
        Me.txtcontactno.TabIndex = 10
        '
        'txtauthorizedby
        '
        Me.txtauthorizedby.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtauthorizedby.Location = New System.Drawing.Point(230, 394)
        Me.txtauthorizedby.Name = "txtauthorizedby"
        Me.txtauthorizedby.Size = New System.Drawing.Size(306, 26)
        Me.txtauthorizedby.TabIndex = 11
        '
        'txtaddress
        '
        Me.txtaddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtaddress.Location = New System.Drawing.Point(230, 261)
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(306, 26)
        Me.txtaddress.TabIndex = 12
        '
        'txtownername
        '
        Me.txtownername.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtownername.Location = New System.Drawing.Point(230, 216)
        Me.txtownername.Name = "txtownername"
        Me.txtownername.Size = New System.Drawing.Size(306, 26)
        Me.txtownername.TabIndex = 13
        '
        'txthouseno
        '
        Me.txthouseno.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txthouseno.Location = New System.Drawing.Point(230, 170)
        Me.txthouseno.Name = "txthouseno"
        Me.txthouseno.Size = New System.Drawing.Size(306, 26)
        Me.txthouseno.TabIndex = 14
        '
        'txtregno
        '
        Me.txtregno.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtregno.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtregno.Location = New System.Drawing.Point(230, 130)
        Me.txtregno.Name = "txtregno"
        Me.txtregno.Size = New System.Drawing.Size(306, 26)
        Me.txtregno.TabIndex = 15
        '
        'pickdateregdate
        '
        Me.pickdateregdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pickdateregdate.Location = New System.Drawing.Point(230, 87)
        Me.pickdateregdate.Name = "pickdateregdate"
        Me.pickdateregdate.Size = New System.Drawing.Size(306, 26)
        Me.pickdateregdate.TabIndex = 16
        Me.pickdateregdate.Value = New Date(2015, 2, 9, 0, 0, 0, 0)
        '
        'lblfill
        '
        Me.lblfill.AutoSize = True
        Me.lblfill.BackColor = System.Drawing.Color.Silver
        Me.lblfill.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfill.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.lblfill.Location = New System.Drawing.Point(22, 23)
        Me.lblfill.Name = "lblfill"
        Me.lblfill.Size = New System.Drawing.Size(533, 29)
        Me.lblfill.TabIndex = 17
        Me.lblfill.Text = "Please Fill Up The Following Form Correctly"
        '
        'btnsave
        '
        Me.btnsave.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnsave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.Location = New System.Drawing.Point(338, 433)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(91, 43)
        Me.btnsave.TabIndex = 18
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'btncancel
        '
        Me.btncancel.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btncancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancel.Location = New System.Drawing.Point(445, 433)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(91, 43)
        Me.btncancel.TabIndex = 19
        Me.btncancel.Text = "Cancel"
        Me.btncancel.UseVisualStyleBackColor = False
        '
        'btnclear
        '
        Me.btnclear.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnclear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnclear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclear.Location = New System.Drawing.Point(230, 433)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(90, 43)
        Me.btnclear.TabIndex = 43
        Me.btnclear.Text = "Clear"
        Me.btnclear.UseVisualStyleBackColor = False
        '
        'frmregister
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(568, 488)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.lblfill)
        Me.Controls.Add(Me.pickdateregdate)
        Me.Controls.Add(Me.txtregno)
        Me.Controls.Add(Me.txthouseno)
        Me.Controls.Add(Me.txtownername)
        Me.Controls.Add(Me.txtaddress)
        Me.Controls.Add(Me.txtauthorizedby)
        Me.Controls.Add(Me.txtcontactno)
        Me.Controls.Add(Me.txtnationality)
        Me.Controls.Add(Me.lblcontactno)
        Me.Controls.Add(Me.lblauthorizedby)
        Me.Controls.Add(Me.lblregno)
        Me.Controls.Add(Me.lblhouseno)
        Me.Controls.Add(Me.lblownername)
        Me.Controls.Add(Me.lbladdress)
        Me.Controls.Add(Me.lblnationality)
        Me.Controls.Add(Me.lblregdate)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "frmregister"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registration Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblregdate As System.Windows.Forms.Label
    Friend WithEvents lblnationality As System.Windows.Forms.Label
    Friend WithEvents lbladdress As System.Windows.Forms.Label
    Friend WithEvents lblownername As System.Windows.Forms.Label
    Friend WithEvents lblhouseno As System.Windows.Forms.Label
    Friend WithEvents lblregno As System.Windows.Forms.Label
    Friend WithEvents lblauthorizedby As System.Windows.Forms.Label
    Friend WithEvents lblcontactno As System.Windows.Forms.Label
    Friend WithEvents txtnationality As System.Windows.Forms.TextBox
    Friend WithEvents txtcontactno As System.Windows.Forms.TextBox
    Friend WithEvents txtauthorizedby As System.Windows.Forms.TextBox
    Friend WithEvents txtaddress As System.Windows.Forms.TextBox
    Friend WithEvents txtownername As System.Windows.Forms.TextBox
    Friend WithEvents txthouseno As System.Windows.Forms.TextBox
    Friend WithEvents txtregno As System.Windows.Forms.TextBox
    Friend WithEvents pickdateregdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblfill As System.Windows.Forms.Label
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents btnclear As System.Windows.Forms.Button
End Class
