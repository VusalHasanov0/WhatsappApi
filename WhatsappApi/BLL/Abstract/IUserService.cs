using WhatsappApi.DTO.ContactDtos;
using WhatsappApi.DTO.UserDtos;
using WhatsappApi.Entites;

namespace WhatsappApi.BLL.Abstract
{
    public interface IUserService
    {
        void Add(UserToAddDto user);
        void Update(string name , UserToUpdateDto user);
        void Delete(string name);
        List<User> GetAll();
    }
}
