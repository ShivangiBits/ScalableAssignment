using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSPurchaseRecordService.Models
{
    public class PurchaseRecord
    {
        [Key]
        public Guid PurchaseId { get; set; }
        public int CustomerId { get; set; }
        public int Amount { get; set; }
        public DateOnly PurchaseDate { get; set; }
        public int EmployeeId { get; set; }
        public List<Purchase_Detail> Purchase_Details { get; set; }=new List<Purchase_Detail>();
        
    }
}
