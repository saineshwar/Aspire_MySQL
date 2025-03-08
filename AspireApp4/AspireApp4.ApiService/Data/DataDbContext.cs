using AspireApp4.ApiService.Models;
using Microsoft.EntityFrameworkCore;
namespace AspireApp4.ApiService.Data;

public class DataDbContext : DbContext
{
    // Define your constructor here
    public DataDbContext(DbContextOptions<DataDbContext> options) : base(options) { }

    // Define your DbSets (tables) here
    public DbSet<Product> Products { get; set; }

}
    
