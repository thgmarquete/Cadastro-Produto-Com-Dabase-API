using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models
{
    public class Context : DbContext
    {
        public DbSet<Category>Categorias{get; set;}
        public DbSet<Product>Produtos{get; set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: @"Data Source=NPNBTMARQUETE\SQLEXPRESS;Database=Web;User ID=sa;Password=spnsw2002;Integrated Security=True");
        }

    }
}
