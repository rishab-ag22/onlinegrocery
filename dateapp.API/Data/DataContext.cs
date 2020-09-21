using dateapp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace dateapp.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){}

        public DbSet<Values> Values { get; set; }
                
    }
}