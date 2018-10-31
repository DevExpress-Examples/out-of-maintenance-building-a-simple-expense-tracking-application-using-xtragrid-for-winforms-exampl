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
            context.Categories.Add(New Category With { _
                .CategoryName = "Entertainment", _
                .TransactionType = TransactionType.Expense _
            })
            context.Categories.Add(New Category With { _
                .CategoryName = "Groceries", _
                .TransactionType = TransactionType.Expense _
            })
            context.Categories.Add(New Category With { _
                .CategoryName = "Automobile Expenses", _
                .TransactionType = TransactionType.Expense _
            })
            context.Categories.Add(New Category With { _
                .CategoryName = "Gifts", _
                .TransactionType = TransactionType.Expense _
            })
            context.Categories.Add(New Category With { _
                .CategoryName = "Loans", _
                .TransactionType = TransactionType.Expense _
            })
            context.Categories.Add(New Category With { _
                .CategoryName = "Phone", _
                .TransactionType = TransactionType.Expense _
            })
            context.Categories.Add(New Category With { _
                .CategoryName = "Taxes", _
                .TransactionType = TransactionType.Expense _
            })
            context.Categories.Add(New Category With { _
                .CategoryName = "Utilities", _
                .TransactionType = TransactionType.Expense _
            })
            context.Categories.Add(New Category With { _
                .CategoryName = "Money Transfer", _
                .TransactionType = TransactionType.Expense _
            })
            context.Categories.Add(New Category With { _
                .CategoryName = "Salary", _
                .TransactionType = TransactionType.Income _
            })
            context.Categories.Add(New Category With { _
                .CategoryName = "Small Business", _
                .TransactionType = TransactionType.Income _
            })
            context.Categories.Add(New Category With { _
                .CategoryName = "Other", _
                .TransactionType = TransactionType.Income _
            })
            context.Categories.Add(New Category With { _
                .CategoryName = "Money Transfer", _
                .TransactionType = TransactionType.Income _
            })
            context.Accounts.Add(New Account With { _
                .AccountName = "Cash", _
                .Amount = rand.Next(1000) _
            })
            context.Accounts.Add(New Account With { _
                .AccountName = "Salary Card", _
                .Amount = rand.Next(5000) _
            })
            context.Accounts.Add(New Account With { _
                .AccountName = "Credit Card", _
                .Amount = rand.Next(5000) _
            })
            context.SaveChanges()

            For Each account As Account In context.Accounts
                For Each category As Category In context.Categories
                    Dim i As Integer = 0
                    Do While i < rand.Next(10)
                        Dim transactionType = If(rand.Next(10) > 5, DataLayer.Data.Classes.TransactionType.Income, DataLayer.Data.Classes.TransactionType.Expense)
                        context.Transactions.Add(New Transaction With { _
                            .Account = account, _
                            .Category = category, _
                            .TransactionType = transactionType, _
                            .Amount = If(transactionType = DataLayer.Data.Classes.TransactionType.Income, rand.Next(10, 1000), rand.Next(-1000, -10)), _
                            .Comment = "Test transaction", _
                            .TrasactionDate = Date.Today.AddDays(-rand.Next(1000)) _
                        })
                        i += 1
                    Loop
                Next category
            Next account

            context.SaveChanges()
        End Sub

    End Class
End Namespace
