using Microsoft.EntityFrameworkCore;
using WhatsappApi.DAL.Abstract1;
using WhatsappApi.DAL.DataContexts;
using WhatsappApi.Entites;

namespace WhatsappApi.DAL.Concrete
{
    public class MessageRepository : IMessageRepository
    {
        private readonly WhatsappContext _whatsappContext;
        public MessageRepository(WhatsappContext whatsappContext)
        {
            _whatsappContext = whatsappContext;
        }
        public void AddMessage(Message message)
        {
            var contactControl = _whatsappContext.Contacts.FirstOrDefault(c=>c.ContactId == message.ContactId);
            var userControl = _whatsappContext.Users.FirstOrDefault(c => c.UserId == message.UserId);
            _whatsappContext.Add(message);
            _whatsappContext.SaveChanges();
        }

        public Contact ControlContact(int contactId)
        {
            return _whatsappContext.Contacts.SingleOrDefault(c => c.ContactId == contactId);
        }

        public void DeleteMessage(int Id)
        {
            Message message = _whatsappContext.Messages.First(c=>c.Id == Id);   
            _whatsappContext.Messages.Remove(message);
            _whatsappContext.SaveChanges();
        }

        public List<Message> GetAllMessageUser(int userId)
        {
            return _whatsappContext.Messages.Where(m=>m.UserId == userId).ToList();
        }
    }
}
