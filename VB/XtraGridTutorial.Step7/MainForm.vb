Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DataLayer
Imports System.Diagnostics
Imports DevExpress.XtraEditors
Imports DataLayer.Data.Classes
Imports DevExpress.Utils
Imports DevExpress.XtraEditors.Repository

Namespace XtraGridTutorial
	Partial Public Class MainForm
		Inherits XtraForm
		Private uow As UnitOfWork
		Public Sub New()
			InitializeComponent()
			uow = New UnitOfWork()
			SetDataSource()
			InitControls()
		End Sub

		Private Sub barButtonSave_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles barButtonSave.ItemClick
			uow.Commit()
		End Sub

		Private Sub barButtonReload_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles barButtonReload.ItemClick
			uow.ReloadContext()
			SetDataSource()
		End Sub

		Private Sub SetDataSource()
			accountBindingSource.DataSource = uow.GetData(Of Account)()
			categoryBindingSource.DataSource = uow.GetData(Of Category)()
			transactionBindingSource.DataSource = uow.GetData(Of Transaction)()
		End Sub
		Private Sub InitControls()
			InitImageComboBox(repositoryItemImageComboBox1)
			InitImageComboBox(repositoryItemImageComboBox2)
		End Sub

		Private Sub InitImageComboBox(ByVal item As RepositoryItemImageComboBox)
			item.Items.AddEnum(GetType(TransactionType))
			For i As Integer = 0 To item.Items.Count - 1
				item.Items(i).ImageIndex = i
			Next i
		End Sub

		Private Sub transactionsGridView_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles transactionsGridView.ValidateRow
			Dim row As Transaction = CType(e.Row, Transaction)
			transactionsGridView.ClearColumnErrors()
            If row.TrasactionDate > DateTime.Today Then
                e.Valid = False
                transactionsGridView.SetColumnError(colTrasactionDate, ValidationErrorStringsHelper.GetDateErrorMessage(colTrasactionDate.GetCaption()))
            End If
			If row.Account Is Nothing Then
				e.Valid = False
				transactionsGridView.SetColumnError(colAccount, ValidationErrorStringsHelper.GetAccountErrorMessage(colAccount.GetCaption()))
			End If
		End Sub

		Private Sub transactionsGridView_InvalidRowException(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles transactionsGridView.InvalidRowException
			e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
		End Sub

		Private Sub barButtonItem1_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles barButtonItem1.ItemClick
			transactionsGridControl.ShowPrintPreview()
		End Sub
	End Class
End Namespace
