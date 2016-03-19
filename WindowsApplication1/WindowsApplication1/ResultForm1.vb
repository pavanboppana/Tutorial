Public Class ResultForm1
    Private Sub Welcome_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim totalCorrectAns As Integer = 0
        For i = 0 To gloTestQuestions.Count - 1
            If gloSubmittedAnswers(i) = 1 Then
                totalCorrectAns = totalCorrectAns + 1
            End If
        Next
        Dim totalMarks As Integer = ((totalCorrectAns * 2) * 100) / (gloTestQuestions.Count * 2)
        If totalMarks >= 95 Then
            lblUsername.Text = "Congratulation " & gloStrUsername & ". You have got " & totalMarks & "% marks and passed in this test."
        Else
            lblUsername.Text = "Sorry " & gloStrUsername & ". You have got " & totalMarks & "% marks and failedd in this test"
        End If
    End Sub

    ' Destroys arraylist elements and stops application debugging.
    Private Sub ResultForm_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        gloTestQuestions.Clear()

        Application.Exit()
    End Sub


    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class