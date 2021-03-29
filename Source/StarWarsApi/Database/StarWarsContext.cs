using Microsoft.EntityFrameworkCore;
using StarWarsApi.Models;

namespace StarWarsApi.Database
{
    public class StarWarsContext : DbContext
    {
        public string ConnectionString;
        public DbSet<SpaceShip> SpaceShips { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Receipt> Receipts { get; set; }
        public DbSet<User.Homeworld> Homeworlds { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsbuilder)
        {
            //hard code connectionstring in onconfiguring method when migrating
            ConnectionString = @"Server = 0.0.0.0,0; Database = StarWarsProjectLive; User Id = adminuser; Password = xxxx"; // this should be a secrect, and not be pushed to git
            optionsbuilder.UseSqlServer(ConnectionString);
        }
    }
}