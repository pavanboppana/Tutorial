Public Class TestForm

    ' Keeps track of currently displayed question.
    Dim intCurrentQuestion As Integer

    ' Displays 1st question when form loads
    Private Sub TestForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        intCurrentQuestion = 0
        DisplayQuestion(intCurrentQuestion)
    End Sub


    ' Dispalys question whose question number specified by variable que.
    Private Sub DisplayQuestion(ByVal que As Integer)
        Dim question As Trivia_Data = CType(gloTestQuestions(que), Trivia_Data)
        LBLQuestion.Text = question.intQuestionNo.ToString() + " " + question.strQuestion
        RBTNAnswerA.Text = question.strAnswer1
        RBTNAnswerB.Text = question.strAnswer2
        RBTNAnswerC.Text = question.strAnswer3
        RBTNAnswerD.Text = question.strAnswer4
    End Sub

    ' Redirects to next question.
    Private Sub BTNNext_Click(sender As System.Object, e As System.EventArgs) Handles BTNNext.Click
        SubmitAnswer()
        If intCurrentQuestion = gloTestQuestions.Count - 1 Then
            MessageBox.Show("Last question..........")
            LBLMessage.Text = "You have finished all questions. Go back for review or submit the test and get the result"
            Exit Sub
        End If
        intCurrentQuestion = intCurrentQuestion + 1
        DisplayQuestion(intCurrentQuestion)


    End Sub

    ' Redirects to previous question.
    Private Sub BTNBack_Click(sender As System.Object, e As System.EventArgs) Handles BTNBack.Click
        SubmitAnswer()
        If intCurrentQuestion = 0 Then
            MessageBox.Show("First question...........")
            Exit Sub
        End If
        intCurrentQuestion = intCurrentQuestion - 1
        DisplayQuestion(intCurrentQuestion)

    End Sub

    ' Stores the answer of current question submitted by user in gloSubmittedAnswers arraylist. 
    Private Sub SubmitAnswer()
        Dim answer As Integer
        If RBTNAnswerA.Checked = True Then
            answer = 1
        End If
        If RBTNAnswerB.Checked = True Then
            answer = 2
        End If
        If RBTNAnswerC.Checked = True Then
            answer = 3
        End If
        If RBTNAnswerD.Checked = True Then
            answer = 4
        End If
        If CType(gloTestQuestions(intCurrentQuestion), Trivia_Data).intCorrectAnswer = answer Then
            gloSubmittedAnswers.Add(1)
        Else
            gloSubmittedAnswers.Add(0)
        End If


    End Sub

    Private Sub BTNQuit_Click(sender As System.Object, e As System.EventArgs) Handles BTNQuit.Click
        Close()
    End Sub

    ' Displays Result form.
    Private Sub BTNSubmit_Click(sender As System.Object, e As System.EventArgs) Handles BTNSubmit.Click
        Me.Close()
        ResultForm1.Show()
    End Sub

End Class