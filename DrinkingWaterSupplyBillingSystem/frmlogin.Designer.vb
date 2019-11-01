<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmlogin
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
        Me.lblpassword = New System.Windows.Forms.Label()
        Me.lblenter = New System.Windows.Forms.Label()
        Me.txtusername = New System.Windows.Forms.TextBox()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.btnlogin = New System.Windows.Forms.Button()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblusername
        '
        Me.lblusername.AutoSize = True
        Me.lblusername.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblusername.Location = New System.Drawing.Point(17, 76)
        Me.lblusername.Name = "lblusername"
        Me.lblusername.Size = New System.Drawing.Size(100, 24)
        Me.lblusername.TabIndex = 0
        Me.lblusername.Text = "UserName"
        '
        'lblpassword
        '
        Me.lblpassword.AutoSize = True
        Me.lblpassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpassword.Location = New System.Drawing.Point(17, 122)
        Me.lblpassword.Name = "lblpassword"
        Me.lblpassword.Size = New System.Drawing.Size(92, 24)
        Me.lblpassword.TabIndex = 1
        Me.lblpassword.Text = "Password"
        '
        'lblenter
        '
        Me.lblenter.AutoSize = True
        Me.lblenter.BackColor = System.Drawing.Color.Silver
        Me.lblenter.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblenter.Location = New System.Drawing.Point(36, 30)
        Me.lblenter.Name = "lblenter"
        Me.lblenter.Size = New System.Drawing.Size(351, 24)
        Me.lblenter.TabIndex = 2
        Me.lblenter.Text = "Enter Your Username And Password"
        '
        'txtusername
        '
        Me.txtusername.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtusername.Location = New System.Drawing.Point(123, 76)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(277, 26)
        Me.txtusername.TabIndex = 4
        '
        'txtpassword
        '
        Me.txtpassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpassword.Location = New System.Drawing.Point(123, 122)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpassword.Size = New System.Drawing.Size(277, 26)
        Me.txtpassword.TabIndex = 5
        '
        'btnlogin
        '
        Me.btnlogin.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnlogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlogin.Location = New System.Drawing.Point(204, 162)
        Me.btnlogin.Name = "btnlogin"
        Me.btnlogin.Size = New System.Drawing.Size(91, 40)
        Me.btnlogin.TabIndex = 6
        Me.btnlogin.Text = "Log In"
        Me.btnlogin.UseVisualStyleBackColor = False
        '
        'btncancel
        '
        Me.btncancel.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btncancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancel.Location = New System.Drawing.Point(310, 162)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(90, 40)
        Me.btncancel.TabIndex = 7
        Me.btncancel.Text = "Cancel"
        Me.btncancel.UseVisualStyleBackColor = False
        '
        'frmlogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(433, 221)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btnlogin)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.txtusername)
        Me.Controls.Add(Me.lblenter)
        Me.Controls.Add(Me.lblpassword)
        Me.Controls.Add(Me.lblusername)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "frmlogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Log In Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblusername As System.Windows.Forms.Label
    Friend WithEvents lblpassword As System.Windows.Forms.Label
    Friend WithEvents lblenter As System.Windows.Forms.Label
    Friend WithEvents txtusername As System.Windows.Forms.TextBox
    Friend WithEvents txtpassword As System.Windows.Forms.TextBox
    Friend WithEvents btnlogin As System.Windows.Forms.Button
    Friend WithEvents btncancel As System.Windows.Forms.Button
End Class
