using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace CSPurchaseRecordService.Models
{
    public class Purchase_Detail
    {   
        [Key]  
        public Guid Purchase_DetailId { get; set; }
        public Guid PurchaseId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public int Rate { get; set; }
    }
}
