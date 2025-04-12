using InvoiceAPI.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace InvoiceAPI.Data.Context;

public class AppDbContext : DbContext
{
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Invoice> Invoices { get; set; }
    public DbSet<InvoiceItem> InvoiceItems { get; set; }
    public DbSet<InvoiceStatus> InvoiceStatuses { get; set; }
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        
    }
    
}