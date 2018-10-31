Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Collections
Imports System.ComponentModel.DataAnnotations.Schema

Namespace DataLayer.Data.Classes
    Public Class Account
        <DatabaseGenerated(DatabaseGeneratedOption.Identity)> _
        Public Property ID() As Integer
        Public Property AccountName() As String
        Public Property Amount() As Decimal
    End Class
End Namespace
