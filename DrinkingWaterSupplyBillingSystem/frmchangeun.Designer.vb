<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmchangeun
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
        Me.lbloldun = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtoldun = New System.Windows.Forms.TextBox()
        Me.txtpw = New System.Windows.Forms.TextBox()
        Me.txtnewun = New System.Windows.Forms.TextBox()
        Me.lblpw = New System.Windows.Forms.Label()
        Me.lblnewun = New System.Windows.Forms.Label()
        Me.lbldeleteregno = New System.Windows.Forms.Label()
        Me.btndone = New System.Windows.Forms.Button()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbloldun
        '
        Me.lbloldun.AutoSize = True
        Me.lbloldun.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbloldun.Location = New System.Drawing.Point(12, 52)
        Me.lbloldun.Name = "lbloldun"
        Me.lbloldun.Size = New System.Drawing.Size(132, 24)
        Me.lbloldun.TabIndex = 44
        Me.lbloldun.Text = "Old Username"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(53, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 20)
        Me.Label1.TabIndex = 45
        '
        'txtoldun
        '
        Me.txtoldun.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtoldun.Location = New System.Drawing.Point(168, 52)
        Me.txtoldun.Name = "txtoldun"
        Me.txtoldun.Size = New System.Drawing.Size(230, 26)
        Me.txtoldun.TabIndex = 47
        '
        'txtpw
        '
        Me.txtpw.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpw.Location = New System.Drawing.Point(74, 147)
        Me.txtpw.Name = "txtpw"
        Me.txtpw.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpw.Size = New System.Drawing.Size(260, 26)
        Me.txtpw.TabIndex = 49
        '
        'txtnewun
        '
        Me.txtnewun.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnewun.Location = New System.Drawing.Point(168, 84)
        Me.txtnewun.Name = "txtnewun"
        Me.txtnewun.Size = New System.Drawing.Size(230, 26)
        Me.txtnewun.TabIndex = 52
        '
        'lblpw
        '
        Me.lblpw.AutoSize = True
        Me.lblpw.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpw.Location = New System.Drawing.Point(39, 120)
        Me.lblpw.Name = "lblpw"
        Me.lblpw.Size = New System.Drawing.Size(336, 24)
        Me.lblpw.TabIndex = 54
        Me.lblpw.Text = "Type Your Password To Make Change"
        '
        'lblnewun
        '
        Me.lblnewun.AutoSize = True
        Me.lblnewun.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnewun.Location = New System.Drawing.Point(12, 86)
        Me.lblnewun.Name = "lblnewun"
        Me.lblnewun.Size = New System.Drawing.Size(141, 24)
        Me.lblnewun.TabIndex = 55
        Me.lblnewun.Text = "New Username"
        '
        'lbldeleteregno
        '
        Me.lbldeleteregno.AutoSize = True
        Me.lbldeleteregno.BackColor = System.Drawing.Color.Silver
        Me.lbldeleteregno.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldeleteregno.Location = New System.Drawing.Point(69, 9)
        Me.lbldeleteregno.Name = "lbldeleteregno"
        Me.lbldeleteregno.Size = New System.Drawing.Size(263, 25)
        Me.lbldeleteregno.TabIndex = 56
        Me.lbldeleteregno.Text = "Change Your Username"
        '
        'btndone
        '
        Me.btndone.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btndone.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btndone.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndone.Location = New System.Drawing.Point(74, 179)
        Me.btndone.Name = "btndone"
        Me.btndone.Size = New System.Drawing.Size(127, 49)
        Me.btndone.TabIndex = 57
        Me.btndone.Text = "Done"
        Me.btndone.UseVisualStyleBackColor = False
        '
        'btncancel
        '
        Me.btncancel.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btncancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancel.Location = New System.Drawing.Point(207, 179)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(127, 49)
        Me.btncancel.TabIndex = 58
        Me.btncancel.Text = "Cancel"
        Me.btncancel.UseVisualStyleBackColor = False
        '
        'frmchangeun
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(403, 240)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btndone)
        Me.Controls.Add(Me.lbldeleteregno)
        Me.Controls.Add(Me.lblnewun)
        Me.Controls.Add(Me.lblpw)
        Me.Controls.Add(Me.txtnewun)
        Me.Controls.Add(Me.txtpw)
        Me.Controls.Add(Me.txtoldun)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbloldun)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "frmchangeun"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Change Your Username"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbloldun As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtoldun As System.Windows.Forms.TextBox
    Friend WithEvents txtpw As System.Windows.Forms.TextBox
    Friend WithEvents txtnewun As System.Windows.Forms.TextBox
    Friend WithEvents lblpw As System.Windows.Forms.Label
    Friend WithEvents lblnewun As System.Windows.Forms.Label
    Friend WithEvents lbldeleteregno As System.Windows.Forms.Label
    Friend WithEvents btndone As System.Windows.Forms.Button
    Friend WithEvents btncancel As System.Windows.Forms.Button
End Class
