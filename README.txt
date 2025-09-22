
# AgriEnergy Connect - ASP.NET Core MVC Application

AgriEnergy Connect is a role-based web application designed to support sustainable agriculture and green energy practices. Built with ASP.NET Core MVC and Entity Framework Core, it provides a platform for farmers and administrators to manage agricultural products effectively.

## Features

### User Authentication and Roles
- Integrated with ASP.NET Core Identity
- Two roles: Admin and Farmer
- Role-based access control

### Product Management
- Farmers can create products with the following fields:
  - Name
  - Type (Vegetables, Grains, Livestock)
  - Description
  - Price
  - Date
- Admins can view all products and delete any entry

### Filtering
- Admins can filter products by product type

### Profile Management
- Farmers are represented through ProfileModel entries
- Profiles include display name, email, password, and role

## Technology Stack

- ASP.NET Core MVC
- Entity Framework Core (Code First)
- SQL Server / LocalDB
- Bootstrap 5 (with Bootswatch themes)
- Razor Views
- ASP.NET Identity

## Database Models

### ProductModel
- ProductId (int)
- ProductName (string)
- ProductType (string)
- ProductDescription (string)
- ProductPrice (decimal)
- ProfileType (DateTime used as date field)

### ProfileModel
- ProfileId (int)
- UserName (string)
- Email (string)
- Password (string)
- Role (string)

## Role Permissions

| Action                  | Admin | Farmer |
|-------------------------|:-----:|:------:|
| Register & Login        | Yes   | Yes    |
| View Products           | Yes   | Yes    |
| Filter Products         | Yes   | No     |
| Create Products         | No    | Yes    |
| Delete Products         | Yes   | No     |
| View Farmer Profiles    | Yes   | No     |

## Setup Instructions

### Prerequisites
- .NET 6 SDK or later
- SQL Server or LocalDB
- Visual Studio 2022+ or Visual Studio Code

### Steps to Run Locally

1. Clone the repository:

```
git clone https://github.com/your-username/AgriEnergyConnect.git
cd AgriEnergyConnect
```

2. Update the database:

```
update-database
```

3. Run the application:

```
press the green start button and it will load to your default browser
```


## Admin Login

To test the Admin experience, make sure to select the admin role when registering an account

## Usage Instructions

- New users can register using the registration page
- Registered users are assigned the Farmer role by default
- Farmers can create and manage their own products
- Admins can:
  - View all products
  - Filter by product type
  - Delete any product
  - View farmer profiles


## License

This project is licensed under the MIT License.
