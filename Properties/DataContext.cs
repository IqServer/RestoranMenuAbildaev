using Microsoft.EntityFrameworkCore;
using models;

namespace testnet
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }
        public DbSet<Place>? Places { get; set; }
        public DbSet<Bludo>? Bludos { get; set; }
        public DbSet<Zakaz>? Zakazs { get; set; }
        


       
        public void  CreateBDNew()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //модификация таблиц в бд
        }

    }


}