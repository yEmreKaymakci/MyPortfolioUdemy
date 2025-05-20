# 🎓 MyPortfolioUdemy – ASP.NET Core Çok Katmanlı Mimari Projesi

**MyPortfolioUdemy**, ASP.NET Core MVC 8.0 kullanılarak geliştirilmiş, **çok katmanlı mimari** prensiplerine uygun, eğitim ve portföy amaçlı bir projedir. Bu proje ile hem **Code First yaklaşımı** hem de API geliştirme becerileri sergilenmiştir. Aynı zamanda yönetici paneli ve kullanıcıya açık vitrin kısmı bulunmaktadır.

## 🎯 Projenin Amacı

- ASP.NET Core'da çok katmanlı mimari pratiği yapmak
- Entity Framework Core ile Code First yaklaşımını uygulamak
- RESTful API geliştirme becerilerini göstermek
- Admin paneli ile içerik yönetimini gerçekleştirmek
---

## 🚀 Kullanılan Teknolojiler

### Backend
- **ASP.NET Core 8.0 MVC**
- **C#**
- **Entity Framework Core 8** (Code First)
- **MSSQL Server**
- **Swagger** (isteğe bağlı)

### Frontend
- **HTML / CSS**
- **Bootstrap 5**
- **JavaScript**
- **Partial View / ViewComponent**

---

Admin Paneli


![Ekran görüntüsü 2025-05-20 130606](https://github.com/user-attachments/assets/bce66997-b598-45cc-b6ef-d08069eaaec2)
![Ekran görüntüsü 2025-05-20 130618](https://github.com/user-attachments/assets/7b631e35-3558-4b19-903e-ae1339bf38b6)
![Ekran görüntüsü 2025-05-20 130637](https://github.com/user-attachments/assets/4c8799a2-d104-45d9-a5ce-57ffd63579f4)

Porfolyo Sayfası


![Ekran görüntüsü 2025-05-20 130707](https://github.com/user-attachments/assets/343f9194-f591-430d-8037-cff1ba3e8351)
![Ekran görüntüsü 2025-05-20 130723](https://github.com/user-attachments/assets/c9e16295-9591-471c-bec8-f00c26167c2e)

## 🧱 Proje Yapısı (Katmanlı Mimarisi)

```plaintext
├── Entities         → Veritabanı modelleri
├── DataAccess       → DbContext ve Repository işlemleri
├── Business         → Servis katmanı (iş mantığı)
├── DTOs             → Data Transfer Objects
├── API              → RESTful servisler
└── WebUI            → Admin panel (MVC yapısı)
