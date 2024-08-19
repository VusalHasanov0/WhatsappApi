using AutoMapper;
using WhatsappApi.BLL.Abstract;
using WhatsappApi.DAL.Abstract1;
using WhatsappApi.DTO.ContactDtos;
using WhatsappApi.DTO.UserDtos;
using WhatsappApi.Entites;

namespace WhatsappApi.BLL.Concrete
{
    
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UserService(IUserRepository userRepository,IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public void Add(UserToAddDto user)
        {
            var data = _mapper.Map<User>(user);
            _userRepository.AddUser(data);
        }

        public void Delete(string name)
        {
            _userRepository.DeleteUser(name);
        }

        public List<User> GetAll()
        {
            return _userRepository.GetAllUsers();
        }

        public void Update(string name, UserToUpdateDto user)
        {
            var data = _mapper.Map<User>(user);
            _userRepository.UpdateUser(name, data);
        }
    }
}
