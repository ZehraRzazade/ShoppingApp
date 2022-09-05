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
    [Table("Basket")]
    public  class Basket
    {

        public int Id { get; set; }
        public int UserId { get; set; }
        public int ProductId { get; set; }
        public Boolean IsDeleted { get; set; }
        public Boolean IsOrder { get; set; }
        public int Count { get; set; }

    }
}