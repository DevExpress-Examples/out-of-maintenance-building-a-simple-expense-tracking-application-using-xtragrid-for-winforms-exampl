Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.ComponentModel.DataAnnotations.Schema

Namespace DataLayer.Data.Classes
	Public Class Category
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
		Private privateCategoryName As String
		Public Property CategoryName() As String
			Get
				Return privateCategoryName
			End Get
			Set(ByVal value As String)
				privateCategoryName = value
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
		Private privateDescription As String
		Public Property Description() As String
			Get
				Return privateDescription
			End Get
			Set(ByVal value As String)
				privateDescription = value
			End Set
		End Property
	End Class
End Namespace
