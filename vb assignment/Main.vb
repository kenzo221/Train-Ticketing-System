Imports System.ComponentModel

Public Class Main
    Public sum As Integer = 0
    Public sum1 As Integer = 0
    Dim subtotal As Integer
    Public subtotal1 As Integer = 0
    Dim surcharge As Integer
    Public surcharge1 As Integer = 0
    Dim first As Integer
    Dim second As Integer
    Public ticketnumber As Integer = 0
    Dim duplicate As Boolean = False

    Private Sub StaffBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.StaffBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TicketingDataSet)

    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TicketingDataSet.Reservation' table. You can move, or remove it, as needed.
        Me.ReservationTableAdapter.Fill(Me.TicketingDataSet.Reservation)
        'TODO: This line of code loads data into the 'TicketingDataSet.Staff' table. You can move, or remove it, as needed.
        Me.StaffTableAdapter.Fill(Me.TicketingDataSet.Staff)

        TicketIDTextBox.Text = Integer.Parse(TicketIDTextBox.Text)
        DataGridView1.Sort(DataGridView1.Columns(0), System.ComponentModel.ListSortDirection.Ascending)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ReservationBindingSource.AddNew()
        DataGridView1.Sort(DataGridView1.Columns(0), System.ComponentModel.ListSortDirection.Ascending)
        Dim prevrow As Integer
        prevrow = DataGridView1.CurrentRow.Index - 1

        TicketIDTextBox.Text = DataGridView1.Rows(prevrow).Cells(0).Value + 1
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try

            Dim currentRow As Integer
            currentRow = DataGridView1.CurrentRow.Index



            ReservationBindingSource.EndEdit()

                ReservationTableAdapter.Update(TicketingDataSet.Reservation)
                MessageBox.Show("Seat Booked")
                sum1 = sum1 + sum
            ticketnumber += 1
            subtotal1 = subtotal1 + subtotal
            surcharge1 = surcharge1 + surcharge
            Dim string1 As String
            string1 = DataGridView1.CurrentRow.Cells(0).Value.ToString & "  " & DataGridView1.CurrentRow.Cells(3).Value.ToString & "  " & DataGridView1.CurrentRow.Cells(4).Value.ToString & vbNewLine
            Payment.ListBox1.Items.Add(string1)
            For index = 0 To currentRow - 1
                If DataGridView1.CurrentRow.Cells(1).Value.ToString = DataGridView1.Rows(index).Cells(1).Value.ToString And DataGridView1.CurrentRow.Cells(3).Value.ToString = DataGridView1.Rows(index).Cells(3).Value.ToString And DataGridView1.CurrentRow.Cells(4).Value.ToString = DataGridView1.Rows(index).Cells(4).Value.ToString Then
                    duplicate = True
                    Payment.ListBox1.Items.Remove(string1)
                    ticketnumber -= 1
                    sum1 = sum1 - sum
                    subtotal1 = subtotal1 - subtotal
                    surcharge1 = surcharge1 - surcharge
                    Exit Sub
                Else
                    duplicate = False
                End If
            Next
        Catch ex As Exception
            MessageBox.Show("Seat has been booked, please try again")
        End Try

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text >= 1 And ComboBox1.Text <= 10 Then
            lblSeatType.Text = "Standard"
            lblPrice.Text = Convert.ToDecimal("15.00").ToString("c")
            second = Convert.ToDecimal("15.00").ToString("c")
            subtotal = Convert.ToDecimal("15.00").ToString("c")
        ElseIf ComboBox1.Text >= 10 And ComboBox1.Text <= 15 Then
            lblSeatType.Text = "Gold"
            lblPrice.Text = Convert.ToDecimal("20.00").ToString("c")
            second = Convert.ToDecimal("20.00").ToString("c")
            subtotal = Convert.ToDecimal("20.00").ToString("c")
        Else
            lblSeatType.Text = "Premium"
            lblPrice.Text = Convert.ToDecimal("45.00").ToString("c")
            second = Convert.ToDecimal("45.00").ToString("c")
            subtotal = Convert.ToDecimal("45.00").ToString("c")
        End If
        sum = (first + second)
        lblPayable.Text = Convert.ToDecimal(sum).ToString("c")
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        If ComboBox2.Text = "Titanic" Then
            lblMovieType.Text = "2D"
            lblSurcharge.Text = Convert.ToDecimal("0.00").ToString("c")
            first = Convert.ToDecimal("0.00").ToString("c")
            lblMovieID.Text = "MI011127"
            surcharge = Convert.ToDecimal("0.00").ToString("c")
        ElseIf ComboBox2.Text = "The End" Then
            lblMovieType.Text = "Imax"
            lblSurcharge.Text = Convert.ToDecimal("10.00").ToString("c")
            first = Convert.ToDecimal("10.00").ToString("c")
            lblMovieID.Text = "MI011132"
            surcharge = Convert.ToDecimal("10.00").ToString("c")
        ElseIf ComboBox2.Text = "The Ride" Then
            lblMovieType.Text = "3D"
            lblSurcharge.Text = Convert.ToDecimal("5.00").ToString("c")
            first = Convert.ToDecimal("5.00").ToString("c")
            lblMovieID.Text = "MI011213"
            surcharge = Convert.ToDecimal("5.00").ToString("c")
        End If
        sum = (first + second)
        lblPayable.Text = Convert.ToDecimal(sum).ToString("c")
    End Sub

    Private Sub btnPay_Click(sender As Object, e As EventArgs) Handles btnPay.Click
        If duplicate = True Then
            MsgBox("Seats has already been booked, please try again")
        Else

            Payment.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If LoginPage.i = 1 Then
            Me.Hide()
            Selection.Show()
        Else
            Me.Hide()
            SelectionNotManager.Show()
        End If
    End Sub
End Class