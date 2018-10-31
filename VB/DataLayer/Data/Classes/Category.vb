Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.ComponentModel.DataAnnotations.Schema

Namespace DataLayer.Data.Classes
    Public Class Category
        <DatabaseGenerated(DatabaseGeneratedOption.Identity)> _
        Public Property ID() As Integer
        Public Property CategoryName() As String
        <NotMapped> _
        Public Property TransactionType() As TransactionType
            Get
                Return CType(TransactionTypeId, TransactionType)
            End Get
            Set(ByVal value As TransactionType)
                TransactionTypeId = CInt(value)
            End Set
        End Property
        Public Property TransactionTypeId() As Integer
        Public Property Description() As String
    End Class
End Namespace
