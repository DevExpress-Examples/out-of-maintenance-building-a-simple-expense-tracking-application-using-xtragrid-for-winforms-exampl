using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer.Data.Classes
{
    public class Account {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string AccountName { get; set; }
        public decimal Amount { get; set; }
    }
}
