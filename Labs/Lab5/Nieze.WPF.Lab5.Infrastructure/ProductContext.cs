using Microsoft.EntityFrameworkCore;
using Nieze.WPF.Labs.Lab5.Domain;

namespace Nieze.WPF.Lab5.Infrastructure;

public class ProductContext : DbContext
{

    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }

    public DbSet<SubCategory> SubCategorys { get; set; }

    protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite(
            "Data Source=products.db");
    }
}
