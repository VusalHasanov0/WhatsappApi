using WhatsappApi.DAL.Abstract1;
using WhatsappApi.DAL.DataContexts;
using WhatsappApi.Entites;

namespace WhatsappApi.DAL.Concrete
{
    public class ContactRepositroy : IContactRepository
    {
        private readonly WhatsappContext _whatsappContext;

        public ContactRepositroy(WhatsappContext whatsappContext)
        {
            _whatsappContext = whatsappContext;
        }
        public void AddContact(Contact contact)
        {
            _whatsappContext.Contacts.Add(contact);
            _whatsappContext.SaveChanges();
        }

        public void DeleteContact(int userId,string name)
        {
            Contact contacts = _whatsappContext.Contacts.First(m => m.Name == name && m.UserId == userId);
            _whatsappContext.Contacts.Remove(contacts);
            _whatsappContext.SaveChanges();

        }

        public List<Contact> GetAll()
        {
            return _whatsappContext.Contacts.ToList();
        }

        public Contact GetContact(string name)
        {
            return _whatsappContext.Contacts.First(m => m.Name == name);

        }

        public void UpdateContact(string name, Contact contact)
        {
            Contact contacts = _whatsappContext.Contacts.First(m => m.Name == name);
            contacts.Name = contact.Name;
            contacts.PhoneNumber = contact.PhoneNumber;
            _whatsappContext.Update(contacts);
            _whatsappContext.SaveChanges();
        }
    }
}
