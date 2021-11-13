using EE3206_WPF.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EE3206_WPF.Database
{
    class DataBaseRepository:DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
