using AutoMapper;
using InvoiceAPI.Data.Context;
using InvoiceAPI.Data.Dto;
using InvoiceAPI.Data.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.DotNet.Scaffolding.Shared.Messaging;

namespace InvoiceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public CustomerController(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet("[action]")]
        public IActionResult ListCustomers()
        {
            var customers = _context.Customers.ToList();
            if (customers == null)
            {
                return NotFound();
            }
            return Ok(customers);
        }

        [HttpPost("[action]")]
        public IActionResult CreateCustomer([FromBody] CustomerCreateDto model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Model is not valid");
            }
            var customer = _mapper.Map<Customer>(model);
            var addedCustomer=_context.Customers.Add(customer);
            if (addedCustomer == null)
            {
                return BadRequest();
            }
            _context.SaveChanges();
            return Ok(customer);
        }

        [HttpPut("[action]")]
        public IActionResult UpdateCustomer(int id,[FromBody] CustomerCreateDto model)
        {
            var selectedCustomer = _context.Customers.Find(id);
            if (selectedCustomer == null)
            {
                return NotFound();
            }
            if (!ModelState.IsValid)
            {
                return BadRequest("Model is not valid");
            }
            
            // Manuel Olarak Güncelleme İşlemi 
            
            // selectedCustomer.FullName = model.FullName;
            // selectedCustomer.Email = model.Email;
            // selectedCustomer.Adress = model.Adress;
            // selectedCustomer.PostCode = model.PostCode;
            // selectedCustomer.Country = model.Country;
            // _context.SaveChanges();
            
            // Mapper ile güncelleme işlemi 
            
            _mapper.Map(model, selectedCustomer);
            _context.SaveChanges();
            return Ok(selectedCustomer);
        }

        [HttpDelete("[action]")]
        public IActionResult DeleteCustomer(int id)
        {
            var selectedCustomer = _context.Customers.Find(id);
            if (selectedCustomer == null)
            {
                return NotFound();
            }
            _context.Customers.Remove(selectedCustomer);
            _context.SaveChanges();
            return Ok(selectedCustomer);
        }

        [HttpGet("[action]")]
        public IActionResult GetCustomers(int Id)
        {
            var getCustomers = _context.Customers.Where(x => x.Id == Id);
            if (getCustomers == null)
            {
                return NotFound();
            }
            return Ok(getCustomers);
        }
    }
}
