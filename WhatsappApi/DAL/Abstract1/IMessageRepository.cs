using WhatsappApi.Entites;

namespace WhatsappApi.DAL.Abstract1
{
    public interface IMessageRepository
    {
        void AddMessage(Message message);
        List<Message> GetAllMessageUser(int userId);
        Contact ControlContact(int contactId);

        void DeleteMessage(int id);

    }
}
