Namespace XtraGridTutorial
    Partial Public Class MainForm
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
            Me.transactionsGridControl = New DevExpress.XtraGrid.GridControl()
            Me.transactionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.transactionsGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAccount = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCategory = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colTransactionType = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colTrasactionDate = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAmount = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colComment = New DevExpress.XtraGrid.Columns.GridColumn()
            CType(Me.transactionsGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.transactionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.transactionsGridView, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' transactionsGridControl
            ' 
            Me.transactionsGridControl.DataSource = Me.transactionBindingSource
            Me.transactionsGridControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.transactionsGridControl.Location = New System.Drawing.Point(0, 0)
            Me.transactionsGridControl.MainView = Me.transactionsGridView
            Me.transactionsGridControl.Name = "transactionsGridControl"
            Me.transactionsGridControl.Size = New System.Drawing.Size(661, 478)
            Me.transactionsGridControl.TabIndex = 0
            Me.transactionsGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.transactionsGridView})
            ' 
            ' transactionBindingSource
            ' 
            Me.transactionBindingSource.DataSource = GetType(DataLayer.Data.Classes.Transaction)
            ' 
            ' transactionsGridView
            ' 
            Me.transactionsGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colID, Me.colAccount, Me.colCategory, Me.colTransactionType, Me.colTrasactionDate, Me.colAmount, Me.colComment})
            Me.transactionsGridView.GridControl = Me.transactionsGridControl
            Me.transactionsGridView.Name = "transactionsGridView"
            ' 
            ' colID
            ' 
            Me.colID.FieldName = "ID"
            Me.colID.Name = "colID"
            Me.colID.Visible = True
            Me.colID.VisibleIndex = 0
            ' 
            ' colAccount
            ' 
            Me.colAccount.FieldName = "Account"
            Me.colAccount.Name = "colAccount"
            Me.colAccount.Visible = True
            Me.colAccount.VisibleIndex = 1
            ' 
            ' colCategory
            ' 
            Me.colCategory.FieldName = "Category"
            Me.colCategory.Name = "colCategory"
            Me.colCategory.Visible = True
            Me.colCategory.VisibleIndex = 2
            ' 
            ' colTransactionType
            ' 
            Me.colTransactionType.FieldName = "TransactionType"
            Me.colTransactionType.Name = "colTransactionType"
            Me.colTransactionType.Visible = True
            Me.colTransactionType.VisibleIndex = 3
            ' 
            ' colTrasactionDate
            ' 
            Me.colTrasactionDate.FieldName = "TrasactionDate"
            Me.colTrasactionDate.Name = "colTrasactionDate"
            Me.colTrasactionDate.Visible = True
            Me.colTrasactionDate.VisibleIndex = 4
            ' 
            ' colAmount
            ' 
            Me.colAmount.FieldName = "Amount"
            Me.colAmount.Name = "colAmount"
            Me.colAmount.Visible = True
            Me.colAmount.VisibleIndex = 5
            ' 
            ' colComment
            ' 
            Me.colComment.FieldName = "Comment"
            Me.colComment.Name = "colComment"
            Me.colComment.Visible = True
            Me.colComment.VisibleIndex = 6
            ' 
            ' MainForm
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(661, 478)
            Me.Controls.Add(Me.transactionsGridControl)
            Me.Icon = (CType(resources.GetObject("$this.Icon"), System.Drawing.Icon))
            Me.Name = "MainForm"
            Me.Text = "ExpenseTracker"
            CType(Me.transactionsGridControl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.transactionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.transactionsGridView, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private transactionsGridControl As DevExpress.XtraGrid.GridControl
        Private transactionsGridView As DevExpress.XtraGrid.Views.Grid.GridView
        Private transactionBindingSource As System.Windows.Forms.BindingSource
        Private colID As DevExpress.XtraGrid.Columns.GridColumn
        Private colAccount As DevExpress.XtraGrid.Columns.GridColumn
        Private colCategory As DevExpress.XtraGrid.Columns.GridColumn
        Private colTransactionType As DevExpress.XtraGrid.Columns.GridColumn
        Private colTrasactionDate As DevExpress.XtraGrid.Columns.GridColumn
        Private colAmount As DevExpress.XtraGrid.Columns.GridColumn
        Private colComment As DevExpress.XtraGrid.Columns.GridColumn

    End Class
End Namespace

