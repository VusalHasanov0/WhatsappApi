using AutoMapper;
using WhatsappApi.BLL.Abstract;
using WhatsappApi.DAL.Abstract1;
using WhatsappApi.DTO.ContactDtos;
using WhatsappApi.Entites;

namespace WhatsappApi.BLL.Concrete
{
    public class ContactService : IContactService
    {
        private readonly IContactRepository _contactRepository;
        private readonly IMapper _mapper;
        public ContactService(IContactRepository contactRepository,IMapper mapper)
        {
            _contactRepository = contactRepository;
            _mapper = mapper;
        }
        public void Add(ContactToAddDto contact)
        {
            //var data = _mapper.Map<Contact>(contact);
            var data = new Contact
            {
                 Name = contact.Name,
                 PhoneNumber = contact.PhoneNumber,
                 UserId = contact.UserId,
            };
            _contactRepository.AddContact(data);
        }

        public void Delete(int userId, string name)
        {
            _contactRepository.DeleteContact(userId,name);
        }

        public ContactToListDto Get(string name)
        {
            return _mapper.Map<ContactToListDto>(_contactRepository.GetContact(name));
            

        }

        public List<ContactToListDto> GetAll()
        {
            var datas = _contactRepository.GetAll();
            return _mapper.Map<List<ContactToListDto>>(datas);
        }

        public void Update(string name, ContactToUpdateDto dto)
        {
            Contact contact = _mapper.Map<Contact>(dto);
            _contactRepository.UpdateContact(name, contact);
        }
    }
}
