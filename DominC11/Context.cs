using DominC;
using Microsoft.EntityFrameworkCore;

namespace DominC11
{
    public class Context : DbContext
    {
        //تعريف مجموعة البيانات لكائنات السيارة
        public DbSet<Car> Cars {  get; set; }
        //تعريف مجموعة البيانات لكائنات الزبون
        public DbSet<Customer> Customers { get; set; }
        //تعريف مجموعة البيانات لكائنات القطعة
        public DbSet<Part> Parts { get; set; }
        //تعريف مجموعة البيانات لكائنات المبيعات
        public DbSet<Sale> Sales{ get; set; }
        //تعريف مجموعة البيانات لكائنات المصنع
        public DbSet<Supplier> Suppliers { get; set; }

        // يتم استدعاء هذه الوظيفة عند تكوين السياق المطلوب
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //خيارات الاتصال بقاعدة البيانات  sql server 
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CarStore");
        }



    }
}