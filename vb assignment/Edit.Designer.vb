<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Edit
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Label1 As System.Windows.Forms.Label
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TicketIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TicketDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PayableAmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MovieIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SeatIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TransactionDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReservationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TicketingDataSet = New vb_assignment.TicketingDataSet()
        Me.ReservationTableAdapter = New vb_assignment.TicketingDataSetTableAdapters.ReservationTableAdapter()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.Reservation_Dataset = New vb_assignment.Reservation_Dataset()
        Me.ReservationBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReservationTableAdapter1 = New vb_assignment.Reservation_DatasetTableAdapters.ReservationTableAdapter()
        Me.TableAdapterManager = New vb_assignment.Reservation_DatasetTableAdapters.TableAdapterManager()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReservationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TicketingDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Reservation_Dataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReservationBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(47, 313)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(94, 20)
        Label1.TabIndex = 4
        Label1.Text = "Ticket Date:"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TicketIDDataGridViewTextBoxColumn, Me.TicketDateDataGridViewTextBoxColumn, Me.PayableAmountDataGridViewTextBoxColumn, Me.MovieIDDataGridViewTextBoxColumn, Me.SeatIDDataGridViewTextBoxColumn, Me.CustomerIDDataGridViewTextBoxColumn, Me.TransactionDateDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ReservationBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(69, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(746, 256)
        Me.DataGridView1.TabIndex = 0
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
        '
        'ReservationBindingSource
        '
        Me.ReservationBindingSource.DataMember = "Reservation"
        Me.ReservationBindingSource.DataSource = Me.TicketingDataSet
        '
        'TicketingDataSet
        '
        Me.TicketingDataSet.DataSetName = "TicketingDataSet"
        Me.TicketingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReservationTableAdapter
        '
        Me.ReservationTableAdapter.ClearBeforeFill = True
        '
        'Reservation_Dataset
        '
        Me.Reservation_Dataset.DataSetName = "Reservation_Dataset"
        Me.Reservation_Dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReservationBindingSource1
        '
        Me.ReservationBindingSource1.DataMember = "Reservation"
        Me.ReservationBindingSource1.DataSource = Me.Reservation_Dataset
        '
        'ReservationTableAdapter1
        '
        Me.ReservationTableAdapter1.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ReservationTableAdapter = Me.ReservationTableAdapter1
        Me.TableAdapterManager.UpdateOrder = vb_assignment.Reservation_DatasetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd/mm/yyyy"
        Me.DateTimePicker1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReservationBindingSource, "TicketDate", True))
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(162, 308)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 26)
        Me.DateTimePicker1.TabIndex = 5
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(130, 383)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(119, 36)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "Update"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(601, 375)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(134, 44)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Finish"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Edit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(947, 454)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Edit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReservationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TicketingDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Reservation_Dataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReservationBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TicketingDataSet As TicketingDataSet
    Friend WithEvents ReservationBindingSource As BindingSource
    Friend WithEvents ReservationTableAdapter As TicketingDataSetTableAdapters.ReservationTableAdapter
    Friend WithEvents TicketIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TicketDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PayableAmountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MovieIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SeatIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustomerIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TransactionDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HelpProvider1 As HelpProvider
    Friend WithEvents Reservation_Dataset As Reservation_Dataset
    Friend WithEvents ReservationBindingSource1 As BindingSource
    Friend WithEvents ReservationTableAdapter1 As Reservation_DatasetTableAdapters.ReservationTableAdapter
    Friend WithEvents TableAdapterManager As Reservation_DatasetTableAdapters.TableAdapterManager
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
End Class
