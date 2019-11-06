using Microsoft.EntityFrameworkCore;
using WebApi.API.Models;


namespace WebApi.API.Data
{
    public class DataContext : DbContext 
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options)
        {
            
        }
        public DbSet<Value> Values  { get; set; }
    }
}