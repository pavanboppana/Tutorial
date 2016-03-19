Imports System.IO

Public Class LoginForm

    ' Define 2-D Array.

Dim UserInfo(,) As String = {{"John", "John123", "user"}, {"Kumary", "Krishnan", "Admin"}, {"Sunate", "Sunate001", "user"}, {"Cathy", "CathyRubby", "user"}, {"Margarate", "Margarita", "Admin"}, {"David", "DavidHaug", "user"}, {"Sunil", "Sunil120", "Administrator"}}

    ' Code for Login Button.

    Private Sub BTNLogin_Click(sender As System.Object, e As System.EventArgs) Handles BTNLogin.Click

        For i = 0 To UserInfo.GetUpperBound(0)

            If (TXTUsername.Text = UserInfo(i, 0) And TXTPassword.Text = UserInfo(i, 1)) Then



                gloStrUsername = UserInfo(i, 0)

                gloStrUserstatus = UserInfo(i, 2)

                MainForm.Show()

                Me.Hide()

                Exit Sub

            End If

        Next

        MessageBox.Show("Please write a valid user name and password ")

    End Sub

    Private Sub BTNCancel_Click(sender As System.Object, e As System.EventArgs) Handles BTNCancel.Click

        Close()

    End Sub

    Private Sub LoginForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        ' Reads questions stored in binary file and store into arraylist gloTestQuestions.

        Try

            Dim file As New FileStream(Directory.GetCurrentDirectory() & "\Question.dat",
FileMode.Open, FileAccess.Read)

            Dim fileRead As New BinaryReader(file)

            While fileRead.BaseStream.Position < fileRead.BaseStream.Length

                Dim question As Trivia_Data

                question.intQuestionNo = fileRead.ReadUInt16()

                question.strQuestion = fileRead.ReadString()

                question.strAnswer1 = fileRead.ReadString()

                question.strAnswer2 = fileRead.ReadString()

                question.strAnswer3 = fileRead.ReadString()

                question.strAnswer4 = fileRead.ReadString()

                question.intCorrectAnswer = fileRead.ReadUInt16()

                gloTestQuestions.Add(question)

            End While

            ' Handles file IO exceptions 

        Catch ex As Exception

            MessageBox.Show("There is no quiz exist. Add questions in system for an exam of Driver Knowledge Test Program....")

        End Try

    End Sub

    Private Function File() As Stream
        Throw New NotImplementedException
    End Function

    
End Class


