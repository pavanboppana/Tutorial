Public Class MainForm

    ' Navigates to test information.
    Private Sub BTNTest_Click(sender As System.Object, e As System.EventArgs) Handles BTNTest.Click
        Information.Show()
        Me.Close()
    End Sub

    ' Navigates to Question for based on role (status) of user.
    Private Sub BTNQuestion_Click(sender As System.Object, e As System.EventArgs) Handles BTNQuestion.Click
        If gloStrUserstatus = "user" Then
            MessageBox.Show("User is not allowed to add new question.")
            Exit Sub
        Else
            QuestionForm.Show()
        End If
    End Sub

    ' Closes current form
    Private Sub BTNClose_Click(sender As System.Object, e As System.EventArgs) Handles BTNClose.Click
        Close()
    End Sub

    Private Sub main_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class