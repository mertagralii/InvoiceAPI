# 💼 InvoiceAPI

**InvoiceAPI**, ASP.NET Core MVC kullanılarak geliştirilmiş bir fatura yönetim sistemidir. Bu API, kullanıcıların fatura oluşturma, listeleme, güncelleme ve silme işlemlerini gerçekleştirmelerine olanak tanır. Proje, Entity Framework Core ile veritabanı işlemlerini yönetir ve RESTful mimariye uygun olarak tasarlanmıştır.  

---

## 🚀 Özellikler

- 🧾 Fatura oluşturma, listeleme, güncelleme ve silme  
- 💾 Entity Framework Core ile veritabanı yönetimi  
- 🌐 RESTful API tasarımı  
- 🧱 Katmanlı mimari yapısı  
- 🔄 AutoMapper entegrasyonu  

---

## 🛠️ Kullanılan Teknolojiler

- ⚙️ ASP.NET Core MVC  
- 🗃️ Entity Framework Core  
- 🔁 AutoMapper  
- 🧮 SQL Server  
- 🧑‍💻 Git & GitHub  

---

## ⚙️ Kurulum

1. 📥 Bu depoyu klonlayın:  
```bash
git clone https://github.com/mertagralii/InvoiceAPI.git
```

2. 📂 Proje dizinine gidin:  
```bash
cd InvoiceAPI
```

3. 📦 Gerekli bağımlılıkları yükleyin:  
```bash
dotnet restore
```

4. 🏗️ Veritabanını oluşturun ve göçleri uygulayın:  
```bash
dotnet ef database update
```

5. ▶️ Uygulamayı başlatın:  
```bash
dotnet run
```

---

## 📡 API Kullanımı

### ➕ Fatura Oluşturma

- **Endpoint:** `POST /api/invoices`

- **İstek Gövdesi:**
```json
{
  "customerName": "John Doe",
  "amount": 1500.00,
  "dueDate": "2025-05-15"
}
```

- **Yanıt:**
```json
{
  "id": 1,
  "customerName": "John Doe",
  "amount": 1500.00,
  "dueDate": "2025-05-15",
  "status": "Pending"
}
```

---

### 📋 Fatura Listeleme

- **Endpoint:** `GET /api/invoices`

- **Yanıt:**
```json
[
  {
    "id": 1,
    "customerName": "John Doe",
    "amount": 1500.00,
    "dueDate": "2025-05-15",
    "status": "Pending"
  },
  {
    "id": 2,
    "customerName": "Jane Smith",
    "amount": 2000.00,
    "dueDate": "2025-06-01",
    "status": "Paid"
  }
]
```

---

## 🤝 Katkıda Bulunma

Katkılar her zaman memnuniyetle karşılanır! 🙌  
Yeni bir özellik ya da iyileştirme eklemeden önce bir "issue" oluşturman yeterli 😉

---

## 📄 Lisans

Bu proje MIT lisansı ile lisanslanmıştır. Daha fazla bilgi için [LICENSE](LICENSE) dosyasına göz atabilirsin.
