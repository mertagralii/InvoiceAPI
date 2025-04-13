using InvoiceAPI.Data.Entities;

namespace InvoiceAPI.Data.Dto;

public class InvoiceDto
{
    public int Id { get; set; }

    public int StatusId { get; set; }
    public InoviceStatusDto Status { get; set; }

    public string Adress { get; set; }

    public string City { get; set; }

    public string PostCode { get; set; }

    public string County { get; set; }

    public DateTime InvoiceDate { get; set; }

    public string PaymentTerms { get; set; }

    public string ProductDescription { get; set; }
    
    public decimal TotalPrice { get; set; }

    public int CustomerId { get; set; }
    public CustomerDto Customer { get; set; }
    
    public List<InvoiceItemDto> InvoiceItems { get; set; }
}