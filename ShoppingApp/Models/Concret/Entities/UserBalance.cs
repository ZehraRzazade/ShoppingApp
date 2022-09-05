using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ShoppingApp.Models.Concret.Entities
{

    [Table("UserBalance")]
    public class UserBalance
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int Balance { get; set; }

    }
}