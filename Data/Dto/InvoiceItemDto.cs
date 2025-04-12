using Microsoft.EntityFrameworkCore;

namespace InvoiceAPI.Data.Dto;

public class InvoiceItemDto
{
    public string ItemName { get; set; }

    public int Quantity { get; set; }

    [Precision(18,2)]  // Ondalığın kaç karakter olduğunu ayarlar (Kuruşu 2 karakter ayarlar)
    public decimal Price { get; set; }
    [Precision(18,2)]
    public decimal TotalPrice { get; set; }
}