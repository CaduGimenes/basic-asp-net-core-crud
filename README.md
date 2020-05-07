# Basic ASP NET Core 3.x CRUD 

<a href="https://github.com/CaduGimenes/basic-asp-net-core-crud/blob/master/LICENSE">
<img  alt="License: MIT"  src="https://img.shields.io/badge/License-MIT-yellow.svg" target="_blank" />
</a>

This project aims to perform the four basic operations necessary to build a system (CRUD), using **.NET Core 3.x** and **EntityFrameworkCore.**

![enter image description here](https://i.ibb.co/Kzx6kqw/Screenshot-2020-05-07-Index-Basic-Crud.png)

## Requirements

 - Visual Studio >= 2017
 - .NET Core 3.x
 - SQL Server

## Database connection

To change the Connection String, you need to change the **appsettings.json** file, located at:

├── BasicCrud 
│ ├── appsettings.json

In **appsettings.json** update "MyConnection" value with your database connection string.

    "ConnectionStrings": {
	    "MyConnection": "Server=Server_Name;Database=Database_Name;User Id=User_ID;Password=User_Password;"
    }

## License

 This project is under license [MIT](https://github.com/CaduGimenes/vendas/blob/master/LICENSE).



```
