using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DataLayer;
using System.Diagnostics;
using DevExpress.XtraEditors;
using DataLayer.Data.Classes;
using DevExpress.Utils;
using DevExpress.XtraEditors.Repository;

namespace XtraGridTutorial {
    public partial class MainForm : XtraForm {
        private UnitOfWork uow;
        public MainForm()
        {
            InitializeComponent();
            uow = new UnitOfWork();
            SetDataSource();
            InitControls();
        }

        private void barButtonSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            uow.Commit();
        }

        private void barButtonReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            uow.ReloadContext();
            SetDataSource();
        }

        private void SetDataSource()
        {
            accountBindingSource.DataSource = uow.GetData<Account>();
            categoryBindingSource.DataSource = uow.GetData<Category>();
            transactionBindingSource.DataSource = uow.GetData<Transaction>();
        }
        private void InitControls()
        {
            InitImageComboBox(repositoryItemImageComboBox1);
            InitImageComboBox(repositoryItemImageComboBox2);
        }

        private void InitImageComboBox(RepositoryItemImageComboBox item)
        {
            item.Items.AddEnum(typeof(TransactionType));
            for (int i = 0; i < item.Items.Count; i++)
            {
                item.Items[i].ImageIndex = i;
            }
        }

        private void transactionsGridView_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            Transaction row = (Transaction)e.Row;
            transactionsGridView.ClearColumnErrors();
            if (row.TrasactionDate != null && row.TrasactionDate > DateTime.Today)
            {
                e.Valid = false;
                transactionsGridView.SetColumnError(colTrasactionDate, ValidationErrorStringsHelper.GetDateErrorMessage(colTrasactionDate.GetCaption()));
            }
            if (row.Account == null)
            {
                e.Valid = false;
                transactionsGridView.SetColumnError(colAccount, ValidationErrorStringsHelper.GetAccountErrorMessage(colAccount.GetCaption()));
            }
        }

        private void transactionsGridView_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
        }
    }
}
