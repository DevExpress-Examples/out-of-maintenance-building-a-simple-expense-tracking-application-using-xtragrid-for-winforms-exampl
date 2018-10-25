namespace XtraGridTutorial {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.transactionsGridControl = new DevExpress.XtraGrid.GridControl();
            this.transactionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transactionsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAccount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCategory = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransactionType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTrasactionDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colComment = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // transactionsGridControl
            // 
            this.transactionsGridControl.DataSource = this.transactionBindingSource;
            this.transactionsGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.transactionsGridControl.Location = new System.Drawing.Point(0, 0);
            this.transactionsGridControl.MainView = this.transactionsGridView;
            this.transactionsGridControl.Name = "transactionsGridControl";
            this.transactionsGridControl.Size = new System.Drawing.Size(661, 478);
            this.transactionsGridControl.TabIndex = 0;
            this.transactionsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.transactionsGridView});
            // 
            // transactionBindingSource
            // 
            this.transactionBindingSource.DataSource = typeof(DataLayer.Data.Classes.Transaction);
            // 
            // transactionsGridView
            // 
            this.transactionsGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colAccount,
            this.colCategory,
            this.colTransactionType,
            this.colTrasactionDate,
            this.colAmount,
            this.colComment});
            this.transactionsGridView.GridControl = this.transactionsGridControl;
            this.transactionsGridView.Name = "transactionsGridView";
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            // 
            // colAccount
            // 
            this.colAccount.FieldName = "Account";
            this.colAccount.Name = "colAccount";
            this.colAccount.Visible = true;
            this.colAccount.VisibleIndex = 1;
            // 
            // colCategory
            // 
            this.colCategory.FieldName = "Category";
            this.colCategory.Name = "colCategory";
            this.colCategory.Visible = true;
            this.colCategory.VisibleIndex = 2;
            // 
            // colTransactionType
            // 
            this.colTransactionType.FieldName = "TransactionType";
            this.colTransactionType.Name = "colTransactionType";
            this.colTransactionType.Visible = true;
            this.colTransactionType.VisibleIndex = 3;
            // 
            // colTrasactionDate
            // 
            this.colTrasactionDate.FieldName = "TrasactionDate";
            this.colTrasactionDate.Name = "colTrasactionDate";
            this.colTrasactionDate.Visible = true;
            this.colTrasactionDate.VisibleIndex = 4;
            // 
            // colAmount
            // 
            this.colAmount.FieldName = "Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.Visible = true;
            this.colAmount.VisibleIndex = 5;
            // 
            // colComment
            // 
            this.colComment.FieldName = "Comment";
            this.colComment.Name = "colComment";
            this.colComment.Visible = true;
            this.colComment.VisibleIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 478);
            this.Controls.Add(this.transactionsGridControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "ExpenseTracker";
            ((System.ComponentModel.ISupportInitialize)(this.transactionsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl transactionsGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView transactionsGridView;
        private System.Windows.Forms.BindingSource transactionBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colAccount;
        private DevExpress.XtraGrid.Columns.GridColumn colCategory;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionType;
        private DevExpress.XtraGrid.Columns.GridColumn colTrasactionDate;
        private DevExpress.XtraGrid.Columns.GridColumn colAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colComment;

    }
}

