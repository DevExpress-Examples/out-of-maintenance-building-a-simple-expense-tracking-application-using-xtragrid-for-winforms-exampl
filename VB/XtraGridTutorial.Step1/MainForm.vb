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
			transactionBindingSource.DataSource = uow.GetData(Of Transaction)()

		End Sub
	End Class
End Namespace
