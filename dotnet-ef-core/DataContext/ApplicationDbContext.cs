using System;
using Microsoft.EntityFrameworkCore;

namespace DotnetEfCore.DataContext
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<CategoryEntity> categories { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;database=ef_db;uid=root;pwd=Agustus97;");
        }
    }
}