Public Class formReport
    Private Sub formReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Reservation_Dataset.Reservation' table. You can move, or remove it, as needed.
        Me.ReservationTableAdapter.Fill(Me.Reservation_Dataset.Reservation)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Selection.Show()

    End Sub
End Class