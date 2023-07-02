using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.EntityFrameworkCore;
using Microsoft.Practices.EnterpriseLibrary.Data;
using static System.Net.Mime.MediaTypeNames;

namespace AZMigrationPortal.Models.ContextClass
{
    public class MigrationContext:DbContext
    {
        public MigrationContext(DbContextOptions<MigrationContext> options) : base(options)
        {

        }
        public DbSet<ApplicationDetails> Applications { get; set; }
        public DbSet<ServerInformation> Servers { get; set; }
        public DbSet<StorageInformation> Storages { get; set; }
        public DbSet<DatabaseInformation> Databases { get; set; }
        public DbSet<PortDetails> Ports { get; set; }

        public DbSet<User>users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>();

            modelBuilder.Entity<ApplicationDetails>();
                //.HasOne(a => a.Server)
                //.WithMany(s => s.Applications)
                //.HasForeignKey(a => a.ApplicationId)
                //.OnDelete(DeleteBehavior.NoAction);



            modelBuilder.Entity<ServerInformation>();
                
            modelBuilder.Entity<StorageInformation>();

            modelBuilder.Entity<DatabaseInformation>();

            modelBuilder.Entity<PortDetails>();
                //.HasOne(p => p.Server)
                //.WithMany(s => s.Ports)
                //.HasForeignKey(p => p.ServerId);

        }
    }
}
