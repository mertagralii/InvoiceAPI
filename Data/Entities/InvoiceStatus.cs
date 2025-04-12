namespace InvoiceAPI.Data.Entities;

public class InvoiceStatus
{
    public int Id { get; set; }

    public string Name { get; set; }

    public List<Invoice> Invoices { get; set; }
}