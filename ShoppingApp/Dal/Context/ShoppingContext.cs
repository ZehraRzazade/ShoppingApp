using ShoppingApp.Models.Concret;
using ShoppingApp.Models.Concret.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Text;

namespace ShoppingApp.Dal.Context
{
  public  class ShoppingContext :DbContext
    {
        public ShoppingContext() : base("Zehra")
        {

        }
        public DbSet<Basket> Basket { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Order> Order { get; set; }

        public DbSet<OrderDetail> OrderDetail { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<UserBalance> UserBalance { get; set; }

    }
}