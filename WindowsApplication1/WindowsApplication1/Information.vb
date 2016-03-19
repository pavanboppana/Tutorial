Public Class Information
    Private Sub BTNCancel_Click(sender As System.Object, e As System.EventArgs) Handles BTNCancel.Click
        Close()
    End Sub

    Private Sub BTNStart_Click(sender As System.Object, e As System.EventArgs) Handles BTNStart.Click
        Close()
        TestForm.Show()
    End Sub

    Private Sub Information_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class