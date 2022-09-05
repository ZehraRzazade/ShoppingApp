using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingApp.Models.Concret.Dto
{
    public class ProductBasketDto
    {
        public int Id { get; set; }
        public string Name  { get; set; }
        public int Count { get; set; }
        public int Price { get; set; }

    }

}