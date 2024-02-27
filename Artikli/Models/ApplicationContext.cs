using Artikli.Models;
using System.Data.Entity;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext() : base("DefaultConnection")
    {
    }

    public DbSet<Artikal> Artikli { get; set; }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Artikal>().ToTable("Artikli");
    }
}