<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TestForm
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
        Me.lblquestion = New System.Windows.Forms.Label()
        Me.RBTNAnswerA = New System.Windows.Forms.RadioButton()
        Me.RBTNAnswerB = New System.Windows.Forms.RadioButton()
        Me.RBTNAnswerC = New System.Windows.Forms.RadioButton()
        Me.RBTNAnswerD = New System.Windows.Forms.RadioButton()
        Me.BTNBack = New System.Windows.Forms.Button()
        Me.BTNNext = New System.Windows.Forms.Button()
        Me.BTNSubmit = New System.Windows.Forms.Button()
        Me.BTNQuit = New System.Windows.Forms.Button()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Question"
        '
        'lblquestion
        '
        Me.lblquestion.AutoSize = True
        Me.lblquestion.Location = New System.Drawing.Point(25, 35)
        Me.lblquestion.Name = "lblquestion"
        Me.lblquestion.Size = New System.Drawing.Size(0, 13)
        Me.lblquestion.TabIndex = 1
        '
        'RBTNAnswerA
        '
        Me.RBTNAnswerA.AutoSize = True
        Me.RBTNAnswerA.Location = New System.Drawing.Point(28, 71)
        Me.RBTNAnswerA.Name = "RBTNAnswerA"
        Me.RBTNAnswerA.Size = New System.Drawing.Size(14, 13)
        Me.RBTNAnswerA.TabIndex = 2
        Me.RBTNAnswerA.TabStop = True
        Me.RBTNAnswerA.UseVisualStyleBackColor = True
        '
        'RBTNAnswerB
        '
        Me.RBTNAnswerB.AutoSize = True
        Me.RBTNAnswerB.Location = New System.Drawing.Point(28, 103)
        Me.RBTNAnswerB.Name = "RBTNAnswerB"
        Me.RBTNAnswerB.Size = New System.Drawing.Size(14, 13)
        Me.RBTNAnswerB.TabIndex = 3
        Me.RBTNAnswerB.TabStop = True
        Me.RBTNAnswerB.UseVisualStyleBackColor = True
        '
        'RBTNAnswerC
        '
        Me.RBTNAnswerC.AutoSize = True
        Me.RBTNAnswerC.Location = New System.Drawing.Point(25, 136)
        Me.RBTNAnswerC.Name = "RBTNAnswerC"
        Me.RBTNAnswerC.Size = New System.Drawing.Size(14, 13)
        Me.RBTNAnswerC.TabIndex = 4
        Me.RBTNAnswerC.TabStop = True
        Me.RBTNAnswerC.UseVisualStyleBackColor = True
        '
        'RBTNAnswerD
        '
        Me.RBTNAnswerD.AutoSize = True
        Me.RBTNAnswerD.Location = New System.Drawing.Point(28, 175)
        Me.RBTNAnswerD.Name = "RBTNAnswerD"
        Me.RBTNAnswerD.Size = New System.Drawing.Size(14, 13)
        Me.RBTNAnswerD.TabIndex = 5
        Me.RBTNAnswerD.TabStop = True
        Me.RBTNAnswerD.UseVisualStyleBackColor = True
        '
        'BTNBack
        '
        Me.BTNBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNBack.Location = New System.Drawing.Point(15, 236)
        Me.BTNBack.Name = "BTNBack"
        Me.BTNBack.Size = New System.Drawing.Size(75, 23)
        Me.BTNBack.TabIndex = 7
        Me.BTNBack.Text = "Back"
        Me.BTNBack.UseVisualStyleBackColor = True
        '
        'BTNNext
        '
        Me.BTNNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNNext.Location = New System.Drawing.Point(96, 236)
        Me.BTNNext.Name = "BTNNext"
        Me.BTNNext.Size = New System.Drawing.Size(75, 23)
        Me.BTNNext.TabIndex = 8
        Me.BTNNext.Text = "Next"
        Me.BTNNext.UseVisualStyleBackColor = True
        '
        'BTNSubmit
        '
        Me.BTNSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNSubmit.Location = New System.Drawing.Point(178, 236)
        Me.BTNSubmit.Name = "BTNSubmit"
        Me.BTNSubmit.Size = New System.Drawing.Size(75, 23)
        Me.BTNSubmit.TabIndex = 9
        Me.BTNSubmit.Text = "Submit"
        Me.BTNSubmit.UseVisualStyleBackColor = True
        '
        'BTNQuit
        '
        Me.BTNQuit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNQuit.Location = New System.Drawing.Point(267, 236)
        Me.BTNQuit.Name = "BTNQuit"
        Me.BTNQuit.Size = New System.Drawing.Size(75, 23)
        Me.BTNQuit.TabIndex = 10
        Me.BTNQuit.Text = "QuitTest"
        Me.BTNQuit.UseVisualStyleBackColor = True
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.ForeColor = System.Drawing.Color.Green
        Me.lblMessage.Location = New System.Drawing.Point(25, 205)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(76, 16)
        Me.lblMessage.TabIndex = 6
        Me.lblMessage.Text = "Message:"
        '
        'TestForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(354, 287)
        Me.Controls.Add(Me.BTNQuit)
        Me.Controls.Add(Me.BTNSubmit)
        Me.Controls.Add(Me.BTNNext)
        Me.Controls.Add(Me.BTNBack)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.RBTNAnswerD)
        Me.Controls.Add(Me.RBTNAnswerC)
        Me.Controls.Add(Me.RBTNAnswerB)
        Me.Controls.Add(Me.RBTNAnswerA)
        Me.Controls.Add(Me.lblquestion)
        Me.Controls.Add(Me.Label1)
        Me.Name = "TestForm"
        Me.Text = "DrivingknowledgeTest"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblquestion As System.Windows.Forms.Label
    Friend WithEvents RBTNAnswerA As System.Windows.Forms.RadioButton
    Friend WithEvents RBTNAnswerB As System.Windows.Forms.RadioButton
    Friend WithEvents RBTNAnswerC As System.Windows.Forms.RadioButton
    Friend WithEvents RBTNAnswerD As System.Windows.Forms.RadioButton
    Friend WithEvents BTNBack As System.Windows.Forms.Button
    Friend WithEvents BTNNext As System.Windows.Forms.Button
    Friend WithEvents BTNSubmit As System.Windows.Forms.Button
    Friend WithEvents BTNQuit As System.Windows.Forms.Button
    Friend WithEvents lblMessage As System.Windows.Forms.Label
End Class
