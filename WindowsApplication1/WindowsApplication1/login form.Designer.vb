<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
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
        Me.TXTUsername = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TXTPassword = New System.Windows.Forms.TextBox()
        Me.BTNLogin = New System.Windows.Forms.Button()
        Me.BTNCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TXTUsername
        '
        Me.TXTUsername.Location = New System.Drawing.Point(103, 47)
        Me.TXTUsername.Name = "TXTUsername"
        Me.TXTUsername.Size = New System.Drawing.Size(109, 20)
        Me.TXTUsername.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(21, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "password"
        '
        'TXTPassword
        '
        Me.TXTPassword.Location = New System.Drawing.Point(102, 109)
        Me.TXTPassword.Name = "TXTPassword"
        Me.TXTPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TXTPassword.Size = New System.Drawing.Size(109, 20)
        Me.TXTPassword.TabIndex = 3
        '
        'BTNLogin
        '
        Me.BTNLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNLogin.Location = New System.Drawing.Point(24, 162)
        Me.BTNLogin.Name = "BTNLogin"
        Me.BTNLogin.Size = New System.Drawing.Size(87, 32)
        Me.BTNLogin.TabIndex = 4
        Me.BTNLogin.Text = "login"
        Me.BTNLogin.UseVisualStyleBackColor = True
        '
        'BTNCancel
        '
        Me.BTNCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNCancel.Location = New System.Drawing.Point(117, 162)
        Me.BTNCancel.Name = "BTNCancel"
        Me.BTNCancel.Size = New System.Drawing.Size(91, 32)
        Me.BTNCancel.TabIndex = 5
        Me.BTNCancel.Text = "cancel"
        Me.BTNCancel.UseVisualStyleBackColor = True
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(243, 232)
        Me.Controls.Add(Me.BTNCancel)
        Me.Controls.Add(Me.BTNLogin)
        Me.Controls.Add(Me.TXTPassword)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TXTUsername)
        Me.Name = "LoginForm"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TXTUsername As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TXTPassword As System.Windows.Forms.TextBox
    Friend WithEvents BTNLogin As System.Windows.Forms.Button
    Friend WithEvents BTNCancel As System.Windows.Forms.Button

End Class
