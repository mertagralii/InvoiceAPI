using AutoMapper;
using InvoiceAPI.Data.Context;
using InvoiceAPI.Data.Dto;
using InvoiceAPI.Data.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace InvoiceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvoiceController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public InvoiceController(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet("[action]")]
        public IActionResult ListInvoice()
        {
            
            var invoices = _context.Invoices
                .Include(x => x.Customer)
                .Include(x=> x.Status)
                .Include(x=> x.InvoiceItems)
                .ToList();
            
            var result = _mapper.Map<List<InvoiceDto>>(invoices);
            
            if (invoices == null)
            {
                return NotFound();
            }
            return Ok(result);

        }

        [HttpPost("[action]")]
        public IActionResult AddInvoice([FromBody] InvoiceCreateDto model)
        { 
            var selectedCustomer =_context.Customers.FirstOrDefault(x=> x.Id == model.CustomerId);
            if (selectedCustomer == null)
            {
                return BadRequest("Customer not found");
            }
            // Statuslar başlangıçta eklenirker herbiri "Pending" olarak kalmasını istediğim içim Id' değerini 1 verdim.
            var invoice = _mapper.Map<Invoice>(model);
            invoice.StatusId = 1;
            _context.Invoices.Add(invoice);
            _context.SaveChanges();
            var result = _mapper.Map<InvoiceCreateDto>(invoice);
            return Ok(result);
        }

        [HttpPut("[action]")]
        public IActionResult UpdateInvoice(int id, [FromBody] InvoiceCreateDto model)
        {
            // TODO: ItemList Kısmı Güncellenmiyor. Ekleme Yapıyor
            
            var selectedInvoice = _context.Invoices.Find(id);

            if (selectedInvoice == null)
            {
                return NotFound("Invoice not found");
            }
            _mapper.Map(model, selectedInvoice);
            _context.SaveChanges();
            var result = _mapper.Map<InvoiceCreateDto>(selectedInvoice);
            return Ok(result);
            
        }

        [HttpDelete("[action]")]
        public IActionResult DeleteInvoice(int id)
        {
                 var getInvoice = _context.Invoices
                .Include(x => x.Customer)
                .Include(x => x.Status)
                .Include(x => x.InvoiceItems)
                .FirstOrDefault(x => x.Id == id);
            if (getInvoice == null)
            {
                return NotFound("Invoice not found");
            }
            
            _context.Invoices.Remove(getInvoice);
            _context.SaveChanges();
            return Ok("Silme İşlemi Gerçekleşti");
        }

        [HttpGet("[action]")]
        public IActionResult GetInvoiceDetail(int id)
        {
            // TODO : ItemList Kısmında otomatik olarak toplama işlemini yapamadım. Burayı soracağım.
            var getInvoice = _context.Invoices
                .Include(x => x.Customer)
                .Include(x => x.Status)
                .Include(x => x.InvoiceItems)
                .FirstOrDefault(x => x.Id == id);
            if (getInvoice == null)
            {
                return NotFound("Invoice not found");
            }
            var result = _mapper.Map<InvoiceDto>(getInvoice);
            return Ok(result);
        }

        [HttpPut("[action]")]
        public IActionResult ChangeInvoiceStatus(int id)
        {
            var selectedInvoice = _context.Invoices.Find(id);
            if (selectedInvoice == null)
            {
                return NotFound("Invoice not found");
            }
            selectedInvoice.StatusId = 2;
            _context.SaveChanges();
            return Ok(selectedInvoice);
        }
    }
}
