# ScalableAssignment
For Scalable Assignment bits
Customer Purchase record service which is having 3 endpoints as below; it uses in memory database
# Customer Purchase Record Microservice
The Customer Purchase Record Microservice is a component of our modern e-commerce system built on .NET Core 7. This microservice plays a crucial role in managing customer purchase records, capturing purchase details, and efficiently calculating the total amount to be paid for each transaction. It's designed to provide a seamless and responsive experience for our customers and streamline our internal operations.

# Key Features
## 1. Purchase Data Storage
### Purchase Details: 
The microservice captures and stores comprehensive purchase details for each transaction. This includes information such as the customer's identity, purchase items, quantities, and transaction timestamps.

### Itemization: 
It meticulously records individual items within a purchase, making it easy to retrieve and analyze specific product information.

## 2. Real-time Calculation
Total Amount Calculation: One of the microservice's core functionalities is real-time calculation of the total amount to be paid. It takes into account the purchase items and their respective quantities.

Pricing Flexibility: Our system is designed to accommodate different pricing strategies, such as dynamic pricing, discounts, and promotions, and applies them to the calculation process.

## 3. Performance Optimization
### Efficiency: 
The microservice is optimized for performance. It uses asynchronous processing and caching to ensure that the total amount is calculated quickly, even during high transaction loads.

### Scalability: 
It's designed to scale horizontally to handle an increasing number of customer transactions without compromising performance.

## 4. Data Security
### Data Protection: 
Purchase records contain sensitive customer and financial information. The microservice employs robust security measures to protect this data, including encryption and access controls.

### Compliance: 
It adheres to data protection regulations and security best practices to maintain customer trust and ensure compliance.

## How It Works
### Purchase Recording: 
When a customer completes a purchase, the microservice receives the purchase details, including the items selected and their quantities.

### Total Amount Calculation: 
The microservice immediately calculates the total amount to be paid based on the purchase items and their associated pricing.

### Data Storage: 
The purchase details, along with the calculated total amount, are securely stored in the database, creating a comprehensive record of the transaction.

### Technology Stack
### Programming Language: .NET Core 7
### Database: IN memory database for example

# Benefits
## Improved Customer Experience: 
Real-time total amount calculation provides transparency and convenience to our customers.

## Operational Efficiency: 
Our team gains insights into customer purchase behavior, helping us make data-driven decisions.

## Scalability: 
The microservice grows with our business, accommodating increasing customer transactions.

The Customer Purchase Record Microservice is a fundamental component of our e-commerce system, empowering us to efficiently manage customer purchases, calculate total amounts, and enhance the overall shopping experience. It's a testament to our commitment to innovation and customer satisfaction.


Feel free to customize this content to suit your specific microservice implementation and business requirements.
<img width="927" alt="image" src="https://github.com/ShivangiBits/ScalableAssignment/assets/143605784/e4e603a7-0b5b-44b9-a489-139d69d4a4d1">

# Execution Instruction
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
2. To fetch data by purchase Id **/api/CSPurchaseRecord/purchaseId**
   
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
3. To Add purchase record **/api/CSPurchaseRecord**
   
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
