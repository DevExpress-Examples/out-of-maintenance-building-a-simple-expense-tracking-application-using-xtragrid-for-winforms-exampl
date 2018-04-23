using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Data.Entity;
using DataLayer.Data;

namespace DataLayer {
    public class UnitOfWork {
        private XtraGridTutorialDBContext context;
        public UnitOfWork() {
            context = new XtraGridTutorialDBContext();
            if (context.Accounts.Count() == 0 && context.Categories.Count() == 0 && context.Transactions.Count() == 0)
            {
                RandomDataGenerator.GenerateRandomData(context);
                context.SaveChanges();
            }
        }

        public void Commit() {
            context.SaveChanges();
        }

        public void ReloadContext() {
            context = new XtraGridTutorialDBContext();
        }

        public BindingList<T> GetData<T>()
            where T: class {
            var table = context.Set<T>();
            table.Load();
            return table.Local.ToBindingList<T>();
        }
    }
}
