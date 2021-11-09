using dotnet_ef_marvel.src.Entities;
using Microsoft.EntityFrameworkCore;
using src.Entities;

namespace src.Context {
    public class DataContext : DbContext {
        public DataContext() { }
        public DataContext(DbContextOptions<DataContext> options) : base (options) {}
        public DbSet<Hero> Heroes {get;set;}
        public DbSet<Group> Groups{get;set;}
    }
}