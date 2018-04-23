using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer.Data.Classes
{
    public class Category {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string CategoryName { get; set; }
        [NotMapped]
        public TransactionType TransactionType { get { return (TransactionType)TransactionTypeId; } set { TransactionTypeId = (int)value; } }
        public int TransactionTypeId { get; set; }
        public string Description { get; set; }
    }
}
