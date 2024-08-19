using WhatsappApi.DTO.MessageDtos;
using WhatsappApi.Entites;

namespace WhatsappApi.BLL.Abstract
{
    public interface IMessageService
    {
        void AddMessage(int userId,int contactId,string content);
        List<MessageToListDto> GetAllMessageUser(int userId);
        void DeleteMessage(int userId);
    }
}
