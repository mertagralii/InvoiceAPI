namespace InvoiceAPI.Data.Dto;

public class InvoiceItemCreateDto
{
    public string ItemName { get; set; }

    public int Quantity { get; set; }

   
    public decimal Price { get; set; }
    
    public decimal TotalPrice { get; set; }
}