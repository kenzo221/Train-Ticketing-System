<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim TicketIDLabel As System.Windows.Forms.Label
        Dim TicketDateLabel As System.Windows.Forms.Label
        Dim PayableAmountLabel As System.Windows.Forms.Label
        Dim MovieIDLabel As System.Windows.Forms.Label
        Dim CustomerIDLabel As System.Windows.Forms.Label
        Dim TransactionDateLabel As System.Windows.Forms.Label
        Dim SeatIDLabel As System.Windows.Forms.Label
        Me.TicketingDataSet = New vb_assignment.TicketingDataSet()
        Me.StaffBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StaffTableAdapter = New vb_assignment.TicketingDataSetTableAdapters.StaffTableAdapter()
        Me.TableAdapterManager = New vb_assignment.TicketingDataSetTableAdapters.TableAdapterManager()
        Me.ReservationTableAdapter = New vb_assignment.TicketingDataSetTableAdapters.ReservationTableAdapter()
        Me.ReservationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TicketIDTextBox = New System.Windows.Forms.TextBox()
        Me.TicketDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.CustomerIDTextBox = New System.Windows.Forms.TextBox()
        Me.TransactionDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblSeatType = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblMovieID = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblMovieType = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblSurcharge = New System.Windows.Forms.Label()
        Me.lblPayable = New System.Windows.Forms.Label()
        Me.btnPay = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TicketIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TicketDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PayableAmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MovieIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SeatIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TransactionDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        TicketIDLabel = New System.Windows.Forms.Label()
        TicketDateLabel = New System.Windows.Forms.Label()
        PayableAmountLabel = New System.Windows.Forms.Label()
        MovieIDLabel = New System.Windows.Forms.Label()
        CustomerIDLabel = New System.Windows.Forms.Label()
        TransactionDateLabel = New System.Windows.Forms.Label()
        SeatIDLabel = New System.Windows.Forms.Label()
        CType(Me.TicketingDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaffBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReservationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TicketIDLabel
        '
        TicketIDLabel.AutoSize = True
        TicketIDLabel.Location = New System.Drawing.Point(10, 96)
        TicketIDLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        TicketIDLabel.Name = "TicketIDLabel"
        TicketIDLabel.Size = New System.Drawing.Size(70, 18)
        TicketIDLabel.TabIndex = 0
        TicketIDLabel.Text = "Ticket ID:"
        '
        'TicketDateLabel
        '
        TicketDateLabel.AutoSize = True
        TicketDateLabel.Location = New System.Drawing.Point(10, 133)
        TicketDateLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        TicketDateLabel.Name = "TicketDateLabel"
        TicketDateLabel.Size = New System.Drawing.Size(87, 18)
        TicketDateLabel.TabIndex = 2
        TicketDateLabel.Text = "Ticket Date:"
        '
        'PayableAmountLabel
        '
        PayableAmountLabel.AutoSize = True
        PayableAmountLabel.Location = New System.Drawing.Point(10, 168)
        PayableAmountLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        PayableAmountLabel.Name = "PayableAmountLabel"
        PayableAmountLabel.Size = New System.Drawing.Size(119, 18)
        PayableAmountLabel.TabIndex = 4
        PayableAmountLabel.Text = "Payable Amount:"
        '
        'MovieIDLabel
        '
        MovieIDLabel.AutoSize = True
        MovieIDLabel.Location = New System.Drawing.Point(10, 204)
        MovieIDLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        MovieIDLabel.Name = "MovieIDLabel"
        MovieIDLabel.Size = New System.Drawing.Size(52, 18)
        MovieIDLabel.TabIndex = 6
        MovieIDLabel.Text = "Movie:"
        '
        'CustomerIDLabel
        '
        CustomerIDLabel.AutoSize = True
        CustomerIDLabel.Location = New System.Drawing.Point(10, 42)
        CustomerIDLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        CustomerIDLabel.Name = "CustomerIDLabel"
        CustomerIDLabel.Size = New System.Drawing.Size(96, 18)
        CustomerIDLabel.TabIndex = 10
        CustomerIDLabel.Text = "Customer ID:"
        '
        'TransactionDateLabel
        '
        TransactionDateLabel.AutoSize = True
        TransactionDateLabel.Location = New System.Drawing.Point(3, 507)
        TransactionDateLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        TransactionDateLabel.Name = "TransactionDateLabel"
        TransactionDateLabel.Size = New System.Drawing.Size(125, 18)
        TransactionDateLabel.TabIndex = 12
        TransactionDateLabel.Text = "Transaction Date:"
        '
        'SeatIDLabel
        '
        SeatIDLabel.AutoSize = True
        SeatIDLabel.Location = New System.Drawing.Point(10, 346)
        SeatIDLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        SeatIDLabel.Name = "SeatIDLabel"
        SeatIDLabel.Size = New System.Drawing.Size(60, 18)
        SeatIDLabel.TabIndex = 8
        SeatIDLabel.Text = "Seat ID:"
        '
        'TicketingDataSet
        '
        Me.TicketingDataSet.DataSetName = "TicketingDataSet"
        Me.TicketingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StaffBindingSource
        '
        Me.StaffBindingSource.DataMember = "Staff"
        Me.StaffBindingSource.DataSource = Me.TicketingDataSet
        '
        'StaffTableAdapter
        '
        Me.StaffTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CustomerTableAdapter = Nothing
        Me.TableAdapterManager.MovieTableAdapter = Nothing
        Me.TableAdapterManager.ReservationTableAdapter = Me.ReservationTableAdapter
        Me.TableAdapterManager.SeatTableAdapter = Nothing
        Me.TableAdapterManager.StaffTableAdapter = Me.StaffTableAdapter
        Me.TableAdapterManager.UpdateOrder = vb_assignment.TicketingDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ReservationTableAdapter
        '
        Me.ReservationTableAdapter.ClearBeforeFill = True
        '
        'ReservationBindingSource
        '
        Me.ReservationBindingSource.DataMember = "Reservation"
        Me.ReservationBindingSource.DataSource = Me.TicketingDataSet
        '
        'TicketIDTextBox
        '
        Me.TicketIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReservationBindingSource, "TicketID", True))
        Me.TicketIDTextBox.Location = New System.Drawing.Point(158, 91)
        Me.TicketIDTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.TicketIDTextBox.Name = "TicketIDTextBox"
        Me.TicketIDTextBox.Size = New System.Drawing.Size(298, 24)
        Me.TicketIDTextBox.TabIndex = 1
        '
        'TicketDateDateTimePicker
        '
        Me.TicketDateDateTimePicker.CustomFormat = "dd/mm/yyyy"
        Me.TicketDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReservationBindingSource, "TicketDate", True))
        Me.TicketDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.TicketDateDateTimePicker.Location = New System.Drawing.Point(158, 127)
        Me.TicketDateDateTimePicker.Margin = New System.Windows.Forms.Padding(4)
        Me.TicketDateDateTimePicker.Name = "TicketDateDateTimePicker"
        Me.TicketDateDateTimePicker.Size = New System.Drawing.Size(298, 24)
        Me.TicketDateDateTimePicker.TabIndex = 3
        '
        'CustomerIDTextBox
        '
        Me.CustomerIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReservationBindingSource, "CustomerID", True))
        Me.CustomerIDTextBox.Location = New System.Drawing.Point(158, 37)
        Me.CustomerIDTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.CustomerIDTextBox.Name = "CustomerIDTextBox"
        Me.CustomerIDTextBox.Size = New System.Drawing.Size(298, 24)
        Me.CustomerIDTextBox.TabIndex = 11
        '
        'TransactionDateDateTimePicker
        '
        Me.TransactionDateDateTimePicker.CustomFormat = "dd/mm/yyyy"
        Me.TransactionDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReservationBindingSource, "TransactionDate", True))
        Me.TransactionDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.TransactionDateDateTimePicker.Location = New System.Drawing.Point(158, 497)
        Me.TransactionDateDateTimePicker.Margin = New System.Windows.Forms.Padding(4)
        Me.TransactionDateDateTimePicker.Name = "TransactionDateDateTimePicker"
        Me.TransactionDateDateTimePicker.Size = New System.Drawing.Size(298, 24)
        Me.TransactionDateDateTimePicker.TabIndex = 13
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TicketIDDataGridViewTextBoxColumn, Me.TicketDateDataGridViewTextBoxColumn, Me.PayableAmountDataGridViewTextBoxColumn, Me.MovieIDDataGridViewTextBoxColumn, Me.SeatIDDataGridViewTextBoxColumn, Me.CustomerIDDataGridViewTextBoxColumn, Me.TransactionDateDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ReservationBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(480, 13)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(795, 489)
        Me.DataGridView1.TabIndex = 14
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(0, 558)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 32)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Add New"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(160, 558)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(112, 32)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "Book"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReservationBindingSource, "SeatID", True))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20"})
        Me.ComboBox1.Location = New System.Drawing.Point(158, 342)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(180, 26)
        Me.ComboBox1.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 395)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 18)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Type:"
        '
        'lblSeatType
        '
        Me.lblSeatType.AutoSize = True
        Me.lblSeatType.Location = New System.Drawing.Point(68, 395)
        Me.lblSeatType.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSeatType.Name = "lblSeatType"
        Me.lblSeatType.Size = New System.Drawing.Size(0, 18)
        Me.lblSeatType.TabIndex = 19
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 440)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 18)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Price:"
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Location = New System.Drawing.Point(80, 440)
        Me.lblPrice.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(0, 18)
        Me.lblPrice.TabIndex = 21
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Titanic", "The End", "The Ride"})
        Me.ComboBox2.Location = New System.Drawing.Point(160, 199)
        Me.ComboBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(180, 26)
        Me.ComboBox2.TabIndex = 22
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 241)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 18)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "ID:"
        '
        'lblMovieID
        '
        Me.lblMovieID.AutoSize = True
        Me.lblMovieID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReservationBindingSource, "MovieID", True))
        Me.lblMovieID.Location = New System.Drawing.Point(51, 241)
        Me.lblMovieID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMovieID.Name = "lblMovieID"
        Me.lblMovieID.Size = New System.Drawing.Size(0, 18)
        Me.lblMovieID.TabIndex = 24
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 273)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 18)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Type:"
        '
        'lblMovieType
        '
        Me.lblMovieType.AutoSize = True
        Me.lblMovieType.Location = New System.Drawing.Point(70, 273)
        Me.lblMovieType.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMovieType.Name = "lblMovieType"
        Me.lblMovieType.Size = New System.Drawing.Size(0, 18)
        Me.lblMovieType.TabIndex = 26
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 303)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 18)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Surcharge:"
        '
        'lblSurcharge
        '
        Me.lblSurcharge.AutoSize = True
        Me.lblSurcharge.Location = New System.Drawing.Point(108, 303)
        Me.lblSurcharge.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSurcharge.Name = "lblSurcharge"
        Me.lblSurcharge.Size = New System.Drawing.Size(0, 18)
        Me.lblSurcharge.TabIndex = 28
        '
        'lblPayable
        '
        Me.lblPayable.AutoSize = True
        Me.lblPayable.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReservationBindingSource, "PayableAmount", True))
        Me.lblPayable.Location = New System.Drawing.Point(156, 168)
        Me.lblPayable.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPayable.Name = "lblPayable"
        Me.lblPayable.Size = New System.Drawing.Size(0, 18)
        Me.lblPayable.TabIndex = 29
        '
        'btnPay
        '
        Me.btnPay.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPay.Location = New System.Drawing.Point(330, 558)
        Me.btnPay.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPay.Name = "btnPay"
        Me.btnPay.Size = New System.Drawing.Size(112, 32)
        Me.btnPay.TabIndex = 30
        Me.btnPay.Text = "Pay"
        Me.btnPay.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(160, 618)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(112, 32)
        Me.Button3.TabIndex = 31
        Me.Button3.Text = "Cancel"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TicketIDDataGridViewTextBoxColumn
        '
        Me.TicketIDDataGridViewTextBoxColumn.DataPropertyName = "TicketID"
        Me.TicketIDDataGridViewTextBoxColumn.HeaderText = "TicketID"
        Me.TicketIDDataGridViewTextBoxColumn.Name = "TicketIDDataGridViewTextBoxColumn"
        '
        'TicketDateDataGridViewTextBoxColumn
        '
        Me.TicketDateDataGridViewTextBoxColumn.DataPropertyName = "TicketDate"
        Me.TicketDateDataGridViewTextBoxColumn.HeaderText = "TicketDate"
        Me.TicketDateDataGridViewTextBoxColumn.Name = "TicketDateDataGridViewTextBoxColumn"
        '
        'PayableAmountDataGridViewTextBoxColumn
        '
        Me.PayableAmountDataGridViewTextBoxColumn.DataPropertyName = "PayableAmount"
        Me.PayableAmountDataGridViewTextBoxColumn.HeaderText = "PayableAmount"
        Me.PayableAmountDataGridViewTextBoxColumn.Name = "PayableAmountDataGridViewTextBoxColumn"
        Me.PayableAmountDataGridViewTextBoxColumn.Width = 120
        '
        'MovieIDDataGridViewTextBoxColumn
        '
        Me.MovieIDDataGridViewTextBoxColumn.DataPropertyName = "MovieID"
        Me.MovieIDDataGridViewTextBoxColumn.HeaderText = "MovieID"
        Me.MovieIDDataGridViewTextBoxColumn.Name = "MovieIDDataGridViewTextBoxColumn"
        '
        'SeatIDDataGridViewTextBoxColumn
        '
        Me.SeatIDDataGridViewTextBoxColumn.DataPropertyName = "SeatID"
        Me.SeatIDDataGridViewTextBoxColumn.HeaderText = "SeatID"
        Me.SeatIDDataGridViewTextBoxColumn.Name = "SeatIDDataGridViewTextBoxColumn"
        '
        'CustomerIDDataGridViewTextBoxColumn
        '
        Me.CustomerIDDataGridViewTextBoxColumn.DataPropertyName = "CustomerID"
        Me.CustomerIDDataGridViewTextBoxColumn.HeaderText = "CustomerID"
        Me.CustomerIDDataGridViewTextBoxColumn.Name = "CustomerIDDataGridViewTextBoxColumn"
        '
        'TransactionDateDataGridViewTextBoxColumn
        '
        Me.TransactionDateDataGridViewTextBoxColumn.DataPropertyName = "TransactionDate"
        Me.TransactionDateDataGridViewTextBoxColumn.HeaderText = "TransactionDate"
        Me.TransactionDateDataGridViewTextBoxColumn.Name = "TransactionDateDataGridViewTextBoxColumn"
        Me.TransactionDateDataGridViewTextBoxColumn.Width = 120
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1370, 654)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btnPay)
        Me.Controls.Add(Me.lblPayable)
        Me.Controls.Add(Me.lblSurcharge)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblMovieType)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblMovieID)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblSeatType)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(TicketIDLabel)
        Me.Controls.Add(Me.TicketIDTextBox)
        Me.Controls.Add(TicketDateLabel)
        Me.Controls.Add(Me.TicketDateDateTimePicker)
        Me.Controls.Add(PayableAmountLabel)
        Me.Controls.Add(MovieIDLabel)
        Me.Controls.Add(SeatIDLabel)
        Me.Controls.Add(CustomerIDLabel)
        Me.Controls.Add(Me.CustomerIDTextBox)
        Me.Controls.Add(TransactionDateLabel)
        Me.Controls.Add(Me.TransactionDateDateTimePicker)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Main"
        Me.Text = "Booking"
        CType(Me.TicketingDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaffBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReservationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TicketingDataSet As TicketingDataSet
    Friend WithEvents StaffBindingSource As BindingSource
    Friend WithEvents StaffTableAdapter As TicketingDataSetTableAdapters.StaffTableAdapter
    Friend WithEvents TableAdapterManager As TicketingDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ReservationTableAdapter As TicketingDataSetTableAdapters.ReservationTableAdapter
    Friend WithEvents ReservationBindingSource As BindingSource
    Friend WithEvents TicketIDTextBox As TextBox
    Friend WithEvents TicketDateDateTimePicker As DateTimePicker
    Friend WithEvents CustomerIDTextBox As TextBox
    Friend WithEvents TransactionDateDateTimePicker As DateTimePicker
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblSeatType As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lblMovieID As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblMovieType As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblSurcharge As Label
    Friend WithEvents lblPayable As Label
    Friend WithEvents btnPay As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents TicketIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TicketDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PayableAmountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MovieIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SeatIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustomerIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TransactionDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
