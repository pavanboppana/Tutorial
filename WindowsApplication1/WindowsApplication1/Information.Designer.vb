<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Information
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblinformation = New System.Windows.Forms.Label()
        Me.BTNStart = New System.Windows.Forms.Button()
        Me.BTNCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(49, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 0
        '
        'lblinformation
        '
        Me.lblinformation.AutoSize = True
        Me.lblinformation.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblinformation.ForeColor = System.Drawing.Color.Red
        Me.lblinformation.Location = New System.Drawing.Point(12, 14)
        Me.lblinformation.Name = "lblinformation"
        Me.lblinformation.Size = New System.Drawing.Size(1177, 20)
        Me.lblinformation.TabIndex = 1
        Me.lblinformation.Text = "Welcome to the driver knowledge test. The test includes 50 Questions. Each questi" & _
    "on contain 2 points. Total hour is one hour and pass mark 95%."
        '
        'BTNStart
        '
        Me.BTNStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNStart.Location = New System.Drawing.Point(61, 156)
        Me.BTNStart.Name = "BTNStart"
        Me.BTNStart.Size = New System.Drawing.Size(90, 35)
        Me.BTNStart.TabIndex = 2
        Me.BTNStart.Text = "Start"
        Me.BTNStart.UseVisualStyleBackColor = True
        '
        'BTNCancel
        '
        Me.BTNCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNCancel.Location = New System.Drawing.Point(157, 156)
        Me.BTNCancel.Name = "BTNCancel"
        Me.BTNCancel.Size = New System.Drawing.Size(89, 35)
        Me.BTNCancel.TabIndex = 3
        Me.BTNCancel.Text = "Cancel"
        Me.BTNCancel.UseVisualStyleBackColor = True
        '
        'Information
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(728, 264)
        Me.Controls.Add(Me.BTNCancel)
        Me.Controls.Add(Me.BTNStart)
        Me.Controls.Add(Me.lblinformation)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Information"
        Me.Text = "Information"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblinformation As System.Windows.Forms.Label
    Friend WithEvents BTNStart As System.Windows.Forms.Button
    Friend WithEvents BTNCancel As System.Windows.Forms.Button
End Class
