using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using YourBook.Dtos;
using YourBook.Models;

namespace YourBook.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<CustomerDto, Customer>();
            Mapper.CreateMap<Book, BookDto>();
            Mapper.CreateMap<CustomerDto, Customer>()
               .ForMember(c => c.Id, opt => opt.Ignore());

            Mapper.CreateMap<BookDto, Book>()
                .ForMember(c => c.Id, opt => opt.Ignore());
        }

    }
}