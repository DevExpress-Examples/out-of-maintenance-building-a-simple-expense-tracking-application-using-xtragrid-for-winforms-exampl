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

        Public Property Accounts() As DbSet(Of Account)
        Public Property Categories() As DbSet(Of Category)
        Public Property Transactions() As DbSet(Of Transaction)
    End Class
End Namespace
