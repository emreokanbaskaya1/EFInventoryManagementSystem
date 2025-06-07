# EFInventoryManagementSystem

A full-featured Windows Forms inventory management system built with C# and Entity Framework (Database First). The application supports admin login and CRUD operations for categories, products, and customers, along with a colorful dashboard for statistics.

## 🧩 Features

- 🔐 Admin login authentication
- 🗃 Category management (Add / Edit / Delete / List)
- 📦 Product operations (Name, Brand, Stock, Price, Category)
- 📊 Visual statistics dashboard (Total stock, customer stats, top brands etc.)
- 🖥 Simple and clean WinForms interface
- 💾 SQL Server + Entity Framework (Database First)
---
## 🛠 Technologies

- C# (.NET Framework)
- Windows Forms
- Entity Framework 6
- Microsoft SQL Server
---
## 🗄 Database Setup
This project includes a db_create folder that contains separate SQL scripts to create the required tables individually.

### 📁 db_create folder includes:
TBLADMIN.sql

TBLKATEGORI.sql

TBLMUSTERI.sql

TBLSATIS.sql

TBLURUN.sql

### ✅ How to use:
Open SQL Server Management Studio (SSMS).

Open each .sql file inside the db_create folder.

Execute them in the following order to avoid foreign key errors:

TBLKATEGORI.sql

TBLADMIN.sql

TBLURUN.sql

TBLMUSTERI.sql

TBLSATIS.sql

(Optional) You can add sample data inside each file or manually through the application UI.

Finally, make sure your App.config connection string points to the database you've created.

### 💡 This modular structure makes it easy to create or edit tables individually without re-running the whole schema.
---

## 📸 Screenshots

### 🔐 Login Screen
A simple login form that authenticates admin credentials.

![image](https://github.com/user-attachments/assets/212f86f3-5a19-458c-8763-5677605ef427)



### 🧭 Main Menu Navigation
Buttons to access product, category, and statistics sections.

![image](https://github.com/user-attachments/assets/8ea2a985-d1b3-4715-b446-506ea0549251)



### 📦 Product Management
Form to manage product details such as stock, brand, price, and category.

![image](https://github.com/user-attachments/assets/4c4d4ea8-25c1-4fe2-8cb4-3e5fae0f189a)



### 📁 Category Management
Add, update, delete, and list product categories.

![image](https://github.com/user-attachments/assets/ba172a46-88be-4035-98e8-754c4aeccc63)




### 📊 Statistics Dashboard
Colorful dashboard showing total stock, top brands, most/least expensive items, etc.
![image](https://github.com/user-attachments/assets/7f23d19f-664e-4726-a161-b23f5464c565)

