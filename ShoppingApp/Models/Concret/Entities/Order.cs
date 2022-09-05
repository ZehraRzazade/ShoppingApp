//using Microsoft.Analytics.Interfaces;
//using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Linq;
using System.Text;

namespace ShoppingApp.Models.Concret
{
    [Table("Orders")]
    public  class Order
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime Date{ get; set; }
        public Decimal TotalPrice { get; set; }
        public int Count { get; set; }  
    }
}