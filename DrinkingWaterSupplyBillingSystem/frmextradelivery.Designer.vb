<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmextradelivery
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
        Me.lbljarrate = New System.Windows.Forms.Label()
        Me.txtjarrate = New System.Windows.Forms.TextBox()
        Me.lblextradelivery = New System.Windows.Forms.Label()
        Me.lbltotalextracharge = New System.Windows.Forms.Label()
        Me.lblnoofjars = New System.Windows.Forms.Label()
        Me.txttotalextracharge = New System.Windows.Forms.TextBox()
        Me.txtnoofjars = New System.Windows.Forms.TextBox()
        Me.btnnext = New System.Windows.Forms.Button()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.btncalculate = New System.Windows.Forms.Button()
        Me.lblinputregno = New System.Windows.Forms.Label()
        Me.txtinputregno = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lbljarrate
        '
        Me.lbljarrate.AutoSize = True
        Me.lbljarrate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbljarrate.Location = New System.Drawing.Point(12, 95)
        Me.lbljarrate.Name = "lbljarrate"
        Me.lbljarrate.Size = New System.Drawing.Size(203, 24)
        Me.lbljarrate.TabIndex = 21
        Me.lbljarrate.Text = "Rate Of A Jar Of Water "
        '
        'txtjarrate
        '
        Me.txtjarrate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtjarrate.Location = New System.Drawing.Point(254, 95)
        Me.txtjarrate.Name = "txtjarrate"
        Me.txtjarrate.Size = New System.Drawing.Size(258, 26)
        Me.txtjarrate.TabIndex = 31
        '
        'lblextradelivery
        '
        Me.lblextradelivery.AutoSize = True
        Me.lblextradelivery.BackColor = System.Drawing.Color.Silver
        Me.lblextradelivery.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblextradelivery.Location = New System.Drawing.Point(108, 9)
        Me.lblextradelivery.Name = "lblextradelivery"
        Me.lblextradelivery.Size = New System.Drawing.Size(258, 25)
        Me.lblextradelivery.TabIndex = 32
        Me.lblextradelivery.Text = "Extra Delivery Payment"
        '
        'lbltotalextracharge
        '
        Me.lbltotalextracharge.AutoSize = True
        Me.lbltotalextracharge.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotalextracharge.Location = New System.Drawing.Point(10, 186)
        Me.lbltotalextracharge.Name = "lbltotalextracharge"
        Me.lbltotalextracharge.Size = New System.Drawing.Size(238, 24)
        Me.lbltotalextracharge.TabIndex = 33
        Me.lbltotalextracharge.Text = "Total Extra Delivery Charge"
        '
        'lblnoofjars
        '
        Me.lblnoofjars.AutoSize = True
        Me.lblnoofjars.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnoofjars.Location = New System.Drawing.Point(12, 140)
        Me.lblnoofjars.Name = "lblnoofjars"
        Me.lblnoofjars.Size = New System.Drawing.Size(142, 24)
        Me.lblnoofjars.TabIndex = 34
        Me.lblnoofjars.Text = "Number Of Jars"
        '
        'txttotalextracharge
        '
        Me.txttotalextracharge.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttotalextracharge.Location = New System.Drawing.Point(254, 186)
        Me.txttotalextracharge.Name = "txttotalextracharge"
        Me.txttotalextracharge.Size = New System.Drawing.Size(170, 26)
        Me.txttotalextracharge.TabIndex = 35
        '
        'txtnoofjars
        '
        Me.txtnoofjars.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnoofjars.Location = New System.Drawing.Point(254, 140)
        Me.txtnoofjars.Name = "txtnoofjars"
        Me.txtnoofjars.Size = New System.Drawing.Size(258, 26)
        Me.txtnoofjars.TabIndex = 36
        '
        'btnnext
        '
        Me.btnnext.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnnext.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnnext.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnext.Location = New System.Drawing.Point(387, 234)
        Me.btnnext.Name = "btnnext"
        Me.btnnext.Size = New System.Drawing.Size(127, 50)
        Me.btnnext.TabIndex = 37
        Me.btnnext.Text = "Next"
        Me.btnnext.UseVisualStyleBackColor = False
        '
        'btnclear
        '
        Me.btnclear.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnclear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnclear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclear.Location = New System.Drawing.Point(254, 234)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(127, 50)
        Me.btnclear.TabIndex = 39
        Me.btnclear.Text = "Clear"
        Me.btnclear.UseVisualStyleBackColor = False
        '
        'btncalculate
        '
        Me.btncalculate.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btncalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncalculate.Location = New System.Drawing.Point(422, 181)
        Me.btncalculate.Name = "btncalculate"
        Me.btncalculate.Size = New System.Drawing.Size(90, 37)
        Me.btncalculate.TabIndex = 40
        Me.btncalculate.Text = "Calculate"
        Me.btncalculate.UseVisualStyleBackColor = False
        '
        'lblinputregno
        '
        Me.lblinputregno.AutoSize = True
        Me.lblinputregno.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblinputregno.Location = New System.Drawing.Point(12, 55)
        Me.lblinputregno.Name = "lblinputregno"
        Me.lblinputregno.Size = New System.Drawing.Size(233, 24)
        Me.lblinputregno.TabIndex = 41
        Me.lblinputregno.Text = "Input Registration Number "
        '
        'txtinputregno
        '
        Me.txtinputregno.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtinputregno.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtinputregno.Location = New System.Drawing.Point(254, 55)
        Me.txtinputregno.Name = "txtinputregno"
        Me.txtinputregno.Size = New System.Drawing.Size(258, 26)
        Me.txtinputregno.TabIndex = 42
        '
        'frmextradelivery
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(519, 296)
        Me.Controls.Add(Me.txtinputregno)
        Me.Controls.Add(Me.lblinputregno)
        Me.Controls.Add(Me.btncalculate)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.btnnext)
        Me.Controls.Add(Me.txtnoofjars)
        Me.Controls.Add(Me.txttotalextracharge)
        Me.Controls.Add(Me.lblnoofjars)
        Me.Controls.Add(Me.lbltotalextracharge)
        Me.Controls.Add(Me.lblextradelivery)
        Me.Controls.Add(Me.txtjarrate)
        Me.Controls.Add(Me.lbljarrate)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "frmextradelivery"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Extra Delivery Payment"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbljarrate As System.Windows.Forms.Label
    Friend WithEvents txtjarrate As System.Windows.Forms.TextBox
    Friend WithEvents lblextradelivery As System.Windows.Forms.Label
    Friend WithEvents lbltotalextracharge As System.Windows.Forms.Label
    Friend WithEvents lblnoofjars As System.Windows.Forms.Label
    Friend WithEvents txttotalextracharge As System.Windows.Forms.TextBox
    Friend WithEvents txtnoofjars As System.Windows.Forms.TextBox
    Friend WithEvents btnnext As System.Windows.Forms.Button
    Friend WithEvents btnclear As System.Windows.Forms.Button
    Friend WithEvents btncalculate As System.Windows.Forms.Button
    Friend WithEvents lblinputregno As System.Windows.Forms.Label
    Friend WithEvents txtinputregno As System.Windows.Forms.TextBox
End Class
