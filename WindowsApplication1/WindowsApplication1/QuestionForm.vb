Imports System.IO

Public Class QuestionForm

    ' Holds question number of question currently being updating or deleting.
    Dim currentlyEditingDeleteingQueNo As Integer
    Private Sub QuestionForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        TXTQuestionNo.Enabled = False
        TXTQuestionNo.Text = gloTestQuestions.Count + 1
        Fill_Grid()
    End Sub

    ' Insert a new question in array list.
    Private Sub BTNAdd_Click(sender As System.Object, e As System.EventArgs) Handles BTNAdd.Click
        Dim question As Trivia_Data
        question.intQuestionNo = TXTQuestionNo.Text
        question.strQuestion = TXTQuestion.Text
        question.strAnswer1 = TXTAnswer1.Text
        question.strAnswer2 = TXTAnswer2.Text
        question.strAnswer3 = TXTAnswer3.Text
        question.strAnswer4 = TXTAnswer4.Text
        question.intCorrectAnswer = Integer.Parse(TXTAnswer5.Text)
        gloTestQuestions.Add(question)
        Fill_Grid()
        MessageBox.Show("Question inserted successfully....")
        ClearText()
    End Sub

    ' Clears all text boxes for next question and displays possible question for it.
    Private Sub ClearText()
        TXTAnswer1.Clear()
        TXTAnswer2.Clear()
        TXTAnswer3.Clear()
        TXTAnswer4.Clear()
        TXTAnswer5.Clear()
        TXTQuestion.Clear()
        TXTQuestionNo.Clear()
        TXTQuestionNo.Text = gloTestQuestions.Count + 1
    End Sub

    ' Fills data grid view controls with available questions in a system.
    Private Sub Fill_Grid()
        Dim dt As DataTable
        dt = New DataTable()
        dt.Columns.Add("Question Number")
        dt.Columns.Add("Question")
        dt.Columns.Add("Answer1")
        dt.Columns.Add("Answer2")
        dt.Columns.Add("Answer3")
        dt.Columns.Add("Answer4")
        dt.Columns.Add("CorrectAnswer")
        Dim question As Trivia_Data
        For j = 0 To gloTestQuestions.Count - 1
            dt.Rows.Add()
            question = CType(gloTestQuestions(j), Trivia_Data)
            dt.Rows(j)("Question Number") = question.intQuestionNo.ToString()
            dt.Rows(j)("Question") = question.strQuestion
            dt.Rows(j)("Answer1") = question.strAnswer1
            dt.Rows(j)("Answer2") = question.strAnswer2
            dt.Rows(j)("Answer3") = question.strAnswer3
            dt.Rows(j)("Answer4") = question.strAnswer4
            dt.Rows(j)("CorrectAnswer") = question.intCorrectAnswer
        Next
        DataGridView1.DataSource = dt
    End Sub


    ' Searchs a question by user supplied question number using binary search technique. 
    Private Sub BTNFind_Click(sender As System.Object, e As System.EventArgs) Handles BTNFind.Click
        Dim totalAddedQuestion As Integer = gloTestQuestions.Count
        Dim questionNo = InputBox("Enter the question number that you want to search:")
        If questionNo > gloTestQuestions.Count Or questionNo = 0 Then
            MessageBox.Show("Question doesn't exist..........")
            ClearText()
            Exit Sub
        Else
            Dim compare As New ArrayListIntegerComparere
            gloTestQuestions.Sort(compare)
            Fill_Grid()
            Dim max As Integer
            Dim min As Integer
            Dim mid As Integer
            min = 0
            max = totalAddedQuestion - 1
            While (max >= min)
                mid = (min + max) / 2
                Dim question As Trivia_Data = CType(gloTestQuestions(mid), Trivia_Data)
                If question.intQuestionNo < questionNo Then
                    min = mid + 1
                ElseIf question.intQuestionNo > questionNo Then
                    max = mid - 1
                Else
                    TXTAnswer1.Text = question.strAnswer1
                    TXTAnswer2.Text = question.strAnswer2
                    TXTAnswer3.Text = question.strAnswer3
                    TXTAnswer4.Text = question.strAnswer4
                    TXTAnswer5.Text = question.intCorrectAnswer
                    TXTQuestion.Text = question.strQuestion
                    TXTQuestionNo.Text = question.intQuestionNo
                    currentlyEditingDeleteingQueNo = mid
                    MessageBox.Show("Question found............")
                    BTNUpdate.Enabled = True
                    BTNDelete.Enabled = True

                    Exit Sub
                End If
            End While
        End If
        MessageBox.Show("Question doesn't exist.................")
        ClearText()
    End Sub

    ' Saves questions in binary file and closes the file after writing operations.
    Private Sub BTNSave_Click(sender As System.Object, e As System.EventArgs) Handles BTNSave.Click
        Dim file As New FileStream(Directory.GetCurrentDirectory() & "\Question.dat", FileMode.Create, FileAccess.Write)
        Dim fileWrite As BinaryWriter = New BinaryWriter(file)
        Dim question As Trivia_Data
        For i = 0 To gloTestQuestions.Count - 1
            question = CType(gloTestQuestions(i), Trivia_Data)
            fileWrite.Write(Convert.ToInt16(question.intQuestionNo))
            fileWrite.Write(question.strQuestion)
            fileWrite.Write(question.strAnswer1)
            fileWrite.Write(question.strAnswer2)
            fileWrite.Write(question.strAnswer3)
            fileWrite.Write(question.strAnswer4)
            fileWrite.Write(Convert.ToInt16(question.intCorrectAnswer))
        Next
        fileWrite.Close()
        file.Close()
        MessageBox.Show("Questions saved in file successfully..........")
    End Sub

    ' Updates exisitng question as per newly provided values.
    Private Sub BTNUpdate_Click(sender As System.Object, e As System.EventArgs) Handles BTNUpdate.Click
        Dim question As Trivia_Data = CType(gloTestQuestions(currentlyEditingDeleteingQueNo), Trivia_Data)
        question.strAnswer1 = TXTAnswer1.Text
        question.strAnswer2 = TXTAnswer2.Text
        question.strAnswer3 = TXTAnswer3.Text
        question.strAnswer4 = TXTAnswer4.Text
        question.intCorrectAnswer = Integer.Parse(TXTAnswer5.Text)
        question.strQuestion = TXTQuestion.Text
        gloTestQuestions(currentlyEditingDeleteingQueNo) = question
        MessageBox.Show("Question updated successfully...................")
        BTNUpdate.Enabled = False
        BTNDelete.Enabled = False
        ClearText()
        Fill_Grid()
    End Sub

    ' Deletes a current question from the arraylist.
    Private Sub BTNDelete_Click(sender As System.Object, e As System.EventArgs) Handles BTNDelete.Click
        gloTestQuestions.RemoveAt(currentlyEditingDeleteingQueNo)
        Fill_Grid()
        ClearText()
        MessageBox.Show("Question removed successfully.....")
        BTNDelete.Enabled = False
        BTNUpdate.Enabled = False
    End Sub

    ' Closes the Question form
    Private Sub BTNClose_Click(sender As System.Object, e As System.EventArgs) Handles BTNClose.Click
        Me.Close()
    End Sub
End Class
