using AutoMapper;
using InvoiceAPI.Data.Dto;
using InvoiceAPI.Data.Entities;

namespace InvoiceAPI;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Invoice, InvoiceDto>().ReverseMap();
        CreateMap<Customer, CustomerDto>().ReverseMap();
        CreateMap<InvoiceStatus, InoviceStatusDto>().ReverseMap();
        CreateMap<InoviceStatusDto,InvoiceDto>().ReverseMap();
        CreateMap<InvoiceItemDto, InvoiceItem>().ReverseMap();
        CreateMap<InvoiceItemDto,InvoiceDto>().ReverseMap();
        CreateMap<InvoiceCreateDto, Invoice>().ReverseMap();
        CreateMap<InvoiceItem, InvoiceItemCreateDto>().ReverseMap();
        CreateMap<Customer, CustomerCreateDto>().ReverseMap();
    }
    
}