<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmmain
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
        Me.btnregister = New System.Windows.Forms.Button()
        Me.btnviewrecord = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnproducebill = New System.Windows.Forms.Button()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.mnufile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuregister = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuviewrecords = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuproducebill = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnudelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuexit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnusettings = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnusecurity = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeUsernameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangePasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuhelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuusingapp = New System.Windows.Forms.ToolStripMenuItem()
        Me.VersionInfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnumenu = New System.Windows.Forms.MenuStrip()
        Me.mnumenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnregister
        '
        Me.btnregister.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnregister.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnregister.FlatAppearance.BorderSize = 2
        Me.btnregister.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnregister.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnregister.Location = New System.Drawing.Point(144, 58)
        Me.btnregister.Name = "btnregister"
        Me.btnregister.Size = New System.Drawing.Size(312, 80)
        Me.btnregister.TabIndex = 0
        Me.btnregister.Text = "Register/Add New Record"
        Me.btnregister.UseVisualStyleBackColor = False
        '
        'btnviewrecord
        '
        Me.btnviewrecord.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnviewrecord.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnviewrecord.FlatAppearance.BorderSize = 2
        Me.btnviewrecord.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnviewrecord.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnviewrecord.Location = New System.Drawing.Point(144, 144)
        Me.btnviewrecord.Name = "btnviewrecord"
        Me.btnviewrecord.Size = New System.Drawing.Size(312, 80)
        Me.btnviewrecord.TabIndex = 1
        Me.btnviewrecord.Text = "View Records"
        Me.btnviewrecord.UseVisualStyleBackColor = False
        '
        'btndelete
        '
        Me.btndelete.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btndelete.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btndelete.FlatAppearance.BorderSize = 2
        Me.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btndelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.Location = New System.Drawing.Point(144, 316)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(312, 80)
        Me.btndelete.TabIndex = 2
        Me.btndelete.Text = "Delete a Record"
        Me.btndelete.UseVisualStyleBackColor = False
        '
        'btnproducebill
        '
        Me.btnproducebill.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnproducebill.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnproducebill.FlatAppearance.BorderSize = 2
        Me.btnproducebill.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnproducebill.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnproducebill.Location = New System.Drawing.Point(144, 230)
        Me.btnproducebill.Name = "btnproducebill"
        Me.btnproducebill.Size = New System.Drawing.Size(312, 80)
        Me.btnproducebill.TabIndex = 3
        Me.btnproducebill.Text = "Produce Bill"
        Me.btnproducebill.UseVisualStyleBackColor = False
        '
        'btncancel
        '
        Me.btncancel.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btncancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancel.Location = New System.Drawing.Point(457, 420)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(127, 49)
        Me.btncancel.TabIndex = 4
        Me.btncancel.Text = "Cancel"
        Me.btncancel.UseVisualStyleBackColor = False
        '
        'mnufile
        '
        Me.mnufile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuregister, Me.mnuviewrecords, Me.mnuproducebill, Me.mnudelete, Me.mnuexit})
        Me.mnufile.Name = "mnufile"
        Me.mnufile.Size = New System.Drawing.Size(59, 33)
        Me.mnufile.Text = "File"
        '
        'mnuregister
        '
        Me.mnuregister.Name = "mnuregister"
        Me.mnuregister.Size = New System.Drawing.Size(236, 34)
        Me.mnuregister.Text = "Register"
        '
        'mnuviewrecords
        '
        Me.mnuviewrecords.Name = "mnuviewrecords"
        Me.mnuviewrecords.Size = New System.Drawing.Size(236, 34)
        Me.mnuviewrecords.Text = "View Records"
        '
        'mnuproducebill
        '
        Me.mnuproducebill.Name = "mnuproducebill"
        Me.mnuproducebill.Size = New System.Drawing.Size(236, 34)
        Me.mnuproducebill.Text = "Produce Bill"
        '
        'mnudelete
        '
        Me.mnudelete.Name = "mnudelete"
        Me.mnudelete.Size = New System.Drawing.Size(236, 34)
        Me.mnudelete.Text = "Delete a Record"
        '
        'mnuexit
        '
        Me.mnuexit.Name = "mnuexit"
        Me.mnuexit.Size = New System.Drawing.Size(236, 34)
        Me.mnuexit.Text = "Exit"
        '
        'mnusettings
        '
        Me.mnusettings.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnusecurity})
        Me.mnusettings.Name = "mnusettings"
        Me.mnusettings.Size = New System.Drawing.Size(101, 33)
        Me.mnusettings.Text = "Settings"
        '
        'mnusecurity
        '
        Me.mnusecurity.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChangeUsernameToolStripMenuItem, Me.ChangePasswordToolStripMenuItem})
        Me.mnusecurity.Name = "mnusecurity"
        Me.mnusecurity.Size = New System.Drawing.Size(163, 34)
        Me.mnusecurity.Text = "Security"
        '
        'ChangeUsernameToolStripMenuItem
        '
        Me.ChangeUsernameToolStripMenuItem.Name = "ChangeUsernameToolStripMenuItem"
        Me.ChangeUsernameToolStripMenuItem.Size = New System.Drawing.Size(260, 34)
        Me.ChangeUsernameToolStripMenuItem.Text = "Change Username"
        '
        'ChangePasswordToolStripMenuItem
        '
        Me.ChangePasswordToolStripMenuItem.Name = "ChangePasswordToolStripMenuItem"
        Me.ChangePasswordToolStripMenuItem.Size = New System.Drawing.Size(260, 34)
        Me.ChangePasswordToolStripMenuItem.Text = "Change Password"
        '
        'mnuhelp
        '
        Me.mnuhelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuusingapp, Me.VersionInfoToolStripMenuItem})
        Me.mnuhelp.Name = "mnuhelp"
        Me.mnuhelp.Size = New System.Drawing.Size(69, 33)
        Me.mnuhelp.Text = "Help"
        '
        'mnuusingapp
        '
        Me.mnuusingapp.Name = "mnuusingapp"
        Me.mnuusingapp.Size = New System.Drawing.Size(254, 34)
        Me.mnuusingapp.Text = "Using Application"
        '
        'VersionInfoToolStripMenuItem
        '
        Me.VersionInfoToolStripMenuItem.Name = "VersionInfoToolStripMenuItem"
        Me.VersionInfoToolStripMenuItem.Size = New System.Drawing.Size(254, 34)
        Me.VersionInfoToolStripMenuItem.Text = "Version Info"
        '
        'mnumenu
        '
        Me.mnumenu.BackColor = System.Drawing.Color.Gray
        Me.mnumenu.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnumenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnufile, Me.mnusettings, Me.mnuhelp})
        Me.mnumenu.Location = New System.Drawing.Point(0, 0)
        Me.mnumenu.Name = "mnumenu"
        Me.mnumenu.Size = New System.Drawing.Size(605, 37)
        Me.mnumenu.TabIndex = 5
        Me.mnumenu.Text = "Menu"
        '
        'frmmain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(605, 481)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btnproducebill)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnviewrecord)
        Me.Controls.Add(Me.btnregister)
        Me.Controls.Add(Me.mnumenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MainMenuStrip = Me.mnumenu
        Me.Name = "frmmain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main Form"
        Me.mnumenu.ResumeLayout(False)
        Me.mnumenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnregister As System.Windows.Forms.Button
    Friend WithEvents btnviewrecord As System.Windows.Forms.Button
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents btnproducebill As System.Windows.Forms.Button
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents mnufile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuregister As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuviewrecords As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuproducebill As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnudelete As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuexit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnusettings As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnusecurity As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuhelp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuusingapp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VersionInfoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnumenu As System.Windows.Forms.MenuStrip
    Friend WithEvents ChangeUsernameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangePasswordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
