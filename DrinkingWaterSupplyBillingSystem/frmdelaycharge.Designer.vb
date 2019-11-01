<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmdelaycharge
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
        Me.lbldelaycharge = New System.Windows.Forms.Label()
        Me.lbltotaldc = New System.Windows.Forms.Label()
        Me.lblnoofmonthsdelay = New System.Windows.Forms.Label()
        Me.lbldelayrate = New System.Windows.Forms.Label()
        Me.txtnoofmonths = New System.Windows.Forms.TextBox()
        Me.txtdelayrate = New System.Windows.Forms.TextBox()
        Me.txttotaldelaycharge = New System.Windows.Forms.TextBox()
        Me.btnnext = New System.Windows.Forms.Button()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.btncalculate = New System.Windows.Forms.Button()
        Me.lblinputregno = New System.Windows.Forms.Label()
        Me.txtinputregno = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lbldelaycharge
        '
        Me.lbldelaycharge.AutoSize = True
        Me.lbldelaycharge.BackColor = System.Drawing.Color.Silver
        Me.lbldelaycharge.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldelaycharge.Location = New System.Drawing.Point(158, 9)
        Me.lbldelaycharge.Name = "lbldelaycharge"
        Me.lbldelaycharge.Size = New System.Drawing.Size(155, 25)
        Me.lbldelaycharge.TabIndex = 33
        Me.lbldelaycharge.Text = "Delay Charge"
        '
        'lbltotaldc
        '
        Me.lbltotaldc.AutoSize = True
        Me.lbltotaldc.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotaldc.Location = New System.Drawing.Point(12, 180)
        Me.lbltotaldc.Name = "lbltotaldc"
        Me.lbltotaldc.Size = New System.Drawing.Size(170, 24)
        Me.lbltotaldc.TabIndex = 34
        Me.lbltotaldc.Text = "Total Delay Charge"
        '
        'lblnoofmonthsdelay
        '
        Me.lblnoofmonthsdelay.AutoSize = True
        Me.lblnoofmonthsdelay.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnoofmonthsdelay.Location = New System.Drawing.Point(12, 132)
        Me.lblnoofmonthsdelay.Name = "lblnoofmonthsdelay"
        Me.lblnoofmonthsdelay.Size = New System.Drawing.Size(272, 24)
        Me.lblnoofmonthsdelay.TabIndex = 35
        Me.lblnoofmonthsdelay.Text = "Number Of Months Been Delay"
        '
        'lbldelayrate
        '
        Me.lbldelayrate.AutoSize = True
        Me.lbldelayrate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldelayrate.Location = New System.Drawing.Point(12, 90)
        Me.lbldelayrate.Name = "lbldelayrate"
        Me.lbldelayrate.Size = New System.Drawing.Size(216, 24)
        Me.lbldelayrate.TabIndex = 36
        Me.lbldelayrate.Text = "Delay Charge Per Month"
        '
        'txtnoofmonths
        '
        Me.txtnoofmonths.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnoofmonths.Location = New System.Drawing.Point(280, 132)
        Me.txtnoofmonths.Name = "txtnoofmonths"
        Me.txtnoofmonths.Size = New System.Drawing.Size(224, 26)
        Me.txtnoofmonths.TabIndex = 37
        '
        'txtdelayrate
        '
        Me.txtdelayrate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdelayrate.Location = New System.Drawing.Point(280, 90)
        Me.txtdelayrate.Name = "txtdelayrate"
        Me.txtdelayrate.Size = New System.Drawing.Size(224, 26)
        Me.txtdelayrate.TabIndex = 38
        '
        'txttotaldelaycharge
        '
        Me.txttotaldelaycharge.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttotaldelaycharge.Location = New System.Drawing.Point(280, 180)
        Me.txttotaldelaycharge.Name = "txttotaldelaycharge"
        Me.txttotaldelaycharge.Size = New System.Drawing.Size(138, 26)
        Me.txttotaldelaycharge.TabIndex = 39
        '
        'btnnext
        '
        Me.btnnext.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnnext.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnnext.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnext.Location = New System.Drawing.Point(399, 219)
        Me.btnnext.Name = "btnnext"
        Me.btnnext.Size = New System.Drawing.Size(105, 50)
        Me.btnnext.TabIndex = 40
        Me.btnnext.Text = "Next"
        Me.btnnext.UseVisualStyleBackColor = False
        '
        'btnclear
        '
        Me.btnclear.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnclear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnclear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclear.Location = New System.Drawing.Point(280, 219)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(104, 50)
        Me.btnclear.TabIndex = 42
        Me.btnclear.Text = "Clear"
        Me.btnclear.UseVisualStyleBackColor = False
        '
        'btncalculate
        '
        Me.btncalculate.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btncalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncalculate.Location = New System.Drawing.Point(414, 174)
        Me.btncalculate.Name = "btncalculate"
        Me.btncalculate.Size = New System.Drawing.Size(90, 39)
        Me.btncalculate.TabIndex = 43
        Me.btncalculate.Text = "Calculate"
        Me.btncalculate.UseVisualStyleBackColor = False
        '
        'lblinputregno
        '
        Me.lblinputregno.AutoSize = True
        Me.lblinputregno.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblinputregno.Location = New System.Drawing.Point(12, 46)
        Me.lblinputregno.Name = "lblinputregno"
        Me.lblinputregno.Size = New System.Drawing.Size(233, 24)
        Me.lblinputregno.TabIndex = 44
        Me.lblinputregno.Text = "Input Registration Number "
        '
        'txtinputregno
        '
        Me.txtinputregno.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtinputregno.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtinputregno.Location = New System.Drawing.Point(280, 46)
        Me.txtinputregno.Name = "txtinputregno"
        Me.txtinputregno.Size = New System.Drawing.Size(224, 26)
        Me.txtinputregno.TabIndex = 45
        '
        'frmdelaycharge
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(509, 281)
        Me.Controls.Add(Me.txtinputregno)
        Me.Controls.Add(Me.lblinputregno)
        Me.Controls.Add(Me.btncalculate)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.btnnext)
        Me.Controls.Add(Me.txttotaldelaycharge)
        Me.Controls.Add(Me.txtdelayrate)
        Me.Controls.Add(Me.txtnoofmonths)
        Me.Controls.Add(Me.lbldelayrate)
        Me.Controls.Add(Me.lblnoofmonthsdelay)
        Me.Controls.Add(Me.lbltotaldc)
        Me.Controls.Add(Me.lbldelaycharge)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "frmdelaycharge"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Delay Charge"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbldelaycharge As System.Windows.Forms.Label
    Friend WithEvents lbltotaldc As System.Windows.Forms.Label
    Friend WithEvents lblnoofmonthsdelay As System.Windows.Forms.Label
    Friend WithEvents lbldelayrate As System.Windows.Forms.Label
    Friend WithEvents txtnoofmonths As System.Windows.Forms.TextBox
    Friend WithEvents txtdelayrate As System.Windows.Forms.TextBox
    Friend WithEvents txttotaldelaycharge As System.Windows.Forms.TextBox
    Friend WithEvents btnnext As System.Windows.Forms.Button
    Friend WithEvents btnclear As System.Windows.Forms.Button
    Friend WithEvents btncalculate As System.Windows.Forms.Button
    Friend WithEvents lblinputregno As System.Windows.Forms.Label
    Friend WithEvents txtinputregno As System.Windows.Forms.TextBox
End Class
