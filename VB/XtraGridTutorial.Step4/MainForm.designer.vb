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
            Me.repositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
            Me.accountBindingSource = New System.Windows.Forms.BindingSource()
            Me.colCategory = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
            Me.categoryBindingSource = New System.Windows.Forms.BindingSource()
            Me.colTransactionType = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemImageComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
            Me.imageCollection1 = New DevExpress.Utils.ImageCollection()
            Me.colTrasactionDate = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAmount = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
            Me.colComment = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemMemoExEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit()
            Me.transactionsGridControl = New DevExpress.XtraGrid.GridControl()
            Me.transactionBindingSource = New System.Windows.Forms.BindingSource()
            Me.xtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
            Me.xtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
            Me.xtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
            Me.accountsGridControl = New DevExpress.XtraGrid.GridControl()
            Me.accountsGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colID1 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAccountName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAmount1 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
            Me.xtraTabPage3 = New DevExpress.XtraTab.XtraTabPage()
            Me.categoriesGridControl = New DevExpress.XtraGrid.GridControl()
            Me.categoriesGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colID2 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCategoryName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colTransactionType1 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemImageComboBox2 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
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
            CType(Me.repositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.accountBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.categoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.imageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.transactionsGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.transactionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.xtraTabControl1.SuspendLayout()
            Me.xtraTabPage1.SuspendLayout()
            Me.xtraTabPage2.SuspendLayout()
            CType(Me.accountsGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.accountsGridView, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.xtraTabPage3.SuspendLayout()
            CType(Me.categoriesGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.categoriesGridView, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemImageComboBox2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.barManager1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' transactionsGridView
            ' 
            Me.transactionsGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colID, Me.colAccount, Me.colCategory, Me.colTransactionType, Me.colTrasactionDate, Me.colAmount, Me.colComment})
            Me.transactionsGridView.GridControl = Me.transactionsGridControl
            Me.transactionsGridView.Name = "transactionsGridView"
            Me.transactionsGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
            ' 
            ' colID
            ' 
            Me.colID.FieldName = "ID"
            Me.colID.Name = "colID"
            ' 
            ' colAccount
            ' 
            Me.colAccount.ColumnEdit = Me.repositoryItemLookUpEdit1
            Me.colAccount.FieldName = "Account"
            Me.colAccount.Name = "colAccount"
            Me.colAccount.Visible = True
            Me.colAccount.VisibleIndex = 0
            ' 
            ' repositoryItemLookUpEdit1
            ' 
            Me.repositoryItemLookUpEdit1.AutoHeight = False
            Me.repositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemLookUpEdit1.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() { New DevExpress.XtraEditors.Controls.LookUpColumnInfo("AccountName", "Name")})
            Me.repositoryItemLookUpEdit1.DataSource = Me.accountBindingSource
            Me.repositoryItemLookUpEdit1.DisplayMember = "AccountName"
            Me.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1"
            Me.repositoryItemLookUpEdit1.NullText = "[Account not selected]"
            ' 
            ' accountBindingSource
            ' 
            Me.accountBindingSource.DataSource = GetType(DataLayer.Data.Classes.Account)
            ' 
            ' colCategory
            ' 
            Me.colCategory.ColumnEdit = Me.repositoryItemLookUpEdit2
            Me.colCategory.FieldName = "Category"
            Me.colCategory.Name = "colCategory"
            Me.colCategory.Visible = True
            Me.colCategory.VisibleIndex = 1
            ' 
            ' repositoryItemLookUpEdit2
            ' 
            Me.repositoryItemLookUpEdit2.AutoHeight = False
            Me.repositoryItemLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemLookUpEdit2.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() { New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CategoryName", "Name")})
            Me.repositoryItemLookUpEdit2.DataSource = Me.categoryBindingSource
            Me.repositoryItemLookUpEdit2.DisplayMember = "CategoryName"
            Me.repositoryItemLookUpEdit2.Name = "repositoryItemLookUpEdit2"
            Me.repositoryItemLookUpEdit2.NullText = "[Category not selected]"
            ' 
            ' categoryBindingSource
            ' 
            Me.categoryBindingSource.DataSource = GetType(DataLayer.Data.Classes.Category)
            ' 
            ' colTransactionType
            ' 
            Me.colTransactionType.ColumnEdit = Me.repositoryItemImageComboBox1
            Me.colTransactionType.FieldName = "TransactionType"
            Me.colTransactionType.Name = "colTransactionType"
            Me.colTransactionType.Visible = True
            Me.colTransactionType.VisibleIndex = 2
            ' 
            ' repositoryItemImageComboBox1
            ' 
            Me.repositoryItemImageComboBox1.AutoHeight = False
            Me.repositoryItemImageComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1"
            Me.repositoryItemImageComboBox1.SmallImages = Me.imageCollection1
            ' 
            ' imageCollection1
            ' 
            Me.imageCollection1.ImageStream = (CType(resources.GetObject("imageCollection1.ImageStream"), DevExpress.Utils.ImageCollectionStreamer))
            Me.imageCollection1.InsertGalleryImage("remove_16x16.png", "images/actions/remove_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/remove_16x16.png"), 0)
            Me.imageCollection1.Images.SetKeyName(0, "remove_16x16.png")
            Me.imageCollection1.InsertGalleryImage("add_16x16.png", "images/actions/add_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/add_16x16.png"), 1)
            Me.imageCollection1.Images.SetKeyName(1, "add_16x16.png")
            ' 
            ' colTrasactionDate
            ' 
            Me.colTrasactionDate.FieldName = "TrasactionDate"
            Me.colTrasactionDate.Name = "colTrasactionDate"
            Me.colTrasactionDate.Visible = True
            Me.colTrasactionDate.VisibleIndex = 3
            ' 
            ' colAmount
            ' 
            Me.colAmount.ColumnEdit = Me.repositoryItemSpinEdit1
            Me.colAmount.FieldName = "Amount"
            Me.colAmount.Name = "colAmount"
            Me.colAmount.Visible = True
            Me.colAmount.VisibleIndex = 4
            ' 
            ' repositoryItemSpinEdit1
            ' 
            Me.repositoryItemSpinEdit1.AutoHeight = False
            Me.repositoryItemSpinEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemSpinEdit1.Mask.EditMask = "c0"
            Me.repositoryItemSpinEdit1.Mask.UseMaskAsDisplayFormat = True
            Me.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1"
            ' 
            ' colComment
            ' 
            Me.colComment.ColumnEdit = Me.repositoryItemMemoExEdit1
            Me.colComment.FieldName = "Comment"
            Me.colComment.Name = "colComment"
            Me.colComment.Visible = True
            Me.colComment.VisibleIndex = 5
            ' 
            ' repositoryItemMemoExEdit1
            ' 
            Me.repositoryItemMemoExEdit1.AutoHeight = False
            Me.repositoryItemMemoExEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemMemoExEdit1.Name = "repositoryItemMemoExEdit1"
            Me.repositoryItemMemoExEdit1.ShowIcon = False
            ' 
            ' transactionsGridControl
            ' 
            Me.transactionsGridControl.DataSource = Me.transactionBindingSource
            Me.transactionsGridControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.transactionsGridControl.Location = New System.Drawing.Point(0, 0)
            Me.transactionsGridControl.MainView = Me.transactionsGridView
            Me.transactionsGridControl.Name = "transactionsGridControl"
            Me.transactionsGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemLookUpEdit1, Me.repositoryItemLookUpEdit2, Me.repositoryItemImageComboBox1, Me.repositoryItemSpinEdit1, Me.repositoryItemMemoExEdit1})
            Me.transactionsGridControl.Size = New System.Drawing.Size(635, 414)
            Me.transactionsGridControl.TabIndex = 1
            Me.transactionsGridControl.UseEmbeddedNavigator = True
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
            Me.accountsGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemTextEdit1})
            Me.accountsGridControl.Size = New System.Drawing.Size(632, 409)
            Me.accountsGridControl.TabIndex = 0
            Me.accountsGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.accountsGridView})
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
            ' 
            ' colAccountName
            ' 
            Me.colAccountName.FieldName = "AccountName"
            Me.colAccountName.Name = "colAccountName"
            Me.colAccountName.Visible = True
            Me.colAccountName.VisibleIndex = 0
            ' 
            ' colAmount1
            ' 
            Me.colAmount1.ColumnEdit = Me.repositoryItemTextEdit1
            Me.colAmount1.FieldName = "Amount"
            Me.colAmount1.Name = "colAmount1"
            Me.colAmount1.Visible = True
            Me.colAmount1.VisibleIndex = 1
            ' 
            ' repositoryItemTextEdit1
            ' 
            Me.repositoryItemTextEdit1.AutoHeight = False
            Me.repositoryItemTextEdit1.Mask.EditMask = "c"
            Me.repositoryItemTextEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
            Me.repositoryItemTextEdit1.Mask.UseMaskAsDisplayFormat = True
            Me.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1"
            ' 
            ' xtraTabPage3
            ' 
            Me.xtraTabPage3.Controls.Add(Me.categoriesGridControl)
            Me.xtraTabPage3.Name = "xtraTabPage3"
            Me.xtraTabPage3.Size = New System.Drawing.Size(632, 409)
            Me.xtraTabPage3.Text = "Categories"
            ' 
            ' categoriesGridControl
            ' 
            Me.categoriesGridControl.DataSource = Me.categoryBindingSource
            Me.categoriesGridControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.categoriesGridControl.Location = New System.Drawing.Point(0, 0)
            Me.categoriesGridControl.MainView = Me.categoriesGridView
            Me.categoriesGridControl.Name = "categoriesGridControl"
            Me.categoriesGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemImageComboBox2})
            Me.categoriesGridControl.Size = New System.Drawing.Size(632, 409)
            Me.categoriesGridControl.TabIndex = 1
            Me.categoriesGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.categoriesGridView})
            ' 
            ' categoriesGridView
            ' 
            Me.categoriesGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colID2, Me.colCategoryName, Me.colTransactionType1, Me.colDescription})
            Me.categoriesGridView.GridControl = Me.categoriesGridControl
            Me.categoriesGridView.Name = "categoriesGridView"
            ' 
            ' colID2
            ' 
            Me.colID2.FieldName = "ID"
            Me.colID2.Name = "colID2"
            ' 
            ' colCategoryName
            ' 
            Me.colCategoryName.FieldName = "CategoryName"
            Me.colCategoryName.Name = "colCategoryName"
            Me.colCategoryName.Visible = True
            Me.colCategoryName.VisibleIndex = 0
            ' 
            ' colTransactionType1
            ' 
            Me.colTransactionType1.ColumnEdit = Me.repositoryItemImageComboBox2
            Me.colTransactionType1.FieldName = "TransactionType"
            Me.colTransactionType1.Name = "colTransactionType1"
            Me.colTransactionType1.Visible = True
            Me.colTransactionType1.VisibleIndex = 1
            ' 
            ' repositoryItemImageComboBox2
            ' 
            Me.repositoryItemImageComboBox2.AutoHeight = False
            Me.repositoryItemImageComboBox2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemImageComboBox2.Name = "repositoryItemImageComboBox2"
            Me.repositoryItemImageComboBox2.SmallImages = Me.imageCollection1
            ' 
            ' colDescription
            ' 
            Me.colDescription.FieldName = "Description"
            Me.colDescription.Name = "colDescription"
            Me.colDescription.Visible = True
            Me.colDescription.VisibleIndex = 2
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
            Me.bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonSave), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonReload) _
            })
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
            ' 
            ' barButtonReload
            ' 
            Me.barButtonReload.Caption = "Reload"
            Me.barButtonReload.Glyph = (CType(resources.GetObject("barButtonReload.Glyph"), System.Drawing.Image))
            Me.barButtonReload.Id = 1
            Me.barButtonReload.Name = "barButtonReload"
            Me.barButtonReload.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
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
            CType(Me.repositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.accountBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.categoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.imageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.transactionsGridControl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.transactionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.xtraTabControl1.ResumeLayout(False)
            Me.xtraTabPage1.ResumeLayout(False)
            Me.xtraTabPage2.ResumeLayout(False)
            CType(Me.accountsGridControl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.accountsGridView, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.xtraTabPage3.ResumeLayout(False)
            CType(Me.categoriesGridControl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.categoriesGridView, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemImageComboBox2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.barManager1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private WithEvents transactionsGridView As DevExpress.XtraGrid.Views.Grid.GridView
        Private transactionsGridControl As DevExpress.XtraGrid.GridControl
        Private transactionBindingSource As System.Windows.Forms.BindingSource
        Private xtraTabControl1 As DevExpress.XtraTab.XtraTabControl
        Private xtraTabPage1 As DevExpress.XtraTab.XtraTabPage
        Private xtraTabPage2 As DevExpress.XtraTab.XtraTabPage
        Private xtraTabPage3 As DevExpress.XtraTab.XtraTabPage
        Private accountsGridControl As DevExpress.XtraGrid.GridControl
        Private accountsGridView As DevExpress.XtraGrid.Views.Grid.GridView
        Private categoriesGridControl As DevExpress.XtraGrid.GridControl
        Private categoriesGridView As DevExpress.XtraGrid.Views.Grid.GridView
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
        Private repositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Private repositoryItemLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Private repositoryItemImageComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
        Private imageCollection1 As DevExpress.Utils.ImageCollection
        Private repositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
        Private repositoryItemMemoExEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
        Private repositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Private repositoryItemImageComboBox2 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox

    End Class
End Namespace

