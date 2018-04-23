Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Data.Entity
Imports DataLayer.Data.Classes

Namespace DataLayer.Data
	Public Class XtraGridTutorialDBContext
		Inherits DbContext
		Public Sub New()
			MyBase.New("name=XtraGridTutorialDBConnectionString")
				Me.Configuration.LazyLoadingEnabled = True
		End Sub

		Private privateAccounts As DbSet(Of Account)
		Public Property Accounts() As DbSet(Of Account)
			Get
				Return privateAccounts
			End Get
			Set(ByVal value As DbSet(Of Account))
				privateAccounts = value
			End Set
		End Property
		Private privateCategories As DbSet(Of Category)
		Public Property Categories() As DbSet(Of Category)
			Get
				Return privateCategories
			End Get
			Set(ByVal value As DbSet(Of Category))
				privateCategories = value
			End Set
		End Property
		Private privateTransactions As DbSet(Of Transaction)
		Public Property Transactions() As DbSet(Of Transaction)
			Get
				Return privateTransactions
			End Get
			Set(ByVal value As DbSet(Of Transaction))
				privateTransactions = value
			End Set
		End Property
	End Class
End Namespace
