<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmdelete
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
        Me.lbldeleteregno = New System.Windows.Forms.Label()
        Me.lblregnodelete = New System.Windows.Forms.Label()
        Me.txtregnodelete = New System.Windows.Forms.TextBox()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.lblbesure = New System.Windows.Forms.Label()
        Me.btnproducebill = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbldeleteregno
        '
        Me.lbldeleteregno.AutoSize = True
        Me.lbldeleteregno.BackColor = System.Drawing.Color.Silver
        Me.lbldeleteregno.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldeleteregno.Location = New System.Drawing.Point(-2, 34)
        Me.lbldeleteregno.Name = "lbldeleteregno"
        Me.lbldeleteregno.Size = New System.Drawing.Size(720, 25)
        Me.lbldeleteregno.TabIndex = 42
        Me.lbldeleteregno.Text = "Input The Registration Number Only Of Record You Want To Delete"
        '
        'lblregnodelete
        '
        Me.lblregnodelete.AutoSize = True
        Me.lblregnodelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblregnodelete.Location = New System.Drawing.Point(4, 77)
        Me.lblregnodelete.Name = "lblregnodelete"
        Me.lblregnodelete.Size = New System.Drawing.Size(182, 24)
        Me.lblregnodelete.TabIndex = 43
        Me.lblregnodelete.Text = "Registration Number"
        '
        'txtregnodelete
        '
        Me.txtregnodelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtregnodelete.Location = New System.Drawing.Point(192, 77)
        Me.txtregnodelete.Name = "txtregnodelete"
        Me.txtregnodelete.Size = New System.Drawing.Size(239, 26)
        Me.txtregnodelete.TabIndex = 44
        '
        'btndelete
        '
        Me.btndelete.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btndelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.Location = New System.Drawing.Point(410, 139)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(127, 48)
        Me.btndelete.TabIndex = 49
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = False
        '
        'btncancel
        '
        Me.btncancel.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btncancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancel.Location = New System.Drawing.Point(562, 139)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(127, 48)
        Me.btncancel.TabIndex = 50
        Me.btncancel.Text = "Cancel"
        Me.btncancel.UseVisualStyleBackColor = False
        '
        'lblbesure
        '
        Me.lblbesure.AutoSize = True
        Me.lblbesure.BackColor = System.Drawing.Color.Silver
        Me.lblbesure.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbesure.Location = New System.Drawing.Point(150, 9)
        Me.lblbesure.Name = "lblbesure"
        Me.lblbesure.Size = New System.Drawing.Size(339, 25)
        Me.lblbesure.TabIndex = 51
        Me.lblbesure.Text = "Be Sure You Produced The Bill"
        '
        'btnproducebill
        '
        Me.btnproducebill.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnproducebill.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnproducebill.Location = New System.Drawing.Point(429, 77)
        Me.btnproducebill.Name = "btnproducebill"
        Me.btnproducebill.Size = New System.Drawing.Size(260, 38)
        Me.btnproducebill.TabIndex = 52
        Me.btnproducebill.Text = "Produce Bill For this Record"
        Me.btnproducebill.UseVisualStyleBackColor = False
        '
        'frmdelete
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(714, 199)
        Me.Controls.Add(Me.btnproducebill)
        Me.Controls.Add(Me.lblbesure)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.txtregnodelete)
        Me.Controls.Add(Me.lblregnodelete)
        Me.Controls.Add(Me.lbldeleteregno)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "frmdelete"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Delete"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbldeleteregno As System.Windows.Forms.Label
    Friend WithEvents lblregnodelete As System.Windows.Forms.Label
    Friend WithEvents txtregnodelete As System.Windows.Forms.TextBox
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents lblbesure As System.Windows.Forms.Label
    Friend WithEvents btnproducebill As System.Windows.Forms.Button
End Class
