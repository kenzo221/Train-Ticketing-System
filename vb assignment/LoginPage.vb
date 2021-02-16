Public Class LoginPage
    Public username As String
    Public i As Integer = 0
    Private Sub StaffBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles StaffBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.StaffBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TicketingDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TicketingDataSet.Staff' table. You can move, or remove it, as needed.
        Me.StaffTableAdapter.Fill(Me.TicketingDataSet.Staff)
        i = 0

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim password As String
        Dim message As String = "The Username or Password was incorrect, Please try again"

        username = TextBox1.Text
        password = TextBox2.Text

        If Me.StaffTableAdapter.ScalarQueryLogin(username, password) And TextBox1.Text = "Mary Susan" Then
            Selection.Show()
            TextBox1.Clear()
            TextBox2.Text = ""
            i = 1
            MessageBox.Show("Welcome", "Information", MessageBoxButtons.OK)
            Me.Hide()
        ElseIf Me.StaffTableAdapter.ScalarQueryLogin(username, password) Then
            SelectionNotManager.Show()
            TextBox1.Clear()
            TextBox2.Text = ""
            MessageBox.Show("Welcome", "Information", MessageBoxButtons.OK)
            Me.Hide()


        Else
            MessageBox.Show(message, "Information", MessageBoxButtons.OK)
            TextBox1.Clear()
            TextBox2.Text = ""

        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub
End Class
