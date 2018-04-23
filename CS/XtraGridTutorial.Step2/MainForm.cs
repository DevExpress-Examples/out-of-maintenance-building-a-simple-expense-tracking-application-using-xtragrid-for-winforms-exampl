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

namespace XtraGridTutorial {
    public partial class MainForm : XtraForm {
        private UnitOfWork uow;
        public MainForm()
        {
            InitializeComponent();
            uow = new UnitOfWork();
            SetDataSource();
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
    }
}
