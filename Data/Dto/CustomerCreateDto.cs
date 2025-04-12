using Microsoft.Build.Framework;

namespace InvoiceAPI.Data.Dto;

public class CustomerCreateDto
{
    [Required]
    public string FullName { get; set; }
    [Required]
    public string Email { get; set; }
    [Required]
    public string Adress { get; set; }
    [Required]
    public string City { get; set; }
    [Required]
    public string PostCode { get; set; }
    [Required]
    public string Country { get; set; }
}