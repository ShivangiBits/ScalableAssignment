# ScalableAssignment
For Scalable Assignment bits
Customer Purchase record service which is having 3 endpoints as below; it uses in memory database
<img width="927" alt="image" src="https://github.com/ShivangiBits/ScalableAssignment/assets/143605784/e4e603a7-0b5b-44b9-a489-139d69d4a4d1">

1. To fetch data **/api/CSPurchaseRecord**
returns in below format:
```json
	{
	  "purchaseId": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
	  "customerId": 0,
	  "amount": 0,
	  "purchaseDate": "2023-10-15",
	  "employeeId": 0,
	  "purchase_Details": [
	    {
	      "purchase_DetailId": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
	      "purchaseId": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
	      "productId": 0,
	      "quantity": 0,
	      "rate": 0
	    }
	  ]
	}
```
3. To fetch data by purchase Id **/api/CSPurchaseRecord/purchaseId**
pass purchaseId as paramater
returns in below format:
```json
	{
	  "purchaseId": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
	  "customerId": 0,
	  "amount": 0,
	  "purchaseDate": "2023-10-15",
	  "employeeId": 0,
	  "purchase_Details": [
	    {
	      "purchase_DetailId": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
	      "purchaseId": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
	      "productId": 0,
	      "quantity": 0,
	      "rate": 0
	    }
	  ]
	}
```
4. To Add purchase record **/api/CSPurchaseRecord**
It required parameter as Json request in below format
```json
	{
	  "customerId": 2,
	  "purchaseDate": "2023-10-14",
	  "employeeId": 12,
	  "purchase_Details": [
	    {
	      "productId": 1233,
	      "quantity": 1,
	      "rate": 14
	    },
		{
	      "productId": 34,
	      "quantity": 3,
	      "rate": 123
	    }
	  ]
	}
```
and returns
```json
{
    "purchaseId": "2013c966-ec7f-428a-87c7-8fb21ddd9000",
    "customerId": 2,
    "amount": 383,
    "purchaseDate": "2023-10-14",
    "employeeId": 12,
    "purchase_Details": [
        {
            "purchase_DetailId": "3abd1f6f-4b7a-4bab-9021-691737b0d280",
            "purchaseId": "2013c966-ec7f-428a-87c7-8fb21ddd9000",
            "productId": 1233,
            "quantity": 1,
            "rate": 14
        },
        {
            "purchase_DetailId": "6da306df-3cbd-48c9-98cc-83ca1c974358",
            "purchaseId": "2013c966-ec7f-428a-87c7-8fb21ddd9000",
            "productId": 34,
            "quantity": 3,
            "rate": 123
        }
    ]
}
```
