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
    [Table("OrderDetails")]
    public  class OrderDetail
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int BasketId { get; set; }  
    }
}