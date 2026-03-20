# 🚀 InteractHub API

Backend API cho hệ thống mạng xã hội (InteractHub) sử dụng ASP.NET Core Web API, Entity Framework Core và SQL Server.

---

## 🧱 Công nghệ sử dụng

| Thành phần     | Công nghệ                          |
| -------------- | ---------------------------------- |
| Framework      | ASP.NET Core 8.0                   |
| ORM            | Entity Framework Core 8            |
| Database       | SQL Server                         |
| Authentication | ASP.NET Core Identity + JWT        |
| API Docs       | Swagger (Swashbuckle)              |
| Realtime       | SignalR (dự kiến)                  |
| Architecture   | RESTful API + Repository + Service |

---

## ⚙️ Yêu cầu môi trường

Trước khi chạy project, cần cài:

### 🔹 1. .NET SDK

* **.NET 8 SDK (BẮT BUỘC)**

```bash
dotnet --version
```

---

### 🔹 2. SQL Server

* SQL Server Express / LocalDB / SQL Server full
* SSMS (khuyến nghị)

---

### 🔹 3. Visual Studio Code hoặc Visual Studio

* Cài extension:

  * C#
  * .NET Install Tool

---

## 📦 Packages sử dụng (QUAN TRỌNG)

Cài đúng version để tránh lỗi:

```bash
dotnet add package Microsoft.EntityFrameworkCore --version 8.0.0
dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 8.0.0
dotnet add package Microsoft.EntityFrameworkCore.Design --version 8.0.0

dotnet add package Microsoft.AspNetCore.Identity.EntityFrameworkCore --version 8.0.0

dotnet add package Swashbuckle.AspNetCore --version 6.5.0
```

---

## 🔧 Cấu hình database

Mở file:

```bash
appsettings.json
```

Sửa connection string:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=localhost;Database=InteractHubDb;Trusted_Connection=True;TrustServerCertificate=True"
}
```

---

## 🏗️ Tạo database (Entity Framework)

### 🔹 1. Cài tool EF

```bash
dotnet tool install --global dotnet-ef
```

---

### 🔹 2. Tạo migration

```bash
dotnet ef migrations add InitDb
```

---

### 🔹 3. Update database

```bash
dotnet ef database update
```

---

## ▶️ Chạy project

```bash
dotnet run
```

---

## 🌐 Swagger API

Sau khi chạy:

```
https://localhost:xxxx/swagger
```

---

## 📁 Cấu trúc project

```
InteractHub.API/
│── Controllers/
│── Models/
│── Data/
│── Migrations/
│── Program.cs
│── appsettings.json
```

---

## 🧠 Chức năng chính (Database)

* User (Identity)
* Post
* Comment
* Like
* Friendship
* Story
* Notification
* Hashtag
* PostReport

---

## ⚠️ Lưu ý quan trọng

### ❌ Lỗi thường gặp

#### 1. Multiple cascade paths

👉 Đã fix bằng:

```csharp
OnDelete(DeleteBehavior.Restrict)
```

---

#### 2. Không chạy được EF

👉 Thiếu .NET 8

---

#### 3. Lỗi package version

👉 Phải dùng đúng version 8.0

---

## 🔐 Authentication (đang phát triển)

* JWT Login/Register
* Role-based Authorization

---

## 👨‍💻 Hướng dẫn dev

```bash
git clone <repo>
cd InteractHub.API
dotnet restore
dotnet ef database update
dotnet run
```

---

## 📌 Ghi chú

* Không cần tạo database thủ công
* EF sẽ tự tạo database
* Identity tự tạo bảng user

---

## 💯 Trạng thái

* ✅ Database: DONE
* ✅ Entity + EF: DONE
* 🔜 JWT Auth: Pending
* 🔜 API CRUD: Pending

---

## 🔥 Author

* InteractHub Team
