using WhatsappApi.DTO.ContactDtos;
using WhatsappApi.Entites;

namespace WhatsappApi.BLL.Abstract
{
    public interface IContactService
    {
        void Add(ContactToAddDto dto);  
        void Update(string name, ContactToUpdateDto dto);
        void Delete(int userId,string name);
        ContactToListDto Get(string name);
        List<ContactToListDto> GetAll(); 
    }
}
