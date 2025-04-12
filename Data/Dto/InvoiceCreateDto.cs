using InvoiceAPI.Data.Entities;

namespace InvoiceAPI.Data.Dto;

public class InvoiceCreateDto
{
    public string Adress { get; set; }

    public string City { get; set; }

    public string PostCode { get; set; }

    public string County { get; set; }

    public DateTime InvoiceDate { get; set; }

    public string PaymentTerms { get; set; }

    public string ProductDescription { get; set; }

    public int CustomerId { get; set; }
    
    public List<InvoiceItemCreateDto> InvoiceItems { get; set; }
}