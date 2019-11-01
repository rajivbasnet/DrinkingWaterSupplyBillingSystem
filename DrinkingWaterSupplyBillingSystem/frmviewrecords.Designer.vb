<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmviewrecords
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
        Me.lblviewrecords = New System.Windows.Forms.Label()
        Me.DataGridView = New System.Windows.Forms.DataGridView()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.btnproducebill = New System.Windows.Forms.Button()
        Me.btnsearchreg = New System.Windows.Forms.Button()
        Me.btnsearchbill = New System.Windows.Forms.Button()
        Me.btnclear = New System.Windows.Forms.Button()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblinputregno
        '
        Me.lblinputregno.AutoSize = True
        Me.lblinputregno.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblinputregno.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblinputregno.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblinputregno.Location = New System.Drawing.Point(8, 57)
        Me.lblinputregno.Name = "lblinputregno"
        Me.lblinputregno.Size = New System.Drawing.Size(233, 24)
        Me.lblinputregno.TabIndex = 2
        Me.lblinputregno.Text = "Input Registration Number "
        '
        'txtinputregno
        '
        Me.txtinputregno.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtinputregno.Location = New System.Drawing.Point(247, 55)
        Me.txtinputregno.Name = "txtinputregno"
        Me.txtinputregno.Size = New System.Drawing.Size(225, 26)
        Me.txtinputregno.TabIndex = 16
        '
        'lblviewrecords
        '
        Me.lblviewrecords.AutoSize = True
        Me.lblviewrecords.BackColor = System.Drawing.Color.Silver
        Me.lblviewrecords.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblviewrecords.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblviewrecords.Location = New System.Drawing.Point(267, 9)
        Me.lblviewrecords.Name = "lblviewrecords"
        Me.lblviewrecords.Size = New System.Drawing.Size(225, 25)
        Me.lblviewrecords.TabIndex = 17
        Me.lblviewrecords.Text = "View/Search Record"
        '
        'DataGridView
        '
        Me.DataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DataGridView.Location = New System.Drawing.Point(12, 135)
        Me.DataGridView.Name = "DataGridView"
        Me.DataGridView.Size = New System.Drawing.Size(777, 316)
        Me.DataGridView.TabIndex = 18
        '
        'btncancel
        '
        Me.btncancel.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btncancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancel.Location = New System.Drawing.Point(626, 457)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(127, 51)
        Me.btncancel.TabIndex = 19
        Me.btncancel.Text = "Cancel"
        Me.btncancel.UseVisualStyleBackColor = False
        '
        'btnproducebill
        '
        Me.btnproducebill.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnproducebill.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnproducebill.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnproducebill.Location = New System.Drawing.Point(387, 457)
        Me.btnproducebill.Name = "btnproducebill"
        Me.btnproducebill.Size = New System.Drawing.Size(232, 51)
        Me.btnproducebill.TabIndex = 20
        Me.btnproducebill.Text = "Produce Bill For this Record"
        Me.btnproducebill.UseVisualStyleBackColor = False
        '
        'btnsearchreg
        '
        Me.btnsearchreg.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnsearchreg.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsearchreg.Location = New System.Drawing.Point(478, 50)
        Me.btnsearchreg.Name = "btnsearchreg"
        Me.btnsearchreg.Size = New System.Drawing.Size(311, 36)
        Me.btnsearchreg.TabIndex = 21
        Me.btnsearchreg.Text = "Search For Registration Record"
        Me.btnsearchreg.UseVisualStyleBackColor = False
        '
        'btnsearchbill
        '
        Me.btnsearchbill.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnsearchbill.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsearchbill.Location = New System.Drawing.Point(478, 84)
        Me.btnsearchbill.Name = "btnsearchbill"
        Me.btnsearchbill.Size = New System.Drawing.Size(311, 36)
        Me.btnsearchbill.TabIndex = 22
        Me.btnsearchbill.Text = "Search For Last Billing Record"
        Me.btnsearchbill.UseVisualStyleBackColor = False
        '
        'btnclear
        '
        Me.btnclear.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnclear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclear.Location = New System.Drawing.Point(387, 84)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(85, 36)
        Me.btnclear.TabIndex = 39
        Me.btnclear.Text = "Clear"
        Me.btnclear.UseVisualStyleBackColor = False
        '
        'frmviewrecords
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(810, 517)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.btnsearchbill)
        Me.Controls.Add(Me.btnsearchreg)
        Me.Controls.Add(Me.btnproducebill)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.DataGridView)
        Me.Controls.Add(Me.lblviewrecords)
        Me.Controls.Add(Me.txtinputregno)
        Me.Controls.Add(Me.lblinputregno)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "frmviewrecords"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "View Records"
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblinputregno As System.Windows.Forms.Label
    Friend WithEvents txtinputregno As System.Windows.Forms.TextBox
    Friend WithEvents lblviewrecords As System.Windows.Forms.Label
    Friend WithEvents DataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents btnproducebill As System.Windows.Forms.Button
    Friend WithEvents btnsearchreg As System.Windows.Forms.Button
    Friend WithEvents btnsearchbill As System.Windows.Forms.Button
    Friend WithEvents btnclear As System.Windows.Forms.Button
End Class
