using AutoMapper;
using BusinessLogic.Models;
using DataAccess.Models;

namespace BusinessLogic.AutoMapperProfile
{
    public class BusinessLogicProfile : Profile
    {
        public BusinessLogicProfile()
        {
            CreateMap<UserRto, UserInformationBlo>()
                 .ForMember(x => x.Id, x => x.MapFrom(m => m.Id))
                 .ForMember(x => x.Birthday, x => x.MapFrom(m => m.Birthday))
                 .ForMember(x => x.LastName, x => x.MapFrom(m => m.LastName))
                 .ForMember(x => x.FirstName, x => x.MapFrom(m => m.FirstName))
                 .ForMember(x => x.Patronymic, x => x.MapFrom(m => m.Patronymic))
                 .ForMember(x => x.Email, x => x.MapFrom(m => m.Email))
                 .ForMember(x => x.PhoneNumberPrefix, x => x.MapFrom(m => m.PhoneNumberPrefix))
                 .ForMember(x => x.PhoneNumber, x => x.MapFrom(m => m.PhoneNumber))
                 .ForMember(x => x.IsBoy, x => x.MapFrom(m => m.IsBoy))
                 .ForMember(x => x.AvatarUrl, x => x.MapFrom(m => m.AvatarUrl));

        }
    }
}
