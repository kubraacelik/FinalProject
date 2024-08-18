# FinalProject
It is a comprehensive C# application developed using the layered architecture approach. This project offers a flexible and scalable structure using modern software development principles and best practices.

## Entities: 
This layer deals with the underlying data structures and entities of the application. Classes such as Product, Category, Order, and Customer are defined here. It also contains data transfer objects (DTOs) such as ProductDetailDto, UserForLoginDto, and UserForRegisterDto.

## DataAccess: 
Database access and operations are performed in this layer. Data access interfaces such as ICategoryDal, IProductDal, IOrderDal, ICustomerDal, and IUserDal and applications using the Entity Framework are located here.

## Business: 
This is the layer that manages business logic and business rules. Classes such as ProductManager, CategoryManager manage business processes and contain various validation rules (such as ProductValidator). In addition, this layer contains features such as SecuredOperation, which manages security and authorization.

## WebAPI: 
Providing the API endpoints of the application, this layer contains controllers such as ProductsController and manages HTTP requests.

## Core: 
Core functionality and common components reside in this layer. Constructs such as ServiceCollectionExtensions, ClaimsPrincipalExtensions, and AutofacBusinessModule provide dependency management, security, and other core functionality.

This layered architecture makes the process of developing a powerful business application more manageable and sustainable. Each layer has a specific area of responsibility and contributes to the overall success of the project.

![Ekran görüntüsü 2024-08-16 174540](https://github.com/user-attachments/assets/11f51e18-2c63-4a4e-8ba8-c91a4623fa62)
![Ekran görüntüsü 2024-08-16 174548](https://github.com/user-attachments/assets/653b3cd4-412f-4e28-937d-9668dcb38df8)

![Ekran görüntüsü 2024-08-16 181552](https://github.com/user-attachments/assets/50ba12b9-8b13-4bbf-a601-85d25049f138)
![Ekran görüntüsü 2024-08-16 181556](https://github.com/user-attachments/assets/f31aff53-fd84-47fe-b44a-f0f8b73b1ad5)

![Ekran görüntüsü 2024-08-16 182501](https://github.com/user-attachments/assets/8e1c1885-31fa-4084-91a5-81df26eb3bed)
![Ekran görüntüsü 2024-08-16 182506](https://github.com/user-attachments/assets/30f5ac11-e610-4b56-bae2-b9060dc961a4)
![Ekran görüntüsü 2024-08-16 182658](https://github.com/user-attachments/assets/fc7302e0-f3d2-4b56-899c-8a987b238b7e)
