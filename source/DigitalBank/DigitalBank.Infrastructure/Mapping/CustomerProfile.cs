using AutoMapper;
using DigitalBank.Domain.Entities;
using DigitalBank.Infrastructure.ViewModel;

namespace DigitalBank.Infrastructure.Mapping
{
    public class CustomerProfile : Profile
    {
        public CustomerProfile()
        {
            CreateMap<CustomerDto, Customer>()
                .ForMember(dest => dest.CustomerId,
                        opt => opt.MapFrom(src => src.CustomerId))
                .ReverseMap();
        }
    }
}
