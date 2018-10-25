using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using DataLayer.Data.Classes;

namespace DataLayer.Data
{
    public class XtraGridTutorialDBContext : DbContext {
        public XtraGridTutorialDBContext()
            : base("name=XtraGridTutorialDBConnectionString") {
                this.Configuration.LazyLoadingEnabled = true; 
        }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
    }
}
