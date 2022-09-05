//using Microsoft.Analytics.Interfaces;
//using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Linq;
using System.Text;

namespace ShoppingApp.Models.Concret
{
    [Table("User")]
    public  class User
    {
        public int ID { get; set; }
       
        public string Name { get; set; }
        public string EMail { get; set; }
       
        public int? Age { get; set; }
        public String Gender { get; set; }
        public Boolean IsBlocked { get; set; }
        public string Password { get; set; }

    } 
}