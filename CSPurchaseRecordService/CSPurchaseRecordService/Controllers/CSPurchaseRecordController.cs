using CSPurchaseRecordService.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace CSPurchaseRecordService.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class CSPurchaseRecordController : ControllerBase
    {
        private readonly CustomerPurchaseDBContext _dbContext;
        public CSPurchaseRecordController(CustomerPurchaseDBContext dBContext)
        {
            this._dbContext = dBContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetPurchaseRecord()
        {
            try
            {
                List<PurchaseRecord> pr = new List<PurchaseRecord>();
                foreach (PurchaseRecord purchase in _dbContext.PurchaseRecord)
                {
                    List<Purchase_Detail> pd = new List<Purchase_Detail>();
                    pd = _dbContext.Purchase_Details.Where(pd => pd.PurchaseId == purchase.PurchaseId).ToList();
                    purchase.Purchase_Details = pd;
                    pr.Add(purchase);
                }
                return Ok(pr);
            }
            catch(Exception ex)
            {
                return Ok("no data found");
            }
           
        }

        [HttpGet("purchaseId")]
        public async Task<IActionResult> GetPurchaseRecordById(Guid purchaseId)
        {
            try
            {
                PurchaseRecord pr = new PurchaseRecord();
                pr = _dbContext.PurchaseRecord.FirstOrDefault(pd => pd.PurchaseId == purchaseId);
                List<Purchase_Detail> pd = new List<Purchase_Detail>();
                pd = _dbContext.Purchase_Details.Where(pd => pd.PurchaseId == purchaseId).ToList();
                pr.Purchase_Details = pd;
                return Ok(pr);
            }
            catch (Exception ex)
            {
                return Ok("no matched data found");
            }
        }
        [HttpPost]
        public async Task<IActionResult> AddPurchaseRecord(PurchaseRecord obj)
        {
            try
            {
                PurchaseRecord purchaseRecord = new PurchaseRecord();
                purchaseRecord.PurchaseId = Guid.NewGuid();
                purchaseRecord.CustomerId = obj.CustomerId;
                purchaseRecord.PurchaseDate = obj.PurchaseDate;
                purchaseRecord.EmployeeId = obj.EmployeeId;
                purchaseRecord.Amount = 0;
                foreach (Purchase_Detail purchase_Detail in obj.Purchase_Details)
                {
                    purchaseRecord.Amount += purchase_Detail.Rate * purchase_Detail.Quantity;
                    Purchase_Detail pd = new Purchase_Detail();
                    pd.Purchase_DetailId = Guid.NewGuid();
                    pd.ProductId = purchase_Detail.ProductId;
                    pd.Quantity = purchase_Detail.Quantity;
                    pd.PurchaseId = purchaseRecord.PurchaseId;
                    pd.Rate = purchase_Detail.Rate;
                    purchaseRecord.Purchase_Details.Add(pd);
                    _dbContext.Purchase_Details.Add(pd);
                    _dbContext.SaveChanges();
                }
                _dbContext.PurchaseRecord.Add(purchaseRecord);
                _dbContext.SaveChanges();

                return Ok(purchaseRecord);
            }
            catch (Exception ex)
            {
                return Ok("unable to save data; please try again");
            }
 

        }
    }
}
