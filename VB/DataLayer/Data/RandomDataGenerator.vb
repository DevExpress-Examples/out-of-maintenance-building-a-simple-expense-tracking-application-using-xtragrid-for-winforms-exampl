Imports Microsoft.VisualBasic
Imports DataLayer.Data.Classes
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Namespace DataLayer.Data
	Public NotInheritable Class RandomDataGenerator
		Private Sub New()
		End Sub
		Public Shared Sub GenerateRandomData(ByVal context As XtraGridTutorialDBContext)
			Dim rand As New Random()
			context.Categories.Add(New Category With {.CategoryName = "Entertainment", .TransactionType = TransactionType.Expense})
			context.Categories.Add(New Category With {.CategoryName = "Groceries", .TransactionType = TransactionType.Expense})
			context.Categories.Add(New Category With {.CategoryName = "Automobile Expenses", .TransactionType = TransactionType.Expense})
			context.Categories.Add(New Category With {.CategoryName = "Gifts", .TransactionType = TransactionType.Expense})
			context.Categories.Add(New Category With {.CategoryName = "Loans", .TransactionType = TransactionType.Expense})
			context.Categories.Add(New Category With {.CategoryName = "Phone", .TransactionType = TransactionType.Expense})
			context.Categories.Add(New Category With {.CategoryName = "Taxes", .TransactionType = TransactionType.Expense})
			context.Categories.Add(New Category With {.CategoryName = "Utilities", .TransactionType = TransactionType.Expense})
			context.Categories.Add(New Category With {.CategoryName = "Money Transfer", .TransactionType = TransactionType.Expense})
			context.Categories.Add(New Category With {.CategoryName = "Salary", .TransactionType = TransactionType.Income})
			context.Categories.Add(New Category With {.CategoryName = "Small Business", .TransactionType = TransactionType.Income})
			context.Categories.Add(New Category With {.CategoryName = "Other", .TransactionType = TransactionType.Income})
			context.Categories.Add(New Category With {.CategoryName = "Money Transfer", .TransactionType = TransactionType.Income})
			context.Accounts.Add(New Account With {.AccountName = "Cash", .Amount = rand.Next(1000)})
			context.Accounts.Add(New Account With {.AccountName = "Salary Card", .Amount = rand.Next(5000)})
			context.Accounts.Add(New Account With {.AccountName = "Credit Card", .Amount = rand.Next(5000)})
			context.SaveChanges()

			For Each account As Account In context.Accounts
				For Each category As Category In context.Categories
					For i As Integer = 0 To rand.Next(10) - 1
                        Dim operationTransactionType = If(rand.Next(10) > 5, TransactionType.Income, TransactionType.Expense)
                        context.Transactions.Add(New Transaction With {.Account = account, .Category = category, .TransactionType = operationTransactionType, .Amount = If((operationTransactionType = TransactionType.Income), rand.Next(10, 1000), rand.Next(-1000, -10)), .Comment = "Test transaction", .TrasactionDate = DateTime.Today.AddDays(-rand.Next(1000))})
					Next i
				Next category
			Next account

			context.SaveChanges()
		End Sub

	End Class
End Namespace
