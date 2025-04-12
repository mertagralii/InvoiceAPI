using Microsoft.EntityFrameworkCore;

namespace InvoiceAPI.Data.Entities;

public class InvoiceItem
{
    public int Id { get; set; }

    public string ItemName { get; set; }

    public int Quantity { get; set; }

    [Precision(18,2)]  // Ondalığın kaç karakter olduğunu ayarlar (Kuruşu 2 karakter ayarlar)
    public decimal Price { get; set; }
    [Precision(18,2)]
    public decimal TotalPrice { get; set; }

    public int InvoiceId { get; set; }
    public Invoice Invoice { get; set; }
}