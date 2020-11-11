
using Microsoft.EntityFrameworkCore;

namespace WCC.Shared
{
    public class WCCCustomerServiceData : DbContext 
    {
        public DbSet<ASC_SignpostingSummary> ASC_SignpostingSummarys { get; set; }
        public DbSet<udv_LastYearsSignpostingSummary> udv_LastYearsSignpostingSummarys { get; set; }

        public WCCCustomerServiceData(DbContextOptions<WCCCustomerServiceData> options) : base(options) { }

        protected override void OnModelCreating( ModelBuilder modelBuilder) 
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ASC_SignpostingSummary>() 
                .Property(s => s.Id)
                .IsRequired();

            modelBuilder.Entity<udv_LastYearsSignpostingSummary>() 
                .Property(s => s.Id)
                .IsRequired();

        }
/**/
    }
}
