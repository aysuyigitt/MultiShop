using Microsoft.EntityFrameworkCore;
using MultiShop.Cargo.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.Cargo.DataAccessLayer.Concrete
{
    public class CargoContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=localhost,1441;initial Catalog=MultiShopCargoDb;Uid=sa;Pwd=123456bB*;TrustServerCertificate=True;");
        }
        public DbSet<CargoCompany> CargoCompany { get; set; }

        public DbSet<CargoDetail> CargoDetail { get; set; }

        public DbSet<CargoCustomer> CargoCustomers { get; set; }

        public DbSet<CargoOperation> CargoOperations { get; set; }
       

    }
}
