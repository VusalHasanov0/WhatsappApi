using WhatsappApi.Entites;

namespace WhatsappApi.DAL.Abstract1
{
    public interface IContactRepository
    {
        void AddContact(Contact contact);
        void UpdateContact(string name ,Contact contact);
        void DeleteContact(int userId,string name);
        List<Contact> GetAll();
        Contact GetContact(string name);
    }
}
