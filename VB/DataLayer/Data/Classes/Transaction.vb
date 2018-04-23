Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.ComponentModel.DataAnnotations.Schema

Namespace DataLayer.Data.Classes
	Public Class Transaction
		Private privateID As Integer
		<DatabaseGenerated(DatabaseGeneratedOption.Identity)> _
		Public Property ID() As Integer
			Get
				Return privateID
			End Get
			Set(ByVal value As Integer)
				privateID = value
			End Set
		End Property
		Private privateAccount As Account
		Public Overridable Property Account() As Account
			Get
				Return privateAccount
			End Get
			Set(ByVal value As Account)
				privateAccount = value
			End Set
		End Property
		Private privateCategory As Category
		Public Overridable Property Category() As Category
			Get
				Return privateCategory
			End Get
			Set(ByVal value As Category)
				privateCategory = value
			End Set
		End Property
		<NotMapped> _
		Public Property TransactionType() As TransactionType
			Get
				Return CType(TransactionTypeId, TransactionType)
			End Get
			Set(ByVal value As TransactionType)
				TransactionTypeId = CInt(Fix(value))
			End Set
		End Property
		Private privateTransactionTypeId As Integer
		Public Property TransactionTypeId() As Integer
			Get
				Return privateTransactionTypeId
			End Get
			Set(ByVal value As Integer)
				privateTransactionTypeId = value
			End Set
		End Property
		Private privateTrasactionDate As DateTime
		Public Property TrasactionDate() As DateTime
			Get
				Return privateTrasactionDate
			End Get
			Set(ByVal value As DateTime)
				privateTrasactionDate = value
			End Set
		End Property
		Private privateAmount As Decimal
		Public Property Amount() As Decimal
			Get
				Return privateAmount
			End Get
			Set(ByVal value As Decimal)
				privateAmount = value
			End Set
		End Property
		Private privateComment As String
		Public Property Comment() As String
			Get
				Return privateComment
			End Get
			Set(ByVal value As String)
				privateComment = value
			End Set
		End Property
	End Class
End Namespace
