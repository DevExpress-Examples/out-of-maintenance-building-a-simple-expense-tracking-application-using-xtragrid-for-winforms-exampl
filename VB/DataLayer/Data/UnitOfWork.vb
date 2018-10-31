Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.ComponentModel
Imports System.Collections.ObjectModel
Imports System.Data.Entity
Imports DataLayer.Data

Namespace DataLayer
    Public Class UnitOfWork
        Private context As XtraGridTutorialDBContext
        Public Sub New()
            context = New XtraGridTutorialDBContext()
            If context.Accounts.Count() = 0 AndAlso context.Categories.Count() = 0 AndAlso context.Transactions.Count() = 0 Then
                RandomDataGenerator.GenerateRandomData(context)
                context.SaveChanges()
            End If
        End Sub

        Public Sub Commit()
            context.SaveChanges()
        End Sub

        Public Sub ReloadContext()
            context = New XtraGridTutorialDBContext()
        End Sub

        Public Function GetData(Of T As Class)() As BindingList(Of T)
            Dim table = context.Set(Of T)()
            table.Load()
            Return table.Local.ToBindingList(Of T)()
        End Function
    End Class
End Namespace
