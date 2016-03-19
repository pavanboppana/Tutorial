<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.BTNTest = New System.Windows.Forms.Button()
        Me.BTNQuestion = New System.Windows.Forms.Button()
        Me.BTNClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BTNTest
        '
        Me.BTNTest.Location = New System.Drawing.Point(118, 33)
        Me.BTNTest.Name = "BTNTest"
        Me.BTNTest.Size = New System.Drawing.Size(156, 38)
        Me.BTNTest.TabIndex = 0
        Me.BTNTest.Text = "Test Your Knowledge"
        Me.BTNTest.UseVisualStyleBackColor = True
        '
        'BTNQuestion
        '
        Me.BTNQuestion.Location = New System.Drawing.Point(118, 112)
        Me.BTNQuestion.Name = "BTNQuestion"
        Me.BTNQuestion.Size = New System.Drawing.Size(156, 38)
        Me.BTNQuestion.TabIndex = 1
        Me.BTNQuestion.Text = "Question"
        Me.BTNQuestion.UseVisualStyleBackColor = True
        '
        'BTNClose
        '
        Me.BTNClose.Location = New System.Drawing.Point(118, 193)
        Me.BTNClose.Name = "BTNClose"
        Me.BTNClose.Size = New System.Drawing.Size(156, 38)
        Me.BTNClose.TabIndex = 2
        Me.BTNClose.Text = "Close"
        Me.BTNClose.UseVisualStyleBackColor = True
        '
        'main_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(392, 262)
        Me.Controls.Add(Me.BTNClose)
        Me.Controls.Add(Me.BTNQuestion)
        Me.Controls.Add(Me.BTNTest)
        Me.Name = "main_form"
        Me.Text = "main_form"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BTNTest As System.Windows.Forms.Button
    Friend WithEvents BTNQuestion As System.Windows.Forms.Button
    Friend WithEvents BTNClose As System.Windows.Forms.Button
End Class
