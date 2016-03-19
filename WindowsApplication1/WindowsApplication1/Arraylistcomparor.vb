Imports System.Collections
Imports System

'comparer class for sort on inetegr data fucntionality of arraylist 
Public Class ArrayListIntegerComparere
    : Implements IComparer

    Public Function Compare(x As Object, y As Object) As Integer Implements System.Collections.IComparer.Compare
        Dim a As New CaseInsensitiveComparer()
        If IsNumeric(x) And IsNumeric(y) Then
            Return CInt(y).CompareTo(x)
        Else
            Return (Compare(CType(y, Trivia_Data).intQuestionNo, CType(x, Trivia_Data).intQuestionNo))
        End If
    End Function

End Class
