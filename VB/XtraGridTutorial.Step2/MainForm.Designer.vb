Imports Microsoft.VisualBasic
Imports System
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
			Me.transactionsGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colAccount = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colCategory = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colTransactionType = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colTrasactionDate = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colAmount = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colComment = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.transactionsGridControl = New DevExpress.XtraGrid.GridControl()
			Me.transactionBindingSource = New System.Windows.Forms.BindingSource()
			Me.xtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
			Me.xtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
			Me.xtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
			Me.accountsGridControl = New DevExpress.XtraGrid.GridControl()
			Me.accountBindingSource = New System.Windows.Forms.BindingSource()
			Me.accountsGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.colID1 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colAccountName = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colAmount1 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.xtraTabPage3 = New DevExpress.XtraTab.XtraTabPage()
			Me.gridControl2 = New DevExpress.XtraGrid.GridControl()
			Me.categoryBindingSource = New System.Windows.Forms.BindingSource()
			Me.gridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.colID2 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colCategoryName = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colTransactionType1 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colDescription = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.barManager1 = New DevExpress.XtraBars.BarManager()
			Me.bar2 = New DevExpress.XtraBars.Bar()
			Me.barButtonSave = New DevExpress.XtraBars.BarButtonItem()
			Me.barButtonReload = New DevExpress.XtraBars.BarButtonItem()
			Me.bar3 = New DevExpress.XtraBars.Bar()
			Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
			CType(Me.transactionsGridView, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.transactionsGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.transactionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.xtraTabControl1.SuspendLayout()
			Me.xtraTabPage1.SuspendLayout()
			Me.xtraTabPage2.SuspendLayout()
			CType(Me.accountsGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.accountBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.accountsGridView, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.xtraTabPage3.SuspendLayout()
			CType(Me.gridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.categoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.barManager1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
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
			' transactionsGridControl
			' 
			Me.transactionsGridControl.DataSource = Me.transactionBindingSource
			Me.transactionsGridControl.Dock = System.Windows.Forms.DockStyle.Fill
			Me.transactionsGridControl.Location = New System.Drawing.Point(0, 0)
			Me.transactionsGridControl.MainView = Me.transactionsGridView
			Me.transactionsGridControl.Name = "transactionsGridControl"
			Me.transactionsGridControl.Size = New System.Drawing.Size(635, 414)
			Me.transactionsGridControl.TabIndex = 1
			Me.transactionsGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.transactionsGridView})
			' 
			' transactionBindingSource
			' 
			Me.transactionBindingSource.DataSource = GetType(DataLayer.Data.Classes.Transaction)
			' 
			' xtraTabControl1
			' 
			Me.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.xtraTabControl1.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Left
			Me.xtraTabControl1.Location = New System.Drawing.Point(0, 40)
			Me.xtraTabControl1.Name = "xtraTabControl1"
			Me.xtraTabControl1.SelectedTabPage = Me.xtraTabPage1
			Me.xtraTabControl1.Size = New System.Drawing.Size(661, 416)
			Me.xtraTabControl1.TabIndex = 2
			Me.xtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() { Me.xtraTabPage1, Me.xtraTabPage2, Me.xtraTabPage3})
			' 
			' xtraTabPage1
			' 
			Me.xtraTabPage1.Controls.Add(Me.transactionsGridControl)
			Me.xtraTabPage1.Name = "xtraTabPage1"
			Me.xtraTabPage1.Size = New System.Drawing.Size(635, 414)
			Me.xtraTabPage1.Text = "Transactions"
			' 
			' xtraTabPage2
			' 
			Me.xtraTabPage2.Controls.Add(Me.accountsGridControl)
			Me.xtraTabPage2.Name = "xtraTabPage2"
			Me.xtraTabPage2.Size = New System.Drawing.Size(632, 409)
			Me.xtraTabPage2.Text = "Accounts"
			' 
			' accountsGridControl
			' 
			Me.accountsGridControl.DataSource = Me.accountBindingSource
			Me.accountsGridControl.Dock = System.Windows.Forms.DockStyle.Fill
			Me.accountsGridControl.Location = New System.Drawing.Point(0, 0)
			Me.accountsGridControl.MainView = Me.accountsGridView
			Me.accountsGridControl.Name = "accountsGridControl"
			Me.accountsGridControl.Size = New System.Drawing.Size(632, 409)
			Me.accountsGridControl.TabIndex = 0
			Me.accountsGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.accountsGridView})
			' 
			' accountBindingSource
			' 
			Me.accountBindingSource.DataSource = GetType(DataLayer.Data.Classes.Account)
			' 
			' accountsGridView
			' 
			Me.accountsGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colID1, Me.colAccountName, Me.colAmount1})
			Me.accountsGridView.GridControl = Me.accountsGridControl
			Me.accountsGridView.Name = "accountsGridView"
			' 
			' colID1
			' 
			Me.colID1.FieldName = "ID"
			Me.colID1.Name = "colID1"
			Me.colID1.Visible = True
			Me.colID1.VisibleIndex = 0
			' 
			' colAccountName
			' 
			Me.colAccountName.FieldName = "AccountName"
			Me.colAccountName.Name = "colAccountName"
			Me.colAccountName.Visible = True
			Me.colAccountName.VisibleIndex = 1
			' 
			' colAmount1
			' 
			Me.colAmount1.FieldName = "Amount"
			Me.colAmount1.Name = "colAmount1"
			Me.colAmount1.Visible = True
			Me.colAmount1.VisibleIndex = 2
			' 
			' xtraTabPage3
			' 
			Me.xtraTabPage3.Controls.Add(Me.gridControl2)
			Me.xtraTabPage3.Name = "xtraTabPage3"
			Me.xtraTabPage3.Size = New System.Drawing.Size(632, 409)
			Me.xtraTabPage3.Text = "Categories"
			' 
			' gridControl2
			' 
			Me.gridControl2.DataSource = Me.categoryBindingSource
			Me.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridControl2.Location = New System.Drawing.Point(0, 0)
			Me.gridControl2.MainView = Me.gridView2
			Me.gridControl2.Name = "gridControl2"
			Me.gridControl2.Size = New System.Drawing.Size(632, 409)
			Me.gridControl2.TabIndex = 1
			Me.gridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView2})
			' 
			' categoryBindingSource
			' 
			Me.categoryBindingSource.DataSource = GetType(DataLayer.Data.Classes.Category)
			' 
			' gridView2
			' 
			Me.gridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colID2, Me.colCategoryName, Me.colTransactionType1, Me.colDescription})
			Me.gridView2.GridControl = Me.gridControl2
			Me.gridView2.Name = "gridView2"
			' 
			' colID2
			' 
			Me.colID2.FieldName = "ID"
			Me.colID2.Name = "colID2"
			Me.colID2.Visible = True
			Me.colID2.VisibleIndex = 0
			' 
			' colCategoryName
			' 
			Me.colCategoryName.FieldName = "CategoryName"
			Me.colCategoryName.Name = "colCategoryName"
			Me.colCategoryName.Visible = True
			Me.colCategoryName.VisibleIndex = 1
			' 
			' colTransactionType1
			' 
			Me.colTransactionType1.FieldName = "TransactionType"
			Me.colTransactionType1.Name = "colTransactionType1"
			Me.colTransactionType1.Visible = True
			Me.colTransactionType1.VisibleIndex = 2
			' 
			' colDescription
			' 
			Me.colDescription.FieldName = "Description"
			Me.colDescription.Name = "colDescription"
			Me.colDescription.Visible = True
			Me.colDescription.VisibleIndex = 3
			' 
			' barManager1
			' 
			Me.barManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() { Me.bar2, Me.bar3})
			Me.barManager1.DockControls.Add(Me.barDockControlTop)
			Me.barManager1.DockControls.Add(Me.barDockControlBottom)
			Me.barManager1.DockControls.Add(Me.barDockControlLeft)
			Me.barManager1.DockControls.Add(Me.barDockControlRight)
			Me.barManager1.Form = Me
			Me.barManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.barButtonSave, Me.barButtonReload})
			Me.barManager1.MainMenu = Me.bar2
			Me.barManager1.MaxItemId = 2
			Me.barManager1.StatusBar = Me.bar3
			' 
			' bar2
			' 
			Me.bar2.BarName = "Main menu"
			Me.bar2.DockCol = 0
			Me.bar2.DockRow = 0
			Me.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
			Me.bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonSave), New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonReload)})
			Me.bar2.OptionsBar.MultiLine = True
			Me.bar2.OptionsBar.UseWholeRow = True
			Me.bar2.Text = "Main menu"
			' 
			' barButtonSave
			' 
			Me.barButtonSave.Caption = "Save"
			Me.barButtonSave.Glyph = (CType(resources.GetObject("barButtonSave.Glyph"), System.Drawing.Image))
			Me.barButtonSave.Id = 0
			Me.barButtonSave.Name = "barButtonSave"
			Me.barButtonSave.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
'			Me.barButtonSave.ItemClick += New DevExpress.XtraBars.ItemClickEventHandler(Me.barButtonSave_ItemClick);
			' 
			' barButtonReload
			' 
			Me.barButtonReload.Caption = "Reload"
			Me.barButtonReload.Glyph = (CType(resources.GetObject("barButtonReload.Glyph"), System.Drawing.Image))
			Me.barButtonReload.Id = 1
			Me.barButtonReload.Name = "barButtonReload"
			Me.barButtonReload.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
'			Me.barButtonReload.ItemClick += New DevExpress.XtraBars.ItemClickEventHandler(Me.barButtonReload_ItemClick);
			' 
			' bar3
			' 
			Me.bar3.BarName = "Status bar"
			Me.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
			Me.bar3.DockCol = 0
			Me.bar3.DockRow = 0
			Me.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
			Me.bar3.OptionsBar.AllowQuickCustomization = False
			Me.bar3.OptionsBar.DrawDragBorder = False
			Me.bar3.OptionsBar.UseWholeRow = True
			Me.bar3.Text = "Status bar"
			' 
			' barDockControlTop
			' 
			Me.barDockControlTop.CausesValidation = False
			Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
			Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
			Me.barDockControlTop.Size = New System.Drawing.Size(661, 40)
			' 
			' barDockControlBottom
			' 
			Me.barDockControlBottom.CausesValidation = False
			Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.barDockControlBottom.Location = New System.Drawing.Point(0, 456)
			Me.barDockControlBottom.Size = New System.Drawing.Size(661, 22)
			' 
			' barDockControlLeft
			' 
			Me.barDockControlLeft.CausesValidation = False
			Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
			Me.barDockControlLeft.Location = New System.Drawing.Point(0, 40)
			Me.barDockControlLeft.Size = New System.Drawing.Size(0, 416)
			' 
			' barDockControlRight
			' 
			Me.barDockControlRight.CausesValidation = False
			Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
			Me.barDockControlRight.Location = New System.Drawing.Point(661, 40)
			Me.barDockControlRight.Size = New System.Drawing.Size(0, 416)
			' 
			' MainForm
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(661, 478)
			Me.Controls.Add(Me.xtraTabControl1)
			Me.Controls.Add(Me.barDockControlLeft)
			Me.Controls.Add(Me.barDockControlRight)
			Me.Controls.Add(Me.barDockControlBottom)
			Me.Controls.Add(Me.barDockControlTop)
			Me.Icon = (CType(resources.GetObject("$this.Icon"), System.Drawing.Icon))
			Me.Name = "MainForm"
			Me.Text = "ExpenseTracker"
			CType(Me.transactionsGridView, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.transactionsGridControl, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.transactionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.xtraTabControl1.ResumeLayout(False)
			Me.xtraTabPage1.ResumeLayout(False)
			Me.xtraTabPage2.ResumeLayout(False)
			CType(Me.accountsGridControl, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.accountBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.accountsGridView, System.ComponentModel.ISupportInitialize).EndInit()
			Me.xtraTabPage3.ResumeLayout(False)
			CType(Me.gridControl2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.categoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.barManager1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private transactionsGridView As DevExpress.XtraGrid.Views.Grid.GridView
		Private transactionsGridControl As DevExpress.XtraGrid.GridControl
		Private transactionBindingSource As System.Windows.Forms.BindingSource
		Private xtraTabControl1 As DevExpress.XtraTab.XtraTabControl
		Private xtraTabPage1 As DevExpress.XtraTab.XtraTabPage
		Private xtraTabPage2 As DevExpress.XtraTab.XtraTabPage
		Private xtraTabPage3 As DevExpress.XtraTab.XtraTabPage
		Private accountsGridControl As DevExpress.XtraGrid.GridControl
		Private accountsGridView As DevExpress.XtraGrid.Views.Grid.GridView
		Private gridControl2 As DevExpress.XtraGrid.GridControl
		Private gridView2 As DevExpress.XtraGrid.Views.Grid.GridView
		Private accountBindingSource As System.Windows.Forms.BindingSource
		Private categoryBindingSource As System.Windows.Forms.BindingSource
		Private barManager1 As DevExpress.XtraBars.BarManager
		Private bar2 As DevExpress.XtraBars.Bar
		Private WithEvents barButtonSave As DevExpress.XtraBars.BarButtonItem
		Private WithEvents barButtonReload As DevExpress.XtraBars.BarButtonItem
		Private bar3 As DevExpress.XtraBars.Bar
		Private barDockControlTop As DevExpress.XtraBars.BarDockControl
		Private barDockControlBottom As DevExpress.XtraBars.BarDockControl
		Private barDockControlLeft As DevExpress.XtraBars.BarDockControl
		Private barDockControlRight As DevExpress.XtraBars.BarDockControl
		Private colID As DevExpress.XtraGrid.Columns.GridColumn
		Private colAccount As DevExpress.XtraGrid.Columns.GridColumn
		Private colCategory As DevExpress.XtraGrid.Columns.GridColumn
		Private colTransactionType As DevExpress.XtraGrid.Columns.GridColumn
		Private colTrasactionDate As DevExpress.XtraGrid.Columns.GridColumn
		Private colAmount As DevExpress.XtraGrid.Columns.GridColumn
		Private colComment As DevExpress.XtraGrid.Columns.GridColumn
		Private colID1 As DevExpress.XtraGrid.Columns.GridColumn
		Private colAccountName As DevExpress.XtraGrid.Columns.GridColumn
		Private colAmount1 As DevExpress.XtraGrid.Columns.GridColumn
		Private colID2 As DevExpress.XtraGrid.Columns.GridColumn
		Private colCategoryName As DevExpress.XtraGrid.Columns.GridColumn
		Private colTransactionType1 As DevExpress.XtraGrid.Columns.GridColumn
		Private colDescription As DevExpress.XtraGrid.Columns.GridColumn

	End Class
End Namespace

