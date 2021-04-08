using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using avicomTestChallange.models;


namespace avicomTestChallange
{
    class ApplicationContext : DbContext
    {

        public DbSet<Manager> Managers;
        public DbSet<Client> Clients;
        public DbSet<Product> Products;
        public DbSet<BuyedProduct> BuyedProducts;

        public ApplicationContext() : base("DefaultConnection") { }
    }
}
