<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmversioninfo
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
        Me.lblsoftwarename = New System.Windows.Forms.Label()
        Me.lblversion = New System.Windows.Forms.Label()
        Me.lblprogrammer = New System.Windows.Forms.Label()
        Me.lblcontact = New System.Windows.Forms.Label()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.lblemail = New System.Windows.Forms.Label()
        Me.lblcopyright = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblsoftwarename
        '
        Me.lblsoftwarename.AutoSize = True
        Me.lblsoftwarename.BackColor = System.Drawing.Color.Silver
        Me.lblsoftwarename.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsoftwarename.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblsoftwarename.Location = New System.Drawing.Point(0, 27)
        Me.lblsoftwarename.Name = "lblsoftwarename"
        Me.lblsoftwarename.Size = New System.Drawing.Size(499, 25)
        Me.lblsoftwarename.TabIndex = 0
        Me.lblsoftwarename.Text = "DRINKING WATER SUPPLY BILLING SYSTEM"
        '
        'lblversion
        '
        Me.lblversion.AutoSize = True
        Me.lblversion.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblversion.ForeColor = System.Drawing.SystemColors.Desktop
        Me.lblversion.Location = New System.Drawing.Point(166, 61)
        Me.lblversion.Name = "lblversion"
        Me.lblversion.Size = New System.Drawing.Size(144, 29)
        Me.lblversion.TabIndex = 1
        Me.lblversion.Text = "Version 1.0"
        '
        'lblprogrammer
        '
        Me.lblprogrammer.AutoSize = True
        Me.lblprogrammer.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblprogrammer.ForeColor = System.Drawing.Color.DimGray
        Me.lblprogrammer.Location = New System.Drawing.Point(57, 103)
        Me.lblprogrammer.Name = "lblprogrammer"
        Me.lblprogrammer.Size = New System.Drawing.Size(370, 29)
        Me.lblprogrammer.TabIndex = 2
        Me.lblprogrammer.Text = "Developed By: RAJIV BASNET"
        '
        'lblcontact
        '
        Me.lblcontact.AutoSize = True
        Me.lblcontact.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcontact.ForeColor = System.Drawing.Color.DimGray
        Me.lblcontact.Location = New System.Drawing.Point(98, 132)
        Me.lblcontact.Name = "lblcontact"
        Me.lblcontact.Size = New System.Drawing.Size(299, 25)
        Me.lblcontact.TabIndex = 3
        Me.lblcontact.Text = "Contact No: +9779819620652"
        '
        'btncancel
        '
        Me.btncancel.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btncancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancel.Location = New System.Drawing.Point(372, 210)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(127, 48)
        Me.btncancel.TabIndex = 5
        Me.btncancel.Text = "Cancel"
        Me.btncancel.UseVisualStyleBackColor = False
        '
        'lblemail
        '
        Me.lblemail.AutoSize = True
        Me.lblemail.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblemail.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblemail.Location = New System.Drawing.Point(72, 157)
        Me.lblemail.Name = "lblemail"
        Me.lblemail.Size = New System.Drawing.Size(346, 25)
        Me.lblemail.TabIndex = 6
        Me.lblemail.Text = "E-mail: razeev.basnet@yahoo.com"
        '
        'lblcopyright
        '
        Me.lblcopyright.AutoSize = True
        Me.lblcopyright.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcopyright.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblcopyright.Location = New System.Drawing.Point(141, 192)
        Me.lblcopyright.Name = "lblcopyright"
        Me.lblcopyright.Size = New System.Drawing.Size(199, 25)
        Me.lblcopyright.TabIndex = 7
        Me.lblcopyright.Text = "Copyright (@) 2015"
        '
        'frmversioninfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(503, 261)
        Me.Controls.Add(Me.lblcopyright)
        Me.Controls.Add(Me.lblemail)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.lblcontact)
        Me.Controls.Add(Me.lblprogrammer)
        Me.Controls.Add(Me.lblversion)
        Me.Controls.Add(Me.lblsoftwarename)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "frmversioninfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Version Info"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblsoftwarename As System.Windows.Forms.Label
    Friend WithEvents lblversion As System.Windows.Forms.Label
    Friend WithEvents lblprogrammer As System.Windows.Forms.Label
    Friend WithEvents lblcontact As System.Windows.Forms.Label
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents lblemail As System.Windows.Forms.Label
    Friend WithEvents lblcopyright As System.Windows.Forms.Label
End Class
