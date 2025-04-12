namespace InvoiceAPI.Data.Entities;

public class Invoice
{
    public int Id { get; set; }

    public int StatusId { get; set; }
    public InvoiceStatus Status { get; set; }

    public string Adress { get; set; }

    public string City { get; set; }

    public string PostCode { get; set; }

    public string County { get; set; }

    public DateTime InvoiceDate { get; set; }

    public string PaymentTerms { get; set; }

    public string ProductDescription { get; set; }

    public int CustomerId { get; set; }
    public Customer Customer { get; set; }
    
    public List<InvoiceItem> InvoiceItems { get; set; }
}