using AutoMapper;
using WhatsappApi.BLL.Abstract;
using WhatsappApi.DAL.Abstract1;
using WhatsappApi.DTO.ContactDtos;
using WhatsappApi.DTO.MessageDtos;
using WhatsappApi.Entites;

namespace WhatsappApi.BLL.Concrete
{
    public class MessageService : IMessageService
    {
        private readonly IMessageRepository _messageRepository;
        private readonly IMapper _mapper;

        public MessageService(IMessageRepository messageRepository, IMapper mapper)
        {
            _messageRepository = messageRepository;
            _mapper = mapper;
        }
        public void AddMessage(int userId, int contactId, string content)
        {

            var contact = _messageRepository.ControlContact(contactId);
            if (contact == null || contact.UserId != userId)
            {
                throw new UnauthorizedAccessException("Bu contact size ait değil.");
            }
            
            
           
            var data = new Message
            {
                UserId = userId,
                ContactId = contactId,
                Content = content,
                SentAt = DateTime.UtcNow,
            };

            _messageRepository.AddMessage(data);
            

        }

        public void DeleteMessage(int userId)
        {
            _messageRepository.DeleteMessage(userId);
        }

        public List<MessageToListDto> GetAllMessageUser(int userId)
        {

            return _mapper.Map<List<MessageToListDto>>(_messageRepository.GetAllMessageUser(userId));
                /*_messageRepository.GetAllMessageUser(userId);*/
        }
    }
}
