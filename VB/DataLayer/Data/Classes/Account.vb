Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Collections
Imports System.ComponentModel.DataAnnotations.Schema

Namespace DataLayer.Data.Classes
	Public Class Account
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
		Private privateAccountName As String
		Public Property AccountName() As String
			Get
				Return privateAccountName
			End Get
			Set(ByVal value As String)
				privateAccountName = value
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
	End Class
End Namespace
