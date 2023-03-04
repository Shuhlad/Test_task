using Microsoft.EntityFrameworkCore;

namespace MVCApplication.Models.Data;

public class MainContext : DbContext
{
    public DbSet<Item> Items { get; set; }

    public MainContext(DbContextOptions options) : base(options)
    {}
}