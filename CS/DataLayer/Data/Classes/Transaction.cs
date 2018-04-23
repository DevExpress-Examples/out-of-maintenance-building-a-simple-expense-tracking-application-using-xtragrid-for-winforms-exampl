using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer.Data.Classes
{
    public class Transaction {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public virtual Account Account { get; set; }
        public virtual Category Category { get; set; }
        [NotMapped]
        public TransactionType TransactionType { get { return (TransactionType)TransactionTypeId; } set { TransactionTypeId = (int)value; } }
        public int TransactionTypeId { get; set; }
        public DateTime TrasactionDate { get; set; }
        public decimal Amount { get; set; }
        public string Comment { get; set; }
    }
}
