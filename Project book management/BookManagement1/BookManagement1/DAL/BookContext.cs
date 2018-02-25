using System;
using System.Data.Entity;
using BookManagement1.Areas.Admin.Models;
using BookManagement1.Models;
using BookManagement1.Areas.Admin.Models.Database;

namespace BookManagement1.DAL
{
    public class BookContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<BillOrder> BillOrders { get; set; }

        public DbSet<OrderDetail> OrderDetails { get; set; }

        public DbSet<Book> Books { get; set; }

        public DbSet<Topic> Topics { get; set; }

        public DbSet<Author> Authors { get; set; }

        public DbSet<Production> Productions { get; set; }

        public DbSet<Categolory> Categolorys { get; set; }

        //public DbSet<CategoloryBook> CategoloryBooks { get; set; }

        //many to many categolory & book
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            try
            {
                modelBuilder.Entity<Categolory>().HasMany<Book>(c => c.Books).
                WithMany(b => b.Categolorys).
                Map(m => { m.MapLeftKey("CategoloryID"); m.MapRightKey("BookID"); m.ToTable("CategoloryBook"); });

            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}