using AutoMapper;

namespace ApiBackEnd_Customers.Mappings
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            CreateMap<Customer, CustomerDto>()
                .ForMember(dest => dest.IdUserInf, act => act.MapFrom(src => src.IdCustomer))
                .ForMember(dest => dest.UserInf, act => act.MapFrom(src => src.User))
                .ForMember(dest => dest.NameInf, act => act.MapFrom(src => src.Name))
                .ForMember(dest => dest.TitleInf, act => act.MapFrom(src => src.Title))
                .ForMember(dest => dest.CellphoneInf, act => act.MapFrom(src => src.Cellphone))
                .ForMember(dest => dest.EmailInf, act => act.MapFrom(src => src.Email))
                .ForMember(dest => dest.ContactTypeInf, act => act.MapFrom(src => src.ContactType));

            CreateMap<CustomerDto, Customer>()
            .ForMember(dest => dest.User, act => act.MapFrom(src => src.UserInf))
            .ForMember(dest => dest.Name, act => act.MapFrom(src => src.NameInf))
            .ForMember(dest => dest.Title, act => act.MapFrom(src => src.TitleInf))
            .ForMember(dest => dest.Cellphone, act => act.MapFrom(src => src.CellphoneInf))
            .ForMember(dest => dest.Email, act => act.MapFrom(src => src.EmailInf))
            .ForMember(dest => dest.ContactType, act => act.MapFrom(src => src.ContactTypeInf));
        }
    }
}
