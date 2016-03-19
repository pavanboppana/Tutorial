<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QuestionForm
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
        Me.lblqno = New System.Windows.Forms.Label()
        Me.lblquestion = New System.Windows.Forms.Label()
        Me.lblanswer1 = New System.Windows.Forms.Label()
        Me.lblanswer2 = New System.Windows.Forms.Label()
        Me.lblanswer3 = New System.Windows.Forms.Label()
        Me.lblanswer4 = New System.Windows.Forms.Label()
        Me.TXTQuestion = New System.Windows.Forms.TextBox()
        Me.TXTQuestionNo = New System.Windows.Forms.TextBox()
        Me.BTNFind = New System.Windows.Forms.Button()
        Me.TXTAnswer1 = New System.Windows.Forms.TextBox()
        Me.TXTAnswer2 = New System.Windows.Forms.TextBox()
        Me.TXTAnswer3 = New System.Windows.Forms.TextBox()
        Me.TXTAnswer4 = New System.Windows.Forms.TextBox()
        Me.lblqanswer = New System.Windows.Forms.Label()
        Me.lblcurrentanswer = New System.Windows.Forms.Label()
        Me.TXTAnswer5 = New System.Windows.Forms.TextBox()
        Me.BTNAdd = New System.Windows.Forms.Button()
        Me.BTNUpdate = New System.Windows.Forms.Button()
        Me.BTNDelete = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BTNSave = New System.Windows.Forms.Button()
        Me.BTNClose = New System.Windows.Forms.Button()
        Me.lbldetails = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblqno
        '
        Me.lblqno.AutoSize = True
        Me.lblqno.Location = New System.Drawing.Point(39, 32)
        Me.lblqno.Name = "lblqno"
        Me.lblqno.Size = New System.Drawing.Size(66, 13)
        Me.lblqno.TabIndex = 0
        Me.lblqno.Text = "QuestionNo:"
        '
        'lblquestion
        '
        Me.lblquestion.AutoSize = True
        Me.lblquestion.Location = New System.Drawing.Point(39, 63)
        Me.lblquestion.Name = "lblquestion"
        Me.lblquestion.Size = New System.Drawing.Size(52, 13)
        Me.lblquestion.TabIndex = 1
        Me.lblquestion.Text = "Question:"
        '
        'lblanswer1
        '
        Me.lblanswer1.AutoSize = True
        Me.lblanswer1.Location = New System.Drawing.Point(39, 142)
        Me.lblanswer1.Name = "lblanswer1"
        Me.lblanswer1.Size = New System.Drawing.Size(48, 13)
        Me.lblanswer1.TabIndex = 2
        Me.lblanswer1.Text = "Answer1"
        '
        'lblanswer2
        '
        Me.lblanswer2.AutoSize = True
        Me.lblanswer2.Location = New System.Drawing.Point(39, 175)
        Me.lblanswer2.Name = "lblanswer2"
        Me.lblanswer2.Size = New System.Drawing.Size(48, 13)
        Me.lblanswer2.TabIndex = 3
        Me.lblanswer2.Text = "Answer2"
        '
        'lblanswer3
        '
        Me.lblanswer3.AutoSize = True
        Me.lblanswer3.Location = New System.Drawing.Point(39, 209)
        Me.lblanswer3.Name = "lblanswer3"
        Me.lblanswer3.Size = New System.Drawing.Size(48, 13)
        Me.lblanswer3.TabIndex = 4
        Me.lblanswer3.Text = "Answer3"
        '
        'lblanswer4
        '
        Me.lblanswer4.AutoSize = True
        Me.lblanswer4.Location = New System.Drawing.Point(39, 241)
        Me.lblanswer4.Name = "lblanswer4"
        Me.lblanswer4.Size = New System.Drawing.Size(48, 13)
        Me.lblanswer4.TabIndex = 5
        Me.lblanswer4.Text = "Answer4"
        '
        'TXTQuestion
        '
        Me.TXTQuestion.Location = New System.Drawing.Point(111, 63)
        Me.TXTQuestion.Multiline = True
        Me.TXTQuestion.Name = "TXTQuestion"
        Me.TXTQuestion.Size = New System.Drawing.Size(355, 70)
        Me.TXTQuestion.TabIndex = 6
        '
        'TXTQuestionNo
        '
        Me.TXTQuestionNo.Location = New System.Drawing.Point(111, 29)
        Me.TXTQuestionNo.Name = "TXTQuestionNo"
        Me.TXTQuestionNo.Size = New System.Drawing.Size(104, 20)
        Me.TXTQuestionNo.TabIndex = 7
        '
        'BTNFind
        '
        Me.BTNFind.Location = New System.Drawing.Point(221, 27)
        Me.BTNFind.Name = "BTNFind"
        Me.BTNFind.Size = New System.Drawing.Size(75, 23)
        Me.BTNFind.TabIndex = 8
        Me.BTNFind.Text = "Find"
        Me.BTNFind.UseVisualStyleBackColor = True
        '
        'TXTAnswer1
        '
        Me.TXTAnswer1.Location = New System.Drawing.Point(111, 139)
        Me.TXTAnswer1.Name = "TXTAnswer1"
        Me.TXTAnswer1.Size = New System.Drawing.Size(355, 20)
        Me.TXTAnswer1.TabIndex = 10
        '
        'TXTAnswer2
        '
        Me.TXTAnswer2.Location = New System.Drawing.Point(111, 168)
        Me.TXTAnswer2.Name = "TXTAnswer2"
        Me.TXTAnswer2.Size = New System.Drawing.Size(355, 20)
        Me.TXTAnswer2.TabIndex = 11
        '
        'TXTAnswer3
        '
        Me.TXTAnswer3.Location = New System.Drawing.Point(111, 206)
        Me.TXTAnswer3.Name = "TXTAnswer3"
        Me.TXTAnswer3.Size = New System.Drawing.Size(355, 20)
        Me.TXTAnswer3.TabIndex = 12
        '
        'TXTAnswer4
        '
        Me.TXTAnswer4.Location = New System.Drawing.Point(111, 232)
        Me.TXTAnswer4.Name = "TXTAnswer4"
        Me.TXTAnswer4.Size = New System.Drawing.Size(355, 20)
        Me.TXTAnswer4.TabIndex = 13
        '
        'lblqanswer
        '
        Me.lblqanswer.AutoSize = True
        Me.lblqanswer.Location = New System.Drawing.Point(39, 277)
        Me.lblqanswer.Name = "lblqanswer"
        Me.lblqanswer.Size = New System.Drawing.Size(90, 13)
        Me.lblqanswer.TabIndex = 14
        Me.lblqanswer.Text = "Question Answer:"
        '
        'lblcurrentanswer
        '
        Me.lblcurrentanswer.AutoSize = True
        Me.lblcurrentanswer.Location = New System.Drawing.Point(39, 305)
        Me.lblcurrentanswer.Name = "lblcurrentanswer"
        Me.lblcurrentanswer.Size = New System.Drawing.Size(82, 13)
        Me.lblcurrentanswer.TabIndex = 15
        Me.lblcurrentanswer.Text = "Current Answer:"
        '
        'TXTAnswer5
        '
        Me.TXTAnswer5.Location = New System.Drawing.Point(149, 302)
        Me.TXTAnswer5.Name = "TXTAnswer5"
        Me.TXTAnswer5.Size = New System.Drawing.Size(100, 20)
        Me.TXTAnswer5.TabIndex = 16
        '
        'BTNAdd
        '
        Me.BTNAdd.Location = New System.Drawing.Point(268, 300)
        Me.BTNAdd.Name = "BTNAdd"
        Me.BTNAdd.Size = New System.Drawing.Size(75, 23)
        Me.BTNAdd.TabIndex = 17
        Me.BTNAdd.Text = "Add"
        Me.BTNAdd.UseVisualStyleBackColor = True
        '
        'BTNUpdate
        '
        Me.BTNUpdate.Location = New System.Drawing.Point(349, 299)
        Me.BTNUpdate.Name = "BTNUpdate"
        Me.BTNUpdate.Size = New System.Drawing.Size(75, 23)
        Me.BTNUpdate.TabIndex = 18
        Me.BTNUpdate.Text = "Update"
        Me.BTNUpdate.UseVisualStyleBackColor = True
        '
        'BTNDelete
        '
        Me.BTNDelete.Location = New System.Drawing.Point(431, 299)
        Me.BTNDelete.Name = "BTNDelete"
        Me.BTNDelete.Size = New System.Drawing.Size(75, 23)
        Me.BTNDelete.TabIndex = 19
        Me.BTNDelete.Text = "Cancel"
        Me.BTNDelete.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(42, 356)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(480, 150)
        Me.DataGridView1.TabIndex = 20
        '
        'BTNSave
        '
        Me.BTNSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNSave.Location = New System.Drawing.Point(186, 512)
        Me.BTNSave.Name = "BTNSave"
        Me.BTNSave.Size = New System.Drawing.Size(88, 35)
        Me.BTNSave.TabIndex = 21
        Me.BTNSave.Text = "Save"
        Me.BTNSave.UseVisualStyleBackColor = True
        '
        'BTNClose
        '
        Me.BTNClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNClose.Location = New System.Drawing.Point(287, 512)
        Me.BTNClose.Name = "BTNClose"
        Me.BTNClose.Size = New System.Drawing.Size(88, 35)
        Me.BTNClose.TabIndex = 22
        Me.BTNClose.Text = "Exit"
        Me.BTNClose.UseVisualStyleBackColor = True
        '
        'lbldetails
        '
        Me.lbldetails.AutoSize = True
        Me.lbldetails.Location = New System.Drawing.Point(39, 9)
        Me.lbldetails.Name = "lbldetails"
        Me.lbldetails.Size = New System.Drawing.Size(84, 13)
        Me.lbldetails.TabIndex = 23
        Me.lbldetails.Text = "QuestionDetails:"
        '
        'QuestionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(822, 559)
        Me.Controls.Add(Me.lbldetails)
        Me.Controls.Add(Me.BTNClose)
        Me.Controls.Add(Me.BTNSave)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.BTNDelete)
        Me.Controls.Add(Me.BTNUpdate)
        Me.Controls.Add(Me.BTNAdd)
        Me.Controls.Add(Me.TXTAnswer5)
        Me.Controls.Add(Me.lblcurrentanswer)
        Me.Controls.Add(Me.lblqanswer)
        Me.Controls.Add(Me.TXTAnswer4)
        Me.Controls.Add(Me.TXTAnswer3)
        Me.Controls.Add(Me.TXTAnswer2)
        Me.Controls.Add(Me.TXTAnswer1)
        Me.Controls.Add(Me.BTNFind)
        Me.Controls.Add(Me.TXTQuestionNo)
        Me.Controls.Add(Me.TXTQuestion)
        Me.Controls.Add(Me.lblanswer4)
        Me.Controls.Add(Me.lblanswer3)
        Me.Controls.Add(Me.lblanswer2)
        Me.Controls.Add(Me.lblanswer1)
        Me.Controls.Add(Me.lblquestion)
        Me.Controls.Add(Me.lblqno)
        Me.Name = "QuestionForm"
        Me.Text = "Question"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblqno As System.Windows.Forms.Label
    Friend WithEvents lblquestion As System.Windows.Forms.Label
    Friend WithEvents lblanswer1 As System.Windows.Forms.Label
    Friend WithEvents lblanswer2 As System.Windows.Forms.Label
    Friend WithEvents lblanswer3 As System.Windows.Forms.Label
    Friend WithEvents lblanswer4 As System.Windows.Forms.Label
    Friend WithEvents TXTQuestion As System.Windows.Forms.TextBox
    Friend WithEvents TXTQuestionNo As System.Windows.Forms.TextBox
    Friend WithEvents BTNFind As System.Windows.Forms.Button
    Friend WithEvents TXTAnswer1 As System.Windows.Forms.TextBox
    Friend WithEvents TXTAnswer2 As System.Windows.Forms.TextBox
    Friend WithEvents TXTAnswer3 As System.Windows.Forms.TextBox
    Friend WithEvents TXTAnswer4 As System.Windows.Forms.TextBox
    Friend WithEvents lblqanswer As System.Windows.Forms.Label
    Friend WithEvents lblcurrentanswer As System.Windows.Forms.Label
    Friend WithEvents TXTAnswer5 As System.Windows.Forms.TextBox
    Friend WithEvents BTNAdd As System.Windows.Forms.Button
    Friend WithEvents BTNUpdate As System.Windows.Forms.Button
    Friend WithEvents BTNDelete As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents BTNSave As System.Windows.Forms.Button
    Friend WithEvents BTNClose As System.Windows.Forms.Button
    Friend WithEvents lbldetails As System.Windows.Forms.Label
End Class
