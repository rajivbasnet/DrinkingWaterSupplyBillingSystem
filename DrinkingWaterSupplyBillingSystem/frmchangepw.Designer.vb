<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmchangepw
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
        Me.lblusername = New System.Windows.Forms.Label()
        Me.txtusername = New System.Windows.Forms.TextBox()
        Me.lblnewpwretype = New System.Windows.Forms.Label()
        Me.lblnewpw = New System.Windows.Forms.Label()
        Me.txtnewpw = New System.Windows.Forms.TextBox()
        Me.txtnewpwretype = New System.Windows.Forms.TextBox()
        Me.lbldeleteregno = New System.Windows.Forms.Label()
        Me.btndone = New System.Windows.Forms.Button()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.lbloldpw = New System.Windows.Forms.Label()
        Me.txtoldpw = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblusername
        '
        Me.lblusername.AutoSize = True
        Me.lblusername.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblusername.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblusername.Location = New System.Drawing.Point(3, 48)
        Me.lblusername.Name = "lblusername"
        Me.lblusername.Size = New System.Drawing.Size(97, 24)
        Me.lblusername.TabIndex = 45
        Me.lblusername.Text = "Username"
        '
        'txtusername
        '
        Me.txtusername.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtusername.Location = New System.Drawing.Point(143, 48)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(243, 26)
        Me.txtusername.TabIndex = 53
        '
        'lblnewpwretype
        '
        Me.lblnewpwretype.AutoSize = True
        Me.lblnewpwretype.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnewpwretype.Location = New System.Drawing.Point(94, 157)
        Me.lblnewpwretype.Name = "lblnewpwretype"
        Me.lblnewpwretype.Size = New System.Drawing.Size(214, 24)
        Me.lblnewpwretype.TabIndex = 54
        Me.lblnewpwretype.Text = "Re-Type New Password"
        '
        'lblnewpw
        '
        Me.lblnewpw.AutoSize = True
        Me.lblnewpw.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnewpw.Location = New System.Drawing.Point(3, 120)
        Me.lblnewpw.Name = "lblnewpw"
        Me.lblnewpw.Size = New System.Drawing.Size(136, 24)
        Me.lblnewpw.TabIndex = 55
        Me.lblnewpw.Text = "New Password"
        '
        'txtnewpw
        '
        Me.txtnewpw.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnewpw.Location = New System.Drawing.Point(143, 120)
        Me.txtnewpw.Name = "txtnewpw"
        Me.txtnewpw.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtnewpw.Size = New System.Drawing.Size(243, 26)
        Me.txtnewpw.TabIndex = 56
        '
        'txtnewpwretype
        '
        Me.txtnewpwretype.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtnewpwretype.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnewpwretype.Location = New System.Drawing.Point(75, 184)
        Me.txtnewpwretype.Name = "txtnewpwretype"
        Me.txtnewpwretype.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtnewpwretype.Size = New System.Drawing.Size(258, 26)
        Me.txtnewpwretype.TabIndex = 57
        '
        'lbldeleteregno
        '
        Me.lbldeleteregno.AutoSize = True
        Me.lbldeleteregno.BackColor = System.Drawing.Color.Silver
        Me.lbldeleteregno.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldeleteregno.Location = New System.Drawing.Point(58, 9)
        Me.lbldeleteregno.Name = "lbldeleteregno"
        Me.lbldeleteregno.Size = New System.Drawing.Size(259, 25)
        Me.lbldeleteregno.TabIndex = 58
        Me.lbldeleteregno.Text = "Change Your Password"
        '
        'btndone
        '
        Me.btndone.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btndone.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btndone.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndone.Location = New System.Drawing.Point(75, 216)
        Me.btndone.Name = "btndone"
        Me.btndone.Size = New System.Drawing.Size(127, 47)
        Me.btndone.TabIndex = 59
        Me.btndone.Text = "Done"
        Me.btndone.UseVisualStyleBackColor = False
        '
        'btncancel
        '
        Me.btncancel.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btncancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancel.Location = New System.Drawing.Point(206, 216)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(127, 47)
        Me.btncancel.TabIndex = 60
        Me.btncancel.Text = "Cancel"
        Me.btncancel.UseVisualStyleBackColor = False
        '
        'lbloldpw
        '
        Me.lbloldpw.AutoSize = True
        Me.lbloldpw.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbloldpw.Location = New System.Drawing.Point(3, 85)
        Me.lbloldpw.Name = "lbloldpw"
        Me.lbloldpw.Size = New System.Drawing.Size(127, 24)
        Me.lbloldpw.TabIndex = 61
        Me.lbloldpw.Text = "Old Password"
        '
        'txtoldpw
        '
        Me.txtoldpw.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtoldpw.Location = New System.Drawing.Point(143, 85)
        Me.txtoldpw.Name = "txtoldpw"
        Me.txtoldpw.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtoldpw.Size = New System.Drawing.Size(243, 26)
        Me.txtoldpw.TabIndex = 62
        '
        'frmchangepw
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(394, 273)
        Me.Controls.Add(Me.txtoldpw)
        Me.Controls.Add(Me.lbloldpw)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btndone)
        Me.Controls.Add(Me.lbldeleteregno)
        Me.Controls.Add(Me.txtnewpwretype)
        Me.Controls.Add(Me.txtnewpw)
        Me.Controls.Add(Me.lblnewpw)
        Me.Controls.Add(Me.lblnewpwretype)
        Me.Controls.Add(Me.txtusername)
        Me.Controls.Add(Me.lblusername)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "frmchangepw"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Change Your Password"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblusername As System.Windows.Forms.Label
    Friend WithEvents txtusername As System.Windows.Forms.TextBox
    Friend WithEvents lblnewpwretype As System.Windows.Forms.Label
    Friend WithEvents lblnewpw As System.Windows.Forms.Label
    Friend WithEvents txtnewpw As System.Windows.Forms.TextBox
    Friend WithEvents txtnewpwretype As System.Windows.Forms.TextBox
    Friend WithEvents lbldeleteregno As System.Windows.Forms.Label
    Friend WithEvents btndone As System.Windows.Forms.Button
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents lbloldpw As System.Windows.Forms.Label
    Friend WithEvents txtoldpw As System.Windows.Forms.TextBox
End Class
