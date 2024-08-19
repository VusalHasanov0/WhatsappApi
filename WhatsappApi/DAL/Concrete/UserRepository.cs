using Microsoft.AspNetCore.Http.HttpResults;
using WhatsappApi.DAL.Abstract1;
using WhatsappApi.DAL.DataContexts;
using WhatsappApi.Entites;

namespace WhatsappApi.DAL.Concrete
{
    public class UserRepository : IUserRepository
    {
        private readonly WhatsappContext _whatsappContext;

        public UserRepository(WhatsappContext whatsappContext)
        {
            _whatsappContext = whatsappContext;   
        }
        public void AddUser(User user)
        {
            _whatsappContext.Users.Add(user);
            _whatsappContext.SaveChanges();
        }

        public void DeleteUser(string name)
        {
            var data = _whatsappContext.Users.First(x => x.Name == name);
            _whatsappContext.Users.Remove(data);
            _whatsappContext.SaveChanges();
        }

        public List<User> GetAllUsers()
        {
            return _whatsappContext.Users.ToList();
        }

        public User GetUser(string name)
        {
            return _whatsappContext.Users.First(x => x.Name == name);
        }

        public void UpdateUser(string name, User user)
        {
            var data = _whatsappContext.Users.First(x => x.Name == name);
            data.Name = user.Name ;
            _whatsappContext.Update(data);
            _whatsappContext.SaveChanges();

        }
    }
}
