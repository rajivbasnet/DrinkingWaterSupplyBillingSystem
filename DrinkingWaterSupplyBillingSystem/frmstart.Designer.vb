<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmstart
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmstart))
        Me.picturebox = New System.Windows.Forms.PictureBox()
        Me.btnstart = New System.Windows.Forms.Button()
        Me.btnclose = New System.Windows.Forms.Button()
        CType(Me.picturebox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picturebox
        '
        Me.picturebox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picturebox.Image = CType(resources.GetObject("picturebox.Image"), System.Drawing.Image)
        Me.picturebox.Location = New System.Drawing.Point(0, 0)
        Me.picturebox.Name = "picturebox"
        Me.picturebox.Size = New System.Drawing.Size(720, 483)
        Me.picturebox.TabIndex = 0
        Me.picturebox.TabStop = False
        '
        'btnstart
        '
        Me.btnstart.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnstart.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnstart.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnstart.Location = New System.Drawing.Point(380, 425)
        Me.btnstart.Name = "btnstart"
        Me.btnstart.Size = New System.Drawing.Size(136, 47)
        Me.btnstart.TabIndex = 1
        Me.btnstart.Text = "Start"
        Me.btnstart.UseVisualStyleBackColor = False
        '
        'btnclose
        '
        Me.btnclose.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnclose.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.Location = New System.Drawing.Point(548, 424)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(130, 47)
        Me.btnclose.TabIndex = 2
        Me.btnclose.Text = "Close"
        Me.btnclose.UseVisualStyleBackColor = False
        '
        'frmstart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(720, 483)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.btnstart)
        Me.Controls.Add(Me.picturebox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "frmstart"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Start Form"
        CType(Me.picturebox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents picturebox As System.Windows.Forms.PictureBox
    Friend WithEvents btnstart As System.Windows.Forms.Button
    Friend WithEvents btnclose As System.Windows.Forms.Button

End Class
