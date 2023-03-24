using DevFramework.Northwind.DataAccess.Concrete.EntityFramework.Mapping;
using DevFramework.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFramework.Northwind.DataAccess.Concrete.EntityFramework
{
    public class NorthwindContext: DbContext
    {
        public NorthwindContext()
        {
            Database.SetInitializer<NorthwindContext>(null); // Disable initializer because we have already created database. İt is not necessary to create database again.İt prevent to create database again.
        }
        public DbSet<Product> Products { get; set; }
        //public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ProductMap());
            //modelBuilder.Configurations.Add(new CategoryMap());
        }
    }
}
