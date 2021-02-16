Public Class Edit
    Private Sub Edit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Reservation_Dataset.Reservation' table. You can move, or remove it, as needed.
        Me.ReservationTableAdapter1.Fill(Me.Reservation_Dataset.Reservation)
        'TODO: This line of code loads data into the 'Reservation_Dataset.Reservation' table. You can move, or remove it, as needed.
        Me.ReservationTableAdapter1.Fill(Me.Reservation_Dataset.Reservation)
        'TODO: This line of code loads data into the 'TicketingDataSet.Reservation' table. You can move, or remove it, as needed.
        Me.ReservationTableAdapter.Fill(Me.TicketingDataSet.Reservation)
        DataGridView1.Sort(DataGridView1.Columns(0), System.ComponentModel.ListSortDirection.Ascending)

    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ReservationBindingSource.EndEdit()

        ReservationTableAdapter.Update(TicketingDataSet.Reservation)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If LoginPage.i = 1 Then
            Me.Hide()
            Selection.Show()
        Else
            Me.Hide()
            SelectionNotManager.Show()
        End If
    End Sub
End Class