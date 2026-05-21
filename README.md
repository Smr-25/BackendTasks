# BackendTasks — Enterprise Backend Learning Portfolio

<p align="center">
  <img alt=".NET" src="https://img.shields.io/badge/.NET-8.0-512BD4?logo=.net&logoColor=white" />
  <img alt="ASP.NET Core" src="https://img.shields.io/badge/ASP.NET%20Core-512BD4?logo=dotnet&logoColor=white" />
  <img alt="EF Core" src="https://img.shields.io/badge/EF%20Core-512BD4?logo=dotnet&logoColor=white" />
  <img alt="MS SQL" src="https://img.shields.io/badge/Microsoft%20SQL%20Server-CC2927?logo=microsoftsqlserver&logoColor=white" />
  <img alt="PostgreSQL" src="https://img.shields.io/badge/PostgreSQL-336791?logo=postgresql&logoColor=white" />
  <img alt="JWT" src="https://img.shields.io/badge/JWT-000000?logo=jsonwebtokens&logoColor=white" />
  <img alt="Swagger" src="https://img.shields.io/badge/Swagger-85EA2D?logo=swagger&logoColor=111111" />
</p>

---

## 🎯 Məqsəd
Bu repository akademiyada keçdiyim **Backend dərsləri, praktiki tapşırıqlar və ev işlərini** sistemli şəkildə toplamaq üçün hazırlanıb. 
Əsas fokus **Enterprise Backend arxitekturası**, **verilənlər bazası idarəetməsi** və **API dizaynı** üzərindədir.  
Portfolio kimi istifadə olunduğu üçün struktur və izahlar peşəkar səviyyədədir.

---

## 🧱 Reponun strukturu
Bu repo **bir neçə müstəqil .NET solution**-dan ibarətdir. Hər qovluq ayrıca layihə və mövzuya fokuslanır:

- `FirstApiApp` — REST API əsasları
- `OnionArchApp` — Onion/Clean Architecture təcrübəsi
- `PustokApp`, `MenuApp`, `EternaApp`, `MentorApp` — CRUD, DI, Auth, Repo Pattern
- `RazorPagesApp`, `TagHelpersExample` — UI layer (Razor Pages/TagHelpers)
- `MessageBrokersMQ` — message broker inteqrasiyası

> Hər layihənin daxilində öz `.sln` faylı mövcuddur və müstəqil şəkildə işlədilir.

---

## 🧰 Texnologiyalar
- **ASP.NET Core** (Web API, Middleware, DI)
- **Entity Framework Core** (Code First, Migrations)
- **MS SQL / PostgreSQL**
- **JWT Authentication & Authorization**
- **Swagger / OpenAPI**
- **Clean Architecture / N-Tier**
- **Repository Pattern & Unit of Work**

---

## 🧭 Syllabus / Curriculum

| Həftə / Mövzu | Məzmun | Texnologiyalar | Repo nümunələri |
|---|---|---|---|
| 1 | C#, OOP və SOLID prinsipləri | C#, .NET | — |
| 2 | ASP.NET Core əsasları (Routing, Controllers, DI) | ASP.NET Core, Swagger | `FirstApiApp` |
| 3 | EF Core ilə CRUD, DbContext, Migrations | EF Core, MS SQL | `PustokApp`, `MenuApp` |
| 4 | Repository Pattern, Unit of Work, Validation | EF Core, LINQ | `EternaApp` |
| 5 | Authentication & Authorization (Identity, JWT) | ASP.NET Core Identity, JWT | `MentorApp` |
| 6 | Clean/Onion Architecture və Layering | Clean Architecture | `OnionArchApp` |
| 7 | Razor Pages, TagHelpers, ViewModel | Razor Pages, TagHelpers | `RazorPagesApp`, `TagHelpersExample` |
| 8 | Message Brokers və async inteqrasiya | MQ (Message Brokers) | `MessageBrokersMQ` |

---

## 🏗️ Architecture & Design
Layihələrdə tipik olaraq aşağıdakı layer strukturu tətbiq olunur:

- **Core** — Domain Entities, DTO-lar, Interface-lər
- **Data / Infrastructure** — EF Core, Repository-lər, Migrations
- **Business / Application** — Service layer, Use-Case-lər, Validation
- **WebAPI / Presentation** — Controllers, Middleware, Swagger, JWT config

> Məqsəd: asılılıqları aşağı layer-lara yönəltmək, test oluna bilən və genişlənə bilən arxitektura qurmaqdır.

---

## ⚙️ Prerequisites & Setup

### 1) Tələb olunanlar
- **.NET SDK** (8.0+)
- **MS SQL Server** və ya **PostgreSQL**
- `dotnet-ef` (EF Core CLI)

```bash
dotnet tool install --global dotnet-ef
```

### 2) Connection String tənzimlənməsi
Layihənin `appsettings.json` və ya `appsettings.Development.json` faylında:

```json
{
  "ConnectionStrings": {
    "Default": "Server=localhost;Database=BackendTasksDb;User Id=sa;Password=YourPassword;TrustServerCertificate=True;"
  },
  "JwtSettings": {
    "Issuer": "BackendTasks",
    "Audience": "BackendTasks",
    "Key": "YourStrongJwtKeyHere"
  }
}
```

**PostgreSQL üçün nümunə:**
```
Host=localhost;Database=BackendTasksDb;Username=postgres;Password=YourPassword;
```

### 3) Migration və DB update
Layihə strukturuna uyğun olaraq `Data/Infrastructure` layihəsini, startup üçün isə `WebAPI/Presentation` layihəsini istifadə edin:

```bash
dotnet ef migrations add InitialCreate \
  --project <DataProjectPath> \
  --startup-project <WebApiProjectPath>

dotnet ef database update \
  --project <DataProjectPath> \
  --startup-project <WebApiProjectPath>
```

### 4) Layihənin işə salınması
```bash
dotnet restore
dotnet run --project <WebApiProjectPath>
```

### 5) Swagger UI
Brauzerdə aşağıdakı ünvana daxil olun:
```
https://localhost:5001/swagger
```

---

## ✅ Nəticə
Bu repository **senior səviyyəli backend konseptlərini** real kod nümunələri ilə tətbiq etmək üçün hazırlanıb.  
Hər bölmə akademiyada öyrəndiyim mövzuları **praktik və real layihə strukturu** ilə birləşdirir.

---

## 📌 Qısa qeydlər
- Hər layihə müstəqil işlədilir, ayrıca `appsettings` konfiqurasiyası ola bilər.
- İstifadə olunan DB, port və JWT parametrləri layihəyə görə fərqlənə bilər.

