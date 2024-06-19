using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2M1.DB
{
    public class MyContext : DbContext
    {
        private string cs = "server = 192.168.0.100; database = T2M1; user id = T2M1; password = T2M1; trustservercertificate = true";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(cs);
        }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<Buyer> Buyers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Products_list> Products_lists { get; set; }
        public DbSet<Сlient> Clients { get; set; }
    }
}
