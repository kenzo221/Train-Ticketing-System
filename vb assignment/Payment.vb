Public Class Payment
    Dim change As Decimal = 0
    Dim entered As Decimal = 0
    Dim money As Decimal = Convert.ToDecimal(Main.sum1).ToString("c")
    Private Sub Payment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = Main.ticketnumber
        Label4.Text = Convert.ToDecimal(Main.sum1).ToString("c")
        Label8.Text = Convert.ToDecimal(Main.subtotal1).ToString("c")
        Label9.Text = Convert.ToDecimal(Main.surcharge1).ToString("c")
        Label10.Text = Convert.ToDecimal(0.00).ToString("c")
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        Dim tax As Decimal
        tax = 0.06

        If CheckBox1.Checked Then
            money = money + (money * tax)
            Label4.Text = Convert.ToDecimal(money).ToString("c")
        Else
            Label4.Text = Convert.ToDecimal(Main.sum1).ToString("c")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        entered = entered + 1
        Label10.Text = Convert.ToDecimal(entered).ToString("c")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        entered = entered + 5
        Label10.Text = Convert.ToDecimal(entered).ToString("c")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        entered = entered + 10
        Label10.Text = Convert.ToDecimal(entered).ToString("c")
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        entered = entered + 50
        Label10.Text = Convert.ToDecimal(entered).ToString("c")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        entered = entered + 0.1
        Label10.Text = Convert.ToDecimal(entered).ToString("c")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        entered = entered + 0.2
        Label10.Text = Convert.ToDecimal(entered).ToString("c")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        entered = entered + 0.5
        Label10.Text = Convert.ToDecimal(entered).ToString("c")
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        entered = 0
        Label10.Text = Convert.ToDecimal(entered).ToString("c")
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If (entered >= money) Then
            change = entered - money
            MsgBox("Your change is " & Convert.ToDecimal(change).ToString("c"))
            If LoginPage.i = 1 Then
                Me.Hide()
                Selection.Show()
            Else
                Me.Hide()
                SelectionNotManager.Show()
            End If
        ElseIf entered < money Then
                MsgBox("The amount is insufficient, please try again")
        End If
    End Sub
End Class