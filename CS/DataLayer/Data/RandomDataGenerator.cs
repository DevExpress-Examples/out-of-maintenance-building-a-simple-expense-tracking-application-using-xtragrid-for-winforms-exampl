using DataLayer.Data.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataLayer.Data
{
    public static class RandomDataGenerator
    {
        public static void GenerateRandomData(XtraGridTutorialDBContext context)
        {
            Random rand = new Random();
            context.Categories.Add(new Category { CategoryName = "Entertainment", TransactionType = TransactionType.Expense });
            context.Categories.Add(new Category { CategoryName = "Groceries", TransactionType = TransactionType.Expense });
            context.Categories.Add(new Category { CategoryName = "Automobile Expenses", TransactionType = TransactionType.Expense });
            context.Categories.Add(new Category { CategoryName = "Gifts", TransactionType = TransactionType.Expense });
            context.Categories.Add(new Category { CategoryName = "Loans", TransactionType = TransactionType.Expense });
            context.Categories.Add(new Category { CategoryName = "Phone", TransactionType = TransactionType.Expense });
            context.Categories.Add(new Category { CategoryName = "Taxes", TransactionType = TransactionType.Expense });
            context.Categories.Add(new Category { CategoryName = "Utilities", TransactionType = TransactionType.Expense });
            context.Categories.Add(new Category { CategoryName = "Money Transfer", TransactionType = TransactionType.Expense });
            context.Categories.Add(new Category { CategoryName = "Salary", TransactionType = TransactionType.Income });
            context.Categories.Add(new Category { CategoryName = "Small Business", TransactionType = TransactionType.Income });
            context.Categories.Add(new Category { CategoryName = "Other", TransactionType = TransactionType.Income });
            context.Categories.Add(new Category { CategoryName = "Money Transfer", TransactionType = TransactionType.Income });
            context.Accounts.Add(new Account { AccountName = "Cash" , Amount = rand.Next(1000) });
            context.Accounts.Add(new Account { AccountName = "Salary Card", Amount = rand.Next(5000) });
            context.Accounts.Add(new Account { AccountName = "Credit Card", Amount = rand.Next(5000) });
            context.SaveChanges();
           
            foreach (Account account in context.Accounts)
                foreach (Category category in context.Categories)
                    for (int i = 0; i < rand.Next(10); i++)
                    {
                        var transactionType = rand.Next(10) > 5 ? TransactionType.Income : TransactionType.Expense;
                        context.Transactions.Add(new Transaction
                        {
                            Account = account,
                            Category = category,
                            TransactionType = transactionType,
                            Amount = (transactionType == TransactionType.Income) ? rand.Next(10, 1000) : rand.Next(-1000, -10),
                            Comment = "Test transaction",
                            TrasactionDate = DateTime.Today.AddDays(-rand.Next(1000))
                        });    
                    }
                    
            context.SaveChanges();
        }

    }
}
