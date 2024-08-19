using AutoMapper;
using WhatsappApi.DTO.ContactDtos;
using WhatsappApi.DTO.MessageDtos;
using WhatsappApi.DTO.UserDtos;
using WhatsappApi.Entites;

namespace WhatsappApi.BLL.Mapper
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<UserToAddDto, User>();
            CreateMap<UserToUpdateDto, User>();
            CreateMap<ContactToAddDto, Contact>();
            CreateMap<Contact, ContactToListDto > ();
            CreateMap<ContactToUpdateDto, Contact>();
            CreateMap<Message, MessageToListDto>();

        }
    }
}
