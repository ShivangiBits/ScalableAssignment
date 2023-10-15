using Microsoft.EntityFrameworkCore;  
  
namespace CSPurchaseRecordService.Models
{
    public class CustomerPurchaseDBContext : DbContext
    {
        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase(databaseName: "CustomerPurchaseRecord");
        }
       
        public DbSet<PurchaseRecord> PurchaseRecord { get; set; }
        public DbSet<Purchase_Detail> Purchase_Details { get; set; }
    }
}