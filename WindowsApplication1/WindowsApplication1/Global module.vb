Module GlobalModule
    ' Global variable to store user infromation.
    Public gloStrUserstatus As String
    Public gloStrUsername As String

    ' Global structure to represent question.
    Public Structure Trivia_Data
        Dim intQuestionNo As Integer
        Dim strQuestion As String
        Dim strAnswer1 As String
        Dim strAnswer2 As String
        Dim strAnswer3 As String
        Dim strAnswer4 As String
        Dim intCorrectAnswer As Integer
    End Structure

    ' Global variable to store questions of test
    Public gloTestQuestions As New ArrayList

    ' Global variable to store answers submitted by user
    Public gloSubmittedAnswers As New ArrayList
End Module

