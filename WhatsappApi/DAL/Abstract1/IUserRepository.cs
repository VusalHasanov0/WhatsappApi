using WhatsappApi.Entites;

namespace WhatsappApi.DAL.Abstract1
{
    public interface IUserRepository
    {
        void AddUser(User user);
        void UpdateUser(string name ,User user);
        void DeleteUser(string name);
        User GetUser(string name);
        List<User> GetAllUsers();
    }
}
