# Order
CSIT-327 Final Exam

## Instructions
![image](https://github.com/Hans-Emmanuel-Duran/Order/assets/124110957/90d6a053-ab0c-4e8f-8a61-b75e9a58b452)

### Tasks:

Given the ERD above, create a ASP.NET Core Web API with the following Endpoints.

1. Get All Orders (with all attached items)
``` JSON
GET /api/orders

Returns
[
    {
        "id" : 1,
        "orderDate": 05/23/2023
        "orderProcessed": true,
        "items" : [
            {
                "id" : 1,
                "quantity" : 5,
                "name" : "Item1",
                "price" : 25.50
            },
            {
                "id" : 2,
                "quantity" : 2,
                "name" : "Item2",
                "price" : 15.50
            }
        ]
    },
    {
        "id" : 2
        ...
    }
]
```
2. Get Order by Id (with all attached items)
3. Create Order (with items)
  a. At least one item is REQUIRED.
4. Delete Order (delete all attached items -- CASCADE DELETE)
5. Update Order

### MUST: 
[ ] Following Presentation/Business/Data Layer patterns
[ ] Use EF Core and Migrations
[x] Git standards
[ ] C# Documentation

### Remarks:
No final exam, no passing grade.

Good luck!
