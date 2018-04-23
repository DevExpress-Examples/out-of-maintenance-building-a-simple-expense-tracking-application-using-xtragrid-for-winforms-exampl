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

Namespace XtraGridTutorial
	Partial Public Class MainForm
		Inherits XtraForm
		Private uow As UnitOfWork
		Public Sub New()
			InitializeComponent()
			uow = New UnitOfWork()
			SetDataSource()
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
	End Class
End Namespace
